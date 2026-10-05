using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D8E RID: 15758
	[Token(Token = "0x2003D8E")]
	public class TemplateMissionCommonRewardBasicItemView : AbstractTemplateMissionRewardItemView
	{
		// Token: 0x06018833 RID: 100403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018833")]
		[Address(RVA = "0x110F380", Offset = "0x110DF80", VA = "0x18110F380", Slot = "4")]
		public override void Render(AbstractTemplateMissionRewardItemViewModel viewModel)
		{
		}

		// Token: 0x06018834 RID: 100404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018834")]
		[Address(RVA = "0x110F600", Offset = "0x110E200", VA = "0x18110F600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018835 RID: 100405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018835")]
		[Address(RVA = "0x110F820", Offset = "0x110E420", VA = "0x18110F820")]
		private void _OnItemCardClicked(int unusedIndex)
		{
		}

		// Token: 0x06018836 RID: 100406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018836")]
		[Address(RVA = "0x110F900", Offset = "0x110E500", VA = "0x18110F900")]
		public TemplateMissionCommonRewardBasicItemView()
		{
		}

		// Token: 0x0401E0B5 RID: 123061
		[Token(Token = "0x401E0B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _itemCont;

		// Token: 0x0401E0B6 RID: 123062
		[Token(Token = "0x401E0B6")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isInited;

		// Token: 0x0401E0B7 RID: 123063
		[Token(Token = "0x401E0B7")]
		[FieldOffset(Offset = "0x30")]
		private UIItemCard m_itemCard;

		// Token: 0x0401E0B8 RID: 123064
		[Token(Token = "0x401E0B8")]
		[FieldOffset(Offset = "0x38")]
		private UIItemViewModel m_itemModel;

		// Token: 0x0401E0B9 RID: 123065
		[Token(Token = "0x401E0B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E0BA RID: 123066
		[Token(Token = "0x401E0BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E0BB RID: 123067
		[Token(Token = "0x401E0BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x0401E0BC RID: 123068
		[Token(Token = "0x401E0BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
