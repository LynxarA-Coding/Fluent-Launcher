using Fluent_Launcher.BackgroundClasses;

namespace Fluent_Launcher_Tests
{
    public class SetupTests
    {
        [Fact]
        // check if Steam folder is valid 
        public void FolderValidTest()
        {
            var setup = new Setup();
            string path = "C:/Program Files (x86)/Steam";
            bool expected = true;
            bool actual = setup.IsSteamFolderValid(path);
            Assert.Equal(expected, actual);
        }

        [Fact]
        // Check if Steam folder is not valid
        public void FolderNotValidTest()
        {
            var setup = new Setup();
            string path = "C:/Program Files (x86)/test";
            bool expected = false;
            bool actual = setup.IsSteamFolderValid(path);
            Assert.Equal(expected, actual);
        }
    }
}