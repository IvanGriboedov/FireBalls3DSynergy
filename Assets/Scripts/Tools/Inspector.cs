﻿using System;
using UnityObject = UnityEngine.Object;

namespace Tools
{
	public static class Inspector
	{
		public static void ValidateOn<T>(ref UnityObject validateObject)
		{
			if (validateObject != null && validateObject is T == false)
			{
				validateObject = null;
				throw new InvalidOperationException($"{nameof(validateObject)} should be derived from {typeof(T)}");
			}
		}
	}
}