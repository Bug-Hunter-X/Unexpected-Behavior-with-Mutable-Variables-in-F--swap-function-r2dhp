let x = ref 10
let y = ref 20

let swap x y =
    let temp = !x
    x := !y
    y := temp

swap x y
printfn "%d %d" !x !y // This will print 20 10 as expected.