using System;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	public static class DOTweenUtils
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x375A8F0", Offset = "0x37594F0", VA = "0x18375A8F0")]
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude)
		{
			return default(Vector3);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x375A220", Offset = "0x3758E20", VA = "0x18375A220")]
		internal static float Angle2D(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x375A790", Offset = "0x3759390", VA = "0x18375A790")]
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation)
		{
			return default(Vector3);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x375A700", Offset = "0x3759300", VA = "0x18375A700")]
		public static Vector2 GetPointOnCircle(Vector2 center, float radius, float degrees)
		{
			return default(Vector2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x375A880", Offset = "0x3759480", VA = "0x18375A880")]
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x375A420", Offset = "0x3759020", VA = "0x18375A420")]
		internal static Type GetLooseScriptType(string typeName)
		{
			return null;
		}

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x0")]
		private static Assembly[] _loadedAssemblies;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] _defAssembliesToQuery;
	}
}
