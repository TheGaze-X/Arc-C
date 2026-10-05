using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.UI.ReportPlayer;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200709C RID: 28828
	[Token(Token = "0x200709C")]
	public class ActMultiV3BattleFinishViewModel : IHotfixable
	{
		// Token: 0x170060EB RID: 24811
		// (get) Token: 0x06028F51 RID: 167761 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F52 RID: 167762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060EB")]
		public SquadFriendData squadFriendData
		{
			[Token(Token = "0x6028F51")]
			[Address(RVA = "0x24549F0", Offset = "0x24535F0", VA = "0x1824549F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F52")]
			[Address(RVA = "0x2455B60", Offset = "0x2454760", VA = "0x182455B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060EC RID: 24812
		// (get) Token: 0x06028F53 RID: 167763 RVA: 0x000D3AE8 File Offset: 0x000D1CE8
		// (set) Token: 0x06028F54 RID: 167764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060EC")]
		public bool isMatch
		{
			[Token(Token = "0x6028F53")]
			[Address(RVA = "0x2453DF0", Offset = "0x24529F0", VA = "0x182453DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F54")]
			[Address(RVA = "0x2455320", Offset = "0x2453F20", VA = "0x182455320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060ED RID: 24813
		// (get) Token: 0x06028F55 RID: 167765 RVA: 0x000D3B00 File Offset: 0x000D1D00
		// (set) Token: 0x06028F56 RID: 167766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060ED")]
		public bool isValid
		{
			[Token(Token = "0x6028F55")]
			[Address(RVA = "0x2454030", Offset = "0x2452C30", VA = "0x182454030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F56")]
			[Address(RVA = "0x24554E0", Offset = "0x24540E0", VA = "0x1824554E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060EE RID: 24814
		// (get) Token: 0x06028F57 RID: 167767 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F58 RID: 167768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060EE")]
		public string actId
		{
			[Token(Token = "0x6028F57")]
			[Address(RVA = "0x2453730", Offset = "0x2452330", VA = "0x182453730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F58")]
			[Address(RVA = "0x2454B10", Offset = "0x2453710", VA = "0x182454B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060EF RID: 24815
		// (get) Token: 0x06028F59 RID: 167769 RVA: 0x000D3B18 File Offset: 0x000D1D18
		// (set) Token: 0x06028F5A RID: 167770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060EF")]
		public bool isRoomClose
		{
			[Token(Token = "0x6028F59")]
			[Address(RVA = "0x2453F10", Offset = "0x2452B10", VA = "0x182453F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F5A")]
			[Address(RVA = "0x2455400", Offset = "0x2454000", VA = "0x182455400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060F0 RID: 24816
		// (get) Token: 0x06028F5B RID: 167771 RVA: 0x000D3B30 File Offset: 0x000D1D30
		// (set) Token: 0x06028F5C RID: 167772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F0")]
		public bool hasGivenLike
		{
			[Token(Token = "0x6028F5B")]
			[Address(RVA = "0x2453BB0", Offset = "0x24527B0", VA = "0x182453BB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F5C")]
			[Address(RVA = "0x2455080", Offset = "0x2453C80", VA = "0x182455080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060F1 RID: 24817
		// (get) Token: 0x06028F5D RID: 167773 RVA: 0x000D3B48 File Offset: 0x000D1D48
		// (set) Token: 0x06028F5E RID: 167774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F1")]
		public bool hasGotLike
		{
			[Token(Token = "0x6028F5D")]
			[Address(RVA = "0x2453C10", Offset = "0x2452810", VA = "0x182453C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F5E")]
			[Address(RVA = "0x24550F0", Offset = "0x2453CF0", VA = "0x1824550F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F2 RID: 24818
		// (get) Token: 0x06028F5F RID: 167775 RVA: 0x000D3B60 File Offset: 0x000D1D60
		// (set) Token: 0x06028F60 RID: 167776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F2")]
		public bool partnerReturnRoom
		{
			[Token(Token = "0x6028F5F")]
			[Address(RVA = "0x24544C0", Offset = "0x24530C0", VA = "0x1824544C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F60")]
			[Address(RVA = "0x2455890", Offset = "0x2454490", VA = "0x182455890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F3 RID: 24819
		// (get) Token: 0x06028F61 RID: 167777 RVA: 0x000D3B78 File Offset: 0x000D1D78
		// (set) Token: 0x06028F62 RID: 167778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F3")]
		public bool isTraining
		{
			[Token(Token = "0x6028F61")]
			[Address(RVA = "0x2453FD0", Offset = "0x2452BD0", VA = "0x182453FD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F62")]
			[Address(RVA = "0x2455470", Offset = "0x2454070", VA = "0x182455470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F4 RID: 24820
		// (get) Token: 0x06028F63 RID: 167779 RVA: 0x000D3B90 File Offset: 0x000D1D90
		// (set) Token: 0x06028F64 RID: 167780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F4")]
		public bool isReverse
		{
			[Token(Token = "0x6028F63")]
			[Address(RVA = "0x2453EB0", Offset = "0x2452AB0", VA = "0x182453EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F64")]
			[Address(RVA = "0x2455390", Offset = "0x2453F90", VA = "0x182455390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F5 RID: 24821
		// (get) Token: 0x06028F65 RID: 167781 RVA: 0x000D3BA8 File Offset: 0x000D1DA8
		// (set) Token: 0x06028F66 RID: 167782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F5")]
		public long finishTime
		{
			[Token(Token = "0x6028F65")]
			[Address(RVA = "0x2453AF0", Offset = "0x24526F0", VA = "0x182453AF0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6028F66")]
			[Address(RVA = "0x2454FA0", Offset = "0x2453BA0", VA = "0x182454FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F6 RID: 24822
		// (get) Token: 0x06028F67 RID: 167783 RVA: 0x000D3BC0 File Offset: 0x000D1DC0
		// (set) Token: 0x06028F68 RID: 167784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F6")]
		public bool hasNewPhoto
		{
			[Token(Token = "0x6028F67")]
			[Address(RVA = "0x2453C70", Offset = "0x2452870", VA = "0x182453C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F68")]
			[Address(RVA = "0x2455160", Offset = "0x2453D60", VA = "0x182455160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F7 RID: 24823
		// (get) Token: 0x06028F69 RID: 167785 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F6A RID: 167786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F7")]
		public string newPhotoId
		{
			[Token(Token = "0x6028F69")]
			[Address(RVA = "0x2454400", Offset = "0x2453000", VA = "0x182454400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F6A")]
			[Address(RVA = "0x24557A0", Offset = "0x24543A0", VA = "0x1824557A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x06028F6B RID: 167787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F6C RID: 167788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F8")]
		public AvatarInfo selfAvatarInfo
		{
			[Token(Token = "0x6028F6B")]
			[Address(RVA = "0x2454670", Offset = "0x2453270", VA = "0x182454670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F6C")]
			[Address(RVA = "0x2455980", Offset = "0x2454580", VA = "0x182455980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x06028F6D RID: 167789 RVA: 0x000D3BD8 File Offset: 0x000D1DD8
		// (set) Token: 0x06028F6E RID: 167790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060F9")]
		public int selfLevel
		{
			[Token(Token = "0x6028F6D")]
			[Address(RVA = "0x24546D0", Offset = "0x24532D0", VA = "0x1824546D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F6E")]
			[Address(RVA = "0x2455A00", Offset = "0x2454600", VA = "0x182455A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x06028F6F RID: 167791 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F70 RID: 167792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FA")]
		public string selfName
		{
			[Token(Token = "0x6028F6F")]
			[Address(RVA = "0x2454730", Offset = "0x2453330", VA = "0x182454730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F70")]
			[Address(RVA = "0x2455A70", Offset = "0x2454670", VA = "0x182455A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x06028F71 RID: 167793 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F72 RID: 167794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FB")]
		public string stageName
		{
			[Token(Token = "0x6028F71")]
			[Address(RVA = "0x2454AB0", Offset = "0x24536B0", VA = "0x182454AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F72")]
			[Address(RVA = "0x2455C60", Offset = "0x2454860", VA = "0x182455C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x06028F73 RID: 167795 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F74 RID: 167796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FC")]
		public string stageCode
		{
			[Token(Token = "0x6028F73")]
			[Address(RVA = "0x2454A50", Offset = "0x2453650", VA = "0x182454A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F74")]
			[Address(RVA = "0x2455BE0", Offset = "0x24547E0", VA = "0x182455BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FD RID: 24829
		// (get) Token: 0x06028F75 RID: 167797 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F76 RID: 167798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FD")]
		public string modeName
		{
			[Token(Token = "0x6028F75")]
			[Address(RVA = "0x2454340", Offset = "0x2452F40", VA = "0x182454340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F76")]
			[Address(RVA = "0x24556B0", Offset = "0x24542B0", VA = "0x1824556B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FE RID: 24830
		// (get) Token: 0x06028F77 RID: 167799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F78 RID: 167800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FE")]
		public string diffName
		{
			[Token(Token = "0x6028F77")]
			[Address(RVA = "0x24539D0", Offset = "0x24525D0", VA = "0x1824539D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F78")]
			[Address(RVA = "0x2454E40", Offset = "0x2453A40", VA = "0x182454E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170060FF RID: 24831
		// (get) Token: 0x06028F79 RID: 167801 RVA: 0x000D3BF0 File Offset: 0x000D1DF0
		// (set) Token: 0x06028F7A RID: 167802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060FF")]
		public ActMultiV3MapDiffType diffType
		{
			[Token(Token = "0x6028F79")]
			[Address(RVA = "0x2453A30", Offset = "0x2452630", VA = "0x182453A30")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapDiffType.NONE;
			}
			[Token(Token = "0x6028F7A")]
			[Address(RVA = "0x2454EC0", Offset = "0x2453AC0", VA = "0x182454EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006100 RID: 24832
		// (get) Token: 0x06028F7B RID: 167803 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F7C RID: 167804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006100")]
		public ActMultiV3DifficultyIconViewModel diffIconModel
		{
			[Token(Token = "0x6028F7B")]
			[Address(RVA = "0x2453970", Offset = "0x2452570", VA = "0x182453970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F7C")]
			[Address(RVA = "0x2454DC0", Offset = "0x24539C0", VA = "0x182454DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006101 RID: 24833
		// (get) Token: 0x06028F7D RID: 167805 RVA: 0x000D3C08 File Offset: 0x000D1E08
		// (set) Token: 0x06028F7E RID: 167806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006101")]
		public int completeStarCnt
		{
			[Token(Token = "0x6028F7D")]
			[Address(RVA = "0x24537F0", Offset = "0x24523F0", VA = "0x1824537F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F7E")]
			[Address(RVA = "0x2454C00", Offset = "0x2453800", VA = "0x182454C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006102 RID: 24834
		// (get) Token: 0x06028F7F RID: 167807 RVA: 0x000D3C20 File Offset: 0x000D1E20
		// (set) Token: 0x06028F80 RID: 167808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006102")]
		public ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028F7F")]
			[Address(RVA = "0x24543A0", Offset = "0x2452FA0", VA = "0x1824543A0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
			[Token(Token = "0x6028F80")]
			[Address(RVA = "0x2455730", Offset = "0x2454330", VA = "0x182455730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006103 RID: 24835
		// (get) Token: 0x06028F81 RID: 167809 RVA: 0x000D3C38 File Offset: 0x000D1E38
		// (set) Token: 0x06028F82 RID: 167810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006103")]
		public int milestoneAdd
		{
			[Token(Token = "0x6028F81")]
			[Address(RVA = "0x24540F0", Offset = "0x2452CF0", VA = "0x1824540F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F82")]
			[Address(RVA = "0x2455550", Offset = "0x2454150", VA = "0x182455550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006104 RID: 24836
		// (get) Token: 0x06028F83 RID: 167811 RVA: 0x000D3C50 File Offset: 0x000D1E50
		// (set) Token: 0x06028F84 RID: 167812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006104")]
		public int milestonePoint
		{
			[Token(Token = "0x6028F83")]
			[Address(RVA = "0x24542E0", Offset = "0x2452EE0", VA = "0x1824542E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F84")]
			[Address(RVA = "0x2455640", Offset = "0x2454240", VA = "0x182455640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006105 RID: 24837
		// (get) Token: 0x06028F85 RID: 167813 RVA: 0x000D3C68 File Offset: 0x000D1E68
		// (set) Token: 0x06028F86 RID: 167814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006105")]
		public int normalRewardCount
		{
			[Token(Token = "0x6028F85")]
			[Address(RVA = "0x2454460", Offset = "0x2453060", VA = "0x182454460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F86")]
			[Address(RVA = "0x2455820", Offset = "0x2454420", VA = "0x182455820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006106 RID: 24838
		// (get) Token: 0x06028F87 RID: 167815 RVA: 0x000D3C80 File Offset: 0x000D1E80
		// (set) Token: 0x06028F88 RID: 167816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006106")]
		public int dailyRewardCount
		{
			[Token(Token = "0x6028F87")]
			[Address(RVA = "0x2453910", Offset = "0x2452510", VA = "0x182453910")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F88")]
			[Address(RVA = "0x2454D50", Offset = "0x2453950", VA = "0x182454D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006107 RID: 24839
		// (get) Token: 0x06028F89 RID: 167817 RVA: 0x000D3C98 File Offset: 0x000D1E98
		// (set) Token: 0x06028F8A RID: 167818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006107")]
		public int dailyProgressCurr
		{
			[Token(Token = "0x6028F89")]
			[Address(RVA = "0x2453850", Offset = "0x2452450", VA = "0x182453850")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F8A")]
			[Address(RVA = "0x2454C70", Offset = "0x2453870", VA = "0x182454C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x06028F8B RID: 167819 RVA: 0x000D3CB0 File Offset: 0x000D1EB0
		// (set) Token: 0x06028F8C RID: 167820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006108")]
		public int dailyProgressMax
		{
			[Token(Token = "0x6028F8B")]
			[Address(RVA = "0x24538B0", Offset = "0x24524B0", VA = "0x1824538B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028F8C")]
			[Address(RVA = "0x2454CE0", Offset = "0x24538E0", VA = "0x182454CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x06028F8D RID: 167821 RVA: 0x000D3CC8 File Offset: 0x000D1EC8
		// (set) Token: 0x06028F8E RID: 167822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006109")]
		public bool showComplexReward
		{
			[Token(Token = "0x6028F8D")]
			[Address(RVA = "0x2454880", Offset = "0x2453480", VA = "0x182454880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F8E")]
			[Address(RVA = "0x2455AF0", Offset = "0x24546F0", VA = "0x182455AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x06028F8F RID: 167823 RVA: 0x000D3CE0 File Offset: 0x000D1EE0
		// (set) Token: 0x06028F90 RID: 167824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610A")]
		public bool gainDailyReward
		{
			[Token(Token = "0x6028F8F")]
			[Address(RVA = "0x2453B50", Offset = "0x2452750", VA = "0x182453B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F90")]
			[Address(RVA = "0x2455010", Offset = "0x2453C10", VA = "0x182455010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x06028F91 RID: 167825 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F92 RID: 167826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610B")]
		public string milestoneItemId
		{
			[Token(Token = "0x6028F91")]
			[Address(RVA = "0x2454150", Offset = "0x2452D50", VA = "0x182454150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F92")]
			[Address(RVA = "0x24555C0", Offset = "0x24541C0", VA = "0x1824555C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x06028F93 RID: 167827 RVA: 0x000D3CF8 File Offset: 0x000D1EF8
		// (set) Token: 0x06028F94 RID: 167828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610C")]
		public bool hasRequestReturnRoom
		{
			[Token(Token = "0x6028F93")]
			[Address(RVA = "0x2453D30", Offset = "0x2452930", VA = "0x182453D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F94")]
			[Address(RVA = "0x2455240", Offset = "0x2453E40", VA = "0x182455240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x06028F95 RID: 167829 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F96 RID: 167830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610D")]
		public string roomCloseToastStr
		{
			[Token(Token = "0x6028F95")]
			[Address(RVA = "0x2454610", Offset = "0x2453210", VA = "0x182454610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028F96")]
			[Address(RVA = "0x2455900", Offset = "0x2454500", VA = "0x182455900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x06028F97 RID: 167831 RVA: 0x000D3D10 File Offset: 0x000D1F10
		// (set) Token: 0x06028F98 RID: 167832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610E")]
		public bool isEarlyQuit
		{
			[Token(Token = "0x6028F97")]
			[Address(RVA = "0x2453D90", Offset = "0x2452990", VA = "0x182453D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F98")]
			[Address(RVA = "0x24552B0", Offset = "0x2453EB0", VA = "0x1824552B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x06028F99 RID: 167833 RVA: 0x000D3D28 File Offset: 0x000D1F28
		// (set) Token: 0x06028F9A RID: 167834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700610F")]
		public bool differentChannel
		{
			[Token(Token = "0x6028F99")]
			[Address(RVA = "0x2453A90", Offset = "0x2452690", VA = "0x182453A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F9A")]
			[Address(RVA = "0x2454F30", Offset = "0x2453B30", VA = "0x182454F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006110 RID: 24848
		// (get) Token: 0x06028F9B RID: 167835 RVA: 0x000D3D40 File Offset: 0x000D1F40
		// (set) Token: 0x06028F9C RID: 167836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006110")]
		public bool canReport
		{
			[Token(Token = "0x6028F9B")]
			[Address(RVA = "0x2453790", Offset = "0x2452390", VA = "0x182453790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F9C")]
			[Address(RVA = "0x2454B90", Offset = "0x2453790", VA = "0x182454B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006111 RID: 24849
		// (get) Token: 0x06028F9D RID: 167837 RVA: 0x000D3D58 File Offset: 0x000D1F58
		// (set) Token: 0x06028F9E RID: 167838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006111")]
		public bool hasReported
		{
			[Token(Token = "0x6028F9D")]
			[Address(RVA = "0x2453CD0", Offset = "0x24528D0", VA = "0x182453CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028F9E")]
			[Address(RVA = "0x24551D0", Offset = "0x2453DD0", VA = "0x1824551D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006112 RID: 24850
		// (get) Token: 0x06028F9F RID: 167839 RVA: 0x000D3D70 File Offset: 0x000D1F70
		[Token(Token = "0x17006112")]
		public bool isPartnerEarlyQuit
		{
			[Token(Token = "0x6028F9F")]
			[Address(RVA = "0x2453E50", Offset = "0x2452A50", VA = "0x182453E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006113 RID: 24851
		// (get) Token: 0x06028FA0 RID: 167840 RVA: 0x000D3D88 File Offset: 0x000D1F88
		[Token(Token = "0x17006113")]
		public bool isSelfEarlyQuit
		{
			[Token(Token = "0x6028FA0")]
			[Address(RVA = "0x2453F70", Offset = "0x2452B70", VA = "0x182453F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17006114 RID: 24852
		// (get) Token: 0x06028FA1 RID: 167841 RVA: 0x000D3DA0 File Offset: 0x000D1FA0
		[Token(Token = "0x17006114")]
		public CharUISkinStruct selfSecretarySKin
		{
			[Token(Token = "0x6028FA1")]
			[Address(RVA = "0x2454790", Offset = "0x2453390", VA = "0x182454790")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17006115 RID: 24853
		// (get) Token: 0x06028FA2 RID: 167842 RVA: 0x000D3DB8 File Offset: 0x000D1FB8
		[Token(Token = "0x17006115")]
		public CharUISkinStruct partnerSecretarySkin
		{
			[Token(Token = "0x6028FA2")]
			[Address(RVA = "0x2454520", Offset = "0x2453120", VA = "0x182454520")]
			get
			{
				return default(CharUISkinStruct);
			}
		}

		// Token: 0x17006116 RID: 24854
		// (get) Token: 0x06028FA3 RID: 167843 RVA: 0x000D3DD0 File Offset: 0x000D1FD0
		[Token(Token = "0x17006116")]
		public int milestonePointBefore
		{
			[Token(Token = "0x6028FA3")]
			[Address(RVA = "0x24541B0", Offset = "0x2452DB0", VA = "0x1824541B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17006117 RID: 24855
		// (get) Token: 0x06028FA4 RID: 167844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006117")]
		public ActMultiV3BattleFinishMapModel mapModel
		{
			[Token(Token = "0x6028FA4")]
			[Address(RVA = "0x2454090", Offset = "0x2452C90", VA = "0x182454090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x06028FA5 RID: 167845 RVA: 0x000D3DE8 File Offset: 0x000D1FE8
		[Token(Token = "0x17006118")]
		public bool showRewardPanel
		{
			[Token(Token = "0x6028FA5")]
			[Address(RVA = "0x24548E0", Offset = "0x24534E0", VA = "0x1824548E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06028FA6 RID: 167846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FA6")]
		[Address(RVA = "0x2452070", Offset = "0x2450C70", VA = "0x182452070")]
		public void LoadData(ActMultiV3BattleFinishViewModel.Param param)
		{
		}

		// Token: 0x06028FA7 RID: 167847 RVA: 0x000D3E00 File Offset: 0x000D2000
		[Token(Token = "0x6028FA7")]
		[Address(RVA = "0x2451CC0", Offset = "0x24508C0", VA = "0x182451CC0")]
		public ReportPlayerPanelInputParam GenReportPanelInputParam(bool show)
		{
			return default(ReportPlayerPanelInputParam);
		}

		// Token: 0x06028FA8 RID: 167848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FA8")]
		[Address(RVA = "0x2453240", Offset = "0x2451E40", VA = "0x182453240")]
		public void OnReportSuc()
		{
		}

		// Token: 0x06028FA9 RID: 167849 RVA: 0x000D3E18 File Offset: 0x000D2018
		[Token(Token = "0x6028FA9")]
		[Address(RVA = "0x2451BC0", Offset = "0x24507C0", VA = "0x182451BC0")]
		public CharWordShowType FindCharWordType()
		{
			return CharWordShowType.HOME_SHOW;
		}

		// Token: 0x06028FAA RID: 167850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FAA")]
		[Address(RVA = "0x24532A0", Offset = "0x2451EA0", VA = "0x1824532A0")]
		public void UpdateGoLikeStatus()
		{
		}

		// Token: 0x06028FAB RID: 167851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FAB")]
		[Address(RVA = "0x2453440", Offset = "0x2452040", VA = "0x182453440")]
		public void UpdateRoomStatus()
		{
		}

		// Token: 0x06028FAC RID: 167852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028FAC")]
		[Address(RVA = "0x24519E0", Offset = "0x24505E0", VA = "0x1824519E0")]
		public ActMultiV3NameCardParam CreateNameCardParam(bool isSelf)
		{
			return null;
		}

		// Token: 0x06028FAD RID: 167853 RVA: 0x000D3E30 File Offset: 0x000D2030
		[Token(Token = "0x6028FAD")]
		[Address(RVA = "0x2451790", Offset = "0x2450390", VA = "0x182451790")]
		public ActMultiV3BattleFinishMilestoneInfo CalcMilestoneInfo(int currVal)
		{
			return default(ActMultiV3BattleFinishMilestoneInfo);
		}

		// Token: 0x06028FAE RID: 167854 RVA: 0x000D3E48 File Offset: 0x000D2048
		[Token(Token = "0x6028FAE")]
		[Address(RVA = "0x24535E0", Offset = "0x24521E0", VA = "0x1824535E0")]
		private ActMultiV3BattleFinishCompleteInfoType _CalcCompleteInfoType(BattleFinishRspData battleFinishRspData)
		{
			return ActMultiV3BattleFinishCompleteInfoType.NONE;
		}

		// Token: 0x06028FAF RID: 167855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FAF")]
		[Address(RVA = "0x24536D0", Offset = "0x24522D0", VA = "0x1824536D0")]
		public ActMultiV3BattleFinishViewModel()
		{
		}

		// Token: 0x0403A75B RID: 239451
		[Token(Token = "0x403A75B")]
		[FieldOffset(Offset = "0x10")]
		private ActMultiV3BattleFinishMapModel m_mapModel;

		// Token: 0x0403A75C RID: 239452
		[Token(Token = "0x403A75C")]
		[FieldOffset(Offset = "0x18")]
		private ActMultiV3Data m_actData;

		// Token: 0x0403A75D RID: 239453
		[Token(Token = "0x403A75D")]
		[FieldOffset(Offset = "0x20")]
		private MultiplayerInputPlayerInfo m_selfPlayerInfo;

		// Token: 0x0403A75E RID: 239454
		[Token(Token = "0x403A75E")]
		[FieldOffset(Offset = "0x28")]
		private MultiplayerInputPlayerInfo m_partnerPlayerInfo;

		// Token: 0x0403A75F RID: 239455
		[Token(Token = "0x403A75F")]
		[FieldOffset(Offset = "0x30")]
		private bool m_partnerEarlyQuit;

		// Token: 0x0403A760 RID: 239456
		[Token(Token = "0x403A760")]
		[FieldOffset(Offset = "0x31")]
		private bool m_selfEarlyQuit;

		// Token: 0x0403A788 RID: 239496
		[Token(Token = "0x403A788")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadFriendData;

		// Token: 0x0403A789 RID: 239497
		[Token(Token = "0x403A789")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_squadFriendData;

		// Token: 0x0403A78A RID: 239498
		[Token(Token = "0x403A78A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMatch;

		// Token: 0x0403A78B RID: 239499
		[Token(Token = "0x403A78B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isMatch;

		// Token: 0x0403A78C RID: 239500
		[Token(Token = "0x403A78C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0403A78D RID: 239501
		[Token(Token = "0x403A78D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isValid;

		// Token: 0x0403A78E RID: 239502
		[Token(Token = "0x403A78E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403A78F RID: 239503
		[Token(Token = "0x403A78F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403A790 RID: 239504
		[Token(Token = "0x403A790")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isRoomClose;

		// Token: 0x0403A791 RID: 239505
		[Token(Token = "0x403A791")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isRoomClose;

		// Token: 0x0403A792 RID: 239506
		[Token(Token = "0x403A792")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_hasGivenLike;

		// Token: 0x0403A793 RID: 239507
		[Token(Token = "0x403A793")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_hasGivenLike;

		// Token: 0x0403A794 RID: 239508
		[Token(Token = "0x403A794")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_hasGotLike;

		// Token: 0x0403A795 RID: 239509
		[Token(Token = "0x403A795")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_hasGotLike;

		// Token: 0x0403A796 RID: 239510
		[Token(Token = "0x403A796")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_partnerReturnRoom;

		// Token: 0x0403A797 RID: 239511
		[Token(Token = "0x403A797")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_partnerReturnRoom;

		// Token: 0x0403A798 RID: 239512
		[Token(Token = "0x403A798")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isTraining;

		// Token: 0x0403A799 RID: 239513
		[Token(Token = "0x403A799")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_isTraining;

		// Token: 0x0403A79A RID: 239514
		[Token(Token = "0x403A79A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isReverse;

		// Token: 0x0403A79B RID: 239515
		[Token(Token = "0x403A79B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_isReverse;

		// Token: 0x0403A79C RID: 239516
		[Token(Token = "0x403A79C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_finishTime;

		// Token: 0x0403A79D RID: 239517
		[Token(Token = "0x403A79D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_finishTime;

		// Token: 0x0403A79E RID: 239518
		[Token(Token = "0x403A79E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_hasNewPhoto;

		// Token: 0x0403A79F RID: 239519
		[Token(Token = "0x403A79F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_hasNewPhoto;

		// Token: 0x0403A7A0 RID: 239520
		[Token(Token = "0x403A7A0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_newPhotoId;

		// Token: 0x0403A7A1 RID: 239521
		[Token(Token = "0x403A7A1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_newPhotoId;

		// Token: 0x0403A7A2 RID: 239522
		[Token(Token = "0x403A7A2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_selfAvatarInfo;

		// Token: 0x0403A7A3 RID: 239523
		[Token(Token = "0x403A7A3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_selfAvatarInfo;

		// Token: 0x0403A7A4 RID: 239524
		[Token(Token = "0x403A7A4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_selfLevel;

		// Token: 0x0403A7A5 RID: 239525
		[Token(Token = "0x403A7A5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_selfLevel;

		// Token: 0x0403A7A6 RID: 239526
		[Token(Token = "0x403A7A6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_selfName;

		// Token: 0x0403A7A7 RID: 239527
		[Token(Token = "0x403A7A7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_selfName;

		// Token: 0x0403A7A8 RID: 239528
		[Token(Token = "0x403A7A8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_stageName;

		// Token: 0x0403A7A9 RID: 239529
		[Token(Token = "0x403A7A9")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_stageName;

		// Token: 0x0403A7AA RID: 239530
		[Token(Token = "0x403A7AA")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_stageCode;

		// Token: 0x0403A7AB RID: 239531
		[Token(Token = "0x403A7AB")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_set_stageCode;

		// Token: 0x0403A7AC RID: 239532
		[Token(Token = "0x403A7AC")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_modeName;

		// Token: 0x0403A7AD RID: 239533
		[Token(Token = "0x403A7AD")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_set_modeName;

		// Token: 0x0403A7AE RID: 239534
		[Token(Token = "0x403A7AE")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_diffName;

		// Token: 0x0403A7AF RID: 239535
		[Token(Token = "0x403A7AF")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_set_diffName;

		// Token: 0x0403A7B0 RID: 239536
		[Token(Token = "0x403A7B0")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_diffType;

		// Token: 0x0403A7B1 RID: 239537
		[Token(Token = "0x403A7B1")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_set_diffType;

		// Token: 0x0403A7B2 RID: 239538
		[Token(Token = "0x403A7B2")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_diffIconModel;

		// Token: 0x0403A7B3 RID: 239539
		[Token(Token = "0x403A7B3")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_set_diffIconModel;

		// Token: 0x0403A7B4 RID: 239540
		[Token(Token = "0x403A7B4")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_completeStarCnt;

		// Token: 0x0403A7B5 RID: 239541
		[Token(Token = "0x403A7B5")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_set_completeStarCnt;

		// Token: 0x0403A7B6 RID: 239542
		[Token(Token = "0x403A7B6")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A7B7 RID: 239543
		[Token(Token = "0x403A7B7")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x0403A7B8 RID: 239544
		[Token(Token = "0x403A7B8")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_milestoneAdd;

		// Token: 0x0403A7B9 RID: 239545
		[Token(Token = "0x403A7B9")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_set_milestoneAdd;

		// Token: 0x0403A7BA RID: 239546
		[Token(Token = "0x403A7BA")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_milestonePoint;

		// Token: 0x0403A7BB RID: 239547
		[Token(Token = "0x403A7BB")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_set_milestonePoint;

		// Token: 0x0403A7BC RID: 239548
		[Token(Token = "0x403A7BC")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_normalRewardCount;

		// Token: 0x0403A7BD RID: 239549
		[Token(Token = "0x403A7BD")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_set_normalRewardCount;

		// Token: 0x0403A7BE RID: 239550
		[Token(Token = "0x403A7BE")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_dailyRewardCount;

		// Token: 0x0403A7BF RID: 239551
		[Token(Token = "0x403A7BF")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_set_dailyRewardCount;

		// Token: 0x0403A7C0 RID: 239552
		[Token(Token = "0x403A7C0")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_dailyProgressCurr;

		// Token: 0x0403A7C1 RID: 239553
		[Token(Token = "0x403A7C1")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_set_dailyProgressCurr;

		// Token: 0x0403A7C2 RID: 239554
		[Token(Token = "0x403A7C2")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_dailyProgressMax;

		// Token: 0x0403A7C3 RID: 239555
		[Token(Token = "0x403A7C3")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_set_dailyProgressMax;

		// Token: 0x0403A7C4 RID: 239556
		[Token(Token = "0x403A7C4")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_showComplexReward;

		// Token: 0x0403A7C5 RID: 239557
		[Token(Token = "0x403A7C5")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_set_showComplexReward;

		// Token: 0x0403A7C6 RID: 239558
		[Token(Token = "0x403A7C6")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_gainDailyReward;

		// Token: 0x0403A7C7 RID: 239559
		[Token(Token = "0x403A7C7")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_set_gainDailyReward;

		// Token: 0x0403A7C8 RID: 239560
		[Token(Token = "0x403A7C8")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_milestoneItemId;

		// Token: 0x0403A7C9 RID: 239561
		[Token(Token = "0x403A7C9")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_set_milestoneItemId;

		// Token: 0x0403A7CA RID: 239562
		[Token(Token = "0x403A7CA")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_hasRequestReturnRoom;

		// Token: 0x0403A7CB RID: 239563
		[Token(Token = "0x403A7CB")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_set_hasRequestReturnRoom;

		// Token: 0x0403A7CC RID: 239564
		[Token(Token = "0x403A7CC")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_get_roomCloseToastStr;

		// Token: 0x0403A7CD RID: 239565
		[Token(Token = "0x403A7CD")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_set_roomCloseToastStr;

		// Token: 0x0403A7CE RID: 239566
		[Token(Token = "0x403A7CE")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_isEarlyQuit;

		// Token: 0x0403A7CF RID: 239567
		[Token(Token = "0x403A7CF")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_set_isEarlyQuit;

		// Token: 0x0403A7D0 RID: 239568
		[Token(Token = "0x403A7D0")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_get_differentChannel;

		// Token: 0x0403A7D1 RID: 239569
		[Token(Token = "0x403A7D1")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_set_differentChannel;

		// Token: 0x0403A7D2 RID: 239570
		[Token(Token = "0x403A7D2")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_canReport;

		// Token: 0x0403A7D3 RID: 239571
		[Token(Token = "0x403A7D3")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_set_canReport;

		// Token: 0x0403A7D4 RID: 239572
		[Token(Token = "0x403A7D4")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_hasReported;

		// Token: 0x0403A7D5 RID: 239573
		[Token(Token = "0x403A7D5")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_set_hasReported;

		// Token: 0x0403A7D6 RID: 239574
		[Token(Token = "0x403A7D6")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_isPartnerEarlyQuit;

		// Token: 0x0403A7D7 RID: 239575
		[Token(Token = "0x403A7D7")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_get_isSelfEarlyQuit;

		// Token: 0x0403A7D8 RID: 239576
		[Token(Token = "0x403A7D8")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_selfSecretarySKin;

		// Token: 0x0403A7D9 RID: 239577
		[Token(Token = "0x403A7D9")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_partnerSecretarySkin;

		// Token: 0x0403A7DA RID: 239578
		[Token(Token = "0x403A7DA")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_get_milestonePointBefore;

		// Token: 0x0403A7DB RID: 239579
		[Token(Token = "0x403A7DB")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_get_mapModel;

		// Token: 0x0403A7DC RID: 239580
		[Token(Token = "0x403A7DC")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_get_showRewardPanel;

		// Token: 0x0403A7DD RID: 239581
		[Token(Token = "0x403A7DD")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A7DE RID: 239582
		[Token(Token = "0x403A7DE")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_GenReportPanelInputParam;

		// Token: 0x0403A7DF RID: 239583
		[Token(Token = "0x403A7DF")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_OnReportSuc;

		// Token: 0x0403A7E0 RID: 239584
		[Token(Token = "0x403A7E0")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_FindCharWordType;

		// Token: 0x0403A7E1 RID: 239585
		[Token(Token = "0x403A7E1")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_UpdateGoLikeStatus;

		// Token: 0x0403A7E2 RID: 239586
		[Token(Token = "0x403A7E2")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_UpdateRoomStatus;

		// Token: 0x0403A7E3 RID: 239587
		[Token(Token = "0x403A7E3")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_CreateNameCardParam;

		// Token: 0x0403A7E4 RID: 239588
		[Token(Token = "0x403A7E4")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_CalcMilestoneInfo;

		// Token: 0x0403A7E5 RID: 239589
		[Token(Token = "0x403A7E5")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__CalcCompleteInfoType;

		// Token: 0x0403A7E6 RID: 239590
		[Token(Token = "0x403A7E6")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200709D RID: 28829
		[Token(Token = "0x200709D")]
		public class Param
		{
			// Token: 0x06028FB0 RID: 167856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028FB0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403A7E7 RID: 239591
			[Token(Token = "0x403A7E7")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403A7E8 RID: 239592
			[Token(Token = "0x403A7E8")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x0403A7E9 RID: 239593
			[Token(Token = "0x403A7E9")]
			[FieldOffset(Offset = "0x20")]
			public bool isTraining;

			// Token: 0x0403A7EA RID: 239594
			[Token(Token = "0x403A7EA")]
			[FieldOffset(Offset = "0x28")]
			public BattleFinishRspData rspData;

			// Token: 0x0403A7EB RID: 239595
			[Token(Token = "0x403A7EB")]
			[FieldOffset(Offset = "0x30")]
			public MultiplayerInput multiplayerInput;
		}
	}
}
