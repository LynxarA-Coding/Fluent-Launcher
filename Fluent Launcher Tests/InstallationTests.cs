using Fluent_Launcher.BackgroundClasses;

namespace Fluent_Launcher_Tests
{
    public class InstallationTests
    {
        [Fact]
        // Check the logic of the Main Installation function
        public void MainSkinInstallationTest()
        {
            var _Installation = new Installation();
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Url from dummy
            string urlFrom = $"{documentsFolder}/Fluent Launcher Tests/from";
            Directory.CreateDirectory(urlFrom);
            string file = $"{urlFrom}/test.txt";
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine("test");
            }

            // Url to dummy
            string urlTo = $"{documentsFolder}/Fluent Launcher Tests/to";
            string skinName = "Fluent Launcher";
            _Installation.Main(urlFrom, urlTo, skinName);

            // check if there is a folder with the skin name and it has a text file
            bool actual = File.Exists($"{urlTo}/{skinName}/test.txt");

            // Delete the dummy folders
            Directory.Delete($"{documentsFolder}/Fluent Launcher Tests", true);

            // Assert
            Assert.True(actual, "Main function does not copy the folder contents");
        }

        [Fact]
        // Check the logic of the Install function
        public void InstallFunctionTest()
        {
            var _Installation = new Installation();
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Url from dummy
            string urlFrom = $"{documentsFolder}/Fluent Launcher Tests/from";
            Directory.CreateDirectory(urlFrom);
            string file = $"{urlFrom}/test.txt";
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine("test");
            }

            // Url to dummy
            string urlTo = $"{documentsFolder}/Fluent Launcher Tests/to";

            // Test the Install function
            _Installation.Install(urlFrom, urlTo);

            // check if there is a folder with the skin name and it has a text file
            bool actual = File.Exists($"{urlTo}/test.txt");

            // Delete the dummy folders
            Directory.Delete($"{documentsFolder}/Fluent Launcher Tests", true);

            // Assert
            Assert.True(actual, "Installation function does not copy the folder contents");
        }

        [Fact]
        // Check the logic of the Uninstall function
        public void UninstallFunctionTest()
        {
            var _Installation = new Installation();
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Url from dummy
            string urlFrom = $"{documentsFolder}/Fluent Launcher Tests/";
            Directory.CreateDirectory(urlFrom);
            string file = $"{urlFrom}/test.txt";
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine("test");
            }

            // Test the Uninstall function
            _Installation.Uninstall(urlFrom);

            // check if there is a folder with the skin name and it has a text file
            bool actual = File.Exists($"{urlFrom}/test.txt");

            // Delete the dummy folders if exist
            if (Directory.Exists($"{urlFrom}/"))
            {
                Directory.Delete($"{urlFrom}/", true);
            }

            // Assert
            Assert.False(actual, "Uninstall function does not delete the folder contents");
        }
    }
}
