using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C04 RID: 19460
	[Token(Token = "0x2004C04")]
	public class HomeBackgroundChangeView : DataBinder<HomeBackgroundChangeViewProperty>
	{
		// Token: 0x0601D3B7 RID: 119735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B7")]
		[Address(RVA = "0x16C7250", Offset = "0x16C5E50", VA = "0x1816C7250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D3B8 RID: 119736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B8")]
		[Address(RVA = "0x16C7410", Offset = "0x16C6010", VA = "0x1816C7410")]
		private void _OnSortToggleClick(TwoStateToggle.State state)
		{
		}

		// Token: 0x0601D3B9 RID: 119737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3B9")]
		[Address(RVA = "0x16C71C0", Offset = "0x16C5DC0", VA = "0x1816C71C0")]
		private void _HandleBgSelectChanged(string bgId)
		{
		}

		// Token: 0x0601D3BA RID: 119738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BA")]
		[Address(RVA = "0x16C7490", Offset = "0x16C6090", VA = "0x1816C7490")]
		private void _RefreshSelectedInfo(HomeBackgroundItemModel selected, bool hideIllustFlag, bool canCheckPos, bool isFirstEnter)
		{
		}

		// Token: 0x0601D3BB RID: 119739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BB")]
		[Address(RVA = "0x16C6E50", Offset = "0x16C5A50", VA = "0x1816C6E50")]
		public void OnHideIllustToggle()
		{
		}

		// Token: 0x0601D3BC RID: 119740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BC")]
		[Address(RVA = "0x16C6DC0", Offset = "0x16C59C0", VA = "0x1816C6DC0")]
		public void InitToggle(bool ascend)
		{
		}

		// Token: 0x0601D3BD RID: 119741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BD")]
		[Address(RVA = "0x16C6EC0", Offset = "0x16C5AC0", VA = "0x1816C6EC0", Slot = "7")]
		public override void OnValueChanged(HomeBackgroundChangeViewProperty property)
		{
		}

		// Token: 0x0601D3BE RID: 119742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D3BE")]
		[Address(RVA = "0x16C7A10", Offset = "0x16C6610", VA = "0x1816C7A10")]
		public HomeBackgroundChangeView()
		{
		}

		// Token: 0x0402669C RID: 157340
		[Token(Token = "0x402669C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _sortToggle;

		// Token: 0x0402669D RID: 157341
		[Token(Token = "0x402669D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objUnlockInfo;

		// Token: 0x0402669E RID: 157342
		[Token(Token = "0x402669E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textUnlockBgName;

		// Token: 0x0402669F RID: 157343
		[Token(Token = "0x402669F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUnlockBgmName;

		// Token: 0x040266A0 RID: 157344
		[Token(Token = "0x40266A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textBgDes;

		// Token: 0x040266A1 RID: 157345
		[Token(Token = "0x40266A1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objLockInfo;

		// Token: 0x040266A2 RID: 157346
		[Token(Token = "0x40266A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _confirmStateToggle;

		// Token: 0x040266A3 RID: 157347
		[Token(Token = "0x40266A3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLockBgName;

		// Token: 0x040266A4 RID: 157348
		[Token(Token = "0x40266A4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textLockBgmName;

		// Token: 0x040266A5 RID: 157349
		[Token(Token = "0x40266A5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textUnlockConditions;

		// Token: 0x040266A6 RID: 157350
		[Token(Token = "0x40266A6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeBackgroundListAdapter _homeBackgroundList;

		// Token: 0x040266A7 RID: 157351
		[Token(Token = "0x40266A7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x040266A8 RID: 157352
		[Token(Token = "0x40266A8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _objBtnConfirmBlocker;

		// Token: 0x040266A9 RID: 157353
		[Token(Token = "0x40266A9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _objMultiNotice;

		// Token: 0x040266AA RID: 157354
		[Token(Token = "0x40266AA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textMultiNotice;

		// Token: 0x040266AB RID: 157355
		[Token(Token = "0x40266AB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _hideIllustToggle;

		// Token: 0x040266AC RID: 157356
		[Token(Token = "0x40266AC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _checkPosBtnGroup;

		// Token: 0x040266AD RID: 157357
		[Token(Token = "0x40266AD")]
		[FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public Action<TwoStateToggle.State> onSortToggleClick;

		// Token: 0x040266AE RID: 157358
		[Token(Token = "0x40266AE")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public Action<string> onBgSelectChanged;

		// Token: 0x040266AF RID: 157359
		[Token(Token = "0x40266AF")]
		[FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public Action onIllustHideChanged;

		// Token: 0x040266B0 RID: 157360
		[Token(Token = "0x40266B0")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x040266B1 RID: 157361
		[Token(Token = "0x40266B1")]
		[FieldOffset(Offset = "0xC4")]
		private int m_routedSequenceNum;

		// Token: 0x040266B2 RID: 157362
		[Token(Token = "0x40266B2")]
		[FieldOffset(Offset = "0xC8")]
		private int m_enterSequenceNum;

		// Token: 0x040266B3 RID: 157363
		[Token(Token = "0x40266B3")]
		[FieldOffset(Offset = "0xD0")]
		private string m_cachedBgId;

		// Token: 0x040266B4 RID: 157364
		[Token(Token = "0x40266B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040266B5 RID: 157365
		[Token(Token = "0x40266B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSortToggleClick;

		// Token: 0x040266B6 RID: 157366
		[Token(Token = "0x40266B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleBgSelectChanged;

		// Token: 0x040266B7 RID: 157367
		[Token(Token = "0x40266B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshSelectedInfo;

		// Token: 0x040266B8 RID: 157368
		[Token(Token = "0x40266B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnHideIllustToggle;

		// Token: 0x040266B9 RID: 157369
		[Token(Token = "0x40266B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitToggle;

		// Token: 0x040266BA RID: 157370
		[Token(Token = "0x40266BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040266BB RID: 157371
		[Token(Token = "0x40266BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
