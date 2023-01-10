#include <stdio.h>
#include <stdint.h>

#define SETBIT(mask,bit) mask|=(1ULL<<(bit))
#define CLEARBIT(mask,bit) mask&=~(1ULL<<(bit))
#define INVERSEBIT(mask,bit) mask^=(1ULL<<(bit))
#define CHECKBIT(mask,bit) !!((mask)&(1ULL<<(bit)))
#define ISVALID(bit) ((bit)>0&&((bit)<=64)) ? 1 : 0

int getNumber(int* number)
{
    printf("\nEnter student's number [1-64]: ");
    scanf("%d",number);
    if(!ISVALID(*number)) 
    {
    printf("\nNot valid number!\n");
    return 1;
    }
    (*number)--;
    return 0;
}

void printAttendanceinfo(uint64_t mask){
    printf("\nNumbers of missing students: ");
    for (int i = 0; i <64; i++){
        if(!CHECKBIT(mask, i))
            printf("%d ", i+1);
    }
    printf("\n\nNumbers of present students: ");
    for (int i = 0; i <64; i++){
        if(CHECKBIT(mask, i))
            printf("%d ", i+1);
    }
     printf("\n");
}

int main(void)
{
uint64_t attendance = 0;
int option=0;
int number=0;

while (1)
{
printf("\nOPTION MENU\n");
printf("-----------\n");
printf("1. Set attendance\n");
printf("2. Clear attendance\n");
printf("3. Attendance info\n");
printf("4. Change attendance\n");
printf("5. Exit\n");
printf("-----------\n");
printf("Please,select: ");
scanf("%d", &option);
if (option == 1)
{
    if(!getNumber(&number))
    {
        SETBIT(attendance,number);
    }
}
else if (option == 2)
{
    if(!getNumber(&number))
    {
        CLEARBIT(attendance,number);
    }
}
else if (option == 3)
{
    printAttendanceinfo(attendance);
}
else if (option == 4)
{
    if(!getNumber(&number))
    {
        INVERSEBIT(attendance,number);
    }  
}
else if (option == 5)
{
return 0;
}
else{
printf("Not valid option!\n");
}
}
return 0;
}