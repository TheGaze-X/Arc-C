using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A03 RID: 18947
	[Token(Token = "0x2004A03")]
	public class InformantHomeView : DataBinder<InformantHomeProperty>, IHotfixable
	{
		// Token: 0x0601C850 RID: 116816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C850")]
		[Address(RVA = "0x15F98D0", Offset = "0x15F84D0", VA = "0x1815F98D0", Slot = "7")]
		public override void OnValueChanged(InformantHomeProperty property)
		{
		}

		// Token: 0x0601C851 RID: 116817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C851")]
		[Address(RVA = "0x15F9840", Offset = "0x15F8440", VA = "0x1815F9840")]
		public void EventOnStartBtnClicked()
		{
		}

		// Token: 0x0601C852 RID: 116818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C852")]
		[Address(RVA = "0x15F97B0", Offset = "0x15F83B0", VA = "0x1815F97B0")]
		public void EventOnMilestoneBtnClicked()
		{
		}

		// Token: 0x0601C853 RID: 116819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C853")]
		[Address(RVA = "0x15F9D20", Offset = "0x15F8920", VA = "0x1815F9D20")]
		public void TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601C854 RID: 116820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C854")]
		[Address(RVA = "0x15F9E00", Offset = "0x15F8A00", VA = "0x1815F9E00")]
		public InformantHomeView()
		{
		}

		// Token: 0x04025617 RID: 153111
		[Token(Token = "0x4025617")]
		private const string ITEM_COST_FORMAT = "-{0}";

		// Token: 0x04025618 RID: 153112
		[Token(Token = "0x4025618")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDay;

		// Token: 0x04025619 RID: 153113
		[Token(Token = "0x4025619")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Font _pointFont;

		// Token: 0x0402561A RID: 153114
		[Token(Token = "0x402561A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMilestonePoint;

		// Token: 0x0402561B RID: 153115
		[Token(Token = "0x402561B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textItemName;

		// Token: 0x0402561C RID: 153116
		[Token(Token = "0x402561C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x0402561D RID: 153117
		[Token(Token = "0x402561D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InformantHomeView.SpecialCustomer[] _panelSpecialCustomer;

		// Token: 0x0402561E RID: 153118
		[Token(Token = "0x402561E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Milestone")]
		private GameObject _panelMilestoneNormal;

		// Token: 0x0402561F RID: 153119
		[Token(Token = "0x402561F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Milestone")]
		private GameObject _panelMilestoneComplete;

		// Token: 0x04025620 RID: 153120
		[Token(Token = "0x4025620")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Milestone")]
		private GameObject _panelTrackPoint;

		// Token: 0x04025621 RID: 153121
		[Token(Token = "0x4025621")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Button")]
		private Text[] _textItemCost;

		// Token: 0x04025622 RID: 153122
		[Token(Token = "0x4025622")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelItemCost;

		// Token: 0x04025623 RID: 153123
		[Token(Token = "0x4025623")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelItemCostNotEnough;

		// Token: 0x04025624 RID: 153124
		[Token(Token = "0x4025624")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnStart;

		// Token: 0x04025625 RID: 153125
		[Token(Token = "0x4025625")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnItemLocked;

		// Token: 0x04025626 RID: 153126
		[Token(Token = "0x4025626")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnClose;

		// Token: 0x04025627 RID: 153127
		[Token(Token = "0x4025627")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnContinue;

		// Token: 0x04025628 RID: 153128
		[Token(Token = "0x4025628")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _objEnterBtnHotspot;

		// Token: 0x04025629 RID: 153129
		[Token(Token = "0x4025629")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402562A RID: 153130
		[Token(Token = "0x402562A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402562B RID: 153131
		[Token(Token = "0x402562B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnStartBtnClicked;

		// Token: 0x0402562C RID: 153132
		[Token(Token = "0x402562C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMilestoneBtnClicked;

		// Token: 0x0402562D RID: 153133
		[Token(Token = "0x402562D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TutorialOnly_RegisterTutorialGo;

		// Token: 0x0402562E RID: 153134
		[Token(Token = "0x402562E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004A04 RID: 18948
		[Token(Token = "0x2004A04")]
		[Serializable]
		private class SpecialCustomer
		{
			// Token: 0x0601C855 RID: 116821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C855")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpecialCustomer()
			{
			}

			// Token: 0x0402562F RID: 153135
			[Token(Token = "0x402562F")]
			[FieldOffset(Offset = "0x10")]
			public GameObject _panelLocked;

			// Token: 0x04025630 RID: 153136
			[Token(Token = "0x4025630")]
			[FieldOffset(Offset = "0x18")]
			public GameObject _panelUnlock;
		}
	}
}
