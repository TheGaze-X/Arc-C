using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BDD RID: 23517
	[Token(Token = "0x2005BDD")]
	public abstract class TemplateCharSelectDetailViewBase<ModelType> : TemplateCharSelectDetailView where ModelType : TemplateCharSelectDetailViewModel, new()
	{
		// Token: 0x0602218E RID: 139662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602218E")]
		public override TemplateCharSelectDetailViewModelCreator GetModelCreator()
		{
			return null;
		}

		// Token: 0x0602218F RID: 139663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602218F")]
		public ModelType GetSubModel()
		{
			return null;
		}

		// Token: 0x06022190 RID: 139664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022190")]
		protected TemplateCharSelectDetailViewBase()
		{
		}

		// Token: 0x0402EC51 RID: 191569
		[Token(Token = "0x402EC51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelCreator;

		// Token: 0x0402EC52 RID: 191570
		[Token(Token = "0x402EC52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSubModel;

		// Token: 0x0402EC53 RID: 191571
		[Token(Token = "0x402EC53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
