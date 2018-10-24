using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour, ITypeWritter{

	/* 
	GameManager script:
	- SaveData;
	- History;
	- Game Sequence;
	- Audio;
	- 
	 */

	private TypeWritter typeWritter;

    public void RunFinishDialog()
    {
		print("Run When the dialog ends");
    }

    void Start () {
		typeWritter = TypeWritter.instance;
		typeWritter.Type(fileName: "TestDialogue");
		//typeWritter.ExecuteWhenFinish("");
	}
	
	void Update () {
		
	}

}
