using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054D3 RID: 21715
	[Token(Token = "0x20054D3")]
	public class RoguelikeGameBankViewModel : IHotfixable
	{
		// Token: 0x17004AC8 RID: 19144
		// (get) Token: 0x0601FF0F RID: 130831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AC8")]
		public string topicId
		{
			[Token(Token = "0x601FF0F")]
			[Address(RVA = "0x1A0EB50", Offset = "0x1A0D750", VA = "0x181A0EB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AC9 RID: 19145
		// (get) Token: 0x0601FF10 RID: 130832 RVA: 0x000B3CB8 File Offset: 0x000B1EB8
		[Token(Token = "0x17004AC9")]
		public int current
		{
			[Token(Token = "0x601FF10")]
			[Address(RVA = "0x1A0E9A0", Offset = "0x1A0D5A0", VA = "0x181A0E9A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004ACA RID: 19146
		// (get) Token: 0x0601FF11 RID: 130833 RVA: 0x000B3CD0 File Offset: 0x000B1ED0
		[Token(Token = "0x17004ACA")]
		public int withdrawCost
		{
			[Token(Token = "0x601FF11")]
			[Address(RVA = "0x1A0EC10", Offset = "0x1A0D810", VA = "0x181A0EC10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004ACB RID: 19147
		// (get) Token: 0x0601FF12 RID: 130834 RVA: 0x000B3CE8 File Offset: 0x000B1EE8
		[Token(Token = "0x17004ACB")]
		public int gold
		{
			[Token(Token = "0x601FF12")]
			[Address(RVA = "0x1A0EA10", Offset = "0x1A0D610", VA = "0x181A0EA10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004ACC RID: 19148
		// (get) Token: 0x0601FF13 RID: 130835 RVA: 0x000B3D00 File Offset: 0x000B1F00
		[Token(Token = "0x17004ACC")]
		public bool isFaulty
		{
			[Token(Token = "0x601FF13")]
			[Address(RVA = "0x1A0EAE0", Offset = "0x1A0D6E0", VA = "0x181A0EAE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004ACD RID: 19149
		// (get) Token: 0x0601FF14 RID: 130836 RVA: 0x000B3D18 File Offset: 0x000B1F18
		[Token(Token = "0x17004ACD")]
		public bool canWithdrawViewShow
		{
			[Token(Token = "0x601FF14")]
			[Address(RVA = "0x1A0E930", Offset = "0x1A0D530", VA = "0x181A0E930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004ACE RID: 19150
		// (get) Token: 0x0601FF15 RID: 130837 RVA: 0x000B3D30 File Offset: 0x000B1F30
		[Token(Token = "0x17004ACE")]
		public int hasWithdrawnCount
		{
			[Token(Token = "0x601FF15")]
			[Address(RVA = "0x1A0EA70", Offset = "0x1A0D670", VA = "0x181A0EA70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004ACF RID: 19151
		// (get) Token: 0x0601FF16 RID: 130838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ACF")]
		public string withdrawCostItemId
		{
			[Token(Token = "0x601FF16")]
			[Address(RVA = "0x1A0EBB0", Offset = "0x1A0D7B0", VA = "0x181A0EBB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AD0 RID: 19152
		// (get) Token: 0x0601FF17 RID: 130839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AD0")]
		public RoguelikeGameBankViewModel.BankWithdrawModelPlugin withdrawPlugin
		{
			[Token(Token = "0x601FF17")]
			[Address(RVA = "0x1A0ED00", Offset = "0x1A0D900", VA = "0x181A0ED00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AD1 RID: 19153
		// (get) Token: 0x0601FF18 RID: 130840 RVA: 0x000B3D48 File Offset: 0x000B1F48
		[Token(Token = "0x17004AD1")]
		public int withdrawLimit
		{
			[Token(Token = "0x601FF18")]
			[Address(RVA = "0x1A0EC80", Offset = "0x1A0D880", VA = "0x181A0EC80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601FF19 RID: 130841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF19")]
		[Address(RVA = "0x1A0E000", Offset = "0x1A0CC00", VA = "0x181A0E000")]
		public void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent.Bank bank)
		{
		}

		// Token: 0x0601FF1A RID: 130842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF1A")]
		[Address(RVA = "0x1A0DF80", Offset = "0x1A0CB80", VA = "0x181A0DF80")]
		public void InjectPlugin(RoguelikeGameBankViewModel.BankWithdrawModelPlugin plugin)
		{
		}

		// Token: 0x0601FF1B RID: 130843 RVA: 0x000B3D60 File Offset: 0x000B1F60
		[Token(Token = "0x601FF1B")]
		[Address(RVA = "0x1A0DE10", Offset = "0x1A0CA10", VA = "0x181A0DE10")]
		public RoguelikeGameBankViewModel.BankInvestStatus GetBankInvestStatus()
		{
			return RoguelikeGameBankViewModel.BankInvestStatus.INVEST_FAULTY;
		}

		// Token: 0x0601FF1C RID: 130844 RVA: 0x000B3D78 File Offset: 0x000B1F78
		[Token(Token = "0x601FF1C")]
		[Address(RVA = "0x1A0DBD0", Offset = "0x1A0C7D0", VA = "0x181A0DBD0")]
		public bool CheckCanWithdraw()
		{
			return default(bool);
		}

		// Token: 0x0601FF1D RID: 130845 RVA: 0x000B3D90 File Offset: 0x000B1F90
		[Token(Token = "0x601FF1D")]
		[Address(RVA = "0x1A0DCD0", Offset = "0x1A0C8D0", VA = "0x181A0DCD0")]
		public bool CheckWithdrawReachLimit(int hasWithdrawnCount)
		{
			return default(bool);
		}

		// Token: 0x0601FF1E RID: 130846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF1E")]
		[Address(RVA = "0x1A0E330", Offset = "0x1A0CF30", VA = "0x181A0E330")]
		public void WithdrawIncrementCurrent()
		{
		}

		// Token: 0x0601FF1F RID: 130847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF1F")]
		[Address(RVA = "0x1A0E2A0", Offset = "0x1A0CEA0", VA = "0x181A0E2A0")]
		public void WithdrawDecrementCurrent()
		{
		}

		// Token: 0x0601FF20 RID: 130848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF20")]
		[Address(RVA = "0x1A0E3C0", Offset = "0x1A0CFC0", VA = "0x181A0E3C0")]
		public void WithdrawMaxCurrent()
		{
		}

		// Token: 0x0601FF21 RID: 130849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF21")]
		[Address(RVA = "0x1A0E450", Offset = "0x1A0D050", VA = "0x181A0E450")]
		public void WithdrawMinCurrent()
		{
		}

		// Token: 0x0601FF22 RID: 130850 RVA: 0x000B3DA8 File Offset: 0x000B1FA8
		[Token(Token = "0x601FF22")]
		[Address(RVA = "0x1A0DEE0", Offset = "0x1A0CAE0", VA = "0x181A0DEE0")]
		public int GetWithdrawCount()
		{
			return 0;
		}

		// Token: 0x0601FF23 RID: 130851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF23")]
		[Address(RVA = "0x1A0E6C0", Offset = "0x1A0D2C0", VA = "0x181A0E6C0")]
		private void _LoadConstData()
		{
		}

		// Token: 0x0601FF24 RID: 130852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF24")]
		[Address(RVA = "0x1A0E7E0", Offset = "0x1A0D3E0", VA = "0x181A0E7E0")]
		private void _LoadPlugin()
		{
		}

		// Token: 0x0601FF25 RID: 130853 RVA: 0x000B3DC0 File Offset: 0x000B1FC0
		[Token(Token = "0x601FF25")]
		[Address(RVA = "0x1A0E4E0", Offset = "0x1A0D0E0", VA = "0x181A0E4E0")]
		private bool _HasNewBankReward()
		{
			return default(bool);
		}

		// Token: 0x0601FF26 RID: 130854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF26")]
		[Address(RVA = "0x1A0E8D0", Offset = "0x1A0D4D0", VA = "0x181A0E8D0")]
		public RoguelikeGameBankViewModel()
		{
		}

		// Token: 0x0402B177 RID: 176503
		[Token(Token = "0x402B177")]
		[FieldOffset(Offset = "0x10")]
		private PlayerRoguelikePendingEvent.ShopContent.Bank m_gameBankPlayerData;

		// Token: 0x0402B178 RID: 176504
		[Token(Token = "0x402B178")]
		[FieldOffset(Offset = "0x18")]
		private PlayerRoguelikeV2.OuterData.Bank m_topicBankPlayerData;

		// Token: 0x0402B179 RID: 176505
		[Token(Token = "0x402B179")]
		[FieldOffset(Offset = "0x20")]
		private int m_gameGold;

		// Token: 0x0402B17A RID: 176506
		[Token(Token = "0x402B17A")]
		[FieldOffset(Offset = "0x28")]
		private string m_topicId;

		// Token: 0x0402B17B RID: 176507
		[Token(Token = "0x402B17B")]
		[FieldOffset(Offset = "0x30")]
		private string m_withdrawCostId;

		// Token: 0x0402B17C RID: 176508
		[Token(Token = "0x402B17C")]
		[FieldOffset(Offset = "0x38")]
		private int m_withdrawTotalLimitCount;

		// Token: 0x0402B17D RID: 176509
		[Token(Token = "0x402B17D")]
		[FieldOffset(Offset = "0x3C")]
		private int m_singleWithdrawMaxCount;

		// Token: 0x0402B17E RID: 176510
		[Token(Token = "0x402B17E")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeGameBankViewModel.BankWithdrawModelPlugin m_withdrawPlugin;

		// Token: 0x0402B17F RID: 176511
		[Token(Token = "0x402B17F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402B180 RID: 176512
		[Token(Token = "0x402B180")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_current;

		// Token: 0x0402B181 RID: 176513
		[Token(Token = "0x402B181")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_withdrawCost;

		// Token: 0x0402B182 RID: 176514
		[Token(Token = "0x402B182")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_gold;

		// Token: 0x0402B183 RID: 176515
		[Token(Token = "0x402B183")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isFaulty;

		// Token: 0x0402B184 RID: 176516
		[Token(Token = "0x402B184")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_canWithdrawViewShow;

		// Token: 0x0402B185 RID: 176517
		[Token(Token = "0x402B185")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_hasWithdrawnCount;

		// Token: 0x0402B186 RID: 176518
		[Token(Token = "0x402B186")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_withdrawCostItemId;

		// Token: 0x0402B187 RID: 176519
		[Token(Token = "0x402B187")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_withdrawPlugin;

		// Token: 0x0402B188 RID: 176520
		[Token(Token = "0x402B188")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_withdrawLimit;

		// Token: 0x0402B189 RID: 176521
		[Token(Token = "0x402B189")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B18A RID: 176522
		[Token(Token = "0x402B18A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InjectPlugin;

		// Token: 0x0402B18B RID: 176523
		[Token(Token = "0x402B18B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetBankInvestStatus;

		// Token: 0x0402B18C RID: 176524
		[Token(Token = "0x402B18C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckCanWithdraw;

		// Token: 0x0402B18D RID: 176525
		[Token(Token = "0x402B18D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckWithdrawReachLimit;

		// Token: 0x0402B18E RID: 176526
		[Token(Token = "0x402B18E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_WithdrawIncrementCurrent;

		// Token: 0x0402B18F RID: 176527
		[Token(Token = "0x402B18F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_WithdrawDecrementCurrent;

		// Token: 0x0402B190 RID: 176528
		[Token(Token = "0x402B190")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_WithdrawMaxCurrent;

		// Token: 0x0402B191 RID: 176529
		[Token(Token = "0x402B191")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_WithdrawMinCurrent;

		// Token: 0x0402B192 RID: 176530
		[Token(Token = "0x402B192")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetWithdrawCount;

		// Token: 0x0402B193 RID: 176531
		[Token(Token = "0x402B193")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LoadConstData;

		// Token: 0x0402B194 RID: 176532
		[Token(Token = "0x402B194")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadPlugin;

		// Token: 0x0402B195 RID: 176533
		[Token(Token = "0x402B195")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__HasNewBankReward;

		// Token: 0x0402B196 RID: 176534
		[Token(Token = "0x402B196")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020054D4 RID: 21716
		[Token(Token = "0x20054D4")]
		public enum BankInvestStatus
		{
			// Token: 0x0402B198 RID: 176536
			[Token(Token = "0x402B198")]
			INVEST_FAULTY,
			// Token: 0x0402B199 RID: 176537
			[Token(Token = "0x402B199")]
			INVEST_SUC_WITH_NEW_REWARD,
			// Token: 0x0402B19A RID: 176538
			[Token(Token = "0x402B19A")]
			INVEST_SUC
		}

		// Token: 0x020054D5 RID: 21717
		[Token(Token = "0x20054D5")]
		public abstract class BankWithdrawModelPlugin : IHotfixable
		{
			// Token: 0x0601FF27 RID: 130855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF27")]
			[Address(RVA = "0x19FE9D0", Offset = "0x19FD5D0", VA = "0x1819FE9D0", Slot = "4")]
			public virtual void OnLoad()
			{
			}

			// Token: 0x0601FF28 RID: 130856
			[Token(Token = "0x601FF28")]
			public abstract bool CanWithdraw();

			// Token: 0x0601FF29 RID: 130857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF29")]
			[Address(RVA = "0x19FEDD0", Offset = "0x19FD9D0", VA = "0x1819FEDD0")]
			public void LoadPlugin(RoguelikeGameBankViewModel closure)
			{
			}

			// Token: 0x0601FF2A RID: 130858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF2A")]
			[Address(RVA = "0x19FEE70", Offset = "0x19FDA70", VA = "0x1819FEE70")]
			protected BankWithdrawModelPlugin()
			{
			}

			// Token: 0x0402B19B RID: 176539
			[Token(Token = "0x402B19B")]
			[FieldOffset(Offset = "0x10")]
			protected RoguelikeGameBankViewModel closure;

			// Token: 0x0402B19C RID: 176540
			[Token(Token = "0x402B19C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnLoad;

			// Token: 0x0402B19D RID: 176541
			[Token(Token = "0x402B19D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_LoadPlugin;

			// Token: 0x0402B19E RID: 176542
			[Token(Token = "0x402B19E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020054D6 RID: 21718
		[Token(Token = "0x20054D6")]
		private interface IWithdrawWithLimit
		{
			// Token: 0x0601FF2B RID: 130859
			[Token(Token = "0x601FF2B")]
			bool CheckWithdrawReachLimit(int hasWithdrawnCount);
		}

		// Token: 0x020054D7 RID: 21719
		[Token(Token = "0x20054D7")]
		private interface IMultipleWithdraw
		{
			// Token: 0x17004AD2 RID: 19154
			// (get) Token: 0x0601FF2C RID: 130860
			[Token(Token = "0x17004AD2")]
			int withdrawCount { [Token(Token = "0x601FF2C")] get; }

			// Token: 0x17004AD3 RID: 19155
			// (get) Token: 0x0601FF2D RID: 130861
			[Token(Token = "0x17004AD3")]
			int maxWithdrawCount { [Token(Token = "0x601FF2D")] get; }

			// Token: 0x0601FF2E RID: 130862
			[Token(Token = "0x601FF2E")]
			void IncreaseWithdrawCount();

			// Token: 0x0601FF2F RID: 130863
			[Token(Token = "0x601FF2F")]
			void DecreaseWithdrawCount();

			// Token: 0x0601FF30 RID: 130864
			[Token(Token = "0x601FF30")]
			void MaximizeWithdrawCount();

			// Token: 0x0601FF31 RID: 130865
			[Token(Token = "0x601FF31")]
			void MinimizeWithdrawCount();
		}

		// Token: 0x020054D8 RID: 21720
		[Token(Token = "0x20054D8")]
		public abstract class BankWithdrawModelForSimplePlugin : RoguelikeGameBankViewModel.BankWithdrawModelPlugin, RoguelikeGameBankViewModel.IWithdrawWithLimit
		{
			// Token: 0x17004AD4 RID: 19156
			// (get) Token: 0x0601FF32 RID: 130866 RVA: 0x000B3DD8 File Offset: 0x000B1FD8
			[Token(Token = "0x17004AD4")]
			public int targetAfterWithdraw
			{
				[Token(Token = "0x601FF32")]
				[Address(RVA = "0x19FECA0", Offset = "0x19FD8A0", VA = "0x1819FECA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17004AD5 RID: 19157
			// (get) Token: 0x0601FF33 RID: 130867
			[Token(Token = "0x17004AD5")]
			public abstract string withdrawTips { [Token(Token = "0x601FF33")] get; }

			// Token: 0x0601FF34 RID: 130868 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
			[Token(Token = "0x601FF34")]
			[Address(RVA = "0x19FEB90", Offset = "0x19FD790", VA = "0x1819FEB90", Slot = "5")]
			public sealed override bool CanWithdraw()
			{
				return default(bool);
			}

			// Token: 0x0601FF35 RID: 130869
			[Token(Token = "0x601FF35")]
			public abstract bool CheckWithdrawReachLimit(int hasWithdrawnCount);

			// Token: 0x0601FF36 RID: 130870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF36")]
			[Address(RVA = "0x19FEC00", Offset = "0x19FD800", VA = "0x1819FEC00")]
			protected BankWithdrawModelForSimplePlugin()
			{
			}

			// Token: 0x0402B19F RID: 176543
			[Token(Token = "0x402B19F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_targetAfterWithdraw;

			// Token: 0x0402B1A0 RID: 176544
			[Token(Token = "0x402B1A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanWithdraw;

			// Token: 0x0402B1A1 RID: 176545
			[Token(Token = "0x402B1A1")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020054D9 RID: 21721
		[Token(Token = "0x20054D9")]
		public abstract class BankWithdrawModelForConsumePlugin : RoguelikeGameBankViewModel.BankWithdrawModelPlugin, RoguelikeGameBankViewModel.IMultipleWithdraw
		{
			// Token: 0x0601FF37 RID: 130871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF37")]
			[Address(RVA = "0x19FE880", Offset = "0x19FD480", VA = "0x1819FE880", Slot = "4")]
			public override void OnLoad()
			{
			}

			// Token: 0x0601FF38 RID: 130872 RVA: 0x000B3E08 File Offset: 0x000B2008
			[Token(Token = "0x601FF38")]
			[Address(RVA = "0x19FE590", Offset = "0x19FD190", VA = "0x1819FE590", Slot = "5")]
			public override bool CanWithdraw()
			{
				return default(bool);
			}

			// Token: 0x17004AD6 RID: 19158
			// (get) Token: 0x0601FF39 RID: 130873 RVA: 0x000B3E20 File Offset: 0x000B2020
			[Token(Token = "0x17004AD6")]
			public int withdrawCount
			{
				[Token(Token = "0x601FF39")]
				[Address(RVA = "0x19FEB30", Offset = "0x19FD730", VA = "0x1819FEB30", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17004AD7 RID: 19159
			// (get) Token: 0x0601FF3A RID: 130874 RVA: 0x000B3E38 File Offset: 0x000B2038
			[Token(Token = "0x17004AD7")]
			public int maxWithdrawCount
			{
				[Token(Token = "0x601FF3A")]
				[Address(RVA = "0x19FEAD0", Offset = "0x19FD6D0", VA = "0x1819FEAD0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FF3B RID: 130875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF3B")]
			[Address(RVA = "0x19FE750", Offset = "0x19FD350", VA = "0x1819FE750", Slot = "8")]
			public void IncreaseWithdrawCount()
			{
			}

			// Token: 0x0601FF3C RID: 130876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF3C")]
			[Address(RVA = "0x19FE6E0", Offset = "0x19FD2E0", VA = "0x1819FE6E0", Slot = "9")]
			public void DecreaseWithdrawCount()
			{
			}

			// Token: 0x0601FF3D RID: 130877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF3D")]
			[Address(RVA = "0x19FE7C0", Offset = "0x19FD3C0", VA = "0x1819FE7C0", Slot = "10")]
			public void MaximizeWithdrawCount()
			{
			}

			// Token: 0x0601FF3E RID: 130878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF3E")]
			[Address(RVA = "0x19FE820", Offset = "0x19FD420", VA = "0x1819FE820", Slot = "11")]
			public void MinimizeWithdrawCount()
			{
			}

			// Token: 0x0601FF3F RID: 130879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF3F")]
			[Address(RVA = "0x19FEA30", Offset = "0x19FD630", VA = "0x1819FEA30")]
			protected BankWithdrawModelForConsumePlugin()
			{
			}

			// Token: 0x0601FF40 RID: 130880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FF40")]
			[Address(RVA = "0x19FE9D0", Offset = "0x19FD5D0", VA = "0x1819FE9D0")]
			private void <>xLuaBaseProxy_OnLoad()
			{
			}

			// Token: 0x0402B1A2 RID: 176546
			[Token(Token = "0x402B1A2")]
			[FieldOffset(Offset = "0x18")]
			private int m_currentWithdrawCount;

			// Token: 0x0402B1A3 RID: 176547
			[Token(Token = "0x402B1A3")]
			[FieldOffset(Offset = "0x1C")]
			private int m_minWithdrawCount;

			// Token: 0x0402B1A4 RID: 176548
			[Token(Token = "0x402B1A4")]
			[FieldOffset(Offset = "0x20")]
			private int m_maxWithdrawCount;

			// Token: 0x0402B1A5 RID: 176549
			[Token(Token = "0x402B1A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnLoad;

			// Token: 0x0402B1A6 RID: 176550
			[Token(Token = "0x402B1A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanWithdraw;

			// Token: 0x0402B1A7 RID: 176551
			[Token(Token = "0x402B1A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_withdrawCount;

			// Token: 0x0402B1A8 RID: 176552
			[Token(Token = "0x402B1A8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_maxWithdrawCount;

			// Token: 0x0402B1A9 RID: 176553
			[Token(Token = "0x402B1A9")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IncreaseWithdrawCount;

			// Token: 0x0402B1AA RID: 176554
			[Token(Token = "0x402B1AA")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_DecreaseWithdrawCount;

			// Token: 0x0402B1AB RID: 176555
			[Token(Token = "0x402B1AB")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_MaximizeWithdrawCount;

			// Token: 0x0402B1AC RID: 176556
			[Token(Token = "0x402B1AC")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_MinimizeWithdrawCount;

			// Token: 0x0402B1AD RID: 176557
			[Token(Token = "0x402B1AD")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
