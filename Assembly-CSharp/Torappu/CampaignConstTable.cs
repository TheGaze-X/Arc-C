using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F49 RID: 3913
	[Token(Token = "0x2000F49")]
	[Serializable]
	public class CampaignConstTable
	{
		// Token: 0x06006C54 RID: 27732 RVA: 0x000316C8 File Offset: 0x0002F8C8
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0x20078A0", Offset = "0x20064A0", VA = "0x1820078A0")]
		public bool ShouldSerializesweepStartTime()
		{
			return default(bool);
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C55")]
		[Address(RVA = "0x20078B0", Offset = "0x20064B0", VA = "0x1820078B0")]
		public CampaignConstTable()
		{
		}

		// Token: 0x0400532E RID: 21294
		[Token(Token = "0x400532E")]
		[FieldOffset(Offset = "0x10")]
		public string systemPreposedStage;

		// Token: 0x0400532F RID: 21295
		[Token(Token = "0x400532F")]
		[FieldOffset(Offset = "0x18")]
		public long rotateStartTime;

		// Token: 0x04005330 RID: 21296
		[Token(Token = "0x4005330")]
		[FieldOffset(Offset = "0x20")]
		public string rotatePreposedStage;

		// Token: 0x04005331 RID: 21297
		[Token(Token = "0x4005331")]
		[FieldOffset(Offset = "0x28")]
		public string zoneUnlockStage;

		// Token: 0x04005332 RID: 21298
		[Token(Token = "0x4005332")]
		[FieldOffset(Offset = "0x30")]
		public string firstRotateRegion;

		// Token: 0x04005333 RID: 21299
		[Token(Token = "0x4005333")]
		[FieldOffset(Offset = "0x38")]
		public long sweepStartTime;
	}
}
