﻿using System;

namespace Towers.Generation
{
	public interface ITowerSegmentCreationCallBack
	{
		event Action<int> SegmentCreated;
	}
}