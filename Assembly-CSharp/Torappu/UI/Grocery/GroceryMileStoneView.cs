using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D48 RID: 19784
	[Token(Token = "0x2004D48")]
	public class GroceryMileStoneView : DataBinder<GroceryMileStoneProperty>, IHotfixable
	{
		// Token: 0x0601D9B7 RID: 121271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9B7")]
		[Address(RVA = "0x1731BF0", Offset = "0x17307F0", VA = "0x181731BF0", Slot = "7")]
		public override void OnValueChanged(GroceryMileStoneProperty property)
		{
		}

		// Token: 0x0601D9B8 RID: 121272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9B8")]
		[Address(RVA = "0x1731B60", Offset = "0x1730760", VA = "0x181731B60")]
		public void OnGetAllClick()
		{
		}

		// Token: 0x0601D9B9 RID: 121273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9B9")]
		[Address(RVA = "0x17315D0", Offset = "0x17301D0", VA = "0x1817315D0")]
		public void FocusOnIdx(int targetIndex)
		{
		}

		// Token: 0x0601D9BA RID: 121274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9BA")]
		[Address(RVA = "0x1731F10", Offset = "0x1730B10", VA = "0x181731F10")]
		public GroceryMileStoneView()
		{
		}

		// Token: 0x040271B5 RID: 160181
		[Token(Token = "0x40271B5")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x040271B6 RID: 160182
		[Token(Token = "0x40271B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _buttonToggle;

		// Token: 0x040271B7 RID: 160183
		[Token(Token = "0x40271B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _claimAllButtonGraphic;

		// Token: 0x040271B8 RID: 160184
		[Token(Token = "0x40271B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _totalPointNumText;

		// Token: 0x040271B9 RID: 160185
		[Token(Token = "0x40271B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Furni Rewards")]
		private List<Text> _furniNameList;

		// Token: 0x040271BA RID: 160186
		[Token(Token = "0x40271BA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Furni Rewards")]
		private List<Text> _furniNeedPointList;

		// Token: 0x040271BB RID: 160187
		[Token(Token = "0x40271BB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GroceryMileStoneItemGridAdapter _adapter;

		// Token: 0x040271BC RID: 160188
		[Token(Token = "0x40271BC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LoopHorizontalScrollRect _content;

		// Token: 0x040271BD RID: 160189
		[Token(Token = "0x40271BD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x040271BE RID: 160190
		[Token(Token = "0x40271BE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x040271BF RID: 160191
		[Token(Token = "0x40271BF")]
		[FieldOffset(Offset = "0x68")]
		private UISwitchTween.TweenWrapper m_focusTween;

		// Token: 0x040271C0 RID: 160192
		[Token(Token = "0x40271C0")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040271C1 RID: 160193
		[Token(Token = "0x40271C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040271C2 RID: 160194
		[Token(Token = "0x40271C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGetAllClick;

		// Token: 0x040271C3 RID: 160195
		[Token(Token = "0x40271C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FocusOnIdx;

		// Token: 0x040271C4 RID: 160196
		[Token(Token = "0x40271C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
