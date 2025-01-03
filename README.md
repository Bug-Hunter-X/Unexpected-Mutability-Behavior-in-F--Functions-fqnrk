# Unexpected Mutability Behavior in F# Functions

This example demonstrates a common pitfall when working with mutable variables in F# functions. The behavior might seem counter-intuitive at first. The core issue is the understanding of how mutability and function calls interact in F#.

The `bug.fs` file contains the problematic code.  The `bugSolution.fs` file presents a solution and explanation.  This repo serves as a concise explanation of this behavior and offers a clear way to avoid such issues.