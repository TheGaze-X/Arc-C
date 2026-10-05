using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	internal class CubicBezierDecoder : ABSPathDecoder
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x1700000A")]
		internal override int minInputWaypoints
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x3746900", Offset = "0x3745500", VA = "0x183746900", Slot = "4")]
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x3746F30", Offset = "0x3745B30", VA = "0x183746F30", Slot = "5")]
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x37471B0", Offset = "0x3745DB0", VA = "0x1837471B0")]
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x37474D0", Offset = "0x37460D0", VA = "0x1837474D0")]
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CubicBezierDecoder()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ControlPoint[] _PartialControlPs;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector3[] _PartialWps;
	}
}
