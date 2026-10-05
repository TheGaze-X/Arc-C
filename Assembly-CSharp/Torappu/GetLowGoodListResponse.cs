using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200087B RID: 2171
	[Token(Token = "0x200087B")]
	public class GetLowGoodListResponse : PlayerDeltaResponse, IQCShopGetResponse, IShopGetResposne
	{
		// Token: 0x06006517 RID: 25879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006517")]
		[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "5")]
		public List<string> GetNewFlag()
		{
			return null;
		}

		// Token: 0x06006518 RID: 25880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006518")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetLowGoodListResponse()
		{
		}

		// Token: 0x040031ED RID: 12781
		[Token(Token = "0x40031ED")]
		[FieldOffset(Offset = "0x28")]
		public List<QCObject> goodList;

		// Token: 0x040031EE RID: 12782
		[Token(Token = "0x40031EE")]
		[FieldOffset(Offset = "0x30")]
		public List<string> groups;

		// Token: 0x040031EF RID: 12783
		[Token(Token = "0x40031EF")]
		[FieldOffset(Offset = "0x38")]
		public List<LowGoodGroupUnlock> groupsInfo;

		// Token: 0x040031F0 RID: 12784
		[Token(Token = "0x40031F0")]
		[FieldOffset(Offset = "0x40")]
		public long shopEndTime;

		// Token: 0x040031F1 RID: 12785
		[Token(Token = "0x40031F1")]
		[FieldOffset(Offset = "0x48")]
		public List<string> newFlag;

		// Token: 0x040031F2 RID: 12786
		[Token(Token = "0x40031F2")]
		[FieldOffset(Offset = "0x50")]
		public int type;
	}
}
