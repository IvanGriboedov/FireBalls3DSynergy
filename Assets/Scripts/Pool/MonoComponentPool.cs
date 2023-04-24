﻿using Factory;
using UnityEngine;

namespace Pool
{
	public class MonoComponentPool<T> : MonoBehaviour, IPool<T> where T : Component
	{
		[SerializeField] private Transform _root;
		[SerializeField] [Min(0)] private int _prewarmedMemberCount;
		
		private ComponentPool<T> _pool;

		public void Initialize(IFactory<T> factory)
		{
			_pool = new ComponentPool<T>(factory, _root, _prewarmedMemberCount);
		}
		
		public void Prewarm()
		{
			Debug.Log("Pool was prewarmed using is own capacity");
			_pool.Prewarm();
		}

		public T Request()
		{
			return _pool.Request();
		}
 
		public void Return(T member)
		{
			_pool.Return(member);
		}
	}
}