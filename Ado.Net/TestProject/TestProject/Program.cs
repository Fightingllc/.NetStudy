using System.Data.SqlClient;

using SqlConnection connection = new

SqlConnection("server=.;uid=sa;pwd=123456;database=Morning;timeout=30");

connection.Open();// 打开连接

Console.WriteLine($"State={connection.State}");

Console.WriteLine($"DataBase={connection.Database}");

Console.WriteLine($"ServerVersion={connection.ServerVersion}");

Console.WriteLine($"DataSource={connection.DataSource}");

Console.WriteLine($"ConnectionTimeout={connection.ConnectionTimeout}");

//Command 是数据库命令对象，它是数据库执行的一个 Transact-SQL 语句或存储过程
// SqlCommand 类 
//命名空间: System.Data.SqlClient
//程序集: System.Data.SqlClient.dll

// SqlCommand() 初始化 SqlCommand 类的新实例
using SqlCommand cmd = new SqlCommand();


// Connection 获取或设置 SqlCommand 的此实例使用的 SqlConnection。
cmd.Connection = connection;

// CommandText 获取或设置要在数据源中执行的 Transact-SQL 语句、表名或存储过程。
cmd.CommandText = $"insert into ScoreInfo values('VsCode','幼儿园',100)";

// ExecuteNonQuery() 对连接执行 Transact-SQL 语句并返回受影响的行数。
cmd.ExecuteNonQuery();

using SqlCommand cmd1 = new SqlCommand("select count(id) from ScoreInfo");
cmd1.Connection = connection;

// ExecuteScalar() 执行查询，并返回查询所返回的结果集中第一行的第一列。 忽略其他列或行。
object count = cmd1.ExecuteScalar();// 获取首行首列

Console.WriteLine(count);

// ExecuteReader() 将 CommandText 发送到 Connection，并生成 SqlDataReader。
using SqlDataReader dataReader = cmd.ExecuteReader();  //  返回一个读取对象