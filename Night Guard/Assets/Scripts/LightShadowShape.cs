using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightShadowShape : MonoBehaviour
{
	Light2D lt;
	[SerializeField] public float minEngleInner = 360f;
    [SerializeField] public float maxEngleInner = 360f;
    [SerializeField] public float minEngleOuter = 360f;
    [SerializeField] public float maxEngleOuter = 360f;
	[SerializeField] public float minTime = 0;
	[SerializeField] public float maxTime = 2;

	private float flickerTimer;
	// Start is called before the first frame update
	void Start()
	{
		lt = GetComponent<Light2D>();
	}
	void FixedUpdate()
	{
		FlickeringController();
	}
	private void FlickerTimer()
	{
		flickerTimer = Random.Range(minTime, maxTime);
	}
	private void Flickering()
	{
		lt.pointLightInnerAngle = Random.Range(minEngleInner, maxEngleInner);
		lt.pointLightOuterAngle = Random.Range(minEngleOuter, maxEngleOuter);
	}
		private void FlickeringController()
	{
		FlickerTimer();
		if (flickerTimer >= Time.deltaTime)
		{
			Flickering();
		}
	}

}
