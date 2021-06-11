package main

import (
    "C"
    "fmt"
)

//export printInt
func printInt(x int) {
    fmt.Printf("Hello from go: %d", x)
}

func main() {}


go build -buildmode=c-archive ctest.go
