using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F44 RID: 3908
	[Token(Token = "0x2000F44")]
	[Serializable]
	public class CampaignZoneData
	{
		// Token: 0x06006C4F RID: 27727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignZoneData()
		{
		}

		// Token: 0x04005317 RID: 21271
		[Token(Token = "0x4005317")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005318 RID: 21272
		[Token(Token = "0x4005318")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005319 RID: 21273
		[Token(Token = "0x4005319")]
		[FieldOffset(Offset = "0x20")]
		public string regionId;

		// Token: 0x0400531A RID: 21274
		[Token(Token = "0x400531A")]
		[FieldOffset(Offset = "0x28")]
		public string templateId;
	}
}
