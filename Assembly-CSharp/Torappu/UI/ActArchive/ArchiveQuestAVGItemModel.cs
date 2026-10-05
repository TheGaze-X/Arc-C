using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BFD RID: 27645
	[Token(Token = "0x2006BFD")]
	public class ArchiveQuestAVGItemModel : IHotfixable
	{
		// Token: 0x06027799 RID: 161689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027799")]
		[Address(RVA = "0x22A8C90", Offset = "0x22A7890", VA = "0x1822A8C90")]
		public ArchiveQuestAVGItemModel()
		{
		}

		// Token: 0x04037F24 RID: 229156
		[Token(Token = "0x4037F24")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2ArchiveQuestType questType;

		// Token: 0x04037F25 RID: 229157
		[Token(Token = "0x4037F25")]
		[FieldOffset(Offset = "0x18")]
		public string questTypeName;

		// Token: 0x04037F26 RID: 229158
		[Token(Token = "0x4037F26")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04037F27 RID: 229159
		[Token(Token = "0x4037F27")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04037F28 RID: 229160
		[Token(Token = "0x4037F28")]
		[FieldOffset(Offset = "0x30")]
		public List<SandboxV2ArchiveQuestAvgData> avgDataList;

		// Token: 0x04037F29 RID: 229161
		[Token(Token = "0x4037F29")]
		[FieldOffset(Offset = "0x38")]
		public List<string> npcPicIdList;

		// Token: 0x04037F2A RID: 229162
		[Token(Token = "0x4037F2A")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2ArchiveQuestZoneData zoneData;

		// Token: 0x04037F2B RID: 229163
		[Token(Token = "0x4037F2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
