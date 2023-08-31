#include <bits/stdc++.h>
using namespace std;

struct date
{
    int dd, mm, yy;
};

struct QLNS
{
    char MaNS[10];
    char TenNS[40];
    date NVL;
    int LuongCB;
};

typedef struct tagNode
{
    QLNS Info;
    struct tagNode* pNext;
}Node;

typedef struct tagList
{
    Node *pHead, *pTail;
} List;

void CreateList (List &l)
{
    l.pHead = NULL;
    l.pTail = NULL;
}

Node* GetNode (QLNS nv)
{
    Node *p;
    p = new Node;
    if (p == NULL) exit(1);
    p->Info = nv;
    p->pNext = NULL;
    return p;
}

void AddHead (List &l, Node* p)
{
    if (l.pHead == NULL)
    {
        l.pHead = p;
        l.pTail = l.pHead;
    }else
    {
        p->pNext = l.pHead;
        l.pHead = p;
    }
}

void AddTail (List &l, Node* p)
{
    if (l.pHead == NULL)
    {
        l.pHead = p;
        l.pTail = l.pHead;
    }else
    {
        l.pTail -> pNext = p;
        l.pTail = p;
    }
}

void InputInfo (QLNS &x)
{
    cout << "Nhap Ma Nhan Su: ";
    cin >> x.MaNS;
    cout << "Nhap Ten Nhan Su: ";
    cin >> x.TenNS;
    cout << "Ngay Vao Lam: ";
    cout << "\nNgay: ";
    cin >> x.NVL.dd;
    cout << "Thang: ";
    cin >> x.NVL.mm;
    cout << "Nam: ";
    cin >> x.NVL.yy;
    cout << "Luong Co Ban: ";
    cin >> x.LuongCB;
}

void InputList (List &l)
{
    QLNS x;
    int n;
    cout << "Nhap so luong Nhan Su: ";
    cin >> n;
    for (int i=0; i<n; i++)
    {
        InputInfo(x);
        Node *p = GetNode(x);
        AddTail (l, p);
    }
}

void OutputList (List l)
{
    Node *p;
    p = l.pHead;
    while (p != NULL)
    {
        cout << "\n====================================\n";
        cout << "Ma Nhan Su: " << p->Info.MaNS << endl;
        cout << "Ten Nhan Su: " << p->Info.TenNS << endl;
        cout << "Ngay Vao Lam: " << p->Info.NVL.dd << " / " << p->Info.NVL.mm << " / " << p->Info.NVL.yy << endl;
        cout << "Luong Co Ban: " << p->Info.LuongCB << endl;
        p = p->pNext;
    }
}

int main()
{
	List l;
	CreateList(l);
	InputList(l);
    OutputList(l);
    return 0;
}
