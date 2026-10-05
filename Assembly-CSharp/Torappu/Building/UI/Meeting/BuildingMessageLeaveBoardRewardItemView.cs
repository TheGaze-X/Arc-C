using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D25 RID: 7461
	[Token(Token = "0x2001D25")]
	public class BuildingMessageLeaveBoardRewardItemView : DataBinder<BuildingMessageLeaveBoardProperty>, IHotfixable
	{
		// Token: 0x0600B82E RID: 47150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B82E")]
		[Address(RVA = "0x335DE00", Offset = "0x335CA00", VA = "0x18335DE00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B82F")]
		[Address(RVA = "0x335D970", Offset = "0x335C570", VA = "0x18335D970", Slot = "7")]
		public override void OnValueChanged(BuildingMessageLeaveBoardProperty property)
		{
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B830")]
		[Address(RVA = "0x335DD30", Offset = "0x335C930", VA = "0x18335DD30")]
		public void ShowView()
		{
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B831")]
		[Address(RVA = "0x335D900", Offset = "0x335C500", VA = "0x18335D900")]
		public void HideView()
		{
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x000453D8 File Offset: 0x000435D8
		[Token(Token = "0x600B832")]
		[Address(RVA = "0x335DDA0", Offset = "0x335C9A0", VA = "0x18335DDA0")]
		private bool _GetCanGetReward()
		{
			return default(bool);
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B833")]
		[Address(RVA = "0x335DF60", Offset = "0x335CB60", VA = "0x18335DF60")]
		public BuildingMessageLeaveBoardRewardItemView()
		{
		}

		// Token: 0x0400B636 RID: 46646
		[Token(Token = "0x400B636")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRewardNum;

		// Token: 0x0400B637 RID: 46647
		[Token(Token = "0x400B637")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _btnGetReward;

		// Token: 0x0400B638 RID: 46648
		[Token(Token = "0x400B638")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x0400B639 RID: 46649
		[Token(Token = "0x400B639")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelCanGetRewardFx;

		// Token: 0x0400B63A RID: 46650
		[Token(Token = "0x400B63A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelGetReward;

		// Token: 0x0400B63B RID: 46651
		[Token(Token = "0x400B63B")]
		[FieldOffset(Offset = "0x48")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0400B63C RID: 46652
		[Token(Token = "0x400B63C")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isinited;

		// Token: 0x0400B63D RID: 46653
		[Token(Token = "0x400B63D")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCard;

		// Token: 0x0400B63E RID: 46654
		[Token(Token = "0x400B63E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B63F RID: 46655
		[Token(Token = "0x400B63F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B640 RID: 46656
		[Token(Token = "0x400B640")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowView;

		// Token: 0x0400B641 RID: 46657
		[Token(Token = "0x400B641")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideView;

		// Token: 0x0400B642 RID: 46658
		[Token(Token = "0x400B642")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCanGetReward;

		// Token: 0x0400B643 RID: 46659
		[Token(Token = "0x400B643")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
