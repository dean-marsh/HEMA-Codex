/* Dean Marsh HND Software Development */
/* HEMA Codex Project - Graded Unit 2 */
/* Main class for the HEMA Database */
/* This class holds all the SQL functions for a database */

/* Libaries used in program */
/* SQLite Library is unfamiliar and new to this project. */
using System;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;


namespace HEMA_Codex
{

    class DatabaseRecord
    {
        /*  Add all database fields */
        /* Declaring all variable names as string */
        public string name;
        public string country;
        public string school;
        public string date;
        public string discipline;
        public string source;
    }


    class HEMAdatabase
    {

        /* Holds connection with the database */
        private SQLiteConnection m_dbConnection;

        /* The SqLite filename */
        private string db_name = "MyHEMADatabase.sqlite";

        public HEMAdatabase()
        {
            initDatabase();
        }

        /* Create the database */
        /* Error handler to make sure database exists or it will create one if not */
        private void initDatabase()
        {
            // File.Delete(db_name);
            if (!File.Exists(db_name))
            {
                SQLiteConnection.CreateFile(db_name);
            }
            try
            {
                connectToDatabase();
                createTable();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("Table not created.");
            }
        }

        /* Open a connection to the database */
        private void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + db_name + ";Version=3;");
            m_dbConnection.Open();
        }

        /* Creates a table named 'codex' with six columns: name, country, 
        school, date activety, discipline types and sources authored. */
        private void createTable()
        {
            /* Add all fields for database and creates the table 'codex' */
            string sql = "create table codex (id integer primary key,"+
                "name varchar(30),"+
                "country varchar(30), "+
                "school varchar(40), "+
                " date varchar(10),"+
                " discipline varchar(60),"+
                " source varchar(40))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        /* Adding a new record to the database */
        public void insertRecord(DatabaseRecord dbrecord)
        {
            /* Sql code to insert new record */
            /* Inserts all fields to the table 'codex' */
            string sql = "INSERT into codex (name, country, school, date, discipline, source) values ('" + dbrecord.name + 
                "', '" + dbrecord.country + 
                "', '" + dbrecord.school + 
                "', '" + dbrecord.date + 
                "', '" + dbrecord.discipline + 
                "', '" + dbrecord.source + "')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        /* Database update function */
        /* The table 'codex' will update the fields dependent of the selected ID */
        public void updateRecord(string id, DatabaseRecord dbrecord)
        {
            /* Will delete all fields and ID from the table codex */ 
            string sql = "UPDATE codex WHERE id = "+id+
                "SET name="+dbrecord.name+
                "country="+dbrecord.country+
                "school="+dbrecord.school+
                "date="+dbrecord.date+
                "discipline="+dbrecord.discipline+
                "source="+dbrecord.source;
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        /* Database Delete function */
        public void deleteRecord(string id)
        {
            /* will delete the matching ID and all it's record from the database */
            string sql = "DELETE FROM codex WHERE id = " + id;
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        /* Data Dictionary set up to retreive the record from the list  */
        public Dictionary<string, string> getRecordList()
        {
            string sql = "SELECT id, name FROM codex order by id asc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            Dictionary<string, string> recordList = new Dictionary<string, string>();

            while (reader.Read())
            {
                recordList.Add(reader["id"].ToString(), reader["name"].ToString());
            }
            return recordList;
        }

        /* Selects from the table codex the id used by the record
         * orders the entries by name and in a descending order.*/
        public DatabaseRecord getRecord(string id)
        {
            /* Retreives the database fields of the matching ID */ 
            string sql = "SELECT * FROM codex WHERE id="+id+" ORDER BY name desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            DatabaseRecord databaseRecord = new DatabaseRecord();
            while (reader.Read())
            {
                /* Reads the fields from the database, converts to string to be displayed */
                databaseRecord.name = reader["name"].ToString();
                databaseRecord.country = reader["country"].ToString();
                databaseRecord.school = reader["school"].ToString();
                databaseRecord.date = reader["date"].ToString();
                databaseRecord.discipline = reader["discipline"].ToString();
                databaseRecord.source = reader["source"].ToString();
            }

            /* Returns all above information from record*/ 
            return databaseRecord;
        }
    }
}