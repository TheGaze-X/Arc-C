using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E02 RID: 19970
	[Token(Token = "0x2004E02")]
	public abstract class NameCardV2BaseRemovableModuleView<T> : NameCardV2BaseRemovableModuleView where T : NameCardV2RemovableModuleBaseModel
	{
		// Token: 0x0601DD89 RID: 122249
		[Token(Token = "0x601DD89")]
		public abstract void OnModuleViewRendered(T model);

		// Token: 0x0601DD8A RID: 122250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8A")]
		public sealed override void RenderModuleView(NameCardV2ModuleBaseModel model)
		{
		}

		// Token: 0x0601DD8B RID: 122251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD8B")]
		protected NameCardV2BaseRemovableModuleView()
		{
		}

		// Token: 0x040278CC RID: 161996
		[Token(Token = "0x40278CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderModuleView;

		// Token: 0x040278CD RID: 161997
		[Token(Token = "0x40278CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
