﻿using System;
using Input;
using UnityEngine;
using Touch = Input.Touches.Touch;

namespace PlayerComponents
{
	public class PlayerInputHandler : MonoBehaviour
	{
		[Header("Player Components")]
		[SerializeField] private Player _player;
		[Header("Input")]
		[SerializeField] private InputTouchPanel _touchPanel;

		private void OnEnable()
		{
			_touchPanel.Holding += Shoot;
		}

		private void OnDisable()
		{
			_touchPanel.Holding -= Shoot;
		}

		private void Shoot(Touch touch) => _player.Shoot();

	}
}