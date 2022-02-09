using GameLearnProject.Input;
using Zenject;

namespace GameLearnProject.ZenjectScripts.ProjectInstallers
{
    public class InputInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<InputManager>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
        }
    }
}