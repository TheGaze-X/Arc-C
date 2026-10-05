using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CAD RID: 15533
	[Token(Token = "0x2003CAD")]
	public class TuningHomeMajorInvestViewModel : TuningHomeInvestBaseViewModel, IHotfixable
	{
		// Token: 0x060183D0 RID: 99280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D0")]
		[Address(RVA = "0x10BDFC0", Offset = "0x10BCBC0", VA = "0x1810BDFC0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060183D1 RID: 99281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D1")]
		[Address(RVA = "0x10BE3C0", Offset = "0x10BCFC0", VA = "0x1810BE3C0")]
		public TuningHomeMajorInvestViewModel()
		{
		}

		// Token: 0x0401D8D5 RID: 121045
		[Token(Token = "0x401D8D5")]
		[FieldOffset(Offset = "0x30")]
		public TuningHomeMajorInvestViewModel.Status status;

		// Token: 0x0401D8D6 RID: 121046
		[Token(Token = "0x401D8D6")]
		[FieldOffset(Offset = "0x34")]
		public int currIndex;

		// Token: 0x0401D8D7 RID: 121047
		[Token(Token = "0x401D8D7")]
		[FieldOffset(Offset = "0x38")]
		public int maxIndex;

		// Token: 0x0401D8D8 RID: 121048
		[Token(Token = "0x401D8D8")]
		[FieldOffset(Offset = "0x3C")]
		public int tokenCount;

		// Token: 0x0401D8D9 RID: 121049
		[Token(Token = "0x401D8D9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D8DA RID: 121050
		[Token(Token = "0x401D8DA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CAE RID: 15534
		[Token(Token = "0x2003CAE")]
		public enum Status
		{
			// Token: 0x0401D8DC RID: 121052
			[Token(Token = "0x401D8DC")]
			NOT_UNLOCKABLE,
			// Token: 0x0401D8DD RID: 121053
			[Token(Token = "0x401D8DD")]
			UNLOCKABLE,
			// Token: 0x0401D8DE RID: 121054
			[Token(Token = "0x401D8DE")]
			UNLOCKED,
			// Token: 0x0401D8DF RID: 121055
			[Token(Token = "0x401D8DF")]
			COMPLETE
		}
	}
}
