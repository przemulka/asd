using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour {
    public GameObject FieldPrefab;

    public GameObject CheckerPrefab;
    private Vector3 GetFieldPosition (int x, int y,bool isChecker)
    {
        SpriteRenderer renderer = FieldPrefab.GetComponent<SpriteRenderer>();
        float fieldSize = renderer.sprite.bounds.size.x * FieldPrefab.transform.localScale.x;
        float startFieldPosition = -(fieldSize*GameModel.GetInstance().BoardSize/2);
        return new Vector3(startFieldPosition + x*fieldSize,startFieldPosition + y*fieldSize, ( isChecker ? -1.0f : 0.0f));
    }
    // Use this for initialization
	void Start () {
		for (int y = 0; y < GameModel.GetInstance().BoardSize; y++)
        {
            for (int x = 0; x < GameModel.GetInstance().BoardSize; x++)
            {
                SpriteRenderer newField = (Instantiate(FieldPrefab, GetFieldPosition(x, y,false), Quaternion.identity) as GameObject).GetComponent<SpriteRenderer>();
                newField.GetComponent<FieldData>().X = x;
                newField.GetComponent<FieldData>().Y = y;
                if((x%2==0 && y % 2 == 0) || (x % 2 == 1 && y % 2 == 1))
                {
                    Color myColor = new Color();
                    ColorUtility.TryParseHtmlString("#CC9966", out myColor);
                    newField.color = myColor;
                    if (y < GameModel.GetInstance().NumCheckersRow)
                    {
                        GameObject checker = Instantiate(CheckerPrefab, GetFieldPosition(x, y, true), Quaternion.identity) as GameObject;
                        GameModel.GetInstance().RegisterCheckerData(checker.GetComponent<CheckerData>(), new Vec2(x, y));
                        
                    }
                    else if (y >= GameModel.GetInstance().BoardSize - GameModel.GetInstance().NumCheckersRow)
                    {
                        GameObject checker = Instantiate(CheckerPrefab, GetFieldPosition(x, y, true), Quaternion.identity) as GameObject;
                        checker.GetComponent<SpriteRenderer>().color = Color.black;
                        GameModel.GetInstance().RegisterCheckerData(checker.GetComponent<CheckerData>(), new Vec2(x, y));
                    }
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
