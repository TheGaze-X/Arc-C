using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DFF RID: 19967
	[Token(Token = "0x2004DFF")]
	public abstract class NameCardV2BaseFixedModuleView<T> : NameCardV2BaseModuleView where T : NameCardV2ModuleBaseModel
	{
		// Token: 0x0601DD73 RID: 122227
		[Token(Token = "0x601DD73")]
		public abstract void OnModuleViewRendered(T model);

		// Token: 0x0601DD74 RID: 122228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD74")]
		public sealed override void RenderModuleView(NameCardV2ModuleBaseModel model)
		{
		}

		// Token: 0x0601DD75 RID: 122229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD75")]
		protected NameCardV2BaseFixedModuleView()
		{
		}

		// Token: 0x040278A5 RID: 161957
		[Token(Token = "0x40278A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderModuleView;

		// Token: 0x040278A6 RID: 161958
		[Token(Token = "0x40278A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
