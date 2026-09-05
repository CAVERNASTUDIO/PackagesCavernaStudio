// Copyright (C) 2026, García Aparicio Erik Alejandro
using CavernaStudio.Formats;
using CavernaStudio.Table;
using CavernaStudio.Licenses;
// using CavernaStudio.Matrix;
                                                                                    /*
           FOR ADD PACKAGES OF CAVERNA STUDIO / PROJECT SCRIPTORIUM 
===================================================================================
dotnet add package CavernaStudio -s "[path de archivo .dpkg]"
"                " CavernaStudio.Table -s "                 "
"                " CavernaStudio.Licenses -s "                 " 

                                                                                    */
FormatsDocument document = new FormatsDocument(); // value default for FormatString document
document.FormatString("[path]");
// The document result of this metod is a one file and one line text
// in format string redaction for automatic creation documents for a strings programs presets.
// Application: in languages programs presets for .bat, .py, .txt, .md etc. 
// Exeption: in the character [ \ ] (fail redaction string, correction for user).
TableFormat table =new TableFormat(); // use default package.
table.ToCSV("[path]",'|'); // the markdown file to csv format table
table.ToMarkDown("[path]",','); // the csv file to markdown format table
table.ToTex("[path]",','); // the csv table file to latex format
table.ToTex("[path]",'|'); // the markdown file to latex format
Licenses licenseSoftware = new Licenses(); // use default Licenses Software
//Methods:
licenseSoftware.LicenseMIT("[title proyect]","[author]","[year]"); // Create document "MIT License" with the software n documentation reference.
licenseSoftware.LicenseFDL("[title proyect]","[author]","[year]"); // Create two documents "License" refence for author n "GNU FDL" document.
licenseSoftware.LicenseGPL("[title proyect]","[author]","[year]"); // Create two documents "License" refence for author n "GNU GPL V3" document.
