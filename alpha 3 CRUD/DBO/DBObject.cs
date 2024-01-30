using MySqlConnector;

namespace alpha_3_CRUD;

public abstract class DBObject(Config config) // consider renaming to MySQLObject
{
    public MySQLConnector Connector { get; set; } = new(config.Dict["server="], config.Dict["username="],
        config.Dict["database="], config.Dict["port="], config.Dict["password="]);


    // CRUD methods for the Customer table
    public void Create(Action execute)
    {
        Connector.OpenConnection();
        execute();
    }

    public void Read(Action<int> execute, int id)
    {
        Connector.OpenConnection();
        execute(id);
    }

    public void Update(Action<int> execute, int id)
    {
        Connector.OpenConnection();
        execute(id);
    }

    public void Delete(Action<int> execute, int id)
    {
        Connector.OpenConnection();
        execute(id);
    }

    public virtual void SetParameters(ref MySqlCommand sqlCommand, int? id = null)
    {
    }
}