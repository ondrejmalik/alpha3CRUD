using MySqlConnector;

namespace alpha_3_CRUD;

public class Kraj(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? Nazev { get; set; }

    public void Create()
    {
        base.Create(() =>
        {
            string query = "INSERT INTO kraj (nazev) " +
                           "VALUES (@Nazev)";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand);
            sqlCommand.ExecuteNonQuery();
        });
    }

    public void Read(int id)
    {
        base.Read((id) =>
        {
            string query = "SELECT * FROM kraj WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand, id);
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Id = reader.GetInt32(0);
                    Nazev = reader.GetString(1);
                }
            }
        }, id);
    }

    public void Update(int id)
    {
        base.Update((id) =>
        {
            string query = "UPDATE kraj " +
                           "SET nazev = @Nazev " +
                           "WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand, id);
            sqlCommand.ExecuteNonQuery();
        }, id);
    }

    public void Delete(int id)
    {
        base.Delete((id) =>
        {
            string query = "DELETE FROM kraj " +
                           "WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.ExecuteNonQuery();
        }, id);
    }
}