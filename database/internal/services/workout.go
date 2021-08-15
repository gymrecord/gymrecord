package services

import (
	"encoding/json"
	"fmt"
	"gymrecord/internal"
	"gymrecord/internal/operations"
	"net/http"
)

func GetAllWorkouts(writer http.ResponseWriter, request *http.Request) {
	_, data := operations.SelectData(internal.Space, "primary", 0, 0, []interface{}{})

	writer.WriteHeader(http.StatusOK)
	resp, err := json.Marshal(data)
	if err != nil {
		panic(err)
	}
	fmt.Println(resp)

	fmt.Fprintf(writer, string(resp))
}
