using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063AB RID: 25515
	[Token(Token = "0x20063AB")]
	public class AutoChessStageInfoChessViewModel : IAutoChessCommonChessModel, IComparable, IHotfixable
	{
		// Token: 0x06024C80 RID: 150656 RVA: 0x000C5718 File Offset: 0x000C3918
		[Token(Token = "0x6024C80")]
		[Address(RVA = "0x1FA6E00", Offset = "0x1FA5A00", VA = "0x181FA6E00", Slot = "4")]
		public int GetLevel()
		{
			return 0;
		}

		// Token: 0x06024C81 RID: 150657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C81")]
		[Address(RVA = "0x1FA6D40", Offset = "0x1FA5940", VA = "0x181FA6D40", Slot = "5")]
		public string GetCharId()
		{
			return null;
		}

		// Token: 0x06024C82 RID: 150658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C82")]
		[Address(RVA = "0x1FA6E60", Offset = "0x1FA5A60", VA = "0x181FA6E60", Slot = "6")]
		public string GetTmplId()
		{
			return null;
		}

		// Token: 0x06024C83 RID: 150659 RVA: 0x000C5730 File Offset: 0x000C3930
		[Token(Token = "0x6024C83")]
		[Address(RVA = "0x1FA6DA0", Offset = "0x1FA59A0", VA = "0x181FA6DA0", Slot = "7")]
		public EvolvePhase GetGoldenEvolvePhase()
		{
			return EvolvePhase.PHASE_0;
		}

		// Token: 0x06024C84 RID: 150660 RVA: 0x000C5748 File Offset: 0x000C3948
		[Token(Token = "0x6024C84")]
		[Address(RVA = "0x1FA6C30", Offset = "0x1FA5830", VA = "0x181FA6C30", Slot = "8")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06024C85 RID: 150661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C85")]
		[Address(RVA = "0x1FA6EC0", Offset = "0x1FA5AC0", VA = "0x181FA6EC0")]
		public AutoChessStageInfoChessViewModel()
		{
		}

		// Token: 0x0403367C RID: 210556
		[Token(Token = "0x403367C")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x0403367D RID: 210557
		[Token(Token = "0x403367D")]
		[FieldOffset(Offset = "0x18")]
		public int chessLevel;

		// Token: 0x0403367E RID: 210558
		[Token(Token = "0x403367E")]
		[FieldOffset(Offset = "0x20")]
		public string charId;

		// Token: 0x0403367F RID: 210559
		[Token(Token = "0x403367F")]
		[FieldOffset(Offset = "0x28")]
		public string tmplId;

		// Token: 0x04033680 RID: 210560
		[Token(Token = "0x4033680")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04033681 RID: 210561
		[Token(Token = "0x4033681")]
		[FieldOffset(Offset = "0x34")]
		public EvolvePhase goldenEvolvePhase;

		// Token: 0x04033682 RID: 210562
		[Token(Token = "0x4033682")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetLevel;

		// Token: 0x04033683 RID: 210563
		[Token(Token = "0x4033683")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCharId;

		// Token: 0x04033684 RID: 210564
		[Token(Token = "0x4033684")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetTmplId;

		// Token: 0x04033685 RID: 210565
		[Token(Token = "0x4033685")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetGoldenEvolvePhase;

		// Token: 0x04033686 RID: 210566
		[Token(Token = "0x4033686")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04033687 RID: 210567
		[Token(Token = "0x4033687")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
