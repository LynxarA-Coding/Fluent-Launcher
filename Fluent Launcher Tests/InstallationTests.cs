using Fluent_Launcher.BackgroundClasses;

namespace Fluent_Launcher_Tests
{
    public class InstallationTests
    {
        [Fact]
        // Check if the function creates the skins folder when it does not exist
        public void Main_CreatesSkinsFolder_WhenItDoesNotExist()
        {
            // Arrange
            var instClass = new Installation();
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var urlFrom = $"{documentsFolder}/Fluent Launcher Tests/from";
            var urlTo = $"{documentsFolder}/Fluent Launcher Tests/to";
            var skinName = "Fluent Launcher";

            // Act
            Directory.CreateDirectory(urlFrom);
            instClass.Main(urlFrom, urlTo, skinName);

            bool expected = true;
            bool actual = Directory.Exists($"{urlTo}/{skinName}");

            // Cleanup
            Directory.Delete($"{documentsFolder}/Fluent Launcher Tests", true);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        // Check if the function deletes the files inside the skins folder before copying the new ones
        public void Main_DeletesFilesInsideDirectory_BeforeCopyingNewOnes()
        {
            // Arrange
            var instClass = new Installation();
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var urlFrom = $"{documentsFolder}/Fluent Launcher Tests/from";
            var urlTo = $"{documentsFolder}/Fluent Launcher Tests/to";
            var skinName = "Fluent Launcher";

            // Create some files in the directory
            Directory.CreateDirectory(urlFrom);
            Directory.CreateDirectory(urlTo);
            StreamWriter sw1 = File.CreateText($"{urlTo}/test1.txt");
            StreamWriter sw2 = File.CreateText($"{urlTo}/test2.txt");
            sw1.Close();
            sw2.Close();

            // Act
            instClass.Main(urlFrom, urlTo, skinName);

            bool expected = true;
            bool actual = Directory.GetFiles(urlTo).Length == 0;

            // Cleanup
            Directory.Delete($"{documentsFolder}/Fluent Launcher Tests", true);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        // Check the logic of the Install function
        public void Install_MovesFilesInsideNewDirectory()
        {
            var installation = new Installation();
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
            installation.Install(urlFrom, urlTo);

            // check if there is a folder with the skin name and it has a text file
            bool actual = File.Exists($"{urlTo}/test.txt");

            // Delete the dummy folders
            Directory.Delete($"{documentsFolder}/Fluent Launcher Tests", true);

            // Assert
            Assert.True(actual, "Installation function does not copy the folder contents");
        }

        [Fact]
        // Check the logic of the Uninstall function
        public void Uninstall_RemovesFilesFromDestinationDirectory()
        {
            var installation = new Installation();
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
            installation.Uninstall(urlFrom);

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

        [Fact]
        // Check the logic of the Uninstall file function
        public void UninstallFile_RemovesFileFromDestinationDirectory()
        {
            var installation = new Installation();
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
            installation.UninstallFile(urlFrom, "test.txt");
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
