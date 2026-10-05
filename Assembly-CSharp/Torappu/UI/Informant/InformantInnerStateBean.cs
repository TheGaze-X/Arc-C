using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A11 RID: 18961
	[Token(Token = "0x2004A11")]
	public class InformantInnerStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C886 RID: 116870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C886")]
		[Address(RVA = "0x15F9E70", Offset = "0x15F8A70", VA = "0x1815F9E70")]
		public InformantInnerStateBean()
		{
		}

		// Token: 0x0402567F RID: 153215
		[Token(Token = "0x402567F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04025680 RID: 153216
		[Token(Token = "0x4025680")]
		[FieldOffset(Offset = "0x18")]
		public bool showStart;

		// Token: 0x04025681 RID: 153217
		[Token(Token = "0x4025681")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, UITabPager.TabPageViewModel> tabPageModels;

		// Token: 0x04025682 RID: 153218
		[Token(Token = "0x4025682")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
