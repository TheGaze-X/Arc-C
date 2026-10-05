using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E5E RID: 3678
	[Token(Token = "0x2000E5E")]
	public class ActVecBreakV2OffenseStageData
	{
		// Token: 0x06006B2B RID: 27435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActVecBreakV2OffenseStageData()
		{
		}

		// Token: 0x04004D04 RID: 19716
		[Token(Token = "0x4004D04")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004D05 RID: 19717
		[Token(Token = "0x4004D05")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04004D06 RID: 19718
		[Token(Token = "0x4004D06")]
		[FieldOffset(Offset = "0x20")]
		public string levelLayout;

		// Token: 0x04004D07 RID: 19719
		[Token(Token = "0x4004D07")]
		[FieldOffset(Offset = "0x28")]
		public string storyDesc;

		// Token: 0x04004D08 RID: 19720
		[Token(Token = "0x4004D08")]
		[FieldOffset(Offset = "0x30")]
		public ActVecBreakV2ParticleType particleType;

		// Token: 0x04004D09 RID: 19721
		[Token(Token = "0x4004D09")]
		[FieldOffset(Offset = "0x38")]
		public ActVecBreakV2BossData bossData;
	}
}
