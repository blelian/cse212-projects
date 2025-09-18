/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
        }

        Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        var topPlayers = new string[10];
    }
}
/*using Microsoft.VisualBasic.FileIO; // For reading CSV files easily
using System;
using System.Collections.Generic;    // For Dictionary
using System.Linq;                   // For sorting with OrderByDescending

public class Basketball
{
    public static void Run()
    {
        // Create a dictionary to store total points per player
        // Key = playerId (string), Value = total points (int)
        var players = new Dictionary<string, int>();

        // Open the CSV file using TextFieldParser
        using var reader = new TextFieldParser("basketball.csv");

        // Tell parser that the file is delimited (not fixed width)
        reader.TextFieldType = FieldType.Delimited;

        // Set comma as the delimiter
        reader.SetDelimiters(",");

        // Skip the header row (column titles) since we don't need them
        reader.ReadFields();

        // Loop through all remaining rows in the CSV
        while (!reader.EndOfData)
        {
            // Read current row and split into an array of columns
            var fields = reader.ReadFields()!;

            // Extract player ID (column 0) and points scored (column 8)
            var playerId = fields[0];
            var points = int.Parse(fields[8]); // Convert points from string to int

            // If player is already in dictionary, add points to existing total
            if (players.ContainsKey(playerId))
            {
                players[playerId] += points;
            }
            else
            {
                // Otherwise, add player with initial points
                players[playerId] = points;
            }
        }

        // Sort dictionary by total points in descending order
        // Take only the top 10 players
        var topPlayers = players
            .OrderByDescending(kv => kv.Value)
            .Take(10);

        // Print the top 10 players with their total points
        Console.WriteLine("Top 10 Players by Total Points:");
        foreach (var kv in topPlayers)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }
    }
}
*/