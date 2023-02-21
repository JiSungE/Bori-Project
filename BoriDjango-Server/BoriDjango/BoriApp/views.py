from django.shortcuts import render
from django.http import HttpResponse, JsonResponse
import sys
import os
# 내장 라이브러리인 sys, os를 사용해 절대경로를 추가하는 코드
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))))
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))
bori_path = sys.path[-2]
bori_django_path = sys.path[-1]

import BoriApp.ChatData as BData
import json
import pandas as pd
import tensorflow as tf
import torch
from chat_.utils.Preprocess import Preprocess
from chat_.models.intent.IntentModel import IntentModel
from chat_.qna.create_embedding_data import CreateEmbeddingData
from chat_.utils.FindAnswer import FindAnswer
import BoriApp.DBControl as DB
def create_keyword(request):
    body =  json.loads(request.body.decode('utf-8'))
    keyword:str = body["keyword"]
    count:str = body["count"]
    DB.create_keyword(keyword,count)
    return HttpResponse("Create Succes")

def setting(request):
    # # tensorflow gpu 메모리 할당
    # # tf는 시작시 메모리를 최대로 할당하기 때문에, 0번 GPU를 4GB 메모리만 사용하도록 설정했음.
    # AWS에서 할당받은 서버에는 GPU가 존재하지 않기에 주석처리 함

    # BData.gpus = tf.config.experimental.list_physical_devices('GPU')
    # if BData.gpus:
    #     try:
    #         tf.config.experimental.set_visible_devices(BData.gpus[0], 'GPU')
    #         tf.config.experimental.set_virtual_device_configuration(BData.gpus[0],
    #                         [tf.config.experimental.VirtualDeviceConfiguration(memory_limit=4096)])
    #     except RuntimeError as e:
    #         print(e)

    # 전처리 객체 생성
    BData.preprocess = Preprocess(word2index_dic=f'{bori_path}/chat_/chatbot_dict.bin',
                   userdic=f'{bori_path}/chat_/utils/user_dic.tsv')

    # 의도 파악 모델
    # BData.intent = IntentModel(model_name=f'{bori_path}/chat_/models/intent_model2.h5', preprocess=BData.preprocess)

    #CSV 파일 로드
    BData.df = pd.read_csv(f'{bori_path}/chat_/qna/answer_data.csv')

    # pt 파일 갱신 및 불러오기
    BData.create_embedding_data = CreateEmbeddingData(df=BData.df, preprocess=BData.preprocess)
    # BData.create_embedding_data.create_pt_file()
    BData.embedding_data = torch.load(f'{bori_path}/chat_/qna/embedding_data.pt')
    BData.find_answer = FindAnswer(BData.preprocess, BData.df, BData.embedding_data)

    return HttpResponse("Setting Complete")

def question(request):
    # JSON 형식에 request에서 question 데이터를 받아서 답변 받아오기
    body =  json.loads(request.body.decode('utf-8'))
    question:str = body["Q"]
    question = question.upper()
    selected_qes ,score, answer, success, url, keyword = BData.find_answer.search(question)

    if(answer == '답변이 아직 등록되지 않았어요.\n 최대한 빠른 시간내에 등록하겠습니다 :('):
        send_json_data_str = {
            "Query": selected_qes,
            "Answer": answer,
            "Success": success,
            "Score": str(score),
            'URL':url,
            "Keyword":'None'
        }
    else:
        send_json_data_str = {
            "Query": selected_qes,
            "Answer": answer,
            "Success": success,
            "Score": str(score),
            'URL':url,
            "Keyword":str(keyword)
        }
        if(send_json_data_str["Keyword"] != 'None'):
            DB.add_count(send_json_data_str["Keyword"])
    
    return JsonResponse(send_json_data_str)

# 검색어 상위 3개
def get_top_three(request):
    top_three = DB.get_top_three()
    return JsonResponse(top_three)

def test(request):
    return JsonResponse({'test':'test'})
