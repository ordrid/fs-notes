let buildperson forename surname age =
    let personDescription = if age < 18 then "child" else "adult"
    (forename, surname), personDescription
