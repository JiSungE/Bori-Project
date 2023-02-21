from django.db import models
from django.utils import timezone

class KeywordRank(models.Model):
    keyword = models.CharField(max_length=100, null=False, primary_key=True)
    count = models.IntegerField()