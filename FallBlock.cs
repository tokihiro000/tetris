using UnityEngine;
using System.Collections;

public class FallBlock : MonoBehaviour {
	Coroutine cor;
	int currentIndexX, currentIndexY;

	// Use this for initialization
	void Start () {
	}

	IEnumerator moveDown() {
		while (true) {
			float x = this.transform.position.x;
			float y = this.transform.position.y;
			this.transform.position = new Vector2 (x, y - 0.26f);

			yield return new WaitForSeconds (0.1f);
		}
	}

	public void setCurrentIndex(int x, int y){
		this.currentIndexX = x;
		this.currentIndexY = y;
	}

	public int getCurrentIndexX(){
		return currentIndexX;
	}

	public int getCurrentIndexY(){
		return currentIndexY;
	}

	private GameObject[] GetAllChildren() {
		GameObject[] gameObjects = this.GetComponentsInChildren<GameObject> ();
		return gameObjects;
	}

}