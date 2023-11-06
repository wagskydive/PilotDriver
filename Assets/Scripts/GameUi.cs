using UnityEngine;

public class GameUi : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log("Hello World!");
    }

    public void DrawGrid(Grid grid)
    {
        for (int i = 0; i < grid.grid.GetLength(0); i++)
        {
            for (int k = 0; k < grid.grid.GetLength(1); k++)
            {
                GameObject gridInstance = Instantiate(Resources.Load("Grid")) as GameObject;
                GridInstance gridScript = gridInstance.AddComponent<GridInstance>();
                gridScript.SetGrid(grid, i, k);
            }
        }
    }
}
