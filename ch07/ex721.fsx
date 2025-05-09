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

let isFeatured place result =
    result.HomeTeam = place || result.AwayTeam = place

let ronaldoCityFeaturesCount =
    results |> List.filter (isFeatured "Ronaldo City") |> List.length
