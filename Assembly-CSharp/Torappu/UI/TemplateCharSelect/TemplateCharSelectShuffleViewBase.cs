using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE8 RID: 23528
	[Token(Token = "0x2005BE8")]
	public abstract class TemplateCharSelectShuffleViewBase<ModelType> : TemplateCharSelectShuffleView where ModelType : TemplateCharSelectShuffleViewModel, new()
	{
		// Token: 0x060221C8 RID: 139720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60221C8")]
		public ModelType GetSubModel()
		{
			return null;
		}

		// Token: 0x060221C9 RID: 139721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60221C9")]
		public override TemplateCharSelectShuffleViewModelCreator GetModelCreator()
		{
			return null;
		}

		// Token: 0x060221CA RID: 139722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221CA")]
		protected TemplateCharSelectShuffleViewBase()
		{
		}

		// Token: 0x0402EC7C RID: 191612
		[Token(Token = "0x402EC7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSubModel;

		// Token: 0x0402EC7D RID: 191613
		[Token(Token = "0x402EC7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelCreator;

		// Token: 0x0402EC7E RID: 191614
		[Token(Token = "0x402EC7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
