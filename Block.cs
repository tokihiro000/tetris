using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Block : MonoBehaviour {
	public GameObject nano;
	int sin90, cos90;
	List<GameObject> activeBlock;
	List<FallBlock> activeFallBlock;


	// Use this for initialization
	void Awake () {
		activeBlock = new List<GameObject> {null, null, null, null};
		activeFallBlock = new List<FallBlock> {null, null, null, null};
		for (int i = 0; i < 4; i++) {
			activeBlock[i] = (GameObject) Instantiate (nano, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
			activeFallBlock[i] = activeBlock[i].GetComponentInChildren<FallBlock> ();
			activeBlock [i].SetActive (false);
		}

		sin90 = 1;
		cos90 = 0;
	}

	public void set_bar(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		for (int i = 0; i < 4; i++) {
			activeBlock [i].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
			activeFallBlock[i].setCurrentIndex (createPosX, createPosY);
			createPosY -= 1;
			activeBlock [i].SetActive (true);
		}
	}

	public void set_rect(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosY -= 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX -= 1;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void set_s(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX += 1;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY -= 1;
		createPosX -= 2;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void set_z(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX -= 1;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY -= 1;
		createPosX += 2;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void set_t(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosX += 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX -= 2;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		createPosX += 1;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void set_l(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosX += 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX -= 1;
		createPosY += 1;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void set_lr(List<float> pointXList, List<float> pointYList, int createPosX, int createPosY) {
		activeBlock [0].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[0].setCurrentIndex (createPosX, createPosY);

		createPosX -= 1;
		activeBlock [1].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[1].setCurrentIndex (createPosX, createPosY);

		createPosX += 1;
		createPosY += 1;
		activeBlock [2].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[2].setCurrentIndex (createPosX, createPosY);

		createPosY += 1;
		activeBlock [3].transform.position = new Vector2 (pointXList [createPosX], pointYList [createPosY]);
		activeFallBlock[3].setCurrentIndex (createPosX, createPosY);

		activeBlock [0].SetActive (true);activeBlock [1].SetActive (true);
		activeBlock [2].SetActive (true);activeBlock [3].SetActive (true);
	}

	public void rotate_r(List<float> pointXList, List<float> pointYList, ref List<List<int> > allList) {
		int originX = activeFallBlock [0].getCurrentIndexX();
		int originY = activeFallBlock [0].getCurrentIndexY();
		List<int> moveXList = new List<int> ();
		List<int> moveYList = new List<int> ();
	
		for (int i = 1; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX();
			int y = activeFallBlock [i].getCurrentIndexY();
			int relativePointX = x - originX;
			int relativePointY = y - originY;
			int relativeMovedPointX = getRightRotatePointX(relativePointX, relativePointY);
			int relativeMovedPointY = getRightRotatePointY(relativePointX, relativePointY);
			int amountOfChangeX = relativeMovedPointX - relativePointX;
			int amountOfChangeY = relativeMovedPointY - relativePointY;
			int newX = x + amountOfChangeX;
			int newY = y + amountOfChangeY;
			if (!isPointEnable(newX, newY, ref allList)) {
				return;
			}
			moveXList.Add(newX);
			moveYList.Add(newY);
		}

		for (int i = 1; i < 4; i++) {
			int newX = moveXList [i - 1];
			int newY = moveYList [i - 1];
			activeBlock[i].transform.position = new Vector2 (pointXList[newX], pointYList[newY]);
			activeFallBlock [i].setCurrentIndex (newX, newY);
		}

	}



	public bool isMoveEnable(List<float> pointXList, List<float> pointYList, ref List<List<int> > allList, string direction = "down") {
		for (int i = 0; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX();
			int y = activeFallBlock [i].getCurrentIndexY();
			int point;
			switch (direction) {
			case "down":
				if (!isPointEnable(x, y - 1, ref allList)) {
					return false;
				}
				break;
			case "left":
				point = allList [y] [x - 1];
				if (!isPointEnable(x - 1, y, ref allList)) {
					return false;
				}
				break;
			case "right":
				point = allList [y] [x + 1];
				if (!isPointEnable(x + 1, y, ref allList)) {
					return false;
				}
				break;
			}
		}

		return true;
	}

	public void moveLeft(List<float> pointXList, List<float> pointYList) {
		for (int i = 0; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX ();
			int y = activeFallBlock [i].getCurrentIndexY ();
			activeFallBlock [i].setCurrentIndex (x - 1, y);
			activeBlock[i].transform.position = new Vector2 (pointXList[x - 1], pointYList[y]);
		}
	}
		
	public void moveRight(List<float> pointXList, List<float> pointYList) {
		for (int i = 0; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX ();
			int y = activeFallBlock [i].getCurrentIndexY ();
			activeFallBlock [i].setCurrentIndex (x + 1, y);
			activeBlock[i].transform.position = new Vector2 (pointXList[x + 1], pointYList[y]);
		}
	}

	public void moveDown(List<float> pointXList, List<float> pointYList) {
		for (int i = 0; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX ();
			int y = activeFallBlock [i].getCurrentIndexY ();
			activeFallBlock [i].setCurrentIndex (x, y - 1);
			activeBlock[i].transform.position = new Vector2 (pointXList[x], pointYList[y - 1]);
		}
	}

	public void changeState (ref List<List<int> > allList, ref List<List<GameObject> > objList) {
		for (int i = 0; i < 4; i++) {
			int x = activeFallBlock [i].getCurrentIndexX ();
			int y = activeFallBlock [i].getCurrentIndexY ();
			int point = allList [y] [x];
			if (point > 1) {
				Debug.Log ("それはおかしい");
			}

			allList [y] [x] = 1;
			objList [y][x] = activeBlock [i];
		}
		Destroy (this.gameObject);
	}

	private bool isPointEnable(int x, int y, ref List<List<int> > allList) {
		if (x <= 0 || y <= 0 || x > GameController.verticalLane || y > GameController.horizontalLane) {
			//Debug.Log("allLIstへ渡したx, yが不正 (" + x + ", " + y +")");
			return false;
		}

		int point = allList [y] [x];
		if (point != 0) {
			return false;
		}

		return true;
	}

	private int getRightRotatePointX (int x, int y) {
		return (int) x * cos90 + y * sin90;
	}

	private int getRightRotatePointY (int x, int y) {
		return (int) -x * sin90 + y * cos90;
	}
}
