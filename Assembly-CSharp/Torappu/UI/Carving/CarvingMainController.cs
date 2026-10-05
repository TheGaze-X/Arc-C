using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200607B RID: 24699
	[Token(Token = "0x200607B")]
	public class CarvingMainController : PageSingleComponent, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x1700545F RID: 21599
		// (get) Token: 0x06023B72 RID: 146290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700545F")]
		public CarvingMainProperty mainProperty
		{
			[Token(Token = "0x6023B72")]
			[Address(RVA = "0x1E60BA0", Offset = "0x1E5F7A0", VA = "0x181E60BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005460 RID: 21600
		// (get) Token: 0x06023B73 RID: 146291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005460")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6023B73")]
			[Address(RVA = "0x1E60B40", Offset = "0x1E5F740", VA = "0x181E60B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x06023B74 RID: 146292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005461")]
		public TouchHandler touchHandler
		{
			[Token(Token = "0x6023B74")]
			[Address(RVA = "0x1E60C00", Offset = "0x1E5F800", VA = "0x181E60C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023B75 RID: 146293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B75")]
		[Address(RVA = "0x1E5C770", Offset = "0x1E5B370", VA = "0x181E5C770", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06023B76 RID: 146294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B76")]
		[Address(RVA = "0x1E5C8D0", Offset = "0x1E5B4D0", VA = "0x181E5C8D0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06023B77 RID: 146295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B77")]
		[Address(RVA = "0x1E5DB10", Offset = "0x1E5C710", VA = "0x181E5DB10")]
		public void RegisterSlotViewListToDragHandler(List<CarvingMainCardDeskView.CarvingSlot> carvingSlots)
		{
		}

		// Token: 0x06023B78 RID: 146296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B78")]
		[Address(RVA = "0x1E5C9D0", Offset = "0x1E5B5D0", VA = "0x181E5C9D0", Slot = "12")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06023B79 RID: 146297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B79")]
		[Address(RVA = "0x1E5FB40", Offset = "0x1E5E740", VA = "0x181E5FB40")]
		private void _OnShopSelectSlot()
		{
		}

		// Token: 0x06023B7A RID: 146298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7A")]
		[Address(RVA = "0x1E5FA40", Offset = "0x1E5E640", VA = "0x181E5FA40")]
		private void _OnShopSelectCard(int pos)
		{
		}

		// Token: 0x06023B7B RID: 146299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7B")]
		[Address(RVA = "0x1E5F6F0", Offset = "0x1E5E2F0", VA = "0x181E5F6F0")]
		private void _OnShopRefresh()
		{
		}

		// Token: 0x06023B7C RID: 146300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7C")]
		[Address(RVA = "0x1E5F4D0", Offset = "0x1E5E0D0", VA = "0x181E5F4D0")]
		private void _OnShopBuyGood()
		{
		}

		// Token: 0x06023B7D RID: 146301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7D")]
		[Address(RVA = "0x1E5E040", Offset = "0x1E5CC40", VA = "0x181E5E040")]
		private void _BuySlot()
		{
		}

		// Token: 0x06023B7E RID: 146302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7E")]
		[Address(RVA = "0x1E5DD30", Offset = "0x1E5C930", VA = "0x181E5DD30")]
		private void _BuyCard()
		{
		}

		// Token: 0x06023B7F RID: 146303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B7F")]
		[Address(RVA = "0x1E5FC00", Offset = "0x1E5E800", VA = "0x181E5FC00")]
		private void _OnShopToProcess()
		{
		}

		// Token: 0x06023B80 RID: 146304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B80")]
		[Address(RVA = "0x1E5EA70", Offset = "0x1E5D670", VA = "0x181E5EA70")]
		private void _OnCardSelected(string cardId)
		{
		}

		// Token: 0x06023B81 RID: 146305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B81")]
		[Address(RVA = "0x1E600D0", Offset = "0x1E5ECD0", VA = "0x181E600D0")]
		private void _OnSlotClickedWhenHandSelected()
		{
		}

		// Token: 0x06023B82 RID: 146306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B82")]
		[Address(RVA = "0x1E5F3D0", Offset = "0x1E5DFD0", VA = "0x181E5F3D0")]
		private void _OnRegisterTutorialGO()
		{
		}

		// Token: 0x06023B83 RID: 146307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B83")]
		[Address(RVA = "0x1E5F2D0", Offset = "0x1E5DED0", VA = "0x181E5F2D0")]
		private void _OnHandCardDraggedOut(string cardId)
		{
		}

		// Token: 0x06023B84 RID: 146308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B84")]
		[Address(RVA = "0x1E5FFB0", Offset = "0x1E5EBB0", VA = "0x181E5FFB0")]
		private void _OnSlotCardDraggedOut(string cardId)
		{
		}

		// Token: 0x06023B85 RID: 146309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B85")]
		[Address(RVA = "0x1E5F060", Offset = "0x1E5DC60", VA = "0x181E5F060")]
		private void _OnDragCancelToHandCard(string cardId)
		{
		}

		// Token: 0x06023B86 RID: 146310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B86")]
		[Address(RVA = "0x1E5F140", Offset = "0x1E5DD40", VA = "0x181E5F140")]
		private void _OnDragCancelToSlotCard(ValueBundle param)
		{
		}

		// Token: 0x06023B87 RID: 146311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B87")]
		[Address(RVA = "0x1E60340", Offset = "0x1E5EF40", VA = "0x181E60340")]
		private void _OnTokenHoverSlotChanged(ValueBundle param)
		{
		}

		// Token: 0x06023B88 RID: 146312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B88")]
		[Address(RVA = "0x1E60450", Offset = "0x1E5F050", VA = "0x181E60450")]
		private void _OnTokenMovedIntoSlot(string cardId)
		{
		}

		// Token: 0x06023B89 RID: 146313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B89")]
		[Address(RVA = "0x1E60220", Offset = "0x1E5EE20", VA = "0x181E60220")]
		private void _OnTokenHoverInHandAreaChanged(ValueBundle param)
		{
		}

		// Token: 0x06023B8A RID: 146314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B8A")]
		[Address(RVA = "0x1E5D8B0", Offset = "0x1E5C4B0", VA = "0x181E5D8B0")]
		public void OpenIntroDialogIfNeed(PlayerActivity.PlayerAct35SideActivity.GameState gameState, Act35SideData.DialogueType dialogueType, out int instId)
		{
		}

		// Token: 0x06023B8B RID: 146315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B8B")]
		[Address(RVA = "0x1E5C470", Offset = "0x1E5B070", VA = "0x181E5C470")]
		public string GetCurrentTutorialTriggerKey(PlayerActivity.PlayerAct35SideActivity.GameState gameState)
		{
			return null;
		}

		// Token: 0x06023B8C RID: 146316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B8C")]
		[Address(RVA = "0x1E5EC30", Offset = "0x1E5D830", VA = "0x181E5EC30")]
		private void _OnClickProcessBtn()
		{
		}

		// Token: 0x06023B8D RID: 146317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B8D")]
		[Address(RVA = "0x1E5EB70", Offset = "0x1E5D770", VA = "0x181E5EB70")]
		private void _OnClickCardDetailBlocker()
		{
		}

		// Token: 0x06023B8E RID: 146318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B8E")]
		[Address(RVA = "0x1E5E320", Offset = "0x1E5CF20", VA = "0x181E5E320")]
		private void _CheckChallengeInfo()
		{
		}

		// Token: 0x06023B8F RID: 146319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B8F")]
		[Address(RVA = "0x1E5E3B0", Offset = "0x1E5CFB0", VA = "0x181E5E3B0")]
		private void _CheckHandbook(bool isNeedDarken)
		{
		}

		// Token: 0x06023B90 RID: 146320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B90")]
		[Address(RVA = "0x1E60970", Offset = "0x1E5F570", VA = "0x181E60970")]
		private void _StartDragBlocker()
		{
		}

		// Token: 0x06023B91 RID: 146321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B91")]
		[Address(RVA = "0x1E5E670", Offset = "0x1E5D270", VA = "0x181E5E670")]
		private void _EndDragBlocker()
		{
		}

		// Token: 0x06023B92 RID: 146322 RVA: 0x000C1BF0 File Offset: 0x000BFDF0
		[Token(Token = "0x6023B92")]
		[Address(RVA = "0x1E5C330", Offset = "0x1E5AF30", VA = "0x181E5C330")]
		public bool CheckIsTriggerUnlockChallengeToast()
		{
			return default(bool);
		}

		// Token: 0x06023B93 RID: 146323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B93")]
		[Address(RVA = "0x1E5E6E0", Offset = "0x1E5D2E0", VA = "0x181E5E6E0")]
		private void _InitController()
		{
		}

		// Token: 0x06023B94 RID: 146324 RVA: 0x000C1C08 File Offset: 0x000BFE08
		[Token(Token = "0x6023B94")]
		[Address(RVA = "0x1E5E530", Offset = "0x1E5D130", VA = "0x181E5E530")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x06023B95 RID: 146325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B95")]
		[Address(RVA = "0x1E60880", Offset = "0x1E5F480", VA = "0x181E60880")]
		private IEnumerator _ProcessCoroutine(List<CarvingProcessFrame> frames, int fromScore)
		{
			return null;
		}

		// Token: 0x06023B96 RID: 146326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023B96")]
		[Address(RVA = "0x1E609E0", Offset = "0x1E5F5E0", VA = "0x181E609E0")]
		private IEnumerator _TriggerBonus()
		{
			return null;
		}

		// Token: 0x06023B97 RID: 146327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B97")]
		[Address(RVA = "0x1E60760", Offset = "0x1E5F360", VA = "0x181E60760")]
		private void _PlayCardBounceAudio(CarvingMainProcessModel processModel)
		{
		}

		// Token: 0x06023B98 RID: 146328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B98")]
		[Address(RVA = "0x1E60530", Offset = "0x1E5F130", VA = "0x181E60530")]
		private void _OpenBonusDialog()
		{
		}

		// Token: 0x06023B99 RID: 146329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B99")]
		[Address(RVA = "0x1E5C550", Offset = "0x1E5B150", VA = "0x181E5C550", Slot = "13")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06023B9A RID: 146330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B9A")]
		[Address(RVA = "0x1E5C600", Offset = "0x1E5B200", VA = "0x181E5C600")]
		public void OnClickBackBtn()
		{
		}

		// Token: 0x06023B9B RID: 146331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B9B")]
		[Address(RVA = "0x1E5DB90", Offset = "0x1E5C790", VA = "0x181E5DB90")]
		public void SetBackBtnActive(bool isShow, bool isInfo = false)
		{
		}

		// Token: 0x06023B9C RID: 146332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B9C")]
		[Address(RVA = "0x1E60A90", Offset = "0x1E5F690", VA = "0x181E60A90")]
		public CarvingMainController()
		{
		}

		// Token: 0x06023B9E RID: 146334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B9E")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06023B9F RID: 146335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023B9F")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x040317FF RID: 202751
		[Token(Token = "0x40317FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04031800 RID: 202752
		[Token(Token = "0x4031800")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Card Detail")]
		private CarvingMainCardDetailView _cardDetailViewPrefab;

		// Token: 0x04031801 RID: 202753
		[Token(Token = "0x4031801")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CarvingBoardView _boardView;

		// Token: 0x04031802 RID: 202754
		[Token(Token = "0x4031802")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelHandCard;

		// Token: 0x04031803 RID: 202755
		[Token(Token = "0x4031803")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelGoldCount;

		// Token: 0x04031804 RID: 202756
		[Token(Token = "0x4031804")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tutorial")]
		private CarvingAVGAdapter _tutorialAdapter;

		// Token: 0x04031805 RID: 202757
		[Token(Token = "0x4031805")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Challenge Task")]
		private CarvingMainChallengeTaskView _taskViewPrefab;

		// Token: 0x04031806 RID: 202758
		[Token(Token = "0x4031806")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Card Detail")]
		private Transform _detailHolder;

		// Token: 0x04031807 RID: 202759
		[Token(Token = "0x4031807")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Challenge Task")]
		private Transform _taskHolder;

		// Token: 0x04031808 RID: 202760
		[Token(Token = "0x4031808")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _topBackMenu;

		// Token: 0x04031809 RID: 202761
		[Token(Token = "0x4031809")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _topBackBtnTxt;

		// Token: 0x0403180A RID: 202762
		[Token(Token = "0x403180A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403180B RID: 202763
		[Token(Token = "0x403180B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _processFrameDuration;

		// Token: 0x0403180C RID: 202764
		[Token(Token = "0x403180C")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _processEndDuration;

		// Token: 0x0403180D RID: 202765
		[Token(Token = "0x403180D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _dragBlocker;

		// Token: 0x0403180E RID: 202766
		[Token(Token = "0x403180E")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403180F RID: 202767
		[Token(Token = "0x403180F")]
		[FieldOffset(Offset = "0x98")]
		private string m_actId;

		// Token: 0x04031810 RID: 202768
		[Token(Token = "0x4031810")]
		[FieldOffset(Offset = "0xA0")]
		private CarvingMainProperty m_mainProperty;

		// Token: 0x04031811 RID: 202769
		[Token(Token = "0x4031811")]
		[FieldOffset(Offset = "0xA8")]
		private CarvingMainCardDetailView m_cardDetailView;

		// Token: 0x04031812 RID: 202770
		[Token(Token = "0x4031812")]
		[FieldOffset(Offset = "0xB0")]
		private CarvingMainChallengeTaskView m_taskView;

		// Token: 0x04031813 RID: 202771
		[Token(Token = "0x4031813")]
		[FieldOffset(Offset = "0xB8")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04031814 RID: 202772
		[Token(Token = "0x4031814")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine m_processCoroutine;

		// Token: 0x04031815 RID: 202773
		[Token(Token = "0x4031815")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isBonusing;

		// Token: 0x04031816 RID: 202774
		[Token(Token = "0x4031816")]
		[FieldOffset(Offset = "0xCC")]
		private int m_createGameSeqNum;

		// Token: 0x04031817 RID: 202775
		[Token(Token = "0x4031817")]
		[FieldOffset(Offset = "0xD0")]
		private int m_handbookDialogInstId;

		// Token: 0x04031818 RID: 202776
		[Token(Token = "0x4031818")]
		[FieldOffset(Offset = "0xD4")]
		private int m_bonusDialogInstId;

		// Token: 0x04031819 RID: 202777
		[Token(Token = "0x4031819")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isDragging;

		// Token: 0x0403181A RID: 202778
		[Token(Token = "0x403181A")]
		[NonSerialized]
		public const int COMMON_CHECK_INFO = 0;

		// Token: 0x0403181B RID: 202779
		[Token(Token = "0x403181B")]
		[NonSerialized]
		public const int COMMON_ON_CLICK_CARD_DETAIL_BLOCK = 1;

		// Token: 0x0403181C RID: 202780
		[Token(Token = "0x403181C")]
		[NonSerialized]
		public const int COMMON_CHECK_HANDBOOK = 2;

		// Token: 0x0403181D RID: 202781
		[Token(Token = "0x403181D")]
		[NonSerialized]
		public const int CHECK_HANDBOOK_DONOT_NEED_DARK = 0;

		// Token: 0x0403181E RID: 202782
		[Token(Token = "0x403181E")]
		[NonSerialized]
		public const int CHECK_HANDBOOK_NEED_DARK = 1;

		// Token: 0x0403181F RID: 202783
		[Token(Token = "0x403181F")]
		[NonSerialized]
		public const int SHOP_SELECT_SLOT = 10;

		// Token: 0x04031820 RID: 202784
		[Token(Token = "0x4031820")]
		[NonSerialized]
		public const int SHOP_SELECT_CARD = 11;

		// Token: 0x04031821 RID: 202785
		[Token(Token = "0x4031821")]
		[NonSerialized]
		public const int SHOP_REFRESH = 12;

		// Token: 0x04031822 RID: 202786
		[Token(Token = "0x4031822")]
		[NonSerialized]
		public const int SHOP_BUY = 13;

		// Token: 0x04031823 RID: 202787
		[Token(Token = "0x4031823")]
		[NonSerialized]
		public const int SHOP_TO_PROCESS = 14;

		// Token: 0x04031824 RID: 202788
		[Token(Token = "0x4031824")]
		[NonSerialized]
		public const int BOARD_PROCESS = 20;

		// Token: 0x04031825 RID: 202789
		[Token(Token = "0x4031825")]
		[NonSerialized]
		public const int BOARD_SLOT_CLICKED = 21;

		// Token: 0x04031826 RID: 202790
		[Token(Token = "0x4031826")]
		[NonSerialized]
		public const int CARD_SELECTED = 30;

		// Token: 0x04031827 RID: 202791
		[Token(Token = "0x4031827")]
		[NonSerialized]
		public const int MSG_HAND_CARD_DRAGGED_OUT = 31;

		// Token: 0x04031828 RID: 202792
		[Token(Token = "0x4031828")]
		[NonSerialized]
		public const int MSG_SLOT_CARD_DRAGGED_OUT = 32;

		// Token: 0x04031829 RID: 202793
		[Token(Token = "0x4031829")]
		[NonSerialized]
		public const int MSG_DRAG_CANCEL_TO_HAND_CARD = 33;

		// Token: 0x0403182A RID: 202794
		[Token(Token = "0x403182A")]
		[NonSerialized]
		public const int MSG_DRAG_CANCEL_TO_SLOT_CARD = 34;

		// Token: 0x0403182B RID: 202795
		[Token(Token = "0x403182B")]
		[NonSerialized]
		public const int MSG_SLOT_CLICKED_WHEN_HAND_SELECTED = 35;

		// Token: 0x0403182C RID: 202796
		[Token(Token = "0x403182C")]
		[NonSerialized]
		public const int MSG_TOKEN_HOVER_SLOT_CHANGED = 36;

		// Token: 0x0403182D RID: 202797
		[Token(Token = "0x403182D")]
		[NonSerialized]
		public const int MSG_TOKEN_HOVER_IN_HAND_AREA_CHANGED = 37;

		// Token: 0x0403182E RID: 202798
		[Token(Token = "0x403182E")]
		[NonSerialized]
		public const int MSG_TOKEN_MOVED_INTO_SLOT = 38;

		// Token: 0x0403182F RID: 202799
		[Token(Token = "0x403182F")]
		[NonSerialized]
		public const int MSG_START_DRAG_BLOCKER = 39;

		// Token: 0x04031830 RID: 202800
		[Token(Token = "0x4031830")]
		[NonSerialized]
		public const int MSG_END_DRAG_BLOCKER = 40;

		// Token: 0x04031831 RID: 202801
		[Token(Token = "0x4031831")]
		[NonSerialized]
		public const int MSG_TUTORIAL_REGISTER_GO = 50;

		// Token: 0x04031832 RID: 202802
		[Token(Token = "0x4031832")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainProperty;

		// Token: 0x04031833 RID: 202803
		[Token(Token = "0x4031833")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x04031834 RID: 202804
		[Token(Token = "0x4031834")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_touchHandler;

		// Token: 0x04031835 RID: 202805
		[Token(Token = "0x4031835")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04031836 RID: 202806
		[Token(Token = "0x4031836")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04031837 RID: 202807
		[Token(Token = "0x4031837")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterSlotViewListToDragHandler;

		// Token: 0x04031838 RID: 202808
		[Token(Token = "0x4031838")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04031839 RID: 202809
		[Token(Token = "0x4031839")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnShopSelectSlot;

		// Token: 0x0403183A RID: 202810
		[Token(Token = "0x403183A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnShopSelectCard;

		// Token: 0x0403183B RID: 202811
		[Token(Token = "0x403183B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnShopRefresh;

		// Token: 0x0403183C RID: 202812
		[Token(Token = "0x403183C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnShopBuyGood;

		// Token: 0x0403183D RID: 202813
		[Token(Token = "0x403183D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__BuySlot;

		// Token: 0x0403183E RID: 202814
		[Token(Token = "0x403183E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BuyCard;

		// Token: 0x0403183F RID: 202815
		[Token(Token = "0x403183F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnShopToProcess;

		// Token: 0x04031840 RID: 202816
		[Token(Token = "0x4031840")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnCardSelected;

		// Token: 0x04031841 RID: 202817
		[Token(Token = "0x4031841")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSlotClickedWhenHandSelected;

		// Token: 0x04031842 RID: 202818
		[Token(Token = "0x4031842")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnRegisterTutorialGO;

		// Token: 0x04031843 RID: 202819
		[Token(Token = "0x4031843")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnHandCardDraggedOut;

		// Token: 0x04031844 RID: 202820
		[Token(Token = "0x4031844")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnSlotCardDraggedOut;

		// Token: 0x04031845 RID: 202821
		[Token(Token = "0x4031845")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnDragCancelToHandCard;

		// Token: 0x04031846 RID: 202822
		[Token(Token = "0x4031846")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnDragCancelToSlotCard;

		// Token: 0x04031847 RID: 202823
		[Token(Token = "0x4031847")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnTokenHoverSlotChanged;

		// Token: 0x04031848 RID: 202824
		[Token(Token = "0x4031848")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnTokenMovedIntoSlot;

		// Token: 0x04031849 RID: 202825
		[Token(Token = "0x4031849")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnTokenHoverInHandAreaChanged;

		// Token: 0x0403184A RID: 202826
		[Token(Token = "0x403184A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OpenIntroDialogIfNeed;

		// Token: 0x0403184B RID: 202827
		[Token(Token = "0x403184B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetCurrentTutorialTriggerKey;

		// Token: 0x0403184C RID: 202828
		[Token(Token = "0x403184C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__OnClickProcessBtn;

		// Token: 0x0403184D RID: 202829
		[Token(Token = "0x403184D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__OnClickCardDetailBlocker;

		// Token: 0x0403184E RID: 202830
		[Token(Token = "0x403184E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckChallengeInfo;

		// Token: 0x0403184F RID: 202831
		[Token(Token = "0x403184F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckHandbook;

		// Token: 0x04031850 RID: 202832
		[Token(Token = "0x4031850")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__StartDragBlocker;

		// Token: 0x04031851 RID: 202833
		[Token(Token = "0x4031851")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EndDragBlocker;

		// Token: 0x04031852 RID: 202834
		[Token(Token = "0x4031852")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckIsTriggerUnlockChallengeToast;

		// Token: 0x04031853 RID: 202835
		[Token(Token = "0x4031853")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x04031854 RID: 202836
		[Token(Token = "0x4031854")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x04031855 RID: 202837
		[Token(Token = "0x4031855")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__ProcessCoroutine;

		// Token: 0x04031856 RID: 202838
		[Token(Token = "0x4031856")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__TriggerBonus;

		// Token: 0x04031857 RID: 202839
		[Token(Token = "0x4031857")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__PlayCardBounceAudio;

		// Token: 0x04031858 RID: 202840
		[Token(Token = "0x4031858")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__OpenBonusDialog;

		// Token: 0x04031859 RID: 202841
		[Token(Token = "0x4031859")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403185A RID: 202842
		[Token(Token = "0x403185A")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OnClickBackBtn;

		// Token: 0x0403185B RID: 202843
		[Token(Token = "0x403185B")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_SetBackBtnActive;

		// Token: 0x0403185C RID: 202844
		[Token(Token = "0x403185C")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
