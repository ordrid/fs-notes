type Person =
    { Forename: string
      Surname: string
      Age: int }

let buildPerson forename surname age =
    { Forename = forename
      Surname = surname
      Age = age }
