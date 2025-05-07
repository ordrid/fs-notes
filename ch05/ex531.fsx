open System

type Name = { Forename: string; Surname: string }

type Address =
    { Line1: string
      Line2: string
      Town: string
      Country: string }

type Customer =
    { Name: Name
      Address: Address
      CreditRating: int }

type Supplier =
    { Name: Name
      Address: string
      Balance: decimal
      DueDate: DateTime }
