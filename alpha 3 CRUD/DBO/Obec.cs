using System.Runtime.Serialization;
using MySqlConnector;

namespace alpha_3_CRUD;

public class Obec(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? Nazev { get; set; }
    public int? IdOkes { get; set; }

    public void Create()
    {
        base.Create(() =>
        {
            string query = "INSERT INTO obec (nazev, id_okres) " +
                           "VALUES (@Nazev, @IdOkres)";
            MySqlCommand sqlCommand = new(query, Connector.Connection);
            SetParameters(ref sqlCommand);
            sqlCommand.ExecuteNonQuery();
        });
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
                    IdOkes = reader.GetInt32(2);
                }
            }
        }, id);
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
    }

    public override void SetParameters(ref MySqlCommand sqlCommand, int? Id = null)
    {
        sqlCommand.Parameters.AddWithValue("@id", Id);
        sqlCommand.Parameters.AddWithValue("@Nazev", Nazev);
        sqlCommand.Parameters.AddWithValue("@IdOkres", IdOkes);
        base.SetParameters(ref sqlCommand);
    }
}