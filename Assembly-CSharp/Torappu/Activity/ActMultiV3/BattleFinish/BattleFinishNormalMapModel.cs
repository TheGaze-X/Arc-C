using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x020070A1 RID: 28833
	[Token(Token = "0x20070A1")]
	public class BattleFinishNormalMapModel : ActMultiV3BattleFinishMapModel
	{
		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x06028FC7 RID: 167879 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028FC8 RID: 167880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006121")]
		public string title
		{
			[Token(Token = "0x6028FC7")]
			[Address(RVA = "0x2473DE0", Offset = "0x24729E0", VA = "0x182473DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028FC8")]
			[Address(RVA = "0x2473FA0", Offset = "0x2472BA0", VA = "0x182473FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x06028FC9 RID: 167881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028FCA RID: 167882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006122")]
		public string desc
		{
			[Token(Token = "0x6028FC9")]
			[Address(RVA = "0x2473C00", Offset = "0x2472800", VA = "0x182473C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028FCA")]
			[Address(RVA = "0x2473E40", Offset = "0x2472A40", VA = "0x182473E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x06028FCB RID: 167883 RVA: 0x000D3ED8 File Offset: 0x000D20D8
		// (set) Token: 0x06028FCC RID: 167884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006123")]
		public bool hasStarPenalty
		{
			[Token(Token = "0x6028FCB")]
			[Address(RVA = "0x2473C60", Offset = "0x2472860", VA = "0x182473C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028FCC")]
			[Address(RVA = "0x2473EC0", Offset = "0x2472AC0", VA = "0x182473EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x06028FCD RID: 167885 RVA: 0x000D3EF0 File Offset: 0x000D20F0
		// (set) Token: 0x06028FCE RID: 167886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006124")]
		public bool isNewStar
		{
			[Token(Token = "0x6028FCD")]
			[Address(RVA = "0x2473CC0", Offset = "0x24728C0", VA = "0x182473CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028FCE")]
			[Address(RVA = "0x2473F30", Offset = "0x2472B30", VA = "0x182473F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006125 RID: 24869
		// (get) Token: 0x06028FCF RID: 167887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006125")]
		public List<BattleFinishTargetModel> targetList
		{
			[Token(Token = "0x6028FCF")]
			[Address(RVA = "0x2473D80", Offset = "0x2472980", VA = "0x182473D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006126 RID: 24870
		// (get) Token: 0x06028FD0 RID: 167888 RVA: 0x000D3F08 File Offset: 0x000D2108
		[Token(Token = "0x17006126")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028FD0")]
			[Address(RVA = "0x2473D20", Offset = "0x2472920", VA = "0x182473D20", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028FD1 RID: 167889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FD1")]
		[Address(RVA = "0x24736B0", Offset = "0x24722B0", VA = "0x1824736B0", Slot = "5")]
		public override void LoadData(ActMultiV3BattleFinishMapModel.Input input)
		{
		}

		// Token: 0x06028FD2 RID: 167890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FD2")]
		[Address(RVA = "0x2473B00", Offset = "0x2472700", VA = "0x182473B00")]
		public BattleFinishNormalMapModel()
		{
		}

		// Token: 0x0403A809 RID: 239625
		[Token(Token = "0x403A809")]
		[FieldOffset(Offset = "0x10")]
		private List<BattleFinishTargetModel> m_targetList;

		// Token: 0x0403A80E RID: 239630
		[Token(Token = "0x403A80E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_title;

		// Token: 0x0403A80F RID: 239631
		[Token(Token = "0x403A80F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_title;

		// Token: 0x0403A810 RID: 239632
		[Token(Token = "0x403A810")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0403A811 RID: 239633
		[Token(Token = "0x403A811")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0403A812 RID: 239634
		[Token(Token = "0x403A812")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hasStarPenalty;

		// Token: 0x0403A813 RID: 239635
		[Token(Token = "0x403A813")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_hasStarPenalty;

		// Token: 0x0403A814 RID: 239636
		[Token(Token = "0x403A814")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isNewStar;

		// Token: 0x0403A815 RID: 239637
		[Token(Token = "0x403A815")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isNewStar;

		// Token: 0x0403A816 RID: 239638
		[Token(Token = "0x403A816")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_targetList;

		// Token: 0x0403A817 RID: 239639
		[Token(Token = "0x403A817")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A818 RID: 239640
		[Token(Token = "0x403A818")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A819 RID: 239641
		[Token(Token = "0x403A819")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
