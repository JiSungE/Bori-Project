import json
# /chatbot.py
import sys
import os
# 내장 라이브러리인 sys, os를 사용해 절대경로를 추가하는 코드
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))))
bori_path = sys.path[-1]
import threading
import json
import pandas as pd
import tensorflow as tf
import torch
from chat_.utils.Preprocess import Preprocess
from chat_.models.intent.IntentModel import IntentModel
from chat_.qna.create_embedding_data import CreateEmbeddingData
from chat_.utils.FindAnswer import FindAnswer

gpus:any
preprocess:Preprocess
intent:IntentModel
df:pd.DataFrame
create_embedding_data:CreateEmbeddingData
embedding_data:any
find_answer:FindAnswer