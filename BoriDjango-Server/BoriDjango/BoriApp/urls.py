from django.urls import path

from . import views

urlpatterns = [
    path('setting/', views.setting, name='setting'),
    path('question/', views.question, name='question'),
    path('create/', views.create_keyword, name='generate_keywords_in_database'),
    path('get/', views.get_top_three, name='get_top_three'),
    path('', views.test, name='test'),
]
