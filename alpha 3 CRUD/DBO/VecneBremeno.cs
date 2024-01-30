namespace alpha_3_CRUD;

public class VecneBremeno(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? Popis { get; set; }
    public DateTime? PoradiK { get; set; }
    public int? IdOpravneniK { get; set; }
    public int? IdOpravneniVeProspechOsobe { get; set; }
    public int? IdOpravneniVeProspechNemovitosti { get; set; }
    
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