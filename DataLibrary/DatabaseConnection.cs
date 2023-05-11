namespace DataLibrary;

public static class DatabaseConnection
{
    public static string ConnectionString
    {
        get
        {
            return @"Server = mssqlstud.fhict.local; Database = dbi505814; User Id = dbi505814; Password = Takethatcucumber123@;TrustServerCertificate=True;";
        }
    }
}
