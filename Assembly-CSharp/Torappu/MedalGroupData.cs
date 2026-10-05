using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010EC RID: 4332
	[Token(Token = "0x20010EC")]
	public class MedalGroupData
	{
		// Token: 0x06006E93 RID: 28307 RVA: 0x000321A8 File Offset: 0x000303A8
		[Token(Token = "0x6006E93")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public virtual bool ShouldSerializesharedExpireTimes()
		{
			return default(bool);
		}

		// Token: 0x06006E94 RID: 28308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E94")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MedalGroupData()
		{
		}

		// Token: 0x04005CDB RID: 23771
		[Token(Token = "0x4005CDB")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005CDC RID: 23772
		[Token(Token = "0x4005CDC")]
		[FieldOffset(Offset = "0x18")]
		public string groupName;

		// Token: 0x04005CDD RID: 23773
		[Token(Token = "0x4005CDD")]
		[FieldOffset(Offset = "0x20")]
		public string groupDesc;

		// Token: 0x04005CDE RID: 23774
		[Token(Token = "0x4005CDE")]
		[FieldOffset(Offset = "0x28")]
		public List<string> medalId;

		// Token: 0x04005CDF RID: 23775
		[Token(Token = "0x4005CDF")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04005CE0 RID: 23776
		[Token(Token = "0x4005CE0")]
		[FieldOffset(Offset = "0x38")]
		public string groupBackColor;

		// Token: 0x04005CE1 RID: 23777
		[Token(Token = "0x4005CE1")]
		[FieldOffset(Offset = "0x40")]
		public long groupGetTime;

		// Token: 0x04005CE2 RID: 23778
		[Token(Token = "0x4005CE2")]
		[FieldOffset(Offset = "0x48")]
		public List<MedalExpireTime> sharedExpireTimes;
	}
}
