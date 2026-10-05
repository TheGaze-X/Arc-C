using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A0C RID: 31244
	[Token(Token = "0x2007A0C")]
	public class Act13sidePrestigeState : PopupFadeState
	{
		// Token: 0x1700669B RID: 26267
		// (get) Token: 0x0602BCAC RID: 179372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700669B")]
		protected TemplateActivityController actController
		{
			[Token(Token = "0x602BCAC")]
			[Address(RVA = "0x27BE970", Offset = "0x27BD570", VA = "0x1827BE970")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700669C RID: 26268
		// (get) Token: 0x0602BCAD RID: 179373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700669C")]
		protected string activityId
		{
			[Token(Token = "0x602BCAD")]
			[Address(RVA = "0x27BEA50", Offset = "0x27BD650", VA = "0x1827BEA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602BCAE RID: 179374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCAE")]
		[Address(RVA = "0x27BD7A0", Offset = "0x27BC3A0", VA = "0x1827BD7A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BCAF RID: 179375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCAF")]
		[Address(RVA = "0x27BDF10", Offset = "0x27BCB10", VA = "0x1827BDF10", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BCB0 RID: 179376 RVA: 0x000DD340 File Offset: 0x000DB540
		[Token(Token = "0x602BCB0")]
		[Address(RVA = "0x27BE070", Offset = "0x27BCC70", VA = "0x1827BE070", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0602BCB1 RID: 179377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCB1")]
		[Address(RVA = "0x27BDDB0", Offset = "0x27BC9B0", VA = "0x1827BDDB0", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602BCB2 RID: 179378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB2")]
		[Address(RVA = "0x27BD9E0", Offset = "0x27BC5E0", VA = "0x1827BD9E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BCB3 RID: 179379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB3")]
		[Address(RVA = "0x27BDD40", Offset = "0x27BC940", VA = "0x1827BDD40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BCB4 RID: 179380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB4")]
		[Address(RVA = "0x27BE570", Offset = "0x27BD170", VA = "0x1827BE570")]
		private void _RenderOrgPanel(bool needAnim)
		{
		}

		// Token: 0x0602BCB5 RID: 179381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB5")]
		[Address(RVA = "0x27BE730", Offset = "0x27BD330", VA = "0x1827BE730")]
		private void _UpdateTrackPoint()
		{
		}

		// Token: 0x0602BCB6 RID: 179382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB6")]
		[Address(RVA = "0x27BD800", Offset = "0x27BC400", VA = "0x1827BD800")]
		public void OnBtnOpenArchive()
		{
		}

		// Token: 0x0602BCB7 RID: 179383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB7")]
		[Address(RVA = "0x27BD950", Offset = "0x27BC550", VA = "0x1827BD950")]
		public void OnBtnOpenMission()
		{
		}

		// Token: 0x0602BCB8 RID: 179384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB8")]
		[Address(RVA = "0x27BE2E0", Offset = "0x27BCEE0", VA = "0x1827BE2E0")]
		private void _OnOrgRewardClick(Act13SideData.OrgData orgData, Act13SideData.PrestigeRank currentRank)
		{
		}

		// Token: 0x0602BCB9 RID: 179385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCB9")]
		[Address(RVA = "0x27BE0E0", Offset = "0x27BCCE0", VA = "0x1827BE0E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BCBA RID: 179386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCBA")]
		[Address(RVA = "0x27BE460", Offset = "0x27BD060", VA = "0x1827BE460")]
		private void _RegisterToRewardState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BCBB RID: 179387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCBB")]
		[Address(RVA = "0x27BE3E0", Offset = "0x27BCFE0", VA = "0x1827BE3E0")]
		private void _RegisterFromMissionState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BCBC RID: 179388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCBC")]
		private T _FetchStageController<T>() where T : ActivityStageController
		{
			return null;
		}

		// Token: 0x0602BCBD RID: 179389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCBD")]
		[Address(RVA = "0x27BE900", Offset = "0x27BD500", VA = "0x1827BE900")]
		public Act13sidePrestigeState()
		{
		}

		// Token: 0x0602BCBF RID: 179391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCBF")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BCC0 RID: 179392 RVA: 0x000DD358 File Offset: 0x000DB558
		[Token(Token = "0x602BCC0")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x0602BCC1 RID: 179393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BCC1")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0602BCC2 RID: 179394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCC2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BCC3 RID: 179395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BCC3")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403F5C6 RID: 259526
		[Token(Token = "0x403F5C6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403F5C7 RID: 259527
		[Token(Token = "0x403F5C7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textUserName;

		// Token: 0x0403F5C8 RID: 259528
		[Token(Token = "0x403F5C8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act13sideOrgPanelView[] _orgPanelList;

		// Token: 0x0403F5C9 RID: 259529
		[Token(Token = "0x403F5C9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403F5CA RID: 259530
		[Token(Token = "0x403F5CA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation[] _orgAnimList;

		// Token: 0x0403F5CB RID: 259531
		[Token(Token = "0x403F5CB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _enterAnimDelay;

		// Token: 0x0403F5CC RID: 259532
		[Token(Token = "0x403F5CC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x0403F5CD RID: 259533
		[Token(Token = "0x403F5CD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UICommonTrackPoint _missionNewTrackPoint;

		// Token: 0x0403F5CE RID: 259534
		[Token(Token = "0x403F5CE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UICommonTrackPoint _archiveTrackPoint;

		// Token: 0x0403F5CF RID: 259535
		[Token(Token = "0x403F5CF")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x0403F5D0 RID: 259536
		[Token(Token = "0x403F5D0")]
		[FieldOffset(Offset = "0xC8")]
		private TemplateActivityController m_stageController;

		// Token: 0x0403F5D1 RID: 259537
		[Token(Token = "0x403F5D1")]
		[FieldOffset(Offset = "0xD0")]
		private Act13sidePrestigeState.StateCache m_stateCache;

		// Token: 0x0403F5D2 RID: 259538
		[Token(Token = "0x403F5D2")]
		[FieldOffset(Offset = "0xE0")]
		private TrackPointViewProperty m_missionTrackProp;

		// Token: 0x0403F5D3 RID: 259539
		[Token(Token = "0x403F5D3")]
		[FieldOffset(Offset = "0xE8")]
		private TrackPointViewProperty m_missionNewTrackProp;

		// Token: 0x0403F5D4 RID: 259540
		[Token(Token = "0x403F5D4")]
		[FieldOffset(Offset = "0xF0")]
		private TrackPointViewProperty m_archiveTrackProp;

		// Token: 0x0403F5D5 RID: 259541
		[Token(Token = "0x403F5D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actController;

		// Token: 0x0403F5D6 RID: 259542
		[Token(Token = "0x403F5D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403F5D7 RID: 259543
		[Token(Token = "0x403F5D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403F5D8 RID: 259544
		[Token(Token = "0x403F5D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403F5D9 RID: 259545
		[Token(Token = "0x403F5D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x0403F5DA RID: 259546
		[Token(Token = "0x403F5DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x0403F5DB RID: 259547
		[Token(Token = "0x403F5DB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F5DC RID: 259548
		[Token(Token = "0x403F5DC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F5DD RID: 259549
		[Token(Token = "0x403F5DD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderOrgPanel;

		// Token: 0x0403F5DE RID: 259550
		[Token(Token = "0x403F5DE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateTrackPoint;

		// Token: 0x0403F5DF RID: 259551
		[Token(Token = "0x403F5DF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnOpenArchive;

		// Token: 0x0403F5E0 RID: 259552
		[Token(Token = "0x403F5E0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBtnOpenMission;

		// Token: 0x0403F5E1 RID: 259553
		[Token(Token = "0x403F5E1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnOrgRewardClick;

		// Token: 0x0403F5E2 RID: 259554
		[Token(Token = "0x403F5E2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F5E3 RID: 259555
		[Token(Token = "0x403F5E3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RegisterToRewardState;

		// Token: 0x0403F5E4 RID: 259556
		[Token(Token = "0x403F5E4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RegisterFromMissionState;

		// Token: 0x0403F5E5 RID: 259557
		[Token(Token = "0x403F5E5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FetchStageController;

		// Token: 0x0403F5E6 RID: 259558
		[Token(Token = "0x403F5E6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A0D RID: 31245
		[Token(Token = "0x2007A0D")]
		private struct StateCache
		{
			// Token: 0x0602BCC4 RID: 179396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BCC4")]
			[Address(RVA = "0x27C0E60", Offset = "0x27BFA60", VA = "0x1827C0E60")]
			public void Clear()
			{
			}

			// Token: 0x0403F5E7 RID: 259559
			[Token(Token = "0x403F5E7")]
			[FieldOffset(Offset = "0x0")]
			public Act13SideData.OrgData orgData;

			// Token: 0x0403F5E8 RID: 259560
			[Token(Token = "0x403F5E8")]
			[FieldOffset(Offset = "0x8")]
			public Act13SideData.PrestigeRank currentRank;
		}
	}
}
