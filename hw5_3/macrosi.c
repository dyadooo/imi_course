#include <stdio.h>
#include <stdint.h>

#define MAX(x,y,z) (x)>=(y)&&(x)>=(z) ? (x) : (y)>=(x)&&(y)>=(z) ? (y) : (z)
#define MIN(x,y,z) (x)<=(y)&&(x)<=(z) ? (x) : (y)<=(x)&&(y)<=(z) ? (y) : (z)
#define SETBIT(mask,bit) mask|=(1ULL<<(bit))
#define CLEARBIT(mask,bit) mask&=~(1ULL<<(bit))
#define INVERSEBIT(mask,bit) mask^=(1ULL<<(bit))
#define CHECKBIT(mask,bit) !!((mask)&(1ULL<<(bit)))
#define SWAP(a,b) (b)=(a)^(b); (a)=(b)^(a); (b)=(b)^(a);

void printMask(uint64_t mask){
    for (int i = 63; i >= 0; i--){
        printf("%d", CHECKBIT(mask, i));
    }
    printf("\n");
}

int main(void)
{
int num1=MAX(15,24,-122);
int num2=MIN(21,-3,0);
printf("MAX=%d MIN=%d\n",num1,num2);
uint64_t mask=0;
SETBIT(mask,6);
printMask(mask);
SETBIT(mask,43);
printMask(mask);
CLEARBIT(mask,6);
printMask(mask);
INVERSEBIT(mask,43);
printMask(mask);
num1=34;
num2=71;
printf("BEFORE SWAP num1=%d,num2=%d\n",num1,num2);
SWAP(num1,num2);
printf("AFTER SWAP num1=%d,num2=%d\n",num1,num2);

return 0;
}