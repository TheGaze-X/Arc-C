using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002781 RID: 10113
	[Token(Token = "0x2002781")]
	public class AutoChessSettleDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x17002414 RID: 9236
		// (get) Token: 0x06010819 RID: 67609 RVA: 0x00064A88 File Offset: 0x00062C88
		// (set) Token: 0x0601081A RID: 67610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002414")]
		public AutoChessSettleDataModel.EndingStatus endingStatus
		{
			[Token(Token = "0x6010819")]
			[Address(RVA = "0x84E350", Offset = "0x84CF50", VA = "0x18084E350")]
			[CompilerGenerated]
			get
			{
				return AutoChessSettleDataModel.EndingStatus.NONE;
			}
			[Token(Token = "0x601081A")]
			[Address(RVA = "0x84E3B0", Offset = "0x84CFB0", VA = "0x18084E3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601081B RID: 67611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601081B")]
		[Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
		public void UpdateData(SettleData settleData)
		{
		}

		// Token: 0x0601081C RID: 67612 RVA: 0x00064AA0 File Offset: 0x00062CA0
		[Token(Token = "0x601081C")]
		[Address(RVA = "0x84E0D0", Offset = "0x84CCD0", VA = "0x18084E0D0")]
		private AutoChessSettleDataModel.EndingStatus _CalcEndingStatus(SettleData settleData)
		{
			return AutoChessSettleDataModel.EndingStatus.NONE;
		}

		// Token: 0x0601081D RID: 67613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601081D")]
		[Address(RVA = "0x84E200", Offset = "0x84CE00", VA = "0x18084E200")]
		public AutoChessSettleDataModel()
		{
		}

		// Token: 0x0401282A RID: 75818
		[Token(Token = "0x401282A")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessSettleBossModel normBossModel;

		// Token: 0x0401282B RID: 75819
		[Token(Token = "0x401282B")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessSettleBossModel hideBossModel;

		// Token: 0x0401282D RID: 75821
		[Token(Token = "0x401282D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endingStatus;

		// Token: 0x0401282E RID: 75822
		[Token(Token = "0x401282E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_endingStatus;

		// Token: 0x0401282F RID: 75823
		[Token(Token = "0x401282F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04012830 RID: 75824
		[Token(Token = "0x4012830")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcEndingStatus;

		// Token: 0x04012831 RID: 75825
		[Token(Token = "0x4012831")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002782 RID: 10114
		[Token(Token = "0x2002782")]
		public enum EndingStatus
		{
			// Token: 0x04012833 RID: 75827
			[Token(Token = "0x4012833")]
			NONE,
			// Token: 0x04012834 RID: 75828
			[Token(Token = "0x4012834")]
			NORM_BOSS_WIN,
			// Token: 0x04012835 RID: 75829
			[Token(Token = "0x4012835")]
			HIDE_BOSS_FAIL,
			// Token: 0x04012836 RID: 75830
			[Token(Token = "0x4012836")]
			HIDE_BOSS_WIN,
			// Token: 0x04012837 RID: 75831
			[Token(Token = "0x4012837")]
			GAME_OVER
		}
	}
}
