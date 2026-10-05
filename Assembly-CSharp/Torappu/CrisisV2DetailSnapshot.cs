using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FDF RID: 4063
	[Token(Token = "0x2000FDF")]
	public class CrisisV2DetailSnapshot : CrisisV2SnapShotBase
	{
		// Token: 0x06006D35 RID: 27957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D35")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2DetailSnapshot()
		{
		}

		// Token: 0x04005630 RID: 22064
		[Token(Token = "0x4005630")]
		[FieldOffset(Offset = "0x38")]
		public int leftHp;

		// Token: 0x04005631 RID: 22065
		[Token(Token = "0x4005631")]
		[FieldOffset(Offset = "0x40")]
		public List<int> scoreRecord;

		// Token: 0x04005632 RID: 22066
		[Token(Token = "0x4005632")]
		[FieldOffset(Offset = "0x48")]
		public List<SharedCharData> squad;

		// Token: 0x04005633 RID: 22067
		[Token(Token = "0x4005633")]
		[FieldOffset(Offset = "0x50")]
		public SharedCharData assistFriend;
	}
}
