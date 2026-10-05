using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006721 RID: 26401
	[Token(Token = "0x2006721")]
	public class HandBookV2PointLineViewModel
	{
		// Token: 0x06025E01 RID: 155137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E01")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2PointLineViewModel()
		{
		}

		// Token: 0x0403545E RID: 218206
		[Token(Token = "0x403545E")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0403545F RID: 218207
		[Token(Token = "0x403545F")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 fromPos;

		// Token: 0x04035460 RID: 218208
		[Token(Token = "0x4035460")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 toPos;

		// Token: 0x04035461 RID: 218209
		[Token(Token = "0x4035461")]
		[FieldOffset(Offset = "0x28")]
		public string htmlColor;
	}
}
