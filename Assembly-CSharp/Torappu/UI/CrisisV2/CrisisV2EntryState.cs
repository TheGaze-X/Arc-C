using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005942 RID: 22850
	[Token(Token = "0x2005942")]
	public class CrisisV2EntryState : State, IValueMsgReceiver
	{
		// Token: 0x06021497 RID: 136343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021497")]
		[Address(RVA = "0x1BA3360", Offset = "0x1BA1F60", VA = "0x181BA3360", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021498 RID: 136344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021498")]
		[Address(RVA = "0x1BA4060", Offset = "0x1BA2C60", VA = "0x181BA4060")]
		private void Update()
		{
		}

		// Token: 0x06021499 RID: 136345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021499")]
		[Address(RVA = "0x1BA3A30", Offset = "0x1BA2630", VA = "0x181BA3A30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602149A RID: 136346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602149A")]
		[Address(RVA = "0x1BA3E90", Offset = "0x1BA2A90", VA = "0x181BA3E90", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602149B RID: 136347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602149B")]
		[Address(RVA = "0x1BA4940", Offset = "0x1BA3540", VA = "0x181BA4940")]
		private void _TriggerCrisisV2BGM()
		{
		}

		// Token: 0x0602149C RID: 136348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602149C")]
		[Address(RVA = "0x1BA44B0", Offset = "0x1BA30B0", VA = "0x181BA44B0")]
		private void _RegisterToMapState(IStateBean targetBean)
		{
		}

		// Token: 0x0602149D RID: 136349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602149D")]
		[Address(RVA = "0x1BA43A0", Offset = "0x1BA2FA0", VA = "0x181BA43A0")]
		private void _OnCrisisDataFetched()
		{
		}

		// Token: 0x0602149E RID: 136350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602149E")]
		[Address(RVA = "0x1BA41B0", Offset = "0x1BA2DB0", VA = "0x181BA41B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602149F RID: 136351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602149F")]
		[Address(RVA = "0x1BA4100", Offset = "0x1BA2D00", VA = "0x181BA4100")]
		private void _EventOnBack()
		{
		}

		// Token: 0x060214A0 RID: 136352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A0")]
		[Address(RVA = "0x1BA4AD0", Offset = "0x1BA36D0", VA = "0x181BA4AD0")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x060214A1 RID: 136353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A1")]
		[Address(RVA = "0x1BA4BE0", Offset = "0x1BA37E0", VA = "0x181BA4BE0")]
		private void _TryConsumeGuidebook([Optional] Story story)
		{
		}

		// Token: 0x060214A2 RID: 136354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A2")]
		[Address(RVA = "0x1BA47B0", Offset = "0x1BA33B0", VA = "0x181BA47B0")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x060214A3 RID: 136355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A3")]
		[Address(RVA = "0x1BA3DE0", Offset = "0x1BA29E0", VA = "0x181BA3DE0")]
		public void OpenShopPage()
		{
		}

		// Token: 0x060214A4 RID: 136356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A4")]
		[Address(RVA = "0x1BA3D30", Offset = "0x1BA2930", VA = "0x181BA3D30")]
		public void OpenArchievePage()
		{
		}

		// Token: 0x060214A5 RID: 136357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A5")]
		[Address(RVA = "0x1BA31B0", Offset = "0x1BA1DB0", VA = "0x181BA31B0")]
		public void EventOnMedalClicked()
		{
		}

		// Token: 0x060214A6 RID: 136358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214A6")]
		[Address(RVA = "0x1BA3260", Offset = "0x1BA1E60", VA = "0x181BA3260", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060214A7 RID: 136359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A7")]
		[Address(RVA = "0x1BA4690", Offset = "0x1BA3290", VA = "0x181BA4690")]
		private void _RegisterToMedalState(IStateBean stateBean)
		{
		}

		// Token: 0x060214A8 RID: 136360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A8")]
		[Address(RVA = "0x1BA3950", Offset = "0x1BA2550", VA = "0x181BA3950")]
		public void OnOpenMapState(string mapId)
		{
		}

		// Token: 0x060214A9 RID: 136361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214A9")]
		[Address(RVA = "0x1BA3790", Offset = "0x1BA2390", VA = "0x181BA3790", Slot = "23")]
		public void OnMessage(int type, ValueBundle value)
		{
		}

		// Token: 0x060214AA RID: 136362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214AA")]
		[Address(RVA = "0x1BA32C0", Offset = "0x1BA1EC0", VA = "0x181BA32C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060214AB RID: 136363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214AB")]
		[Address(RVA = "0x1BA4CA0", Offset = "0x1BA38A0", VA = "0x181BA4CA0")]
		public CrisisV2EntryState()
		{
		}

		// Token: 0x060214AC RID: 136364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214AC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060214AD RID: 136365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60214AD")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060214AE RID: 136366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60214AE")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402D626 RID: 185894
		[Token(Token = "0x402D626")]
		private const string GUIDE_BOOK_SUB_SIGNAL = "entry";

		// Token: 0x0402D627 RID: 185895
		[Token(Token = "0x402D627")]
		[NonSerialized]
		public const string ENTRY_ENTER_ANIM = "crisis_v2_entry_enter_anim";

		// Token: 0x0402D628 RID: 185896
		[Token(Token = "0x402D628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402D629 RID: 185897
		[Token(Token = "0x402D629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CrisisV2EntryStateBean _stateBean;

		// Token: 0x0402D62A RID: 185898
		[Token(Token = "0x402D62A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CrisisV2EntryMainView _mainView;

		// Token: 0x0402D62B RID: 185899
		[Token(Token = "0x402D62B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402D62C RID: 185900
		[Token(Token = "0x402D62C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelShopBtn;

		// Token: 0x0402D62D RID: 185901
		[Token(Token = "0x402D62D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelAchieveBtn;

		// Token: 0x0402D62E RID: 185902
		[Token(Token = "0x402D62E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelDailyBtn;

		// Token: 0x0402D62F RID: 185903
		[Token(Token = "0x402D62F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelMainMapBtn;

		// Token: 0x0402D630 RID: 185904
		[Token(Token = "0x402D630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CrisisV2EntryAVGAdapter _avgAdapter;

		// Token: 0x0402D631 RID: 185905
		[Token(Token = "0x402D631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x0402D632 RID: 185906
		[Token(Token = "0x402D632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0402D633 RID: 185907
		[Token(Token = "0x402D633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string m_cacheMapId;

		// Token: 0x0402D634 RID: 185908
		[Token(Token = "0x402D634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool m_requestingCrisisData;

		// Token: 0x0402D635 RID: 185909
		[Token(Token = "0x402D635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CrisisV2DataFromServer m_crisisData;

		// Token: 0x0402D636 RID: 185910
		[Token(Token = "0x402D636")]
		public const int PERM_MAP_CLICK = 0;

		// Token: 0x0402D637 RID: 185911
		[Token(Token = "0x402D637")]
		public const int TEMP_MAP_CLICK = 1;

		// Token: 0x0402D638 RID: 185912
		[Token(Token = "0x402D638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402D639 RID: 185913
		[Token(Token = "0x402D639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0402D63A RID: 185914
		[Token(Token = "0x402D63A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402D63B RID: 185915
		[Token(Token = "0x402D63B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402D63C RID: 185916
		[Token(Token = "0x402D63C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerCrisisV2BGM;

		// Token: 0x0402D63D RID: 185917
		[Token(Token = "0x402D63D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterToMapState;

		// Token: 0x0402D63E RID: 185918
		[Token(Token = "0x402D63E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCrisisDataFetched;

		// Token: 0x0402D63F RID: 185919
		[Token(Token = "0x402D63F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D640 RID: 185920
		[Token(Token = "0x402D640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnBack;

		// Token: 0x0402D641 RID: 185921
		[Token(Token = "0x402D641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x0402D642 RID: 185922
		[Token(Token = "0x402D642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryConsumeGuidebook;

		// Token: 0x0402D643 RID: 185923
		[Token(Token = "0x402D643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x0402D644 RID: 185924
		[Token(Token = "0x402D644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OpenShopPage;

		// Token: 0x0402D645 RID: 185925
		[Token(Token = "0x402D645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OpenArchievePage;

		// Token: 0x0402D646 RID: 185926
		[Token(Token = "0x402D646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnMedalClicked;

		// Token: 0x0402D647 RID: 185927
		[Token(Token = "0x402D647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402D648 RID: 185928
		[Token(Token = "0x402D648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RegisterToMedalState;

		// Token: 0x0402D649 RID: 185929
		[Token(Token = "0x402D649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnOpenMapState;

		// Token: 0x0402D64A RID: 185930
		[Token(Token = "0x402D64A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402D64B RID: 185931
		[Token(Token = "0x402D64B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402D64C RID: 185932
		[Token(Token = "0x402D64C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
