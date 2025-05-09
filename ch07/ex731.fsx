type Result =
    { HomeTeam: string
      HomeGoals: int
      AwayTeam: string
      AwayGoals: int }

let create home hg away ag =
    { HomeTeam = home
      HomeGoals = hg
      AwayTeam = away
      AwayGoals = ag }

let results =
    [ create "Messiville" 1 "Ronaldo City" 2
      create "Messiville" 1 "Bale Town" 3
      create "Ronaldo City" 2 "Bale Town" 3
      create "Bale Town" 2 "Messiville" 1 ]

results
|> List.collect (fun result ->
    [ {| Team = result.HomeTeam
         Goals = result.HomeGoals |}
      {| Team = result.AwayTeam
         Goals = result.AwayGoals |} ])
|> List.groupBy (fun result -> result.Team)
|> List.map (fun (team, games) -> team, games |> List.sumBy (fun game -> game.Goals))
|> List.maxBy snd
