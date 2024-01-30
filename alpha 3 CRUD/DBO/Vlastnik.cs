using MySqlConnector;

namespace alpha_3_CRUD;

public class Vlastnik(Config config) : DBObject(config)
{
    
    public int Id { get; set; }
    public string? Jmeno { get; set; }
    public string? Prijmeni { get; set; }
    public string? Adresa { get; set; }
    public string? Identifikator { get; set; }
    
    public void Create()
    {
        throw new NotImplementedException();
    }

    public void Read(int customerId)
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}