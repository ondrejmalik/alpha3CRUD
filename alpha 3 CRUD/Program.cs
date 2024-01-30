using alpha_3_CRUD;

Config config = new("config.txt", new List<string>(){ "server=", "username=", "database=", "port=", "password=" });
Okres okres = new(config)
{
    Id = 1,
    Nazev = "werqwer",
    IdKraj = 1
};
okres.Read(1);