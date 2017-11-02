using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour 
{
	#region Variables
	[Header("Variables")]
	public int level;
	public int gold;
	public int castleHealth;
	public int enemiesRemain;
	#endregion
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Setting GUI elements
	void OnGUI()
	{
		// Setting our floats for 16:9
		float scrW = Screen.width / 16;
		float scrH = Screen.height / 9;

		// Main UI box
		GUI.Box(new Rect((12.21f * scrW), 0, (4 * scrW), Screen.height), "Test");
		//Title
		GUI.Box(new Rect((12.72f * scrW), (0.4f * scrH), (3 * scrW), (0.6f * scrH)), "4 Tower Defence");
		// Level text and box
		GUI.Box(new Rect((12.65f * scrW), scrH, (0.8f * scrW), (0.8f * scrH)), "Level");
		GUI.Box(new Rect((14.0f * scrW), scrH, (0.8f * scrW), (0.8f * scrH)), "<level>");
		// Gold text and box
		GUI.Box(new Rect((12.65f * scrW), (2.0f * scrH), (0.8f * scrW), (0.8f * scrH)), "Gold");
		GUI.Box(new Rect((14.0f * scrW), (2.0f * scrH), (0.8f * scrW), (0.8f * scrH)), "<gold>");
		// Castle health and bar
		GUI.Box(new Rect((12.72f * scrW), (3.0f * scrH), (3 * scrW), (0.5f * scrH)), "Castle Health");
		GUI.Box(new Rect((12.72f * scrW), (3.5f * scrH), (3 * scrW), (0.5f * scrH)), "<castleHealth>");
		// Remaining enemies text and box
		GUI.Box(new Rect((12.72f * scrW), (4.25f * scrH), (3 * scrW), (0.5f * scrH)), "Enemies Remaining");
		GUI.Box(new Rect((13.5f * scrW), (4.75f * scrH), (1.5f * scrW), (0.5f * scrH)), "E<enemiesRemain>");
		// Tower text and selection area
		GUI.Box(new Rect((12.72f * scrW), (5.75f * scrH), (3 * scrW), (0.5f * scrH)), "Towers");
		GUI.Button(new Rect((12.36f * scrW), (6.5f * scrH), (0.7f * scrW), (0.7f * scrH)), "BSE");
		GUI.Button(new Rect((13.11f * scrW), (6.5f * scrH), (0.7f * scrW), (0.7f * scrH)), "ETH");
		GUI.Button(new Rect((13.85f * scrW), (6.5f * scrH), (0.7f * scrW), (0.7f * scrH)), "WND");
		GUI.Button(new Rect((14.61f * scrW), (6.5f * scrH), (0.7f * scrW), (0.7f * scrH)), "FIR");
		GUI.Button(new Rect((15.36f * scrW), (6.5f * scrH), (0.7f * scrW), (0.7f * scrH)), "WTR");

	}
}
