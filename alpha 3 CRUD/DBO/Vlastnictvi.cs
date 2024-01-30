namespace alpha_3_CRUD;

public class Vlastnictvi(Config config) : DBObject(config)
{
    public int Id { get; set; }
    public string? ZpusobNabiti { get; set; }
    public int? IdPozemek { get; set; }
    public int? IdVlastnik { get; set; }
    public int? Podil { get; set; }
    

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