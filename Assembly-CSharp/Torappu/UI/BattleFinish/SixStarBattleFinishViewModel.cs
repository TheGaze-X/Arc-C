using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006224 RID: 25124
	[Token(Token = "0x2006224")]
	public class SixStarBattleFinishViewModel : IHotfixable
	{
		// Token: 0x17005584 RID: 21892
		// (get) Token: 0x060243F7 RID: 148471 RVA: 0x000C38B8 File Offset: 0x000C1AB8
		// (set) Token: 0x060243F8 RID: 148472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005584")]
		public int runeRankBeforeBattle
		{
			[Token(Token = "0x60243F7")]
			[Address(RVA = "0x1F1D290", Offset = "0x1F1BE90", VA = "0x181F1D290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60243F8")]
			[Address(RVA = "0x1F1D560", Offset = "0x1F1C160", VA = "0x181F1D560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x060243F9 RID: 148473 RVA: 0x000C38D0 File Offset: 0x000C1AD0
		// (set) Token: 0x060243FA RID: 148474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005585")]
		public int runeRankAfterBattle
		{
			[Token(Token = "0x60243F9")]
			[Address(RVA = "0x1F1D230", Offset = "0x1F1BE30", VA = "0x181F1D230")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60243FA")]
			[Address(RVA = "0x1F1D4F0", Offset = "0x1F1C0F0", VA = "0x181F1D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x060243FB RID: 148475 RVA: 0x000C38E8 File Offset: 0x000C1AE8
		[Token(Token = "0x17005586")]
		public int totalScoreBeforeBattle
		{
			[Token(Token = "0x60243FB")]
			[Address(RVA = "0x1F1D480", Offset = "0x1F1C080", VA = "0x181F1D480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x060243FC RID: 148476 RVA: 0x000C3900 File Offset: 0x000C1B00
		[Token(Token = "0x17005587")]
		public int totalScoreAfterBattle
		{
			[Token(Token = "0x60243FC")]
			[Address(RVA = "0x1F1D410", Offset = "0x1F1C010", VA = "0x181F1D410")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x060243FD RID: 148477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005588")]
		public string stageName
		{
			[Token(Token = "0x60243FD")]
			[Address(RVA = "0x1F1D380", Offset = "0x1F1BF80", VA = "0x181F1D380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x060243FE RID: 148478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005589")]
		public string stageCode
		{
			[Token(Token = "0x60243FE")]
			[Address(RVA = "0x1F1D2F0", Offset = "0x1F1BEF0", VA = "0x181F1D2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060243FF RID: 148479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243FF")]
		[Address(RVA = "0x1F1CBB0", Offset = "0x1F1B7B0", VA = "0x181F1CBB0")]
		public void LoadData(CommonFinishBattleResponse outputFinishResponse)
		{
		}

		// Token: 0x06024400 RID: 148480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024400")]
		[Address(RVA = "0x1F1CFE0", Offset = "0x1F1BBE0", VA = "0x181F1CFE0")]
		private void _UpdateRuneData(string stageId)
		{
		}

		// Token: 0x06024401 RID: 148481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024401")]
		[Address(RVA = "0x1F1CDC0", Offset = "0x1F1B9C0", VA = "0x181F1CDC0")]
		private void _UpdateBattleInfoViewModel(string stageId)
		{
		}

		// Token: 0x06024402 RID: 148482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024402")]
		[Address(RVA = "0x1F1D1D0", Offset = "0x1F1BDD0", VA = "0x181F1D1D0")]
		public SixStarBattleFinishViewModel()
		{
		}

		// Token: 0x04032671 RID: 206449
		[Token(Token = "0x4032671")]
		[FieldOffset(Offset = "0x10")]
		public BattleInfoViewModel battleInfoViewModel;

		// Token: 0x04032672 RID: 206450
		[Token(Token = "0x4032672")]
		[FieldOffset(Offset = "0x18")]
		private FinishBattleRespExtraSixStarData m_sixStarData;

		// Token: 0x04032675 RID: 206453
		[Token(Token = "0x4032675")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_runeRankBeforeBattle;

		// Token: 0x04032676 RID: 206454
		[Token(Token = "0x4032676")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_runeRankBeforeBattle;

		// Token: 0x04032677 RID: 206455
		[Token(Token = "0x4032677")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_runeRankAfterBattle;

		// Token: 0x04032678 RID: 206456
		[Token(Token = "0x4032678")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_runeRankAfterBattle;

		// Token: 0x04032679 RID: 206457
		[Token(Token = "0x4032679")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalScoreBeforeBattle;

		// Token: 0x0403267A RID: 206458
		[Token(Token = "0x403267A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_totalScoreAfterBattle;

		// Token: 0x0403267B RID: 206459
		[Token(Token = "0x403267B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_stageName;

		// Token: 0x0403267C RID: 206460
		[Token(Token = "0x403267C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_stageCode;

		// Token: 0x0403267D RID: 206461
		[Token(Token = "0x403267D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403267E RID: 206462
		[Token(Token = "0x403267E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRuneData;

		// Token: 0x0403267F RID: 206463
		[Token(Token = "0x403267F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateBattleInfoViewModel;

		// Token: 0x04032680 RID: 206464
		[Token(Token = "0x4032680")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
