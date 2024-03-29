/*
Unity3d-TUIO connects touch tracking from a TUIO to objects in Unity3d.

Copyright 2011 - Mindstorm Limited (reg. 05071596)

Author - Simon Lerpiniere

This file is part of Unity3d-TUIO.

Unity3d-TUIO is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Unity3d-TUIO is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser Public License for more details.

You should have received a copy of the GNU Lesser Public License
along with Unity3d-TUIO.  If not, see <http://www.gnu.org/licenses/>.

If you have any questions regarding this library, or would like to purchase 
a commercial licence, please contact Mindstorm via www.mindstorm.com.
*/

using UnityEngine;
using System.Collections;

public static class BoundsExtensions 
{
	public static float GetDiagonalLength(this Bounds b)
	{
		return Vector3.Distance(b.min, b.max);
	}
	
	public static float GetSizeRatio(this Bounds b, Bounds compareTo)
	{
		float bLength = b.GetDiagonalLength();
		float compareLength = compareTo.GetDiagonalLength();
		return bLength == 0f ? 1f : compareLength/bLength;
	}
}
