using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005621 RID: 22049
	[Token(Token = "0x2005621")]
	public class RL05DungeonSpZoneView : RoguelikeDungeonZoneViewBase
	{
		// Token: 0x060205B9 RID: 132537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205B9")]
		[Address(RVA = "0x1A792C0", Offset = "0x1A77EC0", VA = "0x181A792C0", Slot = "8")]
		protected override void OnInit(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x060205BA RID: 132538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205BA")]
		[Address(RVA = "0x1A795D0", Offset = "0x1A781D0", VA = "0x181A795D0", Slot = "9")]
		protected override void OnViewDestroy(RoguelikeDungeonController controller)
		{
		}

		// Token: 0x060205BB RID: 132539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205BB")]
		[Address(RVA = "0x1A78B70", Offset = "0x1A77770", VA = "0x181A78B70", Slot = "11")]
		protected override void CreateZone()
		{
		}

		// Token: 0x060205BC RID: 132540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205BC")]
		[Address(RVA = "0x1A796D0", Offset = "0x1A782D0", VA = "0x181A796D0", Slot = "12")]
		protected override void RenderZone()
		{
		}

		// Token: 0x060205BD RID: 132541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205BD")]
		[Address(RVA = "0x1A79500", Offset = "0x1A78100", VA = "0x181A79500", Slot = "10")]
		protected override void OnSetShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x060205BE RID: 132542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205BE")]
		[Address(RVA = "0x1A79210", Offset = "0x1A77E10", VA = "0x181A79210", Slot = "13")]
		public override IRoguelikeDungeonNodeView GetViewByNode(RoguelikeDungeonNode node)
		{
			return null;
		}

		// Token: 0x060205BF RID: 132543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205BF")]
		[Address(RVA = "0x1A78B10", Offset = "0x1A77710", VA = "0x181A78B10", Slot = "14")]
		public override void CleanNodeEffect()
		{
		}

		// Token: 0x060205C0 RID: 132544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205C0")]
		[Address(RVA = "0x1A7B3D0", Offset = "0x1A79FD0", VA = "0x181A7B3D0")]
		private void _OnDungeonShowAfterTrans(object arg)
		{
		}

		// Token: 0x060205C1 RID: 132545 RVA: 0x000B5890 File Offset: 0x000B3A90
		[Token(Token = "0x60205C1")]
		[Address(RVA = "0x1A7AFC0", Offset = "0x1A79BC0", VA = "0x181A7AFC0")]
		private int _GetMaxDepth(string topicId, RoguelikeDungeonZone curZone)
		{
			return 0;
		}

		// Token: 0x060205C2 RID: 132546 RVA: 0x000B58A8 File Offset: 0x000B3AA8
		[Token(Token = "0x60205C2")]
		[Address(RVA = "0x1A7AE20", Offset = "0x1A79A20", VA = "0x181A7AE20")]
		private int _GetDepthOffset()
		{
			return 0;
		}

		// Token: 0x060205C3 RID: 132547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205C3")]
		[Address(RVA = "0x1A7C170", Offset = "0x1A7AD70", VA = "0x181A7C170")]
		private void _RenderLines(RoguelikeDungeonZone dungeonZone)
		{
		}

		// Token: 0x060205C4 RID: 132548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205C4")]
		[Address(RVA = "0x1A79AA0", Offset = "0x1A786A0", VA = "0x181A79AA0")]
		private void _DealWithNodeAllRelates(RoguelikeDungeonNode parentNode, RL05SpecialZoneNodeContainer parentNodeContainer, List<RoguelikeDungeonLine> dungeonLines)
		{
		}

		// Token: 0x060205C5 RID: 132549 RVA: 0x000B58C0 File Offset: 0x000B3AC0
		[Token(Token = "0x60205C5")]
		[Address(RVA = "0x1A7C9A0", Offset = "0x1A7B5A0", VA = "0x181A7C9A0")]
		private bool _TryToGetRectTransLinkedNodes(RoguelikeDungeonNode parentNode, RoguelikeDungeonNode childNode, RL05SpecialZoneNodeContainer parentNodeContainer, RL05SpecialZoneNodeContainer childNodeContainer, out RectTransform parentRectTransform, out RectTransform childRectTransform)
		{
			return default(bool);
		}

		// Token: 0x060205C6 RID: 132550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205C6")]
		[Address(RVA = "0x1A79F00", Offset = "0x1A78B00", VA = "0x181A79F00")]
		private RL05DungeonSpZoneView.RL05SpecialZoneLine _FindOrCreateLine(RoguelikeDungeonNode parentNode, RoguelikeDungeonNode childNode, RectTransform parentRectTransform, RectTransform childRectTransform)
		{
			return null;
		}

		// Token: 0x060205C7 RID: 132551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205C7")]
		[Address(RVA = "0x1A7AE90", Offset = "0x1A79A90", VA = "0x181A7AE90")]
		private string _GetLineKey(RoguelikeDungeonNode node1, RoguelikeDungeonNode node2)
		{
			return null;
		}

		// Token: 0x060205C8 RID: 132552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205C8")]
		[Address(RVA = "0x1A7B2C0", Offset = "0x1A79EC0", VA = "0x181A7B2C0")]
		private void _MoveRectTransformWithOffset(float offset, ref RectTransform rectTransform)
		{
		}

		// Token: 0x060205C9 RID: 132553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205C9")]
		[Address(RVA = "0x1A7B4A0", Offset = "0x1A7A0A0", VA = "0x181A7B4A0")]
		private void _OnNodeClicked(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x060205CA RID: 132554 RVA: 0x000B58D8 File Offset: 0x000B3AD8
		[Token(Token = "0x60205CA")]
		[Address(RVA = "0x1A798A0", Offset = "0x1A784A0", VA = "0x181A798A0")]
		private Bounds _CalcWorldBoundsOfOffsetRectTransform(RoguelikeDungeonController controller, RectTransform rectTransform, Vector2 focusScreenPoint)
		{
			return default(Bounds);
		}

		// Token: 0x060205CB RID: 132555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205CB")]
		[Address(RVA = "0x1A7CC80", Offset = "0x1A7B880", VA = "0x181A7CC80")]
		private void _TryToResetCameraToCenter()
		{
		}

		// Token: 0x060205CC RID: 132556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205CC")]
		[Address(RVA = "0x1A7BF40", Offset = "0x1A7AB40", VA = "0x181A7BF40")]
		private void _RenderFocusCursor(RoguelikeDungeonZone curZone)
		{
		}

		// Token: 0x060205CD RID: 132557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205CD")]
		[Address(RVA = "0x1A7BB10", Offset = "0x1A7A710", VA = "0x181A7BB10")]
		private void _PlayZoneEnterAnimation()
		{
		}

		// Token: 0x060205CE RID: 132558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205CE")]
		[Address(RVA = "0x1A7B0F0", Offset = "0x1A79CF0", VA = "0x181A7B0F0")]
		private RoguelikeDungeonNode _GetZoneStartNode()
		{
			return null;
		}

		// Token: 0x060205CF RID: 132559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205CF")]
		[Address(RVA = "0x1A7C550", Offset = "0x1A7B150", VA = "0x181A7C550")]
		private void _SetAllNodesAndLinesShow(bool isShow)
		{
		}

		// Token: 0x060205D0 RID: 132560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205D0")]
		[Address(RVA = "0x1A7A9C0", Offset = "0x1A795C0", VA = "0x181A7A9C0")]
		private void _GeneNodesDistanceToStartNode(RoguelikeDungeonNode startNode, out List<List<RL05SpecialZoneNodeContainer>> nodeDistanceList)
		{
		}

		// Token: 0x060205D1 RID: 132561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205D1")]
		[Address(RVA = "0x1A7A550", Offset = "0x1A79150", VA = "0x181A7A550")]
		private void _GeneLinesDistanceToStartNode(RoguelikeDungeonNode startNode, out List<List<RL05SpecialZoneLineView>> lineDistanceList)
		{
		}

		// Token: 0x060205D2 RID: 132562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60205D2")]
		[Address(RVA = "0x1A7C8A0", Offset = "0x1A7B4A0", VA = "0x181A7C8A0")]
		private IEnumerator _ShowZoneEnterCoroutine(List<List<RL05SpecialZoneNodeContainer>> nodeDistanceList, List<List<RL05SpecialZoneLineView>> lineDistanceList)
		{
			return null;
		}

		// Token: 0x060205D3 RID: 132563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205D3")]
		[Address(RVA = "0x1A7CF10", Offset = "0x1A7BB10", VA = "0x181A7CF10")]
		public RL05DungeonSpZoneView()
		{
		}

		// Token: 0x060205D4 RID: 132564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60205D4")]
		[Address(RVA = "0x1A79890", Offset = "0x1A78490", VA = "0x181A79890")]
		private void <>xLuaBaseProxy_OnViewDestroy(RoguelikeDungeonController P0)
		{
		}

		// Token: 0x0402BCB8 RID: 179384
		[Token(Token = "0x402BCB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("line")]
		private RectTransform _lineBlurContainer;

		// Token: 0x0402BCB9 RID: 179385
		[Token(Token = "0x402BCB9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("line")]
		private RectTransform _lineContainer;

		// Token: 0x0402BCBA RID: 179386
		[Token(Token = "0x402BCBA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("line")]
		private RL05SpecialZoneLineView _lineViewPrefab;

		// Token: 0x0402BCBB RID: 179387
		[Token(Token = "0x402BCBB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("line")]
		private Color _colorValid;

		// Token: 0x0402BCBC RID: 179388
		[Token(Token = "0x402BCBC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("line")]
		private Color _colorValidBlur;

		// Token: 0x0402BCBD RID: 179389
		[Token(Token = "0x402BCBD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("line")]
		private Color _colorInvalid;

		// Token: 0x0402BCBE RID: 179390
		[Token(Token = "0x402BCBE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("line")]
		private Color _colorInvalidBlur;

		// Token: 0x0402BCBF RID: 179391
		[Token(Token = "0x402BCBF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("line")]
		private float _lineBlurOffset;

		// Token: 0x0402BCC0 RID: 179392
		[Token(Token = "0x402BCC0")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Group("node")]
		private float _topPadding;

		// Token: 0x0402BCC1 RID: 179393
		[Token(Token = "0x402BCC1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("node")]
		private float _spacingX;

		// Token: 0x0402BCC2 RID: 179394
		[Token(Token = "0x402BCC2")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Group("node")]
		private float _spacingY;

		// Token: 0x0402BCC3 RID: 179395
		[Token(Token = "0x402BCC3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("node")]
		private RectTransform _nodeContainer;

		// Token: 0x0402BCC4 RID: 179396
		[Token(Token = "0x402BCC4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RL05SpecialZoneNodeContainer _nodeContainerPrefab;

		// Token: 0x0402BCC5 RID: 179397
		[Token(Token = "0x402BCC5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _panelCursor;

		// Token: 0x0402BCC6 RID: 179398
		[Token(Token = "0x402BCC6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _cursorGroup;

		// Token: 0x0402BCC7 RID: 179399
		[Token(Token = "0x402BCC7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Transform _localTrans;

		// Token: 0x0402BCC8 RID: 179400
		[Token(Token = "0x402BCC8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup _canvasNodeGroup;

		// Token: 0x0402BCC9 RID: 179401
		[Token(Token = "0x402BCC9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float _focusBlockLeft;

		// Token: 0x0402BCCA RID: 179402
		[Token(Token = "0x402BCCA")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private float _focusBlockRight;

		// Token: 0x0402BCCB RID: 179403
		[Token(Token = "0x402BCCB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RoguelikeFocusNodeView _focusNodeView;

		// Token: 0x0402BCCC RID: 179404
		[Token(Token = "0x402BCCC")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _enterAnimDelay;

		// Token: 0x0402BCCD RID: 179405
		[Token(Token = "0x402BCCD")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<string, RL05SpecialZoneNodeContainer> m_nodeContainers;

		// Token: 0x0402BCCE RID: 179406
		[Token(Token = "0x402BCCE")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<string, RL05DungeonSpZoneView.RL05SpecialZoneLine> m_lines;

		// Token: 0x0402BCCF RID: 179407
		[Token(Token = "0x402BCCF")]
		[FieldOffset(Offset = "0x120")]
		private HashSet<string> m_validLineKeys;

		// Token: 0x0402BCD0 RID: 179408
		[Token(Token = "0x402BCD0")]
		[FieldOffset(Offset = "0x128")]
		private int m_cacheMaxDepth;

		// Token: 0x0402BCD1 RID: 179409
		[Token(Token = "0x402BCD1")]
		[FieldOffset(Offset = "0x12C")]
		private int m_cacheMaxIndex;

		// Token: 0x0402BCD2 RID: 179410
		[Token(Token = "0x402BCD2")]
		[FieldOffset(Offset = "0x130")]
		private int m_cacheDepthOffset;

		// Token: 0x0402BCD3 RID: 179411
		[Token(Token = "0x402BCD3")]
		[FieldOffset(Offset = "0x138")]
		private UISwitchTween m_nodeSwitchTween;

		// Token: 0x0402BCD4 RID: 179412
		[Token(Token = "0x402BCD4")]
		[FieldOffset(Offset = "0x140")]
		private FadeSwitchTween m_cursorFadeSwitchTween;

		// Token: 0x0402BCD5 RID: 179413
		[Token(Token = "0x402BCD5")]
		[FieldOffset(Offset = "0x148")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BCD6 RID: 179414
		[Token(Token = "0x402BCD6")]
		[FieldOffset(Offset = "0x158")]
		private Coroutine m_enterCoroutine;

		// Token: 0x0402BCD7 RID: 179415
		[Token(Token = "0x402BCD7")]
		[FieldOffset(Offset = "0x160")]
		private bool m_isEnterAnimPlaying;

		// Token: 0x0402BCD8 RID: 179416
		[Token(Token = "0x402BCD8")]
		[FieldOffset(Offset = "0x168")]
		private LatchUtils.InvokeWhenUnlock m_invokeWhenRendered;

		// Token: 0x0402BCD9 RID: 179417
		[Token(Token = "0x402BCD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402BCDA RID: 179418
		[Token(Token = "0x402BCDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewDestroy;

		// Token: 0x0402BCDB RID: 179419
		[Token(Token = "0x402BCDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateZone;

		// Token: 0x0402BCDC RID: 179420
		[Token(Token = "0x402BCDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderZone;

		// Token: 0x0402BCDD RID: 179421
		[Token(Token = "0x402BCDD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSetShow;

		// Token: 0x0402BCDE RID: 179422
		[Token(Token = "0x402BCDE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetViewByNode;

		// Token: 0x0402BCDF RID: 179423
		[Token(Token = "0x402BCDF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CleanNodeEffect;

		// Token: 0x0402BCE0 RID: 179424
		[Token(Token = "0x402BCE0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnDungeonShowAfterTrans;

		// Token: 0x0402BCE1 RID: 179425
		[Token(Token = "0x402BCE1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetMaxDepth;

		// Token: 0x0402BCE2 RID: 179426
		[Token(Token = "0x402BCE2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetDepthOffset;

		// Token: 0x0402BCE3 RID: 179427
		[Token(Token = "0x402BCE3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderLines;

		// Token: 0x0402BCE4 RID: 179428
		[Token(Token = "0x402BCE4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DealWithNodeAllRelates;

		// Token: 0x0402BCE5 RID: 179429
		[Token(Token = "0x402BCE5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TryToGetRectTransLinkedNodes;

		// Token: 0x0402BCE6 RID: 179430
		[Token(Token = "0x402BCE6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FindOrCreateLine;

		// Token: 0x0402BCE7 RID: 179431
		[Token(Token = "0x402BCE7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetLineKey;

		// Token: 0x0402BCE8 RID: 179432
		[Token(Token = "0x402BCE8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__MoveRectTransformWithOffset;

		// Token: 0x0402BCE9 RID: 179433
		[Token(Token = "0x402BCE9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnNodeClicked;

		// Token: 0x0402BCEA RID: 179434
		[Token(Token = "0x402BCEA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CalcWorldBoundsOfOffsetRectTransform;

		// Token: 0x0402BCEB RID: 179435
		[Token(Token = "0x402BCEB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryToResetCameraToCenter;

		// Token: 0x0402BCEC RID: 179436
		[Token(Token = "0x402BCEC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RenderFocusCursor;

		// Token: 0x0402BCED RID: 179437
		[Token(Token = "0x402BCED")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__PlayZoneEnterAnimation;

		// Token: 0x0402BCEE RID: 179438
		[Token(Token = "0x402BCEE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetZoneStartNode;

		// Token: 0x0402BCEF RID: 179439
		[Token(Token = "0x402BCEF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SetAllNodesAndLinesShow;

		// Token: 0x0402BCF0 RID: 179440
		[Token(Token = "0x402BCF0")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GeneNodesDistanceToStartNode;

		// Token: 0x0402BCF1 RID: 179441
		[Token(Token = "0x402BCF1")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GeneLinesDistanceToStartNode;

		// Token: 0x0402BCF2 RID: 179442
		[Token(Token = "0x402BCF2")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ShowZoneEnterCoroutine;

		// Token: 0x0402BCF3 RID: 179443
		[Token(Token = "0x402BCF3")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005622 RID: 22050
		[Token(Token = "0x2005622")]
		private class RL05SpecialZoneLine : IHotfixable
		{
			// Token: 0x060205D5 RID: 132565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60205D5")]
			[Address(RVA = "0x1A84FE0", Offset = "0x1A83BE0", VA = "0x181A84FE0")]
			public void RenderView(bool isDisable, RoguelikeDungeonNode dungeonNodeStart, RoguelikeDungeonNode dungeonNodeEnd)
			{
			}

			// Token: 0x060205D6 RID: 132566 RVA: 0x000B58F0 File Offset: 0x000B3AF0
			[Token(Token = "0x60205D6")]
			[Address(RVA = "0x1A84EA0", Offset = "0x1A83AA0", VA = "0x181A84EA0")]
			public int GetDistanceToStartNode(RoguelikeDungeonNode startNode)
			{
				return 0;
			}

			// Token: 0x060205D7 RID: 132567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60205D7")]
			[Address(RVA = "0x1A851A0", Offset = "0x1A83DA0", VA = "0x181A851A0")]
			public RL05SpecialZoneLine()
			{
			}

			// Token: 0x0402BCF4 RID: 179444
			[Token(Token = "0x402BCF4")]
			[FieldOffset(Offset = "0x10")]
			public string lineKey;

			// Token: 0x0402BCF5 RID: 179445
			[Token(Token = "0x402BCF5")]
			[FieldOffset(Offset = "0x18")]
			public RL05SpecialZoneLineView lineView;

			// Token: 0x0402BCF6 RID: 179446
			[Token(Token = "0x402BCF6")]
			[FieldOffset(Offset = "0x20")]
			public RL05SpecialZoneLineView lineBlurView;

			// Token: 0x0402BCF7 RID: 179447
			[Token(Token = "0x402BCF7")]
			[FieldOffset(Offset = "0x28")]
			public int startDepth;

			// Token: 0x0402BCF8 RID: 179448
			[Token(Token = "0x402BCF8")]
			[FieldOffset(Offset = "0x2C")]
			public int endDepth;

			// Token: 0x0402BCF9 RID: 179449
			[Token(Token = "0x402BCF9")]
			[FieldOffset(Offset = "0x30")]
			public int startIndex;

			// Token: 0x0402BCFA RID: 179450
			[Token(Token = "0x402BCFA")]
			[FieldOffset(Offset = "0x34")]
			public int endIndex;

			// Token: 0x0402BCFB RID: 179451
			[Token(Token = "0x402BCFB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402BCFC RID: 179452
			[Token(Token = "0x402BCFC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetDistanceToStartNode;

			// Token: 0x0402BCFD RID: 179453
			[Token(Token = "0x402BCFD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
