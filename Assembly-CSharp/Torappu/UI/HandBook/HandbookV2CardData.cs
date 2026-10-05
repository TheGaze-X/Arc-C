using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066DE RID: 26334
	[Token(Token = "0x20066DE")]
	[Serializable]
	public class HandbookV2CardData
	{
		// Token: 0x06025C9B RID: 154779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C9B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookV2CardData()
		{
		}

		// Token: 0x04035223 RID: 217635
		[Token(Token = "0x4035223")]
		[FieldOffset(Offset = "0x10")]
		public string charID;

		// Token: 0x04035224 RID: 217636
		[Token(Token = "0x4035224")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 pos;

		// Token: 0x04035225 RID: 217637
		[Token(Token = "0x4035225")]
		[FieldOffset(Offset = "0x20")]
		public float lvl;

		// Token: 0x04035226 RID: 217638
		[Token(Token = "0x4035226")]
		[FieldOffset(Offset = "0x28")]
		public string name;
	}
}
