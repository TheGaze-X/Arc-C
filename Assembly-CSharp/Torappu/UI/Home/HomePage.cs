using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AD6 RID: 19158
	[Token(Token = "0x2004AD6")]
	public class HomePage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x0601CC54 RID: 117844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170043E3")]
		public AutoPopupController autoPopupController
		{
			[Token(Token = "0x601CC54")]
			[Address(RVA = "0x164B690", Offset = "0x164A290", VA = "0x18164B690")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601CC55 RID: 117845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC55")]
		[Address(RVA = "0x1647DE0", Offset = "0x16469E0", VA = "0x181647DE0", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x0601CC56 RID: 117846 RVA: 0x000A9758 File Offset: 0x000A7958
		[Token(Token = "0x170043E4")]
		public bool showHomeDisplay
		{
			[Token(Token = "0x601CC56")]
			[Address(RVA = "0x164B780", Offset = "0x164A380", VA = "0x18164B780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601CC57 RID: 117847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC57")]
		[Address(RVA = "0x1648070", Offset = "0x1646C70", VA = "0x181648070", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601CC58 RID: 117848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC58")]
		[Address(RVA = "0x1648560", Offset = "0x1647160", VA = "0x181648560", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x0601CC59 RID: 117849 RVA: 0x000A9770 File Offset: 0x000A7970
		[Token(Token = "0x170043E5")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x601CC59")]
			[Address(RVA = "0x164B710", Offset = "0x164A310", VA = "0x18164B710", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x0601CC5A RID: 117850 RVA: 0x000A9788 File Offset: 0x000A7988
		[Token(Token = "0x601CC5A")]
		[Address(RVA = "0x1647E60", Offset = "0x1646A60", VA = "0x181647E60")]
		public bool IsInitialState()
		{
			return default(bool);
		}

		// Token: 0x0601CC5B RID: 117851 RVA: 0x000A97A0 File Offset: 0x000A79A0
		[Token(Token = "0x601CC5B")]
		[Address(RVA = "0x1647F90", Offset = "0x1646B90", VA = "0x181647F90")]
		public bool IsStateTransiting()
		{
			return default(bool);
		}

		// Token: 0x0601CC5C RID: 117852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC5C")]
		[Address(RVA = "0x1649000", Offset = "0x1647C00", VA = "0x181649000")]
		public void TryEnterHomeCommonActivity(string funcActId, [Optional] DataBundle actMeta)
		{
		}

		// Token: 0x0601CC5D RID: 117853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC5D")]
		[Address(RVA = "0x1648C50", Offset = "0x1647850", VA = "0x181648C50")]
		public void RouteToCrisisV2Stage()
		{
		}

		// Token: 0x0601CC5E RID: 117854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC5E")]
		[Address(RVA = "0x1648EC0", Offset = "0x1647AC0", VA = "0x181648EC0")]
		public void RouteToRoguelike(string topicId)
		{
		}

		// Token: 0x0601CC5F RID: 117855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC5F")]
		[Address(RVA = "0x16489C0", Offset = "0x16475C0", VA = "0x1816489C0")]
		public void RouteToCharRepo()
		{
		}

		// Token: 0x0601CC60 RID: 117856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC60")]
		[Address(RVA = "0x1648860", Offset = "0x1647460", VA = "0x181648860")]
		public void PlayHomeMusic(string musicId)
		{
		}

		// Token: 0x0601CC61 RID: 117857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC61")]
		[Address(RVA = "0x1648920", Offset = "0x1647520", VA = "0x181648920")]
		public void ResetHomeMusicToConfig()
		{
		}

		// Token: 0x0601CC62 RID: 117858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC62")]
		[Address(RVA = "0x1647B70", Offset = "0x1646770", VA = "0x181647B70")]
		[Obsolete("HomeIllustPage was replaced with home char rotation state")]
		public void BackToLastStateOrIllustPage()
		{
		}

		// Token: 0x0601CC63 RID: 117859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC63")]
		[Address(RVA = "0x16497E0", Offset = "0x16483E0", VA = "0x1816497E0")]
		private void _BackToLastStateOrCertainPage(string pageName)
		{
		}

		// Token: 0x0601CC64 RID: 117860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC64")]
		[Address(RVA = "0x16496F0", Offset = "0x16482F0", VA = "0x1816496F0")]
		private IEnumerator _BackToInitStateAndOpenPageCoroutine(string pageName)
		{
			return null;
		}

		// Token: 0x0601CC65 RID: 117861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC65")]
		[Address(RVA = "0x164AF20", Offset = "0x1649B20", VA = "0x18164AF20")]
		private void _SetPageShow(bool isShow)
		{
		}

		// Token: 0x0601CC66 RID: 117862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC66")]
		[Address(RVA = "0x1647D00", Offset = "0x1646900", VA = "0x181647D00", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601CC67 RID: 117863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC67")]
		[Address(RVA = "0x1649FB0", Offset = "0x1648BB0", VA = "0x181649FB0")]
		private void _HandleOnShow(bool isFromStack)
		{
		}

		// Token: 0x0601CC68 RID: 117864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC68")]
		[Address(RVA = "0x1647C00", Offset = "0x1646800", VA = "0x181647C00", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601CC69 RID: 117865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC69")]
		[Address(RVA = "0x16482F0", Offset = "0x1646EF0", VA = "0x1816482F0", Slot = "19")]
		protected override IEnumerator OnPageReservedDuringReset(UIPageStackParam param)
		{
			return null;
		}

		// Token: 0x0601CC6A RID: 117866 RVA: 0x000A97B8 File Offset: 0x000A79B8
		[Token(Token = "0x601CC6A")]
		[Address(RVA = "0x164A420", Offset = "0x1649020", VA = "0x18164A420")]
		private bool _IsNotResetToDefaultHomeState()
		{
			return default(bool);
		}

		// Token: 0x0601CC6B RID: 117867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC6B")]
		[Address(RVA = "0x164A910", Offset = "0x1649510", VA = "0x18164A910")]
		private void _MarkPlayDynEntranceWhenRouted(bool useHomeMainState, bool isFromStack)
		{
		}

		// Token: 0x0601CC6C RID: 117868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC6C")]
		[Address(RVA = "0x164AE60", Offset = "0x1649A60", VA = "0x18164AE60")]
		private IEnumerator _PlayHomeShowAnim()
		{
			return null;
		}

		// Token: 0x0601CC6D RID: 117869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC6D")]
		[Address(RVA = "0x164AD70", Offset = "0x1649970", VA = "0x18164AD70")]
		private IEnumerator _PlayDynEntrance(DynIllustStartMgr.Param param)
		{
			return null;
		}

		// Token: 0x0601CC6E RID: 117870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC6E")]
		[Address(RVA = "0x1648400", Offset = "0x1647000", VA = "0x181648400", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601CC6F RID: 117871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC6F")]
		[Address(RVA = "0x1649D10", Offset = "0x1648910", VA = "0x181649D10")]
		private IEnumerator _CoroutineOnPageRouted()
		{
			return null;
		}

		// Token: 0x0601CC70 RID: 117872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC70")]
		[Address(RVA = "0x16494F0", Offset = "0x16480F0", VA = "0x1816494F0")]
		private void _AfterHomePageRouted()
		{
		}

		// Token: 0x0601CC71 RID: 117873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC71")]
		[Address(RVA = "0x1649DD0", Offset = "0x16489D0", VA = "0x181649DD0")]
		private IEnumerator _CoroutinePlayDynEntrance(CharUISkinStruct skin, bool backToMainState)
		{
			return null;
		}

		// Token: 0x0601CC72 RID: 117874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC72")]
		[Address(RVA = "0x16486A0", Offset = "0x16472A0", VA = "0x1816486A0")]
		public void PlayDynEntrance(CharUISkinStruct skin, bool backToMainState)
		{
		}

		// Token: 0x0601CC73 RID: 117875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC73")]
		[Address(RVA = "0x164ABF0", Offset = "0x16497F0", VA = "0x18164ABF0")]
		private void _OnRouteFromNonPluginPage(bool playedDynEntranceWhenRouted)
		{
		}

		// Token: 0x0601CC74 RID: 117876 RVA: 0x000A97D0 File Offset: 0x000A79D0
		[Token(Token = "0x601CC74")]
		[Address(RVA = "0x1649BF0", Offset = "0x16487F0", VA = "0x181649BF0")]
		private bool _CheckIfFromPluginPage()
		{
			return default(bool);
		}

		// Token: 0x0601CC75 RID: 117877 RVA: 0x000A97E8 File Offset: 0x000A79E8
		[Token(Token = "0x601CC75")]
		[Address(RVA = "0x16499C0", Offset = "0x16485C0", VA = "0x1816499C0")]
		private bool _CanShowExitGameDialog()
		{
			return default(bool);
		}

		// Token: 0x0601CC76 RID: 117878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC76")]
		[Address(RVA = "0x164B010", Offset = "0x1649C10", VA = "0x18164B010")]
		private static void _ShowExitGameDialog()
		{
		}

		// Token: 0x0601CC77 RID: 117879 RVA: 0x000A9800 File Offset: 0x000A7A00
		[Token(Token = "0x601CC77")]
		[Address(RVA = "0x164A1C0", Offset = "0x1648DC0", VA = "0x18164A1C0")]
		private bool _InitHomeStateFromParam(HomePage.Params param)
		{
			return default(bool);
		}

		// Token: 0x0601CC78 RID: 117880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC78")]
		[Address(RVA = "0x164B2B0", Offset = "0x1649EB0", VA = "0x18164B2B0")]
		private IEnumerator _TryOpenIllustEditStateCoroutine()
		{
			return null;
		}

		// Token: 0x0601CC79 RID: 117881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC79")]
		[Address(RVA = "0x164B370", Offset = "0x1649F70", VA = "0x18164B370")]
		private IEnumerator _TryOpenInitHomeActivityCoroutine(string actId, DataBundle actMeta)
		{
			return null;
		}

		// Token: 0x0601CC7A RID: 117882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC7A")]
		private IEnumerator _TryOpenReplaceableStateCoroutine<T>(bool fastMode = false) where T : HomeReplaceableState
		{
			return null;
		}

		// Token: 0x0601CC7B RID: 117883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC7B")]
		private IEnumerator _JumpToCharRotationRelateState<T>() where T : HomeReplaceableState
		{
			return null;
		}

		// Token: 0x0601CC7C RID: 117884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC7C")]
		[Address(RVA = "0x1649170", Offset = "0x1647D70", VA = "0x181649170")]
		public CharWordData TryLoadRandomIllustText()
		{
			return null;
		}

		// Token: 0x0601CC7D RID: 117885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC7D")]
		[Address(RVA = "0x164A070", Offset = "0x1648C70", VA = "0x18164A070")]
		private void _InitHomeMusic(bool isNewlyAdd)
		{
		}

		// Token: 0x0601CC7E RID: 117886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC7E")]
		[Address(RVA = "0x164AAE0", Offset = "0x16496E0", VA = "0x18164AAE0")]
		private void _ModifyHomeMusicChunk(string musicId, bool isNewlyAdd)
		{
		}

		// Token: 0x0601CC7F RID: 117887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC7F")]
		[Address(RVA = "0x1649F00", Offset = "0x1648B00", VA = "0x181649F00")]
		private static string _GetMusicIdFromSelectedBkg()
		{
			return null;
		}

		// Token: 0x0601CC80 RID: 117888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC80")]
		[Address(RVA = "0x164A4D0", Offset = "0x16490D0", VA = "0x18164A4D0")]
		private void _JumpToRoguelikeEntryView(string topicId)
		{
		}

		// Token: 0x0601CC81 RID: 117889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC81")]
		[Address(RVA = "0x164A580", Offset = "0x1649180", VA = "0x18164A580")]
		private void _JumpToRoguelikeTabView(string topicId)
		{
		}

		// Token: 0x0601CC82 RID: 117890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC82")]
		[Address(RVA = "0x1648250", Offset = "0x1646E50", VA = "0x181648250")]
		private void OnDisable()
		{
		}

		// Token: 0x0601CC83 RID: 117891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC83")]
		[Address(RVA = "0x164B590", Offset = "0x164A190", VA = "0x18164B590")]
		public HomePage()
		{
		}

		// Token: 0x0601CC89 RID: 117897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC89")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601CC8A RID: 117898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC8A")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601CC8B RID: 117899 RVA: 0x000A9818 File Offset: 0x000A7A18
		[Token(Token = "0x601CC8B")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x0601CC8C RID: 117900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC8C")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0601CC8D RID: 117901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC8D")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0601CC8E RID: 117902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CC8E")]
		[Address(RVA = "0x1649260", Offset = "0x1647E60", VA = "0x181649260")]
		private IEnumerator <>xLuaBaseProxy_OnPageReservedDuringReset(UIPageStackParam P0)
		{
			return null;
		}

		// Token: 0x0601CC8F RID: 117903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CC8F")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x04025C21 RID: 154657
		[Token(Token = "0x4025C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ListSet<string> PLUGIN_PAGES;

		// Token: 0x04025C22 RID: 154658
		[Token(Token = "0x4025C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private HomeMainStateBean _homeStateBean;

		// Token: 0x04025C23 RID: 154659
		[Token(Token = "0x4025C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04025C24 RID: 154660
		[Token(Token = "0x4025C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private AutoPopupController m_autoPopupController;

		// Token: 0x04025C25 RID: 154661
		[Token(Token = "0x4025C25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_isHomeShowAnimPlaying;

		// Token: 0x04025C26 RID: 154662
		[Token(Token = "0x4025C26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIPopupWindow.UIBlocker m_homeShowAnimblocker;

		// Token: 0x04025C27 RID: 154663
		[Token(Token = "0x4025C27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool m_playDynEntranceWhenRouted;

		// Token: 0x04025C28 RID: 154664
		[Token(Token = "0x4025C28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04025C29 RID: 154665
		[Token(Token = "0x4025C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_autoPopupController;

		// Token: 0x04025C2A RID: 154666
		[Token(Token = "0x4025C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x04025C2B RID: 154667
		[Token(Token = "0x4025C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showHomeDisplay;

		// Token: 0x04025C2C RID: 154668
		[Token(Token = "0x4025C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04025C2D RID: 154669
		[Token(Token = "0x4025C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04025C2E RID: 154670
		[Token(Token = "0x4025C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x04025C2F RID: 154671
		[Token(Token = "0x4025C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsInitialState;

		// Token: 0x04025C30 RID: 154672
		[Token(Token = "0x4025C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsStateTransiting;

		// Token: 0x04025C31 RID: 154673
		[Token(Token = "0x4025C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryEnterHomeCommonActivity;

		// Token: 0x04025C32 RID: 154674
		[Token(Token = "0x4025C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RouteToCrisisV2Stage;

		// Token: 0x04025C33 RID: 154675
		[Token(Token = "0x4025C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RouteToRoguelike;

		// Token: 0x04025C34 RID: 154676
		[Token(Token = "0x4025C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RouteToCharRepo;

		// Token: 0x04025C35 RID: 154677
		[Token(Token = "0x4025C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_PlayHomeMusic;

		// Token: 0x04025C36 RID: 154678
		[Token(Token = "0x4025C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ResetHomeMusicToConfig;

		// Token: 0x04025C37 RID: 154679
		[Token(Token = "0x4025C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_BackToLastStateOrIllustPage;

		// Token: 0x04025C38 RID: 154680
		[Token(Token = "0x4025C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__BackToLastStateOrCertainPage;

		// Token: 0x04025C39 RID: 154681
		[Token(Token = "0x4025C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__BackToInitStateAndOpenPageCoroutine;

		// Token: 0x04025C3A RID: 154682
		[Token(Token = "0x4025C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetPageShow;

		// Token: 0x04025C3B RID: 154683
		[Token(Token = "0x4025C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04025C3C RID: 154684
		[Token(Token = "0x4025C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleOnShow;

		// Token: 0x04025C3D RID: 154685
		[Token(Token = "0x4025C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04025C3E RID: 154686
		[Token(Token = "0x4025C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnPageReservedDuringReset;

		// Token: 0x04025C3F RID: 154687
		[Token(Token = "0x4025C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__IsNotResetToDefaultHomeState;

		// Token: 0x04025C40 RID: 154688
		[Token(Token = "0x4025C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__MarkPlayDynEntranceWhenRouted;

		// Token: 0x04025C41 RID: 154689
		[Token(Token = "0x4025C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PlayHomeShowAnim;

		// Token: 0x04025C42 RID: 154690
		[Token(Token = "0x4025C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__PlayDynEntrance;

		// Token: 0x04025C43 RID: 154691
		[Token(Token = "0x4025C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x04025C44 RID: 154692
		[Token(Token = "0x4025C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CoroutineOnPageRouted;

		// Token: 0x04025C45 RID: 154693
		[Token(Token = "0x4025C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__AfterHomePageRouted;

		// Token: 0x04025C46 RID: 154694
		[Token(Token = "0x4025C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CoroutinePlayDynEntrance;

		// Token: 0x04025C47 RID: 154695
		[Token(Token = "0x4025C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_PlayDynEntrance;

		// Token: 0x04025C48 RID: 154696
		[Token(Token = "0x4025C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnRouteFromNonPluginPage;

		// Token: 0x04025C49 RID: 154697
		[Token(Token = "0x4025C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__CheckIfFromPluginPage;

		// Token: 0x04025C4A RID: 154698
		[Token(Token = "0x4025C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CanShowExitGameDialog;

		// Token: 0x04025C4B RID: 154699
		[Token(Token = "0x4025C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ShowExitGameDialog;

		// Token: 0x04025C4C RID: 154700
		[Token(Token = "0x4025C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__InitHomeStateFromParam;

		// Token: 0x04025C4D RID: 154701
		[Token(Token = "0x4025C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__TryOpenIllustEditStateCoroutine;

		// Token: 0x04025C4E RID: 154702
		[Token(Token = "0x4025C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__TryOpenInitHomeActivityCoroutine;

		// Token: 0x04025C4F RID: 154703
		[Token(Token = "0x4025C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__TryOpenReplaceableStateCoroutine;

		// Token: 0x04025C50 RID: 154704
		[Token(Token = "0x4025C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__JumpToCharRotationRelateState;

		// Token: 0x04025C51 RID: 154705
		[Token(Token = "0x4025C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryLoadRandomIllustText;

		// Token: 0x04025C52 RID: 154706
		[Token(Token = "0x4025C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__InitHomeMusic;

		// Token: 0x04025C53 RID: 154707
		[Token(Token = "0x4025C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ModifyHomeMusicChunk;

		// Token: 0x04025C54 RID: 154708
		[Token(Token = "0x4025C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GetMusicIdFromSelectedBkg;

		// Token: 0x04025C55 RID: 154709
		[Token(Token = "0x4025C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__JumpToRoguelikeEntryView;

		// Token: 0x04025C56 RID: 154710
		[Token(Token = "0x4025C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__JumpToRoguelikeTabView;

		// Token: 0x04025C57 RID: 154711
		[Token(Token = "0x4025C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04025C58 RID: 154712
		[Token(Token = "0x4025C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AD7 RID: 19159
		[Token(Token = "0x2004AD7")]
		public enum InitOpts
		{
			// Token: 0x04025C5A RID: 154714
			[Token(Token = "0x4025C5A")]
			NONE,
			// Token: 0x04025C5B RID: 154715
			[Token(Token = "0x4025C5B")]
			EDIT_ILLUST,
			// Token: 0x04025C5C RID: 154716
			[Token(Token = "0x4025C5C")]
			CHANGE_BKG,
			// Token: 0x04025C5D RID: 154717
			[Token(Token = "0x4025C5D")]
			HOME_ACT,
			// Token: 0x04025C5E RID: 154718
			[Token(Token = "0x4025C5E")]
			CHANGE_SECRETARY,
			// Token: 0x04025C5F RID: 154719
			[Token(Token = "0x4025C5F")]
			CHANGE_SECRETARY_SKIN,
			// Token: 0x04025C60 RID: 154720
			[Token(Token = "0x4025C60")]
			CHANGE_THEME
		}

		// Token: 0x02004AD8 RID: 19160
		[Token(Token = "0x2004AD8")]
		public class Params
		{
			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0601CC90 RID: 117904 RVA: 0x000A9830 File Offset: 0x000A7A30
			// (set) Token: 0x0601CC91 RID: 117905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170043E6")]
			public HomePage.InitOpts initOpt
			{
				[Token(Token = "0x601CC90")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				private get
				{
					return HomePage.InitOpts.NONE;
				}
				[Token(Token = "0x601CC91")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601CC92 RID: 117906 RVA: 0x000A9848 File Offset: 0x000A7A48
			[Token(Token = "0x601CC92")]
			[Address(RVA = "0x164B940", Offset = "0x164A540", VA = "0x18164B940")]
			public bool HasInitOpt()
			{
				return default(bool);
			}

			// Token: 0x0601CC93 RID: 117907 RVA: 0x000A9860 File Offset: 0x000A7A60
			[Token(Token = "0x601CC93")]
			[Address(RVA = "0x164B8B0", Offset = "0x164A4B0", VA = "0x18164B8B0")]
			public HomePage.InitOpts ConsumeInitOpt()
			{
				return HomePage.InitOpts.NONE;
			}

			// Token: 0x0601CC94 RID: 117908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CC94")]
			[Address(RVA = "0x164B900", Offset = "0x164A500", VA = "0x18164B900")]
			public HomeThemeChangeStateBean.RoutedHomeThemeParam GetAndConsumeRoutedHomeThemeParam()
			{
				return null;
			}

			// Token: 0x0601CC95 RID: 117909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CC95")]
			[Address(RVA = "0x164B8C0", Offset = "0x164A4C0", VA = "0x18164B8C0")]
			public HomeBackgroundChangeStateBean.RoutedHomeBkgParam GetAndConsumeRoutedHomeBkgParam()
			{
				return null;
			}

			// Token: 0x0601CC96 RID: 117910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CC96")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04025C62 RID: 154722
			[Token(Token = "0x4025C62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string paramStr;

			// Token: 0x04025C63 RID: 154723
			[Token(Token = "0x4025C63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DataBundle paramBundle;

			// Token: 0x04025C64 RID: 154724
			[Token(Token = "0x4025C64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isPreview;

			// Token: 0x04025C65 RID: 154725
			[Token(Token = "0x4025C65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public HomeSecretaryChangeSkinStateBean.InputParams skinStateParam;

			// Token: 0x04025C66 RID: 154726
			[Token(Token = "0x4025C66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public HomeThemeChangeStateBean.RoutedHomeThemeParam routedHomeThemeParam;

			// Token: 0x04025C67 RID: 154727
			[Token(Token = "0x4025C67")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public HomeBackgroundChangeStateBean.RoutedHomeBkgParam routedHomeBkgParam;
		}

		// Token: 0x02004AD9 RID: 19161
		[Token(Token = "0x2004AD9")]
		public interface INotResetToDefaultHomeState
		{
		}
	}
}
