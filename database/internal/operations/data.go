package operations

import (
	"github.com/tarantool/go-tarantool"
	"gymrecord/internal/connector"
	"log"
)

func SelectData(space string, index interface{}, offset uint32, limit uint32, key interface{}) (uint32, []interface{}) {
	conn := connector.ConnectToTarantool()

	resp, err := conn.Select(space, index, offset, limit, tarantool.IterEq, key)

	if err != nil {
		log.Fatalf(err.Error())
	}

	log.Println(resp.Data)

	return resp.Code, resp.Data
}

func AddData(space string, data interface{}) (uint32, []interface{}) {
	conn := connector.ConnectToTarantool()
	resp, err := conn.Insert(space, data)

	if err != nil {
		log.Fatalf(err.Error())
	}

	log.Println(resp.Data)

	return resp.Code, resp.Data
}

func EditData(space string, index string, key interface{}, ops interface{}) (uint32, []interface{}) {
	conn := connector.ConnectToTarantool()
	resp, err := conn.Update(space, index, key, ops)

	if err != nil {
		log.Fatalf(err.Error())
	}

	log.Println(resp.Data)

	return resp.Code, resp.Data
}

func DeleteData(space string, index string, key int) (uint32, []interface{}) {
	conn := connector.ConnectToTarantool()
	resp, err := conn.Delete(space, index, key)

	if err != nil {
		log.Fatalf(err.Error())
	}

	log.Println(resp.Data)

	return resp.Code, resp.Data
}
