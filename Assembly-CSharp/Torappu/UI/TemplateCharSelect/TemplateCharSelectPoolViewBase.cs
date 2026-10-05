using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE3 RID: 23523
	[Token(Token = "0x2005BE3")]
	public abstract class TemplateCharSelectPoolViewBase<ModelType> : TemplateCharSelectPoolView where ModelType : TemplateCharSelectPoolViewModel, new()
	{
		// Token: 0x060221B0 RID: 139696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60221B0")]
		public override TemplateCharSelectPoolViewModelCreator GetModelCreator()
		{
			return null;
		}

		// Token: 0x060221B1 RID: 139697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221B1")]
		protected TemplateCharSelectPoolViewBase()
		{
		}

		// Token: 0x0402EC69 RID: 191593
		[Token(Token = "0x402EC69")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelCreator;

		// Token: 0x0402EC6A RID: 191594
		[Token(Token = "0x402EC6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
