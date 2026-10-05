using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B1A RID: 19226
	[Token(Token = "0x2004B1A")]
	public class HomeMailArchiveStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601CE9F RID: 118431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CE9F")]
		[Address(RVA = "0x1658080", Offset = "0x1656C80", VA = "0x181658080")]
		public HomeMailArchiveStateBean()
		{
		}

		// Token: 0x04025F00 RID: 155392
		[Token(Token = "0x4025F00")]
		[FieldOffset(Offset = "0x10")]
		public HomeMailArchiveViewModel viewModel;

		// Token: 0x04025F01 RID: 155393
		[Token(Token = "0x4025F01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
