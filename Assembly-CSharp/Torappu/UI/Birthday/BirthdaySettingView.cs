using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Birthday
{
	// Token: 0x020061D7 RID: 25047
	[Token(Token = "0x20061D7")]
	public class BirthdaySettingView : DataBinder<BirthdaySettingProperty>
	{
		// Token: 0x0602423E RID: 148030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602423E")]
		[Address(RVA = "0x1EDDCF0", Offset = "0x1EDC8F0", VA = "0x181EDDCF0", Slot = "7")]
		public override void OnValueChanged(BirthdaySettingProperty property)
		{
		}

		// Token: 0x0602423F RID: 148031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602423F")]
		[Address(RVA = "0x1EDDB20", Offset = "0x1EDC720", VA = "0x181EDDB20")]
		public void OnConfirm()
		{
		}

		// Token: 0x06024240 RID: 148032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024240")]
		[Address(RVA = "0x1EDDBC0", Offset = "0x1EDC7C0", VA = "0x181EDDBC0")]
		public void OnSetDate()
		{
		}

		// Token: 0x06024241 RID: 148033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024241")]
		[Address(RVA = "0x1EDDC50", Offset = "0x1EDC850", VA = "0x181EDDC50")]
		public void OnSetRegisterDate()
		{
		}

		// Token: 0x06024242 RID: 148034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024242")]
		[Address(RVA = "0x1EDDA80", Offset = "0x1EDC680", VA = "0x181EDDA80")]
		public void OnCloseClick()
		{
		}

		// Token: 0x06024243 RID: 148035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024243")]
		[Address(RVA = "0x1EDDFB0", Offset = "0x1EDCBB0", VA = "0x181EDDFB0")]
		public BirthdaySettingView()
		{
		}

		// Token: 0x04032405 RID: 205829
		[Token(Token = "0x4032405")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x04032406 RID: 205830
		[Token(Token = "0x4032406")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04032407 RID: 205831
		[Token(Token = "0x4032407")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _date;

		// Token: 0x04032408 RID: 205832
		[Token(Token = "0x4032408")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelSetStartDay;

		// Token: 0x04032409 RID: 205833
		[Token(Token = "0x4032409")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelIsStartDay;

		// Token: 0x0403240A RID: 205834
		[Token(Token = "0x403240A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelConfirm;

		// Token: 0x0403240B RID: 205835
		[Token(Token = "0x403240B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCannotConfirm;

		// Token: 0x0403240C RID: 205836
		[Token(Token = "0x403240C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _validDateColor;

		// Token: 0x0403240D RID: 205837
		[Token(Token = "0x403240D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _invalidDateColor;

		// Token: 0x0403240E RID: 205838
		[Token(Token = "0x403240E")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403240F RID: 205839
		[Token(Token = "0x403240F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032410 RID: 205840
		[Token(Token = "0x4032410")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x04032411 RID: 205841
		[Token(Token = "0x4032411")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSetDate;

		// Token: 0x04032412 RID: 205842
		[Token(Token = "0x4032412")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSetRegisterDate;

		// Token: 0x04032413 RID: 205843
		[Token(Token = "0x4032413")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCloseClick;

		// Token: 0x04032414 RID: 205844
		[Token(Token = "0x4032414")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
