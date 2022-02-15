namespace GameLearnProject.LoaderScripts.Interfaces
{
    public interface IParser
    {
        string Serialize(object objectForSerialize);
        
        void Deserialize<T>(string jsonData);
    }
}