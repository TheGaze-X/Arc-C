using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x02002063 RID: 8291
	[Token(Token = "0x2002063")]
	[Serializable]
	public class HighlightPolluteTileProfile : HighlightTileProfile
	{
		// Token: 0x0600CC33 RID: 52275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CC33")]
		[Address(RVA = "0x34D5C20", Offset = "0x34D4820", VA = "0x1834D5C20")]
		public HighlightPolluteTileProfile()
		{
		}

		// Token: 0x0400D6AC RID: 54956
		[Token(Token = "0x400D6AC")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float gapForUseAnim;
	}
}
