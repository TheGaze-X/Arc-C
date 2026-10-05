using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CA9 RID: 15529
	[Token(Token = "0x2003CA9")]
	public class TuningHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060183CB RID: 99275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183CB")]
		[Address(RVA = "0x10BF530", Offset = "0x10BE130", VA = "0x1810BF530")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060183CC RID: 99276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183CC")]
		[Address(RVA = "0x10BF5E0", Offset = "0x10BE1E0", VA = "0x1810BF5E0")]
		public TuningHomeStateBean()
		{
		}

		// Token: 0x0401D8C3 RID: 121027
		[Token(Token = "0x401D8C3")]
		[FieldOffset(Offset = "0x10")]
		public TuningHomeProperty property;

		// Token: 0x0401D8C4 RID: 121028
		[Token(Token = "0x401D8C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401D8C5 RID: 121029
		[Token(Token = "0x401D8C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
