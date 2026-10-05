using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004258 RID: 16984
	[Token(Token = "0x2004258")]
	public abstract class SandboxV2AbstractNodeView : MonoBehaviour, IAsyncDataView<SandboxV2AbstractNodeView.RenderParam>, IAsyncShowEffect, IHotfixable
	{
		// Token: 0x0601A2D5 RID: 107221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D5")]
		[Address(RVA = "0x13170F0", Offset = "0x1315CF0", VA = "0x1813170F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D6")]
		[Address(RVA = "0x1317570", Offset = "0x1316170", VA = "0x181317570")]
		private void _ResetNodeUnlockFx()
		{
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D7")]
		[Address(RVA = "0x1317180", Offset = "0x1315D80", VA = "0x181317180")]
		private void _OnNodeStateChanged(SandboxV2NodeState srcState, SandboxV2NodeState dstState, bool fastMode, TweenCallback renderFunc)
		{
		}

		// Token: 0x0601A2D8 RID: 107224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D8")]
		[Address(RVA = "0x1316550", Offset = "0x1315150", VA = "0x181316550", Slot = "4")]
		public void AsyncSetData(SandboxV2AbstractNodeView.RenderParam param)
		{
		}

		// Token: 0x0601A2D9 RID: 107225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2D9")]
		[Address(RVA = "0x1316CC0", Offset = "0x13158C0", VA = "0x181316CC0", Slot = "6")]
		protected virtual void DoOnInit()
		{
		}

		// Token: 0x0601A2DA RID: 107226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2DA")]
		[Address(RVA = "0x1316DA0", Offset = "0x13159A0", VA = "0x181316DA0", Slot = "7")]
		protected virtual void DoOnRecycle()
		{
		}

		// Token: 0x0601A2DB RID: 107227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2DB")]
		[Address(RVA = "0x1316F30", Offset = "0x1315B30", VA = "0x181316F30", Slot = "8")]
		protected virtual void DoRenderPermanentData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2DC RID: 107228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2DC")]
		[Address(RVA = "0x1316E30", Offset = "0x1315A30", VA = "0x181316E30", Slot = "9")]
		protected virtual void DoRenderBasicData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2DD RID: 107229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2DD")]
		[Address(RVA = "0x1316EB0", Offset = "0x1315AB0", VA = "0x181316EB0", Slot = "10")]
		protected virtual void DoRenderData(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2DE RID: 107230
		[Token(Token = "0x601A2DE")]
		protected abstract SandboxV2EnterAnimTween InitEnterAnim(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel);

		// Token: 0x0601A2DF RID: 107231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2DF")]
		[Address(RVA = "0x1316C60", Offset = "0x1315860", VA = "0x181316C60", Slot = "5")]
		public void AsyncShow()
		{
		}

		// Token: 0x0601A2E0 RID: 107232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E0")]
		[Address(RVA = "0x1317000", Offset = "0x1315C00", VA = "0x181317000")]
		public void OnNodeClicked()
		{
		}

		// Token: 0x0601A2E1 RID: 107233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E1")]
		[Address(RVA = "0x13176B0", Offset = "0x13162B0", VA = "0x1813176B0")]
		private void _TutorialOnly_RegisterNode()
		{
		}

		// Token: 0x0601A2E2 RID: 107234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2E2")]
		[Address(RVA = "0x1317790", Offset = "0x1316390", VA = "0x181317790")]
		protected SandboxV2AbstractNodeView()
		{
		}

		// Token: 0x04021172 RID: 135538
		[Token(Token = "0x4021172")]
		private const string PANEL_UNLOCK_FX_ANIM_NAME = "sandboxv2_dungeon_node_unlock";

		// Token: 0x04021173 RID: 135539
		[Token(Token = "0x4021173")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _hotspotGo;

		// Token: 0x04021174 RID: 135540
		[Token(Token = "0x4021174")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _showHandler;

		// Token: 0x04021175 RID: 135541
		[Token(Token = "0x4021175")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Unlock Fx")]
		private AnimationWrapper _unlockFxPrefab;

		// Token: 0x04021176 RID: 135542
		[Token(Token = "0x4021176")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Unlock Fx")]
		private RectTransform _unlockFxHolder;

		// Token: 0x04021177 RID: 135543
		[Token(Token = "0x4021177")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Unlock Fx")]
		private CanvasGroup _unlockFxAlphaHandler;

		// Token: 0x04021178 RID: 135544
		[Token(Token = "0x4021178")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Unlock Fx")]
		private float _unlockFxHideOffset;

		// Token: 0x04021179 RID: 135545
		[Token(Token = "0x4021179")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Unlock Fx")]
		private float _unlockFxShowOffset;

		// Token: 0x0402117A RID: 135546
		[Token(Token = "0x402117A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Unlock Fx")]
		private float _unlockFxFadeDuration;

		// Token: 0x0402117B RID: 135547
		[Token(Token = "0x402117B")]
		[FieldOffset(Offset = "0x50")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonConstructChecker;

		// Token: 0x0402117C RID: 135548
		[Token(Token = "0x402117C")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_dungeonDataChangeChecker;

		// Token: 0x0402117D RID: 135549
		[Token(Token = "0x402117D")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_enterAnimChecker;

		// Token: 0x0402117E RID: 135550
		[Token(Token = "0x402117E")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonViewModel.SeqNumChecker m_nodeRegisterChecker;

		// Token: 0x0402117F RID: 135551
		[Token(Token = "0x402117F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x04021180 RID: 135552
		[Token(Token = "0x4021180")]
		[FieldOffset(Offset = "0x94")]
		private SandboxV2NodeState m_cachedNodeState;

		// Token: 0x04021181 RID: 135553
		[Token(Token = "0x4021181")]
		[FieldOffset(Offset = "0x98")]
		private SandboxV2EnterAnimTween m_enterAnimTween;

		// Token: 0x04021182 RID: 135554
		[Token(Token = "0x4021182")]
		[FieldOffset(Offset = "0xA0")]
		private FadeSwitchTween m_showTween;

		// Token: 0x04021183 RID: 135555
		[Token(Token = "0x4021183")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_asyncShown;

		// Token: 0x04021184 RID: 135556
		[Token(Token = "0x4021184")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationWrapper m_unlockFx;

		// Token: 0x04021185 RID: 135557
		[Token(Token = "0x4021185")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_unlockTween;

		// Token: 0x04021186 RID: 135558
		[Token(Token = "0x4021186")]
		[FieldOffset(Offset = "0xC0")]
		protected UIPageFinder pageFinder;

		// Token: 0x04021187 RID: 135559
		[Token(Token = "0x4021187")]
		[FieldOffset(Offset = "0xD0")]
		protected string nodeId;

		// Token: 0x04021188 RID: 135560
		[Token(Token = "0x4021188")]
		[FieldOffset(Offset = "0xD8")]
		protected string topicId;

		// Token: 0x04021189 RID: 135561
		[Token(Token = "0x4021189")]
		[FieldOffset(Offset = "0xE0")]
		protected SandboxV2DungeonViewConfig dungeonViewConfig;

		// Token: 0x0402118A RID: 135562
		[Token(Token = "0x402118A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402118B RID: 135563
		[Token(Token = "0x402118B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ResetNodeUnlockFx;

		// Token: 0x0402118C RID: 135564
		[Token(Token = "0x402118C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnNodeStateChanged;

		// Token: 0x0402118D RID: 135565
		[Token(Token = "0x402118D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AsyncSetData;

		// Token: 0x0402118E RID: 135566
		[Token(Token = "0x402118E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoOnInit;

		// Token: 0x0402118F RID: 135567
		[Token(Token = "0x402118F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoOnRecycle;

		// Token: 0x04021190 RID: 135568
		[Token(Token = "0x4021190")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoRenderPermanentData;

		// Token: 0x04021191 RID: 135569
		[Token(Token = "0x4021191")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoRenderBasicData;

		// Token: 0x04021192 RID: 135570
		[Token(Token = "0x4021192")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoRenderData;

		// Token: 0x04021193 RID: 135571
		[Token(Token = "0x4021193")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_AsyncShow;

		// Token: 0x04021194 RID: 135572
		[Token(Token = "0x4021194")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnNodeClicked;

		// Token: 0x04021195 RID: 135573
		[Token(Token = "0x4021195")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TutorialOnly_RegisterNode;

		// Token: 0x04021196 RID: 135574
		[Token(Token = "0x4021196")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004259 RID: 16985
		[Token(Token = "0x2004259")]
		public struct RenderParam
		{
			// Token: 0x04021197 RID: 135575
			[Token(Token = "0x4021197")]
			[FieldOffset(Offset = "0x0")]
			public string nodeId;

			// Token: 0x04021198 RID: 135576
			[Token(Token = "0x4021198")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2DungeonViewModel dungeonViewModel;
		}
	}
}
