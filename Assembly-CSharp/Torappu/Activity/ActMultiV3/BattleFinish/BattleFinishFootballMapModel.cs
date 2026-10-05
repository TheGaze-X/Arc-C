using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x020070A2 RID: 28834
	[Token(Token = "0x20070A2")]
	public class BattleFinishFootballMapModel : ActMultiV3BattleFinishMapModel
	{
		// Token: 0x17006127 RID: 24871
		// (get) Token: 0x06028FD3 RID: 167891 RVA: 0x000D3F20 File Offset: 0x000D2120
		// (set) Token: 0x06028FD4 RID: 167892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006127")]
		public bool isNewGoal
		{
			[Token(Token = "0x6028FD3")]
			[Address(RVA = "0x24734A0", Offset = "0x24720A0", VA = "0x1824734A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028FD4")]
			[Address(RVA = "0x2473640", Offset = "0x2472240", VA = "0x182473640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006128 RID: 24872
		// (get) Token: 0x06028FD5 RID: 167893 RVA: 0x000D3F38 File Offset: 0x000D2138
		// (set) Token: 0x06028FD6 RID: 167894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006128")]
		public int goalMine
		{
			[Token(Token = "0x6028FD5")]
			[Address(RVA = "0x24733E0", Offset = "0x2471FE0", VA = "0x1824733E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028FD6")]
			[Address(RVA = "0x2473560", Offset = "0x2472160", VA = "0x182473560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17006129 RID: 24873
		// (get) Token: 0x06028FD7 RID: 167895 RVA: 0x000D3F50 File Offset: 0x000D2150
		// (set) Token: 0x06028FD8 RID: 167896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006129")]
		public int goalOther
		{
			[Token(Token = "0x6028FD7")]
			[Address(RVA = "0x2473440", Offset = "0x2472040", VA = "0x182473440")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028FD8")]
			[Address(RVA = "0x24735D0", Offset = "0x24721D0", VA = "0x1824735D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700612A RID: 24874
		// (get) Token: 0x06028FD9 RID: 167897 RVA: 0x000D3F68 File Offset: 0x000D2168
		[Token(Token = "0x1700612A")]
		public int goalDiff
		{
			[Token(Token = "0x6028FD9")]
			[Address(RVA = "0x2473240", Offset = "0x2471E40", VA = "0x182473240")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700612B RID: 24875
		// (get) Token: 0x06028FDA RID: 167898 RVA: 0x000D3F80 File Offset: 0x000D2180
		[Token(Token = "0x1700612B")]
		public override ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028FDA")]
			[Address(RVA = "0x2473500", Offset = "0x2472100", VA = "0x182473500", Slot = "4")]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
		}

		// Token: 0x06028FDB RID: 167899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FDB")]
		[Address(RVA = "0x2473010", Offset = "0x2471C10", VA = "0x182473010", Slot = "5")]
		public override void LoadData(ActMultiV3BattleFinishMapModel.Input input)
		{
		}

		// Token: 0x06028FDC RID: 167900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028FDC")]
		[Address(RVA = "0x24731A0", Offset = "0x2471DA0", VA = "0x1824731A0")]
		public BattleFinishFootballMapModel()
		{
		}

		// Token: 0x0403A81D RID: 239645
		[Token(Token = "0x403A81D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isNewGoal;

		// Token: 0x0403A81E RID: 239646
		[Token(Token = "0x403A81E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isNewGoal;

		// Token: 0x0403A81F RID: 239647
		[Token(Token = "0x403A81F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goalMine;

		// Token: 0x0403A820 RID: 239648
		[Token(Token = "0x403A820")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_goalMine;

		// Token: 0x0403A821 RID: 239649
		[Token(Token = "0x403A821")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_goalOther;

		// Token: 0x0403A822 RID: 239650
		[Token(Token = "0x403A822")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_goalOther;

		// Token: 0x0403A823 RID: 239651
		[Token(Token = "0x403A823")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_goalDiff;

		// Token: 0x0403A824 RID: 239652
		[Token(Token = "0x403A824")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x0403A825 RID: 239653
		[Token(Token = "0x403A825")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A826 RID: 239654
		[Token(Token = "0x403A826")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
