using UnityEngine;

public class Player
{
    public int playerNumber;
    public Grid grid;

    public Player(int playerNumber, Grid grid)
    {
        this.playerNumber = playerNumber;
        this.grid = grid;
    }

    public void Play()
    {
        int x = Random.Range(0, 3);
        int y = Random.Range(0, 3);

        if (grid.IsGridValidAndEmpty(x, y))
        {
            grid.SetGrid(x, y, playerNumber);
        }
        else
        {
            Play();
        }
    }
}
