using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012D9 RID: 4825
	[Token(Token = "0x20012D9")]
	public class SandboxV2ArchiveQuestData : IComparable<SandboxV2ArchiveQuestData>
	{
		// Token: 0x06007252 RID: 29266 RVA: 0x00032D78 File Offset: 0x00030F78
		[Token(Token = "0x6007252")]
		[Address(RVA = "0x220E480", Offset = "0x220D080", VA = "0x18220E480", Slot = "4")]
		public int CompareTo(SandboxV2ArchiveQuestData other)
		{
			return 0;
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007253")]
		[Address(RVA = "0x220E4D0", Offset = "0x220D0D0", VA = "0x18220E4D0")]
		public string GetAvgFuncId()
		{
			return null;
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007254")]
		[Address(RVA = "0x220E510", Offset = "0x220D110", VA = "0x18220E510")]
		public string GetCgFuncId(string cgId)
		{
			return null;
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007255")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ArchiveQuestData()
		{
		}

		// Token: 0x04006A8F RID: 27279
		[Token(Token = "0x4006A8F")]
		private const string FORMAT_AVG_ID = "avg_{0}";

		// Token: 0x04006A90 RID: 27280
		[Token(Token = "0x4006A90")]
		private const string FORMAT_CG_ID = "cg_{0}_{1}";

		// Token: 0x04006A91 RID: 27281
		[Token(Token = "0x4006A91")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006A92 RID: 27282
		[Token(Token = "0x4006A92")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006A93 RID: 27283
		[Token(Token = "0x4006A93")]
		[FieldOffset(Offset = "0x1C")]
		public SandboxV2ArchiveQuestType questType;

		// Token: 0x04006A94 RID: 27284
		[Token(Token = "0x4006A94")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04006A95 RID: 27285
		[Token(Token = "0x4006A95")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04006A96 RID: 27286
		[Token(Token = "0x4006A96")]
		[FieldOffset(Offset = "0x30")]
		public List<SandboxV2ArchiveQuestAvgData> avgDataList;

		// Token: 0x04006A97 RID: 27287
		[Token(Token = "0x4006A97")]
		[FieldOffset(Offset = "0x38")]
		public List<SandboxV2ArchiveQuestCgData> cgDataList;

		// Token: 0x04006A98 RID: 27288
		[Token(Token = "0x4006A98")]
		[FieldOffset(Offset = "0x40")]
		public List<string> npcPicIdList;

		// Token: 0x04006A99 RID: 27289
		[Token(Token = "0x4006A99")]
		[FieldOffset(Offset = "0x48")]
		public SandboxV2ArchiveQuestZoneData zoneData;
	}
}
