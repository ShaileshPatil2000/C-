using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");
MySqlConnection connection = new MySqlConnection();
connection.ConnectionString = "server=localhost;port=3306;user=root;password=hello;database=demo"; 

//string query = "select * from products";


// Console.WriteLine("Enter id");
// int id = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter Name");
// string name = Console.ReadLine();
// Console.WriteLine("Enter Unit_Price");
// int up = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter Quantity");
// int qty = int.Parse(Console.ReadLine());
// string query = "insert into products values(@id, @name, @up, @qty)";

string query = "select count(*) from products";
MySqlCommand command = new MySqlCommand(query,connection);
// command.Parameters.AddWithValue("@id",id);
// command.Parameters.AddWithValue("@name",name);
// command.Parameters.AddWithValue("@up",up);
// command.Parameters.AddWithValue("@qty",qty);
try{
connection.Open();
//MySqlDataReader reader = command.ExecuteReader();
// while(reader.Read()){
//     int id = int.Parse(reader["prod_id"].ToString());
//     string name = reader["prod_name"].ToString();
//     int up = int.Parse(reader["unit_price"].ToString());
//     int qty = int.Parse(reader["quantity"].ToString());
//     Console.WriteLine(id + "," + name + "," + up + "," + qty);
// }
// reader.Close();

// int n = command.ExecuteNonQuery();
// if(n > 0){
//     Console.WriteLine("Inserted Record at "+id);
// }

int count = int.Parse(command.ExecuteScalar().ToString());
Console.WriteLine("Total No. of products :"+count);
}catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    connection.Close();
}

