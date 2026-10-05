using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC2 RID: 4034
	[Token(Token = "0x2000FC2")]
	public class CrisisV2RewardItemData
	{
		// Token: 0x06006D0C RID: 27916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2RewardItemData()
		{
		}

		// Token: 0x040055A1 RID: 21921
		[Token(Token = "0x40055A1")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle reward;

		// Token: 0x040055A2 RID: 21922
		[Token(Token = "0x40055A2")]
		[FieldOffset(Offset = "0x18")]
		public bool isTimeLimit;
	}
}
