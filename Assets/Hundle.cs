using UnityEngine;
using System.Collections;
using Leap;

public class Hundle : MonoBehaviour {
	// Use this for initialization
	public
	void Start () {
		//RigidRoundHand
	}
	
	// Update is called once per frame
	void Update () {
		//print (controller.IsConnected());
		//print (controller.GetFrame());
		HandController controller = GetComponent<HandController>();
		if (controller.IsConnected()) { //controller is a Controller object
			Frame frame = controller.GetFrame(); // controller is a Controller object
			HandList hands = frame.Hands;
			Hand firstHand = hands [0];
			Hand secondHand = hands [1];
			float nigiri = (firstHand.GrabStrength + secondHand.GrabStrength) / 2;
			print(nigiri);
			if(nigiri > 0.8){
				print("アクセル");
			}
			if(nigiri < 0.3){
				print("バックとブレーキ");
			}
		}
		//print (controller.GetAllPhysicsHands()[0]);
		//print (controller.GetAllPhysicsHands()[1]);



		//RigidRoundHand(Clone) palm
		//wrist joint
		GameObject lefthand = GameObject.Find("CleanRobotFullLeftHand(Clone)");
		GameObject left = lefthand.transform.FindChild("wrist joint").gameObject;
		GameObject righthand = GameObject.Find("CleanRobotFullRightHand(Clone)");
		GameObject right = righthand.transform.FindChild("wrist joint").gameObject;
		print (left.transform.position.y.ToString() + "   " + right.transform.position.y.ToString());
		float l = left.transform.position.y;
		float r = right.transform.position.y;
		if (l > r + 0.5) {
			print ("右に曲がる");
		} else if (r > l + 0.5) {
			print ("左に曲がる");
		} else {
			print ("まっすぐ進む");
		}


		//print (lefthandpoint.transform.position.ToString() + "   " + righthandpoint.transform.position.ToString());

		/*
		GameObject righthand = GameObject.Find("CleanRobotFullLeftHand(Clone)");
		GameObject index = lefthand.transform.FindChild("index").gameObject;
		GameObject bone1 = index.transform.FindChild("bone1").gameObject;
		GameObject rightpoint = bone1.transform.FindChild("LEAPMOTION_LOW_POLY_HAND_v01:polySurface1_polySurface86").gameObject;
		print (leftpoint.transform.position.y);*/
		//CleanRobotFullRightHand(Clone)
		//LEAPMOTION_LOW_POLY_HAND_v01:polySurface1_polySurface86
		//LEAPMOTION_LOW_POLY_HAND_v01:polySurface1_polySurface86
		//GameObject lefthand = GameObject.Find("CleanRobotFullLeftHand(Clone)");
		/*
		GameObject lefthand = GameObject.Find("LEAPMOTION_LOW_POLY_HAND_v01:polySurface1_polySurface86");
		GameObject oya = lefthand.transform.parent.gameObject;
		GameObject oyaoya = oya.transform.parent.gameObject;
		GameObject oyaoyaoya = oyaoya.transform.parent.gameObject;
		print (oyaoyaoya);
		*/
		//print(lefthand.transform.position);
	}
}
