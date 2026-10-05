using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052C3 RID: 21187
	[Token(Token = "0x20052C3")]
	public abstract class RoguelikeEndingController<TModel> : RoguelikeEndingControllerBase where TModel : RoguelikeEndingViewModel
	{
		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x0601F3F4 RID: 127988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004945")]
		protected TModel endingViewModel
		{
			[Token(Token = "0x601F3F4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F3F5 RID: 127989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F5")]
		protected sealed override void SetEndingViewModel(RoguelikeEndingViewModel viewModel)
		{
		}

		// Token: 0x0601F3F6 RID: 127990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3F6")]
		protected RoguelikeEndingController()
		{
		}

		// Token: 0x04029F86 RID: 171910
		[Token(Token = "0x4029F86")]
		[FieldOffset(Offset = "0x0")]
		private TModel m_viewModel;

		// Token: 0x04029F87 RID: 171911
		[Token(Token = "0x4029F87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endingViewModel;

		// Token: 0x04029F88 RID: 171912
		[Token(Token = "0x4029F88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetEndingViewModel;

		// Token: 0x04029F89 RID: 171913
		[Token(Token = "0x4029F89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
