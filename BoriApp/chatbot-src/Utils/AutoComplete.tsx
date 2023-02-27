/* eslint-disable prettier/prettier */
/* eslint-disable semi */

/* eslint-disable react-native/no-inline-styles */
import React, {useEffect, useState} from 'react';
import {ScrollView, Text, TouchableOpacity, View} from 'react-native';

let sampleData = [''];
let Akey = 0;

// 자동완성 기능 (미완) 서버에서 받은 데이터를 통해 자동완성을 제공하는 컴포넌트
export const AutoComplete = ({text, ukey, addChattings}: any | string) => {
  text = text.toUpperCase(); // 상위 컴포넌트에서 받은 text를 response 데이터와 통일 시키기 위해 대문자로 변환
  const [autoComplete, setAutoComplete] = useState<string[]>([]);

  // 입력받은 text가 자동완성조건에 일치하는 지 검사 후 일치한다면 리스트에 추가
  useEffect(() => {
    let data: string[] = [];
    sampleData.some((value: string) => {
      if (value.includes(text)) {
        data.push(value);
      }
    });
    setAutoComplete(data);
  }, [text]);
  //2
  return (
    <>
      <ScrollView horizontal={true}>
        <View
          style={{
            alignItems: 'center',
            alignContent: 'center',
            flexDirection: 'row',
          }}>
          <View style={{marginBottom: 40}} />
          <View style={{alignItems: 'center', flexDirection: 'row'}}>
            {autoComplete.map(value => {
              return (
                <TouchableOpacity
                  onPress={() => {
                    addChattings(value);
                  }}
                  key={ukey + Akey++}
                  style={{
                    paddingHorizontal: 10,
                    borderRadius: 20,
                    backgroundColor: 'white',
                    marginBottom: 5,
                    borderWidth: 1,
                    borderColor: '#c7c7c7',
                    margin: 5,
                  }}>
                  <Text key={Akey++} style={{fontSize: 15}}>
                    {value}
                  </Text>
                </TouchableOpacity>
              );
            })}
          </View>
        </View>
      </ScrollView>
    </>
  );
};
