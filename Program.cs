// Copyright (C) 2026, García Aparicio Erik Alejandro
using CavernaStudio.Formats;
using CavernaStudio.Table;
/*
           FOR ADD PACKAGES OF CAVERNA STUDIO / PROJECT SCRIPTORIUM 
===================================================================================
dotnet add package CavernaStudio -s "[ruta de archivo .dpkg]"
 "                " CavernaStudio.Table -s "                  " 

 */   

FormatsDocument documento = new FormatsDocument(); // value for FormatString document
documento.FormatString("[Path]");
/* The document result of this metod is a one file and one line text
 in format string redaction for automatic creation documents for a strings programs presets.
 Application: in languages programs presets for .bat, .py, .txt, .md etc. 
 Exeption: in the character [ \ ] (fail redaction string, correction for user).*/

TableFormat table =new TableFormat(); // use default package.
table.ToCSV("[ruta]",'|'); // the markdown file to csv format table
table.ToMarkDown("[ruta]",','); // the csv file to markdown format table

table.ToTex("[ruta]",','); // the csv table file to latex format
table.ToTex("[ruta]",'|'); // the markdown file to latex format
