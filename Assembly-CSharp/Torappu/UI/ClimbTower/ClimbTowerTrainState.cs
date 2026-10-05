using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D36 RID: 23862
	[Token(Token = "0x2005D36")]
	public class ClimbTowerTrainState : PopupFadeState, IHotfixable
	{
		// Token: 0x060228DB RID: 141531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228DB")]
		[Address(RVA = "0x1D2CA50", Offset = "0x1D2B650", VA = "0x181D2CA50", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228DC RID: 141532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228DC")]
		[Address(RVA = "0x1D2CC70", Offset = "0x1D2B870", VA = "0x181D2CC70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228DD RID: 141533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228DD")]
		[Address(RVA = "0x1D2CE40", Offset = "0x1D2BA40", VA = "0x181D2CE40", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060228DE RID: 141534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228DE")]
		[Address(RVA = "0x1D2CDD0", Offset = "0x1D2B9D0", VA = "0x181D2CDD0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x060228DF RID: 141535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228DF")]
		[Address(RVA = "0x1D2CD50", Offset = "0x1D2B950", VA = "0x181D2CD50", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060228E0 RID: 141536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228E0")]
		[Address(RVA = "0x1D2D350", Offset = "0x1D2BF50", VA = "0x181D2D350", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060228E1 RID: 141537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E1")]
		[Address(RVA = "0x1D2D8B0", Offset = "0x1D2C4B0", VA = "0x181D2D8B0")]
		private void _OnJumpToPreview(IStateBean stateBean)
		{
		}

		// Token: 0x060228E2 RID: 141538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E2")]
		[Address(RVA = "0x1D2CAB0", Offset = "0x1D2B6B0", VA = "0x181D2CAB0")]
		public void OnContinueClicked()
		{
		}

		// Token: 0x060228E3 RID: 141539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E3")]
		[Address(RVA = "0x1D2D070", Offset = "0x1D2BC70", VA = "0x181D2D070")]
		public void OnStartClicked()
		{
		}

		// Token: 0x060228E4 RID: 141540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E4")]
		[Address(RVA = "0x1D2DC80", Offset = "0x1D2C880", VA = "0x181D2DC80")]
		private void _TriggerTutorialCoroutine()
		{
		}

		// Token: 0x060228E5 RID: 141541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E5")]
		[Address(RVA = "0x1D2DB00", Offset = "0x1D2C700", VA = "0x181D2DB00")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x060228E6 RID: 141542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228E6")]
		[Address(RVA = "0x1D2DDB0", Offset = "0x1D2C9B0", VA = "0x181D2DDB0")]
		private IEnumerator _WaitAndTrigTutorial()
		{
			return null;
		}

		// Token: 0x060228E7 RID: 141543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E7")]
		[Address(RVA = "0x1D2DBB0", Offset = "0x1D2C7B0", VA = "0x181D2DBB0")]
		private void _TrainTowerGuideEndCallback(Story story)
		{
		}

		// Token: 0x060228E8 RID: 141544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E8")]
		[Address(RVA = "0x1D2D5C0", Offset = "0x1D2C1C0", VA = "0x181D2D5C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228E9 RID: 141545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228E9")]
		[Address(RVA = "0x1D2DA20", Offset = "0x1D2C620", VA = "0x181D2DA20")]
		private void _OnTowerSelected(string towerId)
		{
		}

		// Token: 0x060228EA RID: 141546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228EA")]
		[Address(RVA = "0x1D2D7B0", Offset = "0x1D2C3B0", VA = "0x181D2D7B0")]
		private void _OnDetailClicked(string towerId)
		{
		}

		// Token: 0x060228EB RID: 141547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228EB")]
		[Address(RVA = "0x1D2DE60", Offset = "0x1D2CA60", VA = "0x181D2DE60")]
		public ClimbTowerTrainState()
		{
		}

		// Token: 0x060228ED RID: 141549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228ED")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060228EE RID: 141550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228EE")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060228EF RID: 141551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228EF")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x060228F0 RID: 141552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228F0")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060228F1 RID: 141553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228F1")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F7F7 RID: 194551
		[Token(Token = "0x402F7F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerTrainView _trainView;

		// Token: 0x0402F7F8 RID: 194552
		[Token(Token = "0x402F7F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topContainer;

		// Token: 0x0402F7F9 RID: 194553
		[Token(Token = "0x402F7F9")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0402F7FA RID: 194554
		[Token(Token = "0x402F7FA")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerTrainStateBean m_stateBean;

		// Token: 0x0402F7FB RID: 194555
		[Token(Token = "0x402F7FB")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x0402F7FC RID: 194556
		[Token(Token = "0x402F7FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F7FD RID: 194557
		[Token(Token = "0x402F7FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F7FE RID: 194558
		[Token(Token = "0x402F7FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F7FF RID: 194559
		[Token(Token = "0x402F7FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0402F800 RID: 194560
		[Token(Token = "0x402F800")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0402F801 RID: 194561
		[Token(Token = "0x402F801")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F802 RID: 194562
		[Token(Token = "0x402F802")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnJumpToPreview;

		// Token: 0x0402F803 RID: 194563
		[Token(Token = "0x402F803")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnContinueClicked;

		// Token: 0x0402F804 RID: 194564
		[Token(Token = "0x402F804")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStartClicked;

		// Token: 0x0402F805 RID: 194565
		[Token(Token = "0x402F805")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TriggerTutorialCoroutine;

		// Token: 0x0402F806 RID: 194566
		[Token(Token = "0x402F806")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x0402F807 RID: 194567
		[Token(Token = "0x402F807")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WaitAndTrigTutorial;

		// Token: 0x0402F808 RID: 194568
		[Token(Token = "0x402F808")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__TrainTowerGuideEndCallback;

		// Token: 0x0402F809 RID: 194569
		[Token(Token = "0x402F809")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F80A RID: 194570
		[Token(Token = "0x402F80A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnTowerSelected;

		// Token: 0x0402F80B RID: 194571
		[Token(Token = "0x402F80B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnDetailClicked;

		// Token: 0x0402F80C RID: 194572
		[Token(Token = "0x402F80C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
