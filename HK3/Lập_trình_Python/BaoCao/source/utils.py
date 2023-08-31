from flask import Flask, jsonify
import newspaper
import mysql.connector
from newspaper import Article

conn = mysql.connector
def get_all(query):
    # tạo đối tượng connection
    conn = mysql.connector.connect(host = "localhost", user = "root", 
    passwd = "root", database='crawlingdb', charset = 'utf8mb4')
    cs = conn.cursor()
    data = cs.execute(query)
    data = cs.fetchall()
    conn.close()
    return data
    

def add_news(conn, url, category_id ):
    query = "INSERT INTO news(TITLE, CONTENT, PICTURE, VIDEO, PAGE_NEWS_ID) Values (%s, %s, %s, %s, %s)"
    article = Article(url)
    article.download()
    article.parse()
    conn = mysql.connector.connect(host = "localhost", user = "root", 
    passwd = "root", database='crawlingdb')
    cs = conn.cursor()
    cs.execute(query, (article.title, article.text, article.top_image, article.url, category_id))
    cs.fetchall()
    conn.commit()


def get_news_url():
    cats = get_all("SELECT * FROM crawlingdb.category")
    conn = mysql.connector.connect(host = "localhost", user = "root", 
    passwd = "root", database='crawlingdb')
    for cat in cats:
        cat_id = cat[0]
        url = cat[2]
        cat_paper = newspaper.build(url)
        print(cat_paper)
        for article in cat_paper.articles:
            try:
                print("==>", article.url)
                add_news(conn, article.url, cat_id)
            except Exception as ex:
                print("ERROR: ", str(ex))
                pass
    conn.close()

if __name__ == "__main__":
    get_news_url()