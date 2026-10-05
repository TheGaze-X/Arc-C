using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B8C RID: 15244
	[Token(Token = "0x2003B8C")]
	public abstract class VoucherSkinBasePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x06017E40 RID: 97856
		[Token(Token = "0x1700390F")]
		public abstract string emptyText { [Token(Token = "0x6017E40")] get; }

		// Token: 0x17003910 RID: 14608
		// (get) Token: 0x06017E41 RID: 97857
		[Token(Token = "0x17003910")]
		public abstract ItemType voucherType { [Token(Token = "0x6017E41")] get; }

		// Token: 0x06017E42 RID: 97858
		[Token(Token = "0x6017E42")]
		public abstract void Render(VoucherSkinHomeViewModel model);

		// Token: 0x06017E43 RID: 97859
		[Token(Token = "0x6017E43")]
		public abstract string GetTitleText(VoucherSkinHomeViewModel model);

		// Token: 0x06017E44 RID: 97860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E44")]
		[Address(RVA = "0x10248D0", Offset = "0x10234D0", VA = "0x1810248D0")]
		public void OnClickSpreadRule()
		{
		}

		// Token: 0x06017E45 RID: 97861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E45")]
		[Address(RVA = "0x10249A0", Offset = "0x10235A0", VA = "0x1810249A0")]
		protected VoucherSkinBasePlugin()
		{
		}

		// Token: 0x0401CE18 RID: 118296
		[Token(Token = "0x401CE18")]
		[FieldOffset(Offset = "0x18")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401CE19 RID: 118297
		[Token(Token = "0x401CE19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickSpreadRule;

		// Token: 0x0401CE1A RID: 118298
		[Token(Token = "0x401CE1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
