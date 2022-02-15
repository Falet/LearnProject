namespace GameLearnProject.LoaderScripts.Interfaces
{
    public interface ISaverSerializeData
    {
        void Save(string jsonData, string nameData = null);

        void Get(string nameData);
    }
}