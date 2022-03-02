using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Rendering.Universal;


[RequireComponent(typeof(Light))]
public class LightControll : MonoBehaviour
{
	TorchGathering torch;
	LightDesapearenceTimer timer;
	Light2D lt;
	[SerializeField] Color lightColor = Color.yellow;
	[SerializeField] float minIntensity = 8f;
	[SerializeField] float maxIntensity = 3f;
	[SerializeField] public float minTime = 0;
	[SerializeField] public float maxTime = 2;
	[SerializeField] private float lightRangeModifier = 3;
	[SerializeField] public float minRangeInnerInnitial;
	[SerializeField] public float maxRangeInnerInnitial;
	[SerializeField] public float minRangeOuterInnitial;
	[SerializeField] public float maxRangeOuterInnitial;
	private float minRangeInner;
	private float maxRangeInner;
	private float minRangeOuter;
	private float maxRangeOuter;
	private float flickerTimer;
	
		void Start()
	{
		torch = GetComponentInParent<TorchGathering>();
		lt = GetComponent<Light2D>();
		timer = GetComponent<LightDesapearenceTimer>();
		minRangeInner = minRangeInnerInnitial;
		maxRangeInner = maxRangeInnerInnitial;
		minRangeOuter = minRangeOuterInnitial;
		maxRangeOuter = maxRangeOuterInnitial;
	}
    void FixedUpdate()
	{
		FlickeringController();
	}
	private void FlickerTimer()
    {
		flickerTimer=Random.Range(minTime, maxTime);
    }
	private void Flickering()
    {
		lt.intensity = Random.Range(minIntensity, maxIntensity);
		lt.pointLightInnerRadius = Random.Range(minRangeInner, maxRangeInner);
		lt.pointLightOuterRadius = Random.Range(minRangeOuter, maxRangeOuter);
		lt.color = lightColor;
		
	}
	private void FlickeringController()
    {
		LightTimedShortnener();
		FlickerTimer();
		if (flickerTimer>=Time.deltaTime)
        {
			Flickering();
        }
    }
	private void LightTimedShortnener()
    {
		if (timer.isTimerZero==true)
        {	
			minRangeInner -= lightRangeModifier;
			minRangeOuter -= lightRangeModifier;
			maxRangeInner -= lightRangeModifier;
			maxRangeOuter -= lightRangeModifier;
			timer.isTimerZero = false; 
        }
    }
	public void LightReset()
    {
		
			minRangeInner = minRangeInnerInnitial;
			minRangeOuter = minRangeOuterInnitial;
			maxRangeInner = maxRangeInnerInnitial;
			maxRangeOuter = maxRangeOuterInnitial;
    }
}