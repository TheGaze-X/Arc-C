using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	public class TowerOuter
	{
		// Token: 0x0600680B RID: 26635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680B")]
		[Address(RVA = "0x1F02BB0", Offset = "0x1F017B0", VA = "0x181F02BB0")]
		public TowerOuter()
		{
		}

		// Token: 0x04003CD2 RID: 15570
		[Token(Token = "0x4003CD2")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> training;

		// Token: 0x04003CD3 RID: 15571
		[Token(Token = "0x4003CD3")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, TowerOuter.TowerData> towers;

		// Token: 0x04003CD4 RID: 15572
		[Token(Token = "0x4003CD4")]
		[FieldOffset(Offset = "0x20")]
		public int hasTowerPass;

		// Token: 0x04003CD5 RID: 15573
		[Token(Token = "0x4003CD5")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty(PropertyName = "pickedGodCard")]
		public Dictionary<string, string[]> pickedCardMap;

		// Token: 0x04003CD6 RID: 15574
		[Token(Token = "0x4003CD6")]
		[FieldOffset(Offset = "0x30")]
		public TowerTactical tactical;

		// Token: 0x04003CD7 RID: 15575
		[Token(Token = "0x4003CD7")]
		[FieldOffset(Offset = "0x38")]
		public TowerGameStrategy strategy;

		// Token: 0x04003CD8 RID: 15576
		[Token(Token = "0x4003CD8")]
		[FieldOffset(Offset = "0x40")]
		public PlayerSquadItem[] squad;

		// Token: 0x02000B6E RID: 2926
		[Token(Token = "0x2000B6E")]
		public class TowerData
		{
			// Token: 0x0600680C RID: 26636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600680C")]
			[Address(RVA = "0x1F02B20", Offset = "0x1F01720", VA = "0x181F02B20")]
			public TowerData()
			{
			}

			// Token: 0x04003CD9 RID: 15577
			[Token(Token = "0x4003CD9")]
			[FieldOffset(Offset = "0x10")]
			public int best;

			// Token: 0x04003CDA RID: 15578
			[Token(Token = "0x4003CDA")]
			[FieldOffset(Offset = "0x18")]
			public List<int> reward;

			// Token: 0x04003CDB RID: 15579
			[Token(Token = "0x4003CDB")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "unlockHard")]
			public bool isHardValid;

			// Token: 0x04003CDC RID: 15580
			[Token(Token = "0x4003CDC")]
			[FieldOffset(Offset = "0x24")]
			public int hardBest;

			// Token: 0x04003CDD RID: 15581
			[Token(Token = "0x4003CDD")]
			[FieldOffset(Offset = "0x28")]
			public bool canSweep;

			// Token: 0x04003CDE RID: 15582
			[Token(Token = "0x4003CDE")]
			[FieldOffset(Offset = "0x29")]
			public bool canSweepHard;
		}
	}
}
