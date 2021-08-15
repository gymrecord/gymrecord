package models

import (
	"github.com/google/uuid"
	"time"
)

type Workout struct {
	Id          uuid.UUID
	Title       string
	Description string
	Category    string
	DateTime    time.Time
	Likes       int
	Exercises   []Exercises
	Tags        []Tags
}

type Exercises struct {
	Id       uuid.UUID
	Title    string
	Tags     []Tags
	Feedback string
	Timer    time.Timer
	Media    []Media
}

type Tags struct {
}

type Media struct {
}
