using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005346 RID: 21318
	[Token(Token = "0x2005346")]
	public abstract class RoguelikeMenuWindow<TModel> : RoguelikeMenuWindow where TModel : RoguelikeMenuCompViewModel, new()
	{
		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x0601F702 RID: 128770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049B7")]
		public sealed override Type viewModelType
		{
			[Token(Token = "0x601F702")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F703 RID: 128771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F703")]
		public sealed override void DoRender(RoguelikeMenuCompViewModel viewModel)
		{
		}

		// Token: 0x0601F704 RID: 128772
		[Token(Token = "0x601F704")]
		public abstract void Render(TModel viewModel);

		// Token: 0x0601F705 RID: 128773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F705")]
		protected RoguelikeMenuWindow()
		{
		}

		// Token: 0x0402A4B3 RID: 173235
		[Token(Token = "0x402A4B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewModelType;

		// Token: 0x0402A4B4 RID: 173236
		[Token(Token = "0x402A4B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402A4B5 RID: 173237
		[Token(Token = "0x402A4B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
