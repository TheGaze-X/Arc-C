using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004677 RID: 18039
	[Token(Token = "0x2004677")]
	public class RoguelikeTopicEndingCommonController : RoguelikeTopicEndingControllerBase
	{
		// Token: 0x0601B630 RID: 112176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B630")]
		[Address(RVA = "0x14B3250", Offset = "0x14B1E50", VA = "0x1814B3250", Slot = "4")]
		public override void OnInit(RoguelikeTopicEndingState state, string topicId, RoguelikeTopicPage.SettleInfo settleInfo)
		{
		}

		// Token: 0x0601B631 RID: 112177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B631")]
		[Address(RVA = "0x14B3080", Offset = "0x14B1C80", VA = "0x1814B3080", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x0601B632 RID: 112178 RVA: 0x000A5030 File Offset: 0x000A3230
		[Token(Token = "0x601B632")]
		[Address(RVA = "0x14B3370", Offset = "0x14B1F70", VA = "0x1814B3370", Slot = "8")]
		protected override bool OnNext()
		{
			return default(bool);
		}

		// Token: 0x0601B633 RID: 112179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B633")]
		[Address(RVA = "0x14B3540", Offset = "0x14B2140", VA = "0x1814B3540")]
		private void _InitViews()
		{
		}

		// Token: 0x0601B634 RID: 112180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B634")]
		[Address(RVA = "0x14B3A10", Offset = "0x14B2610", VA = "0x1814B3A10")]
		public RoguelikeTopicEndingCommonController()
		{
		}

		// Token: 0x0601B635 RID: 112181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B635")]
		[Address(RVA = "0x14B3530", Offset = "0x14B2130", VA = "0x1814B3530")]
		private void <>xLuaBaseProxy_OnInit(RoguelikeTopicEndingState P0, string P1, RoguelikeTopicPage.SettleInfo P2)
		{
		}

		// Token: 0x0601B636 RID: 112182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B636")]
		[Address(RVA = "0x14B3520", Offset = "0x14B2120", VA = "0x1814B3520")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04023667 RID: 144999
		[Token(Token = "0x4023667")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RoguelikeTopicEndingPageViewBase> _pageViews;

		// Token: 0x04023668 RID: 145000
		[Token(Token = "0x4023668")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<RoguelikeTopicEndingCommonController.DynamicViewConfig> _dynamicViewConfigs;

		// Token: 0x04023669 RID: 145001
		[Token(Token = "0x4023669")]
		[FieldOffset(Offset = "0x40")]
		private List<RoguelikeTopicEndingPageViewBase> m_views;

		// Token: 0x0402366A RID: 145002
		[Token(Token = "0x402366A")]
		[FieldOffset(Offset = "0x48")]
		private List<Type> m_viewShowTypes;

		// Token: 0x0402366B RID: 145003
		[Token(Token = "0x402366B")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicEndingCommonViewModel m_viewModel;

		// Token: 0x0402366C RID: 145004
		[Token(Token = "0x402366C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402366D RID: 145005
		[Token(Token = "0x402366D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402366E RID: 145006
		[Token(Token = "0x402366E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnNext;

		// Token: 0x0402366F RID: 145007
		[Token(Token = "0x402366F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitViews;

		// Token: 0x04023670 RID: 145008
		[Token(Token = "0x4023670")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004678 RID: 18040
		[Token(Token = "0x2004678")]
		[Serializable]
		private class DynamicViewConfig
		{
			// Token: 0x0601B637 RID: 112183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B637")]
			[Address(RVA = "0x5A4AB0", Offset = "0x5A36B0", VA = "0x1805A4AB0")]
			public DynamicViewConfig()
			{
			}

			// Token: 0x04023671 RID: 145009
			[Token(Token = "0x4023671")]
			[FieldOffset(Offset = "0x10")]
			public Transform container;

			// Token: 0x04023672 RID: 145010
			[Token(Token = "0x4023672")]
			[FieldOffset(Offset = "0x18")]
			public int insertIndex;

			// Token: 0x04023673 RID: 145011
			[Token(Token = "0x4023673")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeTopicEndingPageViewBase view;
		}
	}
}
