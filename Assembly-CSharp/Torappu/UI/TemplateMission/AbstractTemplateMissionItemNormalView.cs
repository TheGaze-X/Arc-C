using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D7B RID: 15739
	[Token(Token = "0x2003D7B")]
	public abstract class AbstractTemplateMissionItemNormalView : AbstractTemplateMissionItemBaseView
	{
		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x060187D7 RID: 100311 RVA: 0x0009A980 File Offset: 0x00098B80
		[Token(Token = "0x17003A74")]
		public TemplateMissionListItemViewType itemViewType
		{
			[Token(Token = "0x60187D7")]
			[Address(RVA = "0x1101140", Offset = "0x10FFD40", VA = "0x181101140")]
			get
			{
				return TemplateMissionListItemViewType.NORMAL_ITEM;
			}
		}

		// Token: 0x060187D8 RID: 100312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187D8")]
		[Address(RVA = "0x11010A0", Offset = "0x10FFCA0", VA = "0x1811010A0")]
		protected AbstractTemplateMissionItemNormalView()
		{
		}

		// Token: 0x0401E026 RID: 122918
		[Token(Token = "0x401E026")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemViewType;

		// Token: 0x0401E027 RID: 122919
		[Token(Token = "0x401E027")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
