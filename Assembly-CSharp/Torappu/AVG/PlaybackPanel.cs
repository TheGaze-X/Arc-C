using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001ED6 RID: 7894
	[Token(Token = "0x2001ED6")]
	[RequireComponent(typeof(CanvasGroup))]
	public class PlaybackPanel : ExecutorComponent, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x0600C3CE RID: 50126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001765")]
		protected PlaybackPanel.Adapter adapter
		{
			[Token(Token = "0x600C3CE")]
			[Address(RVA = "0x341B810", Offset = "0x341A410", VA = "0x18341B810")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C3CF RID: 50127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3CF")]
		[Address(RVA = "0x3419950", Offset = "0x3418550", VA = "0x183419950", Slot = "13")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600C3D0 RID: 50128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C3D0")]
		[Address(RVA = "0x34194B0", Offset = "0x34180B0", VA = "0x1834194B0", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D1")]
		[Address(RVA = "0x34199B0", Offset = "0x34185B0", VA = "0x1834199B0", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C3D2 RID: 50130 RVA: 0x00047E38 File Offset: 0x00046038
		[Token(Token = "0x600C3D2")]
		[Address(RVA = "0x341A420", Offset = "0x3419020", VA = "0x18341A420")]
		private bool _ExecuteDialog(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D3 RID: 50131 RVA: 0x00047E50 File Offset: 0x00046050
		[Token(Token = "0x600C3D3")]
		[Address(RVA = "0x341A1D0", Offset = "0x3418DD0", VA = "0x18341A1D0")]
		private bool _ExecuteDecision(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x00047E68 File Offset: 0x00046068
		[Token(Token = "0x600C3D4")]
		[Address(RVA = "0x341AB90", Offset = "0x3419790", VA = "0x18341AB90")]
		private bool _ExecutePredicate(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D5 RID: 50133 RVA: 0x00047E80 File Offset: 0x00046080
		[Token(Token = "0x600C3D5")]
		[Address(RVA = "0x341AFF0", Offset = "0x3419BF0", VA = "0x18341AFF0")]
		private bool _ExecuteSubtitle(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D6 RID: 50134 RVA: 0x00047E98 File Offset: 0x00046098
		[Token(Token = "0x600C3D6")]
		[Address(RVA = "0x3419F90", Offset = "0x3418B90", VA = "0x183419F90")]
		private bool _ExecuteAside(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D7 RID: 50135 RVA: 0x00047EB0 File Offset: 0x000460B0
		[Token(Token = "0x600C3D7")]
		[Address(RVA = "0x341A730", Offset = "0x3419330", VA = "0x18341A730")]
		private bool _ExecuteMultiline(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3D8 RID: 50136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3D8")]
		[Address(RVA = "0x341B570", Offset = "0x341A170", VA = "0x18341B570")]
		private void _TryEndMultilineMode()
		{
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x00047EC8 File Offset: 0x000460C8
		[Token(Token = "0x600C3D9")]
		[Address(RVA = "0x341AC90", Offset = "0x3419890", VA = "0x18341AC90")]
		private bool _ExecuteSticker(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3DA RID: 50138 RVA: 0x00047EE0 File Offset: 0x000460E0
		[Token(Token = "0x600C3DA")]
		[Address(RVA = "0x3419C10", Offset = "0x3418810", VA = "0x183419C10")]
		private bool _ExecuteAnimText(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C3DB RID: 50139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DB")]
		[Address(RVA = "0x341B340", Offset = "0x3419F40", VA = "0x18341B340")]
		private void _ResetLastCurrentIcon()
		{
		}

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600C3DC RID: 50140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001766")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x600C3DC")]
			[Address(RVA = "0x341B920", Offset = "0x341A520", VA = "0x18341B920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0600C3DD RID: 50141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001767")]
		private UISwitchTween fadeSwitchTween
		{
			[Token(Token = "0x600C3DD")]
			[Address(RVA = "0x341B9F0", Offset = "0x341A5F0", VA = "0x18341B9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C3DE RID: 50142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DE")]
		[Address(RVA = "0x341B600", Offset = "0x341A200", VA = "0x18341B600")]
		private void _UpdateShown(bool value, bool force)
		{
		}

		// Token: 0x0600C3DF RID: 50143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DF")]
		[Address(RVA = "0x341B500", Offset = "0x341A100", VA = "0x18341B500")]
		private void _ResetScrollSlide()
		{
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x0600C3E0 RID: 50144 RVA: 0x00047EF8 File Offset: 0x000460F8
		// (set) Token: 0x0600C3E1 RID: 50145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001768")]
		public bool isShown
		{
			[Token(Token = "0x600C3E0")]
			[Address(RVA = "0x341BB80", Offset = "0x341A780", VA = "0x18341BB80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C3E1")]
			[Address(RVA = "0x341BC00", Offset = "0x341A800", VA = "0x18341BC00")]
			set
			{
			}
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E2")]
		[Address(RVA = "0x3419870", Offset = "0x3418470", VA = "0x183419870")]
		public void OnCloseBtnClicked()
		{
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E3")]
		[Address(RVA = "0x3419450", Offset = "0x3418050", VA = "0x183419450", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E4")]
		[Address(RVA = "0x341B750", Offset = "0x341A350", VA = "0x18341B750")]
		public PlaybackPanel()
		{
		}

		// Token: 0x0600C3E5 RID: 50149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E5")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C61B RID: 50715
		[Token(Token = "0x400C61B")]
		private const string PARAM_NAME_OPTIONS = "options";

		// Token: 0x0400C61C RID: 50716
		[Token(Token = "0x400C61C")]
		private const string COMMAND_NAME_DECISION = "decision";

		// Token: 0x0400C61D RID: 50717
		[Token(Token = "0x400C61D")]
		private const string COMMAND_NAME_PREDICATE = "predicate";

		// Token: 0x0400C61E RID: 50718
		[Token(Token = "0x400C61E")]
		private const string COMMAND_SUBTITLE = "subtitle";

		// Token: 0x0400C61F RID: 50719
		[Token(Token = "0x400C61F")]
		private const string COMMAND_STICKER = "sticker";

		// Token: 0x0400C620 RID: 50720
		[Token(Token = "0x400C620")]
		private const string COMMAND_ANIMTEXT = "animtext";

		// Token: 0x0400C621 RID: 50721
		[Token(Token = "0x400C621")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGPlaybackTextView _avgPlaybackTextView;

		// Token: 0x0400C622 RID: 50722
		[Token(Token = "0x400C622")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0400C623 RID: 50723
		[Token(Token = "0x400C623")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0400C624 RID: 50724
		[Token(Token = "0x400C624")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContentSizeFitterHelper _fitterHelper;

		// Token: 0x0400C625 RID: 50725
		[Token(Token = "0x400C625")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _closeBtn;

		// Token: 0x0400C626 RID: 50726
		[Token(Token = "0x400C626")]
		[FieldOffset(Offset = "0x78")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C627 RID: 50727
		[Token(Token = "0x400C627")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_playbackTween;

		// Token: 0x0400C628 RID: 50728
		[Token(Token = "0x400C628")]
		[FieldOffset(Offset = "0x88")]
		private PlaybackPanel.Adapter m_innerAdapter;

		// Token: 0x0400C629 RID: 50729
		[Token(Token = "0x400C629")]
		[FieldOffset(Offset = "0x90")]
		private ListDict<int, string> m_cachedAnimTextContent;

		// Token: 0x0400C62A RID: 50730
		[Token(Token = "0x400C62A")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isProcessingMultiline;

		// Token: 0x0400C62B RID: 50731
		[Token(Token = "0x400C62B")]
		[FieldOffset(Offset = "0xA0")]
		private StringBuilder m_cachedStrBuilder;

		// Token: 0x0400C62C RID: 50732
		[Token(Token = "0x400C62C")]
		[FieldOffset(Offset = "0xA8")]
		private AVGPlaybackTextView.Options m_multilineOption;

		// Token: 0x0400C62D RID: 50733
		[Token(Token = "0x400C62D")]
		[FieldOffset(Offset = "0xD8")]
		private AVGPlaybackTextView.VirtualView m_multilineView;

		// Token: 0x0400C62E RID: 50734
		[Token(Token = "0x400C62E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0400C62F RID: 50735
		[Token(Token = "0x400C62F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPointerClick;

		// Token: 0x0400C630 RID: 50736
		[Token(Token = "0x400C630")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C631 RID: 50737
		[Token(Token = "0x400C631")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C632 RID: 50738
		[Token(Token = "0x400C632")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteDialog;

		// Token: 0x0400C633 RID: 50739
		[Token(Token = "0x400C633")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ExecuteDecision;

		// Token: 0x0400C634 RID: 50740
		[Token(Token = "0x400C634")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ExecutePredicate;

		// Token: 0x0400C635 RID: 50741
		[Token(Token = "0x400C635")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteSubtitle;

		// Token: 0x0400C636 RID: 50742
		[Token(Token = "0x400C636")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExecuteAside;

		// Token: 0x0400C637 RID: 50743
		[Token(Token = "0x400C637")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExecuteMultiline;

		// Token: 0x0400C638 RID: 50744
		[Token(Token = "0x400C638")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryEndMultilineMode;

		// Token: 0x0400C639 RID: 50745
		[Token(Token = "0x400C639")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ExecuteSticker;

		// Token: 0x0400C63A RID: 50746
		[Token(Token = "0x400C63A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ExecuteAnimText;

		// Token: 0x0400C63B RID: 50747
		[Token(Token = "0x400C63B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetLastCurrentIcon;

		// Token: 0x0400C63C RID: 50748
		[Token(Token = "0x400C63C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x0400C63D RID: 50749
		[Token(Token = "0x400C63D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_fadeSwitchTween;

		// Token: 0x0400C63E RID: 50750
		[Token(Token = "0x400C63E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateShown;

		// Token: 0x0400C63F RID: 50751
		[Token(Token = "0x400C63F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetScrollSlide;

		// Token: 0x0400C640 RID: 50752
		[Token(Token = "0x400C640")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isShown;

		// Token: 0x0400C641 RID: 50753
		[Token(Token = "0x400C641")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_isShown;

		// Token: 0x0400C642 RID: 50754
		[Token(Token = "0x400C642")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnCloseBtnClicked;

		// Token: 0x0400C643 RID: 50755
		[Token(Token = "0x400C643")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C644 RID: 50756
		[Token(Token = "0x400C644")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001ED7 RID: 7895
		[Token(Token = "0x2001ED7")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0600C3E6 RID: 50150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3E6")]
			[Address(RVA = "0x341BFF0", Offset = "0x341ABF0", VA = "0x18341BFF0")]
			public SwitchTween(CanvasGroup alphaHandler, float duration = 0.16f)
			{
			}

			// Token: 0x0600C3E7 RID: 50151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C3E7")]
			[Address(RVA = "0x341BDA0", Offset = "0x341A9A0", VA = "0x18341BDA0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0600C3E8 RID: 50152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C3E8")]
			[Address(RVA = "0x341BE70", Offset = "0x341AA70", VA = "0x18341BE70", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0600C3E9 RID: 50153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3E9")]
			[Address(RVA = "0x341BD00", Offset = "0x341A900", VA = "0x18341BD00", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0600C3EA RID: 50154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3EA")]
			[Address(RVA = "0x341BC80", Offset = "0x341A880", VA = "0x18341BC80", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0600C3EB RID: 50155 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3EB")]
			[Address(RVA = "0x341BF40", Offset = "0x341AB40", VA = "0x18341BF40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0600C3EC RID: 50156 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3EC")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0600C3ED RID: 50157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3ED")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0600C3EE RID: 50158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3EE")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0400C645 RID: 50757
			[Token(Token = "0x400C645")]
			[FieldOffset(Offset = "0x48")]
			private CanvasGroup m_alphaHandler;

			// Token: 0x0400C646 RID: 50758
			[Token(Token = "0x400C646")]
			[FieldOffset(Offset = "0x50")]
			private float m_duration;

			// Token: 0x0400C647 RID: 50759
			[Token(Token = "0x400C647")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400C648 RID: 50760
			[Token(Token = "0x400C648")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0400C649 RID: 50761
			[Token(Token = "0x400C649")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0400C64A RID: 50762
			[Token(Token = "0x400C64A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0400C64B RID: 50763
			[Token(Token = "0x400C64B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0400C64C RID: 50764
			[Token(Token = "0x400C64C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02001ED8 RID: 7896
		[Token(Token = "0x2001ED8")]
		protected class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0600C3EF RID: 50159 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3EF")]
			[Address(RVA = "0x34071D0", Offset = "0x3405DD0", VA = "0x1834071D0")]
			public Adapter(PlaybackPanel closure)
			{
			}

			// Token: 0x0600C3F0 RID: 50160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C3F0")]
			[Address(RVA = "0x3406EB0", Offset = "0x3405AB0", VA = "0x183406EB0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0600C3F1 RID: 50161 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C3F1")]
			[Address(RVA = "0x3407000", Offset = "0x3405C00", VA = "0x183407000")]
			public AVGPlaybackTextView.VirtualView GetLastCell()
			{
				return null;
			}

			// Token: 0x0600C3F2 RID: 50162 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3F2")]
			[Address(RVA = "0x3406D50", Offset = "0x3405950", VA = "0x183406D50")]
			public void AddCell(AVGPlaybackTextView.VirtualView view)
			{
			}

			// Token: 0x0600C3F3 RID: 50163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C3F3")]
			[Address(RVA = "0x34070A0", Offset = "0x3405CA0", VA = "0x1834070A0")]
			public void NotifyViewChanged(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0400C64D RID: 50765
			[Token(Token = "0x400C64D")]
			[FieldOffset(Offset = "0x18")]
			public PlaybackPanel m_closure;

			// Token: 0x0400C64E RID: 50766
			[Token(Token = "0x400C64E")]
			[FieldOffset(Offset = "0x20")]
			private List<AVGPlaybackTextView.VirtualView> m_cells;

			// Token: 0x0400C64F RID: 50767
			[Token(Token = "0x400C64F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400C650 RID: 50768
			[Token(Token = "0x400C650")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0400C651 RID: 50769
			[Token(Token = "0x400C651")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetLastCell;

			// Token: 0x0400C652 RID: 50770
			[Token(Token = "0x400C652")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AddCell;

			// Token: 0x0400C653 RID: 50771
			[Token(Token = "0x400C653")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_NotifyViewChanged;
		}
	}
}
