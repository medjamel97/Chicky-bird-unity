using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameBehavior : MonoBehaviour
{
	// 0 = Swipe / 1 = Accelerometre / 2 = Camera / 3 = Voice  
	// Variable accessible men ay script
	public static int gameMode;
	public static bool gameRunning = false;

	public Text topText;
	public GameObject menu;

	void Start()
	{
		gameMode = 0;
	}

	void Update()
	{

	}

	public void chooseMode(int modeCode)
	{
		gameMode = modeCode;

		if (modeCode == 0)
		{
			topText.text = "Swipe";
		}
		else if (modeCode == 1)
		{
			topText.text = "Accelerometre";
		}
		else if (modeCode == 2)
		{
			topText.text = "Camera";
		}
		else if (modeCode == 3)
		{
			ObstacleBehavior.itemsSpeed = 3;
			topText.text = "Voice";
		}

		menu.SetActive(false);

		startGame();
	}

	public static void startGame()
	{
		gameRunning = true;
	}

	public static void stopGame()
	{
		gameRunning = false;
	}
}
