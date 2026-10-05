using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007745 RID: 30533
	[Token(Token = "0x2007745")]
	public class Act1VHalfIdleCharDepotCharsHolderView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE43 RID: 175683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE43")]
		[Address(RVA = "0x26AC960", Offset = "0x26AB560", VA = "0x1826AC960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE44 RID: 175684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE44")]
		[Address(RVA = "0x26AC0D0", Offset = "0x26AACD0", VA = "0x1826AC0D0")]
		public void OnRender(string actId, CommonCharSelectShuffleDefaultViewModel shuffleViewModel, bool forceCollectChars = false, bool needFocus = false, int focusCharInstId = -1)
		{
		}

		// Token: 0x0602AE45 RID: 175685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE45")]
		[Address(RVA = "0x26AC600", Offset = "0x26AB200", VA = "0x1826AC600")]
		private void _CollectChars(string actId)
		{
		}

		// Token: 0x0602AE46 RID: 175686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE46")]
		[Address(RVA = "0x26ACC10", Offset = "0x26AB810", VA = "0x1826ACC10")]
		private void _ShuffleChars(CommonCharSelectShuffleDefaultViewModel shuffleViewModel)
		{
		}

		// Token: 0x0602AE47 RID: 175687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE47")]
		[Address(RVA = "0x26ACAB0", Offset = "0x26AB6B0", VA = "0x1826ACAB0")]
		private void _ScrollFocusTo(ValueTuple<float, float> pos)
		{
		}

		// Token: 0x0602AE48 RID: 175688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE48")]
		[Address(RVA = "0x26ACE30", Offset = "0x26ABA30", VA = "0x1826ACE30")]
		public Act1VHalfIdleCharDepotCharsHolderView()
		{
		}

		// Token: 0x0403DD78 RID: 253304
		[Token(Token = "0x403DD78")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act1VHalfIdleCharDepotAdapter _charDepotAdapter;

		// Token: 0x0403DD79 RID: 253305
		[Token(Token = "0x403DD79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x0403DD7A RID: 253306
		[Token(Token = "0x403DD7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GridLayoutGroup _layout;

		// Token: 0x0403DD7B RID: 253307
		[Token(Token = "0x403DD7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0403DD7C RID: 253308
		[Token(Token = "0x403DD7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopHorizontalScrollRect _scrollRect;

		// Token: 0x0403DD7D RID: 253309
		[Token(Token = "0x403DD7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _scrollViewRect;

		// Token: 0x0403DD7E RID: 253310
		[Token(Token = "0x403DD7E")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<Act1VHalfIdleCharDepotCard.Options> onCharClick;

		// Token: 0x0403DD7F RID: 253311
		[Token(Token = "0x403DD7F")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0403DD80 RID: 253312
		[Token(Token = "0x403DD80")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType> m_charTypeDict;

		// Token: 0x0403DD81 RID: 253313
		[Token(Token = "0x403DD81")]
		[FieldOffset(Offset = "0x60")]
		private List<Act1VHalfIdleCharSelectCardViewModel> m_allChars;

		// Token: 0x0403DD82 RID: 253314
		[Token(Token = "0x403DD82")]
		[FieldOffset(Offset = "0x68")]
		private List<Act1VHalfIdleCharSelectCardViewModel> m_shuffledChars;

		// Token: 0x0403DD83 RID: 253315
		[Token(Token = "0x403DD83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DD84 RID: 253316
		[Token(Token = "0x403DD84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DD85 RID: 253317
		[Token(Token = "0x403DD85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CollectChars;

		// Token: 0x0403DD86 RID: 253318
		[Token(Token = "0x403DD86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShuffleChars;

		// Token: 0x0403DD87 RID: 253319
		[Token(Token = "0x403DD87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ScrollFocusTo;

		// Token: 0x0403DD88 RID: 253320
		[Token(Token = "0x403DD88")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007746 RID: 30534
		[Token(Token = "0x2007746")]
		private class PostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602AE49 RID: 175689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE49")]
			[Address(RVA = "0x26C2900", Offset = "0x26C1500", VA = "0x1826C2900")]
			public PostLayoutAction(Act1VHalfIdleCharDepotCharsHolderView closure, ValueTuple<float, float> pos)
			{
			}

			// Token: 0x0602AE4A RID: 175690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE4A")]
			[Address(RVA = "0x26C2740", Offset = "0x26C1340", VA = "0x1826C2740", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0403DD89 RID: 253321
			[Token(Token = "0x403DD89")]
			[FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleCharDepotCharsHolderView m_closure;

			// Token: 0x0403DD8A RID: 253322
			[Token(Token = "0x403DD8A")]
			[FieldOffset(Offset = "0x18")]
			private ValueTuple<float, float> m_pos;
		}
	}
}
