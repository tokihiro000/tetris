using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {
	public int horizontal;
	public int vertical;
	public static int horizontalLane;
	public static int verticalLane;
	public float blockWidth;
	public GameObject[] Blocks;
	public int createPosX, createPosY;
	Block activeBlock;
	FallBlock activeFallBlock;
	GameObject[] childOfActiveBlock;
	List<List<int> > allList;
	List<List<GameObject> > objList;
	List<float> pointXList;
	List<float> pointYList;
	bool isBlockActive;

	// Use this for initialization
	void Start () {
		horizontalLane = horizontal;
		verticalLane = vertical;
		isBlockActive = true;

		allList = new List<List<int> >();
		for(int i = 0; i < horizontalLane + 2; i++) {
			List<int> list = new List<int> ();

			if (i == 0) {
				for (int j = 0; j < verticalLane + 2; j++) {
					list.Add (10);
				}
			} else {
				for (int j = 0; j < verticalLane + 2; j++) {
					if (j == 0 || j == (verticalLane + 1)) {
						list.Add (10);
					} else {
						list.Add (0);
					}
				}
			}
			allList.Add (list);
		}

		objList = new List<List<GameObject> > ();
		for(int i = 0; i < horizontalLane + 2; i++) {
			List<GameObject> list = new List<GameObject> ()  {null, null, null, null, null, null, null, null, null, null, null, null};
			objList.Add (list);
		}

		pointXList = new List<float> ();
		for (int i = 1; i < verticalLane + 2; i++) {
			float pointX = (-3.0f + i * 0.5f);
			pointXList.Add (pointX);
		}

		pointYList = new List<float> ();
		for (int i = 1; i < horizontalLane + 2; i++) {
			float pointY = (-5.5f + i * 0.5f);
			pointYList.Add (pointY);
		}

		GameObject obj = (GameObject) Instantiate (Blocks[0], new Vector3(pointXList[createPosX], pointYList[createPosY], 0.0f), Quaternion.identity);
		activeBlock = obj.GetComponentInChildren<Block> ();
		activeBlock.set_bar (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_rect (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_s (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_z (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_t (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_l (pointXList, pointYList, createPosX, createPosY);
		//activeBlock.set_lr (pointXList, pointYList, createPosX, createPosY);
	}

	void Update () {
		if (isBlockActive) {
			if (Input.GetKeyDown ("left")) {
				if (activeBlock.isMoveEnable (pointXList, pointYList, ref allList, "left")) {
					activeBlock.moveLeft(pointXList, pointYList);
				}
			}

			if (Input.GetKeyDown ("right")) {
				if (activeBlock.isMoveEnable (pointXList, pointYList, ref allList, "right")) {
					activeBlock.moveRight(pointXList, pointYList);
				}
			}

			if (Input.GetKeyDown ("down")) {
				if (activeBlock.isMoveEnable (pointXList, pointYList, ref allList, "down")) {
					activeBlock.moveDown (pointXList, pointYList);
				} else {
					isBlockActive = false;
					activeBlock.changeState (ref allList, ref objList);
					breakBlock();
					organizeMap ();
					nextBlock();
				}
			}

			if (Input.GetKeyDown (KeyCode.Space)) {
				activeBlock.rotate_r (pointXList, pointYList, ref allList);

			}
		}
	}

	void breakBlock() {
		List<int> removeIndexList = new List<int> ();
		int count = objList.Count;
		for (int i = 0; i < count; i++) {
			List<GameObject> list = objList [i];
			int deletedObj = 0;
			list.ForEach (delegate(GameObject obj) {
				if (obj != null) {
					deletedObj += 1;
				}
			});

			if (deletedObj == 10) {
				removeIndexList.Add (i);
				list.ForEach (delegate(GameObject obj) {
					Destroy (obj);
				});
			}
		}

		removeIndexList.Sort ((a, b) => b - a);
		removeIndexList.ForEach (delegate(int i){
			objList.RemoveAt (i);
			allList.RemoveAt (i);
		});

		removeIndexList.ForEach (delegate(int i){
			List<GameObject> list = new List<GameObject> ()  {null, null, null, null, null, null, null, null, null, null, null, null};
			objList.Add(list);

			List<int> list2 = new List<int> {10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10};
			allList.Add(list2);
		});
	}

	void organizeMap() {
		for (int i = 1; i < verticalLane + 1; i++) {
			for (int j = 1; j < horizontalLane + 1; j++) {
				GameObject obj = objList [j] [i];
				if (obj == null) {
					continue;
				}
				obj.transform.position = new Vector2(pointXList[i], pointYList[j]);
			}
		}
	}

	void nextBlock () {
		GameObject obj = (GameObject) Instantiate (Blocks[0], new Vector3(pointXList[createPosX], pointYList[createPosY], 0.0f), Quaternion.identity);
		activeBlock = obj.GetComponentInChildren<Block> ();
		activeBlock.set_bar (pointXList, pointYList, createPosX, createPosY);
		isBlockActive = true;
	}
}
