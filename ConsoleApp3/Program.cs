#region Task 1

int[] shelf = { 8, 10, 2};

bool isChanged = true;

while (isChanged) 
{
    isChanged = false;
    for (int i = 0; i < shelf.Length - 1; i++)
    {
        if (shelf[i] > shelf[i+1])
        {
            int temp = shelf[i];
            shelf[i] = shelf[i+1];
            shelf[i+1] = temp;
            isChanged = true;
        }
    }
}

int shelfArea = shelf[0] * shelf[1];

int door_a = 8;
int door_b = 2;


Console.WriteLine(shelfArea <= (door_a * door_b) ? "kecir" : "kecmir");
#endregion

#region Task 2

bool isPowerOfTwo = true;
int number = 315;

while (number > 0)
{
    if (number == 2)
    {
        break;
    }
    else if (number % 2 == 0)
    {
        number /= 2;
        continue;
    }
    isPowerOfTwo = false;
    break;
}

Console.WriteLine(isPowerOfTwo ? "2nin quvvetidir" : "2nin quvveti deyil");

#endregion

#region Task 3

int num = 1265;
int count = 0;

while (num > 0)
{
    num /= 10;
    count++;
}

Console.WriteLine($"{count} mertebelidir");

#endregion