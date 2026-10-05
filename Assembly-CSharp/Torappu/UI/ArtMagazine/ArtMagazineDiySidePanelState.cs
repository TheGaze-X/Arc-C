using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200655E RID: 25950
	[Token(Token = "0x200655E")]
	public abstract class ArtMagazineDiySidePanelState : State
	{
		// Token: 0x06025510 RID: 152848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025510")]
		[Address(RVA = "0x204F910", Offset = "0x204E510", VA = "0x18204F910", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06025511 RID: 152849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025511")]
		[Address(RVA = "0x204F9C0", Offset = "0x204E5C0", VA = "0x18204F9C0", Slot = "20")]
		public override ITransAction PickDynamicTransAction(State otherState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x06025512 RID: 152850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025512")]
		[Address(RVA = "0x204FCA0", Offset = "0x204E8A0", VA = "0x18204FCA0")]
		private void _SetRootCanvasShow(bool isShow, bool fastMode)
		{
		}

		// Token: 0x06025513 RID: 152851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025513")]
		[Address(RVA = "0x204FB80", Offset = "0x204E780", VA = "0x18204FB80")]
		private void _InitSwitchTweenIfNot()
		{
		}

		// Token: 0x06025514 RID: 152852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025514")]
		[Address(RVA = "0x204F8B0", Offset = "0x204E4B0", VA = "0x18204F8B0", Slot = "23")]
		protected virtual void BeforeInTransition()
		{
		}

		// Token: 0x06025515 RID: 152853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025515")]
		[Address(RVA = "0x204FE80", Offset = "0x204EA80", VA = "0x18204FE80")]
		protected ArtMagazineDiySidePanelState()
		{
		}

		// Token: 0x06025516 RID: 152854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025516")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x06025517 RID: 152855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025517")]
		[Address(RVA = "0xF97A90", Offset = "0xF96690", VA = "0x180F97A90")]
		private ITransAction <>xLuaBaseProxy_PickDynamicTransAction(State P0, TransitionType P1)
		{
			return null;
		}

		// Token: 0x040345AB RID: 214443
		[Token(Token = "0x40345AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _rootCanvas;

		// Token: 0x040345AC RID: 214444
		[Token(Token = "0x40345AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x040345AD RID: 214445
		[Token(Token = "0x40345AD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Ease _fadeEase;

		// Token: 0x040345AE RID: 214446
		[Token(Token = "0x40345AE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ArtMagazineDiyPage.LeafViewDisplayOptions _displayOptions;

		// Token: 0x040345AF RID: 214447
		[Token(Token = "0x40345AF")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_switchTween;

		// Token: 0x040345B0 RID: 214448
		[Token(Token = "0x40345B0")]
		[FieldOffset(Offset = "0x78")]
		private ArtMagazineDiySidePanelState.OutTransition m_outTransition;

		// Token: 0x040345B1 RID: 214449
		[Token(Token = "0x40345B1")]
		[FieldOffset(Offset = "0x80")]
		private ArtMagazineDiySidePanelState.InTransition m_inTransition;

		// Token: 0x040345B2 RID: 214450
		[Token(Token = "0x40345B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x040345B3 RID: 214451
		[Token(Token = "0x40345B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PickDynamicTransAction;

		// Token: 0x040345B4 RID: 214452
		[Token(Token = "0x40345B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetRootCanvasShow;

		// Token: 0x040345B5 RID: 214453
		[Token(Token = "0x40345B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitSwitchTweenIfNot;

		// Token: 0x040345B6 RID: 214454
		[Token(Token = "0x40345B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeforeInTransition;

		// Token: 0x040345B7 RID: 214455
		[Token(Token = "0x40345B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200655F RID: 25951
		[Token(Token = "0x200655F")]
		private class OutTransition : ITransAction
		{
			// Token: 0x06025518 RID: 152856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025518")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OutTransition(ArtMagazineDiySidePanelState closure)
			{
			}

			// Token: 0x17005819 RID: 22553
			// (get) Token: 0x06025519 RID: 152857 RVA: 0x000C7710 File Offset: 0x000C5910
			[Token(Token = "0x17005819")]
			public TransActionType ActionType
			{
				[Token(Token = "0x6025519")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x0602551A RID: 152858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602551A")]
			[Address(RVA = "0x2055B20", Offset = "0x2054720", VA = "0x182055B20", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x0602551B RID: 152859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602551B")]
			[Address(RVA = "0x2055A80", Offset = "0x2054680", VA = "0x182055A80", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x040345B8 RID: 214456
			[Token(Token = "0x40345B8")]
			[FieldOffset(Offset = "0x10")]
			private ArtMagazineDiySidePanelState m_closure;
		}

		// Token: 0x02006560 RID: 25952
		[Token(Token = "0x2006560")]
		private class InTransition : ITransAction
		{
			// Token: 0x0602551C RID: 152860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602551C")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public InTransition(ArtMagazineDiySidePanelState closure)
			{
			}

			// Token: 0x1700581A RID: 22554
			// (get) Token: 0x0602551D RID: 152861 RVA: 0x000C7728 File Offset: 0x000C5928
			[Token(Token = "0x1700581A")]
			public TransActionType ActionType
			{
				[Token(Token = "0x602551D")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x0602551E RID: 152862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602551E")]
			[Address(RVA = "0x2054780", Offset = "0x2053380", VA = "0x182054780", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x0602551F RID: 152863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602551F")]
			[Address(RVA = "0x20546A0", Offset = "0x20532A0", VA = "0x1820546A0", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x040345B9 RID: 214457
			[Token(Token = "0x40345B9")]
			[FieldOffset(Offset = "0x10")]
			private ArtMagazineDiySidePanelState m_closure;
		}
	}
}
