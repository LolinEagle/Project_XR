using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuManager : MonoBehaviour{
	[Header("Menu A")]
	[SerializeField] Transform		buttonParent;
	[SerializeField] GameObject		buttonPrefab;

	[Header("Menu B")]
	[SerializeField] GameObject		menuB;
	[SerializeField] AudioSource	audioSource;
	[SerializeField] string[]		activityNames;
	[SerializeField] AudioClip[]	activitySounds;

	[Header("Debug mode (use for regular unity play mode)")]
	[SerializeField] private bool	debug = false;

	void Start(){
		if (activityNames.Length != activitySounds.Length) {
			Debug.Log("Error : activityNames and activitySounds have not the same length.");
		} else {
			GenerateButtons();
		}
	}

	void GenerateButtons(){
		for (int i = 0; i < activityNames.Length; i++){
			GameObject	btn = Instantiate(buttonPrefab, buttonParent);
			int			currentIndex = i;

			btn.GetComponentInChildren<Text>().text = activityNames[currentIndex];
			if (debug){
				Button	btnComponent = btn.GetComponent<Button>();
				btnComponent.onClick.AddListener(() => OpenMenuB(activityNames[currentIndex], activitySounds[currentIndex]));
			} else {
				btn.GetComponent<XRSimpleInteractable>().selectEntered.AddListener((args) => OpenMenuB(activityNames[currentIndex], activitySounds[currentIndex]));
			}
		}
	}

	void OpenMenuB(string selectedActivity, AudioClip selectedSounds){
		menuB.SetActive(true);
		menuB.GetComponentInChildren<Text>().text = selectedActivity;
		menuB.GetComponentInChildren<Button>().onClick.AddListener(() => audioSource.Play());
		audioSource.clip = selectedSounds;
	}
}
