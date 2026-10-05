using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D36 RID: 15670
	[Token(Token = "0x2003D36")]
	public abstract class TemplateTrapView : DataBinder<TemplateTrapProperty>, IHotfixable
	{
		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x060186AB RID: 100011
		[Token(Token = "0x17003A65")]
		public abstract TemplateTrapState.TemplateTrapSaveType saveType { [Token(Token = "0x60186AB")] get; }

		// Token: 0x060186AC RID: 100012
		[Token(Token = "0x60186AC")]
		public abstract Tween StartFadeInTween();

		// Token: 0x060186AD RID: 100013
		[Token(Token = "0x60186AD")]
		public abstract void SetAction(TemplateTrapState.ActionConfig action);

		// Token: 0x060186AE RID: 100014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186AE")]
		[Address(RVA = "0x10FFA10", Offset = "0x10FE610", VA = "0x1810FFA10")]
		protected TemplateTrapView()
		{
		}

		// Token: 0x0401DDED RID: 122349
		[Token(Token = "0x401DDED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
