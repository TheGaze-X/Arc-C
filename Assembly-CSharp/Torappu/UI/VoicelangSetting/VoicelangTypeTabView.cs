using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoicelangSetting
{
	// Token: 0x02003BC4 RID: 15300
	[Token(Token = "0x2003BC4")]
	public class VoicelangTypeTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F51 RID: 98129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F51")]
		[Address(RVA = "0x10766F0", Offset = "0x10752F0", VA = "0x1810766F0")]
		public void UpdateView(VoicelangTypeViewModel model)
		{
		}

		// Token: 0x06017F52 RID: 98130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F52")]
		[Address(RVA = "0x1076550", Offset = "0x1075150", VA = "0x181076550")]
		public void SetIsLastTab(bool isLast)
		{
		}

		// Token: 0x06017F53 RID: 98131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F53")]
		[Address(RVA = "0x10765D0", Offset = "0x10751D0", VA = "0x1810765D0")]
		public void SetSelectEvent(UISelectGroupTypeEvent listener)
		{
		}

		// Token: 0x06017F54 RID: 98132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F54")]
		[Address(RVA = "0x1076650", Offset = "0x1075250", VA = "0x181076650")]
		public void SetWidth(float width)
		{
		}

		// Token: 0x06017F55 RID: 98133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F55")]
		[Address(RVA = "0x10764C0", Offset = "0x10750C0", VA = "0x1810764C0")]
		public void OnClick()
		{
		}

		// Token: 0x06017F56 RID: 98134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F56")]
		[Address(RVA = "0x1076840", Offset = "0x1075440", VA = "0x181076840")]
		public VoicelangTypeTabView()
		{
		}

		// Token: 0x0401CFCF RID: 118735
		[Token(Token = "0x401CFCF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text m_typeText;

		// Token: 0x0401CFD0 RID: 118736
		[Token(Token = "0x401CFD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_selectGo;

		// Token: 0x0401CFD1 RID: 118737
		[Token(Token = "0x401CFD1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_rectTrans;

		// Token: 0x0401CFD2 RID: 118738
		[Token(Token = "0x401CFD2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_goCount;

		// Token: 0x0401CFD3 RID: 118739
		[Token(Token = "0x401CFD3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_goShu;

		// Token: 0x0401CFD4 RID: 118740
		[Token(Token = "0x401CFD4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text m_lbCount;

		// Token: 0x0401CFD5 RID: 118741
		[Token(Token = "0x401CFD5")]
		[FieldOffset(Offset = "0x48")]
		private UISelectGroupTypeEvent m_listener;

		// Token: 0x0401CFD6 RID: 118742
		[Token(Token = "0x401CFD6")]
		[FieldOffset(Offset = "0x50")]
		private VoicelangTypeViewModel m_model;

		// Token: 0x0401CFD7 RID: 118743
		[Token(Token = "0x401CFD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0401CFD8 RID: 118744
		[Token(Token = "0x401CFD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetIsLastTab;

		// Token: 0x0401CFD9 RID: 118745
		[Token(Token = "0x401CFD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectEvent;

		// Token: 0x0401CFDA RID: 118746
		[Token(Token = "0x401CFDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetWidth;

		// Token: 0x0401CFDB RID: 118747
		[Token(Token = "0x401CFDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401CFDC RID: 118748
		[Token(Token = "0x401CFDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
