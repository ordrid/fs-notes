let drive distance gas =
    if distance > 50.0 then gas / 2.0
    elif distance > 25 then gas - 10.0
    elif distance > 0 then gas - 1.0
    else gas

let finalState = 100.0 |> drive 55 |> drive 26 |> drive 1
