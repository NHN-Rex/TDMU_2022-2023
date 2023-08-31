#include <iostream>
using namespace std;

struct Tree_Node{
	int data;
    // 2 biến lưu địa chỉ của cây con bên trái và phải.
	Tree_Node *pLeft, *pRight;
};

Tree_Node *Create_Tree_Node(int x){
    Tree_Node *temp = new Tree_Node;
    temp->data = x;
    temp->pLeft = NULL;
    temp->pRight = NULL;
    return temp;
}

struct Tree_Linked_List{
    Tree_Node *head;
    Tree_Node *tail;
};

Tree_Node *root;

int main(){

    return 0;
}