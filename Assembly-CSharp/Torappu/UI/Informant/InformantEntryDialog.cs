using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A00 RID: 18944
	[Token(Token = "0x2004A00")]
	public class InformantEntryDialog : UICompDialog<InformantDialogCommonInput>, IHotfixable
	{
		// Token: 0x0601C831 RID: 116785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C831")]
		[Address(RVA = "0x15F6270", Offset = "0x15F4E70", VA = "0x1815F6270", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C832 RID: 116786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C832")]
		[Address(RVA = "0x15F64A0", Offset = "0x15F50A0", VA = "0x1815F64A0", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C833 RID: 116787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C833")]
		[Address(RVA = "0x15F6190", Offset = "0x15F4D90", VA = "0x1815F6190", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601C834 RID: 116788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C834")]
		[Address(RVA = "0x15F60C0", Offset = "0x15F4CC0", VA = "0x1815F60C0")]
		public void EventOnNextStateBtnClicked()
		{
		}

		// Token: 0x0601C835 RID: 116789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C835")]
		[Address(RVA = "0x15F6A60", Offset = "0x15F5660", VA = "0x1815F6A60")]
		private void _EventOnExitClicked()
		{
		}

		// Token: 0x0601C836 RID: 116790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C836")]
		[Address(RVA = "0x15F6B30", Offset = "0x15F5730", VA = "0x1815F6B30")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C837 RID: 116791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C837")]
		[Address(RVA = "0x15F6E70", Offset = "0x15F5A70", VA = "0x1815F6E70")]
		private void _TutorialOnly_RegisterTutorialGo()
		{
		}

		// Token: 0x0601C838 RID: 116792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C838")]
		[Address(RVA = "0x15F6DC0", Offset = "0x15F59C0", VA = "0x1815F6DC0")]
		private void _TutorialOnly_EntryAnimRouted()
		{
		}

		// Token: 0x0601C839 RID: 116793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C839")]
		[Address(RVA = "0x15F7020", Offset = "0x15F5C20", VA = "0x1815F7020")]
		public InformantEntryDialog()
		{
		}

		// Token: 0x0601C83A RID: 116794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C83A")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601C83B RID: 116795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C83B")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x040255D5 RID: 153045
		[Token(Token = "0x40255D5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040255D6 RID: 153046
		[Token(Token = "0x40255D6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _openingAnim;

		// Token: 0x040255D7 RID: 153047
		[Token(Token = "0x40255D7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040255D8 RID: 153048
		[Token(Token = "0x40255D8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Common")]
		private InformantNewsTabView _newsTabPrefab;

		// Token: 0x040255D9 RID: 153049
		[Token(Token = "0x40255D9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _newsTabContainer;

		// Token: 0x040255DA RID: 153050
		[Token(Token = "0x40255DA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Common")]
		private InformantCustomerBarView _customerBarPrefab;

		// Token: 0x040255DB RID: 153051
		[Token(Token = "0x40255DB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _customerBarContainer;

		// Token: 0x040255DC RID: 153052
		[Token(Token = "0x40255DC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Common")]
		private InformantCommonTopMenu _topMenuPrefab;

		// Token: 0x040255DD RID: 153053
		[Token(Token = "0x40255DD")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _topMenuContainer;

		// Token: 0x040255DE RID: 153054
		[Token(Token = "0x40255DE")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Common")]
		private InformantMilestonePointItemView _milestonePrefab;

		// Token: 0x040255DF RID: 153055
		[Token(Token = "0x40255DF")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Common")]
		private RectTransform _milestoneContainer;

		// Token: 0x040255E0 RID: 153056
		[Token(Token = "0x40255E0")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private InformantCustomerInfoView _customerInfo;

		// Token: 0x040255E1 RID: 153057
		[Token(Token = "0x40255E1")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _textCustomerName;

		// Token: 0x040255E2 RID: 153058
		[Token(Token = "0x40255E2")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AVGSharedCharacter _imgChar;

		// Token: 0x040255E3 RID: 153059
		[Token(Token = "0x40255E3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _avgCharBlackStart;

		// Token: 0x040255E4 RID: 153060
		[Token(Token = "0x40255E4")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float _avgCharBlackEnd;

		// Token: 0x040255E5 RID: 153061
		[Token(Token = "0x40255E5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _textDay;

		// Token: 0x040255E6 RID: 153062
		[Token(Token = "0x40255E6")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _objTutorialCustomerInfo;

		// Token: 0x040255E7 RID: 153063
		[Token(Token = "0x40255E7")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _objMilestonePoint;

		// Token: 0x040255E8 RID: 153064
		[Token(Token = "0x40255E8")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _objBtnStart;

		// Token: 0x040255E9 RID: 153065
		[Token(Token = "0x40255E9")]
		[FieldOffset(Offset = "0x118")]
		private InformantNewsTabView m_newsTabView;

		// Token: 0x040255EA RID: 153066
		[Token(Token = "0x40255EA")]
		[FieldOffset(Offset = "0x120")]
		private InformantMilestonePointItemView m_milestoneView;

		// Token: 0x040255EB RID: 153067
		[Token(Token = "0x40255EB")]
		[FieldOffset(Offset = "0x128")]
		private InformantCommonTopMenu m_topMenu;

		// Token: 0x040255EC RID: 153068
		[Token(Token = "0x40255EC")]
		[FieldOffset(Offset = "0x130")]
		private InformantCustomerBarProperty m_customerBarProperty;

		// Token: 0x040255ED RID: 153069
		[Token(Token = "0x40255ED")]
		[FieldOffset(Offset = "0x138")]
		private InformantCustomerInfoViewModel m_infoViewModel;

		// Token: 0x040255EE RID: 153070
		[Token(Token = "0x40255EE")]
		[FieldOffset(Offset = "0x140")]
		private InformantNewsTabViewModel m_newsTabViewModel;

		// Token: 0x040255EF RID: 153071
		[Token(Token = "0x40255EF")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_entryAnim;

		// Token: 0x040255F0 RID: 153072
		[Token(Token = "0x40255F0")]
		[FieldOffset(Offset = "0x150")]
		private string m_actId;

		// Token: 0x040255F1 RID: 153073
		[Token(Token = "0x40255F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040255F2 RID: 153074
		[Token(Token = "0x40255F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040255F3 RID: 153075
		[Token(Token = "0x40255F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x040255F4 RID: 153076
		[Token(Token = "0x40255F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNextStateBtnClicked;

		// Token: 0x040255F5 RID: 153077
		[Token(Token = "0x40255F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnExitClicked;

		// Token: 0x040255F6 RID: 153078
		[Token(Token = "0x40255F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x040255F7 RID: 153079
		[Token(Token = "0x40255F7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterTutorialGo;

		// Token: 0x040255F8 RID: 153080
		[Token(Token = "0x40255F8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TutorialOnly_EntryAnimRouted;

		// Token: 0x040255F9 RID: 153081
		[Token(Token = "0x40255F9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
