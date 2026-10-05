using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004025 RID: 16421
	[Token(Token = "0x2004025")]
	public class SandboxV2CharSelectLogisticsLeftView : SandboxV2AdminCharSelectAbstractLeftView
	{
		// Token: 0x060196B0 RID: 104112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196B0")]
		[Address(RVA = "0x121EC30", Offset = "0x121D830", VA = "0x18121EC30", Slot = "4")]
		public override void RenderView(SandboxV2CharListViewModel charListViewModel, SandboxV2CharSelectTabEnum tabEnum)
		{
		}

		// Token: 0x060196B1 RID: 104113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196B1")]
		[Address(RVA = "0x121F0B0", Offset = "0x121DCB0", VA = "0x18121F0B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060196B2 RID: 104114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196B2")]
		[Address(RVA = "0x121F1D0", Offset = "0x121DDD0", VA = "0x18121F1D0")]
		private void _OnScrollRectTween(float pos)
		{
		}

		// Token: 0x060196B3 RID: 104115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196B3")]
		[Address(RVA = "0x121EB90", Offset = "0x121D790", VA = "0x18121EB90")]
		public void EventOnTipsBtnClick()
		{
		}

		// Token: 0x060196B4 RID: 104116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196B4")]
		[Address(RVA = "0x121F340", Offset = "0x121DF40", VA = "0x18121F340")]
		public SandboxV2CharSelectLogisticsLeftView()
		{
		}

		// Token: 0x0401FA21 RID: 129569
		[Token(Token = "0x401FA21")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _layoutContent;

		// Token: 0x0401FA22 RID: 129570
		[Token(Token = "0x401FA22")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401FA23 RID: 129571
		[Token(Token = "0x401FA23")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _realViewportRectTransform;

		// Token: 0x0401FA24 RID: 129572
		[Token(Token = "0x401FA24")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401FA25 RID: 129573
		[Token(Token = "0x401FA25")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2CharSelectLogisticsLeftView.BuffListAdapter m_buffListAdapter;

		// Token: 0x0401FA26 RID: 129574
		[Token(Token = "0x401FA26")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2CharListViewModel m_charListViewModel;

		// Token: 0x0401FA27 RID: 129575
		[Token(Token = "0x401FA27")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FA28 RID: 129576
		[Token(Token = "0x401FA28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FA29 RID: 129577
		[Token(Token = "0x401FA29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FA2A RID: 129578
		[Token(Token = "0x401FA2A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnScrollRectTween;

		// Token: 0x0401FA2B RID: 129579
		[Token(Token = "0x401FA2B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTipsBtnClick;

		// Token: 0x0401FA2C RID: 129580
		[Token(Token = "0x401FA2C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004026 RID: 16422
		[Token(Token = "0x2004026")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060196B7 RID: 104119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60196B7")]
			[Address(RVA = "0x1213000", Offset = "0x1211C00", VA = "0x181213000")]
			public BuffListAdapter(SandboxV2CharSelectLogisticsLeftView closure)
			{
			}

			// Token: 0x17003C92 RID: 15506
			// (get) Token: 0x060196B8 RID: 104120 RVA: 0x0009DFC8 File Offset: 0x0009C1C8
			[Token(Token = "0x17003C92")]
			public override int count
			{
				[Token(Token = "0x60196B8")]
				[Address(RVA = "0x1213080", Offset = "0x1211C80", VA = "0x181213080", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060196B9 RID: 104121 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60196B9")]
			[Address(RVA = "0x1212E30", Offset = "0x1211A30", VA = "0x181212E30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060196BA RID: 104122 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60196BA")]
			[Address(RVA = "0x1212D50", Offset = "0x1211950", VA = "0x181212D50")]
			public RectTransform GetTargetViewRectTransform(int index)
			{
				return null;
			}

			// Token: 0x0401FA2D RID: 129581
			[Token(Token = "0x401FA2D")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2CharSelectLogisticsLeftView m_closure;

			// Token: 0x0401FA2E RID: 129582
			[Token(Token = "0x401FA2E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FA2F RID: 129583
			[Token(Token = "0x401FA2F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FA30 RID: 129584
			[Token(Token = "0x401FA30")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401FA31 RID: 129585
			[Token(Token = "0x401FA31")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetTargetViewRectTransform;
		}
	}
}
