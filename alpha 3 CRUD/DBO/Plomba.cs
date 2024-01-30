namespace alpha_3_CRUD;

public class Plomba(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public int? CisloJednacihoRizeni { get; set; }
    public string? Popis { get; set; }
    public DateTime? Datum { get; set; }
    public int? IdPozemek { get; set; }
    
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