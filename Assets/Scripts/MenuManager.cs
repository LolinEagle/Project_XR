using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuManager : MonoBehaviour{
	[SerializeField] GameObject		menuB;
	[SerializeField] Transform		buttonParent;
	[SerializeField] GameObject		buttonPrefab;
	[SerializeField] string[]		activityNames;
	[SerializeField] AudioClip[]	activitySounds;

	private bool	debug = true;

	void Start(){
		GenerateButtons();
	}

	void GenerateButtons(){
		foreach (string activity in activityNames){
			GameObject	btn = Instantiate(buttonPrefab, buttonParent);

			btn.GetComponentInChildren<Text>().text = activity;
			if (debug){
				Button	btnComponent = btn.GetComponent<Button>();
				btnComponent.onClick.AddListener(() => OpenMenuB(activity));
			}
			// btn.GetComponent<XRSimpleInteractable>().selectEntered.AddListener((args) => OpenMenuB(activity));
		}
	}

	void OpenMenuB(string selectedActivity){
		menuB.SetActive(true);
		menuB.GetComponentInChildren<Button>().GetComponentInChildren<Text>().text = selectedActivity;
	}
}
