using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal class CatmullRomDecoder : ABSPathDecoder
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x1700000C")]
		internal override int minInputWaypoints
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x37444D0", Offset = "0x37430D0", VA = "0x1837444D0", Slot = "4")]
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x3744830", Offset = "0x3743430", VA = "0x183744830", Slot = "5")]
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x3744CA0", Offset = "0x37438A0", VA = "0x183744CA0")]
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x3744FC0", Offset = "0x3743BC0", VA = "0x183744FC0")]
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CatmullRomDecoder()
		{
		}

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ControlPoint[] _PartialControlPs;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector3[] _PartialWps;
	}
}
