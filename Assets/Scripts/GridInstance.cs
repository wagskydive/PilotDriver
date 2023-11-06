using UnityEngine;

public class GridInstance : MonoBehaviour
{
    public Grid grid;
    public int x;
    public int y;

    public void SetGrid(Grid grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
    }

    public void OnClick()
    {
        Debug.Log("Hello World!");
    }
}
