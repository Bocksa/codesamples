public static string GetUserIdFromDiscordId(long discordId) {
    string userId = ""; // define a buffer

    using (var con = new MySqlConnection(Connection.GetConnectionString())) {
        con.Open(); // connect to the server

        var cmd = new MySqlCommand($"SELECT * FROM fpp.bar WHERE DiscordId = {discordId};", con); // prepare a query to execute (keep in mind that 'discordId' should be sanitized or it's vulnerable to SQL injection)

        MySqlDataReader rdr = cmd.ExecuteReader(); // execute the query

        // start reading the database
        while (rdr.Read()) {
            if (rdr.HasRows) { // check if the database has any rows to begin with
                if (rdr.GetDouble(2) == discordId) { // check if this row has the discord id
                    customerId = rdr.GetString(4); // indexes start from 0 (which is the left column in Workbench)
                }
            } else {
                // the database has no rows, so we can return blank
                return "";
            }
        }

        con.Close(); // disconnect from the server
    }

    return userId; // return the user
}
