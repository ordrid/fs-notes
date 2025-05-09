let calculate binOp x y binOpName =
    let result = binOp x y
    printfn $"{binOpName} {x} {y} = {result}"
    result
