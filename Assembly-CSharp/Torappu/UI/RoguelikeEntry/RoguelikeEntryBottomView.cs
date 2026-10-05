using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x0200446C RID: 17516
	[Token(Token = "0x200446C")]
	public class RoguelikeEntryBottomView : DataBinder<RoguelikeEntryProperty>, IHotfixable
	{
		// Token: 0x0601AC6F RID: 109679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC6F")]
		[Address(RVA = "0x13D6980", Offset = "0x13D5580", VA = "0x1813D6980", Slot = "7")]
		public override void OnValueChanged(RoguelikeEntryProperty property)
		{
		}

		// Token: 0x0601AC70 RID: 109680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC70")]
		[Address(RVA = "0x13D6B90", Offset = "0x13D5790", VA = "0x1813D6B90")]
		private void _FocusToItem(int targetIndex)
		{
		}

		// Token: 0x0601AC71 RID: 109681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC71")]
		[Address(RVA = "0x13D7130", Offset = "0x13D5D30", VA = "0x1813D7130")]
		public RoguelikeEntryBottomView()
		{
		}

		// Token: 0x040223B3 RID: 140211
		[Token(Token = "0x40223B3")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x040223B4 RID: 140212
		[Token(Token = "0x40223B4")]
		private const int SLIDE_MAX_LENGTH = 10;

		// Token: 0x040223B5 RID: 140213
		[Token(Token = "0x40223B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeEntryBottomAdapter _adapter;

		// Token: 0x040223B6 RID: 140214
		[Token(Token = "0x40223B6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x040223B7 RID: 140215
		[Token(Token = "0x40223B7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LoopHorizontalScrollRect _scrollRect;

		// Token: 0x040223B8 RID: 140216
		[Token(Token = "0x40223B8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x040223B9 RID: 140217
		[Token(Token = "0x40223B9")]
		[FieldOffset(Offset = "0x40")]
		private int m_cachedSequenceId;

		// Token: 0x040223BA RID: 140218
		[Token(Token = "0x40223BA")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_cachedTween;

		// Token: 0x040223BB RID: 140219
		[Token(Token = "0x40223BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040223BC RID: 140220
		[Token(Token = "0x40223BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FocusToItem;

		// Token: 0x040223BD RID: 140221
		[Token(Token = "0x40223BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200446D RID: 17517
		[Token(Token = "0x200446D")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0601AC74 RID: 109684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC74")]
			[Address(RVA = "0x13D53A0", Offset = "0x13D3FA0", VA = "0x1813D53A0")]
			public OnPostLayoutAction(RoguelikeEntryBottomView closure, int focusIdx)
			{
			}

			// Token: 0x0601AC75 RID: 109685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AC75")]
			[Address(RVA = "0x13D5320", Offset = "0x13D3F20", VA = "0x1813D5320", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x040223BE RID: 140222
			[Token(Token = "0x40223BE")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeEntryBottomView m_closure;

			// Token: 0x040223BF RID: 140223
			[Token(Token = "0x40223BF")]
			[FieldOffset(Offset = "0x18")]
			private int m_focusIdx;
		}
	}
}
