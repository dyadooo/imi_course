#include <stdio.h>

int main()
{
    double uin = 0;
    double uf = 0;
    double current =0;

    printf("Enter Uin , V:\n");
    scanf("%lf",&uin);

    printf("Enter Uf , V:\n");
    scanf("%lf",&uf);

    printf("Enter current , mA:\n");
    scanf("%lf",&current);
    current/=1000;

    double R = (uin-uf)/current;
    R/=1000;

    printf("\nR = %.3lf, kOhm\n",R);
   
    return 0;
}