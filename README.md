# Updater
A tool used to execute commands intended to update legacy sites "the old way"

# How to use:
Let's say you have named it _update_. In command prompt, execute the following command  _update prod_. Note that there is prod.upd file that contains the script. This files consists of commands - one command per line. A line can start with '#'. Then the whole line is ignored. This is used for comments.

Supported commands are:
* ZipToFolder zipFileName folderPath
* CleanFolder folderPath [list of file extensions to clear]
* FolderToZip folderPath zipeFileName
* FolderToFolder sourceFolderPath destinationFolderPath
* BackupSql connectionString backupDatabase backupFolder 
* DeleteFolder folderPath

One example scenario that we automate is:
* Backup the database
* Unzip the installation package in a temp folder
* Remove all *.config and *.sitemap files
* Copy temp folder content into the application installation directory
* Remove temp folder
