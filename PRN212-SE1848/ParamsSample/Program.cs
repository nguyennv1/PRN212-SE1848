int sum(params int[] arr)
{
    int s = 0;
    foreach (int x in arr)
        s = s + x;
    return s;
}
int s0 = sum();
int s1 = sum(100);
int s2 = sum(100, 200);
int s3 = sum(3, 4, 20, 200, 42, 34);