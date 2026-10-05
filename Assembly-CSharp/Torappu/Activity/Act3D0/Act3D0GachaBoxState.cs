using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F0 RID: 29680
	[Token(Token = "0x20073F0")]
	public class Act3D0GachaBoxState : PopupFadeState
	{
		// Token: 0x06029EC4 RID: 171716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EC4")]
		[Address(RVA = "0x258C9C0", Offset = "0x258B5C0", VA = "0x18258C9C0")]
		public void OnEnable()
		{
		}

		// Token: 0x06029EC5 RID: 171717 RVA: 0x000D6FC8 File Offset: 0x000D51C8
		[Token(Token = "0x6029EC5")]
		[Address(RVA = "0x258CF90", Offset = "0x258BB90", VA = "0x18258CF90")]
		private bool _InitIfNot()
		{
			return default(bool);
		}

		// Token: 0x06029EC6 RID: 171718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EC6")]
		[Address(RVA = "0x258C800", Offset = "0x258B400", VA = "0x18258C800", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029EC7 RID: 171719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EC7")]
		[Address(RVA = "0x258C940", Offset = "0x258B540", VA = "0x18258C940")]
		public void OnClick(string m_boxId)
		{
		}

		// Token: 0x06029EC8 RID: 171720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EC8")]
		[Address(RVA = "0x258C860", Offset = "0x258B460", VA = "0x18258C860")]
		public void OnClickTence(string m_boxId)
		{
		}

		// Token: 0x06029EC9 RID: 171721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EC9")]
		[Address(RVA = "0x258D510", Offset = "0x258C110", VA = "0x18258D510")]
		private void _SendGachaRequest(string boxId, int count)
		{
		}

		// Token: 0x06029ECA RID: 171722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ECA")]
		[Address(RVA = "0x258D2B0", Offset = "0x258BEB0", VA = "0x18258D2B0")]
		private void _SendGachaInfoRequest()
		{
		}

		// Token: 0x06029ECB RID: 171723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029ECB")]
		[Address(RVA = "0x258D080", Offset = "0x258BC80", VA = "0x18258D080")]
		private static IEnumerator _ReceiveItemsFromBox(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06029ECC RID: 171724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ECC")]
		[Address(RVA = "0x258D170", Offset = "0x258BD70", VA = "0x18258D170")]
		private void _RefreshActWithNewIndex()
		{
		}

		// Token: 0x06029ECD RID: 171725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ECD")]
		[Address(RVA = "0x258D200", Offset = "0x258BE00", VA = "0x18258D200")]
		private void _RefreshCoinState()
		{
		}

		// Token: 0x06029ECE RID: 171726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ECE")]
		[Address(RVA = "0x258CA60", Offset = "0x258B660", VA = "0x18258CA60", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029ECF RID: 171727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ECF")]
		[Address(RVA = "0x258CC50", Offset = "0x258B850", VA = "0x18258CC50")]
		public void ToClueState()
		{
		}

		// Token: 0x06029ED0 RID: 171728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ED0")]
		[Address(RVA = "0x258D7D0", Offset = "0x258C3D0", VA = "0x18258D7D0")]
		public Act3D0GachaBoxState()
		{
		}

		// Token: 0x06029ED2 RID: 171730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ED2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403C130 RID: 246064
		[Token(Token = "0x403C130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act3D0GachaBoxStateBean _stateBean;

		// Token: 0x0403C131 RID: 246065
		[Token(Token = "0x403C131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act3D0GachaBoxRightPartView _rightPartView;

		// Token: 0x0403C132 RID: 246066
		[Token(Token = "0x403C132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act3D0ClueShowPart _showPart;

		// Token: 0x0403C133 RID: 246067
		[Token(Token = "0x403C133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x0403C134 RID: 246068
		[Token(Token = "0x403C134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403C135 RID: 246069
		[Token(Token = "0x403C135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _banner;

		// Token: 0x0403C136 RID: 246070
		[Token(Token = "0x403C136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _coinText;

		// Token: 0x0403C137 RID: 246071
		[Token(Token = "0x403C137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIGachaBoxDrawEffectFloatPage _floatPage;

		// Token: 0x0403C138 RID: 246072
		[Token(Token = "0x403C138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _floatPageContainer;

		// Token: 0x0403C139 RID: 246073
		[Token(Token = "0x403C139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0403C13A RID: 246074
		[Token(Token = "0x403C13A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIGachaBoxDrawEffectFloatPage m_floatPage;

		// Token: 0x0403C13B RID: 246075
		[Token(Token = "0x403C13B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_isInited;

		// Token: 0x0403C13C RID: 246076
		[Token(Token = "0x403C13C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403C13D RID: 246077
		[Token(Token = "0x403C13D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C13E RID: 246078
		[Token(Token = "0x403C13E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C13F RID: 246079
		[Token(Token = "0x403C13F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C140 RID: 246080
		[Token(Token = "0x403C140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickTence;

		// Token: 0x0403C141 RID: 246081
		[Token(Token = "0x403C141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendGachaRequest;

		// Token: 0x0403C142 RID: 246082
		[Token(Token = "0x403C142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendGachaInfoRequest;

		// Token: 0x0403C143 RID: 246083
		[Token(Token = "0x403C143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsFromBox;

		// Token: 0x0403C144 RID: 246084
		[Token(Token = "0x403C144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshActWithNewIndex;

		// Token: 0x0403C145 RID: 246085
		[Token(Token = "0x403C145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshCoinState;

		// Token: 0x0403C146 RID: 246086
		[Token(Token = "0x403C146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C147 RID: 246087
		[Token(Token = "0x403C147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ToClueState;

		// Token: 0x0403C148 RID: 246088
		[Token(Token = "0x403C148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
