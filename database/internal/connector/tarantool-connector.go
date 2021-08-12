package connector

import (
	"github.com/tarantool/go-tarantool"
	"log"
)

func ConnectToTarantool() *tarantool.Connection {
	conn, err := tarantool.Connect("127.0.0.1:3301", tarantool.Opts{
		User: "admin",
		Pass: "pass",
	})

	if err != nil {
		log.Fatalf("Connection refused")
	}

	defer conn.Close()

	return conn
}
