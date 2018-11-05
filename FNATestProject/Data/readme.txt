FNA can mount (at present) directories and zip files with the special .pak extension (normal .zip will NOT work!)

The file structure within must be the same.

Directories take priority over zip files, so if a file at the same path is present in both the directory's file will be used.

test.pak only contains hellomessage.txt at the moment as I was testing if the PakFileSystem was working.

- Andrew