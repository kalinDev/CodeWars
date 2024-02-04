package kata

import (
	"strconv"
	"strings"
)

func Points(games []string) int {
	totalPointsA := 0
	for _, game := range games {
		score := strings.Split(game, ":")
		scoreA, _ := strconv.Atoi(score[0])
		scoreB, _ := strconv.Atoi(score[1])

		if scoreA > scoreB {
			totalPointsA += 3
		} else if scoreA == scoreB {
			totalPointsA++
		}
	}

	return totalPointsA
}
