# Aspose

## Installtion

### Windows
 * .NET8
 * aspose-finance 23.10.0
 * System.Drawing.Common 4.5.2

1. You need clone the project to your computer
   ```
   git clone https://github.com/Yiao/Aspose.git
   ```
2. You open the project with Visual Studio
3. Run the application

### Mac
 * .NET8
 * aspose-finance 23.10.0
 * System.Drawing.Common 4.5.2
 * runtime.osx.10.10-x64.CoreCompat.System.Drawing 6.0.5.128

1. You need clone the project to your computer
   ```
   git clone https://github.com/Yiao/Aspose.git
   ```
2. You open the project with Visual Studio
3. Install runtime.osx.10.10-x64.CoreCompat.System.Drawing 6.0.5.128
   ```
   dotnet add package runtime.osx.10.10-x64.CoreCompat.System.Drawing --version 6.0.5.128
   ```
4. Replace the code in the class FileManager, because we don't use \\, we use / for the repository
   ```
   public static string? GetTestFileDir()
   {
            string startDirectory = GetTheRootDir();
            return startDirectory != null ? Path.Combine(startDirectory, "TestFile/") : null;
    }

   public static string? GetResultFileDir()
   {
            string startDirectory = GetTheRootDir();
            return startDirectory != null ? Path.Combine(startDirectory, "ResultFile/") : null;
   }
   ```
5. Run the application
