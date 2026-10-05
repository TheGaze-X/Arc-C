using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005341 RID: 21313
	[Token(Token = "0x2005341")]
	public abstract class RoguelikeMenuObject<TModel> : RoguelikeMenuObject where TModel : RoguelikeMenuCompViewModel, new()
	{
		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x0601F6EA RID: 128746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049B4")]
		public sealed override Type viewModelType
		{
			[Token(Token = "0x601F6EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F6EB RID: 128747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6EB")]
		public sealed override void DoRender(RoguelikeMenuCompViewModel viewModel)
		{
		}

		// Token: 0x0601F6EC RID: 128748
		[Token(Token = "0x601F6EC")]
		public abstract void Render(TModel viewModel);

		// Token: 0x0601F6ED RID: 128749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6ED")]
		protected RoguelikeMenuObject()
		{
		}

		// Token: 0x0402A49D RID: 173213
		[Token(Token = "0x402A49D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewModelType;

		// Token: 0x0402A49E RID: 173214
		[Token(Token = "0x402A49E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402A49F RID: 173215
		[Token(Token = "0x402A49F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
