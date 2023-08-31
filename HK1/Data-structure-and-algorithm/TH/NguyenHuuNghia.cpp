#include<iostream>
#include <string>
#include <stdlib.h>
#include <list>
#include <algorithm>
#include <vector>
using namespace std;

void input(int a[], int n){
    
    for(int i = 0; i < n; i++){
        cout << "a[";
        cout << i;
        cout << "] = ";
        cin >> a[i];
    }
}

int linear_search(int arr[], int n, int x){  
    for (int i = 0; i < n; i++) 
        if (arr[i] == x) 
            return i; 
    return -1; 
}

int binary_search (int a[], int n, int x){
    int l=0, r=n-1, m;
    while (l <= r){
        m = (l+r)/2;
        if (a[m] == x)
            return m;
        if (a[m] < x)
            l = m+1;
        else
            r = m-1;
    }
    return -1;
}

void swap(int &a, int &b){
    int x = a;
    a = b;
    b = x;
}

void Interchange_Sort(int a[], int n){
    for(int i = 0; i < n-1; i++){
        for(int j = i+1; j<n; j++){
            if(a[i]>a[j]) swap(a[i], a[j]);
        }
    }
}

void bubble_sort(int a[], int n){
    for(int i = 0; i < n; i++){
        for(int j = i+1; j < n; j++){
            if(a[i] > a[j]) swap(a[i], a[j]);
        }
    }
}

void Insertion_Sort(int a[], int n){
    int j, x;
    for(int i = 1; i < n; i++){
        x = a[i];
        for(j = i; (x < a[j-1] && j > 0); j--){
            a[j] = a[j-1];
        }
        a[j] = x;
    }
}

void insertion_sort(int a[], int n){
    int i, j, x;
    for(i = 1; i < n; i++){
        x = a[i];
        for(j = i; (x < a[j-1] && j > 0); j--){
            a[j] = a[j-1];
        }
        a[j] = x;
    }
}

void Selection_Sort(int a[], int n){
    int min;
    for(int i = 0; i < n; i++){
        min = i;
        for(int j = i+1; j<n;j++){
            if(a[min]> a[j])
                min = j;
        }
        if(min != i)
            swap(a[i], a[min]);
    }
}


void selection_sort(int a[], int n){
    int min;
    for(int i = 0; i < n; i++){
        min = i;
        for(int j = i+1; j < n; j++){
            if(a[min]>a[j])
                min = j;
        }
        if(min != i) swap(a[min], a[i]);
    }
}

void Shake_Sort (int a[], int n){
	int l = 0, r = n-1, k = n-1;
	while (l < r){
		for (int i=r; i>l; i--)
			if (a[i] < a[i-1]){
				swap (a[i], a[i-1]);
				k = i;
			}
		l = k;
		for (int i=l; i<r; i++)
			if (a[i] > a[i+1]){
				swap (a[i], a[i+1]);
				k = i;
			}
		r = k;
	}
}
int Chia_Mang (int a[], int n, int start, int end){
    int Moc = a[end];
    int k = (start -1);
    for (int i = start ; i < end; i++)
        if (a[i] < Moc){
            k++;
            swap (a[k], a[i]);
        }
    swap (a[k+1], a[end]);
    return k+1;
}

void Quick_Sort(int a[], int n, int start, int end){
    if (start < end){
        int p = Chia_Mang(a, n, start, end);
        Quick_Sort(a, n, start, p - 1);
        Quick_Sort(a, n, p + 1, end);
    }
}

void merge(int a[], int l, int m, int h){
    int  i, j, k = l;
    int n1 = m-l+1;
    int n2 = h - m;
    int *L = new int[n1];
    int *R = new int[n2];
    for(i = 0; i < n1; i++){
        L[i] = a[l+i];
    }
    for(j = 0; j < n2; j++){
        R[j] = a[m+j+1];
    }
    i = 0; j = 0;
    while(i < n1 && j < n2){
        if(L[i] <= R[j]){
            a[k] = L[i];
            i++;
        }else{
            a[k] = R[j];
            j++;
        }
        k++;
        /*Viết tắt 18-25*/
        /*a[k++] = (L[i] <= R[j]) ? L[i++] : R[j++];*/
    }
    while(i < n1){
        a[k] = L[i];
        k++;
        i++;
        /*Viết tắt 30-32*/
        /*a[k++] = L[i++];*/
    }
    while(j < n2){
        a[k] = R[j];
        k++;
        j++;
        /*Viết tắt 37-39*/
        /*a[k++] = R[j++];*/
    }
}

void Merge_Sort(int a[], int l, int h){
    if(l < h){
        int m = l + (h - l)/2;
        Merge_Sort(a, l, m);
        Merge_Sort(a, m+1, h);
        merge(a, l, m, h);
    }
}

///Danh sach lien ket don
struct date{
    int dd, mm, yy;
};

struct STUDENT{
    char MSSV[10];
    string FullName;
    date DoB;
    string Address;
};

typedef struct tagStudentNode{
    STUDENT Info;
    struct tagStudentNode* pNext;
}StudentNode;

