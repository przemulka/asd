using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    static GameController Getinstance()
    {
        if (instance==null)
        {
            instance = GameObject.FindGameObjectWithTag("Kontroler").GetComponent<GameController>();
        }
        return instance;
    }

    static private GameController instance;

    public Player CurrentPlayer
    {
        get
        {
            return Players[CurrentPlayerIdx];
        }
    }

    public Player[] Players = new Player[2];

    public int CurrentPlayerIdx = 0;

	// Use this for initialization
	void Start () {

        Players[0] = GameObject.Find("Gracz1").GetComponent<Player>();
        Players[0].Direction = 1;

        Players[1] = GameObject.Find("Gracz2").GetComponent<Player>();
        Players[1].Direction = -1;

        for (int y = 0; y < GameModel.GetInstance().BoardSize; y++)
        {
            for (int x = 0; x < GameModel.GetInstance().BoardSize; x++)
            {
                if ((x % 2 == 0 && y % 2 == 0) || (x % 2 == 1 && y % 2 == 1))
                {
                    if (y < GameModel.GetInstance().NumCheckersRow)
                    {
                        GameModel.GetInstance().Board[x, y].Owner = Players[0];
                    }
                    else if (y >= GameModel.GetInstance().BoardSize - GameModel.GetInstance().NumCheckersRow)
                    {
                        GameModel.GetInstance().Board[x, y].Owner = Players[1];
                    }
                }
            }
        }
        
    }

}
	
	// Update is called once per frame
	void Update () {
		
	}
}

