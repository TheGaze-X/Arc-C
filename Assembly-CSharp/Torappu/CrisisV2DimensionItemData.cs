using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC1 RID: 4033
	[Token(Token = "0x2000FC1")]
	public class CrisisV2DimensionItemData
	{
		// Token: 0x06006D0B RID: 27915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2DimensionItemData()
		{
		}

		// Token: 0x0400559F RID: 21919
		[Token(Token = "0x400559F")]
		[FieldOffset(Offset = "0x10")]
		public string desc;

		// Token: 0x040055A0 RID: 21920
		[Token(Token = "0x40055A0")]
		[FieldOffset(Offset = "0x18")]
		public int maxScore;
	}
}
