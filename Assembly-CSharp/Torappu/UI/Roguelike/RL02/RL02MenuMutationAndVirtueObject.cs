using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005785 RID: 22405
	[Token(Token = "0x2005785")]
	public class RL02MenuMutationAndVirtueObject : RoguelikeMenuObject<RL02MutationAndVirtueViewModel>
	{
		// Token: 0x06020C8E RID: 134286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C8E")]
		[Address(RVA = "0x1B23C30", Offset = "0x1B22830", VA = "0x181B23C30", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x17004CE0 RID: 19680
		// (get) Token: 0x06020C8F RID: 134287 RVA: 0x000B74B0 File Offset: 0x000B56B0
		[Token(Token = "0x17004CE0")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020C8F")]
			[Address(RVA = "0x1B240F0", Offset = "0x1B22CF0", VA = "0x181B240F0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020C90 RID: 134288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C90")]
		[Address(RVA = "0x1B23E80", Offset = "0x1B22A80", VA = "0x181B23E80", Slot = "16")]
		public override void Render(RL02MutationAndVirtueViewModel viewModel)
		{
		}

		// Token: 0x06020C91 RID: 134289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C91")]
		[Address(RVA = "0x1B24080", Offset = "0x1B22C80", VA = "0x181B24080")]
		public RL02MenuMutationAndVirtueObject()
		{
		}

		// Token: 0x06020C92 RID: 134290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020C92")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x0402C87F RID: 182399
		[Token(Token = "0x402C87F")]
		private const float SHOW_TWEEN_DURATION = 0.23f;

		// Token: 0x0402C880 RID: 182400
		[Token(Token = "0x402C880")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02MenuMutationAndVirtueObject.MutationOnlyStatePanel _panelMutationOnly;

		// Token: 0x0402C881 RID: 182401
		[Token(Token = "0x402C881")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL02MenuMutationAndVirtueObject.OneVirtueStatePanel _panelOneVirtue;

		// Token: 0x0402C882 RID: 182402
		[Token(Token = "0x402C882")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RL02MenuMutationAndVirtueObject.MultiVirtueStatePanel _panelMultiVirtue;

		// Token: 0x0402C883 RID: 182403
		[Token(Token = "0x402C883")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RL02MenuMutationAndVirtueObject.MutationAndVirtueStatePanel _panelMutationAndVirtue;

		// Token: 0x0402C884 RID: 182404
		[Token(Token = "0x402C884")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402C885 RID: 182405
		[Token(Token = "0x402C885")]
		[FieldOffset(Offset = "0x58")]
		private List<RL02MenuMutationAndVirtueObject.StatePanel> m_statePanelList;

		// Token: 0x0402C886 RID: 182406
		[Token(Token = "0x402C886")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween m_showTween;

		// Token: 0x0402C887 RID: 182407
		[Token(Token = "0x402C887")]
		[FieldOffset(Offset = "0x68")]
		private RL02MenuMutationAndVirtueObject.State m_lastState;

		// Token: 0x0402C888 RID: 182408
		[Token(Token = "0x402C888")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402C889 RID: 182409
		[Token(Token = "0x402C889")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402C88A RID: 182410
		[Token(Token = "0x402C88A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C88B RID: 182411
		[Token(Token = "0x402C88B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005786 RID: 22406
		[Token(Token = "0x2005786")]
		private enum State
		{
			// Token: 0x0402C88D RID: 182413
			[Token(Token = "0x402C88D")]
			NONE,
			// Token: 0x0402C88E RID: 182414
			[Token(Token = "0x402C88E")]
			MUTATION_ONLY,
			// Token: 0x0402C88F RID: 182415
			[Token(Token = "0x402C88F")]
			ONE_VIRTUE,
			// Token: 0x0402C890 RID: 182416
			[Token(Token = "0x402C890")]
			MULTI_VIRTUE,
			// Token: 0x0402C891 RID: 182417
			[Token(Token = "0x402C891")]
			MUTATION_AND_VIRTUE
		}

		// Token: 0x02005787 RID: 22407
		[Token(Token = "0x2005787")]
		[Serializable]
		private class MutationAndVirtueIcon : IHotfixable
		{
			// Token: 0x06020C93 RID: 134291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C93")]
			[Address(RVA = "0x1B19300", Offset = "0x1B17F00", VA = "0x181B19300")]
			public void Render(string topicId, string iconId, bool fastMode)
			{
			}

			// Token: 0x06020C94 RID: 134292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C94")]
			[Address(RVA = "0x1B193E0", Offset = "0x1B17FE0", VA = "0x181B193E0")]
			public MutationAndVirtueIcon()
			{
			}

			// Token: 0x0402C892 RID: 182418
			[Token(Token = "0x402C892")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Image _imageIcon;

			// Token: 0x0402C893 RID: 182419
			[Token(Token = "0x402C893")]
			[FieldOffset(Offset = "0x18")]
			private string m_cachedIconId;

			// Token: 0x0402C894 RID: 182420
			[Token(Token = "0x402C894")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C895 RID: 182421
			[Token(Token = "0x402C895")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005788 RID: 22408
		[Token(Token = "0x2005788")]
		[Serializable]
		private abstract class StatePanel : IHotfixable
		{
			// Token: 0x06020C95 RID: 134293 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C95")]
			[Address(RVA = "0x1B2B1F0", Offset = "0x1B29DF0", VA = "0x181B2B1F0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x06020C96 RID: 134294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C96")]
			[Address(RVA = "0x1B2B030", Offset = "0x1B29C30", VA = "0x181B2B030")]
			public void Render(bool isShow, bool fastMode, RL02MutationAndVirtueViewModel viewModel)
			{
			}

			// Token: 0x06020C97 RID: 134295
			[Token(Token = "0x6020C97")]
			protected abstract void _DoRender(RL02MutationAndVirtueViewModel viewModel, bool fastMode);

			// Token: 0x06020C98 RID: 134296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C98")]
			[Address(RVA = "0x1B2B2C0", Offset = "0x1B29EC0", VA = "0x181B2B2C0")]
			protected StatePanel()
			{
			}

			// Token: 0x0402C896 RID: 182422
			[Token(Token = "0x402C896")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private CanvasGroup _canvasContent;

			// Token: 0x0402C897 RID: 182423
			[Token(Token = "0x402C897")]
			[FieldOffset(Offset = "0x18")]
			private UISwitchTween m_showTween;

			// Token: 0x0402C898 RID: 182424
			[Token(Token = "0x402C898")]
			[FieldOffset(Offset = "0x20")]
			private bool m_lastShowStatus;

			// Token: 0x0402C899 RID: 182425
			[Token(Token = "0x402C899")]
			[FieldOffset(Offset = "0x21")]
			private bool m_inited;

			// Token: 0x0402C89A RID: 182426
			[Token(Token = "0x402C89A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0402C89B RID: 182427
			[Token(Token = "0x402C89B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0402C89C RID: 182428
			[Token(Token = "0x402C89C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005789 RID: 22409
		[Token(Token = "0x2005789")]
		[Serializable]
		private class MutationOnlyStatePanel : RL02MenuMutationAndVirtueObject.StatePanel
		{
			// Token: 0x06020C99 RID: 134297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C99")]
			[Address(RVA = "0x1B19650", Offset = "0x1B18250", VA = "0x181B19650", Slot = "4")]
			protected override void _DoRender(RL02MutationAndVirtueViewModel viewModel, bool fastMode)
			{
			}

			// Token: 0x06020C9A RID: 134298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9A")]
			[Address(RVA = "0x1B19750", Offset = "0x1B18350", VA = "0x181B19750")]
			public MutationOnlyStatePanel()
			{
			}

			// Token: 0x0402C89D RID: 182429
			[Token(Token = "0x402C89D")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIcon;

			// Token: 0x0402C89E RID: 182430
			[Token(Token = "0x402C89E")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textMutation;

			// Token: 0x0402C89F RID: 182431
			[Token(Token = "0x402C89F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__DoRender;

			// Token: 0x0402C8A0 RID: 182432
			[Token(Token = "0x402C8A0")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200578A RID: 22410
		[Token(Token = "0x200578A")]
		[Serializable]
		private class OneVirtueStatePanel : RL02MenuMutationAndVirtueObject.StatePanel
		{
			// Token: 0x06020C9B RID: 134299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9B")]
			[Address(RVA = "0x1B1A0B0", Offset = "0x1B18CB0", VA = "0x181B1A0B0", Slot = "4")]
			protected override void _DoRender(RL02MutationAndVirtueViewModel viewModel, bool fastMode)
			{
			}

			// Token: 0x06020C9C RID: 134300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9C")]
			[Address(RVA = "0x1B1A1E0", Offset = "0x1B18DE0", VA = "0x181B1A1E0")]
			public OneVirtueStatePanel()
			{
			}

			// Token: 0x0402C8A1 RID: 182433
			[Token(Token = "0x402C8A1")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIcon;

			// Token: 0x0402C8A2 RID: 182434
			[Token(Token = "0x402C8A2")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textVirtue;

			// Token: 0x0402C8A3 RID: 182435
			[Token(Token = "0x402C8A3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__DoRender;

			// Token: 0x0402C8A4 RID: 182436
			[Token(Token = "0x402C8A4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200578B RID: 22411
		[Token(Token = "0x200578B")]
		[Serializable]
		private class MultiVirtueStatePanel : RL02MenuMutationAndVirtueObject.StatePanel
		{
			// Token: 0x06020C9D RID: 134301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9D")]
			[Address(RVA = "0x1B18DF0", Offset = "0x1B179F0", VA = "0x181B18DF0", Slot = "4")]
			protected override void _DoRender(RL02MutationAndVirtueViewModel viewModel, bool fastMode)
			{
			}

			// Token: 0x06020C9E RID: 134302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9E")]
			[Address(RVA = "0x1B18F90", Offset = "0x1B17B90", VA = "0x181B18F90")]
			public MultiVirtueStatePanel()
			{
			}

			// Token: 0x0402C8A5 RID: 182437
			[Token(Token = "0x402C8A5")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIcon1;

			// Token: 0x0402C8A6 RID: 182438
			[Token(Token = "0x402C8A6")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIcon2;

			// Token: 0x0402C8A7 RID: 182439
			[Token(Token = "0x402C8A7")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _panelMore;

			// Token: 0x0402C8A8 RID: 182440
			[Token(Token = "0x402C8A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__DoRender;

			// Token: 0x0402C8A9 RID: 182441
			[Token(Token = "0x402C8A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200578C RID: 22412
		[Token(Token = "0x200578C")]
		[Serializable]
		private class MutationAndVirtueStatePanel : RL02MenuMutationAndVirtueObject.StatePanel
		{
			// Token: 0x06020C9F RID: 134303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020C9F")]
			[Address(RVA = "0x1B19440", Offset = "0x1B18040", VA = "0x181B19440", Slot = "4")]
			protected override void _DoRender(RL02MutationAndVirtueViewModel viewModel, bool fastMode)
			{
			}

			// Token: 0x06020CA0 RID: 134304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020CA0")]
			[Address(RVA = "0x1B195B0", Offset = "0x1B181B0", VA = "0x181B195B0")]
			public MutationAndVirtueStatePanel()
			{
			}

			// Token: 0x0402C8AA RID: 182442
			[Token(Token = "0x402C8AA")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIconMutation;

			// Token: 0x0402C8AB RID: 182443
			[Token(Token = "0x402C8AB")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private RL02MenuMutationAndVirtueObject.MutationAndVirtueIcon _imageIconVirtue;

			// Token: 0x0402C8AC RID: 182444
			[Token(Token = "0x402C8AC")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private GameObject _panelMore;

			// Token: 0x0402C8AD RID: 182445
			[Token(Token = "0x402C8AD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__DoRender;

			// Token: 0x0402C8AE RID: 182446
			[Token(Token = "0x402C8AE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
