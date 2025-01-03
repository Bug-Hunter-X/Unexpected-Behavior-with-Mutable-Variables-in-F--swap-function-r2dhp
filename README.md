# F# Mutable Variable Swap Bug

This repository demonstrates a common pitfall when working with mutable variables in F#.  The `swap` function attempts to swap the values of two mutable variables, but due to F#'s pass-by-reference nature, the result is not as expected.

The `bug.fs` file contains the erroneous code. The `bugSolution.fs` file provides a corrected version, illustrating how to properly swap values without unexpected side effects.

This example highlights the importance of understanding F#'s memory management when working with mutable state.