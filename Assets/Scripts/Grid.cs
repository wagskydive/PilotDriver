using UnityEngine;

public class Grid
{
    public int[,] grid = new int[3, 3];

    public Grid()
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                grid[i, k] = 0;
            }
        }
    }

    public void PrintGrid()
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            string row = "";
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                row += grid[i, k] + " ";
            }
            Debug.Log(row);
        }
    }

    public void SetGrid(int x, int y, int value)
    {
        grid[x, y] = value;
    }

    public int GetGrid(int x, int y)
    {
        return grid[x, y];
    }

    public bool IsGridEmpty(int x, int y)
    {
        return grid[x, y] == 0;
    }

    public bool IsGridFull()
    {
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int k = 0; k < grid.GetLength(1); k++)
            {
                if (grid[i, k] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }

    public bool IsGridValid(int x, int y)
    {
        return x >= 0 && x < grid.GetLength(0) && y >= 0 && y < grid.GetLength(1);
    }

    public bool IsGridValidAndEmpty(int x, int y)
    {
        return IsGridValid(x, y) && IsGridEmpty(x, y);
    }

    public bool IsGridValidAndFull(int x, int y)
    {
        return IsGridValid(x, y) && !IsGridEmpty(x, y);
    }

    public bool IsGridValidAndFull(int x, int y, int value)
    {
        return IsGridValid(x, y) && !IsGridEmpty(x, y) && grid[x, y] == value;
    }

    public bool IsGridValidAndEmptyOrFull(int x, int y)
    {
        return IsGridValid(x, y) && (IsGridEmpty(x, y) || !IsGridEmpty(x, y));

    }
}
