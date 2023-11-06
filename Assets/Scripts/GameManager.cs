using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The player plays against the computer. The player is always X and the computer is always O. The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.
// The game is played on a 3x3 grid.
// The player who is playing X always goes first.
// Players alternate placing Xs and Os on the board until either one player has three in a row, horizontally, vertically, or diagonally; or all nine squares are filled.
// If a player is able to draw three Xs or three Os in a row, that player wins.
// If all nine squares are filled and neither player has three in a row, the game is a draw.


public class GameManager : MonoBehaviour
{

    GameObject player;

    GameObject gridObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        Grid grid = new Grid();
        grid.PrintGrid();
        player = Instantiate(Resources.Load("Player")) as GameObject;
        PlayerInstance playerScript = player.AddComponent<PlayerInstance>();
        playerScript.SetPlayer(new Player(1, grid));


        gridObject = Instantiate(Resources.Load("Grid")) as GameObject;

        for(int i = 0; i < 3; i++)
        {
            for(int k = 0; k < 3; k++)
            {
                GameObject gridInstance = Instantiate(Resources.Load("GridInstance")) as GameObject;
                GridInstance gridInstanceScript = gridInstance.AddComponent<GridInstance>();
                gridInstanceScript.SetGrid(grid, i, k);
                gridInstance.transform.parent = gridObject.transform;
                gridInstance.transform.localPosition = new Vector3(i, k, 0);
            }
        }

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
