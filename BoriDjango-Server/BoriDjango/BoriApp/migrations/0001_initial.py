# Generated by Django 4.1.5 on 2023-01-06 12:00

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='KeywordRank',
            fields=[
                ('title', models.CharField(max_length=100, primary_key=True, serialize=False)),
                ('count', models.IntegerField(default=0, verbose_name='숫자')),
            ],
        ),
    ]
