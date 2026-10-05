using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	public class PlayerGacha
	{
		// Token: 0x060066CD RID: 26317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066CD")]
		[Address(RVA = "0x1EFA670", Offset = "0x1EF9270", VA = "0x181EFA670")]
		public PlayerGacha()
		{
		}

		// Token: 0x04003779 RID: 14201
		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0x10")]
		public PlayerGacha.PlayerNewbeeGachaPool newbee;

		// Token: 0x0400377A RID: 14202
		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerGacha.PlayerGachaPool> normal;

		// Token: 0x0400377B RID: 14203
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerGacha.PlayerFreeLimitGacha> limit;

		// Token: 0x0400377C RID: 14204
		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ListDict<string, JObject>> linkage;

		// Token: 0x0400377D RID: 14205
		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, PlayerGacha.PlayerAttainGacha> attain;

		// Token: 0x0400377E RID: 14206
		[Token(Token = "0x400377E")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, PlayerGacha.PlayerSingleGacha> single;

		// Token: 0x0400377F RID: 14207
		[Token(Token = "0x400377F")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty(PropertyName = "double")]
		public Dictionary<string, PlayerGacha.PlayerDoubleGacha> doubleGacha;

		// Token: 0x04003780 RID: 14208
		[Token(Token = "0x4003780")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, PlayerGacha.PlayerFesClassicGacha> fesClassic;

		// Token: 0x04003781 RID: 14209
		[Token(Token = "0x4003781")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, PlayerGacha.PlayerSpecialGacha> special;

		// Token: 0x04003782 RID: 14210
		[Token(Token = "0x4003782")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, PlayerGacha.PlayerReturnGacha> backflow;

		// Token: 0x02000A0C RID: 2572
		[Token(Token = "0x2000A0C")]
		public class PlayerNewbeeGachaPool
		{
			// Token: 0x060066CE RID: 26318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066CE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerNewbeeGachaPool()
			{
			}

			// Token: 0x04003783 RID: 14211
			[Token(Token = "0x4003783")]
			[FieldOffset(Offset = "0x10")]
			public bool openFlag;

			// Token: 0x04003784 RID: 14212
			[Token(Token = "0x4003784")]
			[FieldOffset(Offset = "0x14")]
			public int cnt;

			// Token: 0x04003785 RID: 14213
			[Token(Token = "0x4003785")]
			[FieldOffset(Offset = "0x18")]
			public string poolId;
		}

		// Token: 0x02000A0D RID: 2573
		[Token(Token = "0x2000A0D")]
		public class PlayerGachaPool
		{
			// Token: 0x060066CF RID: 26319 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerGachaPool()
			{
			}

			// Token: 0x04003786 RID: 14214
			[Token(Token = "0x4003786")]
			[FieldOffset(Offset = "0x10")]
			public int cnt;

			// Token: 0x04003787 RID: 14215
			[Token(Token = "0x4003787")]
			[FieldOffset(Offset = "0x14")]
			public int maxCnt;

			// Token: 0x04003788 RID: 14216
			[Token(Token = "0x4003788")]
			[FieldOffset(Offset = "0x18")]
			public bool avail;
		}

		// Token: 0x02000A0E RID: 2574
		[Token(Token = "0x2000A0E")]
		public class PlayerFreeLimitGacha
		{
			// Token: 0x060066D0 RID: 26320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerFreeLimitGacha()
			{
			}

			// Token: 0x04003789 RID: 14217
			[Token(Token = "0x4003789")]
			[FieldOffset(Offset = "0x10")]
			public int leastFree;

			// Token: 0x0400378A RID: 14218
			[Token(Token = "0x400378A")]
			[FieldOffset(Offset = "0x14")]
			public int poolCnt;

			// Token: 0x0400378B RID: 14219
			[Token(Token = "0x400378B")]
			[FieldOffset(Offset = "0x18")]
			public bool recruitedFreeChar;
		}

		// Token: 0x02000A0F RID: 2575
		[Token(Token = "0x2000A0F")]
		public class PlayerAttainGacha
		{
			// Token: 0x060066D1 RID: 26321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAttainGacha()
			{
			}

			// Token: 0x0400378C RID: 14220
			[Token(Token = "0x400378C")]
			[FieldOffset(Offset = "0x10")]
			public int attain6Count;
		}

		// Token: 0x02000A10 RID: 2576
		[Token(Token = "0x2000A10")]
		public class PlayerSingleGacha
		{
			// Token: 0x060066D2 RID: 26322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerSingleGacha()
			{
			}

			// Token: 0x0400378D RID: 14221
			[Token(Token = "0x400378D")]
			[FieldOffset(Offset = "0x10")]
			public int cnt;

			// Token: 0x0400378E RID: 14222
			[Token(Token = "0x400378E")]
			[FieldOffset(Offset = "0x14")]
			public int maxCnt;

			// Token: 0x0400378F RID: 14223
			[Token(Token = "0x400378F")]
			[FieldOffset(Offset = "0x18")]
			public bool avail;

			// Token: 0x04003790 RID: 14224
			[Token(Token = "0x4003790")]
			[FieldOffset(Offset = "0x1C")]
			public int singleEnsureCnt;

			// Token: 0x04003791 RID: 14225
			[Token(Token = "0x4003791")]
			[FieldOffset(Offset = "0x20")]
			public bool singleEnsureUse;

			// Token: 0x04003792 RID: 14226
			[Token(Token = "0x4003792")]
			[FieldOffset(Offset = "0x28")]
			public string singleEnsureChar;
		}

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		public class PlayerDoubleGacha
		{
			// Token: 0x060066D3 RID: 26323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerDoubleGacha()
			{
			}

			// Token: 0x04003793 RID: 14227
			[Token(Token = "0x4003793")]
			[FieldOffset(Offset = "0x10")]
			public int showCnt;

			// Token: 0x04003794 RID: 14228
			[Token(Token = "0x4003794")]
			[FieldOffset(Offset = "0x14")]
			public PlayerGacha.PlayerDoubleGacha.HitCharState hitCharState;

			// Token: 0x04003795 RID: 14229
			[Token(Token = "0x4003795")]
			[FieldOffset(Offset = "0x18")]
			public string hitCharId;

			// Token: 0x02000A12 RID: 2578
			[Token(Token = "0x2000A12")]
			public enum HitCharState
			{
				// Token: 0x04003797 RID: 14231
				[Token(Token = "0x4003797")]
				NONE,
				// Token: 0x04003798 RID: 14232
				[Token(Token = "0x4003798")]
				FIRST,
				// Token: 0x04003799 RID: 14233
				[Token(Token = "0x4003799")]
				SECOND
			}
		}

		// Token: 0x02000A13 RID: 2579
		[Token(Token = "0x2000A13")]
		public class PlayerFesClassicGacha
		{
			// Token: 0x060066D4 RID: 26324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D4")]
			[Address(RVA = "0x1EFA1E0", Offset = "0x1EF8DE0", VA = "0x181EFA1E0")]
			public PlayerFesClassicGacha()
			{
			}

			// Token: 0x0400379A RID: 14234
			[Token(Token = "0x400379A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<string>> upChar;
		}

		// Token: 0x02000A14 RID: 2580
		[Token(Token = "0x2000A14")]
		public class PlayerSpecialGacha
		{
			// Token: 0x060066D5 RID: 26325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D5")]
			[Address(RVA = "0x1EFEBA0", Offset = "0x1EFD7A0", VA = "0x181EFEBA0")]
			public PlayerSpecialGacha()
			{
			}

			// Token: 0x0400379B RID: 14235
			[Token(Token = "0x400379B")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<string>> upChar;
		}

		// Token: 0x02000A15 RID: 2581
		[Token(Token = "0x2000A15")]
		public class PlayerReturnGacha
		{
			// Token: 0x060066D6 RID: 26326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066D6")]
			[Address(RVA = "0x1EFC640", Offset = "0x1EFB240", VA = "0x181EFC640")]
			public PlayerReturnGacha()
			{
			}

			// Token: 0x0400379C RID: 14236
			[Token(Token = "0x400379C")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<string>> upChar;
		}
	}
}
