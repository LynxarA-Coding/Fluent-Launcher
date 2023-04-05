using Fluent_Launcher.BackgroundClasses;

namespace Fluent_Launcher_Tests
{
    public class SetupTests
    {
        [Fact]
        // check if Steam folder is valid 
        public void FolderValid()
        {
            var _Setup = new Setup();
            string path = "C:/Program Files (x86)/Steam";
            bool expected = true;
            bool actual = _Setup.IsSteamFolderValid(path);
            Assert.Equal(expected, actual);
        }

        [Fact]
        // Check if Steam folder is not valid
        public void FolderNotValid()
        {
            var _Setup = new Setup();
            string path = "C:/Program Files (x86)/test";
            bool expected = false;
            bool actual = _Setup.IsSteamFolderValid(path);
            Assert.Equal(expected, actual);
        }
    }
}