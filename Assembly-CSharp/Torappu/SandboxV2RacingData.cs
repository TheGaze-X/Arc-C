using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F3 RID: 4851
	[Token(Token = "0x20012F3")]
	public class SandboxV2RacingData
	{
		// Token: 0x0600726C RID: 29292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726C")]
		[Address(RVA = "0x2210520", Offset = "0x220F120", VA = "0x182210520")]
		public SandboxV2RacingData()
		{
		}

		// Token: 0x04006B3C RID: 27452
		[Token(Token = "0x4006B3C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, SandboxV2RacerBasicInfo> racerBasicInfo;

		// Token: 0x04006B3D RID: 27453
		[Token(Token = "0x4006B3D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, SandboxV2RacerTalentInfo> racerTalentInfo;

		// Token: 0x04006B3E RID: 27454
		[Token(Token = "0x4006B3E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, SandboxV2RacerNameInfo> racerNameInfo;

		// Token: 0x04006B3F RID: 27455
		[Token(Token = "0x4006B3F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, SandboxV2RacerMedalInfo> racerMedalInfo;

		// Token: 0x04006B40 RID: 27456
		[Token(Token = "0x4006B40")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> enemyItemMap;

		// Token: 0x04006B41 RID: 27457
		[Token(Token = "0x4006B41")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, SandboxV2RacingItemInfo> racingItemInfo;

		// Token: 0x04006B42 RID: 27458
		[Token(Token = "0x4006B42")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2RacingConstData constData;
	}
}
