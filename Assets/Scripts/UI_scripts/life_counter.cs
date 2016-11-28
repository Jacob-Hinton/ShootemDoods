using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class life_counter : MonoBehaviour {

	public static int lives = 3;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}

	public static void increaseLife() {
		if (lives < 3)
			lives++;
	}

	public static void decreaseLife() {
		if (lives > 0) {
			lives--;
			Scene scene = SceneManager.GetActiveScene();

			SceneManager.LoadScene(scene.name);
		}
		else {
			pause_script.Pause();
			pause_script.gameOver();
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
