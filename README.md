# PoL(Power of Life)  

[![jump to our movie](RM_Materials/Youtube.png)](https://youtu.be/PpIDIxW8HEw)

## 製品概要  
### 人生  X  Tech    
  コロナ禍でも、健康で、生き生きとした生活を!  

### 背景(製品開発のきっかけ、課題等）  
  **「なにもやる気が起きない」**    
  COVID-19の影響で自宅にいる時間が増えたことで、生活リズムが崩れたり、元気が出なかったりすること、ありませんか?  
  私たちはそんな生活に活力を与えてくれるようなプロダクトを作りたいという想いを元に、人に元気を与えるための「PoL(Power of Life)」を製作しました。
### 製品説明（具体的な製品の説明）
 アラームやスケジュール管理、ごはん占いなどができる多機能アプリケーションです。  
また、コロナ禍で孤独感を感じている人に向けて、キャラクターが話しかけてくれる機能も搭載しました！  

### 特長  
#### 1. キャラクターが話しかけてくれる  
  - 時間によって、話しかけてくれる言葉が変わる  
  - さみしい心が癒される  

#### 2. 時間の管理をしてくれる  
  - アラーム、スケジュール管理機能を持っている  
  - 時間によって背景が変わり、家に引きこもっていても時間感覚が狂わない  

#### 3. 健康管理ができる  
  - 頭痛が低気圧によるものか、病気によるものか判断ができる  
  - 食事の提案をすることによって、食欲をそそる  

### 解決出来ること  
  不健康な習慣を減らしたり、心の闇を軽減したりすることで、自粛生活によって失われた活力を取り戻す  
### 今後の展望  
  - アラームとカーテンを連動させ、朝日によって気持ちの良い朝をむかえられるようにする  
  - ヘルスケアデータを収集するデバイスと組み合わせ、病気を予防したり、運動不足を解消したりする  
### 注力したこと（こだわり等）
  - キャラクターが自然なタイミングで瞬きをし、しゃべると口が動く  
  - 設定したアラーム、スケジュールが一目で確認できる  
  - 朝は明るく、夜は落ち着いた背景  


## 開発技術
### 活用した技術
#### API・データ
  - [Open JTalk](http://open-jtalk.sp.nitech.ac.jp)
  - [ミライ小町](https://github.com/Miraikomachi)

#### フレームワーク・ライブラリ・モジュール
  - [Unity](https://unity.com/ja)  
  - Visual C#  
  - .NET 4.x  
  - [DPS310 Library for Arduino](https://github.com/Infineon/DPS310-Pressure-Sensor)  

#### デバイス
  - [Infineon社製 XMC1100 XMCGo2](https://www.infineon.com/cms/de/product/evaluation-boards/kit_xmc_2go_xmc1100_v1/?redirId=115070#ispnTab9)  
  - [Infineon社製 DPS310](https://www.infineon.com/cms/en/product/evaluation-boards/s2go-pressure-dps310/?redirId=127963)


### 独自技術
#### ハッカソンで開発した独自機能・技術  
- 現在時刻と連動して背景が変わる [commit](https://github.com/jphacks/B_2001/commit/3db0f340965c268acc3151c9d684c7b3637329b0)  
- 気圧を測定し、低気圧かどうか判断させる [commit](https://github.com/jphacks/B_2001/commit/76ad428d1739135a666834d8ade85a165e6071eb)  
- スケジュールをJSONファイルで管理 [commit](https://github.com/jphacks/B_2001/commit/4ded93a43e4a9e7b3f2c716fa8ad30f1f1becfd0)  
- 現在時刻と比較し、アラームを鳴らす [commit](https://github.com/jphacks/B_2001/commit/b554d7ce4f901fa9b985c1e1a464ab59f51a5974)

#### 製品に取り入れた研究内容（データ・ソフトウェアなど）（※アカデミック部門の場合のみ提出必須）
