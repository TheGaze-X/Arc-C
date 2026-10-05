using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C6 RID: 6342
	[Token(Token = "0x20018C6")]
	public class GridLocator
	{
		// Token: 0x0600A00C RID: 40972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A00C")]
		[Address(RVA = "0x31B5AB0", Offset = "0x31B46B0", VA = "0x1831B5AB0")]
		public GridLocator(float[,] calcMat)
		{
		}

		// Token: 0x0600A00D RID: 40973 RVA: 0x0003E6B8 File Offset: 0x0003C8B8
		[Token(Token = "0x600A00D")]
		[Address(RVA = "0x31B5950", Offset = "0x31B4550", VA = "0x1831B5950")]
		public Vector3 GetLocation(int pos0, int pos1)
		{
			return default(Vector3);
		}

		// Token: 0x0400966D RID: 38509
		[Token(Token = "0x400966D")]
		[FieldOffset(Offset = "0x10")]
		private float[,] _calculationMatrix;
	}
}
