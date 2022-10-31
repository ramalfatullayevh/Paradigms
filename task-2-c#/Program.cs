int eded = 986543;
int mertebe;
int sum = 0;
while (eded > 0)
{
    mertebe = eded % 10;
    eded = eded / 10;
    sum = sum + mertebe;
}
Console.WriteLine(sum);
