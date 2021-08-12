package main

import (
	"fmt"
	"github.com/gorilla/mux"
	"gymrecord/internal/services"
	"net/http"
)

func main() {
	r := mux.NewRouter()
	r.HandleFunc("/", services.GetAllWorkouts)
	http.Handle("/", r)
	fmt.Println("Start server")
	http.ListenAndServe(":9001", nil)
}
