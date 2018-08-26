using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Sql;

namespace KonturT.AppData
{
    class ConnectionsF
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=:memory:;Version=3;New=True;");
        SQLiteCommand cmd = new SQLiteCommand();
        

        string sql_command = "DROP TABLE IF EXISTS person;"
          + "CREATE TABLE person("
          + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
          + "first_name TEXT, "
          + "last_name TEXT, "
          + "sex INTEGER, "
          + "birth_date INTEGER);"
          + "INSERT INTO person(first_name, last_name, sex, birth_date) "
          + "VALUES ('John', 'Doe', 0, strftime('%s', '1979-12-10'));"
          + "INSERT INTO person(first_name, last_name, sex, birth_date) "
          + "VALUES ('Vanessa', 'Maison', 1, strftime('%s', '1977-12-10'));"
          + "INSERT INTO person(first_name, last_name, sex, birth_date) "
          + "VALUES ('Ivan', 'Vasiliev', 0, strftime('%s', '1987-01-06'));"
          + "INSERT INTO person(first_name, last_name, sex, birth_date) "
          + "VALUES ('Kevin', 'Drago', 0, strftime('%s', '1991-06-11'));"
          + "INSERT INTO person(first_name, last_name, sex, birth_date) "
          + "VALUES ('Angel', 'Vasco', 1, strftime('%s', '1987-10-09'));";
    }
}
