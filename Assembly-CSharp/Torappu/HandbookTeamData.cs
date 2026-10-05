using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010A0 RID: 4256
	[Token(Token = "0x20010A0")]
	[Serializable]
	public class HandbookTeamData
	{
		// Token: 0x06006E2B RID: 28203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E2B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookTeamData()
		{
		}

		// Token: 0x04005AC8 RID: 23240
		[Token(Token = "0x4005AC8")]
		[FieldOffset(Offset = "0x10")]
		public string powerId;

		// Token: 0x04005AC9 RID: 23241
		[Token(Token = "0x4005AC9")]
		[FieldOffset(Offset = "0x18")]
		public int orderNum;

		// Token: 0x04005ACA RID: 23242
		[Token(Token = "0x4005ACA")]
		[FieldOffset(Offset = "0x1C")]
		public int powerLevel;

		// Token: 0x04005ACB RID: 23243
		[Token(Token = "0x4005ACB")]
		[FieldOffset(Offset = "0x20")]
		public string powerName;

		// Token: 0x04005ACC RID: 23244
		[Token(Token = "0x4005ACC")]
		[FieldOffset(Offset = "0x28")]
		public string powerCode;

		// Token: 0x04005ACD RID: 23245
		[Token(Token = "0x4005ACD")]
		[FieldOffset(Offset = "0x30")]
		public string color;

		// Token: 0x04005ACE RID: 23246
		[Token(Token = "0x4005ACE")]
		[FieldOffset(Offset = "0x38")]
		public bool isLimited;

		// Token: 0x04005ACF RID: 23247
		[Token(Token = "0x4005ACF")]
		[FieldOffset(Offset = "0x39")]
		public bool isRaw;
	}
}
