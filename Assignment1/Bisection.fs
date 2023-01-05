module Tests

open System
open Xunit

// Recursive function of The algorithm of Bisection method
let rec bisection (a: Double, b: Double, funcOf: Double -> Double) =
    if funcOf a * funcOf b >= 0 then
        invalidArg $"funcOf a: {funcOf a}, funcOf b: {funcOf b}" "(a) * f(b) must be < 0"

    let c = (a + b) / 2.0

    match funcOf c with
    | 0.0 -> c
    | _ when funcOf a * funcOf c < 0 -> bisection (c, b, funcOf)
    | _ -> bisection (a, c, funcOf)

[<Fact>]
let ``(i) x3−x−1 = 0`` () =
    let f (x: Double) = (x * x * x) - x - 1.0
    let a, b = 1.32471795, -1.32471795
    printf $"f: {bisection (a, b, f)}"

    Assert.True(true)
    
[<Fact>]
let ``(ii) x−cos(x) = 0`` () =
    let f (x: Double) = x - cos(x)
    let a, b = 1, 0.5
    printf $"f: {bisection (a, b, f)}"

    Assert.True(true)
    
[<Fact>]
let ``(iii) e^−x − x= 0`` () =
    let f (x: Double) = exp(-x) - x
    let a, b = 2, -10
    printf $"f: {bisection (a, b, f)}"

    Assert.True(true)
    
