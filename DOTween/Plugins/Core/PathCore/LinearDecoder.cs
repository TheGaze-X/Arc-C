using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening.Plugins.Core.PathCore
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	internal class LinearDecoder : ABSPathDecoder
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x1700000D")]
		internal override int minInputWaypoints
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x374ABE0", Offset = "0x37497E0", VA = "0x18374ABE0", Slot = "4")]
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x374AC50", Offset = "0x3749850", VA = "0x18374AC50", Slot = "5")]
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints)
		{
			return default(Vector3);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x374AE50", Offset = "0x3749A50", VA = "0x18374AE50")]
		internal void SetTimeToLengthTables(Path p, int subdivisions)
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		internal void SetWaypointsLengths(Path p, int subdivisions)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LinearDecoder()
		{
		}
	}
}
