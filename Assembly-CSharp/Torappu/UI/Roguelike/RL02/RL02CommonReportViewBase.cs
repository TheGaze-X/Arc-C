using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005749 RID: 22345
	[Token(Token = "0x2005749")]
	public abstract class RL02CommonReportViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x06020BDB RID: 134107 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BDA RID: 134106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CC5")]
		public Action prevViewAction
		{
			[Token(Token = "0x6020BDB")]
			[Address(RVA = "0x1B073C0", Offset = "0x1B05FC0", VA = "0x181B073C0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020BDA")]
			[Address(RVA = "0x1B07580", Offset = "0x1B06180", VA = "0x181B07580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004CC6 RID: 19654
		// (get) Token: 0x06020BDD RID: 134109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BDC RID: 134108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CC6")]
		public Action nextViewAction
		{
			[Token(Token = "0x6020BDD")]
			[Address(RVA = "0x1B07360", Offset = "0x1B05F60", VA = "0x181B07360")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020BDC")]
			[Address(RVA = "0x1B07500", Offset = "0x1B06100", VA = "0x181B07500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004CC7 RID: 19655
		// (get) Token: 0x06020BDF RID: 134111 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BDE RID: 134110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CC7")]
		public Action skipAction
		{
			[Token(Token = "0x6020BDF")]
			[Address(RVA = "0x1B07420", Offset = "0x1B06020", VA = "0x181B07420")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020BDE")]
			[Address(RVA = "0x1B07600", Offset = "0x1B06200", VA = "0x181B07600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x06020BE1 RID: 134113 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BE0 RID: 134112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CC8")]
		public Action closeAction
		{
			[Token(Token = "0x6020BE1")]
			[Address(RVA = "0x1B07300", Offset = "0x1B05F00", VA = "0x181B07300")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6020BE0")]
			[Address(RVA = "0x1B07480", Offset = "0x1B06080", VA = "0x181B07480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020BE2 RID: 134114
		[Token(Token = "0x6020BE2")]
		public abstract RL02ReportController.ReportViewType GetViewType();

		// Token: 0x06020BE3 RID: 134115
		[Token(Token = "0x6020BE3")]
		public abstract void Show(RL02EndingFrameReportViewModel viewModel, bool isForward);

		// Token: 0x06020BE4 RID: 134116
		[Token(Token = "0x6020BE4")]
		public abstract IEnumerator Hide();

		// Token: 0x06020BE5 RID: 134117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BE5")]
		[Address(RVA = "0x1B07080", Offset = "0x1B05C80", VA = "0x181B07080")]
		public void EventOnPrevBtnClicked()
		{
		}

		// Token: 0x06020BE6 RID: 134118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BE6")]
		[Address(RVA = "0x1B06F70", Offset = "0x1B05B70", VA = "0x181B06F70")]
		public void EventOnNextBtnClicked()
		{
		}

		// Token: 0x06020BE7 RID: 134119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BE7")]
		[Address(RVA = "0x1B07190", Offset = "0x1B05D90", VA = "0x181B07190")]
		public void EventOnSkipBtnClicked()
		{
		}

		// Token: 0x06020BE8 RID: 134120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BE8")]
		[Address(RVA = "0x1B06E60", Offset = "0x1B05A60", VA = "0x181B06E60")]
		public void EventOnCloseBtnClicked()
		{
		}

		// Token: 0x06020BE9 RID: 134121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BE9")]
		[Address(RVA = "0x1B072A0", Offset = "0x1B05EA0", VA = "0x181B072A0")]
		protected RL02CommonReportViewBase()
		{
		}

		// Token: 0x0402C732 RID: 182066
		[Token(Token = "0x402C732")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_prevViewAction;

		// Token: 0x0402C733 RID: 182067
		[Token(Token = "0x402C733")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_prevViewAction;

		// Token: 0x0402C734 RID: 182068
		[Token(Token = "0x402C734")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_nextViewAction;

		// Token: 0x0402C735 RID: 182069
		[Token(Token = "0x402C735")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nextViewAction;

		// Token: 0x0402C736 RID: 182070
		[Token(Token = "0x402C736")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_skipAction;

		// Token: 0x0402C737 RID: 182071
		[Token(Token = "0x402C737")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_skipAction;

		// Token: 0x0402C738 RID: 182072
		[Token(Token = "0x402C738")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_closeAction;

		// Token: 0x0402C739 RID: 182073
		[Token(Token = "0x402C739")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_closeAction;

		// Token: 0x0402C73A RID: 182074
		[Token(Token = "0x402C73A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClicked;

		// Token: 0x0402C73B RID: 182075
		[Token(Token = "0x402C73B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClicked;

		// Token: 0x0402C73C RID: 182076
		[Token(Token = "0x402C73C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnSkipBtnClicked;

		// Token: 0x0402C73D RID: 182077
		[Token(Token = "0x402C73D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClicked;

		// Token: 0x0402C73E RID: 182078
		[Token(Token = "0x402C73E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
