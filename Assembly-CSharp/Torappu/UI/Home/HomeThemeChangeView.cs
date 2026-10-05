using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C20 RID: 19488
	[Token(Token = "0x2004C20")]
	public class HomeThemeChangeView : DataBinder<HomeThemeChangeViewProperty>
	{
		// Token: 0x0601D445 RID: 119877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D445")]
		[Address(RVA = "0x16D8040", Offset = "0x16D6C40", VA = "0x1816D8040", Slot = "7")]
		public override void OnValueChanged(HomeThemeChangeViewProperty property)
		{
		}

		// Token: 0x0601D446 RID: 119878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D446")]
		[Address(RVA = "0x16D8680", Offset = "0x16D7280", VA = "0x1816D8680")]
		private void _RenderUnlockCondition(HomeThemeItemModel selected)
		{
		}

		// Token: 0x0601D447 RID: 119879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D447")]
		[Address(RVA = "0x16D8890", Offset = "0x16D7490", VA = "0x1816D8890")]
		public HomeThemeChangeView()
		{
		}

		// Token: 0x040267C0 RID: 157632
		[Token(Token = "0x40267C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HomeThemeListAdapter _adapter;

		// Token: 0x040267C1 RID: 157633
		[Token(Token = "0x40267C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _sortToggle;

		// Token: 0x040267C2 RID: 157634
		[Token(Token = "0x40267C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objUnlockInfo;

		// Token: 0x040267C3 RID: 157635
		[Token(Token = "0x40267C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUnlockThemeName;

		// Token: 0x040267C4 RID: 157636
		[Token(Token = "0x40267C4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textThemeDes;

		// Token: 0x040267C5 RID: 157637
		[Token(Token = "0x40267C5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objLockInfo;

		// Token: 0x040267C6 RID: 157638
		[Token(Token = "0x40267C6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _confirmStateToggle;

		// Token: 0x040267C7 RID: 157639
		[Token(Token = "0x40267C7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textLockThemeName;

		// Token: 0x040267C8 RID: 157640
		[Token(Token = "0x40267C8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textUnlockConditions;

		// Token: 0x040267C9 RID: 157641
		[Token(Token = "0x40267C9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _btnConfirm;

		// Token: 0x040267CA RID: 157642
		[Token(Token = "0x40267CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objBtnConfirmBlocker;

		// Token: 0x040267CB RID: 157643
		[Token(Token = "0x40267CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _objMultiNotice;

		// Token: 0x040267CC RID: 157644
		[Token(Token = "0x40267CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textMultiNotice;

		// Token: 0x040267CD RID: 157645
		[Token(Token = "0x40267CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TwoStateToggle _hideIllustToggle;

		// Token: 0x040267CE RID: 157646
		[Token(Token = "0x40267CE")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Action<TwoStateToggle.State> onSortToggleClick;

		// Token: 0x040267CF RID: 157647
		[Token(Token = "0x40267CF")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action<string> onSelectChanged;

		// Token: 0x040267D0 RID: 157648
		[Token(Token = "0x40267D0")]
		private const string UNLOCK_CONDITION_TYPE = "    - {0}({1}/{2})";

		// Token: 0x040267D1 RID: 157649
		[Token(Token = "0x40267D1")]
		[FieldOffset(Offset = "0xA0")]
		private int m_routedSequenceNum;

		// Token: 0x040267D2 RID: 157650
		[Token(Token = "0x40267D2")]
		[FieldOffset(Offset = "0xA4")]
		private int m_enterSequenceNum;

		// Token: 0x040267D3 RID: 157651
		[Token(Token = "0x40267D3")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedTmId;

		// Token: 0x040267D4 RID: 157652
		[Token(Token = "0x40267D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040267D5 RID: 157653
		[Token(Token = "0x40267D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderUnlockCondition;

		// Token: 0x040267D6 RID: 157654
		[Token(Token = "0x40267D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
