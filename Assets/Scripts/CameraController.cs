using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Follow camera should always be implemented in LateUpdate because it tracks objects that might have moved inside Update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
