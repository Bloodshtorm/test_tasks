import requests
import vkbottle
from vkbottle import API
import asyncio
import time
from datetime import datetime

def take_1_post_access(data, code, accesstoken):
    session = requests.Session()

    whiledata = data

    while data['id'] == whiledata['id']:
        time.sleep(0.2)
        response = session.post(
        url="https://api.vk.com/method/execute",
        data={
            "code": code,
            "access_token": accesstoken,  
            "v": "5.131"
        }
        )
        print(datetime.now())
        if 'error' in response.json():
             return 'error'
        
        whiledata = response.json()['response']['items'][0]
        #print(datetime.now())
    print(datetime.now())
    return whiledata

async def main_access(post, access):
    api = API(token=access)
    try:                                                                             
         await api.wall.create_comment(owner_id=post['owner_id'], post_id=post['id'], message='Феликс–Сынмин–Чан–Джисон–Чонин–Чанбин')
    except vkbottle.VKAPIError:
         return 'error'


moscow_time = datetime.now()

while moscow_time.second < 59:
        moscow_time = datetime.now()
        if moscow_time.second == 59:
              code = """return API.wall.get({
                "domain": "drunktaste",
                "offset": 1,
                "count": 1,
                "v": "5.131"
                });"""
              
              # токен получить по ссылке https://oauth.vk.com/authorize?client_id=51571124&display=page&scope=wall&response_type=token&v=5.131 
              access_token = "vk1.a.kInGv_boygjLenic-9n5JIUySp93FP4defz293ZzEmF9IMHnLfchBHaYDVcdCxkCP1GpbUYpVNPtZXRtf7k3CZozBoCBHQwkuRt_NKXnLpau7l5eVpe1z_OWST42Z46pyI0vmfFQgTz-GW8wOg3OVw0Q_JA9g3_4qVxsRNCqnsPIvXxdfBQscC1E8gA3e-vfadKLCje0XYnOvGkSerJpNQ"
              
              response = requests.post(
                url="https://api.vk.com/method/execute",
                data={
                "code": code,
                "access_token": access_token,
                "v": "5.131"
                }
                )
              print(datetime.now())

              #start = time.time()
              data = response.json()['response']['items'][0]

              time.sleep(0.2)  

              one_post = take_1_post_access(data, code, access_token)
              while one_post == 'error':
                   one_post = take_1_post_access(data, code, access_token)

              post = asyncio.run(main(one_post, access_token))     
              while post == 'error':
                   post = asyncio.run(main_access(one_post, access_token))
                   
              print(datetime.now())