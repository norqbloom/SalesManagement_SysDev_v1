/*顧客マスタ*/
SET IDENTITY_INSERT M_Client ON
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (1,4,N'上村電機',N'京都府京都市伏見区塩屋町3-9-95',N'077-672-6006',N'6128046',N'077-581-0164',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (2,1,N'萬田金融',N'大阪府大阪市西区北堀江1丁目22-3',N'06-8757-6267',N'5500014',N'06-8757-6267',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (3,1,N'宝田電機',N'大阪府大阪市中央区和泉町2-5-46',N'06-1423-1895',N'5720806',N'06-1374-4358',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (4,1,N'INATUGI',N'大阪府茨木市横江2-5-60',N'072-02-5171',N'5670044',N'072-018-0116',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (5,2,N'水野電機',N'大阪府豊中市末広町2-6-13',N'06-2096-0974',N'5600024',N'06-2434-2434',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (6,1,N'ショップ赤川',N'大阪府大阪市天王寺区上本町',N'090-1111-1111',N'5430001',N'06-1111-1111',0,null)
INSERT INTO M_Client (ClID,SoID,ClName,ClAddress,ClPhone,ClPostal,ClFAX,ClFlag,ClHidden)
VALUES (7,3,N'成田',N'奈良県御所市船路2-8-87',N'0746-0-1160',N'6392268',N'0746-0-1160',0,null)
SET IDENTITY_INSERT M_Client OFF

/*社員マスタ*/
SET IDENTITY_INSERT M_Employee ON
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(116,N'坂口 郁美',2,3,29389,N'0116',N'06-6813-5485',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(310,N'高谷春男',1,2,26744,N'0310',N'06-6356-8742',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(1002,N'日下部俊夫',1,2,33120,N'1002',N'06-6579-0622',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(1007,N'岸本芽生',3,2,35465,N'1007',N'075-425-3371',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(1111,N'奥村敦彦',4,3,31123,N'999',N'079-145-6121',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(1208,N'渋谷秋昴',5,2,34365,N'1208',N'0790-68-8043',0,null)
INSERT INTO M_Employee(EmID,EmName,SoID,PoID,EmHiredate,EmPassword,EmPhone,EmFlag,EmHidden)
VALUES(1227,N'生田徳次郎',1,1,23456,N'1227',N'06-3021-1630',0,null)
SET IDENTITY_INSERT M_Employee OFF

/*大分類マスタ*/
SET IDENTITY_INSERT M_MajorCassification ON
INSERT INTO M_MajorCassification(McID,McName,McFlag,McHidden)
VALUES(1,N'テレビ・レコーダー',0,null)
INSERT INTO M_MajorCassification(McID,McName,McFlag,McHidden)
VALUES(2,N'エアコン・冷蔵庫・洗濯機',0,null)
INSERT INTO M_MajorCassification(McID,McName,McFlag,McHidden)
VALUES(3,N'オーディオ・イヤホン・ヘッドホン',0,null)
INSERT INTO M_MajorCassification(McID,McName,McFlag,McHidden)
VALUES(4,N'携帯電話・スマートフォン',0,null)
SET IDENTITY_INSERT M_MajorCassification OFF

/*メーカーマスタ*/
SET IDENTITY_INSERT M_Maker ON
INSERT INTO M_Maker(MaID,MaName,MaAdress,MaPhone,MaPostal,MaFAX,MaFlag,MaHidden)
VALUES(1,N'Aメーカ',N'大阪',N'000-0000-0000',N'0000000',N'000-0000-0000',0,null)
INSERT INTO M_Maker(MaID,MaName,MaAdress,MaPhone,MaPostal,MaFAX,MaFlag,MaHidden)
VALUES(2,N'Bメーカ',N'京都',N'000-0000-0000',N'0000000',N'000-0000-0000',0,null)
INSERT INTO M_Maker(MaID,MaName,MaAdress,MaPhone,MaPostal,MaFAX,MaFlag,MaHidden)
VALUES(3,N'Cメーカ',N'和歌山',N'000-0000-0000',N'0000000',N'000-0000-0000',0,null)
INSERT INTO M_Maker(MaID,MaName,MaAdress,MaPhone,MaPostal,MaFAX,MaFlag,MaHidden)
VALUES(4,N'Dメーカ',N'滋賀',N'000-0000-0000',N'0000000',N'000-0000-0000',0,null)
SET IDENTITY_INSERT M_Maker OFF

/*役職マスタ*/
SET IDENTITY_INSERT M_Position ON
INSERT INTO M_Position(PoID,PoName,PoFlag,PoHidden)
VALUES(1,N'管理者',0,null)
INSERT INTO M_Position(PoID,PoName,PoFlag,PoHidden)
VALUES(2,N'営業',0,null)
INSERT INTO M_Position(PoID,PoName,PoFlag,PoHidden)
VALUES(3,N'物流',0,null)
SET IDENTITY_INSERT M_Position OFF

/*商品マスタ*/
SET IDENTITY_INSERT M_Product ON
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(1,1,N'テレビA',100000,null,100,1,null,N'黒',N'2019/05/01',0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(2,1,N'テレビB',98000,null,100,1,null,N'黒',43595,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(3,1,N'レコーダーA',5000,null,50,2,null,N'黒',43739,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(4,2,N'エアコンA',160000,null,50,3,null,N'白',44105,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(5,2,N'冷蔵庫A',200000,null,50,4,null,N'白',43831,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(6,2,N'洗濯機A',150000,null,50,5,null,N'白',43525,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(7,3,N'オーディオA',6000,null,10,6,null,N'黒',44044,0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(8,3,N'イヤホンA',5000,null,100,7,null,N'赤',N'2019/05/01',0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(9,4,N'iphone8',78800,null,50,9,null,N'ゴールド',43000,2,N'メーカー販売中止')
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(10,4,N'スマートフォンA',30000,null,50,10,null,N'シルバー',N'2019/05/01',0,null)
INSERT INTO M_Product(PrID,MaID,PrName,Price,PrJCode,PrSafetyStock,ScID,PrModelNumber,PrColor,PrReleaseDate,PrFlag,PrHidden)
VALUES(11,4,N'スマートフォンB',40000,null,50,10,null,N'黒',44136,0,null)
SET IDENTITY_INSERT M_Product OFF

/*営業所マスタ*/
SET IDENTITY_INSERT M_SalesOffice ON
INSERT INTO M_SalesOffice(SoID,SoName,SoAddress,SoPhone,SoPostal,SoFAX,SoFlag,SoHidden)
VALUES(1,N'北大阪営業所',N'大阪府吹田市寿町3-4-40',N'06-7011-6123',N'5600046',N'06-6562-2740',0,null)
INSERT INTO M_SalesOffice(SoID,SoName,SoAddress,SoPhone,SoPostal,SoFAX,SoFlag,SoHidden)
VALUES(2,N'兵庫営業所',N'兵庫県姫路市東辻井2-5-20',N'079-669-4326',N'6700994',N'079-669-4327',0,null)
INSERT INTO M_SalesOffice(SoID,SoName,SoAddress,SoPhone,SoPostal,SoFAX,SoFlag,SoHidden)
VALUES(3,N'鹿営業所',N'奈良県生駒郡三郷町勢野8-7-50',N'0745-99-0084',N'6360814',N'0746-0-1160639',0,null)
INSERT INTO M_SalesOffice(SoID,SoName,SoAddress,SoPhone,SoPostal,SoFAX,SoFlag,SoHidden)
VALUES(4,N'京都営業所',N'京都府京都市山科区東野南井ノ上町10-3-7',N'077-6726006',N'6078143',N'0771-85-2574',0,null)
INSERT INTO M_SalesOffice(SoID,SoName,SoAddress,SoPhone,SoPostal,SoFAX,SoFlag,SoHidden)
VALUES(5,N'和歌山営業所',N'和歌山県和歌山市柳丁4-19',N'073-887-1927',N'6408336',N'0735-78-4874',0,null)
SET IDENTITY_INSERT M_SalesOffice OFF

/*小分類マスタ*/
SET IDENTITY_INSERT M_SmallClassification ON
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(1,1,N'テレビ',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(2,1,N'レコーダー',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(3,2,N'エアコン',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(4,2,N'冷蔵庫',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(5,2,N'洗濯機',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(6,3,N'オーディオ',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(7,3,N'イヤホン',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(8,3,N'ヘッドホン',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(9,4,N'携帯電話',0,null)
INSERT INTO M_SmallClassification(ScID,McID,ScName,ScFlag,ScHidden)
VALUES(10,4,N'スマートフォン',0,null)
SET IDENTITY_INSERT M_SmallClassification OFF

/*在庫テーブル*/
SET IDENTITY_INSERT T_Stock ON
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(1,1,100,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(2,2,120,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(3,3,199,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(4,4,50,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(5,5,60,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(6,6,32,0)
INSERT INTO T_Stock(StID,PrID,StQuantity,StFlag)
VALUES(7,10,240,0)
SET IDENTITY_INSERT T_Stock OFF

/*テンプレ*/
/*SET IDENTITY_INSERT  ON
INSERT INTO ()
VALUES()
SET IDENTITY_INSERT  OFF:/
