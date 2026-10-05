using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x0200281F RID: 10271
	[Token(Token = "0x200281F")]
	[RequireComponent(typeof(CanvasGroup))]
	public class DialogPlaybackPanel : DialogExecutorBase, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x170025B2 RID: 9650
		// (get) Token: 0x0601117F RID: 70015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025B2")]
		protected DialogPlaybackPanel.Adapter adapter
		{
			[Token(Token = "0x601117F")]
			[Address(RVA = "0x8F8CF0", Offset = "0x8F78F0", VA = "0x1808F8CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011180 RID: 70016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011180")]
		[Address(RVA = "0x8F8730", Offset = "0x8F7330", VA = "0x1808F8730", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06011181 RID: 70017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011181")]
		[Address(RVA = "0x8F8790", Offset = "0x8F7390", VA = "0x1808F8790")]
		public void OnReset()
		{
		}

		// Token: 0x170025B3 RID: 9651
		// (get) Token: 0x06011182 RID: 70018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025B3")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x6011182")]
			[Address(RVA = "0x8F8DF0", Offset = "0x8F79F0", VA = "0x1808F8DF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025B4 RID: 9652
		// (get) Token: 0x06011183 RID: 70019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025B4")]
		private UISwitchTween fadeSwitchTween
		{
			[Token(Token = "0x6011183")]
			[Address(RVA = "0x8F8EC0", Offset = "0x8F7AC0", VA = "0x1808F8EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011184 RID: 70020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011184")]
		[Address(RVA = "0x8F8B10", Offset = "0x8F7710", VA = "0x1808F8B10")]
		private void _UpdateShown(bool value, bool force)
		{
		}

		// Token: 0x06011185 RID: 70021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011185")]
		[Address(RVA = "0x8F89F0", Offset = "0x8F75F0", VA = "0x1808F89F0")]
		private void _ResetLastCurrentIcon()
		{
		}

		// Token: 0x06011186 RID: 70022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011186")]
		[Address(RVA = "0x8F8AA0", Offset = "0x8F76A0", VA = "0x1808F8AA0")]
		private void _ResetScrollSlide()
		{
		}

		// Token: 0x170025B5 RID: 9653
		// (get) Token: 0x06011187 RID: 70023 RVA: 0x000694B0 File Offset: 0x000676B0
		// (set) Token: 0x06011188 RID: 70024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170025B5")]
		public bool isShown
		{
			[Token(Token = "0x6011187")]
			[Address(RVA = "0x8F9040", Offset = "0x8F7C40", VA = "0x1808F9040")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6011188")]
			[Address(RVA = "0x8F90B0", Offset = "0x8F7CB0", VA = "0x1808F90B0")]
			set
			{
			}
		}

		// Token: 0x06011189 RID: 70025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011189")]
		[Address(RVA = "0x8F86D0", Offset = "0x8F72D0", VA = "0x1808F86D0")]
		public void OnCloseBtnClicked()
		{
		}

		// Token: 0x0601118A RID: 70026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601118A")]
		[Address(RVA = "0x8F8250", Offset = "0x8F6E50", VA = "0x1808F8250")]
		public void AddDialog(string text, string name)
		{
		}

		// Token: 0x0601118B RID: 70027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601118B")]
		[Address(RVA = "0x8F83F0", Offset = "0x8F6FF0", VA = "0x1808F83F0")]
		public void AddOptions(List<BattleDialogOption> dialogueOptions, int decision)
		{
		}

		// Token: 0x0601118C RID: 70028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601118C")]
		[Address(RVA = "0x8F8C00", Offset = "0x8F7800", VA = "0x1808F8C00")]
		public DialogPlaybackPanel()
		{
		}

		// Token: 0x0401327E RID: 78462
		[Token(Token = "0x401327E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DialogPlaybackTextView _avgPlaybackTextView;

		// Token: 0x0401327F RID: 78463
		[Token(Token = "0x401327F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04013280 RID: 78464
		[Token(Token = "0x4013280")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04013281 RID: 78465
		[Token(Token = "0x4013281")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ContentSizeFitterHelper _fitterHelper;

		// Token: 0x04013282 RID: 78466
		[Token(Token = "0x4013282")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _closeBtn;

		// Token: 0x04013283 RID: 78467
		[Token(Token = "0x4013283")]
		[FieldOffset(Offset = "0x40")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x04013284 RID: 78468
		[Token(Token = "0x4013284")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_playbackTween;

		// Token: 0x04013285 RID: 78469
		[Token(Token = "0x4013285")]
		[FieldOffset(Offset = "0x50")]
		private DialogPlaybackPanel.Adapter m_innerAdapter;

		// Token: 0x04013286 RID: 78470
		[Token(Token = "0x4013286")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isProcessingMultiline;

		// Token: 0x04013287 RID: 78471
		[Token(Token = "0x4013287")]
		[FieldOffset(Offset = "0x60")]
		private StringBuilder m_cachedStrBuilder;

		// Token: 0x04013288 RID: 78472
		[Token(Token = "0x4013288")]
		[FieldOffset(Offset = "0x68")]
		private DialogPlaybackTextView.Options m_multilineOption;

		// Token: 0x04013289 RID: 78473
		[Token(Token = "0x4013289")]
		[FieldOffset(Offset = "0x98")]
		private DialogPlaybackTextView.VirtualView m_multilineView;

		// Token: 0x0401328A RID: 78474
		[Token(Token = "0x401328A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0401328B RID: 78475
		[Token(Token = "0x401328B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x0401328C RID: 78476
		[Token(Token = "0x401328C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0401328D RID: 78477
		[Token(Token = "0x401328D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0401328E RID: 78478
		[Token(Token = "0x401328E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_fadeSwitchTween;

		// Token: 0x0401328F RID: 78479
		[Token(Token = "0x401328F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateShown;

		// Token: 0x04013290 RID: 78480
		[Token(Token = "0x4013290")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ResetLastCurrentIcon;

		// Token: 0x04013291 RID: 78481
		[Token(Token = "0x4013291")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetScrollSlide;

		// Token: 0x04013292 RID: 78482
		[Token(Token = "0x4013292")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x04013293 RID: 78483
		[Token(Token = "0x4013293")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isShown;

		// Token: 0x04013294 RID: 78484
		[Token(Token = "0x4013294")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCloseBtnClicked;

		// Token: 0x04013295 RID: 78485
		[Token(Token = "0x4013295")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AddDialog;

		// Token: 0x04013296 RID: 78486
		[Token(Token = "0x4013296")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_AddOptions;

		// Token: 0x04013297 RID: 78487
		[Token(Token = "0x4013297")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002820 RID: 10272
		[Token(Token = "0x2002820")]
		protected class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601118D RID: 70029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601118D")]
			[Address(RVA = "0x907360", Offset = "0x905F60", VA = "0x180907360")]
			public Adapter(DialogPlaybackPanel closure)
			{
			}

			// Token: 0x0601118E RID: 70030 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601118E")]
			[Address(RVA = "0x907040", Offset = "0x905C40", VA = "0x180907040", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601118F RID: 70031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601118F")]
			[Address(RVA = "0x907190", Offset = "0x905D90", VA = "0x180907190")]
			public DialogPlaybackTextView.VirtualView GetLastCell()
			{
				return null;
			}

			// Token: 0x06011190 RID: 70032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011190")]
			[Address(RVA = "0x906EE0", Offset = "0x905AE0", VA = "0x180906EE0")]
			public void AddCell(DialogPlaybackTextView.VirtualView view)
			{
			}

			// Token: 0x06011191 RID: 70033 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011191")]
			[Address(RVA = "0x907230", Offset = "0x905E30", VA = "0x180907230")]
			public void NotifyViewChanged(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x04013298 RID: 78488
			[Token(Token = "0x4013298")]
			[FieldOffset(Offset = "0x18")]
			public DialogPlaybackPanel m_closure;

			// Token: 0x04013299 RID: 78489
			[Token(Token = "0x4013299")]
			[FieldOffset(Offset = "0x20")]
			private List<DialogPlaybackTextView.VirtualView> m_cells;

			// Token: 0x0401329A RID: 78490
			[Token(Token = "0x401329A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401329B RID: 78491
			[Token(Token = "0x401329B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0401329C RID: 78492
			[Token(Token = "0x401329C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetLastCell;

			// Token: 0x0401329D RID: 78493
			[Token(Token = "0x401329D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AddCell;

			// Token: 0x0401329E RID: 78494
			[Token(Token = "0x401329E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_NotifyViewChanged;
		}
	}
}
