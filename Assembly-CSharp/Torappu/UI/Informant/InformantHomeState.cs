using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A01 RID: 18945
	[Token(Token = "0x2004A01")]
	public class InformantHomeState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601C83C RID: 116796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C83C")]
		[Address(RVA = "0x15F7370", Offset = "0x15F5F70", VA = "0x1815F7370", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C83D RID: 116797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C83D")]
		[Address(RVA = "0x15F73D0", Offset = "0x15F5FD0", VA = "0x1815F73D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C83E RID: 116798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C83E")]
		[Address(RVA = "0x15F78D0", Offset = "0x15F64D0", VA = "0x1815F78D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C83F RID: 116799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C83F")]
		[Address(RVA = "0x15F7B00", Offset = "0x15F6700", VA = "0x1815F7B00", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601C840 RID: 116800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C840")]
		[Address(RVA = "0x15F83E0", Offset = "0x15F6FE0", VA = "0x1815F83E0")]
		private void _OnJumpToInnerState(IStateBean sb)
		{
		}

		// Token: 0x0601C841 RID: 116801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C841")]
		[Address(RVA = "0x15F7760", Offset = "0x15F6360", VA = "0x1815F7760", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C842 RID: 116802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C842")]
		[Address(RVA = "0x15F7DD0", Offset = "0x15F69D0", VA = "0x1815F7DD0")]
		private void _EventOnStartBtnClicked()
		{
		}

		// Token: 0x0601C843 RID: 116803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C843")]
		[Address(RVA = "0x15F7D20", Offset = "0x15F6920", VA = "0x1815F7D20")]
		private void _EventOnMilestoneBtnClicked()
		{
		}

		// Token: 0x0601C844 RID: 116804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C844")]
		[Address(RVA = "0x15F8250", Offset = "0x15F6E50", VA = "0x1815F8250")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C845 RID: 116805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C845")]
		[Address(RVA = "0x15F7C60", Offset = "0x15F6860", VA = "0x1815F7C60")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x0601C846 RID: 116806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C846")]
		[Address(RVA = "0x15F81C0", Offset = "0x15F6DC0", VA = "0x1815F81C0")]
		private void _HandleStartGame(InformantStartGameResponse _)
		{
		}

		// Token: 0x0601C847 RID: 116807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C847")]
		[Address(RVA = "0x15F84D0", Offset = "0x15F70D0", VA = "0x1815F84D0")]
		private void _OpenInner()
		{
		}

		// Token: 0x0601C848 RID: 116808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C848")]
		[Address(RVA = "0x15F8580", Offset = "0x15F7180", VA = "0x1815F8580")]
		private void _TryConsumeGuidebook()
		{
		}

		// Token: 0x0601C849 RID: 116809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C849")]
		[Address(RVA = "0x15F8620", Offset = "0x15F7220", VA = "0x1815F8620")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C84A RID: 116810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C84A")]
		[Address(RVA = "0x15F8830", Offset = "0x15F7430", VA = "0x1815F8830")]
		private void _TutorialOnly_EntryAnimRouted()
		{
		}

		// Token: 0x0601C84B RID: 116811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C84B")]
		[Address(RVA = "0x15F88E0", Offset = "0x15F74E0", VA = "0x1815F88E0")]
		public InformantHomeState()
		{
		}

		// Token: 0x0601C84C RID: 116812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C84C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C84D RID: 116813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C84D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601C84E RID: 116814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C84E")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x040255FA RID: 153082
		[Token(Token = "0x40255FA")]
		[NonSerialized]
		public const int ON_START_BTN_CLICKED = 0;

		// Token: 0x040255FB RID: 153083
		[Token(Token = "0x40255FB")]
		[NonSerialized]
		public const int ON_MILESTONE_BTN_CLICKED = 1;

		// Token: 0x040255FC RID: 153084
		[Token(Token = "0x40255FC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InformantHomeView _homeView;

		// Token: 0x040255FD RID: 153085
		[Token(Token = "0x40255FD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040255FE RID: 153086
		[Token(Token = "0x40255FE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InformantCommonTopMenu _topMenuPrefab;

		// Token: 0x040255FF RID: 153087
		[Token(Token = "0x40255FF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04025600 RID: 153088
		[Token(Token = "0x4025600")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x04025601 RID: 153089
		[Token(Token = "0x4025601")]
		[FieldOffset(Offset = "0xA0")]
		private InformantCommonTopMenu m_topMenu;

		// Token: 0x04025602 RID: 153090
		[Token(Token = "0x4025602")]
		[FieldOffset(Offset = "0xA8")]
		private InformantHomeStateBean m_stateBean;

		// Token: 0x04025603 RID: 153091
		[Token(Token = "0x4025603")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_entryAnim;

		// Token: 0x04025604 RID: 153092
		[Token(Token = "0x4025604")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025605 RID: 153093
		[Token(Token = "0x4025605")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025606 RID: 153094
		[Token(Token = "0x4025606")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025607 RID: 153095
		[Token(Token = "0x4025607")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025608 RID: 153096
		[Token(Token = "0x4025608")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToInnerState;

		// Token: 0x04025609 RID: 153097
		[Token(Token = "0x4025609")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402560A RID: 153098
		[Token(Token = "0x402560A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnStartBtnClicked;

		// Token: 0x0402560B RID: 153099
		[Token(Token = "0x402560B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnMilestoneBtnClicked;

		// Token: 0x0402560C RID: 153100
		[Token(Token = "0x402560C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402560D RID: 153101
		[Token(Token = "0x402560D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x0402560E RID: 153102
		[Token(Token = "0x402560E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleStartGame;

		// Token: 0x0402560F RID: 153103
		[Token(Token = "0x402560F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenInner;

		// Token: 0x04025610 RID: 153104
		[Token(Token = "0x4025610")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x04025611 RID: 153105
		[Token(Token = "0x4025611")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x04025612 RID: 153106
		[Token(Token = "0x4025612")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TutorialOnly_EntryAnimRouted;

		// Token: 0x04025613 RID: 153107
		[Token(Token = "0x4025613")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
