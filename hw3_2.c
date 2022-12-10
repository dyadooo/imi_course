#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
	int rnum = 0, rsum = 0,rmin=20,rmax=0;
	double average = 0;
	time_t t;

	srand((unsigned)time(&t));
	printf("Random values: ");
	for (int i = 0; i < 20; i++)
	{
		rnum = rand() % 20;
		if (rnum > rmax) rmax = rnum;
		if (rnum < rmin) rmin = rnum;
		rsum += rnum;
		printf("%d ", rnum);
	}
	average = (double)rsum / 20;
	printf("\nSum: %d\nAverage: %lf\nMax: %d\nMin: %d",rsum,average,rmax,rmin);

	return 0;
}
