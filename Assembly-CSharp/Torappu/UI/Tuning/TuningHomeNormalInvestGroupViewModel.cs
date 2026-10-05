using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CB1 RID: 15537
	[Token(Token = "0x2003CB1")]
	public class TuningHomeNormalInvestGroupViewModel : IHotfixable
	{
		// Token: 0x060183D5 RID: 99285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D5")]
		[Address(RVA = "0x10BE460", Offset = "0x10BD060", VA = "0x1810BE460")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060183D6 RID: 99286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183D6")]
		[Address(RVA = "0x10BE870", Offset = "0x10BD470", VA = "0x1810BE870")]
		public TuningHomeNormalInvestGroupViewModel()
		{
		}

		// Token: 0x0401D8E6 RID: 121062
		[Token(Token = "0x401D8E6")]
		[FieldOffset(Offset = "0x10")]
		public List<TuningHomeNormalInvestViewModel> investModelList;

		// Token: 0x0401D8E7 RID: 121063
		[Token(Token = "0x401D8E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D8E8 RID: 121064
		[Token(Token = "0x401D8E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
