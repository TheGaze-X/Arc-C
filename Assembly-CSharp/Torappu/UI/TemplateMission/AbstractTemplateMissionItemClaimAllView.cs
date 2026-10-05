using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D7A RID: 15738
	[Token(Token = "0x2003D7A")]
	public abstract class AbstractTemplateMissionItemClaimAllView : AbstractTemplateMissionItemBaseView
	{
		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x060187D5 RID: 100309 RVA: 0x0009A968 File Offset: 0x00098B68
		[Token(Token = "0x17003A73")]
		public TemplateMissionListItemViewType itemViewType
		{
			[Token(Token = "0x60187D5")]
			[Address(RVA = "0x1101040", Offset = "0x10FFC40", VA = "0x181101040")]
			get
			{
				return TemplateMissionListItemViewType.NORMAL_ITEM;
			}
		}

		// Token: 0x060187D6 RID: 100310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187D6")]
		[Address(RVA = "0x1100FA0", Offset = "0x10FFBA0", VA = "0x181100FA0")]
		protected AbstractTemplateMissionItemClaimAllView()
		{
		}

		// Token: 0x0401E024 RID: 122916
		[Token(Token = "0x401E024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViewType;

		// Token: 0x0401E025 RID: 122917
		[Token(Token = "0x401E025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
