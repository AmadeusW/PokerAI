
open System.IO

let handPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hdb"
let rosterPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hroster"
let playerDirectoryPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\pdb"

let hands = File.ReadAllLines handPath
let rosters = File.ReadAllLines rosterPath

let handsData = hands |> Array.map (fun x -> x.Split ([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries))
let rostersData = hands |> Array.map (fun x -> x.Split ([| ' ' |], System.StringSplitOptions.RemoveEmptyEntries))
let players = data.[0] |> Array.map (fun x -> rostersData )
