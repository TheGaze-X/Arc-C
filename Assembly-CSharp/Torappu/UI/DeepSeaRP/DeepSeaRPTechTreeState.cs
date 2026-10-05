using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200517E RID: 20862
	[Token(Token = "0x200517E")]
	public class DeepSeaRPTechTreeState : PopupFadeState
	{
		// Token: 0x0601ED38 RID: 126264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED38")]
		[Address(RVA = "0x189ADF0", Offset = "0x18999F0", VA = "0x18189ADF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ED39 RID: 126265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED39")]
		[Address(RVA = "0x189AE50", Offset = "0x1899A50", VA = "0x18189AE50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ED3A RID: 126266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED3A")]
		[Address(RVA = "0x189C710", Offset = "0x189B310", VA = "0x18189C710")]
		private void _TryTriggerAVG()
		{
		}

		// Token: 0x0601ED3B RID: 126267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED3B")]
		[Address(RVA = "0x189BFE0", Offset = "0x189ABE0", VA = "0x18189BFE0")]
		private IEnumerator _TriggerAVGCoro()
		{
			return null;
		}

		// Token: 0x0601ED3C RID: 126268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED3C")]
		[Address(RVA = "0x189ABE0", Offset = "0x18997E0", VA = "0x18189ABE0")]
		public void EventOnExit()
		{
		}

		// Token: 0x0601ED3D RID: 126269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED3D")]
		[Address(RVA = "0x189B350", Offset = "0x1899F50", VA = "0x18189B350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ED3E RID: 126270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED3E")]
		[Address(RVA = "0x189BB30", Offset = "0x189A730", VA = "0x18189BB30")]
		private void _SaveEdits()
		{
		}

		// Token: 0x0601ED3F RID: 126271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED3F")]
		[Address(RVA = "0x189B8A0", Offset = "0x189A4A0", VA = "0x18189B8A0")]
		private void _OnSaveCompleted()
		{
		}

		// Token: 0x0601ED40 RID: 126272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ED40")]
		[Address(RVA = "0x189B2A0", Offset = "0x1899EA0", VA = "0x18189B2A0")]
		private IEnumerator _CoShowSavedLogo()
		{
			return null;
		}

		// Token: 0x0601ED41 RID: 126273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED41")]
		[Address(RVA = "0x189BDF0", Offset = "0x189A9F0", VA = "0x18189BDF0")]
		private void _StartCoShowSavedLogo()
		{
		}

		// Token: 0x0601ED42 RID: 126274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED42")]
		[Address(RVA = "0x189B1C0", Offset = "0x1899DC0", VA = "0x18189B1C0")]
		private void _ClearCoShowSavedLogo()
		{
		}

		// Token: 0x0601ED43 RID: 126275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED43")]
		[Address(RVA = "0x189B130", Offset = "0x1899D30", VA = "0x18189B130")]
		private void _BreakSavedLogoShowing()
		{
		}

		// Token: 0x0601ED44 RID: 126276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED44")]
		[Address(RVA = "0x189B060", Offset = "0x1899C60", VA = "0x18189B060")]
		private void _ActiveTechNode(string techId)
		{
		}

		// Token: 0x0601ED45 RID: 126277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED45")]
		[Address(RVA = "0x189B7A0", Offset = "0x189A3A0", VA = "0x18189B7A0")]
		private void _OnActiveTechNodeCompleted(string techId)
		{
		}

		// Token: 0x0601ED46 RID: 126278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED46")]
		[Address(RVA = "0x189BC10", Offset = "0x189A810", VA = "0x18189BC10")]
		private void _SetTechNode(string techId)
		{
		}

		// Token: 0x0601ED47 RID: 126279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED47")]
		[Address(RVA = "0x189C9B0", Offset = "0x189B5B0", VA = "0x18189C9B0")]
		private void _UnsetTechNode(string techId)
		{
		}

		// Token: 0x0601ED48 RID: 126280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED48")]
		[Address(RVA = "0x189BF50", Offset = "0x189AB50", VA = "0x18189BF50")]
		private void _SwitchTechBranch(string techId)
		{
		}

		// Token: 0x0601ED49 RID: 126281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED49")]
		[Address(RVA = "0x189C3F0", Offset = "0x189AFF0", VA = "0x18189C3F0")]
		private void _TryChangeBranches(Action onComplete)
		{
		}

		// Token: 0x0601ED4A RID: 126282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED4A")]
		[Address(RVA = "0x189C070", Offset = "0x189AC70", VA = "0x18189C070")]
		private void _TryActiveTechTreeNode(string treeId, Action<string> onComplete)
		{
		}

		// Token: 0x0601ED4B RID: 126283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED4B")]
		[Address(RVA = "0x189CAC0", Offset = "0x189B6C0", VA = "0x18189CAC0")]
		public DeepSeaRPTechTreeState()
		{
		}

		// Token: 0x0601ED4D RID: 126285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED4D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04029597 RID: 169367
		[Token(Token = "0x4029597")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04029598 RID: 169368
		[Token(Token = "0x4029598")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DeepSeaRPTechTreeView _view;

		// Token: 0x04029599 RID: 169369
		[Token(Token = "0x4029599")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402959A RID: 169370
		[Token(Token = "0x402959A")]
		[FieldOffset(Offset = "0x88")]
		private DeepSeaRPTechTreeStateBean m_stateBean;

		// Token: 0x0402959B RID: 169371
		[Token(Token = "0x402959B")]
		private const float SAVED_LOGO_SHOWING_DUR = 0.5f;

		// Token: 0x0402959C RID: 169372
		[Token(Token = "0x402959C")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_coSavedLogoShow;

		// Token: 0x0402959D RID: 169373
		[Token(Token = "0x402959D")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isSavedShowing;

		// Token: 0x0402959E RID: 169374
		[Token(Token = "0x402959E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402959F RID: 169375
		[Token(Token = "0x402959F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040295A0 RID: 169376
		[Token(Token = "0x40295A0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryTriggerAVG;

		// Token: 0x040295A1 RID: 169377
		[Token(Token = "0x40295A1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TriggerAVGCoro;

		// Token: 0x040295A2 RID: 169378
		[Token(Token = "0x40295A2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnExit;

		// Token: 0x040295A3 RID: 169379
		[Token(Token = "0x40295A3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040295A4 RID: 169380
		[Token(Token = "0x40295A4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SaveEdits;

		// Token: 0x040295A5 RID: 169381
		[Token(Token = "0x40295A5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSaveCompleted;

		// Token: 0x040295A6 RID: 169382
		[Token(Token = "0x40295A6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CoShowSavedLogo;

		// Token: 0x040295A7 RID: 169383
		[Token(Token = "0x40295A7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StartCoShowSavedLogo;

		// Token: 0x040295A8 RID: 169384
		[Token(Token = "0x40295A8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearCoShowSavedLogo;

		// Token: 0x040295A9 RID: 169385
		[Token(Token = "0x40295A9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__BreakSavedLogoShowing;

		// Token: 0x040295AA RID: 169386
		[Token(Token = "0x40295AA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ActiveTechNode;

		// Token: 0x040295AB RID: 169387
		[Token(Token = "0x40295AB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnActiveTechNodeCompleted;

		// Token: 0x040295AC RID: 169388
		[Token(Token = "0x40295AC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetTechNode;

		// Token: 0x040295AD RID: 169389
		[Token(Token = "0x40295AD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UnsetTechNode;

		// Token: 0x040295AE RID: 169390
		[Token(Token = "0x40295AE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SwitchTechBranch;

		// Token: 0x040295AF RID: 169391
		[Token(Token = "0x40295AF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TryChangeBranches;

		// Token: 0x040295B0 RID: 169392
		[Token(Token = "0x40295B0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryActiveTechTreeNode;

		// Token: 0x040295B1 RID: 169393
		[Token(Token = "0x40295B1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
