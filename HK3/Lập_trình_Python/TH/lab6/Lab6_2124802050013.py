from flask import Flask
from flask_sqlalchemy import SQLAlchemy
from sqlalchemy import Column, Integer, String, ForeignKey
from sqlalchemy.orm import relationship
import mysql.connector
add = Flask(__name__)
add.config["SQLALCHEMY_DATABASE_URI"] = "mysql+pymysql://root:root@localhost/Lab6?charset=utf8mb4"
add.config['SQLALCHEMY_TRACK_MODIFICATIONS'] = True
db = SQLAlchemy(app=add)

class KHACHHANG(db.Model):
    MAKH = db.Column(db.Integer, nullable=False, primary_key=True)
    TENKH = db.Column(db.String(100), nullable=False)
    DIACHI = db.Column(db.String(100), nullable=False)
    LOAIKH = db.Column(db.String(50), nullable=False)
    dienthoai = relationship("DIENTHOAI", backref="KHACHHANG", lazy=True)
    def __init__(self, MAKH, TENKH, DIACHI, LOAIKH):
        self.DIACHI = DIACHI
        self.LOAIKH = LOAIKH
        self.TENKH = TENKH
        self.MAKH = MAKH
    
class DIENTHOAI(db.Model):
    SODT = db.Column(db.String(11), nullable=False, primary_key=True)
    MAKH = db.Column(db.Integer, ForeignKey(KHACHHANG.MAKH), nullable=False)
    LOAIDT = db.Column(db.String(50), nullable=False)
    SOHD = db.Column(db.Integer, nullable=False)
    dichvu = relationship("DICHVU", secondary="DANGKY")
    def __repr__(self, SODT, MAKH, LOAIDT, SOHD):
        self.MAKH = MAKH
        self.SODT = SODT
        self.SOHD = SOHD
        self.LOAIDT = LOAIDT
    
class DICHVU(db.Model):
    MADV = db.Column(db.Integer, nullable=False, primary_key=True)
    TENDV = db.Column(db.String(50), nullable=False)
    dienthoai = relationship("DIENTHOAI", secondary="DANGKY")
    def __repr__(self, MADV, TENDV):
        self.MADV = MADV
        self.TENDV = TENDV

class DANGKY(db.Model):
    MADV = db.Column(db.Integer, nullable = False, primary_key = True)
    SODT = db.Column(db.String(11), nullable = False, primary_key = True)
    dienthoai = relationship("DIENTHOAI", backref="DANGKY_DIENTHOAI")
    dichvu = relationship("DICHVU", backref="DANGKY_DICHVU")
    def __repr__(self, MADV, SODT):
        self.MADV = MADV
        self.SODT = SODT



with add.app_context():
    db.create_all()
    

conn = mysql.connector.connect(host = "localhost", user = "root", passwd = "root", database='lab6', charset = 'utf8mb4')
cs = conn.cursor()

query_khachhang = "insert into khachhang values \
(1, 'Nguyễn Hữu Nghĩa', 'Bình Dương', 'Cá Nhân'),\
(2, 'Lục Tấn Khoa', 'Bình Dương', 'Doanh Nghiệp'),\
(3, 'Phạm Tuấn Vũ', 'Bình Dương', 'Cá Nhân'),\
(4, 'Trần Trung Nguyên', 'Thủ Dầu Một', 'Doanh Nghiệp'),\
(5, 'Nguyễn Thị Thanh Hằng', 'Thủ Dầu Một', 'Cá Nhân')"
# cs.execute(query_khachhang)

query_dienthoai = "INSERT INTO dienthoai values\
('0000000000', 1, 'Vô tuyến', 1),\
('1111111111', 2, 'Dây cáp', 2),\
('2222222222', 3, 'Vô tuyến', 3),\
('3333333333', 4, 'Dây cáp', 4),\
('4444444444', 5, 'Vô tuyến', 5)"
#cs.execute(query_dienthoai)

query_dichvu = "insert into dichvu values\
(1, 'DV1'),\
(2, 'DV2'),\
(3, 'DV3'),\
(4, 'DV4'),\
(5, 'DV5')"
#cs.execute(query_dichvu)

query_dangky = "insert into dangky values\
(1, '0000000000'),\
(2, '1111111111'),\
(3, '2222222222'),\
(4, '1111111111'),\
(5, '0000000000')"
#cs.execute(query_dangky)

#cs.fetchall()
#conn.commit()

#a
# querya = "select TENDV , dt.SODT, TENKH, LOAIKH \
# From dichvu dv, khachhang kh, dangky dk, dienthoai dt \
# where dv.MADV = dk.MADV and dk.SODT = dt.SODT and dt.MAKH = kh.MAKH and kh.LOAIKH = 'Cá Nhân'"

# cs.execute(querya)
# cs.fetchall()
# conn.commit()
with add.app_context():
    db.session.query(KHACHHANG).all()

