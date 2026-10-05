using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public struct BattleOutlineConfig
	{
		// Token: 0x04001FFB RID: 8187
		[Token(Token = "0x4001FFB")]
		[FieldOffset(Offset = "0x0")]
		public float outlineSize;

		// Token: 0x04001FFC RID: 8188
		[Token(Token = "0x4001FFC")]
		[FieldOffset(Offset = "0x4")]
		public Color outlineColor;

		// Token: 0x04001FFD RID: 8189
		[Token(Token = "0x4001FFD")]
		[FieldOffset(Offset = "0x14")]
		public bool useEightWays;
	}
}
