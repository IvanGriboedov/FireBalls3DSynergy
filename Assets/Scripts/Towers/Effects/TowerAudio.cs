﻿using UnityEngine;

namespace Towers.Effects
{
	[RequireComponent(typeof(AudioSource))]
	public class TowerAudio : MonoBehaviour
	{
		[SerializeField] private AudioClip _segmentRemovedSound;
		
		[Header("Pitch preference")]
		[SerializeField] private float _startPitch;
		[SerializeField] private float _maxPitch;
		[SerializeField] private float _pitchIncreasedStep;

		private AudioSource _audioSource;
		private float _currentPitchLevel;

		private void Start()
		{
			_audioSource = GetComponent<AudioSource>();
			_currentPitchLevel = _startPitch;
		}

		public void PlaySound(int segmentCount)
		{
			_currentPitchLevel = Mathf.Clamp(_currentPitchLevel + _pitchIncreasedStep, _startPitch, _maxPitch);

			_audioSource.pitch = _currentPitchLevel;
			_audioSource.PlayOneShot(_segmentRemovedSound);
		}
	}
}