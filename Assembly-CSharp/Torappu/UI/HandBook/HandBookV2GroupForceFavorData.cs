using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006728 RID: 26408
	[Token(Token = "0x2006728")]
	public class HandBookV2GroupForceFavorData
	{
		// Token: 0x170059B7 RID: 22967
		// (get) Token: 0x06025E0F RID: 155151 RVA: 0x000C94B0 File Offset: 0x000C76B0
		[Token(Token = "0x170059B7")]
		public float avgFavor
		{
			[Token(Token = "0x6025E0F")]
			[Address(RVA = "0x20DE490", Offset = "0x20DD090", VA = "0x1820DE490")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06025E10 RID: 155152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E10")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2GroupForceFavorData()
		{
		}

		// Token: 0x0403547D RID: 218237
		[Token(Token = "0x403547D")]
		[FieldOffset(Offset = "0x10")]
		public int charCount;

		// Token: 0x0403547E RID: 218238
		[Token(Token = "0x403547E")]
		[FieldOffset(Offset = "0x14")]
		public int totalFavor;

		// Token: 0x0403547F RID: 218239
		[Token(Token = "0x403547F")]
		[FieldOffset(Offset = "0x18")]
		public bool isAvail;
	}
}
