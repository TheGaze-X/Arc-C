using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B4A RID: 2890
	[Token(Token = "0x2000B4A")]
	public class PlayerDeepSea
	{
		// Token: 0x060067F6 RID: 26614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0x1EF96E0", Offset = "0x1EF82E0", VA = "0x181EF96E0")]
		public PlayerDeepSea()
		{
		}

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerDeepSea.PlaceStatus> places;

		// Token: 0x04003C4D RID: 15437
		[Token(Token = "0x4003C4D")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerDeepSea.NodeStatus> nodes;

		// Token: 0x04003C4E RID: 15438
		[Token(Token = "0x4003C4E")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, List<PlayerDeepSea.ChoiceStatus>> choices;

		// Token: 0x04003C4F RID: 15439
		[Token(Token = "0x4003C4F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerDeepSea.ReadStatus> events;

		// Token: 0x04003C50 RID: 15440
		[Token(Token = "0x4003C50")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PlayerDeepSea.TreasureStatus> treasures;

		// Token: 0x04003C51 RID: 15441
		[Token(Token = "0x4003C51")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, PlayerDeepSea.ReadStatus> stories;

		// Token: 0x04003C52 RID: 15442
		[Token(Token = "0x4003C52")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, PlayerDeepSea.TechData> techTrees;

		// Token: 0x04003C53 RID: 15443
		[Token(Token = "0x4003C53")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, List<string>> logs;

		// Token: 0x02000B4B RID: 2891
		[Token(Token = "0x2000B4B")]
		public enum PlaceStatus
		{
			// Token: 0x04003C55 RID: 15445
			[Token(Token = "0x4003C55")]
			INVISIBLE,
			// Token: 0x04003C56 RID: 15446
			[Token(Token = "0x4003C56")]
			UNKNOWN,
			// Token: 0x04003C57 RID: 15447
			[Token(Token = "0x4003C57")]
			DISCOVERED
		}

		// Token: 0x02000B4C RID: 2892
		[Token(Token = "0x2000B4C")]
		public enum NodeStatus
		{
			// Token: 0x04003C59 RID: 15449
			[Token(Token = "0x4003C59")]
			LOCKED,
			// Token: 0x04003C5A RID: 15450
			[Token(Token = "0x4003C5A")]
			UNLOCK,
			// Token: 0x04003C5B RID: 15451
			[Token(Token = "0x4003C5B")]
			TRIGGERED
		}

		// Token: 0x02000B4D RID: 2893
		[Token(Token = "0x2000B4D")]
		public enum ChoiceStatus
		{
			// Token: 0x04003C5D RID: 15453
			[Token(Token = "0x4003C5D")]
			LOCKED,
			// Token: 0x04003C5E RID: 15454
			[Token(Token = "0x4003C5E")]
			UNLOCK,
			// Token: 0x04003C5F RID: 15455
			[Token(Token = "0x4003C5F")]
			SELECTED
		}

		// Token: 0x02000B4E RID: 2894
		[Token(Token = "0x2000B4E")]
		public enum ReadStatus
		{
			// Token: 0x04003C61 RID: 15457
			[Token(Token = "0x4003C61")]
			UNREAD,
			// Token: 0x04003C62 RID: 15458
			[Token(Token = "0x4003C62")]
			READ
		}

		// Token: 0x02000B4F RID: 2895
		[Token(Token = "0x2000B4F")]
		public enum TreasureStatus
		{
			// Token: 0x04003C64 RID: 15460
			[Token(Token = "0x4003C64")]
			NOTGOT,
			// Token: 0x04003C65 RID: 15461
			[Token(Token = "0x4003C65")]
			GOT
		}

		// Token: 0x02000B50 RID: 2896
		[Token(Token = "0x2000B50")]
		public enum TechStatus
		{
			// Token: 0x04003C67 RID: 15463
			[Token(Token = "0x4003C67")]
			LOCKED,
			// Token: 0x04003C68 RID: 15464
			[Token(Token = "0x4003C68")]
			UNLOCK,
			// Token: 0x04003C69 RID: 15465
			[Token(Token = "0x4003C69")]
			ACTIVED
		}

		// Token: 0x02000B51 RID: 2897
		[Token(Token = "0x2000B51")]
		public class TechData
		{
			// Token: 0x060067F7 RID: 26615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067F7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TechData()
			{
			}

			// Token: 0x04003C6A RID: 15466
			[Token(Token = "0x4003C6A")]
			[FieldOffset(Offset = "0x10")]
			public PlayerDeepSea.TechStatus state;

			// Token: 0x04003C6B RID: 15467
			[Token(Token = "0x4003C6B")]
			[FieldOffset(Offset = "0x18")]
			public string branch;
		}
	}
}
