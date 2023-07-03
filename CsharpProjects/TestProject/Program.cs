
// 随机数
/// <summary>
/// 类的实例称为对象，对象就是类的实例
/// new 操作符
/// 1. 请求足够大的地址，用于存储Random类的新对象
/// 2. 创建新的对象，并将其存储在内存地址上
/// 3. 返回内存地址，使其保存在dice变量中，在dice变量中便可以访问Random类的属性和方法
/// 注：一些方法需要在调用该方法之前创建类的实例，需要判断方法是有状态的还是无状态的：
/// 无状态的不用创建类的新实例，有状态的参看实例1
/// </summary>
/// <returns></returns>
Random dice = new Random();
int roll = dice.Next(1,7);
// Random.Next()返回的是int类型 
// Next()的参数：  a.无参0-2147483647 b.单参代表最大值 c.双参取值范围
string rollString = dice.Next(1,7).ToString();
Console.WriteLine(roll);
Console.WriteLine(rollString);

// 实例1
//对象引用对于非静态的字段、方法或属性“Random.Next(int, int)”是必需的
// 所有需要先对Random类进行实例化，在进行访问
// Console.WriteLine("3-5",Random.Next(3, 5));
// int result = Random.Next(1,3);
// Console.WriteLine(result);

/// <summary>
/// Math类的使用
/// Math.Max()的参数类型是两个int类型，如果想求一个数组的最大值，不能直接传入数组，需要对数组进行遍历
/// </summary>
int a = 19;
int b = 24;
int maxNum = Math.Max(a,b);
Console.WriteLine("maxNum："+ maxNum);


int[] numArr =  {1,2,3,15,3};
int maxNumber = numArr[0]; // 假设第一个元素是最大值，遍历数组与该元素进行比较
for(int i = 1; i < numArr.Length; i++)
{
    maxNumber = Math.Max(maxNumber, numArr[i]);
}
Console.WriteLine("maxNumber"+ maxNumber);
//error CS1501: “Max”方法没有采用 1 个参数的重载
// Console.WriteLine("numArr:" + Math.Max(numArr));


// if 语句的学习
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;
Console.WriteLine("total:"+ total);
if(total == 7 || total == 11)
{
    Console.WriteLine("You win!");
}else{
    Console.WriteLine("You lose!");
}

// boolean的学习 Contains
string message = "Have a good day!";
bool result = message.Contains("good");
Console.WriteLine(result);
if(message.Contains("day"))
{
    Console.WriteLine("day");
}else{
    Console.WriteLine("no day");
}

// 数组 C#中的数组初始需要设定长度，一旦设置，后面不能对数组进行增删操作
string[] arr1 = new string[3];
string[] arr2 = new string[5] {"a","b","c","d","e"};

arr2[4] = "西瓜";

Console.WriteLine(arr2); //System.String[]

// 逐个输出数组元素
foreach(string item in arr2)
{
    Console.WriteLine(item);
}
// 或者将数组元素拼接为字符串后输出
string joinArr = string.Join(",", arr2);
Console.WriteLine(joinArr);

/** 
在 C# 中，数组的大小是固定的，一旦创建后无法直接插入新的数据。
如果您需要在数组中插入新的数据，最好的做法是使用动态数据结构，例如 List<T>。

*/
List<string> fraudulentOrderIDs = new List<string> { "A123", "B456", "C789" };

// 在指定位置插入新数据
fraudulentOrderIDs.Insert(1, "D987"); // 在索引位置 1 插入新数据 "D987"

// 或者在末尾添加新数据
fraudulentOrderIDs.Add("E321"); // 在末尾添加新数据 "E321"

// 使用 foreach 遍历列表
foreach (string orderID in fraudulentOrderIDs)
{
    Console.WriteLine(orderID);
}
