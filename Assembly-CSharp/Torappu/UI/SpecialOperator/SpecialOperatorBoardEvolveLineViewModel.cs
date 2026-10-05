using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E92 RID: 16018
	[Token(Token = "0x2003E92")]
	public class SpecialOperatorBoardEvolveLineViewModel : ISpecialOperatorBoardEvolveItemViewModel, IHotfixable
	{
		// Token: 0x06018E05 RID: 101893 RVA: 0x0009C450 File Offset: 0x0009A650
		[Token(Token = "0x6018E05")]
		[Address(RVA = "0x1185F90", Offset = "0x1184B90", VA = "0x181185F90", Slot = "4")]
		public SpecialOperatorBoardEvolveItemType GetItemType()
		{
			return SpecialOperatorBoardEvolveItemType.LINE;
		}

		// Token: 0x06018E06 RID: 101894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E06")]
		[Address(RVA = "0x1185FF0", Offset = "0x1184BF0", VA = "0x181185FF0", Slot = "5")]
		public void RefreshData(PlayerCharacter playerChar)
		{
		}

		// Token: 0x06018E07 RID: 101895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E07")]
		[Address(RVA = "0x1186070", Offset = "0x1184C70", VA = "0x181186070")]
		public SpecialOperatorBoardEvolveLineViewModel()
		{
		}

		// Token: 0x0401EA5C RID: 125532
		[Token(Token = "0x401EA5C")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase evolvePhase;

		// Token: 0x0401EA5D RID: 125533
		[Token(Token = "0x401EA5D")]
		[FieldOffset(Offset = "0x14")]
		public int levelMax;

		// Token: 0x0401EA5E RID: 125534
		[Token(Token = "0x401EA5E")]
		[FieldOffset(Offset = "0x18")]
		public EvolvePhase currEvolvePhase;

		// Token: 0x0401EA5F RID: 125535
		[Token(Token = "0x401EA5F")]
		[FieldOffset(Offset = "0x1C")]
		public int currLevel;

		// Token: 0x0401EA60 RID: 125536
		[Token(Token = "0x401EA60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x0401EA61 RID: 125537
		[Token(Token = "0x401EA61")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0401EA62 RID: 125538
		[Token(Token = "0x401EA62")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
