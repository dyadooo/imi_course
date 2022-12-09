#include <stdio.h>

int main()
{
	int count = 0;
	double R = 0, RSUM=0, temp = 0;
	printf("Enter resistor count: ");
	scanf("%d", &count);

	for (int i = 0; i < count; i++)
	{
	printf("Enter resistor %d resistance, Ohm: ",i);
	scanf("%lf", &R);
	RSUM += R;
	temp += (1/R);
	}

	printf("\nResistance of series connected resistors: %lf , Ohm", RSUM);
	printf("\nResistance of parallel connected resistors: %lf , Ohm", 1/temp);

	return 0;
}