using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {
	AudioSource m_MyAudioSource;
	float m_MySliderValue;

	void Start () {
		m_MySliderValue = 0.5f;
		m_MyAudioSource = GetComponent<AudioSource>();
		m_MyAudioSource.Play();
	}
	
	// Update is called once per frame
	void OnGUI () {
		m_MySliderValue= GUI.HorizontalSlider(new Rect(25, 25, 200, 60), m_MySliderValue, 0.0F, 1.0F);
		m_MyAudioSource.volume = m_MySliderValue;
	}
}
