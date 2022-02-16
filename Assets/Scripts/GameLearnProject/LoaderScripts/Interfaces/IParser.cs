namespace GameLearnProject.LoaderScripts.Interfaces
{
    public interface IParser
    {
        string Serialize(object objectForSerialize);
        
        T Deserialize<T>(string jsonData);
    }
}