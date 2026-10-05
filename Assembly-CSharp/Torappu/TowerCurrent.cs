using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using XLua;

namespace Torappu
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	public class TowerCurrent
	{
		// Token: 0x06006803 RID: 26627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006803")]
		[Address(RVA = "0x1F028F0", Offset = "0x1F014F0", VA = "0x181F028F0")]
		public TowerCurrent()
		{
		}

		// Token: 0x04003CA9 RID: 15529
		[Token(Token = "0x4003CA9")]
		[FieldOffset(Offset = "0x10")]
		public TowerCurrent.Status status;

		// Token: 0x04003CAA RID: 15530
		[Token(Token = "0x4003CAA")]
		[FieldOffset(Offset = "0x18")]
		public TowerCurrent.TowerGodCard godCard;

		// Token: 0x04003CAB RID: 15531
		[Token(Token = "0x4003CAB")]
		[FieldOffset(Offset = "0x20")]
		public List<TowerCurrent.TowerGameLayer> layer;

		// Token: 0x04003CAC RID: 15532
		[Token(Token = "0x4003CAC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, TowerCurrent.GameCard> cards;

		// Token: 0x04003CAD RID: 15533
		[Token(Token = "0x4003CAD")]
		[FieldOffset(Offset = "0x30")]
		public List<TowerCurrent.TowerTrapInfo> trap;

		// Token: 0x04003CAE RID: 15534
		[Token(Token = "0x4003CAE")]
		[FieldOffset(Offset = "0x38")]
		public TowerCurrent.HalftimeRecruit halftime;

		// Token: 0x02000B64 RID: 2916
		[Token(Token = "0x2000B64")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TowerGameState
		{
			// Token: 0x04003CB0 RID: 15536
			[Token(Token = "0x4003CB0")]
			NONE,
			// Token: 0x04003CB1 RID: 15537
			[Token(Token = "0x4003CB1")]
			INIT_GOD_CARD,
			// Token: 0x04003CB2 RID: 15538
			[Token(Token = "0x4003CB2")]
			INIT_BUFF,
			// Token: 0x04003CB3 RID: 15539
			[Token(Token = "0x4003CB3")]
			INIT_CARD,
			// Token: 0x04003CB4 RID: 15540
			[Token(Token = "0x4003CB4")]
			STANDBY,
			// Token: 0x04003CB5 RID: 15541
			[Token(Token = "0x4003CB5")]
			RECRUIT,
			// Token: 0x04003CB6 RID: 15542
			[Token(Token = "0x4003CB6")]
			SUB_GOD_CARD_RECRUIT,
			// Token: 0x04003CB7 RID: 15543
			[Token(Token = "0x4003CB7")]
			END
		}

		// Token: 0x02000B65 RID: 2917
		[Token(Token = "0x2000B65")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TowerCardType
		{
			// Token: 0x04003CB9 RID: 15545
			[Token(Token = "0x4003CB9")]
			CHAR,
			// Token: 0x04003CBA RID: 15546
			[Token(Token = "0x4003CBA")]
			ASSIST,
			// Token: 0x04003CBB RID: 15547
			[Token(Token = "0x4003CBB")]
			NPC
		}

		// Token: 0x02000B66 RID: 2918
		[Token(Token = "0x2000B66")]
		public class Status
		{
			// Token: 0x06006804 RID: 26628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006804")]
			[Address(RVA = "0x1F02460", Offset = "0x1F01060", VA = "0x181F02460")]
			public Status()
			{
			}

			// Token: 0x04003CBC RID: 15548
			[Token(Token = "0x4003CBC")]
			[FieldOffset(Offset = "0x10")]
			public TowerCurrent.TowerGameState state;

			// Token: 0x04003CBD RID: 15549
			[Token(Token = "0x4003CBD")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "tower")]
			public string towerId;

			// Token: 0x04003CBE RID: 15550
			[Token(Token = "0x4003CBE")]
			[FieldOffset(Offset = "0x20")]
			public int coord;

			// Token: 0x04003CBF RID: 15551
			[Token(Token = "0x4003CBF")]
			[FieldOffset(Offset = "0x28")]
			public TowerTactical tactical;

			// Token: 0x04003CC0 RID: 15552
			[Token(Token = "0x4003CC0")]
			[FieldOffset(Offset = "0x30")]
			public long start;

			// Token: 0x04003CC1 RID: 15553
			[Token(Token = "0x4003CC1")]
			[FieldOffset(Offset = "0x38")]
			public bool isHard;
		}

		// Token: 0x02000B67 RID: 2919
		[Token(Token = "0x2000B67")]
		public class TowerGodCard
		{
			// Token: 0x06006805 RID: 26629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006805")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TowerGodCard()
			{
			}

			// Token: 0x04003CC2 RID: 15554
			[Token(Token = "0x4003CC2")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "id")]
			public string godCardId;

			// Token: 0x04003CC3 RID: 15555
			[Token(Token = "0x4003CC3")]
			[FieldOffset(Offset = "0x18")]
			public string subGodCardId;
		}

		// Token: 0x02000B68 RID: 2920
		[Token(Token = "0x2000B68")]
		public class TowerGameLayer
		{
			// Token: 0x06006806 RID: 26630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006806")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TowerGameLayer()
			{
			}

			// Token: 0x04003CC4 RID: 15556
			[Token(Token = "0x4003CC4")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04003CC5 RID: 15557
			[Token(Token = "0x4003CC5")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "try")]
			public int tryNum;

			// Token: 0x04003CC6 RID: 15558
			[Token(Token = "0x4003CC6")]
			[FieldOffset(Offset = "0x1C")]
			public bool pass;
		}

		// Token: 0x02000B69 RID: 2921
		[Token(Token = "0x2000B69")]
		public class GameCard : PlayerCharacter
		{
			// Token: 0x06006807 RID: 26631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006807")]
			[Address(RVA = "0x1EEA330", Offset = "0x1EE8F30", VA = "0x181EEA330")]
			public GameCard()
			{
			}

			// Token: 0x04003CC7 RID: 15559
			[Token(Token = "0x4003CC7")]
			[FieldOffset(Offset = "0x90")]
			public string relation;

			// Token: 0x04003CC8 RID: 15560
			[Token(Token = "0x4003CC8")]
			[FieldOffset(Offset = "0x98")]
			public TowerCurrent.TowerCardType type;

			// Token: 0x04003CC9 RID: 15561
			[Token(Token = "0x4003CC9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000B6A RID: 2922
		[Token(Token = "0x2000B6A")]
		public class TowerTrapInfo
		{
			// Token: 0x06006808 RID: 26632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006808")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TowerTrapInfo()
			{
			}

			// Token: 0x04003CCA RID: 15562
			[Token(Token = "0x4003CCA")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04003CCB RID: 15563
			[Token(Token = "0x4003CCB")]
			[FieldOffset(Offset = "0x18")]
			public string alias;
		}

		// Token: 0x02000B6B RID: 2923
		[Token(Token = "0x2000B6B")]
		public class HalftimeRecruit
		{
			// Token: 0x06006809 RID: 26633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006809")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalftimeRecruit()
			{
			}

			// Token: 0x04003CCC RID: 15564
			[Token(Token = "0x4003CCC")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "count")]
			public int remainCount;

			// Token: 0x04003CCD RID: 15565
			[Token(Token = "0x4003CCD")]
			[FieldOffset(Offset = "0x18")]
			public List<TowerCurrent.HalftimeCandidateGroup> candidate;

			// Token: 0x04003CCE RID: 15566
			[Token(Token = "0x4003CCE")]
			[FieldOffset(Offset = "0x20")]
			public bool canGiveUp;
		}

		// Token: 0x02000B6C RID: 2924
		[Token(Token = "0x2000B6C")]
		public class HalftimeCandidateGroup
		{
			// Token: 0x0600680A RID: 26634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600680A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalftimeCandidateGroup()
			{
			}

			// Token: 0x04003CCF RID: 15567
			[Token(Token = "0x4003CCF")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04003CD0 RID: 15568
			[Token(Token = "0x4003CD0")]
			[FieldOffset(Offset = "0x18")]
			public TowerCurrent.TowerCardType type;

			// Token: 0x04003CD1 RID: 15569
			[Token(Token = "0x4003CD1")]
			[FieldOffset(Offset = "0x20")]
			public List<TowerCurrent.GameCard> cards;
		}
	}
}
