# Updater
A tool used to execute commands intended to update legacy sites "the old way". However, it can be used as a simple task runner. It is designed to be easily extendable.

# How to use:
Let's say you have named the application _updater.exe_ and have it in your PATH variable. In command prompt, execute the following command - _updater prod_. Note that there is a prod.upd file that contains the script. This files consists of commands - one command per line. If a line starts with '#', then the whole line is ignored. This is used for to have comments in the scripts.

Supported commands are:
* ZipToFolder zipFileName folderPath
* CleanFolder folderPath [list of file extensions to clear]
* FolderToZip folderPath zipFileName
* FolderToFolder sourceFolderPath destinationFolderPath
* BackupSql connectionString backupDatabase backupFolder 
* DeleteFolder folderPath

One example scenario that we automate is:
* Backup the database
* Unzip the installation package in a temp folder
* Remove all *.config and *.sitemap files
* Copy temp folder content into the application installation directory
* Remove temp folder
