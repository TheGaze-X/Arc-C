using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA4 RID: 24228
	[Token(Token = "0x2005EA4")]
	public class ItemRepoOptionalVoucherChooseItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023181 RID: 143745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023181")]
		[Address(RVA = "0x1D9ADF0", Offset = "0x1D999F0", VA = "0x181D9ADF0")]
		public void ApplyData(ItemRepoOptionalVoucherChooseItemViewModel chooseItemViewModel)
		{
		}

		// Token: 0x06023182 RID: 143746 RVA: 0x000BFEE0 File Offset: 0x000BE0E0
		[Token(Token = "0x6023182")]
		[Address(RVA = "0x1D9B2C0", Offset = "0x1D99EC0", VA = "0x181D9B2C0")]
		private bool ShowItemHasCount(ItemType itemType)
		{
			return default(bool);
		}

		// Token: 0x06023183 RID: 143747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023183")]
		[Address(RVA = "0x1D9B140", Offset = "0x1D99D40", VA = "0x181D9B140")]
		public void OnAddItemClick()
		{
		}

		// Token: 0x06023184 RID: 143748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023184")]
		[Address(RVA = "0x1D9B1C0", Offset = "0x1D99DC0", VA = "0x181D9B1C0")]
		public void OnDetailClick()
		{
		}

		// Token: 0x06023185 RID: 143749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023185")]
		[Address(RVA = "0x1D9B240", Offset = "0x1D99E40", VA = "0x181D9B240")]
		public void OnMinusItemClick()
		{
		}

		// Token: 0x06023186 RID: 143750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023186")]
		[Address(RVA = "0x1D9B340", Offset = "0x1D99F40", VA = "0x181D9B340")]
		public ItemRepoOptionalVoucherChooseItemView()
		{
		}

		// Token: 0x0403059E RID: 198046
		[Token(Token = "0x403059E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objSelectDec;

		// Token: 0x0403059F RID: 198047
		[Token(Token = "0x403059F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objSelectBoard;

		// Token: 0x040305A0 RID: 198048
		[Token(Token = "0x40305A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x040305A1 RID: 198049
		[Token(Token = "0x40305A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtItemName;

		// Token: 0x040305A2 RID: 198050
		[Token(Token = "0x40305A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtItemHasCount;

		// Token: 0x040305A3 RID: 198051
		[Token(Token = "0x40305A3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtPickCount;

		// Token: 0x040305A4 RID: 198052
		[Token(Token = "0x40305A4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objPerPickCount;

		// Token: 0x040305A5 RID: 198053
		[Token(Token = "0x40305A5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _txtPerPickCount;

		// Token: 0x040305A6 RID: 198054
		[Token(Token = "0x40305A6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objAddPart;

		// Token: 0x040305A7 RID: 198055
		[Token(Token = "0x40305A7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objMinusPart;

		// Token: 0x040305A8 RID: 198056
		[Token(Token = "0x40305A8")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public UIStringEvent onAddItemClickEvent;

		// Token: 0x040305A9 RID: 198057
		[Token(Token = "0x40305A9")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public UIStringEvent onDetailClickEvent;

		// Token: 0x040305AA RID: 198058
		[Token(Token = "0x40305AA")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UIStringEvent onMinusItemClickEvent;

		// Token: 0x040305AB RID: 198059
		[Token(Token = "0x40305AB")]
		[FieldOffset(Offset = "0x80")]
		private string m_cacheItemId;

		// Token: 0x040305AC RID: 198060
		[Token(Token = "0x40305AC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_chosing;

		// Token: 0x040305AD RID: 198061
		[Token(Token = "0x40305AD")]
		private const string PER_PICK_COUNT = "x{0}";

		// Token: 0x040305AE RID: 198062
		[Token(Token = "0x40305AE")]
		[FieldOffset(Offset = "0x8C")]
		private float ALPHA_ICON_UNSELECT;

		// Token: 0x040305AF RID: 198063
		[Token(Token = "0x40305AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040305B0 RID: 198064
		[Token(Token = "0x40305B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowItemHasCount;

		// Token: 0x040305B1 RID: 198065
		[Token(Token = "0x40305B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAddItemClick;

		// Token: 0x040305B2 RID: 198066
		[Token(Token = "0x40305B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x040305B3 RID: 198067
		[Token(Token = "0x40305B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMinusItemClick;

		// Token: 0x040305B4 RID: 198068
		[Token(Token = "0x40305B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
