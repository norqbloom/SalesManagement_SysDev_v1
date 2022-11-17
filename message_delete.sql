delete from M_Message where MsgCD = 'M2029'
delete from M_Message where MsgCD = 'M2033'

INSERT INTO M_Message(MsgCD,MsgComments,MsgTitle,MsgButton,MsgICon)
VALUES (N'M2029',N'商品データを登録してよろしいですか？',N'追加確認',1,64)
INSERT INTO M_Message(MsgCD,MsgComments,MsgTitle,MsgButton,MsgICon)
VALUES (N'M2033',N'商品データを更新してよろしいですか？',N'追加確認',1,64)