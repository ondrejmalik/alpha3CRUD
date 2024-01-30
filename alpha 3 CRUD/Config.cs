using System.Text.RegularExpressions;

namespace alpha_3_CRUD;

public class Config
{
    public StreamReader Sr { get; set; }
    public Dictionary<string, string> Dict { get; set; } = new();

    public Config(string fileName, List<string> keys)
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            @$"alpha3\{fileName}");
        if (!File.Exists(path))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            File.Create(path);
        }

        Sr = new(path);
        foreach (var key in keys)
        {
            Dict.Add(key, "");
        }
        ReadConfigFromFile();
    }

    public void ReadConfigFromFile()
    {
        string configText = Sr.ReadToEnd();
        foreach (var key in Dict.Keys)
        {
            Regex re = new($"{key}(.*)");
            Dict[key] = re.Match(configText).Groups[1].Value;
        }
    }
}