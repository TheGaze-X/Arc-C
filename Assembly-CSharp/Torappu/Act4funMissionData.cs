using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EAE RID: 3758
	[Token(Token = "0x2000EAE")]
	public class Act4funMissionData
	{
		// Token: 0x06006B80 RID: 27520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B80")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act4funMissionData()
		{
		}

		// Token: 0x04004F58 RID: 20312
		[Token(Token = "0x4004F58")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x04004F59 RID: 20313
		[Token(Token = "0x4004F59")]
		[FieldOffset(Offset = "0x18")]
		public string sortId;

		// Token: 0x04004F5A RID: 20314
		[Token(Token = "0x4004F5A")]
		[FieldOffset(Offset = "0x20")]
		public string missionDes;

		// Token: 0x04004F5B RID: 20315
		[Token(Token = "0x4004F5B")]
		[FieldOffset(Offset = "0x28")]
		public List<string> rewardIconIds;

		// Token: 0x04004F5C RID: 20316
		[Token(Token = "0x4004F5C")]
		[FieldOffset(Offset = "0x30")]
		public List<ItemBundle> rewards;
	}
}
