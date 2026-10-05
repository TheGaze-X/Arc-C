using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E3 RID: 21475
	[Token(Token = "0x20053E3")]
	public abstract class RoguelikeRewardItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x0601F996 RID: 129430
		// (set) Token: 0x0601F997 RID: 129431
		[Token(Token = "0x17004A00")]
		public abstract UIIntEvent onClickEvent { [Token(Token = "0x601F996")] protected get; [Token(Token = "0x601F997")] set; }

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x0601F998 RID: 129432
		[Token(Token = "0x17004A01")]
		public abstract RoguelikeRewardShowTypeSet showType { [Token(Token = "0x601F998")] get; }

		// Token: 0x0601F999 RID: 129433
		[Token(Token = "0x601F999")]
		public abstract void OnClick();

		// Token: 0x0601F99A RID: 129434
		[Token(Token = "0x601F99A")]
		public abstract void Render(RoguelikeRewardItemViewModel viewModel, string topicId);

		// Token: 0x0601F99B RID: 129435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F99B")]
		[Address(RVA = "0x193FEB0", Offset = "0x193EAB0", VA = "0x18193FEB0")]
		public void RenderItem(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F99C RID: 129436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F99C")]
		[Address(RVA = "0x1940060", Offset = "0x193EC60", VA = "0x181940060")]
		private void _TryToRenderExDropTag(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F99D RID: 129437 RVA: 0x000B2668 File Offset: 0x000B0868
		[Token(Token = "0x601F99D")]
		[Address(RVA = "0x193FF70", Offset = "0x193EB70", VA = "0x18193FF70")]
		private RoguelikeRewardExDropTagSrcType _GetRewardExDropTagSrcType(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
			return RoguelikeRewardExDropTagSrcType.NONE;
		}

		// Token: 0x0601F99E RID: 129438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F99E")]
		[Address(RVA = "0x19404E0", Offset = "0x193F0E0", VA = "0x1819404E0")]
		protected RoguelikeRewardItem()
		{
		}

		// Token: 0x0402A8F1 RID: 174321
		[Token(Token = "0x402A8F1")]
		private const string COLOR_GROUP_EXDROP_TAG = "exDropTag";

		// Token: 0x0402A8F2 RID: 174322
		[Token(Token = "0x402A8F2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _exDropTagContainer;

		// Token: 0x0402A8F3 RID: 174323
		[Token(Token = "0x402A8F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402A8F4 RID: 174324
		[Token(Token = "0x402A8F4")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_uiPageFinder;

		// Token: 0x0402A8F5 RID: 174325
		[Token(Token = "0x402A8F5")]
		[FieldOffset(Offset = "0x38")]
		protected RoguelikeRewardItemViewModel m_cachedViewModel;

		// Token: 0x0402A8F6 RID: 174326
		[Token(Token = "0x402A8F6")]
		[FieldOffset(Offset = "0x40")]
		protected RoguelikeRewardItemExDropTagView m_exDropTagView;

		// Token: 0x0402A8F7 RID: 174327
		[Token(Token = "0x402A8F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderItem;

		// Token: 0x0402A8F8 RID: 174328
		[Token(Token = "0x402A8F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryToRenderExDropTag;

		// Token: 0x0402A8F9 RID: 174329
		[Token(Token = "0x402A8F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetRewardExDropTagSrcType;

		// Token: 0x0402A8FA RID: 174330
		[Token(Token = "0x402A8FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
