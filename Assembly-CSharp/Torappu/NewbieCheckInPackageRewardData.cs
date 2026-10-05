using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001124 RID: 4388
	[Token(Token = "0x2001124")]
	public class NewbieCheckInPackageRewardData
	{
		// Token: 0x06006EE8 RID: 28392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NewbieCheckInPackageRewardData()
		{
		}

		// Token: 0x04005E11 RID: 24081
		[Token(Token = "0x4005E11")]
		[FieldOffset(Offset = "0x10")]
		public int orderNum;

		// Token: 0x04005E12 RID: 24082
		[Token(Token = "0x4005E12")]
		[FieldOffset(Offset = "0x18")]
		public ItemBundle itemBundle;
	}
}
