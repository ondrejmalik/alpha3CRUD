using MySqlConnector;

namespace alpha_3_CRUD;

public class Okres(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? Nazev { get; set; }
    public int? IdKraj { get; set; }

    public void Create()
    {
        base.Create(() =>
        {
            string query = "INSERT INTO Okres (nazev, id_kraj) " +
                           "VALUES (@Nazev, @IdKraj)";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand);
            sqlCommand.ExecuteNonQuery();
        });
        //throw new NotImplementedException();
    }

    public void Read(int id)
    {
        base.Read((id) =>
        {
            string query = "SELECT * FROM obec WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand, id);
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    Id = reader.GetInt32(0);
                    Nazev = reader.GetString(1);
                    IdKraj = reader.GetInt32(2);
                }
            }
        }, id);
        //throw new NotImplementedException();
    }

    public void Update(int id)
    {
        base.Update((id) =>
        {
            string query = "UPDATE obec " +
                           "SET nazev = @Nazev, id_okres = @IdOkres " +
                           "WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand, id);
            sqlCommand.ExecuteNonQuery();
        }, id);
        //throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        base.Delete((id) =>
        {
            string query = "DELETE FROM obec " +
                           "WHERE id = @id";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand, id);
            sqlCommand.ExecuteNonQuery();
        }, id);
        //throw new NotImplementedException();
    }

    public override void SetParameters(ref MySqlCommand sqlCommand, int? id = null)
    {
        sqlCommand.Parameters.AddWithValue("@Id", id);
        sqlCommand.Parameters.AddWithValue("@Nazev", Nazev);
        sqlCommand.Parameters.AddWithValue("@IdKraj", IdKraj);
        base.SetParameters(ref sqlCommand, id);
    }
}