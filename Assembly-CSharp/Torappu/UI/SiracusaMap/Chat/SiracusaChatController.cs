using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Chat;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FCB RID: 16331
	[Token(Token = "0x2003FCB")]
	public class SiracusaChatController : DataBinder<SiracusaMapChatProperty>, IHotfixable
	{
		// Token: 0x06019500 RID: 103680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019500")]
		[Address(RVA = "0x1205AB0", Offset = "0x12046B0", VA = "0x181205AB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019501 RID: 103681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019501")]
		[Address(RVA = "0x12035B0", Offset = "0x12021B0", VA = "0x1812035B0")]
		public void BindBridge(SiracusaMapChatState.IBridge bridge)
		{
		}

		// Token: 0x06019502 RID: 103682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019502")]
		[Address(RVA = "0x1203740", Offset = "0x1202340", VA = "0x181203740", Slot = "7")]
		public override void OnValueChanged(SiracusaMapChatProperty property)
		{
		}

		// Token: 0x06019503 RID: 103683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019503")]
		[Address(RVA = "0x1203CD0", Offset = "0x12028D0", VA = "0x181203CD0")]
		public void SkipEvent()
		{
		}

		// Token: 0x06019504 RID: 103684 RVA: 0x0009DB00 File Offset: 0x0009BD00
		[Token(Token = "0x6019504")]
		[Address(RVA = "0x1204B50", Offset = "0x1203750", VA = "0x181204B50")]
		private ChatItemOptions _CreateDialogItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x06019505 RID: 103685 RVA: 0x0009DB18 File Offset: 0x0009BD18
		[Token(Token = "0x6019505")]
		[Address(RVA = "0x1204F60", Offset = "0x1203B60", VA = "0x181204F60")]
		private ChatItemOptions _CreateNarrationItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x06019506 RID: 103686 RVA: 0x0009DB30 File Offset: 0x0009BD30
		[Token(Token = "0x6019506")]
		[Address(RVA = "0x12057B0", Offset = "0x12043B0", VA = "0x1812057B0")]
		private ChatItemOptions _CreateVoiceWithinItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x06019507 RID: 103687 RVA: 0x0009DB48 File Offset: 0x0009BD48
		[Token(Token = "0x6019507")]
		[Address(RVA = "0x12041F0", Offset = "0x1202DF0", VA = "0x1812041F0")]
		private ChatItemOptions _CreateDecisionItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x06019508 RID: 103688 RVA: 0x0009DB60 File Offset: 0x0009BD60
		[Token(Token = "0x6019508")]
		[Address(RVA = "0x1205200", Offset = "0x1203E00", VA = "0x181205200")]
		private ChatItemOptions _CreateObtainItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x06019509 RID: 103689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019509")]
		[Address(RVA = "0x1205710", Offset = "0x1204310", VA = "0x181205710")]
		private IChatDelayView _CreatePreDelayView()
		{
			return null;
		}

		// Token: 0x0601950A RID: 103690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601950A")]
		[Address(RVA = "0x1203D60", Offset = "0x1202960", VA = "0x181203D60")]
		private IList<ChatItemOptions> _BaseCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x0601950B RID: 103691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601950B")]
		[Address(RVA = "0x1206160", Offset = "0x1204D60", VA = "0x181206160")]
		private IList<ChatItemOptions> _MainCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x0601950C RID: 103692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601950C")]
		[Address(RVA = "0x1206AE0", Offset = "0x12056E0", VA = "0x181206AE0")]
		private void _Play()
		{
		}

		// Token: 0x0601950D RID: 103693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601950D")]
		[Address(RVA = "0x1207720", Offset = "0x1206320", VA = "0x181207720")]
		private void _Skip()
		{
		}

		// Token: 0x0601950E RID: 103694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601950E")]
		[Address(RVA = "0x1206E30", Offset = "0x1205A30", VA = "0x181206E30")]
		private void _Replay()
		{
		}

		// Token: 0x0601950F RID: 103695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601950F")]
		[Address(RVA = "0x12070A0", Offset = "0x1205CA0", VA = "0x1812070A0")]
		private void _SetPauseIfPlaying(bool isPaused)
		{
		}

		// Token: 0x06019510 RID: 103696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019510")]
		[Address(RVA = "0x1204100", Offset = "0x1202D00", VA = "0x181204100")]
		private void _ClearPlaying()
		{
		}

		// Token: 0x06019511 RID: 103697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019511")]
		[Address(RVA = "0x1205F40", Offset = "0x1204B40", VA = "0x181205F40")]
		private void _InterruptPlaying()
		{
		}

		// Token: 0x06019512 RID: 103698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019512")]
		[Address(RVA = "0x1205E40", Offset = "0x1204A40", VA = "0x181205E40")]
		private string _InsertFetcher(string optionId)
		{
			return null;
		}

		// Token: 0x06019513 RID: 103699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019513")]
		[Address(RVA = "0x12069B0", Offset = "0x12055B0", VA = "0x1812069B0")]
		private void _OnOptionSelected(string optionId)
		{
		}

		// Token: 0x06019514 RID: 103700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019514")]
		[Address(RVA = "0x1206910", Offset = "0x1205510", VA = "0x181206910")]
		private void _OnItemObtained(string itemId)
		{
		}

		// Token: 0x06019515 RID: 103701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019515")]
		[Address(RVA = "0x1206A40", Offset = "0x1205640", VA = "0x181206A40")]
		private void _OnPlayComplete()
		{
		}

		// Token: 0x06019516 RID: 103702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019516")]
		[Address(RVA = "0x1206020", Offset = "0x1204C20", VA = "0x181206020")]
		private Sprite _LoadSiracusaAvatar(string avatarId)
		{
			return null;
		}

		// Token: 0x06019517 RID: 103703 RVA: 0x0009DB78 File Offset: 0x0009BD78
		[Token(Token = "0x6019517")]
		[Address(RVA = "0x1203630", Offset = "0x1202230", VA = "0x181203630")]
		public static bool CheckIfOptionCanSelect(HashSet<string> selectedOptionSet, HashSet<string> obtainItemSet, bool isCharCommentLike, string optionId, bool needCommentLike, string requiredCardId)
		{
			return default(bool);
		}

		// Token: 0x06019518 RID: 103704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019518")]
		[Address(RVA = "0x1207130", Offset = "0x1205D30", VA = "0x181207130")]
		private void _ShowSkipButton(bool show)
		{
		}

		// Token: 0x06019519 RID: 103705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019519")]
		[Address(RVA = "0x12063B0", Offset = "0x1204FB0", VA = "0x1812063B0")]
		private void _NormalRecordFilter(IList<ChatItemOptions> inputItems, List<ChatItemOptions> outputRecords, List<ChatItemOptions> outputPlayables)
		{
		}

		// Token: 0x0601951A RID: 103706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601951A")]
		[Address(RVA = "0x12071C0", Offset = "0x1205DC0", VA = "0x1812071C0")]
		private void _SkipRecordFilter(IList<ChatItemOptions> inputItems, List<ChatItemOptions> outputRecords, List<ChatItemOptions> outputPlayables)
		{
		}

		// Token: 0x0601951B RID: 103707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601951B")]
		[Address(RVA = "0x1207AB0", Offset = "0x12066B0", VA = "0x181207AB0")]
		public SiracusaChatController()
		{
		}

		// Token: 0x0401F734 RID: 128820
		[Token(Token = "0x401F734")]
		private const float MOVE_DUR = 0.3f;

		// Token: 0x0401F735 RID: 128821
		[Token(Token = "0x401F735")]
		private const ScrollRect.MovementType SCORLL_MOVEMENT_TYPE = ScrollRect.MovementType.Elastic;

		// Token: 0x0401F736 RID: 128822
		[Token(Token = "0x401F736")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGChatBoxController _chatController;

		// Token: 0x0401F737 RID: 128823
		[Token(Token = "0x401F737")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollType;

		// Token: 0x0401F738 RID: 128824
		[Token(Token = "0x401F738")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatDialogComp _dialogSelfPrefab;

		// Token: 0x0401F739 RID: 128825
		[Token(Token = "0x401F739")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatDialogComp _dialogOtherPrefab;

		// Token: 0x0401F73A RID: 128826
		[Token(Token = "0x401F73A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatNarrationComp _narrationPrefab;

		// Token: 0x0401F73B RID: 128827
		[Token(Token = "0x401F73B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatDialogComp _voiceWithinPrefab;

		// Token: 0x0401F73C RID: 128828
		[Token(Token = "0x401F73C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatDecisionComp _decisionPrefab;

		// Token: 0x0401F73D RID: 128829
		[Token(Token = "0x401F73D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatObtainComp _obtainPrefab;

		// Token: 0x0401F73E RID: 128830
		[Token(Token = "0x401F73E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ChatItems")]
		private SiracusaChatEndComp _endPrefab;

		// Token: 0x0401F73F RID: 128831
		[Token(Token = "0x401F73F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatSimpleComp _loadingPrefab;

		// Token: 0x0401F740 RID: 128832
		[Token(Token = "0x401F740")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _skipBtnCanvasGroup;

		// Token: 0x0401F741 RID: 128833
		[Token(Token = "0x401F741")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0401F742 RID: 128834
		[Token(Token = "0x401F742")]
		[FieldOffset(Offset = "0x80")]
		private ListDict<string, Func<Command, ChatItemOptions>> m_cmdHandlers;

		// Token: 0x0401F743 RID: 128835
		[Token(Token = "0x401F743")]
		[FieldOffset(Offset = "0x88")]
		private SiracusaData m_data;

		// Token: 0x0401F744 RID: 128836
		[Token(Token = "0x401F744")]
		[FieldOffset(Offset = "0x90")]
		private readonly Dictionary<string, SiracusaChatDecisionComp.OptionModel> m_playingOptions;

		// Token: 0x0401F745 RID: 128837
		[Token(Token = "0x401F745")]
		[FieldOffset(Offset = "0x98")]
		private readonly Dictionary<SiracusaChatDecisionComp.VirtualView, SiracusaChatDecisionComp.ViewModel> m_playingDecisions;

		// Token: 0x0401F746 RID: 128838
		[Token(Token = "0x401F746")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Dictionary<SiracusaChatObtainComp.VirtualView, SiracusaChatObtainComp.ViewModel> m_playingObtains;

		// Token: 0x0401F747 RID: 128839
		[Token(Token = "0x401F747")]
		[FieldOffset(Offset = "0xA8")]
		private HashSet<string> m_cachedSelectedOptions;

		// Token: 0x0401F748 RID: 128840
		[Token(Token = "0x401F748")]
		[FieldOffset(Offset = "0xB0")]
		private HashSet<string> m_cachedObtainedItems;

		// Token: 0x0401F749 RID: 128841
		[Token(Token = "0x401F749")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_cachedIsCharCommentLike;

		// Token: 0x0401F74A RID: 128842
		[Token(Token = "0x401F74A")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedStoryId;

		// Token: 0x0401F74B RID: 128843
		[Token(Token = "0x401F74B")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedIsReplay;

		// Token: 0x0401F74C RID: 128844
		[Token(Token = "0x401F74C")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_alreadySkip;

		// Token: 0x0401F74D RID: 128845
		[Token(Token = "0x401F74D")]
		[FieldOffset(Offset = "0xD0")]
		private SiracusaMapChatState.IBridge m_bridge;

		// Token: 0x0401F74E RID: 128846
		[Token(Token = "0x401F74E")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401F74F RID: 128847
		[Token(Token = "0x401F74F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F750 RID: 128848
		[Token(Token = "0x401F750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindBridge;

		// Token: 0x0401F751 RID: 128849
		[Token(Token = "0x401F751")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F752 RID: 128850
		[Token(Token = "0x401F752")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SkipEvent;

		// Token: 0x0401F753 RID: 128851
		[Token(Token = "0x401F753")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateDialogItem;

		// Token: 0x0401F754 RID: 128852
		[Token(Token = "0x401F754")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateNarrationItem;

		// Token: 0x0401F755 RID: 128853
		[Token(Token = "0x401F755")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateVoiceWithinItem;

		// Token: 0x0401F756 RID: 128854
		[Token(Token = "0x401F756")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateDecisionItem;

		// Token: 0x0401F757 RID: 128855
		[Token(Token = "0x401F757")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateObtainItem;

		// Token: 0x0401F758 RID: 128856
		[Token(Token = "0x401F758")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreatePreDelayView;

		// Token: 0x0401F759 RID: 128857
		[Token(Token = "0x401F759")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__BaseCommandHandler;

		// Token: 0x0401F75A RID: 128858
		[Token(Token = "0x401F75A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__MainCommandHandler;

		// Token: 0x0401F75B RID: 128859
		[Token(Token = "0x401F75B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Play;

		// Token: 0x0401F75C RID: 128860
		[Token(Token = "0x401F75C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__Skip;

		// Token: 0x0401F75D RID: 128861
		[Token(Token = "0x401F75D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__Replay;

		// Token: 0x0401F75E RID: 128862
		[Token(Token = "0x401F75E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetPauseIfPlaying;

		// Token: 0x0401F75F RID: 128863
		[Token(Token = "0x401F75F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ClearPlaying;

		// Token: 0x0401F760 RID: 128864
		[Token(Token = "0x401F760")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InterruptPlaying;

		// Token: 0x0401F761 RID: 128865
		[Token(Token = "0x401F761")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InsertFetcher;

		// Token: 0x0401F762 RID: 128866
		[Token(Token = "0x401F762")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnOptionSelected;

		// Token: 0x0401F763 RID: 128867
		[Token(Token = "0x401F763")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnItemObtained;

		// Token: 0x0401F764 RID: 128868
		[Token(Token = "0x401F764")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnPlayComplete;

		// Token: 0x0401F765 RID: 128869
		[Token(Token = "0x401F765")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__LoadSiracusaAvatar;

		// Token: 0x0401F766 RID: 128870
		[Token(Token = "0x401F766")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckIfOptionCanSelect;

		// Token: 0x0401F767 RID: 128871
		[Token(Token = "0x401F767")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ShowSkipButton;

		// Token: 0x0401F768 RID: 128872
		[Token(Token = "0x401F768")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__NormalRecordFilter;

		// Token: 0x0401F769 RID: 128873
		[Token(Token = "0x401F769")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SkipRecordFilter;

		// Token: 0x0401F76A RID: 128874
		[Token(Token = "0x401F76A")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
