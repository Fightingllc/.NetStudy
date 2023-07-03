
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
int roll = dice.Next(1, 7);
// Random.Next()返回的是int类型 
// Next()的参数：  a.无参0-2147483647 b.单参代表最大值 c.双参取值范围
string rollString = dice.Next(1, 7).ToString();
// Console.WriteLine(roll);
// Console.WriteLine(rollString);

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
int maxNum = Math.Max(a, b);

// Console.WriteLine("maxNum："+ maxNum);


int[] numArr = { 1, 2, 3, 15, 3 };
int maxNumber = numArr[0]; // 假设第一个元素是最大值，遍历数组与该元素进行比较

for (int i = 1; i < numArr.Length; i++)
{
    maxNumber = Math.Max(maxNumber, numArr[i]);
}

// Console.WriteLine("maxNumber"+ maxNumber);
//error CS1501: “Max”方法没有采用 1 个参数的重载
// Console.WriteLine("numArr:" + Math.Max(numArr));


// if 语句的学习
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine("total:" + total);
if (total == 7 || total == 11)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}

// boolean的学习 Contains
string message = "Have a good day!";
bool result = message.Contains("good");

// Console.WriteLine(result);

// if (message.Contains("day"))
// {
//     Console.WriteLine("day");
// } else {
//     Console.WriteLine("no day");
// }

// ````````````````````````````````````````````````````````````````````````````````````````````
// 数组 C#中的数组初始需要设定长度，一旦设置，后面不能对数组进行增删操作
string[] arr1 = new string[3];
string[] arr2 = new string[5] { "a", "b", "c", "d", "e" };

arr2[4] = "西瓜";

// Console.WriteLine(arr2); //System.String[]

// 逐个输出数组元素
foreach (string item in arr2)
{
    Console.WriteLine(item);
}
// 或者将数组元素拼接为字符串后输出
string joinArr = string.Join(",", arr2);

// Console.WriteLine(joinArr);


// ````````````````````````````````````````````````````````````````````````````````````````````
/** 
List
在 C# 中，数组的大小是固定的，一旦创建后无法直接插入新的数据。
如果您需要在数组中插入新的数据，最好的做法是使用动态数据结构，例如 List<T>。

*/
List<string> list = new List<string> { "A123", "B456", "C789" };

// 在指定位置插入新数据
list.Insert(1, "D987"); // 在索引位置 1 插入新数据 "D987"

// 或者在末尾添加新数据
list.Add("E321"); // 在末尾添加新数据 "E321"

// 使用 foreach 遍历列表
foreach (string item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine("```````````");
// ```````````````````````````````````````````````````````````````````````````````````````````
// 案例测试
string[] orders = { "B234", "C344", "A34", "D344", "B345" };

foreach (string item in orders)
{
    // StartsWith 方法判断元素是否以指定的字符开头
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}

// ````````````````````````````````````````````````````````````````````````````````````````````

// C# 命名规则
// 不允许使用特殊字符# - $
// 变量名使用驼峰 初始小写开头后面大写开头

string str = "Life is not Limit";

// ToCharArray 将字符中拆分为字符数组
char[] charArr = str.ToCharArray();

// Array.Reverse 反过滤字符数组
Array.Reverse(charArr);

// ToLower 将字符中所有字符设置为小写
string strLower = str.ToLower();

// ToUpper 将字符中所有字符设置为大写
string strUpper = str.ToUpper();

// ````````````````````````````````````````````````````````````````````````````````````````````
// 强制转换（隐士转换）
int aa = 10;
double bb = aa;
string cc = "10";

// int result1 = aa + bb + cc;
// 无法将类型“string”隐式转换为“int”

string result2 = aa + bb + cc;

// 查看bb的类型
Console.WriteLine(bb.GetType()); // System.Double
// Console.WriteLine(result1);
Console.WriteLine($"{result2.GetType()},{result2}"); // System.String; 2010

// decimal num1 = 10.5m;   
// int myInt = (int)num1; // 将num1进行强制转换为int

// Console.WriteLine($"int:{myInt}"); // int:10

// 显示转换
// ToStrirng()，将数字转化为字符串
// int num2 = 10;

// Console.WriteLine(num2.ToString()); // 10

// Parse()，将string转化为int
// string strNum = "10";
// int num3 = int.Parse(strNum);

// Console.WriteLine(num3); // 10

// Convert类中也有很多类型转换的方法
// System.Int32是.NET类库中的基础数据类型名称，C#将其映射到int关键字
// string value = "10";
// int num4 = Convert.ToInt32(value);

// Console.WriteLine(num4); // 10

// TryParse()的使用
string strNum2 = "10";
int num5;

// 将strNum2转化为int，如果成功，他将转换后的值存储在out中，返回true，如次失败，他将返回false
bool results = int.TryParse(strNum2, out num5);

if (results)
{
    Console.WriteLine(num5); // 10
}

// 案例
// 字母进行拼接使用message，数字进行求和使用total
string[] str3 = { "12.3", "45", "ABC", "11", "DEF" };

string message1 = string.Empty;
decimal total1 = 0;

foreach (string item in str3)
{

    // 将数组中的字符中数字进行求和
    if (decimal.TryParse(item, out decimal num6))
    {
        total1 += num6;
    }
    else
    {
        message1 += item;
    }
}

// Console.WriteLine($"message:{message1}"); // message:ABCDEF
// Console.WriteLine($"total:{total1}"); // total:68.3

// 方法
void DisplayRandomNumber()
{
    Random random = new Random();

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(random.Next(3, 10));
    }
    Console.WriteLine();
}
DisplayRandomNumber();


// 案例IPv4
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555.0.555" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
    address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

    ValidLength();
    ValidZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is not a valid IPv4 address");
    }
}
// 107.31.1.5 is a valid IPv4 address
// 255.0.0.255 is a valid IPv4 address
// 555.0.555 is not a valid IPv4 address

void ValidLength()
{
    validLength = address.Length == 4;
}

void ValidZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        if (int.Parse(number) > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

