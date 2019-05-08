using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour {

	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//unityちゃんオブジェクトを取得
		this.unitychan = GameObject.Find("unitychan");
	}
		
	// Update is called once per frame
	void Update () {
		//unityちゃんとアイテムの距離を測定
		float item_difference = unitychan.transform.position.z - this.transform.position.z;
		//unityちゃんがアイテムを追い越した時、アイテムを破棄
		if(item_difference >= 10){
			Destroy (this.gameObject);
	}
}

}