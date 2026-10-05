using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007025 RID: 28709
	[Token(Token = "0x2007025")]
	public class ActMultiV3PrepareMainState : State, IValueMsgReceiver, IPopupCustomActive, ICompDialogCallBack
	{
		// Token: 0x17006037 RID: 24631
		// (get) Token: 0x06028BEF RID: 166895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006037")]
		public UICompDialogMgr dlgMgr
		{
			[Token(Token = "0x6028BEF")]
			[Address(RVA = "0x240AA80", Offset = "0x2409680", VA = "0x18240AA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028BF0 RID: 166896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028BF0")]
		[Address(RVA = "0x2406980", Offset = "0x2405580", VA = "0x182406980", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028BF1 RID: 166897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028BF1")]
		[Address(RVA = "0x24070A0", Offset = "0x2405CA0", VA = "0x1824070A0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028BF2 RID: 166898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF2")]
		[Address(RVA = "0x24069E0", Offset = "0x24055E0", VA = "0x1824069E0", Slot = "25")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06028BF3 RID: 166899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF3")]
		[Address(RVA = "0x2406BB0", Offset = "0x24057B0", VA = "0x182406BB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028BF4 RID: 166900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF4")]
		[Address(RVA = "0x2406C20", Offset = "0x2405820", VA = "0x182406C20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06028BF5 RID: 166901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF5")]
		[Address(RVA = "0x2406B50", Offset = "0x2405750", VA = "0x182406B50")]
		private void OnDestroy()
		{
		}

		// Token: 0x06028BF6 RID: 166902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF6")]
		[Address(RVA = "0x240A6F0", Offset = "0x24092F0", VA = "0x18240A6F0")]
		private void _Release()
		{
		}

		// Token: 0x06028BF7 RID: 166903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF7")]
		[Address(RVA = "0x2407520", Offset = "0x2406120", VA = "0x182407520")]
		private void Update()
		{
		}

		// Token: 0x06028BF8 RID: 166904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF8")]
		[Address(RVA = "0x2409380", Offset = "0x2407F80", VA = "0x182409380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028BF9 RID: 166905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BF9")]
		[Address(RVA = "0x2407200", Offset = "0x2405E00", VA = "0x182407200")]
		public void SetPopViewLayer(Transform viewTrans)
		{
		}

		// Token: 0x06028BFA RID: 166906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BFA")]
		[Address(RVA = "0x2407280", Offset = "0x2405E80", VA = "0x182407280")]
		public void UpdateMainViewConfig()
		{
		}

		// Token: 0x17006038 RID: 24632
		// (get) Token: 0x06028BFB RID: 166907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006038")]
		public ActMultiV3PrepareMainBannerView banner
		{
			[Token(Token = "0x6028BFB")]
			[Address(RVA = "0x240AA20", Offset = "0x2409620", VA = "0x18240AA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028BFC RID: 166908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BFC")]
		[Address(RVA = "0x2409960", Offset = "0x2408560", VA = "0x182409960")]
		private void _OnJumpToStageListState(IStateBean stateBean)
		{
		}

		// Token: 0x06028BFD RID: 166909 RVA: 0x000D2DC8 File Offset: 0x000D0FC8
		[Token(Token = "0x6028BFD")]
		[Address(RVA = "0x2406910", Offset = "0x2405510", VA = "0x182406910", Slot = "24")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x06028BFE RID: 166910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BFE")]
		[Address(RVA = "0x2406C90", Offset = "0x2405890", VA = "0x182406C90", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028BFF RID: 166911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BFF")]
		[Address(RVA = "0x2407AB0", Offset = "0x24066B0", VA = "0x182407AB0")]
		private void _EventOnExit()
		{
		}

		// Token: 0x06028C00 RID: 166912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C00")]
		[Address(RVA = "0x2407730", Offset = "0x2406330", VA = "0x182407730")]
		private void _EventOnBack()
		{
		}

		// Token: 0x06028C01 RID: 166913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C01")]
		[Address(RVA = "0x24089C0", Offset = "0x24075C0", VA = "0x1824089C0")]
		private void _EventOnSetEmergency(bool emergency)
		{
		}

		// Token: 0x06028C02 RID: 166914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C02")]
		[Address(RVA = "0x2409E50", Offset = "0x2408A50", VA = "0x182409E50")]
		private void _OpenChat()
		{
		}

		// Token: 0x06028C03 RID: 166915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C03")]
		[Address(RVA = "0x2407F40", Offset = "0x2406B40", VA = "0x182407F40")]
		private void _EventOnKick()
		{
		}

		// Token: 0x06028C04 RID: 166916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C04")]
		[Address(RVA = "0x24077A0", Offset = "0x24063A0", VA = "0x1824077A0")]
		private void _EventOnCheckNameCard()
		{
		}

		// Token: 0x06028C05 RID: 166917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C05")]
		[Address(RVA = "0x2408750", Offset = "0x2407350", VA = "0x182408750")]
		private void _EventOnOpenStageDetailDialog()
		{
		}

		// Token: 0x06028C06 RID: 166918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C06")]
		[Address(RVA = "0x2408290", Offset = "0x2406E90", VA = "0x182408290")]
		private void _EventOnOpenSquadEffectInfoDialog()
		{
		}

		// Token: 0x06028C07 RID: 166919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C07")]
		[Address(RVA = "0x2408530", Offset = "0x2407130", VA = "0x182408530")]
		private void _EventOnOpenStageChooseState()
		{
		}

		// Token: 0x06028C08 RID: 166920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C08")]
		[Address(RVA = "0x2407960", Offset = "0x2406560", VA = "0x182407960")]
		private void _EventOnEnterGameOnPartnerOffline()
		{
		}

		// Token: 0x06028C09 RID: 166921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C09")]
		[Address(RVA = "0x2407D60", Offset = "0x2406960", VA = "0x182407D60")]
		private void _EventOnInvite()
		{
		}

		// Token: 0x06028C0A RID: 166922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0A")]
		[Address(RVA = "0x240A2D0", Offset = "0x2408ED0", VA = "0x18240A2D0")]
		private void _OpenNameCardPage()
		{
		}

		// Token: 0x06028C0B RID: 166923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0B")]
		[Address(RVA = "0x2409C60", Offset = "0x2408860", VA = "0x182409C60")]
		private void _OnSendChat()
		{
		}

		// Token: 0x06028C0C RID: 166924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0C")]
		[Address(RVA = "0x240A770", Offset = "0x2409370", VA = "0x18240A770")]
		private void _UnRegiesterSvrEvent()
		{
		}

		// Token: 0x06028C0D RID: 166925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0D")]
		[Address(RVA = "0x240A500", Offset = "0x2409100", VA = "0x18240A500")]
		private void _RegisterSvrEvent()
		{
		}

		// Token: 0x06028C0E RID: 166926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0E")]
		[Address(RVA = "0x2408D50", Offset = "0x2407950", VA = "0x182408D50")]
		private void _HandleTeamChanged(object arg)
		{
		}

		// Token: 0x06028C0F RID: 166927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C0F")]
		[Address(RVA = "0x2409100", Offset = "0x2407D00", VA = "0x182409100")]
		private void _HandleTeamChat(object arg)
		{
		}

		// Token: 0x06028C10 RID: 166928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C10")]
		[Address(RVA = "0x2408B10", Offset = "0x2407710", VA = "0x182408B10")]
		private void _HandleGetNameCardRet(object arg)
		{
		}

		// Token: 0x06028C11 RID: 166929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C11")]
		[Address(RVA = "0x2406880", Offset = "0x2405480", VA = "0x182406880")]
		public void CloseDialogsAndEmoticonPanel()
		{
		}

		// Token: 0x06028C12 RID: 166930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C12")]
		[Address(RVA = "0x240A960", Offset = "0x2409560", VA = "0x18240A960")]
		public ActMultiV3PrepareMainState()
		{
		}

		// Token: 0x06028C13 RID: 166931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C13")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028C14 RID: 166932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C14")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028C15 RID: 166933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C15")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403A189 RID: 237961
		[Token(Token = "0x403A189")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3PrepareMainStepView _stepView;

		// Token: 0x0403A18A RID: 237962
		[Token(Token = "0x403A18A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActMultiV3PrepareMainViewBase[] _staticMainViews;

		// Token: 0x0403A18B RID: 237963
		[Token(Token = "0x403A18B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ActMultiV3PrepareMainState.DynViewPrefab[] _viewPrefabs;

		// Token: 0x0403A18C RID: 237964
		[Token(Token = "0x403A18C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform _popViewContainer;

		// Token: 0x0403A18D RID: 237965
		[Token(Token = "0x403A18D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3PrepareMainBannerView _bannerView;

		// Token: 0x0403A18E RID: 237966
		[Token(Token = "0x403A18E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3EmoticonController _emoticonController;

		// Token: 0x0403A18F RID: 237967
		[Token(Token = "0x403A18F")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3PrepareMainViewModelProperty m_prop;

		// Token: 0x0403A190 RID: 237968
		[Token(Token = "0x403A190")]
		[FieldOffset(Offset = "0x88")]
		private List<ActMultiV3PrepareMainStepPanelBase> m_stepPanels;

		// Token: 0x0403A191 RID: 237969
		[Token(Token = "0x403A191")]
		[FieldOffset(Offset = "0x90")]
		private List<ActMultiV3PrepareMainViewBase> m_mainViews;

		// Token: 0x0403A192 RID: 237970
		[Token(Token = "0x403A192")]
		[FieldOffset(Offset = "0x98")]
		private UICompDialogMgr m_dlgMgr;

		// Token: 0x0403A193 RID: 237971
		[Token(Token = "0x403A193")]
		[FieldOffset(Offset = "0xA0")]
		private int m_leaveRoomDlgInstId;

		// Token: 0x0403A194 RID: 237972
		[Token(Token = "0x403A194")]
		[FieldOffset(Offset = "0xA4")]
		private int m_kickDlgInstId;

		// Token: 0x0403A195 RID: 237973
		[Token(Token = "0x403A195")]
		[FieldOffset(Offset = "0xA8")]
		private int m_enterGameOnPartnerOfflineDlgInstId;

		// Token: 0x0403A196 RID: 237974
		[Token(Token = "0x403A196")]
		[FieldOffset(Offset = "0xB0")]
		private string m_partnerIdToKick;

		// Token: 0x0403A197 RID: 237975
		[Token(Token = "0x403A197")]
		[FieldOffset(Offset = "0xB8")]
		private int m_invitedDialogInstId;

		// Token: 0x0403A198 RID: 237976
		[Token(Token = "0x403A198")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, long> m_invitedCache;

		// Token: 0x0403A199 RID: 237977
		[Token(Token = "0x403A199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dlgMgr;

		// Token: 0x0403A19A RID: 237978
		[Token(Token = "0x403A19A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A19B RID: 237979
		[Token(Token = "0x403A19B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403A19C RID: 237980
		[Token(Token = "0x403A19C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403A19D RID: 237981
		[Token(Token = "0x403A19D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A19E RID: 237982
		[Token(Token = "0x403A19E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403A19F RID: 237983
		[Token(Token = "0x403A19F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403A1A0 RID: 237984
		[Token(Token = "0x403A1A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Release;

		// Token: 0x0403A1A1 RID: 237985
		[Token(Token = "0x403A1A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403A1A2 RID: 237986
		[Token(Token = "0x403A1A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A1A3 RID: 237987
		[Token(Token = "0x403A1A3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetPopViewLayer;

		// Token: 0x0403A1A4 RID: 237988
		[Token(Token = "0x403A1A4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateMainViewConfig;

		// Token: 0x0403A1A5 RID: 237989
		[Token(Token = "0x403A1A5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_banner;

		// Token: 0x0403A1A6 RID: 237990
		[Token(Token = "0x403A1A6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnJumpToStageListState;

		// Token: 0x0403A1A7 RID: 237991
		[Token(Token = "0x403A1A7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x0403A1A8 RID: 237992
		[Token(Token = "0x403A1A8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403A1A9 RID: 237993
		[Token(Token = "0x403A1A9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnExit;

		// Token: 0x0403A1AA RID: 237994
		[Token(Token = "0x403A1AA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnBack;

		// Token: 0x0403A1AB RID: 237995
		[Token(Token = "0x403A1AB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnSetEmergency;

		// Token: 0x0403A1AC RID: 237996
		[Token(Token = "0x403A1AC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OpenChat;

		// Token: 0x0403A1AD RID: 237997
		[Token(Token = "0x403A1AD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnKick;

		// Token: 0x0403A1AE RID: 237998
		[Token(Token = "0x403A1AE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnCheckNameCard;

		// Token: 0x0403A1AF RID: 237999
		[Token(Token = "0x403A1AF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnOpenStageDetailDialog;

		// Token: 0x0403A1B0 RID: 238000
		[Token(Token = "0x403A1B0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnOpenSquadEffectInfoDialog;

		// Token: 0x0403A1B1 RID: 238001
		[Token(Token = "0x403A1B1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__EventOnOpenStageChooseState;

		// Token: 0x0403A1B2 RID: 238002
		[Token(Token = "0x403A1B2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnEnterGameOnPartnerOffline;

		// Token: 0x0403A1B3 RID: 238003
		[Token(Token = "0x403A1B3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__EventOnInvite;

		// Token: 0x0403A1B4 RID: 238004
		[Token(Token = "0x403A1B4")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OpenNameCardPage;

		// Token: 0x0403A1B5 RID: 238005
		[Token(Token = "0x403A1B5")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnSendChat;

		// Token: 0x0403A1B6 RID: 238006
		[Token(Token = "0x403A1B6")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UnRegiesterSvrEvent;

		// Token: 0x0403A1B7 RID: 238007
		[Token(Token = "0x403A1B7")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RegisterSvrEvent;

		// Token: 0x0403A1B8 RID: 238008
		[Token(Token = "0x403A1B8")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__HandleTeamChanged;

		// Token: 0x0403A1B9 RID: 238009
		[Token(Token = "0x403A1B9")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__HandleTeamChat;

		// Token: 0x0403A1BA RID: 238010
		[Token(Token = "0x403A1BA")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__HandleGetNameCardRet;

		// Token: 0x0403A1BB RID: 238011
		[Token(Token = "0x403A1BB")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CloseDialogsAndEmoticonPanel;

		// Token: 0x0403A1BC RID: 238012
		[Token(Token = "0x403A1BC")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007026 RID: 28710
		[Token(Token = "0x2007026")]
		[Serializable]
		private class DynViewPrefab
		{
			// Token: 0x06028C16 RID: 166934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028C16")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DynViewPrefab()
			{
			}

			// Token: 0x0403A1BD RID: 238013
			[Token(Token = "0x403A1BD")]
			[FieldOffset(Offset = "0x10")]
			public Transform container;

			// Token: 0x0403A1BE RID: 238014
			[Token(Token = "0x403A1BE")]
			[FieldOffset(Offset = "0x18")]
			public ActMultiV3PrepareMainViewBase viewPrefab;
		}

		// Token: 0x02007027 RID: 28711
		[Token(Token = "0x2007027")]
		public static class Event
		{
			// Token: 0x0403A1BF RID: 238015
			[Token(Token = "0x403A1BF")]
			public const int EXIT = 1;

			// Token: 0x0403A1C0 RID: 238016
			[Token(Token = "0x403A1C0")]
			public const int BACK = 2;

			// Token: 0x0403A1C1 RID: 238017
			[Token(Token = "0x403A1C1")]
			public const int OPEN_STAGE_DETAIL = 3;

			// Token: 0x0403A1C2 RID: 238018
			[Token(Token = "0x403A1C2")]
			public const int KICK = 4;

			// Token: 0x0403A1C3 RID: 238019
			[Token(Token = "0x403A1C3")]
			public const int CHECK_PARTNER_NAME_CARD = 5;

			// Token: 0x0403A1C4 RID: 238020
			[Token(Token = "0x403A1C4")]
			public const int OPEN_CHAT = 6;

			// Token: 0x0403A1C5 RID: 238021
			[Token(Token = "0x403A1C5")]
			public const int SET_IN_EMERGENCY = 7;

			// Token: 0x0403A1C6 RID: 238022
			[Token(Token = "0x403A1C6")]
			public const int OPEN_SQUAD_INFO = 8;

			// Token: 0x0403A1C7 RID: 238023
			[Token(Token = "0x403A1C7")]
			public const int ON_STAGE_CHOOSE_BTN_CLICKED = 9;

			// Token: 0x0403A1C8 RID: 238024
			[Token(Token = "0x403A1C8")]
			public const int ENTER_GAME_ON_PARTNER_OFFLINE = 10;

			// Token: 0x0403A1C9 RID: 238025
			[Token(Token = "0x403A1C9")]
			public const int MAP_CHANGED = 11;

			// Token: 0x0403A1CA RID: 238026
			[Token(Token = "0x403A1CA")]
			public const int ON_INVITE = 12;
		}
	}
}
