using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public static class DOCurve
	{
		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public static class CubicBezier
		{
			// Token: 0x06000011 RID: 17 RVA: 0x0000209C File Offset: 0x0000029C
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x371FA30", Offset = "0x371E630", VA = "0x18371FA30")]
			public static Vector3 GetPointOnSegment(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, float factor)
			{
				return default(Vector3);
			}

			// Token: 0x06000012 RID: 18 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x371FBB0", Offset = "0x371E7B0", VA = "0x18371FBB0")]
			public static Vector3[] GetSegmentPointCloud(Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10)
			{
				return null;
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x371FEA0", Offset = "0x371EAA0", VA = "0x18371FEA0")]
			public static void GetSegmentPointCloud(List<Vector3> addToList, Vector3 startPoint, Vector3 startControlPoint, Vector3 endPoint, Vector3 endControlPoint, int resolution = 10)
			{
			}
		}
	}
}
