using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A33 RID: 10803
	[Token(Token = "0x2002A33")]
	public class DouququMoneyManager : IHotfixable
	{
		// Token: 0x1700276D RID: 10093
		// (get) Token: 0x06011EDB RID: 73435 RVA: 0x0006DAB8 File Offset: 0x0006BCB8
		// (set) Token: 0x06011EDC RID: 73436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700276D")]
		public long currentMoney
		{
			[Token(Token = "0x6011EDB")]
			[Address(RVA = "0x9C3D40", Offset = "0x9C2940", VA = "0x1809C3D40")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6011EDC")]
			[Address(RVA = "0x9C4090", Offset = "0x9C2C90", VA = "0x1809C4090")]
			private set
			{
			}
		}

		// Token: 0x1700276E RID: 10094
		// (get) Token: 0x06011EDD RID: 73437 RVA: 0x0006DAD0 File Offset: 0x0006BCD0
		[Token(Token = "0x1700276E")]
		public bool isMoneyFull
		{
			[Token(Token = "0x6011EDD")]
			[Address(RVA = "0x9C3E00", Offset = "0x9C2A00", VA = "0x1809C3E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x06011EDE RID: 73438 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		// (set) Token: 0x06011EDF RID: 73439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700276F")]
		public long betMoney
		{
			[Token(Token = "0x6011EDE")]
			[Address(RVA = "0x9C3C80", Offset = "0x9C2880", VA = "0x1809C3C80")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6011EDF")]
			[Address(RVA = "0x9C3FD0", Offset = "0x9C2BD0", VA = "0x1809C3FD0")]
			private set
			{
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x06011EE0 RID: 73440 RVA: 0x0006DB00 File Offset: 0x0006BD00
		// (set) Token: 0x06011EE1 RID: 73441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002770")]
		public long rewardMoney
		{
			[Token(Token = "0x6011EE0")]
			[Address(RVA = "0x9C3F10", Offset = "0x9C2B10", VA = "0x1809C3F10")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6011EE1")]
			[Address(RVA = "0x9C4150", Offset = "0x9C2D50", VA = "0x1809C4150")]
			private set
			{
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06011EE2 RID: 73442 RVA: 0x0006DB18 File Offset: 0x0006BD18
		[Token(Token = "0x17002771")]
		public int lastBetCnt
		{
			[Token(Token = "0x6011EE2")]
			[Address(RVA = "0x9C3EB0", Offset = "0x9C2AB0", VA = "0x1809C3EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06011EE3 RID: 73443 RVA: 0x0006DB30 File Offset: 0x0006BD30
		[Token(Token = "0x17002772")]
		public Choice currentChoice
		{
			[Token(Token = "0x6011EE3")]
			[Address(RVA = "0x9C3CE0", Offset = "0x9C28E0", VA = "0x1809C3CE0")]
			get
			{
				return Choice.LEFT;
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06011EE4 RID: 73444 RVA: 0x0006DB48 File Offset: 0x0006BD48
		[Token(Token = "0x17002773")]
		public Selection currentSelection
		{
			[Token(Token = "0x6011EE4")]
			[Address(RVA = "0x9C3DA0", Offset = "0x9C29A0", VA = "0x1809C3DA0")]
			get
			{
				return Selection.CHOICE_1;
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06011EE5 RID: 73445 RVA: 0x0006DB60 File Offset: 0x0006BD60
		[Token(Token = "0x17002774")]
		public bool win
		{
			[Token(Token = "0x6011EE5")]
			[Address(RVA = "0x9C3F70", Offset = "0x9C2B70", VA = "0x1809C3F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011EE6 RID: 73446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EE6")]
		[Address(RVA = "0x9C31A0", Offset = "0x9C1DA0", VA = "0x1809C31A0")]
		public void Init(GameModeFactory.DouququGameMode gameMode)
		{
		}

		// Token: 0x06011EE7 RID: 73447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EE7")]
		[Address(RVA = "0x9C36F0", Offset = "0x9C22F0", VA = "0x1809C36F0")]
		public void OnGameOver()
		{
		}

		// Token: 0x06011EE8 RID: 73448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EE8")]
		[Address(RVA = "0x9C3670", Offset = "0x9C2270", VA = "0x1809C3670")]
		public void OnChooseStart(bool isLeft)
		{
		}

		// Token: 0x06011EE9 RID: 73449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EE9")]
		[Address(RVA = "0x9C32D0", Offset = "0x9C1ED0", VA = "0x1809C32D0")]
		public void OnBetPreStart(Selection selection)
		{
		}

		// Token: 0x06011EEA RID: 73450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EEA")]
		[Address(RVA = "0x9C3570", Offset = "0x9C2170", VA = "0x1809C3570")]
		public void OnBetStart()
		{
		}

		// Token: 0x06011EEB RID: 73451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EEB")]
		[Address(RVA = "0x9C3800", Offset = "0x9C2400", VA = "0x1809C3800")]
		public void OnRoundEnd(RoundResult result)
		{
		}

		// Token: 0x06011EEC RID: 73452 RVA: 0x0006DB78 File Offset: 0x0006BD78
		[Token(Token = "0x6011EEC")]
		[Address(RVA = "0x9C3100", Offset = "0x9C1D00", VA = "0x1809C3100")]
		public float GetOdds()
		{
			return 0f;
		}

		// Token: 0x06011EED RID: 73453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EED")]
		[Address(RVA = "0x9C3AD0", Offset = "0x9C26D0", VA = "0x1809C3AD0")]
		private void _LogRoundPlayerResult()
		{
		}

		// Token: 0x06011EEE RID: 73454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011EEE")]
		[Address(RVA = "0x9C3C20", Offset = "0x9C2820", VA = "0x1809C3C20")]
		public DouququMoneyManager()
		{
		}

		// Token: 0x04014360 RID: 82784
		[Token(Token = "0x4014360")]
		[FieldOffset(Offset = "0x10")]
		private long m_currentMoney;

		// Token: 0x04014361 RID: 82785
		[Token(Token = "0x4014361")]
		[FieldOffset(Offset = "0x18")]
		private long m_betMoney;

		// Token: 0x04014362 RID: 82786
		[Token(Token = "0x4014362")]
		[FieldOffset(Offset = "0x20")]
		private long m_rewardMoney;

		// Token: 0x04014363 RID: 82787
		[Token(Token = "0x4014363")]
		[FieldOffset(Offset = "0x28")]
		private int m_lastBetCnt;

		// Token: 0x04014364 RID: 82788
		[Token(Token = "0x4014364")]
		[FieldOffset(Offset = "0x2C")]
		private Choice m_currentChoice;

		// Token: 0x04014365 RID: 82789
		[Token(Token = "0x4014365")]
		[FieldOffset(Offset = "0x30")]
		private Selection m_currentSelection;

		// Token: 0x04014366 RID: 82790
		[Token(Token = "0x4014366")]
		[FieldOffset(Offset = "0x38")]
		private GameModeFactory.DouququGameMode m_gameMode;

		// Token: 0x04014367 RID: 82791
		[Token(Token = "0x4014367")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isWin;

		// Token: 0x04014368 RID: 82792
		[Token(Token = "0x4014368")]
		[FieldOffset(Offset = "0x48")]
		private long m_maxMoney;

		// Token: 0x04014369 RID: 82793
		[Token(Token = "0x4014369")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentMoney;

		// Token: 0x0401436A RID: 82794
		[Token(Token = "0x401436A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_currentMoney;

		// Token: 0x0401436B RID: 82795
		[Token(Token = "0x401436B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isMoneyFull;

		// Token: 0x0401436C RID: 82796
		[Token(Token = "0x401436C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_betMoney;

		// Token: 0x0401436D RID: 82797
		[Token(Token = "0x401436D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_betMoney;

		// Token: 0x0401436E RID: 82798
		[Token(Token = "0x401436E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rewardMoney;

		// Token: 0x0401436F RID: 82799
		[Token(Token = "0x401436F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_rewardMoney;

		// Token: 0x04014370 RID: 82800
		[Token(Token = "0x4014370")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_lastBetCnt;

		// Token: 0x04014371 RID: 82801
		[Token(Token = "0x4014371")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentChoice;

		// Token: 0x04014372 RID: 82802
		[Token(Token = "0x4014372")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_currentSelection;

		// Token: 0x04014373 RID: 82803
		[Token(Token = "0x4014373")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_win;

		// Token: 0x04014374 RID: 82804
		[Token(Token = "0x4014374")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014375 RID: 82805
		[Token(Token = "0x4014375")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x04014376 RID: 82806
		[Token(Token = "0x4014376")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnChooseStart;

		// Token: 0x04014377 RID: 82807
		[Token(Token = "0x4014377")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnBetPreStart;

		// Token: 0x04014378 RID: 82808
		[Token(Token = "0x4014378")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnBetStart;

		// Token: 0x04014379 RID: 82809
		[Token(Token = "0x4014379")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnRoundEnd;

		// Token: 0x0401437A RID: 82810
		[Token(Token = "0x401437A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetOdds;

		// Token: 0x0401437B RID: 82811
		[Token(Token = "0x401437B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LogRoundPlayerResult;

		// Token: 0x0401437C RID: 82812
		[Token(Token = "0x401437C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
