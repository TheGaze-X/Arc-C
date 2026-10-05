using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052A0 RID: 21152
	[Token(Token = "0x20052A0")]
	public abstract class RoguelikeClassicEndingStatsViewComponent<TModel> : RoguelikeClassicEndingStatsViewComponentBase where TModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x0601F35B RID: 127835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004930")]
		public sealed override Type viewModelType
		{
			[Token(Token = "0x601F35B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F35C RID: 127836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F35C")]
		public sealed override void DoRender(UIPage page, RoguelikeClassicEndingStatsViewComponentModel viewModel)
		{
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x0601F35D RID: 127837 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F35E RID: 127838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004931")]
		private protected UIPage page
		{
			[Token(Token = "0x601F35D")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F35E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F35F RID: 127839
		[Token(Token = "0x601F35F")]
		protected abstract void Render(TModel viewModel);

		// Token: 0x0601F360 RID: 127840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F360")]
		protected RoguelikeClassicEndingStatsViewComponent()
		{
		}

		// Token: 0x04029E63 RID: 171619
		[Token(Token = "0x4029E63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewModelType;

		// Token: 0x04029E64 RID: 171620
		[Token(Token = "0x4029E64")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04029E65 RID: 171621
		[Token(Token = "0x4029E65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04029E66 RID: 171622
		[Token(Token = "0x4029E66")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04029E67 RID: 171623
		[Token(Token = "0x4029E67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
