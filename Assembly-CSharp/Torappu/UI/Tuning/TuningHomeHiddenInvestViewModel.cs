using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CAF RID: 15535
	[Token(Token = "0x2003CAF")]
	public class TuningHomeHiddenInvestViewModel : TuningHomeInvestBaseViewModel, IHotfixable
	{
		// Token: 0x060183D2 RID: 99282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D2")]
		[Address(RVA = "0x10BBC20", Offset = "0x10BA820", VA = "0x1810BBC20")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060183D3 RID: 99283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D3")]
		[Address(RVA = "0x10BBF00", Offset = "0x10BAB00", VA = "0x1810BBF00")]
		public TuningHomeHiddenInvestViewModel()
		{
		}

		// Token: 0x0401D8E0 RID: 121056
		[Token(Token = "0x401D8E0")]
		[FieldOffset(Offset = "0x30")]
		public bool needShow;

		// Token: 0x0401D8E1 RID: 121057
		[Token(Token = "0x401D8E1")]
		[FieldOffset(Offset = "0x31")]
		public bool isComplete;

		// Token: 0x0401D8E2 RID: 121058
		[Token(Token = "0x401D8E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D8E3 RID: 121059
		[Token(Token = "0x401D8E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
