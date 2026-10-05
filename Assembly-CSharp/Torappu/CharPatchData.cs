using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000F76 RID: 3958
	[Token(Token = "0x2000F76")]
	public class CharPatchData
	{
		// Token: 0x06006CA5 RID: 27813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CA5")]
		[Address(RVA = "0x20FF500", Offset = "0x20FE100", VA = "0x1820FF500")]
		public CharPatchData()
		{
		}

		// Token: 0x04005405 RID: 21509
		[Token(Token = "0x4005405")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, CharPatchData.PatchInfo> infos;

		// Token: 0x04005406 RID: 21510
		[Token(Token = "0x4005406")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CharacterData> patchChars;

		// Token: 0x04005407 RID: 21511
		[Token(Token = "0x4005407")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CharPatchData.UnlockCond> unlockConds;

		// Token: 0x04005408 RID: 21512
		[Token(Token = "0x4005408")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CharPatchData.PatchDetailInfo> patchDetailInfoList;

		// Token: 0x02000F77 RID: 3959
		[Token(Token = "0x2000F77")]
		public class PatchInfo
		{
			// Token: 0x06006CA6 RID: 27814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CA6")]
			[Address(RVA = "0x21091B0", Offset = "0x2107DB0", VA = "0x1821091B0")]
			public PatchInfo()
			{
			}

			// Token: 0x04005409 RID: 21513
			[Token(Token = "0x4005409")]
			[FieldOffset(Offset = "0x10")]
			public List<string> tmplIds;

			// Token: 0x0400540A RID: 21514
			[Token(Token = "0x400540A")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "default")]
			public string defaultPatch;
		}

		// Token: 0x02000F78 RID: 3960
		[Token(Token = "0x2000F78")]
		public class UnlockCond
		{
			// Token: 0x06006CA7 RID: 27815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CA7")]
			[Address(RVA = "0x2117930", Offset = "0x2116530", VA = "0x182117930")]
			public UnlockCond()
			{
			}

			// Token: 0x0400540B RID: 21515
			[Token(Token = "0x400540B")]
			[FieldOffset(Offset = "0x10")]
			public List<CharPatchData.UnlockCond.Item> conds;

			// Token: 0x02000F79 RID: 3961
			[Token(Token = "0x2000F79")]
			public class Item
			{
				// Token: 0x06006CA8 RID: 27816 RVA: 0x00031968 File Offset: 0x0002FB68
				[Token(Token = "0x6006CA8")]
				[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
				public bool ShouldSerializeunlockTs()
				{
					return default(bool);
				}

				// Token: 0x06006CA9 RID: 27817 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006CA9")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Item()
				{
				}

				// Token: 0x0400540C RID: 21516
				[Token(Token = "0x400540C")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x0400540D RID: 21517
				[Token(Token = "0x400540D")]
				[FieldOffset(Offset = "0x18")]
				public PlayerBattleRank completeState;

				// Token: 0x0400540E RID: 21518
				[Token(Token = "0x400540E")]
				[FieldOffset(Offset = "0x20")]
				public long unlockTs;
			}
		}

		// Token: 0x02000F7A RID: 3962
		[Token(Token = "0x2000F7A")]
		public class PatchDetailInfo
		{
			// Token: 0x06006CAA RID: 27818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CAA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PatchDetailInfo()
			{
			}

			// Token: 0x0400540F RID: 21519
			[Token(Token = "0x400540F")]
			[FieldOffset(Offset = "0x10")]
			public string patchId;

			// Token: 0x04005410 RID: 21520
			[Token(Token = "0x4005410")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04005411 RID: 21521
			[Token(Token = "0x4005411")]
			[FieldOffset(Offset = "0x20")]
			public string infoParam;

			// Token: 0x04005412 RID: 21522
			[Token(Token = "0x4005412")]
			[FieldOffset(Offset = "0x28")]
			public int transSortId;
		}
	}
}
