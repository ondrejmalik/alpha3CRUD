namespace alpha_3_CRUD;

public class DruhPozemku(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? Nazev { get; set; }
    
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