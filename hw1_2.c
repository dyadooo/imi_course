#include <stdio.h>

int main()
{
    int heigth=0,length=0;
    printf("\nВъведете дължината ");
    scanf("%d",&length);
    printf("\nВъведете височината ");
    scanf("%d",&heigth);
    printf("\nРезултати: лице %d , периметър %d",heigth*length,2*(heigth+length));
    return 0;
}