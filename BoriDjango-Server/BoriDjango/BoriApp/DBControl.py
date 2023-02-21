import sys
import os
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))

from BoriApp.models import KeywordRank
from django.db import connection

# 키워드 정보를 데이터베이스에 저장하는 함수
def create_keyword(keyword:str, count:str):
    q:KeywordRank = KeywordRank(keyword=keyword, count = count)
    q.save()

# 키워드에 대한 카운트 숫자를 증가시키는 쿼리와 함수
def add_count(keyword:str):
    try:
        cursor = connection.cursor()
        select_query = f'select count from BoriApp_keywordrank where keyword = "{keyword}";'
        cursor.execute(select_query)
        stocks = cursor.fetchall()
        before_count = stocks[0][0]
        KeywordRank.objects.filter(keyword = keyword).update(count = before_count + 1)
    except:
        temp = str(keyword).upper()
        if(temp == 'NONE'):
            return
        # 데이터베이스에 없는 키워드 일 때 키워드를 생성하고 카운트를 증가 (nan or None은 패스)
        insert_query = f"insert into BoriApp_keywordrank values('{keyword}', 0);"
        cursor.execute(insert_query)
        #----------------------------
        select_query = f'select count from BoriApp_keywordrank where keyword = "{keyword}";'
        cursor.execute(select_query)
        stocks = cursor.fetchall()
        before_count = stocks[0][0]
        KeywordRank.objects.filter(keyword = keyword).update(count = before_count + 1)

# 검색 수가 많은 상위 3개를 데이터베이스에서 가져오는 쿼리와 함수
def get_top_three():
    try:
        cursor = connection.cursor()
        query = 'select keyword from BoriApp_keywordrank order by count desc limit 3;'
        result = cursor.execute(query)
        stocks = cursor.fetchall()
        return_data = {
            "First":stocks[0][0],
            "Second":stocks[1][0],
            "Third":stocks[2][0]
        }
        
        return return_data
    except:
        print("Failed")
