using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F48 RID: 3912
	[Token(Token = "0x2000F48")]
	[Serializable]
	public class CampaignMissionData
	{
		// Token: 0x06006C53 RID: 27731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignMissionData()
		{
		}

		// Token: 0x04005329 RID: 21289
		[Token(Token = "0x4005329")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400532A RID: 21290
		[Token(Token = "0x400532A")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0400532B RID: 21291
		[Token(Token = "0x400532B")]
		[FieldOffset(Offset = "0x20")]
		public string[] param;

		// Token: 0x0400532C RID: 21292
		[Token(Token = "0x400532C")]
		[FieldOffset(Offset = "0x28")]
		public string description;

		// Token: 0x0400532D RID: 21293
		[Token(Token = "0x400532D")]
		[FieldOffset(Offset = "0x30")]
		public int breakFeeAdd;
	}
}
