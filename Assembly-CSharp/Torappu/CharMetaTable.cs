using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F75 RID: 3957
	[Token(Token = "0x2000F75")]
	[Serializable]
	public class CharMetaTable
	{
		// Token: 0x06006CA4 RID: 27812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA4")]
		[Address(RVA = "0x20FF360", Offset = "0x20FDF60", VA = "0x1820FF360")]
		public CharMetaTable()
		{
		}

		// Token: 0x04005400 RID: 21504
		[Token(Token = "0x4005400")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<string>> spCharGroups;

		// Token: 0x04005401 RID: 21505
		[Token(Token = "0x4005401")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Dictionary<string, SpCharMissionData>> spCharMissions;

		// Token: 0x04005402 RID: 21506
		[Token(Token = "0x4005402")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, long> spCharVoucherSkinTime;

		// Token: 0x04005403 RID: 21507
		[Token(Token = "0x4005403")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<string>> charIdMasterListMap;

		// Token: 0x04005404 RID: 21508
		[Token(Token = "0x4005404")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, CharMasterBasicData> charMasterDataMap;
	}
}
