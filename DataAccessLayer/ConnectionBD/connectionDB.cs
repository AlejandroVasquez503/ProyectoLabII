using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class connectionBD
{
    private readonly string _connectionString;

    public connectionBD()
    {
        _connectionString = "Data Source=DESKTOP-NFDMETJ\\SQLEXPRESS;Initial Catalog=ControlGastosUniversitarios;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
    }

    public SqlConnection GetconnectionBD()
    {
        return new SqlConnection(_connectionString);
    }
}