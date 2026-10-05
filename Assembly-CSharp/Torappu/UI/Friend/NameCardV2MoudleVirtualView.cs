using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF9 RID: 19961
	[Token(Token = "0x2004DF9")]
	public abstract class NameCardV2MoudleVirtualView : UIRecycleLayoutAdapter.VirtualView<NameCardV2BaseModuleView>
	{
		// Token: 0x0601DD54 RID: 122196
		[Token(Token = "0x601DD54")]
		public abstract void RenderModuleView(NameCardV2ModuleBaseModel model);

		// Token: 0x0601DD55 RID: 122197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD55")]
		[Address(RVA = "0x1778E10", Offset = "0x1777A10", VA = "0x181778E10")]
		protected NameCardV2MoudleVirtualView()
		{
		}

		// Token: 0x0402787B RID: 161915
		[Token(Token = "0x402787B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
