from flask import Flask, jsonify, render_template, request
import utils
import render_templates
app = Flask(__name__)

@app.route("/")
def render():
    return render_template("index.html")

@app.route("/category", methods = ["GET"])
def get_categories():
    rows = utils.get_all("SELECT * From crawlingdb.category")
    data = []
    for r in rows:
        data.append(
            {
                "id": r[0],
                "tentrangbao": r[1],
                "url": r[2]
            }
        )
    return render_template("category.html", data = data)

@app.route("/news", methods = ["GET"])
def get_news():
    rows = utils.get_all("SELECT * From crawlingdb.news")
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
            }
        )
    # return render_template("news.html", data = data)

# tìm kiếm theo kewords
    kw = request.args.get("keywords", None)
    dt = render_templates.read_news(kw)
    return render_template("news.html", data=dt)

if __name__=="__main__":
    app.run()