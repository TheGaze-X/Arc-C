using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048B5 RID: 18613
	[Token(Token = "0x20048B5")]
	public class StartMissionSimpleView : MissionSinglePage
	{
		// Token: 0x0601C143 RID: 115011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C143")]
		[Address(RVA = "0x1573160", Offset = "0x1571D60", VA = "0x181573160")]
		private void Awake()
		{
		}

		// Token: 0x0601C144 RID: 115012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C144")]
		[Address(RVA = "0x1573410", Offset = "0x1572010", VA = "0x181573410")]
		public void OnMissionGroupButtonPressed()
		{
		}

		// Token: 0x0601C145 RID: 115013 RVA: 0x000A7280 File Offset: 0x000A5480
		[Token(Token = "0x601C145")]
		[Address(RVA = "0x1573330", Offset = "0x1571F30", VA = "0x181573330", Slot = "4")]
		public override bool IsToBeShown(MissionModel stateBean)
		{
			return default(bool);
		}

		// Token: 0x0601C146 RID: 115014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C146")]
		[Address(RVA = "0x15734A0", Offset = "0x15720A0", VA = "0x1815734A0", Slot = "5")]
		protected override void RefreshView()
		{
		}

		// Token: 0x0601C147 RID: 115015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C147")]
		[Address(RVA = "0x15741B0", Offset = "0x1572DB0", VA = "0x1815741B0")]
		private void _RenderBtnResFullOpen()
		{
		}

		// Token: 0x0601C148 RID: 115016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C148")]
		[Address(RVA = "0x15744E0", Offset = "0x15730E0", VA = "0x1815744E0")]
		private void _RenderEmptyView(bool isMissionLock, bool isFullOpenAndAllComplete)
		{
		}

		// Token: 0x0601C149 RID: 115017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C149")]
		[Address(RVA = "0x1574B20", Offset = "0x1573720", VA = "0x181574B20")]
		private void _RenderNormalView()
		{
		}

		// Token: 0x0601C14A RID: 115018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14A")]
		[Address(RVA = "0x15738C0", Offset = "0x15724C0", VA = "0x1815738C0")]
		private void _InitView()
		{
		}

		// Token: 0x0601C14B RID: 115019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14B")]
		[Address(RVA = "0x1573CF0", Offset = "0x15728F0", VA = "0x181573CF0")]
		private void _RefreshView()
		{
		}

		// Token: 0x0601C14C RID: 115020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14C")]
		[Address(RVA = "0x15746D0", Offset = "0x15732D0", VA = "0x1815746D0")]
		private void _RenderGroupInfo()
		{
		}

		// Token: 0x0601C14D RID: 115021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14D")]
		[Address(RVA = "0x1573760", Offset = "0x1572360", VA = "0x181573760")]
		private void _AdjustGridCellSize(CanvasScaler nullableScaler)
		{
		}

		// Token: 0x0601C14E RID: 115022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14E")]
		[Address(RVA = "0x15731F0", Offset = "0x1571DF0", VA = "0x1815731F0")]
		public void EventOnPreviewOpen()
		{
		}

		// Token: 0x0601C14F RID: 115023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C14F")]
		[Address(RVA = "0x1573290", Offset = "0x1571E90", VA = "0x181573290")]
		public void EventOnResDialogOpen()
		{
		}

		// Token: 0x0601C150 RID: 115024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C150")]
		[Address(RVA = "0x1574C20", Offset = "0x1573820", VA = "0x181574C20")]
		public StartMissionSimpleView()
		{
		}

		// Token: 0x0601C152 RID: 115026 RVA: 0x000A7298 File Offset: 0x000A5498
		[Token(Token = "0x601C152")]
		[Address(RVA = "0x1564210", Offset = "0x1562E10", VA = "0x181564210")]
		private bool <>xLuaBaseProxy_IsToBeShown(MissionModel P0)
		{
			return default(bool);
		}

		// Token: 0x0601C153 RID: 115027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C153")]
		[Address(RVA = "0x1564280", Offset = "0x1562E80", VA = "0x181564280")]
		private void <>xLuaBaseProxy_RefreshView()
		{
		}

		// Token: 0x04024AFD RID: 150269
		[Token(Token = "0x4024AFD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _normalPartGo;

		// Token: 0x04024AFE RID: 150270
		[Token(Token = "0x4024AFE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x04024AFF RID: 150271
		[Token(Token = "0x4024AFF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _allCompleteInfoGo;

		// Token: 0x04024B00 RID: 150272
		[Token(Token = "0x4024B00")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _unlockInfoGo;

		// Token: 0x04024B01 RID: 150273
		[Token(Token = "0x4024B01")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Full Open")]
		private GameObject _fullOpenUnavailGo;

		// Token: 0x04024B02 RID: 150274
		[Token(Token = "0x4024B02")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Full Open")]
		private GameObject _fullOpenAvailGo;

		// Token: 0x04024B03 RID: 150275
		[Token(Token = "0x4024B03")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Full Open")]
		private GameObject _fullOpenRemainGo;

		// Token: 0x04024B04 RID: 150276
		[Token(Token = "0x4024B04")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Full Open")]
		private Text _textFullOpenRemainTime;

		// Token: 0x04024B05 RID: 150277
		[Token(Token = "0x4024B05")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Full Open")]
		private GameObject _fullOpenActiveTimeGo;

		// Token: 0x04024B06 RID: 150278
		[Token(Token = "0x4024B06")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Full Open")]
		private GameObject _fullOpenPauseTimeGo;

		// Token: 0x04024B07 RID: 150279
		[Token(Token = "0x4024B07")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Full Open")]
		private Color _colorFullOpenActiveTime;

		// Token: 0x04024B08 RID: 150280
		[Token(Token = "0x4024B08")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Full Open")]
		private Color _colorFullOpenPauseTime;

		// Token: 0x04024B09 RID: 150281
		[Token(Token = "0x4024B09")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textUnlockTitle;

		// Token: 0x04024B0A RID: 150282
		[Token(Token = "0x4024B0A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textUnlockDesc;

		// Token: 0x04024B0B RID: 150283
		[Token(Token = "0x4024B0B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _taskContainer;

		// Token: 0x04024B0C RID: 150284
		[Token(Token = "0x4024B0C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private StartMissionTaskStart _tagObj;

		// Token: 0x04024B0D RID: 150285
		[Token(Token = "0x4024B0D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _missionText;

		// Token: 0x04024B0E RID: 150286
		[Token(Token = "0x4024B0E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private MissionRewardPreviewItem _rewardItem;

		// Token: 0x04024B0F RID: 150287
		[Token(Token = "0x4024B0F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _maskContainer;

		// Token: 0x04024B10 RID: 150288
		[Token(Token = "0x4024B10")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _missionGroupButton;

		// Token: 0x04024B11 RID: 150289
		[Token(Token = "0x4024B11")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _unfinishedBgPanel;

		// Token: 0x04024B12 RID: 150290
		[Token(Token = "0x4024B12")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _unfinishedPanel;

		// Token: 0x04024B13 RID: 150291
		[Token(Token = "0x4024B13")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _finishedBgPanel;

		// Token: 0x04024B14 RID: 150292
		[Token(Token = "0x4024B14")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _finishedPanel;

		// Token: 0x04024B15 RID: 150293
		[Token(Token = "0x4024B15")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private StartMissionSimpleView.TextGroupWithPadding _phaseRewardCountLabelGroup;

		// Token: 0x04024B16 RID: 150294
		[Token(Token = "0x4024B16")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text[] _phaseRewardNameLabels;

		// Token: 0x04024B17 RID: 150295
		[Token(Token = "0x4024B17")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x04024B18 RID: 150296
		[Token(Token = "0x4024B18")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private RectTransform _rectContainer;

		// Token: 0x04024B19 RID: 150297
		[Token(Token = "0x4024B19")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 cellSizeDefault;

		// Token: 0x04024B1A RID: 150298
		[Token(Token = "0x4024B1A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 cellSizeExpand;

		// Token: 0x04024B1B RID: 150299
		[Token(Token = "0x4024B1B")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isFirstRender;

		// Token: 0x04024B1C RID: 150300
		[Token(Token = "0x4024B1C")]
		[FieldOffset(Offset = "0x128")]
		private MissionGroup m_missionGroup;

		// Token: 0x04024B1D RID: 150301
		[Token(Token = "0x4024B1D")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<string, StartMissionTaskStart> m_missionTasks;

		// Token: 0x04024B1E RID: 150302
		[Token(Token = "0x4024B1E")]
		[FieldOffset(Offset = "0x138")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024B1F RID: 150303
		[Token(Token = "0x4024B1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04024B20 RID: 150304
		[Token(Token = "0x4024B20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMissionGroupButtonPressed;

		// Token: 0x04024B21 RID: 150305
		[Token(Token = "0x4024B21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsToBeShown;

		// Token: 0x04024B22 RID: 150306
		[Token(Token = "0x4024B22")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04024B23 RID: 150307
		[Token(Token = "0x4024B23")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderBtnResFullOpen;

		// Token: 0x04024B24 RID: 150308
		[Token(Token = "0x4024B24")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderEmptyView;

		// Token: 0x04024B25 RID: 150309
		[Token(Token = "0x4024B25")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderNormalView;

		// Token: 0x04024B26 RID: 150310
		[Token(Token = "0x4024B26")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x04024B27 RID: 150311
		[Token(Token = "0x4024B27")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x04024B28 RID: 150312
		[Token(Token = "0x4024B28")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderGroupInfo;

		// Token: 0x04024B29 RID: 150313
		[Token(Token = "0x4024B29")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AdjustGridCellSize;

		// Token: 0x04024B2A RID: 150314
		[Token(Token = "0x4024B2A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnPreviewOpen;

		// Token: 0x04024B2B RID: 150315
		[Token(Token = "0x4024B2B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnResDialogOpen;

		// Token: 0x04024B2C RID: 150316
		[Token(Token = "0x4024B2C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048B6 RID: 18614
		[Token(Token = "0x20048B6")]
		[Serializable]
		public class TextGroupWithPadding
		{
			// Token: 0x0601C154 RID: 115028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C154")]
			[Address(RVA = "0x15759D0", Offset = "0x15745D0", VA = "0x1815759D0")]
			public void Init()
			{
			}

			// Token: 0x0601C155 RID: 115029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C155")]
			[Address(RVA = "0x1575F10", Offset = "0x1574B10", VA = "0x181575F10")]
			private void _RefreshPhaseRewardCountLabelsFitter(string content)
			{
			}

			// Token: 0x0601C156 RID: 115030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C156")]
			[Address(RVA = "0x1575C60", Offset = "0x1574860", VA = "0x181575C60")]
			public void Setup(string content)
			{
			}

			// Token: 0x0601C157 RID: 115031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C157")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TextGroupWithPadding()
			{
			}

			// Token: 0x04024B2D RID: 150317
			[Token(Token = "0x4024B2D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text[] _labels;

			// Token: 0x04024B2E RID: 150318
			[Token(Token = "0x4024B2E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float[] _stringLengthPaddingConfigs;

			// Token: 0x04024B2F RID: 150319
			[Token(Token = "0x4024B2F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private int _rewardCountLabelAutoSizeFitLengthThreshold;

			// Token: 0x04024B30 RID: 150320
			[Token(Token = "0x4024B30")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _manualSizeLength;

			// Token: 0x04024B31 RID: 150321
			[Token(Token = "0x4024B31")]
			[FieldOffset(Offset = "0x28")]
			private float[] m_labelBasicOffsets;

			// Token: 0x04024B32 RID: 150322
			[Token(Token = "0x4024B32")]
			[FieldOffset(Offset = "0x30")]
			private ContentSizeFitter[] m_rewardCountContentFitters;
		}
	}
}
