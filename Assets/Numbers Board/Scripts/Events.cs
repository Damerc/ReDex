using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
	private WritingHandler writingHandler;
	public Animator winDialog;
	public GameObject menu;
    public string ContentScene = "";
    public string MenuScene = "";

    void Start ()
	{
		//Setting up the writingHandler reference
		GameObject numbers = HierrachyManager.FindActiveGameObjectWithName ("Numbers");
		if (numbers != null)
			writingHandler = numbers.GetComponent<WritingHandler> ();
	}
	
	//Load the next number
	public void LoadTheNextNumber (object ob)
	{
		if (writingHandler == null) {
			return;
		}
        
        writingHandler.LoadNextNumber ();
	}
	
	//Load the previous/number
	public void LoadThePreviousNumber (object ob)
	{
		if (writingHandler == null) {
			return;
		}
		
		writingHandler.LoadPreviousNumber ();
		
	}
	
	//Load the current Number
	public void LoadNumber (Object ob)
	{
		if (ob == null) {
			return;
        }
		WritingHandler.currentNumberIndex = int.Parse (ob.name.Split ('-') [1]);
		//Application.LoadLevel ("Left");
        SceneManager.LoadScene(ContentScene);

    }
	
	//Erase the current Number
	public void EraseNumber (Object ob)
	{
		if (writingHandler == null) {
			return;
		}
		writingHandler.RefreshProcess ();
		
	}
	
	//Close win dialog
	public void CloseWinDialog (Object ob)
	{
		writingHandler.numbers [WritingHandler.currentNumberIndex].SetActive (true);
		menu.SetActive (true);
		GameObject [] linesRenderes = GameObject.FindGameObjectsWithTag ("LineRenderer");
		foreach (GameObject line in linesRenderes) {
			line.GetComponent<LineRenderer> ().enabled = true;
		}
		
		GameObject [] circlePoint = GameObject.FindGameObjectsWithTag ("CirclePoint");
		foreach (GameObject cp in circlePoint) {
			cp.GetComponent<MeshRenderer> ().enabled = true;
		}
		winDialog.SetBool ("isFadingIn", false);
	}
	
	//Load numbers menu
	public void LoadNumbersMenu (Object ob)
	{
		SceneManager.LoadScene(MenuScene);
	}
}