using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
	public float Seconds;
	
	void Start ()
	{
		StartCoroutine("DestroySelf");
	}

	private IEnumerator DestroySelf()
	{
		yield return new WaitForSeconds(Seconds);
		Destroy(gameObject);
	}
}
