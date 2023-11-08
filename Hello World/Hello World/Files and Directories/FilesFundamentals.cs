using System;
using System.IO;

namespace Fundamentals.Files_and_Directories
{
    /// <summary>
    /// In .NET we have a name space called System.IO holding all the classes we need to work with files and directories:
    ///
    ///     File, FileInfo: Provide methods for creating, copying, deleting, moving and opening of files.
    ///         -File provides static methods:
    ///             Ideal when we have to undertake a small number of operations on a file.
    ///             Requires constant security checking for each new method we work with,
    ///             which affects performance when dealing with a large number of operations
    ///           
    ///         -FileInfo provides instance methods:
    ///             By creating an object of the FileInfo class, security checking is only once during the creation of h
    ///             the object
    ///
    ///      Directory, DirectoryInfo: Provide methods for creating, copying, deleting, moving and opening of directories.
    ///         -Directory provides static methods:
    ///             Ideal when we have to undertake a small number of operations on a file.
    ///             Requires constant security checking for each new method we work with,
    ///             which affects performance when dealing with a large number of operations
    ///           
    ///         -DirectoryInfo provides instance methods:
    ///             By creating an object of the FileInfo class, security checking is only once during the creation of h
    ///             the object
    ///
    ///     Path: Provides methods to work with Strings that contains a file or directory path information.
    ///     
    /// </summary>
    public class FilesFundamentals
    {

        public void fileFundamentals()
        {
            const string sourcePath = @"c:\temp\myfile.jpg";
            //* Copies an existing file to a new file. True indicates that if the file already existed, it can be overwritten.
            File.Copy(sourcePath, @"d:\temp\myfile.jpg", true);

            if (File.Exists(sourcePath))
                File.Delete(sourcePath);

            var fileContent = File.ReadAllText(sourcePath);
        }

        public void fileInfoFundamentals()
        {
            var sourcePath = @"c:\temp\myfile.jpg";
            var destinationPath = @"d:\temp\myfile.jpg";
            var fileInfo = new FileInfo(sourcePath);

            //* Copies an existing file to a new file. True indicates that if the file already existed, it can be overwritten.
            fileInfo.CopyTo(destinationPath, true);

            if (fileInfo.Exists)
                fileInfo.Delete();

            //* FileInfo does not have a readAllText method
        }

        public void directoryFundamentals()
        {
            var sourcePath = @"D:\OneDrive - Algonquin College\Coding toolkit\C-Sharp\Hello World\Hello World";
            var destinationPath = @"d:\temp\myfile.jpg";

            //Directory.CreateDirectory(sourcePath);

            //* Returns a String array with all files with a specific search pattern. SearchOption tells the method that it should search in all
            //* Directories and their subdirectories
            var files = Directory.GetFiles(sourcePath, ".", SearchOption.AllDirectories);

            foreach (var file in files)
                //Print all the files in the current project
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(sourcePath, ".", SearchOption.AllDirectories);

            foreach (var directory in directories)
                //Print all the directories in the current project
                Console.WriteLine(directory);

        }

        public void directoryInfoFundamentals()
        {
            var sourcePath = @"D:\OneDrive - Algonquin College\Coding toolkit\C-Sharp\Hello World\Hello World";
            var directoryInfo = new DirectoryInfo(sourcePath);

            var files = directoryInfo.GetFiles(".", SearchOption.AllDirectories);
            foreach (var file in files)
                //Print all the files in the current project
                Console.WriteLine(file);

            var directories = directoryInfo.GetDirectories(".", SearchOption.AllDirectories);

            foreach (var directory in directories)
                //Print all the directories in the current project
                Console.WriteLine(directory);
        }

        /// <summary>
        /// Path provides methods to work with a path and extract information from a path
        /// </summary>
        public void pathFundamentals()
        {
            var path = @"D:\OneDrive - Algonquin College\Coding toolkit\C-Sharp\Hello World\Hello World\CSharpFundamentals.sln";
           
            Console.WriteLine("Path extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

        }
}
}