using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D5A RID: 15706
	[Token(Token = "0x2003D5A")]
	public class TemplateShopGroupLoopAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x06018765 RID: 100197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018765")]
		[Address(RVA = "0x10F3B90", Offset = "0x10F2790", VA = "0x1810F3B90")]
		public void RebuildList()
		{
		}

		// Token: 0x06018766 RID: 100198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018766")]
		[Address(RVA = "0x10F3960", Offset = "0x10F2560", VA = "0x1810F3960", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x06018767 RID: 100199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018767")]
		[Address(RVA = "0x10F3CB0", Offset = "0x10F28B0", VA = "0x1810F3CB0")]
		public TemplateShopGroupLoopAdapter()
		{
		}

		// Token: 0x0401DF3F RID: 122687
		[Token(Token = "0x401DF3F")]
		[FieldOffset(Offset = "0x18")]
		public List<TemplateShopGroupViewModel> viewModelList;

		// Token: 0x0401DF40 RID: 122688
		[Token(Token = "0x401DF40")]
		[FieldOffset(Offset = "0x20")]
		public TemplateShopResHolder resHolder;

		// Token: 0x0401DF41 RID: 122689
		[Token(Token = "0x401DF41")]
		[FieldOffset(Offset = "0x28")]
		public TemplateShopLoopGroupView groupView;

		// Token: 0x0401DF42 RID: 122690
		[Token(Token = "0x401DF42")]
		[FieldOffset(Offset = "0x30")]
		public int constraintCount;

		// Token: 0x0401DF43 RID: 122691
		[Token(Token = "0x401DF43")]
		[FieldOffset(Offset = "0x38")]
		public AsyncGameObjectLoader loader;

		// Token: 0x0401DF44 RID: 122692
		[Token(Token = "0x401DF44")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 cellSize;

		// Token: 0x0401DF45 RID: 122693
		[Token(Token = "0x401DF45")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 spaceing;

		// Token: 0x0401DF46 RID: 122694
		[Token(Token = "0x401DF46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RebuildList;

		// Token: 0x0401DF47 RID: 122695
		[Token(Token = "0x401DF47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

		// Token: 0x0401DF48 RID: 122696
		[Token(Token = "0x401DF48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
