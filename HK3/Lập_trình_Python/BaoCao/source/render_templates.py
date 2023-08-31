import utils
from flask import render_template
import json
#read category
def read_category():
    rows = utils.get_all("SELECT  * FROM crawlingdb.category")
    data = []
    for r in rows:
        data.append(
            {"id": r[0],
             "subject": r[1],
             "url": r[2]
             }
        )
   # with open("json_file/category.json", "w") as cat:
    #    json.dump(data, cat)
    return render_template("category.html", data=data)

# read news
def get_news():
    rows = utils.get_all("SELECT * FROM crawlingdb.news")
    data = []
    for r in rows:
        data.append(
        {
            "id": r[0],
            "tieude": r[1],
            "noidung": r[2],
            "hinhanh": r[3],
            "video": r[4],
            "id_trang": r[5]
        })
    with open("json_file/news.json", "w", encoding="utf8") as f:
        json.dump(data, f)


def read_news(keywords):
    with open("json_file/news.json", encoding="utf8") as f:
        news = json.load(f)
    if keywords:
        news = [n for n in news if n["tieude"].lower().find(keywords.lower()) >= 0]
    return news

if __name__ == "__main__":
    get_news()