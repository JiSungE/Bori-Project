/* eslint-disable prettier/prettier */
import React, {useState} from 'react';
import {
  Image,
  Linking,
  NativeScrollEvent,
  NativeSyntheticEvent,
  ScrollView,
  Text,
  TouchableOpacity,
  View,
} from 'react-native';
import styles from '../styles/styles';

const SNS = [
  'https://i.ibb.co/7WYRtC0/image.png',
  'https://i.ibb.co/fpB6f6M/image.png',
  'https://i.ibb.co/sR51s3K/image.png',
];

const SNSURLS = [
  'https://youtu.be/yg3pr2HWj-Y',
  'https://www.facebook.com/woosong.univ',
  'https://blog.naver.com/woosong-univ/222972778607',
];

export const Sns = () => {
  const [imgActive, setImgActive] = useState(0);

  const onChange = (e: NativeSyntheticEvent<NativeScrollEvent>) => {
    const nextCurrent: number = Math.floor(
      e.nativeEvent.contentOffset.x / e.nativeEvent.layoutMeasurement.width,
    );
    if (nextCurrent < 0) {
      return;
    }
    setImgActive(nextCurrent);
  };

  return (
    <View>
      <View style={styles.center}>
        <Text style={styles.header}>SNS</Text>
        <Text style={styles.centerline} />
      </View>
      <View>
        <ScrollView
          onScroll={(event: any) => onChange(event)}
          showsHorizontalScrollIndicator={false}
          pagingEnabled
          horizontal>
          {SNS.map(e => (
            <TouchableOpacity
              activeOpacity={1}
              key={e + 'Touchable'}
              onPress={() => {
                Linking.openURL(SNSURLS[SNS.indexOf(e)]);
              }}>
              <Image
                key={e}
                resizeMode="stretch"
                style={styles.snsimg}
                source={{uri: e}}
              />
            </TouchableOpacity>
          ))}
        </ScrollView>

        <View style={styles.wrapDot}>
          {SNS.map((e, index) => (
            <Text
              key={e}
              style={imgActive === index ? styles.dotActive : styles.dot}>
              ●
            </Text>
          ))}
        </View>
      </View>
    </View>
  );
};
