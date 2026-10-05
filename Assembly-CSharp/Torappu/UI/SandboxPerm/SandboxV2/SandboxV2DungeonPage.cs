using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041DB RID: 16859
	[Token(Token = "0x20041DB")]
	public class SandboxV2DungeonPage : StateEnginePage, ISandboxV2TopicIdHolder, IMobileTouchPage, IHotfixable, ISandboxV2DialogHolder
	{
		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0601A021 RID: 106529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DF8")]
		public string topicId
		{
			[Token(Token = "0x601A021")]
			[Address(RVA = "0x12EF490", Offset = "0x12EE090", VA = "0x1812EF490")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0601A022 RID: 106530 RVA: 0x0009FFA8 File Offset: 0x0009E1A8
		[Token(Token = "0x17003DF9")]
		public bool isMonth
		{
			[Token(Token = "0x601A022")]
			[Address(RVA = "0x12EF350", Offset = "0x12EDF50", VA = "0x1812EF350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0601A023 RID: 106531 RVA: 0x0009FFC0 File Offset: 0x0009E1C0
		[Token(Token = "0x17003DFA")]
		public bool fromReadArchive
		{
			[Token(Token = "0x601A023")]
			[Address(RVA = "0x12EF2C0", Offset = "0x12EDEC0", VA = "0x1812EF2C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0601A024 RID: 106532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DFB")]
		public string monthlyRushId
		{
			[Token(Token = "0x601A024")]
			[Address(RVA = "0x12EF3F0", Offset = "0x12EDFF0", VA = "0x1812EF3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0601A025 RID: 106533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003DFC")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x601A025")]
			[Address(RVA = "0x12EF260", Offset = "0x12EDE60", VA = "0x1812EF260", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A026 RID: 106534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A026")]
		[Address(RVA = "0x12EE260", Offset = "0x12ECE60", VA = "0x1812EE260")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A027 RID: 106535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A027")]
		[Address(RVA = "0x12EDD10", Offset = "0x12EC910", VA = "0x1812EDD10")]
		public void SetCameraActiveByStateTransition(bool active, Type stateType)
		{
		}

		// Token: 0x0601A028 RID: 106536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A028")]
		[Address(RVA = "0x12EE700", Offset = "0x12ED300", VA = "0x1812EE700")]
		private void _SetCameraActive(bool active, SandboxV2DungeonPage.CameraActiveSrc src)
		{
		}

		// Token: 0x0601A029 RID: 106537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A029")]
		[Address(RVA = "0x12EE160", Offset = "0x12ECD60", VA = "0x1812EE160")]
		private void _DisplayDungeon(bool isShow)
		{
		}

		// Token: 0x0601A02A RID: 106538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A02A")]
		[Address(RVA = "0x12EE420", Offset = "0x12ED020", VA = "0x1812EE420")]
		private void _ReloadDungeon(bool isFromStack)
		{
		}

		// Token: 0x0601A02B RID: 106539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A02B")]
		[Address(RVA = "0x12ED810", Offset = "0x12EC410", VA = "0x1812ED810", Slot = "29")]
		public string GetTopicId()
		{
			return null;
		}

		// Token: 0x0601A02C RID: 106540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A02C")]
		[Address(RVA = "0x12ED920", Offset = "0x12EC520", VA = "0x1812ED920", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601A02D RID: 106541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A02D")]
		[Address(RVA = "0x12EDC40", Offset = "0x12EC840", VA = "0x1812EDC40", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0601A02E RID: 106542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A02E")]
		[Address(RVA = "0x12ED870", Offset = "0x12EC470", VA = "0x1812ED870", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601A02F RID: 106543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A02F")]
		[Address(RVA = "0x12EE650", Offset = "0x12ED250", VA = "0x1812EE650")]
		private IEnumerator _RouteToMonthModeState()
		{
			return null;
		}

		// Token: 0x0601A030 RID: 106544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A030")]
		[Address(RVA = "0x12EE560", Offset = "0x12ED160", VA = "0x1812EE560")]
		private IEnumerator _RouteToCrossDayPage(bool isReadArchive, bool isRiftSettle, bool isChallengeSettle)
		{
			return null;
		}

		// Token: 0x0601A031 RID: 106545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A031")]
		[Address(RVA = "0x12ED6B0", Offset = "0x12EC2B0", VA = "0x1812ED6B0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601A032 RID: 106546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A032")]
		[Address(RVA = "0x12ED5D0", Offset = "0x12EC1D0", VA = "0x1812ED5D0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601A033 RID: 106547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A033")]
		[Address(RVA = "0x12EDB20", Offset = "0x12EC720", VA = "0x1812EDB20", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601A034 RID: 106548 RVA: 0x0009FFD8 File Offset: 0x0009E1D8
		[Token(Token = "0x601A034")]
		[Address(RVA = "0x12ED460", Offset = "0x12EC060", VA = "0x1812ED460", Slot = "18")]
		public override bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601A035 RID: 106549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A035")]
		[Address(RVA = "0x12EDFB0", Offset = "0x12ECBB0", VA = "0x1812EDFB0")]
		private void _ClearDungeonIfNecessary()
		{
		}

		// Token: 0x0601A036 RID: 106550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A036")]
		[Address(RVA = "0x12EECF0", Offset = "0x12ED8F0", VA = "0x1812EECF0")]
		private void _TrySendTutorialOnlyLoadArchiveRequest(string topicId)
		{
		}

		// Token: 0x0601A037 RID: 106551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A037")]
		[Address(RVA = "0x12EE7C0", Offset = "0x12ED3C0", VA = "0x1812EE7C0")]
		private void _TriggerSandboxV2BGM()
		{
		}

		// Token: 0x0601A038 RID: 106552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A038")]
		[Address(RVA = "0x12EDED0", Offset = "0x12ECAD0", VA = "0x1812EDED0")]
		private void _ClearBGM()
		{
		}

		// Token: 0x0601A039 RID: 106553 RVA: 0x0009FFF0 File Offset: 0x0009E1F0
		[Token(Token = "0x601A039")]
		[Address(RVA = "0x12EE200", Offset = "0x12ECE00", VA = "0x1812EE200")]
		private int _GetBGMInstId()
		{
			return 0;
		}

		// Token: 0x0601A03A RID: 106554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A03A")]
		[Address(RVA = "0x12EEC00", Offset = "0x12ED800", VA = "0x1812EEC00")]
		private void _TriggerTutorial()
		{
		}

		// Token: 0x0601A03B RID: 106555 RVA: 0x000A0008 File Offset: 0x0009E208
		[Token(Token = "0x601A03B")]
		[Address(RVA = "0x12EEF90", Offset = "0x12EDB90", VA = "0x1812EEF90")]
		private bool _ValidateSandboxV2GuideQuest(string topicId, Story story)
		{
			return default(bool);
		}

		// Token: 0x0601A03C RID: 106556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A03C")]
		[Address(RVA = "0x12EEA40", Offset = "0x12ED640", VA = "0x1812EEA40")]
		private void _TriggerSandboxV2DungeonGuideQuest()
		{
		}

		// Token: 0x0601A03D RID: 106557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A03D")]
		[Address(RVA = "0x12EE340", Offset = "0x12ECF40", VA = "0x1812EE340")]
		private void _OnSandboxV2DungeonGuideQuestCompleted(Story story)
		{
		}

		// Token: 0x0601A03E RID: 106558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A03E")]
		[Address(RVA = "0x12ED780", Offset = "0x12EC380", VA = "0x1812ED780", Slot = "30")]
		public void EnableMobileTouch(bool enable)
		{
		}

		// Token: 0x0601A03F RID: 106559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A03F")]
		[Address(RVA = "0x12EF190", Offset = "0x12EDD90", VA = "0x1812EF190")]
		public SandboxV2DungeonPage()
		{
		}

		// Token: 0x0601A045 RID: 106565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A045")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601A046 RID: 106566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A046")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0601A047 RID: 106567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A047")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601A048 RID: 106568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A048")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0601A049 RID: 106569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A049")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0601A04A RID: 106570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A04A")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0601A04B RID: 106571 RVA: 0x000A0068 File Offset: 0x0009E268
		[Token(Token = "0x601A04B")]
		[Address(RVA = "0x1071280", Offset = "0x106FE80", VA = "0x181071280")]
		private bool <>xLuaBaseProxy_CustomSetActive(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04020C18 RID: 134168
		[Token(Token = "0x4020C18")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SandboxV2DungeonController _dungeonController;

		// Token: 0x04020C19 RID: 134169
		[Token(Token = "0x4020C19")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SandboxV2DungeonCameraController _cameraController;

		// Token: 0x04020C1A RID: 134170
		[Token(Token = "0x4020C1A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SandboxV2DungeonAVGAdapter _avgAdapter;

		// Token: 0x04020C1B RID: 134171
		[Token(Token = "0x4020C1B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private GameObject _cameraHolder;

		// Token: 0x04020C1C RID: 134172
		[Token(Token = "0x4020C1C")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject _cameraUIHolder;

		// Token: 0x04020C1D RID: 134173
		[Token(Token = "0x4020C1D")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private CanvasGroup[] _rootCanvasGroups;

		// Token: 0x04020C1E RID: 134174
		[Token(Token = "0x4020C1E")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private CanvasGroup _canvasUI;

		// Token: 0x04020C1F RID: 134175
		[Token(Token = "0x4020C1F")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CanvasGroup _canvasMask;

		// Token: 0x04020C20 RID: 134176
		[Token(Token = "0x4020C20")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04020C21 RID: 134177
		[Token(Token = "0x4020C21")]
		[FieldOffset(Offset = "0x138")]
		private bool m_inited;

		// Token: 0x04020C22 RID: 134178
		[Token(Token = "0x4020C22")]
		[FieldOffset(Offset = "0x140")]
		private SandboxV2DungeonPage.Param m_param;

		// Token: 0x04020C23 RID: 134179
		[Token(Token = "0x4020C23")]
		[FieldOffset(Offset = "0x148")]
		private DataBundle m_savedInst;

		// Token: 0x04020C24 RID: 134180
		[Token(Token = "0x4020C24")]
		[FieldOffset(Offset = "0x150")]
		private UISwitchTween m_maskShowTween;

		// Token: 0x04020C25 RID: 134181
		[Token(Token = "0x4020C25")]
		[FieldOffset(Offset = "0x158")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04020C26 RID: 134182
		[Token(Token = "0x4020C26")]
		[FieldOffset(Offset = "0x160")]
		private bool m_skipDungeonPage;

		// Token: 0x04020C27 RID: 134183
		[Token(Token = "0x4020C27")]
		[FieldOffset(Offset = "0x164")]
		private int m_cachedDungeonDay;

		// Token: 0x04020C28 RID: 134184
		[Token(Token = "0x4020C28")]
		[FieldOffset(Offset = "0x168")]
		private long m_cachedDungeonReadArchiveTs;

		// Token: 0x04020C29 RID: 134185
		[Token(Token = "0x4020C29")]
		[FieldOffset(Offset = "0x170")]
		private List<Type> m_cameraActiveHandlers;

		// Token: 0x04020C2A RID: 134186
		[Token(Token = "0x4020C2A")]
		[FieldOffset(Offset = "0x178")]
		private int m_cameraInactiveFlag;

		// Token: 0x04020C2B RID: 134187
		[Token(Token = "0x4020C2B")]
		[FieldOffset(Offset = "0x17C")]
		private bool m_isPlayerDataReady;

		// Token: 0x04020C2C RID: 134188
		[Token(Token = "0x4020C2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020C2D RID: 134189
		[Token(Token = "0x4020C2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isMonth;

		// Token: 0x04020C2E RID: 134190
		[Token(Token = "0x4020C2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fromReadArchive;

		// Token: 0x04020C2F RID: 134191
		[Token(Token = "0x4020C2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_monthlyRushId;

		// Token: 0x04020C30 RID: 134192
		[Token(Token = "0x4020C30")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04020C31 RID: 134193
		[Token(Token = "0x4020C31")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020C32 RID: 134194
		[Token(Token = "0x4020C32")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetCameraActiveByStateTransition;

		// Token: 0x04020C33 RID: 134195
		[Token(Token = "0x4020C33")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetCameraActive;

		// Token: 0x04020C34 RID: 134196
		[Token(Token = "0x4020C34")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DisplayDungeon;

		// Token: 0x04020C35 RID: 134197
		[Token(Token = "0x4020C35")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReloadDungeon;

		// Token: 0x04020C36 RID: 134198
		[Token(Token = "0x4020C36")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetTopicId;

		// Token: 0x04020C37 RID: 134199
		[Token(Token = "0x4020C37")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04020C38 RID: 134200
		[Token(Token = "0x4020C38")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04020C39 RID: 134201
		[Token(Token = "0x4020C39")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04020C3A RID: 134202
		[Token(Token = "0x4020C3A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RouteToMonthModeState;

		// Token: 0x04020C3B RID: 134203
		[Token(Token = "0x4020C3B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RouteToCrossDayPage;

		// Token: 0x04020C3C RID: 134204
		[Token(Token = "0x4020C3C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04020C3D RID: 134205
		[Token(Token = "0x4020C3D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x04020C3E RID: 134206
		[Token(Token = "0x4020C3E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04020C3F RID: 134207
		[Token(Token = "0x4020C3F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04020C40 RID: 134208
		[Token(Token = "0x4020C40")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ClearDungeonIfNecessary;

		// Token: 0x04020C41 RID: 134209
		[Token(Token = "0x4020C41")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TrySendTutorialOnlyLoadArchiveRequest;

		// Token: 0x04020C42 RID: 134210
		[Token(Token = "0x4020C42")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TriggerSandboxV2BGM;

		// Token: 0x04020C43 RID: 134211
		[Token(Token = "0x4020C43")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearBGM;

		// Token: 0x04020C44 RID: 134212
		[Token(Token = "0x4020C44")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetBGMInstId;

		// Token: 0x04020C45 RID: 134213
		[Token(Token = "0x4020C45")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TriggerTutorial;

		// Token: 0x04020C46 RID: 134214
		[Token(Token = "0x4020C46")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ValidateSandboxV2GuideQuest;

		// Token: 0x04020C47 RID: 134215
		[Token(Token = "0x4020C47")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__TriggerSandboxV2DungeonGuideQuest;

		// Token: 0x04020C48 RID: 134216
		[Token(Token = "0x4020C48")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__OnSandboxV2DungeonGuideQuestCompleted;

		// Token: 0x04020C49 RID: 134217
		[Token(Token = "0x4020C49")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_EnableMobileTouch;

		// Token: 0x04020C4A RID: 134218
		[Token(Token = "0x4020C4A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041DC RID: 16860
		[Token(Token = "0x20041DC")]
		public class Param
		{
			// Token: 0x0601A04C RID: 106572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A04C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04020C4B RID: 134219
			[Token(Token = "0x4020C4B")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04020C4C RID: 134220
			[Token(Token = "0x4020C4C")]
			[FieldOffset(Offset = "0x18")]
			public bool isMonth;
		}

		// Token: 0x020041DD RID: 16861
		[Token(Token = "0x20041DD")]
		public enum CameraActiveSrc
		{
			// Token: 0x04020C4E RID: 134222
			[Token(Token = "0x4020C4E")]
			SRC_PAGE_SHOW,
			// Token: 0x04020C4F RID: 134223
			[Token(Token = "0x4020C4F")]
			SRC_STATE_TRANSITION,
			// Token: 0x04020C50 RID: 134224
			[Token(Token = "0x4020C50")]
			SRC_CUSTOM_SET_ACTIVE
		}
	}
}
