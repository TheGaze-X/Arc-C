using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006148 RID: 24904
	[Token(Token = "0x2006148")]
	public class CampaignZoneMapView : DataBinder<CampaignZoneMapProperty>, IHotfixable
	{
		// Token: 0x06023F4A RID: 147274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4A")]
		[Address(RVA = "0x1EAE480", Offset = "0x1EAD080", VA = "0x181EAE480", Slot = "7")]
		public override void OnValueChanged(CampaignZoneMapProperty property)
		{
		}

		// Token: 0x06023F4B RID: 147275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4B")]
		[Address(RVA = "0x1EAE3E0", Offset = "0x1EACFE0", VA = "0x181EAE3E0")]
		public void EventOnJumpBtnClicked()
		{
		}

		// Token: 0x06023F4C RID: 147276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4C")]
		[Address(RVA = "0x1EAE340", Offset = "0x1EACF40", VA = "0x181EAE340")]
		public void EventOnBackBkgClicked()
		{
		}

		// Token: 0x06023F4D RID: 147277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4D")]
		[Address(RVA = "0x1EAED60", Offset = "0x1EAD960", VA = "0x181EAED60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023F4E RID: 147278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4E")]
		[Address(RVA = "0x1EAE830", Offset = "0x1EAD430", VA = "0x181EAE830")]
		private void _FocusToStage(string stageId, bool isEnter)
		{
		}

		// Token: 0x06023F4F RID: 147279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F4F")]
		[Address(RVA = "0x1EAEC50", Offset = "0x1EAD850", VA = "0x181EAEC50")]
		private void _FocusToValue(float val)
		{
		}

		// Token: 0x06023F50 RID: 147280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F50")]
		[Address(RVA = "0x1EAEF30", Offset = "0x1EADB30", VA = "0x181EAEF30")]
		public CampaignZoneMapView()
		{
		}

		// Token: 0x04031ECF RID: 204495
		[Token(Token = "0x4031ECF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 MAP_INIT_POS;

		// Token: 0x04031ED0 RID: 204496
		[Token(Token = "0x4031ED0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignZoneMapStageNodeView _prefabStageNode;

		// Token: 0x04031ED1 RID: 204497
		[Token(Token = "0x4031ED1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _stageNodeContainer;

		// Token: 0x04031ED2 RID: 204498
		[Token(Token = "0x4031ED2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Focus")]
		private RectTransform _focusBound;

		// Token: 0x04031ED3 RID: 204499
		[Token(Token = "0x4031ED3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Focus")]
		private RectTransform _mapRoot;

		// Token: 0x04031ED4 RID: 204500
		[Token(Token = "0x4031ED4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Focus")]
		private float _duration;

		// Token: 0x04031ED5 RID: 204501
		[Token(Token = "0x4031ED5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Focus")]
		private Ease _ease;

		// Token: 0x04031ED6 RID: 204502
		[Token(Token = "0x4031ED6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04031ED7 RID: 204503
		[Token(Token = "0x4031ED7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031ED8 RID: 204504
		[Token(Token = "0x4031ED8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _rewardTrackPoint;

		// Token: 0x04031ED9 RID: 204505
		[Token(Token = "0x4031ED9")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04031EDA RID: 204506
		[Token(Token = "0x4031EDA")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, CampaignZoneMapStageViewModel> m_cachedStageModelDict;

		// Token: 0x04031EDB RID: 204507
		[Token(Token = "0x4031EDB")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedSelectedStageId;

		// Token: 0x04031EDC RID: 204508
		[Token(Token = "0x4031EDC")]
		[FieldOffset(Offset = "0x80")]
		private CampaignZoneMapView.StageNodeViewPool m_stageNodePool;

		// Token: 0x04031EDD RID: 204509
		[Token(Token = "0x4031EDD")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04031EDE RID: 204510
		[Token(Token = "0x4031EDE")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_focusTween;

		// Token: 0x04031EDF RID: 204511
		[Token(Token = "0x4031EDF")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedZoneId;

		// Token: 0x04031EE0 RID: 204512
		[Token(Token = "0x4031EE0")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_rewardTrack;

		// Token: 0x04031EE1 RID: 204513
		[Token(Token = "0x4031EE1")]
		[FieldOffset(Offset = "0xA8")]
		private int m_cachedSequenceNum;

		// Token: 0x04031EE2 RID: 204514
		[Token(Token = "0x4031EE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031EE3 RID: 204515
		[Token(Token = "0x4031EE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnJumpBtnClicked;

		// Token: 0x04031EE4 RID: 204516
		[Token(Token = "0x4031EE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackBkgClicked;

		// Token: 0x04031EE5 RID: 204517
		[Token(Token = "0x4031EE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04031EE6 RID: 204518
		[Token(Token = "0x4031EE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FocusToStage;

		// Token: 0x04031EE7 RID: 204519
		[Token(Token = "0x4031EE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FocusToValue;

		// Token: 0x04031EE8 RID: 204520
		[Token(Token = "0x4031EE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006149 RID: 24905
		[Token(Token = "0x2006149")]
		private class StageNodeViewPool : GameObjectDictPool<CampaignZoneMapStageNodeView>, IHotfixable
		{
			// Token: 0x06023F52 RID: 147282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F52")]
			[Address(RVA = "0x1EB28B0", Offset = "0x1EB14B0", VA = "0x181EB28B0")]
			public StageNodeViewPool(CampaignZoneMapView closure)
			{
			}

			// Token: 0x06023F53 RID: 147283 RVA: 0x000C27D8 File Offset: 0x000C09D8
			[Token(Token = "0x6023F53")]
			[Address(RVA = "0x1EB23A0", Offset = "0x1EB0FA0", VA = "0x181EB23A0", Slot = "5")]
			protected override bool ContainsKey(string key)
			{
				return default(bool);
			}

			// Token: 0x06023F54 RID: 147284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023F54")]
			[Address(RVA = "0x1EB26A0", Offset = "0x1EB12A0", VA = "0x181EB26A0", Slot = "6")]
			protected override IEnumerable<string> IterKeys()
			{
				return null;
			}

			// Token: 0x06023F55 RID: 147285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023F55")]
			[Address(RVA = "0x1EB24C0", Offset = "0x1EB10C0", VA = "0x181EB24C0", Slot = "7")]
			protected override CampaignZoneMapStageNodeView GetPrefab(string key)
			{
				return null;
			}

			// Token: 0x06023F56 RID: 147286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023F56")]
			[Address(RVA = "0x1EB25C0", Offset = "0x1EB11C0", VA = "0x181EB25C0", Slot = "8")]
			protected override CampaignZoneMapStageNodeView Instantiate(string key, CampaignZoneMapStageNodeView prefab)
			{
				return null;
			}

			// Token: 0x06023F57 RID: 147287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F57")]
			[Address(RVA = "0x1EB2750", Offset = "0x1EB1350", VA = "0x181EB2750", Slot = "9")]
			protected override void Render(string key, CampaignZoneMapStageNodeView obj)
			{
			}

			// Token: 0x04031EE9 RID: 204521
			[Token(Token = "0x4031EE9")]
			[FieldOffset(Offset = "0x20")]
			private CampaignZoneMapView m_closure;

			// Token: 0x04031EEA RID: 204522
			[Token(Token = "0x4031EEA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031EEB RID: 204523
			[Token(Token = "0x4031EEB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ContainsKey;

			// Token: 0x04031EEC RID: 204524
			[Token(Token = "0x4031EEC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IterKeys;

			// Token: 0x04031EED RID: 204525
			[Token(Token = "0x4031EED")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04031EEE RID: 204526
			[Token(Token = "0x4031EEE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Instantiate;

			// Token: 0x04031EEF RID: 204527
			[Token(Token = "0x4031EEF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_Render;
		}

		// Token: 0x0200614B RID: 24907
		[Token(Token = "0x200614B")]
		private class RewardTrackViewModel : ITrackPointModel, IHotfixable
		{
			// Token: 0x06023F61 RID: 147297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F61")]
			[Address(RVA = "0x1EB1D30", Offset = "0x1EB0930", VA = "0x181EB1D30", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x170054DE RID: 21726
			// (get) Token: 0x06023F62 RID: 147298 RVA: 0x000C2808 File Offset: 0x000C0A08
			// (set) Token: 0x06023F63 RID: 147299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170054DE")]
			public bool isShow
			{
				[Token(Token = "0x6023F62")]
				[Address(RVA = "0x1EB1E80", Offset = "0x1EB0A80", VA = "0x181EB1E80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6023F63")]
				[Address(RVA = "0x1EB1EE0", Offset = "0x1EB0AE0", VA = "0x181EB1EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06023F64 RID: 147300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023F64")]
			[Address(RVA = "0x1EB1E20", Offset = "0x1EB0A20", VA = "0x181EB1E20")]
			public RewardTrackViewModel()
			{
			}

			// Token: 0x04031EF6 RID: 204534
			[Token(Token = "0x4031EF6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04031EF7 RID: 204535
			[Token(Token = "0x4031EF7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04031EF8 RID: 204536
			[Token(Token = "0x4031EF8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x04031EF9 RID: 204537
			[Token(Token = "0x4031EF9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200614C RID: 24908
			[Token(Token = "0x200614C")]
			public class Input
			{
				// Token: 0x06023F65 RID: 147301 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6023F65")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Input()
				{
				}

				// Token: 0x04031EFA RID: 204538
				[Token(Token = "0x4031EFA")]
				[FieldOffset(Offset = "0x10")]
				public bool isShow;
			}
		}
	}
}
