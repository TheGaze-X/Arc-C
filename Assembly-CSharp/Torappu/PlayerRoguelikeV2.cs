using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using XLua;

namespace Torappu
{
	// Token: 0x02000AC1 RID: 2753
	[Token(Token = "0x2000AC1")]
	public class PlayerRoguelikeV2
	{
		// Token: 0x0600677D RID: 26493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677D")]
		[Address(RVA = "0x1EFD150", Offset = "0x1EFBD50", VA = "0x181EFD150")]
		public PlayerRoguelikeV2()
		{
		}

		// Token: 0x040039FE RID: 14846
		[Token(Token = "0x40039FE")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRoguelikeV2.CurrentData current;

		// Token: 0x040039FF RID: 14847
		[Token(Token = "0x40039FF")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerRoguelikeV2.OuterData> outer;

		// Token: 0x04003A00 RID: 14848
		[Token(Token = "0x4003A00")]
		[FieldOffset(Offset = "0x20")]
		public string pinned;

		// Token: 0x02000AC2 RID: 2754
		[Token(Token = "0x2000AC2")]
		public class CurrentData
		{
			// Token: 0x0600677E RID: 26494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600677E")]
			[Address(RVA = "0x1EE8780", Offset = "0x1EE7380", VA = "0x181EE8780")]
			public CurrentData()
			{
			}

			// Token: 0x04003A01 RID: 14849
			[Token(Token = "0x4003A01")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikeV2.CurrentData.PlayerStatus player;

			// Token: 0x04003A02 RID: 14850
			[Token(Token = "0x4003A02")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikeV2Dungeon map;

			// Token: 0x04003A03 RID: 14851
			[Token(Token = "0x4003A03")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikeV2.CurrentData.Inventory inventory;

			// Token: 0x04003A04 RID: 14852
			[Token(Token = "0x4003A04")]
			[FieldOffset(Offset = "0x28")]
			public PlayerRoguelikeV2.CurrentData.Game game;

			// Token: 0x04003A05 RID: 14853
			[Token(Token = "0x4003A05")]
			[FieldOffset(Offset = "0x30")]
			public PlayerRoguelikeV2.CurrentData.Troop troop;

			// Token: 0x04003A06 RID: 14854
			[Token(Token = "0x4003A06")]
			[FieldOffset(Offset = "0x38")]
			public PlayerRoguelikeV2.CurrentData.Buff buff;

			// Token: 0x04003A07 RID: 14855
			[Token(Token = "0x4003A07")]
			[FieldOffset(Offset = "0x40")]
			public PlayerRoguelikeV2.CurrentData.Module module;

			// Token: 0x02000AC3 RID: 2755
			[Token(Token = "0x2000AC3")]
			public class PlayerStatus
			{
				// Token: 0x0600677F RID: 26495 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600677F")]
				[Address(RVA = "0x1EFF3A0", Offset = "0x1EFDFA0", VA = "0x181EFF3A0")]
				public PlayerStatus()
				{
				}

				// Token: 0x04003A08 RID: 14856
				[Token(Token = "0x4003A08")]
				[FieldOffset(Offset = "0x10")]
				public PlayerRoguelikePlayerState state;

				// Token: 0x04003A09 RID: 14857
				[Token(Token = "0x4003A09")]
				[FieldOffset(Offset = "0x18")]
				public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties property;

				// Token: 0x04003A0A RID: 14858
				[Token(Token = "0x4003A0A")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRoguelikeV2.CurrentData.PlayerStatus.NodePosition cursor;

				// Token: 0x04003A0B RID: 14859
				[Token(Token = "0x4003A0B")]
				[FieldOffset(Offset = "0x28")]
				public List<PlayerRoguelikePendingEvent> pending;

				// Token: 0x04003A0C RID: 14860
				[Token(Token = "0x4003A0C")]
				[FieldOffset(Offset = "0x30")]
				public List<PlayerRoguelikeV2.CurrentData.PlayerStatus.NodePosition> trace;

				// Token: 0x04003A0D RID: 14861
				[Token(Token = "0x4003A0D")]
				[FieldOffset(Offset = "0x38")]
				public PlayerRoguelikeV2.CurrentData.PlayerStatus.Status status;

				// Token: 0x04003A0E RID: 14862
				[Token(Token = "0x4003A0E")]
				[FieldOffset(Offset = "0x40")]
				public string toEnding;

				// Token: 0x04003A0F RID: 14863
				[Token(Token = "0x4003A0F")]
				[FieldOffset(Offset = "0x48")]
				public bool chgEnding;

				// Token: 0x04003A10 RID: 14864
				[Token(Token = "0x4003A10")]
				[FieldOffset(Offset = "0x50")]
				public List<PlayerRoguelikeV2.CurrentData.PlayerStatus.InnerMission> innerMission;

				// Token: 0x04003A11 RID: 14865
				[Token(Token = "0x4003A11")]
				[FieldOffset(Offset = "0x58")]
				public PlayerRoguelikeV2.CurrentData.PlayerStatus.NodeMission nodeMission;

				// Token: 0x04003A12 RID: 14866
				[Token(Token = "0x4003A12")]
				[FieldOffset(Offset = "0x60")]
				public Dictionary<string, List<PlayerRoguelikeV2.CurrentData.PlayerStatus.ZoneRewardItem>> zoneReward;

				// Token: 0x04003A13 RID: 14867
				[Token(Token = "0x4003A13")]
				[FieldOffset(Offset = "0x68")]
				public Dictionary<string, List<PlayerRoguelikeV2.CurrentData.PlayerStatus.ZoneRewardItem>> traderReturn;

				// Token: 0x02000AC4 RID: 2756
				[Token(Token = "0x2000AC4")]
				public class Properties
				{
					// Token: 0x06006780 RID: 26496 RVA: 0x00030948 File Offset: 0x0002EB48
					[Token(Token = "0x6006780")]
					[Address(RVA = "0x1EFFF00", Offset = "0x1EFEB00", VA = "0x181EFFF00")]
					public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.RewardHpShowStatus GetHpShowState()
					{
						return PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.RewardHpShowStatus.NONE;
					}

					// Token: 0x06006781 RID: 26497 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006781")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Properties()
					{
					}

					// Token: 0x04003A14 RID: 14868
					[Token(Token = "0x4003A14")]
					[FieldOffset(Offset = "0x10")]
					public int exp;

					// Token: 0x04003A15 RID: 14869
					[Token(Token = "0x4003A15")]
					[FieldOffset(Offset = "0x14")]
					public int level;

					// Token: 0x04003A16 RID: 14870
					[Token(Token = "0x4003A16")]
					[FieldOffset(Offset = "0x18")]
					public int maxLevel;

					// Token: 0x04003A17 RID: 14871
					[Token(Token = "0x4003A17")]
					[FieldOffset(Offset = "0x1C")]
					public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.Hp hp;

					// Token: 0x04003A18 RID: 14872
					[Token(Token = "0x4003A18")]
					[FieldOffset(Offset = "0x24")]
					public int shield;

					// Token: 0x04003A19 RID: 14873
					[Token(Token = "0x4003A19")]
					[FieldOffset(Offset = "0x28")]
					public int gold;

					// Token: 0x04003A1A RID: 14874
					[Token(Token = "0x4003A1A")]
					[FieldOffset(Offset = "0x2C")]
					public int capacity;

					// Token: 0x04003A1B RID: 14875
					[Token(Token = "0x4003A1B")]
					[FieldOffset(Offset = "0x30")]
					public PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.Population population;

					// Token: 0x04003A1C RID: 14876
					[Token(Token = "0x4003A1C")]
					[FieldOffset(Offset = "0x38")]
					public int conPerfectBattle;

					// Token: 0x04003A1D RID: 14877
					[Token(Token = "0x4003A1D")]
					private const string HP_SHOW_STATE_NORMAL = "NORMAL";

					// Token: 0x04003A1E RID: 14878
					[Token(Token = "0x4003A1E")]
					private const string HP_SHOW_STATE_HIDDEN = "HIDDEN";

					// Token: 0x04003A1F RID: 14879
					[Token(Token = "0x4003A1F")]
					[FieldOffset(Offset = "0x40")]
					[JsonProperty("hpShowState")]
					private string m_hpShowState;

					// Token: 0x02000AC5 RID: 2757
					[Token(Token = "0x2000AC5")]
					public struct Hp
					{
						// Token: 0x04003A20 RID: 14880
						[Token(Token = "0x4003A20")]
						[FieldOffset(Offset = "0x0")]
						public int current;

						// Token: 0x04003A21 RID: 14881
						[Token(Token = "0x4003A21")]
						[FieldOffset(Offset = "0x4")]
						public int max;
					}

					// Token: 0x02000AC6 RID: 2758
					[Token(Token = "0x2000AC6")]
					public struct Population
					{
						// Token: 0x04003A22 RID: 14882
						[Token(Token = "0x4003A22")]
						[FieldOffset(Offset = "0x0")]
						public int cost;

						// Token: 0x04003A23 RID: 14883
						[Token(Token = "0x4003A23")]
						[FieldOffset(Offset = "0x4")]
						public int max;
					}

					// Token: 0x02000AC7 RID: 2759
					[Token(Token = "0x2000AC7")]
					public enum RewardHpShowStatus
					{
						// Token: 0x04003A25 RID: 14885
						[Token(Token = "0x4003A25")]
						NONE,
						// Token: 0x04003A26 RID: 14886
						[Token(Token = "0x4003A26")]
						NORMAL,
						// Token: 0x04003A27 RID: 14887
						[Token(Token = "0x4003A27")]
						HIDDEN
					}
				}

				// Token: 0x02000AC8 RID: 2760
				[Token(Token = "0x2000AC8")]
				public class NodePosition
				{
					// Token: 0x06006782 RID: 26498 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006782")]
					[Address(RVA = "0x1EEC570", Offset = "0x1EEB170", VA = "0x181EEC570")]
					public NodePosition()
					{
					}

					// Token: 0x04003A28 RID: 14888
					[Token(Token = "0x4003A28")]
					[FieldOffset(Offset = "0x10")]
					public int zone;

					// Token: 0x04003A29 RID: 14889
					[Token(Token = "0x4003A29")]
					[FieldOffset(Offset = "0x18")]
					public RoguelikeNodePosition position;
				}

				// Token: 0x02000AC9 RID: 2761
				[Token(Token = "0x2000AC9")]
				public class Status
				{
					// Token: 0x06006783 RID: 26499 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006783")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Status()
					{
					}

					// Token: 0x04003A2A RID: 14890
					[Token(Token = "0x4003A2A")]
					[FieldOffset(Offset = "0x10")]
					public int bankPut;
				}

				// Token: 0x02000ACA RID: 2762
				[Token(Token = "0x2000ACA")]
				public class InnerMission
				{
					// Token: 0x06006784 RID: 26500 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006784")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public InnerMission()
					{
					}

					// Token: 0x04003A2B RID: 14891
					[Token(Token = "0x4003A2B")]
					[FieldOffset(Offset = "0x10")]
					public string tmpl;

					// Token: 0x04003A2C RID: 14892
					[Token(Token = "0x4003A2C")]
					[FieldOffset(Offset = "0x18")]
					public string id;

					// Token: 0x04003A2D RID: 14893
					[Token(Token = "0x4003A2D")]
					[FieldOffset(Offset = "0x20")]
					public int[] progress;
				}

				// Token: 0x02000ACB RID: 2763
				[Token(Token = "0x2000ACB")]
				public class NodeMission
				{
					// Token: 0x06006785 RID: 26501 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006785")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public NodeMission()
					{
					}

					// Token: 0x04003A2E RID: 14894
					[Token(Token = "0x4003A2E")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003A2F RID: 14895
					[Token(Token = "0x4003A2F")]
					[FieldOffset(Offset = "0x18")]
					public PlayerRoguelikeV2.CurrentData.PlayerStatus.NodeMission.NodeMissionState state;

					// Token: 0x04003A30 RID: 14896
					[Token(Token = "0x4003A30")]
					[FieldOffset(Offset = "0x1C")]
					public bool tip;

					// Token: 0x04003A31 RID: 14897
					[Token(Token = "0x4003A31")]
					[FieldOffset(Offset = "0x20")]
					public int[] progress;

					// Token: 0x02000ACC RID: 2764
					[Token(Token = "0x2000ACC")]
					public enum NodeMissionState
					{
						// Token: 0x04003A33 RID: 14899
						[Token(Token = "0x4003A33")]
						NOT_COMPLETED,
						// Token: 0x04003A34 RID: 14900
						[Token(Token = "0x4003A34")]
						COMPLETED,
						// Token: 0x04003A35 RID: 14901
						[Token(Token = "0x4003A35")]
						ALL_FINISHED
					}
				}

				// Token: 0x02000ACD RID: 2765
				[Token(Token = "0x2000ACD")]
				public class ZoneRewardItem
				{
					// Token: 0x06006786 RID: 26502 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006786")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public ZoneRewardItem()
					{
					}

					// Token: 0x04003A36 RID: 14902
					[Token(Token = "0x4003A36")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003A37 RID: 14903
					[Token(Token = "0x4003A37")]
					[FieldOffset(Offset = "0x18")]
					public int count;

					// Token: 0x04003A38 RID: 14904
					[Token(Token = "0x4003A38")]
					[FieldOffset(Offset = "0x20")]
					public string instId;
				}
			}

			// Token: 0x02000ACE RID: 2766
			[Token(Token = "0x2000ACE")]
			public class Char : PlayerCharacter
			{
				// Token: 0x06006787 RID: 26503 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006787")]
				[Address(RVA = "0x1EE7760", Offset = "0x1EE6360", VA = "0x181EE7760")]
				public Char()
				{
				}

				// Token: 0x04003A39 RID: 14905
				[Token(Token = "0x4003A39")]
				[FieldOffset(Offset = "0x90")]
				public int upgradePhase;

				// Token: 0x04003A3A RID: 14906
				[Token(Token = "0x4003A3A")]
				[FieldOffset(Offset = "0x94")]
				public bool upgradeLimited;

				// Token: 0x04003A3B RID: 14907
				[Token(Token = "0x4003A3B")]
				[FieldOffset(Offset = "0x98")]
				public RoguelikeCharState type;

				// Token: 0x04003A3C RID: 14908
				[Token(Token = "0x4003A3C")]
				[FieldOffset(Offset = "0xA0")]
				public List<string> charBuff;

				// Token: 0x04003A3D RID: 14909
				[Token(Token = "0x4003A3D")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02000ACF RID: 2767
			[Token(Token = "0x2000ACF")]
			public class RecruitChar : PlayerCharacter
			{
				// Token: 0x06006788 RID: 26504 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006788")]
				[Address(RVA = "0x1F004C0", Offset = "0x1EFF0C0", VA = "0x181F004C0")]
				public RecruitChar()
				{
				}

				// Token: 0x04003A3E RID: 14910
				[Token(Token = "0x4003A3E")]
				[FieldOffset(Offset = "0x90")]
				public RoguelikeCharState type;

				// Token: 0x04003A3F RID: 14911
				[Token(Token = "0x4003A3F")]
				[FieldOffset(Offset = "0x94")]
				public int upgradePhase;

				// Token: 0x04003A40 RID: 14912
				[Token(Token = "0x4003A40")]
				[FieldOffset(Offset = "0x98")]
				public bool upgradeLimited;

				// Token: 0x04003A41 RID: 14913
				[Token(Token = "0x4003A41")]
				[FieldOffset(Offset = "0x9C")]
				public int population;

				// Token: 0x04003A42 RID: 14914
				[Token(Token = "0x4003A42")]
				[FieldOffset(Offset = "0xA0")]
				public bool isUpgrade;

				// Token: 0x04003A43 RID: 14915
				[Token(Token = "0x4003A43")]
				[FieldOffset(Offset = "0xA4")]
				public int troopInstId;

				// Token: 0x04003A44 RID: 14916
				[Token(Token = "0x4003A44")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}

			// Token: 0x02000AD0 RID: 2768
			[Token(Token = "0x2000AD0")]
			public class ExpeditionReturn
			{
				// Token: 0x06006789 RID: 26505 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006789")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ExpeditionReturn()
				{
				}

				// Token: 0x04003A45 RID: 14917
				[Token(Token = "0x4003A45")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "char")]
				public List<PlayerRoguelikeV2.CurrentData.ExpeditionReturn.Char> charList;

				// Token: 0x04003A46 RID: 14918
				[Token(Token = "0x4003A46")]
				[FieldOffset(Offset = "0x18")]
				public PlayerRoguelikeV2.CurrentData.ExpeditionReturn.Reward[] rewards;

				// Token: 0x02000AD1 RID: 2769
				[Token(Token = "0x2000AD1")]
				public class Char
				{
					// Token: 0x0600678A RID: 26506 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600678A")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Char()
					{
					}

					// Token: 0x04003A47 RID: 14919
					[Token(Token = "0x4003A47")]
					[FieldOffset(Offset = "0x10")]
					public string instId;

					// Token: 0x04003A48 RID: 14920
					[Token(Token = "0x4003A48")]
					[FieldOffset(Offset = "0x18")]
					public bool isUpgrade;

					// Token: 0x04003A49 RID: 14921
					[Token(Token = "0x4003A49")]
					[FieldOffset(Offset = "0x19")]
					public bool isCure;

					// Token: 0x04003A4A RID: 14922
					[Token(Token = "0x4003A4A")]
					[FieldOffset(Offset = "0x1A")]
					public bool isCandle;
				}

				// Token: 0x02000AD2 RID: 2770
				[Token(Token = "0x2000AD2")]
				public class Reward
				{
					// Token: 0x0600678B RID: 26507 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600678B")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Reward()
					{
					}

					// Token: 0x04003A4B RID: 14923
					[Token(Token = "0x4003A4B")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003A4C RID: 14924
					[Token(Token = "0x4003A4C")]
					[FieldOffset(Offset = "0x18")]
					public int count;

					// Token: 0x04003A4D RID: 14925
					[Token(Token = "0x4003A4D")]
					[FieldOffset(Offset = "0x20")]
					public string instId;
				}
			}

			// Token: 0x02000AD3 RID: 2771
			[Token(Token = "0x2000AD3")]
			public class Troop
			{
				// Token: 0x0600678C RID: 26508 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600678C")]
				[Address(RVA = "0x1F02FA0", Offset = "0x1F01BA0", VA = "0x181F02FA0")]
				public Troop()
				{
				}

				// Token: 0x04003A4E RID: 14926
				[Token(Token = "0x4003A4E")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerRoguelikeV2.CurrentData.Char> chars;

				// Token: 0x04003A4F RID: 14927
				[Token(Token = "0x4003A4F")]
				[FieldOffset(Offset = "0x18")]
				public List<string> expedition;

				// Token: 0x04003A50 RID: 14928
				[Token(Token = "0x4003A50")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, PlayerRoguelikeV2.CurrentData.Troop.ExpedType> expeditionDetails;

				// Token: 0x04003A51 RID: 14929
				[Token(Token = "0x4003A51")]
				[FieldOffset(Offset = "0x28")]
				public PlayerRoguelikeV2.CurrentData.ExpeditionReturn expeditionReturn;

				// Token: 0x04003A52 RID: 14930
				[Token(Token = "0x4003A52")]
				[FieldOffset(Offset = "0x30")]
				public bool hasExpeditionReturn;

				// Token: 0x02000AD4 RID: 2772
				[Token(Token = "0x2000AD4")]
				public enum ExpedType
				{
					// Token: 0x04003A54 RID: 14932
					[Token(Token = "0x4003A54")]
					EXPED,
					// Token: 0x04003A55 RID: 14933
					[Token(Token = "0x4003A55")]
					TRAVEL,
					// Token: 0x04003A56 RID: 14934
					[Token(Token = "0x4003A56")]
					CANDLE,
					// Token: 0x04003A57 RID: 14935
					[Token(Token = "0x4003A57")]
					NO_UPGRADE,
					// Token: 0x04003A58 RID: 14936
					[Token(Token = "0x4003A58")]
					GUIDED,
					// Token: 0x04003A59 RID: 14937
					[Token(Token = "0x4003A59")]
					NON_GUIDED
				}
			}

			// Token: 0x02000AD5 RID: 2773
			[Token(Token = "0x2000AD5")]
			public class Relic
			{
				// Token: 0x0600678D RID: 26509 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600678D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Relic()
				{
				}

				// Token: 0x04003A5A RID: 14938
				[Token(Token = "0x4003A5A")]
				[FieldOffset(Offset = "0x10")]
				public string index;

				// Token: 0x04003A5B RID: 14939
				[Token(Token = "0x4003A5B")]
				[FieldOffset(Offset = "0x18")]
				public string id;

				// Token: 0x04003A5C RID: 14940
				[Token(Token = "0x4003A5C")]
				[FieldOffset(Offset = "0x20")]
				public int count;

				// Token: 0x04003A5D RID: 14941
				[Token(Token = "0x4003A5D")]
				[FieldOffset(Offset = "0x24")]
				public int layer;

				// Token: 0x04003A5E RID: 14942
				[Token(Token = "0x4003A5E")]
				[FieldOffset(Offset = "0x28")]
				public long ts;

				// Token: 0x04003A5F RID: 14943
				[Token(Token = "0x4003A5F")]
				[FieldOffset(Offset = "0x30")]
				public bool used;
			}

			// Token: 0x02000AD6 RID: 2774
			[Token(Token = "0x2000AD6")]
			public class Trap
			{
				// Token: 0x0600678E RID: 26510 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600678E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Trap()
				{
				}

				// Token: 0x04003A60 RID: 14944
				[Token(Token = "0x4003A60")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003A61 RID: 14945
				[Token(Token = "0x4003A61")]
				[FieldOffset(Offset = "0x18")]
				public long ts;
			}

			// Token: 0x02000AD7 RID: 2775
			[Token(Token = "0x2000AD7")]
			public class ExploreTool
			{
				// Token: 0x0600678F RID: 26511 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600678F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ExploreTool()
				{
				}

				// Token: 0x04003A62 RID: 14946
				[Token(Token = "0x4003A62")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003A63 RID: 14947
				[Token(Token = "0x4003A63")]
				[FieldOffset(Offset = "0x18")]
				public long ts;
			}

			// Token: 0x02000AD8 RID: 2776
			[Token(Token = "0x2000AD8")]
			public class Recruit
			{
				// Token: 0x06006790 RID: 26512 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006790")]
				[Address(RVA = "0x1F00570", Offset = "0x1EFF170", VA = "0x181F00570")]
				public Recruit()
				{
				}

				// Token: 0x04003A64 RID: 14948
				[Token(Token = "0x4003A64")]
				[FieldOffset(Offset = "0x10")]
				public string index;

				// Token: 0x04003A65 RID: 14949
				[Token(Token = "0x4003A65")]
				[FieldOffset(Offset = "0x18")]
				public string id;

				// Token: 0x04003A66 RID: 14950
				[Token(Token = "0x4003A66")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRoguelikeV2.CurrentData.Recruit.State state;

				// Token: 0x04003A67 RID: 14951
				[Token(Token = "0x4003A67")]
				[FieldOffset(Offset = "0x28")]
				public PlayerRoguelikeV2.CurrentData.RecruitChar[] list;

				// Token: 0x04003A68 RID: 14952
				[Token(Token = "0x4003A68")]
				[FieldOffset(Offset = "0x30")]
				public PlayerRoguelikeV2.CurrentData.RecruitChar result;

				// Token: 0x04003A69 RID: 14953
				[Token(Token = "0x4003A69")]
				[FieldOffset(Offset = "0x38")]
				public long ts;

				// Token: 0x04003A6A RID: 14954
				[Token(Token = "0x4003A6A")]
				[FieldOffset(Offset = "0x40")]
				public bool needAssist;

				// Token: 0x04003A6B RID: 14955
				[Token(Token = "0x4003A6B")]
				[FieldOffset(Offset = "0x48")]
				public Dictionary<string, List<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData>> assistList;

				// Token: 0x04003A6C RID: 14956
				[Token(Token = "0x4003A6C")]
				[FieldOffset(Offset = "0x50")]
				public Dictionary<string, List<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData>> starFriendAssistList;

				// Token: 0x02000AD9 RID: 2777
				[Token(Token = "0x2000AD9")]
				public enum State
				{
					// Token: 0x04003A6E RID: 14958
					[Token(Token = "0x4003A6E")]
					CREATE,
					// Token: 0x04003A6F RID: 14959
					[Token(Token = "0x4003A6F")]
					ACTIVE,
					// Token: 0x04003A70 RID: 14960
					[Token(Token = "0x4003A70")]
					DONE
				}

				// Token: 0x02000ADA RID: 2778
				[Token(Token = "0x2000ADA")]
				public class OrigChar : FriendCommonData
				{
					// Token: 0x06006791 RID: 26513 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006791")]
					[Address(RVA = "0x1EECBD0", Offset = "0x1EEB7D0", VA = "0x181EECBD0")]
					public OrigChar()
					{
					}

					// Token: 0x04003A71 RID: 14961
					[Token(Token = "0x4003A71")]
					[FieldOffset(Offset = "0x68")]
					public int assistSlotIndex;

					// Token: 0x04003A72 RID: 14962
					[Token(Token = "0x4003A72")]
					[FieldOffset(Offset = "0x70")]
					public string aliasName;

					// Token: 0x04003A73 RID: 14963
					[Token(Token = "0x4003A73")]
					[FieldOffset(Offset = "0x78")]
					public SharedCharData[] assistCharList;

					// Token: 0x04003A74 RID: 14964
					[Token(Token = "0x4003A74")]
					[FieldOffset(Offset = "0x80")]
					public bool isFriend;

					// Token: 0x04003A75 RID: 14965
					[Token(Token = "0x4003A75")]
					[FieldOffset(Offset = "0x81")]
					public bool canRequestFriend;

					// Token: 0x04003A76 RID: 14966
					[Token(Token = "0x4003A76")]
					[FieldOffset(Offset = "0x82")]
					public bool isStarFriend;

					// Token: 0x04003A77 RID: 14967
					[Token(Token = "0x4003A77")]
					[FieldOffset(Offset = "0x0")]
					private static DelegateBridge _c__Hotfix0_ctor;
				}

				// Token: 0x02000ADB RID: 2779
				[Token(Token = "0x2000ADB")]
				public class FriendAssistData
				{
					// Token: 0x06006792 RID: 26514 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006792")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public FriendAssistData()
					{
					}

					// Token: 0x04003A78 RID: 14968
					[Token(Token = "0x4003A78")]
					[FieldOffset(Offset = "0x10")]
					public PlayerRoguelikeV2.CurrentData.Recruit.OrigChar orig;

					// Token: 0x04003A79 RID: 14969
					[Token(Token = "0x4003A79")]
					[FieldOffset(Offset = "0x18")]
					public PlayerRoguelikeV2.CurrentData.RecruitChar recruit;
				}
			}

			// Token: 0x02000ADC RID: 2780
			[Token(Token = "0x2000ADC")]
			public class Inventory
			{
				// Token: 0x06006793 RID: 26515 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006793")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Inventory()
				{
				}

				// Token: 0x04003A7A RID: 14970
				[Token(Token = "0x4003A7A")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerRoguelikeV2.CurrentData.Relic> relic;

				// Token: 0x04003A7B RID: 14971
				[Token(Token = "0x4003A7B")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerRoguelikeV2.CurrentData.Recruit> recruit;

				// Token: 0x04003A7C RID: 14972
				[Token(Token = "0x4003A7C")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "stashRecruit")]
				public List<string> stashedRecruit;

				// Token: 0x04003A7D RID: 14973
				[Token(Token = "0x4003A7D")]
				[FieldOffset(Offset = "0x28")]
				[JsonProperty(PropertyName = "stashRecruitLimit")]
				public int stashedRecruitLimit;

				// Token: 0x04003A7E RID: 14974
				[Token(Token = "0x4003A7E")]
				[FieldOffset(Offset = "0x30")]
				public PlayerRoguelikeV2.CurrentData.Trap trap;

				// Token: 0x04003A7F RID: 14975
				[Token(Token = "0x4003A7F")]
				[FieldOffset(Offset = "0x38")]
				public Dictionary<string, PlayerRoguelikeV2.CurrentData.ExploreTool> exploreTool;

				// Token: 0x04003A80 RID: 14976
				[Token(Token = "0x4003A80")]
				[FieldOffset(Offset = "0x40")]
				public Dictionary<string, int> consumable;
			}

			// Token: 0x02000ADD RID: 2781
			[Token(Token = "0x2000ADD")]
			public class Buff
			{
				// Token: 0x06006794 RID: 26516 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006794")]
				[Address(RVA = "0x1EE71C0", Offset = "0x1EE5DC0", VA = "0x181EE71C0")]
				public Buff()
				{
				}

				// Token: 0x04003A81 RID: 14977
				[Token(Token = "0x4003A81")]
				[FieldOffset(Offset = "0x10")]
				public int tmpHP;

				// Token: 0x04003A82 RID: 14978
				[Token(Token = "0x4003A82")]
				[FieldOffset(Offset = "0x18")]
				public PlayerRoguelikeV2.CurrentData.Capsule capsule;

				// Token: 0x04003A83 RID: 14979
				[Token(Token = "0x4003A83")]
				[FieldOffset(Offset = "0x20")]
				public List<string> squadBuff;
			}

			// Token: 0x02000ADE RID: 2782
			[Token(Token = "0x2000ADE")]
			public class Capsule
			{
				// Token: 0x06006795 RID: 26517 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006795")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Capsule()
				{
				}

				// Token: 0x04003A84 RID: 14980
				[Token(Token = "0x4003A84")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003A85 RID: 14981
				[Token(Token = "0x4003A85")]
				[FieldOffset(Offset = "0x18")]
				public long ts;

				// Token: 0x04003A86 RID: 14982
				[Token(Token = "0x4003A86")]
				[FieldOffset(Offset = "0x20")]
				public bool active;
			}

			// Token: 0x02000ADF RID: 2783
			[Token(Token = "0x2000ADF")]
			public class Game
			{
				// Token: 0x06006796 RID: 26518 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006796")]
				[Address(RVA = "0x1EEA3F0", Offset = "0x1EE8FF0", VA = "0x181EEA3F0")]
				public Game()
				{
				}

				// Token: 0x04003A87 RID: 14983
				[Token(Token = "0x4003A87")]
				[FieldOffset(Offset = "0x10")]
				public string uid;

				// Token: 0x04003A88 RID: 14984
				[Token(Token = "0x4003A88")]
				[FieldOffset(Offset = "0x18")]
				public string theme;

				// Token: 0x04003A89 RID: 14985
				[Token(Token = "0x4003A89")]
				[FieldOffset(Offset = "0x20")]
				public RoguelikeTopicMode mode;

				// Token: 0x04003A8A RID: 14986
				[Token(Token = "0x4003A8A")]
				[FieldOffset(Offset = "0x24")]
				public int modeGrade;

				// Token: 0x04003A8B RID: 14987
				[Token(Token = "0x4003A8B")]
				[FieldOffset(Offset = "0x28")]
				public int equivalentGrade;

				// Token: 0x04003A8C RID: 14988
				[Token(Token = "0x4003A8C")]
				[FieldOffset(Offset = "0x30")]
				public string predefined;

				// Token: 0x04003A8D RID: 14989
				[Token(Token = "0x4003A8D")]
				[FieldOffset(Offset = "0x38")]
				public int difficult;

				// Token: 0x04003A8E RID: 14990
				[Token(Token = "0x4003A8E")]
				[FieldOffset(Offset = "0x40")]
				public PlayerRoguelikeV2.CurrentData.Game.OuterBuff outerBuff;

				// Token: 0x04003A8F RID: 14991
				[Token(Token = "0x4003A8F")]
				[FieldOffset(Offset = "0x48")]
				public long start;

				// Token: 0x04003A90 RID: 14992
				[Token(Token = "0x4003A90")]
				[FieldOffset(Offset = "0x50")]
				public string activity;

				// Token: 0x02000AE0 RID: 2784
				[Token(Token = "0x2000AE0")]
				public class OuterBuff
				{
					// Token: 0x06006797 RID: 26519 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006797")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public OuterBuff()
					{
					}
				}
			}

			// Token: 0x02000AE1 RID: 2785
			[Token(Token = "0x2000AE1")]
			public class Module
			{
				// Token: 0x06006798 RID: 26520 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006798")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Module()
				{
				}

				// Token: 0x04003A91 RID: 14993
				[Token(Token = "0x4003A91")]
				[FieldOffset(Offset = "0x10")]
				public PlayerRoguelikeV2.CurrentData.Module.San san;

				// Token: 0x04003A92 RID: 14994
				[Token(Token = "0x4003A92")]
				[FieldOffset(Offset = "0x18")]
				public PlayerRoguelikeV2.CurrentData.Module.Dice dice;

				// Token: 0x04003A93 RID: 14995
				[Token(Token = "0x4003A93")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRoguelikeV2.CurrentData.Module.Totem totem;

				// Token: 0x04003A94 RID: 14996
				[Token(Token = "0x4003A94")]
				[FieldOffset(Offset = "0x28")]
				public PlayerRoguelikeV2.CurrentData.Module.Vision vision;

				// Token: 0x04003A95 RID: 14997
				[Token(Token = "0x4003A95")]
				[FieldOffset(Offset = "0x30")]
				public PlayerRoguelikeV2.CurrentData.Module.Chaos chaos;

				// Token: 0x04003A96 RID: 14998
				[Token(Token = "0x4003A96")]
				[FieldOffset(Offset = "0x38")]
				public PlayerRoguelikeV2.CurrentData.Module.Fragment fragment;

				// Token: 0x04003A97 RID: 14999
				[Token(Token = "0x4003A97")]
				[FieldOffset(Offset = "0x40")]
				public PlayerRoguelikeV2.CurrentData.Module.Disaster disaster;

				// Token: 0x04003A98 RID: 15000
				[Token(Token = "0x4003A98")]
				[FieldOffset(Offset = "0x48")]
				public PlayerRoguelikeV2.CurrentData.Module.NodeUpgrade nodeUpgrade;

				// Token: 0x04003A99 RID: 15001
				[Token(Token = "0x4003A99")]
				[FieldOffset(Offset = "0x50")]
				public PlayerRoguelikeV2.CurrentData.Module.Copper copper;

				// Token: 0x04003A9A RID: 15002
				[Token(Token = "0x4003A9A")]
				[FieldOffset(Offset = "0x58")]
				public PlayerRoguelikeV2.CurrentData.Module.Wrath wrath;

				// Token: 0x04003A9B RID: 15003
				[Token(Token = "0x4003A9B")]
				[FieldOffset(Offset = "0x60")]
				public PlayerRoguelikeV2.CurrentData.Module.Sky sky;

				// Token: 0x02000AE2 RID: 2786
				[Token(Token = "0x2000AE2")]
				public class San
				{
					// Token: 0x06006799 RID: 26521 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006799")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public San()
					{
					}

					// Token: 0x04003A9C RID: 15004
					[Token(Token = "0x4003A9C")]
					[FieldOffset(Offset = "0x10")]
					public int sanity;
				}

				// Token: 0x02000AE3 RID: 2787
				[Token(Token = "0x2000AE3")]
				public class Dice
				{
					// Token: 0x0600679A RID: 26522 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679A")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Dice()
					{
					}

					// Token: 0x04003A9D RID: 15005
					[Token(Token = "0x4003A9D")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003A9E RID: 15006
					[Token(Token = "0x4003A9E")]
					[FieldOffset(Offset = "0x18")]
					public int count;
				}

				// Token: 0x02000AE4 RID: 2788
				[Token(Token = "0x2000AE4")]
				public class InventoryTotem
				{
					// Token: 0x0600679B RID: 26523 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679B")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public InventoryTotem()
					{
					}

					// Token: 0x04003A9F RID: 15007
					[Token(Token = "0x4003A9F")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003AA0 RID: 15008
					[Token(Token = "0x4003AA0")]
					[FieldOffset(Offset = "0x18")]
					[JsonProperty("index")]
					public string instId;

					// Token: 0x04003AA1 RID: 15009
					[Token(Token = "0x4003AA1")]
					[FieldOffset(Offset = "0x20")]
					public bool used;

					// Token: 0x04003AA2 RID: 15010
					[Token(Token = "0x4003AA2")]
					[FieldOffset(Offset = "0x28")]
					public string affix;

					// Token: 0x04003AA3 RID: 15011
					[Token(Token = "0x4003AA3")]
					[FieldOffset(Offset = "0x30")]
					public long ts;
				}

				// Token: 0x02000AE5 RID: 2789
				[Token(Token = "0x2000AE5")]
				public class Totem
				{
					// Token: 0x0600679C RID: 26524 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679C")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Totem()
					{
					}

					// Token: 0x04003AA4 RID: 15012
					[Token(Token = "0x4003AA4")]
					[FieldOffset(Offset = "0x10")]
					public List<PlayerRoguelikeV2.CurrentData.Module.InventoryTotem> totemPiece;

					// Token: 0x04003AA5 RID: 15013
					[Token(Token = "0x4003AA5")]
					[FieldOffset(Offset = "0x18")]
					public string predictTotemId;
				}

				// Token: 0x02000AE6 RID: 2790
				[Token(Token = "0x2000AE6")]
				public class Vision
				{
					// Token: 0x0600679D RID: 26525 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679D")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Vision()
					{
					}

					// Token: 0x04003AA6 RID: 15014
					[Token(Token = "0x4003AA6")]
					[FieldOffset(Offset = "0x10")]
					public int value;

					// Token: 0x04003AA7 RID: 15015
					[Token(Token = "0x4003AA7")]
					[FieldOffset(Offset = "0x14")]
					public bool isMax;
				}

				// Token: 0x02000AE7 RID: 2791
				[Token(Token = "0x2000AE7")]
				public class ChaosZoneDelta
				{
					// Token: 0x0600679E RID: 26526 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679E")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public ChaosZoneDelta()
					{
					}

					// Token: 0x04003AA8 RID: 15016
					[Token(Token = "0x4003AA8")]
					[FieldOffset(Offset = "0x10")]
					public int dValue;

					// Token: 0x04003AA9 RID: 15017
					[Token(Token = "0x4003AA9")]
					[FieldOffset(Offset = "0x14")]
					public int preLevel;

					// Token: 0x04003AAA RID: 15018
					[Token(Token = "0x4003AAA")]
					[FieldOffset(Offset = "0x18")]
					public int afterLevel;

					// Token: 0x04003AAB RID: 15019
					[Token(Token = "0x4003AAB")]
					[FieldOffset(Offset = "0x20")]
					public List<string> dChaos;
				}

				// Token: 0x02000AE8 RID: 2792
				[Token(Token = "0x2000AE8")]
				public class Chaos
				{
					// Token: 0x0600679F RID: 26527 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x600679F")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Chaos()
					{
					}

					// Token: 0x04003AAC RID: 15020
					[Token(Token = "0x4003AAC")]
					[FieldOffset(Offset = "0x10")]
					public int value;

					// Token: 0x04003AAD RID: 15021
					[Token(Token = "0x4003AAD")]
					[FieldOffset(Offset = "0x14")]
					public int level;

					// Token: 0x04003AAE RID: 15022
					[Token(Token = "0x4003AAE")]
					[FieldOffset(Offset = "0x18")]
					public int curMaxValue;

					// Token: 0x04003AAF RID: 15023
					[Token(Token = "0x4003AAF")]
					[FieldOffset(Offset = "0x20")]
					public List<string> chaosList;

					// Token: 0x04003AB0 RID: 15024
					[Token(Token = "0x4003AB0")]
					[FieldOffset(Offset = "0x28")]
					public string predict;

					// Token: 0x04003AB1 RID: 15025
					[Token(Token = "0x4003AB1")]
					[FieldOffset(Offset = "0x30")]
					public PlayerRoguelikeV2.CurrentData.Module.ChaosZoneDelta deltaChaos;

					// Token: 0x04003AB2 RID: 15026
					[Token(Token = "0x4003AB2")]
					[FieldOffset(Offset = "0x38")]
					public int lastBattleGain;
				}

				// Token: 0x02000AE9 RID: 2793
				[Token(Token = "0x2000AE9")]
				public class Fragment
				{
					// Token: 0x060067A0 RID: 26528 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A0")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Fragment()
					{
					}

					// Token: 0x04003AB3 RID: 15027
					[Token(Token = "0x4003AB3")]
					[FieldOffset(Offset = "0x10")]
					public int totalWeight;

					// Token: 0x04003AB4 RID: 15028
					[Token(Token = "0x4003AB4")]
					[FieldOffset(Offset = "0x14")]
					public int limitWeight;

					// Token: 0x04003AB5 RID: 15029
					[Token(Token = "0x4003AB5")]
					[FieldOffset(Offset = "0x18")]
					public int overWeight;

					// Token: 0x04003AB6 RID: 15030
					[Token(Token = "0x4003AB6")]
					[FieldOffset(Offset = "0x20")]
					public Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.InventoryFragment> fragments;

					// Token: 0x04003AB7 RID: 15031
					[Token(Token = "0x4003AB7")]
					[FieldOffset(Offset = "0x28")]
					public Dictionary<int, int> troopWeights;

					// Token: 0x04003AB8 RID: 15032
					[Token(Token = "0x4003AB8")]
					[FieldOffset(Offset = "0x30")]
					public List<int> troopCarry;

					// Token: 0x04003AB9 RID: 15033
					[Token(Token = "0x4003AB9")]
					[FieldOffset(Offset = "0x38")]
					public int sellCount;

					// Token: 0x04003ABA RID: 15034
					[Token(Token = "0x4003ABA")]
					[FieldOffset(Offset = "0x40")]
					public PlayerRoguelikeV2.CurrentData.Module.InventoryInspiration currInspiration;
				}

				// Token: 0x02000AEA RID: 2794
				[Token(Token = "0x2000AEA")]
				public class InventoryFragment
				{
					// Token: 0x060067A1 RID: 26529 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A1")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public InventoryFragment()
					{
					}

					// Token: 0x04003ABB RID: 15035
					[Token(Token = "0x4003ABB")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003ABC RID: 15036
					[Token(Token = "0x4003ABC")]
					[FieldOffset(Offset = "0x18")]
					public string index;

					// Token: 0x04003ABD RID: 15037
					[Token(Token = "0x4003ABD")]
					[FieldOffset(Offset = "0x20")]
					public bool used;

					// Token: 0x04003ABE RID: 15038
					[Token(Token = "0x4003ABE")]
					[FieldOffset(Offset = "0x28")]
					public long ts;

					// Token: 0x04003ABF RID: 15039
					[Token(Token = "0x4003ABF")]
					[FieldOffset(Offset = "0x30")]
					public int weight;

					// Token: 0x04003AC0 RID: 15040
					[Token(Token = "0x4003AC0")]
					[FieldOffset(Offset = "0x34")]
					public int value;

					// Token: 0x04003AC1 RID: 15041
					[Token(Token = "0x4003AC1")]
					[FieldOffset(Offset = "0x38")]
					public int price;
				}

				// Token: 0x02000AEB RID: 2795
				[Token(Token = "0x2000AEB")]
				public class InventoryInspiration
				{
					// Token: 0x060067A2 RID: 26530 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A2")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public InventoryInspiration()
					{
					}

					// Token: 0x04003AC2 RID: 15042
					[Token(Token = "0x4003AC2")]
					[FieldOffset(Offset = "0x10")]
					public string instId;

					// Token: 0x04003AC3 RID: 15043
					[Token(Token = "0x4003AC3")]
					[FieldOffset(Offset = "0x18")]
					public string id;
				}

				// Token: 0x02000AEC RID: 2796
				[Token(Token = "0x2000AEC")]
				public class Disaster
				{
					// Token: 0x060067A3 RID: 26531 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A3")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Disaster()
					{
					}

					// Token: 0x04003AC4 RID: 15044
					[Token(Token = "0x4003AC4")]
					[FieldOffset(Offset = "0x10")]
					[JsonProperty("curDisaster")]
					public string curDisasterId;

					// Token: 0x04003AC5 RID: 15045
					[Token(Token = "0x4003AC5")]
					[FieldOffset(Offset = "0x18")]
					public int disperseStep;
				}

				// Token: 0x02000AED RID: 2797
				[Token(Token = "0x2000AED")]
				public class NodeUpgrade
				{
					// Token: 0x060067A4 RID: 26532 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A4")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public NodeUpgrade()
					{
					}

					// Token: 0x04003AC6 RID: 15046
					[Token(Token = "0x4003AC6")]
					[FieldOffset(Offset = "0x10")]
					public Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.NodeUpgradeInfo> nodeTypeInfoMap;
				}

				// Token: 0x02000AEE RID: 2798
				[Token(Token = "0x2000AEE")]
				public class NodeUpgradeInfo
				{
					// Token: 0x060067A5 RID: 26533 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A5")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public NodeUpgradeInfo()
					{
					}

					// Token: 0x04003AC7 RID: 15047
					[Token(Token = "0x4003AC7")]
					[FieldOffset(Offset = "0x10")]
					public string tempUpgrade;

					// Token: 0x04003AC8 RID: 15048
					[Token(Token = "0x4003AC8")]
					[FieldOffset(Offset = "0x18")]
					public List<string> upgradeList;
				}

				// Token: 0x02000AEF RID: 2799
				[Token(Token = "0x2000AEF")]
				public class Copper
				{
					// Token: 0x060067A6 RID: 26534 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A6")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Copper()
					{
					}

					// Token: 0x04003AC9 RID: 15049
					[Token(Token = "0x4003AC9")]
					[FieldOffset(Offset = "0x10")]
					public Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.InventoryCopper> bag;

					// Token: 0x04003ACA RID: 15050
					[Token(Token = "0x4003ACA")]
					[FieldOffset(Offset = "0x18")]
					public int redrawCost;

					// Token: 0x04003ACB RID: 15051
					[Token(Token = "0x4003ACB")]
					[FieldOffset(Offset = "0x1C")]
					public bool redrawFreeze;

					// Token: 0x04003ACC RID: 15052
					[Token(Token = "0x4003ACC")]
					[FieldOffset(Offset = "0x20")]
					public int redrawFreezeCnt;
				}

				// Token: 0x02000AF0 RID: 2800
				[Token(Token = "0x2000AF0")]
				public class InventoryCopper
				{
					// Token: 0x060067A7 RID: 26535 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A7")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public InventoryCopper()
					{
					}

					// Token: 0x04003ACD RID: 15053
					[Token(Token = "0x4003ACD")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003ACE RID: 15054
					[Token(Token = "0x4003ACE")]
					[FieldOffset(Offset = "0x18")]
					public bool isDrawn;

					// Token: 0x04003ACF RID: 15055
					[Token(Token = "0x4003ACF")]
					[FieldOffset(Offset = "0x1C")]
					public int layer;

					// Token: 0x04003AD0 RID: 15056
					[Token(Token = "0x4003AD0")]
					[FieldOffset(Offset = "0x20")]
					public int countDown;

					// Token: 0x04003AD1 RID: 15057
					[Token(Token = "0x4003AD1")]
					[FieldOffset(Offset = "0x28")]
					public long ts;
				}

				// Token: 0x02000AF1 RID: 2801
				[Token(Token = "0x2000AF1")]
				public class Wrath
				{
					// Token: 0x060067A8 RID: 26536 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A8")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public Wrath()
					{
					}

					// Token: 0x04003AD2 RID: 15058
					[Token(Token = "0x4003AD2")]
					[FieldOffset(Offset = "0x10")]
					public string[] wraths;

					// Token: 0x04003AD3 RID: 15059
					[Token(Token = "0x4003AD3")]
					[FieldOffset(Offset = "0x18")]
					public int newWrath;
				}

				// Token: 0x02000AF2 RID: 2802
				[Token(Token = "0x2000AF2")]
				public class WrathInfo
				{
					// Token: 0x060067A9 RID: 26537 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067A9")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public WrathInfo()
					{
					}

					// Token: 0x04003AD4 RID: 15060
					[Token(Token = "0x4003AD4")]
					[FieldOffset(Offset = "0x10")]
					public string wrathId;

					// Token: 0x04003AD5 RID: 15061
					[Token(Token = "0x4003AD5")]
					[FieldOffset(Offset = "0x18")]
					public int level;
				}

				// Token: 0x02000AF3 RID: 2803
				[Token(Token = "0x2000AF3")]
				public class Sky
				{
					// Token: 0x060067AA RID: 26538 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067AA")]
					[Address(RVA = "0x1F01AA0", Offset = "0x1F006A0", VA = "0x181F01AA0")]
					public Sky()
					{
					}

					// Token: 0x04003AD6 RID: 15062
					[Token(Token = "0x4003AD6")]
					[FieldOffset(Offset = "0x10")]
					public Dictionary<int, PlayerRoguelikeV2.CurrentData.Module.SkyZoneInfo> zones;
				}

				// Token: 0x02000AF4 RID: 2804
				[Token(Token = "0x2000AF4")]
				public class SkyZoneInfo
				{
					// Token: 0x060067AB RID: 26539 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067AB")]
					[Address(RVA = "0x1F01A10", Offset = "0x1F00610", VA = "0x181F01A10")]
					public SkyZoneInfo()
					{
					}

					// Token: 0x04003AD7 RID: 15063
					[Token(Token = "0x4003AD7")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003AD8 RID: 15064
					[Token(Token = "0x4003AD8")]
					[FieldOffset(Offset = "0x18")]
					public int ap;

					// Token: 0x04003AD9 RID: 15065
					[Token(Token = "0x4003AD9")]
					[FieldOffset(Offset = "0x20")]
					public Dictionary<int, PlayerRoguelikeV2.CurrentData.Module.SkyZoneNodeInfo> nodes;

					// Token: 0x04003ADA RID: 15066
					[Token(Token = "0x4003ADA")]
					[FieldOffset(Offset = "0x28")]
					public PlayerRoguelikeV2.CurrentData.Module.SkyZoneExPadInfo mapExPad;
				}

				// Token: 0x02000AF5 RID: 2805
				[Token(Token = "0x2000AF5")]
				public class SkyZoneExPadInfo
				{
					// Token: 0x060067AC RID: 26540 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067AC")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public SkyZoneExPadInfo()
					{
					}

					// Token: 0x04003ADB RID: 15067
					[Token(Token = "0x4003ADB")]
					[FieldOffset(Offset = "0x10")]
					public int left;

					// Token: 0x04003ADC RID: 15068
					[Token(Token = "0x4003ADC")]
					[FieldOffset(Offset = "0x14")]
					public int right;
				}

				// Token: 0x02000AF6 RID: 2806
				[Token(Token = "0x2000AF6")]
				public enum SkyZoneNodeState
				{
					// Token: 0x04003ADE RID: 15070
					[Token(Token = "0x4003ADE")]
					LOCK,
					// Token: 0x04003ADF RID: 15071
					[Token(Token = "0x4003ADF")]
					UNLOCK,
					// Token: 0x04003AE0 RID: 15072
					[Token(Token = "0x4003AE0")]
					FINISH,
					// Token: 0x04003AE1 RID: 15073
					[Token(Token = "0x4003AE1")]
					CLOSE
				}

				// Token: 0x02000AF7 RID: 2807
				[Token(Token = "0x2000AF7")]
				public class SkyZoneNodeInfo
				{
					// Token: 0x060067AD RID: 26541 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067AD")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public SkyZoneNodeInfo()
					{
					}

					// Token: 0x04003AE2 RID: 15074
					[Token(Token = "0x4003AE2")]
					[FieldOffset(Offset = "0x10")]
					public PlayerRoguelikeV2.CurrentData.Module.SkyZoneNodeState state;

					// Token: 0x04003AE3 RID: 15075
					[Token(Token = "0x4003AE3")]
					[FieldOffset(Offset = "0x14")]
					public int type;

					// Token: 0x04003AE4 RID: 15076
					[Token(Token = "0x4003AE4")]
					[FieldOffset(Offset = "0x18")]
					public int sceneSubType;

					// Token: 0x04003AE5 RID: 15077
					[Token(Token = "0x4003AE5")]
					[FieldOffset(Offset = "0x20")]
					public int[] battleProgress;

					// Token: 0x04003AE6 RID: 15078
					[Token(Token = "0x4003AE6")]
					[FieldOffset(Offset = "0x28")]
					public bool shopIsEmpty;

					// Token: 0x04003AE7 RID: 15079
					[Token(Token = "0x4003AE7")]
					[FieldOffset(Offset = "0x30")]
					public List<string> shopGoodIds;

					// Token: 0x04003AE8 RID: 15080
					[Token(Token = "0x4003AE8")]
					[FieldOffset(Offset = "0x38")]
					public bool shopRefreshShow;

					// Token: 0x04003AE9 RID: 15081
					[Token(Token = "0x4003AE9")]
					[FieldOffset(Offset = "0x3C")]
					public int shopRefreshCnt;

					// Token: 0x04003AEA RID: 15082
					[Token(Token = "0x4003AEA")]
					[FieldOffset(Offset = "0x40")]
					public int shopRefreshCost;
				}
			}
		}

		// Token: 0x02000AF8 RID: 2808
		[Token(Token = "0x2000AF8")]
		public class OuterData
		{
			// Token: 0x060067AE RID: 26542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60067AE")]
			[Address(RVA = "0x1EECC30", Offset = "0x1EEB830", VA = "0x181EECC30")]
			public OuterData()
			{
			}

			// Token: 0x04003AEB RID: 15083
			[Token(Token = "0x4003AEB")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikeV2.OuterData.BattlePass bp;

			// Token: 0x04003AEC RID: 15084
			[Token(Token = "0x4003AEC")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikeV2.OuterData.Buff buff;

			// Token: 0x04003AED RID: 15085
			[Token(Token = "0x4003AED")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikeV2.OuterData.Mission mission;

			// Token: 0x04003AEE RID: 15086
			[Token(Token = "0x4003AEE")]
			[FieldOffset(Offset = "0x28")]
			public PlayerRoguelikeV2.OuterData.Collection collect;

			// Token: 0x04003AEF RID: 15087
			[Token(Token = "0x4003AEF")]
			[FieldOffset(Offset = "0x30")]
			public PlayerRoguelikeV2.OuterData.Bank bank;

			// Token: 0x04003AF0 RID: 15088
			[Token(Token = "0x4003AF0")]
			[FieldOffset(Offset = "0x38")]
			public PlayerRoguelikeV2.OuterData.Record record;

			// Token: 0x04003AF1 RID: 15089
			[Token(Token = "0x4003AF1")]
			[FieldOffset(Offset = "0x40")]
			public PlayerRoguelikeV2.OuterData.MonthTeam monthTeam;

			// Token: 0x04003AF2 RID: 15090
			[Token(Token = "0x4003AF2")]
			[FieldOffset(Offset = "0x48")]
			public PlayerRoguelikeV2.OuterData.Challenge challenge;

			// Token: 0x04003AF3 RID: 15091
			[Token(Token = "0x4003AF3")]
			[FieldOffset(Offset = "0x50")]
			public PlayerRoguelikeV2.OuterData.PlayerRogueActivity activity;

			// Token: 0x02000AF9 RID: 2809
			[Token(Token = "0x2000AF9")]
			public class Record
			{
				// Token: 0x060067AF RID: 26543 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067AF")]
				[Address(RVA = "0x1F00430", Offset = "0x1EFF030", VA = "0x181F00430")]
				public Record()
				{
				}

				// Token: 0x04003AF4 RID: 15092
				[Token(Token = "0x4003AF4")]
				[FieldOffset(Offset = "0x10")]
				public long last;

				// Token: 0x04003AF5 RID: 15093
				[Token(Token = "0x4003AF5")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> stageCnt;

				// Token: 0x04003AF6 RID: 15094
				[Token(Token = "0x4003AF6")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, Dictionary<string, int>> bandCnt;

				// Token: 0x04003AF7 RID: 15095
				[Token(Token = "0x4003AF7")]
				[FieldOffset(Offset = "0x28")]
				public Dictionary<string, Dictionary<string, int>> bandGrade;

				// Token: 0x04003AF8 RID: 15096
				[Token(Token = "0x4003AF8")]
				[FieldOffset(Offset = "0x30")]
				public List<PlayerRoguelikeV2.OuterData.Record.History> history;

				// Token: 0x02000AFA RID: 2810
				[Token(Token = "0x2000AFA")]
				public class History
				{
					// Token: 0x060067B0 RID: 26544 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067B0")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public History()
					{
					}

					// Token: 0x04003AF9 RID: 15097
					[Token(Token = "0x4003AF9")]
					[FieldOffset(Offset = "0x10")]
					public string seed;

					// Token: 0x04003AFA RID: 15098
					[Token(Token = "0x4003AFA")]
					[FieldOffset(Offset = "0x18")]
					public string bandId;

					// Token: 0x04003AFB RID: 15099
					[Token(Token = "0x4003AFB")]
					[FieldOffset(Offset = "0x20")]
					public RoguelikeTopicMode mode;

					// Token: 0x04003AFC RID: 15100
					[Token(Token = "0x4003AFC")]
					[FieldOffset(Offset = "0x24")]
					public int modeGrade;

					// Token: 0x04003AFD RID: 15101
					[Token(Token = "0x4003AFD")]
					[FieldOffset(Offset = "0x28")]
					public string ending;

					// Token: 0x04003AFE RID: 15102
					[Token(Token = "0x4003AFE")]
					[FieldOffset(Offset = "0x30")]
					public string failEnding;

					// Token: 0x04003AFF RID: 15103
					[Token(Token = "0x4003AFF")]
					[FieldOffset(Offset = "0x38")]
					public int result;

					// Token: 0x04003B00 RID: 15104
					[Token(Token = "0x4003B00")]
					[FieldOffset(Offset = "0x40")]
					public long endTs;
				}
			}

			// Token: 0x02000AFB RID: 2811
			[Token(Token = "0x2000AFB")]
			public class BattlePass
			{
				// Token: 0x060067B1 RID: 26545 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067B1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BattlePass()
				{
				}

				// Token: 0x04003B01 RID: 15105
				[Token(Token = "0x4003B01")]
				[FieldOffset(Offset = "0x10")]
				public int point;

				// Token: 0x04003B02 RID: 15106
				[Token(Token = "0x4003B02")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> reward;
			}

			// Token: 0x02000AFC RID: 2812
			[Token(Token = "0x2000AFC")]
			public class Mission
			{
				// Token: 0x060067B2 RID: 26546 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067B2")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Mission()
				{
				}

				// Token: 0x04003B03 RID: 15107
				[Token(Token = "0x4003B03")]
				[FieldOffset(Offset = "0x10")]
				public string updateId;

				// Token: 0x04003B04 RID: 15108
				[Token(Token = "0x4003B04")]
				[FieldOffset(Offset = "0x18")]
				public int refresh;

				// Token: 0x04003B05 RID: 15109
				[Token(Token = "0x4003B05")]
				[FieldOffset(Offset = "0x20")]
				public List<PlayerRoguelikeV2.OuterData.Mission.MissionSlot> list;

				// Token: 0x02000AFD RID: 2813
				[Token(Token = "0x2000AFD")]
				public class MissionSlot
				{
					// Token: 0x060067B3 RID: 26547 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067B3")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public MissionSlot()
					{
					}

					// Token: 0x04003B06 RID: 15110
					[Token(Token = "0x4003B06")]
					[FieldOffset(Offset = "0x10")]
					public RoguelikeGameMonthTaskClass type;

					// Token: 0x04003B07 RID: 15111
					[Token(Token = "0x4003B07")]
					[FieldOffset(Offset = "0x18")]
					public PlayerRoguelikeV2.OuterData.Mission.MissionItem mission;
				}

				// Token: 0x02000AFE RID: 2814
				[Token(Token = "0x2000AFE")]
				public class MissionItem
				{
					// Token: 0x060067B4 RID: 26548 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067B4")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public MissionItem()
					{
					}

					// Token: 0x04003B08 RID: 15112
					[Token(Token = "0x4003B08")]
					[FieldOffset(Offset = "0x10")]
					public RoguelikeGameMonthTaskClass type;

					// Token: 0x04003B09 RID: 15113
					[Token(Token = "0x4003B09")]
					[FieldOffset(Offset = "0x18")]
					public string id;

					// Token: 0x04003B0A RID: 15114
					[Token(Token = "0x4003B0A")]
					[FieldOffset(Offset = "0x20")]
					public int state;

					// Token: 0x04003B0B RID: 15115
					[Token(Token = "0x4003B0B")]
					[FieldOffset(Offset = "0x24")]
					public int target;

					// Token: 0x04003B0C RID: 15116
					[Token(Token = "0x4003B0C")]
					[FieldOffset(Offset = "0x28")]
					public int value;
				}
			}

			// Token: 0x02000AFF RID: 2815
			[Token(Token = "0x2000AFF")]
			public class TotemCollection
			{
				// Token: 0x060067B5 RID: 26549 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067B5")]
				[Address(RVA = "0x1F02830", Offset = "0x1F01430", VA = "0x181F02830")]
				public TotemCollection()
				{
				}

				// Token: 0x04003B0D RID: 15117
				[Token(Token = "0x4003B0D")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> totem;

				// Token: 0x04003B0E RID: 15118
				[Token(Token = "0x4003B0E")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> affix;
			}

			// Token: 0x02000B00 RID: 2816
			[Token(Token = "0x2000B00")]
			public class Collection
			{
				// Token: 0x060067B6 RID: 26550 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067B6")]
				[Address(RVA = "0x1EE7D40", Offset = "0x1EE6940", VA = "0x181EE7D40")]
				public Collection()
				{
				}

				// Token: 0x04003B0F RID: 15119
				[Token(Token = "0x4003B0F")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> band;

				// Token: 0x04003B10 RID: 15120
				[Token(Token = "0x4003B10")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> relic;

				// Token: 0x04003B11 RID: 15121
				[Token(Token = "0x4003B11")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> capsule;

				// Token: 0x04003B12 RID: 15122
				[Token(Token = "0x4003B12")]
				[FieldOffset(Offset = "0x28")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> activeTool;

				// Token: 0x04003B13 RID: 15123
				[Token(Token = "0x4003B13")]
				[FieldOffset(Offset = "0x30")]
				public Dictionary<RoguelikeTopicMode, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> mode;

				// Token: 0x04003B14 RID: 15124
				[Token(Token = "0x4003B14")]
				[FieldOffset(Offset = "0x38")]
				public Dictionary<RoguelikeTopicMode, Dictionary<int, PlayerRoguelikeV2.OuterData.Collection.DifficultyUnlockInfo>> modeGrade;

				// Token: 0x04003B15 RID: 15125
				[Token(Token = "0x4003B15")]
				[FieldOffset(Offset = "0x40")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> recruitSet;

				// Token: 0x04003B16 RID: 15126
				[Token(Token = "0x4003B16")]
				[FieldOffset(Offset = "0x48")]
				public Dictionary<string, int> bgm;

				// Token: 0x04003B17 RID: 15127
				[Token(Token = "0x4003B17")]
				[FieldOffset(Offset = "0x50")]
				public Dictionary<string, int> pic;

				// Token: 0x04003B18 RID: 15128
				[Token(Token = "0x4003B18")]
				[FieldOffset(Offset = "0x58")]
				public Dictionary<string, List<string>> chatV2;

				// Token: 0x04003B19 RID: 15129
				[Token(Token = "0x4003B19")]
				[FieldOffset(Offset = "0x60")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> endbook;

				// Token: 0x04003B1A RID: 15130
				[Token(Token = "0x4003B1A")]
				[FieldOffset(Offset = "0x68")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> buff;

				// Token: 0x04003B1B RID: 15131
				[Token(Token = "0x4003B1B")]
				[FieldOffset(Offset = "0x70")]
				public PlayerRoguelikeV2.OuterData.TotemCollection totem;

				// Token: 0x04003B1C RID: 15132
				[Token(Token = "0x4003B1C")]
				[FieldOffset(Offset = "0x78")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> chaos;

				// Token: 0x04003B1D RID: 15133
				[Token(Token = "0x4003B1D")]
				[FieldOffset(Offset = "0x80")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> fragment;

				// Token: 0x04003B1E RID: 15134
				[Token(Token = "0x4003B1E")]
				[FieldOffset(Offset = "0x88")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> disaster;

				// Token: 0x04003B1F RID: 15135
				[Token(Token = "0x4003B1F")]
				[FieldOffset(Offset = "0x90")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.NodeUpgradeInfo> nodeUpgrade;

				// Token: 0x04003B20 RID: 15136
				[Token(Token = "0x4003B20")]
				[FieldOffset(Offset = "0x98")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> copper;

				// Token: 0x04003B21 RID: 15137
				[Token(Token = "0x4003B21")]
				[FieldOffset(Offset = "0xA0")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> wrath;

				// Token: 0x02000B01 RID: 2817
				[Token(Token = "0x2000B01")]
				public class ItemUnlockInfo
				{
					// Token: 0x060067B7 RID: 26551 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067B7")]
					[Address(RVA = "0x1EEAE50", Offset = "0x1EE9A50", VA = "0x181EEAE50")]
					public ItemUnlockInfo()
					{
					}

					// Token: 0x04003B22 RID: 15138
					[Token(Token = "0x4003B22")]
					[FieldOffset(Offset = "0x10")]
					public RoguelikeArchiveItemUnlockStatus state;

					// Token: 0x04003B23 RID: 15139
					[Token(Token = "0x4003B23")]
					[FieldOffset(Offset = "0x18")]
					public List<int> progress;
				}

				// Token: 0x02000B02 RID: 2818
				[Token(Token = "0x2000B02")]
				public class DifficultyUnlockInfo
				{
					// Token: 0x060067B8 RID: 26552 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067B8")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public DifficultyUnlockInfo()
					{
					}

					// Token: 0x04003B24 RID: 15140
					[Token(Token = "0x4003B24")]
					[FieldOffset(Offset = "0x10")]
					public PlayerRoguelikeDifficultyStatus state;
				}
			}

			// Token: 0x02000B03 RID: 2819
			[Token(Token = "0x2000B03")]
			public class Bank
			{
				// Token: 0x060067B9 RID: 26553 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067B9")]
				[Address(RVA = "0x1EE6860", Offset = "0x1EE5460", VA = "0x181EE6860")]
				public Bank()
				{
				}

				// Token: 0x04003B25 RID: 15141
				[Token(Token = "0x4003B25")]
				[FieldOffset(Offset = "0x10")]
				public bool show;

				// Token: 0x04003B26 RID: 15142
				[Token(Token = "0x4003B26")]
				[FieldOffset(Offset = "0x14")]
				public int current;

				// Token: 0x04003B27 RID: 15143
				[Token(Token = "0x4003B27")]
				[FieldOffset(Offset = "0x18")]
				public int record;

				// Token: 0x04003B28 RID: 15144
				[Token(Token = "0x4003B28")]
				[FieldOffset(Offset = "0x1C")]
				public int totalPut;

				// Token: 0x04003B29 RID: 15145
				[Token(Token = "0x4003B29")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, int> reward;
			}

			// Token: 0x02000B04 RID: 2820
			[Token(Token = "0x2000B04")]
			public class Buff
			{
				// Token: 0x060067BA RID: 26554 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BA")]
				[Address(RVA = "0x1EE7130", Offset = "0x1EE5D30", VA = "0x181EE7130")]
				public Buff()
				{
				}

				// Token: 0x04003B2A RID: 15146
				[Token(Token = "0x4003B2A")]
				[FieldOffset(Offset = "0x10")]
				public int pointOwned;

				// Token: 0x04003B2B RID: 15147
				[Token(Token = "0x4003B2B")]
				[FieldOffset(Offset = "0x14")]
				public int pointCost;

				// Token: 0x04003B2C RID: 15148
				[Token(Token = "0x4003B2C")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> unlocked;
			}

			// Token: 0x02000B05 RID: 2821
			[Token(Token = "0x2000B05")]
			public class MonthTeam
			{
				// Token: 0x060067BB RID: 26555 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BB")]
				[Address(RVA = "0x1EEC410", Offset = "0x1EEB010", VA = "0x181EEC410")]
				public MonthTeam()
				{
				}

				// Token: 0x04003B2D RID: 15149
				[Token(Token = "0x4003B2D")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> reward;

				// Token: 0x04003B2E RID: 15150
				[Token(Token = "0x4003B2E")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, List<int>> mission;
			}

			// Token: 0x02000B06 RID: 2822
			[Token(Token = "0x2000B06")]
			public class ChallengeCollection
			{
				// Token: 0x060067BC RID: 26556 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BC")]
				[Address(RVA = "0x1EE7320", Offset = "0x1EE5F20", VA = "0x181EE7320")]
				public ChallengeCollection()
				{
				}

				// Token: 0x04003B2F RID: 15151
				[Token(Token = "0x4003B2F")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> exploreTool;
			}

			// Token: 0x02000B07 RID: 2823
			[Token(Token = "0x2000B07")]
			public class Challenge
			{
				// Token: 0x060067BD RID: 26557 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BD")]
				[Address(RVA = "0x1EE7440", Offset = "0x1EE6040", VA = "0x181EE7440")]
				public Challenge()
				{
				}

				// Token: 0x04003B30 RID: 15152
				[Token(Token = "0x4003B30")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, int> reward;

				// Token: 0x04003B31 RID: 15153
				[Token(Token = "0x4003B31")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerRoguelikeChallengeStatus> grade;

				// Token: 0x04003B32 RID: 15154
				[Token(Token = "0x4003B32")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRoguelikeV2.OuterData.ChallengeCollection collect;
			}

			// Token: 0x02000B08 RID: 2824
			[Token(Token = "0x2000B08")]
			public class NodeUpgradeInfo
			{
				// Token: 0x060067BE RID: 26558 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BE")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NodeUpgradeInfo()
				{
				}

				// Token: 0x04003B33 RID: 15155
				[Token(Token = "0x4003B33")]
				[FieldOffset(Offset = "0x10")]
				public List<string> unlockList;
			}

			// Token: 0x02000B09 RID: 2825
			[Token(Token = "0x2000B09")]
			public class PlayerRogueActivity
			{
				// Token: 0x060067BF RID: 26559 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60067BF")]
				[Address(RVA = "0x1EFC6D0", Offset = "0x1EFB2D0", VA = "0x181EFC6D0")]
				public PlayerRogueActivity()
				{
				}

				// Token: 0x04003B34 RID: 15156
				[Token(Token = "0x4003B34")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty("SEED_MODE")]
				public ListDict<string, PlayerRoguelikeV2.OuterData.PlayerRogueActivity.PlayerRoguelikeActivitySeedModeData> roguelikeActivitySeedModeDatas;

				// Token: 0x02000B0A RID: 2826
				[Token(Token = "0x2000B0A")]
				public class PlayerRoguelikeActivitySeedModeData
				{
					// Token: 0x060067C0 RID: 26560 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067C0")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public PlayerRoguelikeActivitySeedModeData()
					{
					}

					// Token: 0x04003B35 RID: 15157
					[Token(Token = "0x4003B35")]
					[FieldOffset(Offset = "0x10")]
					public PlayerRoguelikeV2.OuterData.PlayerRogueActivity.PlayerRogueActivityUnlockInfo unlockState;

					// Token: 0x04003B36 RID: 15158
					[Token(Token = "0x4003B36")]
					[FieldOffset(Offset = "0x18")]
					public string seed;
				}

				// Token: 0x02000B0B RID: 2827
				[Token(Token = "0x2000B0B")]
				public class PlayerRogueActivityUnlockInfo
				{
					// Token: 0x060067C1 RID: 26561 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60067C1")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public PlayerRogueActivityUnlockInfo()
					{
					}

					// Token: 0x04003B37 RID: 15159
					[Token(Token = "0x4003B37")]
					[FieldOffset(Offset = "0x10")]
					public PlayerRoguelikeV2.OuterData.PlayerRogueActivity.PlayerRogueActivityUnlockInfo.PlayerRogueActivityUnlockState state;

					// Token: 0x04003B38 RID: 15160
					[Token(Token = "0x4003B38")]
					[FieldOffset(Offset = "0x18")]
					public List<int> progress;

					// Token: 0x02000B0C RID: 2828
					[Token(Token = "0x2000B0C")]
					public enum PlayerRogueActivityUnlockState
					{
						// Token: 0x04003B3A RID: 15162
						[Token(Token = "0x4003B3A")]
						LOCKED,
						// Token: 0x04003B3B RID: 15163
						[Token(Token = "0x4003B3B")]
						UNLOCKED_UNPLAYED,
						// Token: 0x04003B3C RID: 15164
						[Token(Token = "0x4003B3C")]
						UNLOCKED_PLAYED
					}
				}
			}
		}
	}
}