typedef struct tagList{
    StudentNode *pHead, *pTail;
} List;

void InputInfo (STUDENT &x){
    cout << "Nhap MSSV: ";
    cin >> x.MSSV;
    cin.ignore();
    cout << "Nhap ho va ten: ";
    getline(cin, x.FullName);
    cout << "Ngay sinh: ";
    cout << "\nNgay: ";
    cin >> x.DoB.dd;
    cout << "Thang: ";
    cin >> x.DoB.mm;
    cout << "Nam: ";
    cin >> x.DoB.yy;
    fflush(stdin);
    cout << "Nhap dia chi: ";
    getline (cin, x.Address);
}

void CreateList (List &l){
    l.pHead = NULL;
    l.pTail = NULL;
}

StudentNode* GetNode (STUDENT sv){
    StudentNode *p;
    p = new StudentNode;
    if (p == NULL) exit(1);
    p->Info = sv;
    p->pNext = NULL;
    return p;
}

void AddHead (List &l, StudentNode* p){
    if (l.pHead == NULL){
        l.pHead = p;
        l.pTail = l.pHead;
    }else{
        p->pNext = l.pHead;
        l.pHead = p;
    }
}

void AddTail (List &l, StudentNode* p){
    if (l.pHead == NULL){
        l.pHead = p;
        l.pTail = l.pHead;
    }else{
        l.pTail -> pNext = p;
        l.pTail = p;
    }
}

void InputList (List &l){
    STUDENT x;
    char kt;
    cout << "Nhap phim bat ky de nhan tiep.\n";
    cout << "Nhap phim 0 de dung nhap.\n";
    do{
        cin >> kt;
        if (kt == '0') break;
        InputInfo(x);
        StudentNode *p = GetNode(x);
        AddTail (l, p);
    }while(1);
}

void OutputList (List l){
    StudentNode *p;
    p = l.pHead;
    while (p != NULL){
        cout << "--------------------------------\n";
        cout << "MSSV: " << p -> Info.MSSV << endl;
        cout << "Name: " << p -> Info.FullName << endl;
        cout << "Ngay Sinh: " << p -> Info.DoB.dd << " / " << p ->Info.DoB.mm << " / " << p ->Info.DoB.yy << endl;
        cout << "Dia chi: " << p -> Info.Address << endl;
        p = p -> pNext;
    }
}

void xuat_mang(int a[], int n){
    for(int i = 0; i < n; i++){
        cout << a[i] << " ";
    }
}

void output(int a[], int n){
    cout << "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
    cout << "\n 1. Tim kiem tuyen tinh";
    cout << "\n 2. Tim kiem nhi phan";
    cout << "\n 3. Interchange_Sort";
    cout << "\n 4. Bubble_Sort";
    cout << "\n 5. Insertion_Sort";
    cout << "\n 6. Shake_Sort";
    cout << "\n 7. Selection_Sort";
    cout << "\n 8. Quick_Sort";
    cout << "\n 9. Merge_Sort";
    cout << "\n 10. Danh sach lien ket don\n";
    cout << "\n 0. Ket thuc chuong trinh\n";
    cout << "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
    int u;
    int k;
    do{
        cout << "\nNhap so de chay chuong trinh: ";
        cin >> u;
        switch (u){
            case 1:
                cout <<"Nhap k can tim: "; cin >> k;
                cout << "Vi tri cua K can tim (TKTT): " << linear_search(a, n, k) << endl;
                break;
            case 2:
                Interchange_Sort(a, n);
                cout <<"Nhap k can tim: "; cin >> k;
                xuat_mang(a, n);
                cout << "Vi tri cua K can tim (TKNP): " << binary_search (a, n, k) << endl;
                break;
            case 3:
                cout << "\n------Interchange_Sort------\n";
                Interchange_Sort(a, n);
                xuat_mang(a, n);
                break;
            case 4:
                cout << "\n------Bubble_Sort------\n";
                bubble_sort (a, n);
                xuat_mang(a, n);
                break;
            case 5:
                cout << "\n------Insertion_Sort------\n";
                Insertion_Sort (a, n);
                xuat_mang(a, n);
                break;
            case 6:
                cout << "\n------Shake_Sort------\n";
                Shake_Sort (a, n);
                xuat_mang(a, n);
                break;
            case 7:
                cout << "\n------Selection_Sort------\n";
                Selection_Sort (a, n);
                xuat_mang(a, n);
                break;
            case 8:
                cout << "\n------Quick_Sort------\n";
                Quick_Sort (a, n, 0, n-1);
                xuat_mang(a, n);
                break;
            case 9:
                cout << "\n------Merge_Sort------\n";
                Merge_Sort(a, 0, n-1);
                xuat_mang(a, n);
                break;
            case 10:
                List l;
                CreateList(l);
                InputList(l);
                OutputList(l);
                break;
        }
        cout << "\n=====================================\n";
    }while (1<=u && u < 10);
}

int main(){
    int n; 
    cout << "So luong phan tu = "; cin >> n;
    int a[n];
    input(a, n);
    output(a, n);
    return 0;
}