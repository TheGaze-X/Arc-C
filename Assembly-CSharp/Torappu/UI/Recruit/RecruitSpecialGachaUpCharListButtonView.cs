using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004719 RID: 18201
	[Token(Token = "0x2004719")]
	public class RecruitSpecialGachaUpCharListButtonView : DataBinder<RecruitSpecialGachaUpCharListProperty>, IHotfixable
	{
		// Token: 0x0601B969 RID: 113001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B969")]
		[Address(RVA = "0x14E7AD0", Offset = "0x14E66D0", VA = "0x1814E7AD0", Slot = "7")]
		public override void OnValueChanged(RecruitSpecialGachaUpCharListProperty property)
		{
		}

		// Token: 0x0601B96A RID: 113002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B96A")]
		[Address(RVA = "0x14E79B0", Offset = "0x14E65B0", VA = "0x1814E79B0")]
		public void EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x0601B96B RID: 113003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B96B")]
		[Address(RVA = "0x14E7920", Offset = "0x14E6520", VA = "0x1814E7920")]
		public void EventOnCancelBtnClicked()
		{
		}

		// Token: 0x0601B96C RID: 113004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B96C")]
		[Address(RVA = "0x14E7A40", Offset = "0x14E6640", VA = "0x1814E7A40")]
		public void EventOnIntroBtnClicked()
		{
		}

		// Token: 0x0601B96D RID: 113005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B96D")]
		[Address(RVA = "0x14E7C60", Offset = "0x14E6860", VA = "0x1814E7C60")]
		public RecruitSpecialGachaUpCharListButtonView()
		{
		}

		// Token: 0x04023BD7 RID: 146391
		[Token(Token = "0x4023BD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelBtnConfirm;

		// Token: 0x04023BD8 RID: 146392
		[Token(Token = "0x4023BD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBtnConfirmDisable;

		// Token: 0x04023BD9 RID: 146393
		[Token(Token = "0x4023BD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTips;

		// Token: 0x04023BDA RID: 146394
		[Token(Token = "0x4023BDA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bkgComplete;

		// Token: 0x04023BDB RID: 146395
		[Token(Token = "0x4023BDB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _bkgUnComplete;

		// Token: 0x04023BDC RID: 146396
		[Token(Token = "0x4023BDC")]
		[FieldOffset(Offset = "0x48")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x04023BDD RID: 146397
		[Token(Token = "0x4023BDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023BDE RID: 146398
		[Token(Token = "0x4023BDE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClicked;

		// Token: 0x04023BDF RID: 146399
		[Token(Token = "0x4023BDF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCancelBtnClicked;

		// Token: 0x04023BE0 RID: 146400
		[Token(Token = "0x4023BE0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnIntroBtnClicked;

		// Token: 0x04023BE1 RID: 146401
		[Token(Token = "0x4023BE1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
