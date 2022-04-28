using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour {

	private Animator _animator;
	private TextMeshProUGUI _text;
	private float _timeLeft = 3f;
	private float lastTime;

	void Start () {
		_text = GetComponent<TextMeshProUGUI>();
		_animator = GetComponent<Animator>();
		
		Time.timeScale = 0f;

		StartCoroutine(Counter());
	}

	private IEnumerator Counter () {
		yield return new WaitForSecondsRealtime(1f);
		lastTime = Time.unscaledTime;

		_animator.SetTrigger("Start");
		
		while (_timeLeft > 0f) {
			_timeLeft -= Time.unscaledTime - lastTime;
			lastTime = Time.unscaledTime;
			_text.text = _timeLeft > 0f ? $"{Mathf.CeilToInt(_timeLeft)}" : "Go!";
			
			yield return 0;
		}

		Time.timeScale = 1f;

		yield return new WaitForSecondsRealtime(1f);
		
		gameObject.SetActive(false);
	}
	
}