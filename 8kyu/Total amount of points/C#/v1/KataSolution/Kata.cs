namespace KataSolution;

public static class Kata {
    public static int TotalPoints(string[] games)
    {
        int totalPointsA = 0;
        foreach (var game in games)
        {
            var score = game.Split(":");
            var scoreA = int.Parse(score[0]);
            var scoreB = int.Parse(score[1]);

            if (scoreA > scoreB) totalPointsA += 3;
            else if (scoreA == scoreB) totalPointsA++;
        }

        return totalPointsA;
    }
}