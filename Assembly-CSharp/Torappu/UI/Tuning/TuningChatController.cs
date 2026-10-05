using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C6D RID: 15469
	[Token(Token = "0x2003C6D")]
	public class TuningChatController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018299 RID: 98969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018299")]
		[Address(RVA = "0x10A6D60", Offset = "0x10A5960", VA = "0x1810A6D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601829A RID: 98970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601829A")]
		[Address(RVA = "0x10A5720", Offset = "0x10A4320", VA = "0x1810A5720")]
		public void Play(TuningChatController.PlayOptions options)
		{
		}

		// Token: 0x0601829B RID: 98971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601829B")]
		[Address(RVA = "0x10A5990", Offset = "0x10A4590", VA = "0x1810A5990")]
		public void Skip()
		{
		}

		// Token: 0x0601829C RID: 98972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601829C")]
		[Address(RVA = "0x10A5900", Offset = "0x10A4500", VA = "0x1810A5900")]
		public void ResetPlay()
		{
		}

		// Token: 0x0601829D RID: 98973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601829D")]
		[Address(RVA = "0x10A78C0", Offset = "0x10A64C0", VA = "0x1810A78C0")]
		private void _SkipImpl(TuningChatController.PlayOptions options)
		{
		}

		// Token: 0x0601829E RID: 98974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601829E")]
		[Address(RVA = "0x10A70C0", Offset = "0x10A5CC0", VA = "0x1810A70C0")]
		private void _PlayImpl(TuningChatController.PlayOptions options, Action<IList<ChatItemOptions>, List<ChatItemOptions>, List<ChatItemOptions>> filter, bool fromScratch)
		{
		}

		// Token: 0x0601829F RID: 98975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601829F")]
		[Address(RVA = "0x10A5C10", Offset = "0x10A4810", VA = "0x1810A5C10")]
		private IList<ChatItemOptions> _BaseCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x060182A0 RID: 98976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182A0")]
		[Address(RVA = "0x10A7470", Offset = "0x10A6070", VA = "0x1810A7470")]
		private IList<ChatItemOptions> _PlayModeCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x060182A1 RID: 98977 RVA: 0x000999C0 File Offset: 0x00097BC0
		[Token(Token = "0x60182A1")]
		[Address(RVA = "0x10A5FA0", Offset = "0x10A4BA0", VA = "0x1810A5FA0")]
		private ChatItemOptions _CreateDialogItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x060182A2 RID: 98978 RVA: 0x000999D8 File Offset: 0x00097BD8
		[Token(Token = "0x60182A2")]
		[Address(RVA = "0x10A6B30", Offset = "0x10A5730", VA = "0x1810A6B30")]
		private ChatItemOptions _CreateTitleItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x060182A3 RID: 98979 RVA: 0x000999F0 File Offset: 0x00097BF0
		[Token(Token = "0x60182A3")]
		[Address(RVA = "0x10A6270", Offset = "0x10A4E70", VA = "0x1810A6270")]
		private ChatItemOptions _CreateDivItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x060182A4 RID: 98980 RVA: 0x00099A08 File Offset: 0x00097C08
		[Token(Token = "0x60182A4")]
		[Address(RVA = "0x10A6470", Offset = "0x10A5070", VA = "0x1810A6470")]
		private ChatItemOptions _CreateNarItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x060182A5 RID: 98981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182A5")]
		[Address(RVA = "0x10A7650", Offset = "0x10A6250", VA = "0x1810A7650")]
		private void _PlayRecordFilter(IList<ChatItemOptions> inputItems, List<ChatItemOptions> outputRecords, List<ChatItemOptions> outputPlayables)
		{
		}

		// Token: 0x060182A6 RID: 98982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182A6")]
		[Address(RVA = "0x10A79F0", Offset = "0x10A65F0", VA = "0x1810A79F0")]
		private void _SkipRecordFilter(IList<ChatItemOptions> inputItems, List<ChatItemOptions> outputRecords, List<ChatItemOptions> outputPlayables)
		{
		}

		// Token: 0x060182A7 RID: 98983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60182A7")]
		[Address(RVA = "0x10A6A10", Offset = "0x10A5610", VA = "0x1810A6A10")]
		private IChatDelayView _CreatePreDelayView()
		{
			return null;
		}

		// Token: 0x060182A8 RID: 98984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182A8")]
		[Address(RVA = "0x10A5610", Offset = "0x10A4210", VA = "0x1810A5610")]
		public void HandleNarration(int index)
		{
		}

		// Token: 0x060182A9 RID: 98985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60182A9")]
		[Address(RVA = "0x10A7F10", Offset = "0x10A6B10", VA = "0x1810A7F10")]
		public TuningChatController()
		{
		}

		// Token: 0x0401D61B RID: 120347
		[Token(Token = "0x401D61B")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static string NARRATION_STYLE_SKIP;

		// Token: 0x0401D61C RID: 120348
		[Token(Token = "0x401D61C")]
		[FieldOffset(Offset = "0x8")]
		[NonSerialized]
		public static string NARRATION_STYLE_NEXT;

		// Token: 0x0401D61D RID: 120349
		[Token(Token = "0x401D61D")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public static string NARRATION_STYLE_SUBMIT;

		// Token: 0x0401D61E RID: 120350
		[Token(Token = "0x401D61E")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public static string NARRATION_STYLE_FINISH;

		// Token: 0x0401D61F RID: 120351
		[Token(Token = "0x401D61F")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public static string DIALOG_STYLE_ASK;

		// Token: 0x0401D620 RID: 120352
		[Token(Token = "0x401D620")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public static string DIALOG_STYLE_ANSWER;

		// Token: 0x0401D621 RID: 120353
		[Token(Token = "0x401D621")]
		private const string DIV_STYLE_LINE = "line";

		// Token: 0x0401D622 RID: 120354
		[Token(Token = "0x401D622")]
		private const string DIV_STYLE_START = "start";

		// Token: 0x0401D623 RID: 120355
		[Token(Token = "0x401D623")]
		private const string DIV_STYLE_SUCCESS = "success";

		// Token: 0x0401D624 RID: 120356
		[Token(Token = "0x401D624")]
		private const float MOVE_DUR = 0.3f;

		// Token: 0x0401D625 RID: 120357
		[Token(Token = "0x401D625")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGChatBoxController _chatController;

		// Token: 0x0401D626 RID: 120358
		[Token(Token = "0x401D626")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TuningChatDialogComp _dialogPrefab;

		// Token: 0x0401D627 RID: 120359
		[Token(Token = "0x401D627")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TuningChatSimpleComp _linePrefab;

		// Token: 0x0401D628 RID: 120360
		[Token(Token = "0x401D628")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TuningChatTitleComp _titlePrefab;

		// Token: 0x0401D629 RID: 120361
		[Token(Token = "0x401D629")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TuningChatSimpleComp _startPrefab;

		// Token: 0x0401D62A RID: 120362
		[Token(Token = "0x401D62A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TuningChatSimpleComp _successPrefab;

		// Token: 0x0401D62B RID: 120363
		[Token(Token = "0x401D62B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TuningChatSimpleComp _endPrefab;

		// Token: 0x0401D62C RID: 120364
		[Token(Token = "0x401D62C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TuningChatPredelayComp _loadingPrefab;

		// Token: 0x0401D62D RID: 120365
		[Token(Token = "0x401D62D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _scaleFactorFetcher;

		// Token: 0x0401D62E RID: 120366
		[Token(Token = "0x401D62E")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<string, Func<Command, ChatItemOptions>> m_cmdHandlers;

		// Token: 0x0401D62F RID: 120367
		[Token(Token = "0x401D62F")]
		[FieldOffset(Offset = "0x68")]
		private TuningChatController.PlayOptions m_playOptions;

		// Token: 0x0401D630 RID: 120368
		[Token(Token = "0x401D630")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401D631 RID: 120369
		[Token(Token = "0x401D631")]
		[FieldOffset(Offset = "0xA8")]
		private ListDict<string, TuningChatController.TuningChatItemMeta> m_narMetas;

		// Token: 0x0401D632 RID: 120370
		[Token(Token = "0x401D632")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedUnhandledIndex;

		// Token: 0x0401D633 RID: 120371
		[Token(Token = "0x401D633")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_isInited;

		// Token: 0x0401D634 RID: 120372
		[Token(Token = "0x401D634")]
		[FieldOffset(Offset = "0xB8")]
		private TuningChatController.TuningChatCoroutineHandler m_coroutineHandler;

		// Token: 0x0401D635 RID: 120373
		[Token(Token = "0x401D635")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D636 RID: 120374
		[Token(Token = "0x401D636")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0401D637 RID: 120375
		[Token(Token = "0x401D637")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Skip;

		// Token: 0x0401D638 RID: 120376
		[Token(Token = "0x401D638")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ResetPlay;

		// Token: 0x0401D639 RID: 120377
		[Token(Token = "0x401D639")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SkipImpl;

		// Token: 0x0401D63A RID: 120378
		[Token(Token = "0x401D63A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayImpl;

		// Token: 0x0401D63B RID: 120379
		[Token(Token = "0x401D63B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BaseCommandHandler;

		// Token: 0x0401D63C RID: 120380
		[Token(Token = "0x401D63C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayModeCommandHandler;

		// Token: 0x0401D63D RID: 120381
		[Token(Token = "0x401D63D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateDialogItem;

		// Token: 0x0401D63E RID: 120382
		[Token(Token = "0x401D63E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CreateTitleItem;

		// Token: 0x0401D63F RID: 120383
		[Token(Token = "0x401D63F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateDivItem;

		// Token: 0x0401D640 RID: 120384
		[Token(Token = "0x401D640")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateNarItem;

		// Token: 0x0401D641 RID: 120385
		[Token(Token = "0x401D641")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayRecordFilter;

		// Token: 0x0401D642 RID: 120386
		[Token(Token = "0x401D642")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SkipRecordFilter;

		// Token: 0x0401D643 RID: 120387
		[Token(Token = "0x401D643")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CreatePreDelayView;

		// Token: 0x0401D644 RID: 120388
		[Token(Token = "0x401D644")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HandleNarration;

		// Token: 0x0401D645 RID: 120389
		[Token(Token = "0x401D645")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C6E RID: 15470
		[Token(Token = "0x2003C6E")]
		public struct PlayOptions
		{
			// Token: 0x0401D646 RID: 120390
			[Token(Token = "0x401D646")]
			[FieldOffset(Offset = "0x0")]
			public string storyId;

			// Token: 0x0401D647 RID: 120391
			[Token(Token = "0x401D647")]
			[FieldOffset(Offset = "0x8")]
			public string npcName;

			// Token: 0x0401D648 RID: 120392
			[Token(Token = "0x401D648")]
			[FieldOffset(Offset = "0x10")]
			public int initIndex;

			// Token: 0x0401D649 RID: 120393
			[Token(Token = "0x401D649")]
			[FieldOffset(Offset = "0x14")]
			public float delay;

			// Token: 0x0401D64A RID: 120394
			[Token(Token = "0x401D64A")]
			[FieldOffset(Offset = "0x18")]
			public Action<int, string, string> onNarrationPlay;

			// Token: 0x0401D64B RID: 120395
			[Token(Token = "0x401D64B")]
			[FieldOffset(Offset = "0x20")]
			public Action onNarrationHandled;

			// Token: 0x0401D64C RID: 120396
			[Token(Token = "0x401D64C")]
			[FieldOffset(Offset = "0x28")]
			public bool useSelfCoroutine;
		}

		// Token: 0x02003C6F RID: 15471
		[Token(Token = "0x2003C6F")]
		public class TuningChatItemMeta
		{
			// Token: 0x060182AB RID: 98987 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182AB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TuningChatItemMeta()
			{
			}

			// Token: 0x0401D64D RID: 120397
			[Token(Token = "0x401D64D")]
			[FieldOffset(Offset = "0x10")]
			public int index;

			// Token: 0x0401D64E RID: 120398
			[Token(Token = "0x401D64E")]
			[FieldOffset(Offset = "0x18")]
			public string narrationStyle;

			// Token: 0x0401D64F RID: 120399
			[Token(Token = "0x401D64F")]
			[FieldOffset(Offset = "0x20")]
			public string content;

			// Token: 0x0401D650 RID: 120400
			[Token(Token = "0x401D650")]
			[FieldOffset(Offset = "0x28")]
			public bool isHandled;
		}

		// Token: 0x02003C70 RID: 15472
		[Token(Token = "0x2003C70")]
		public class TuningChatCoroutineHandler : AVGChatBoxController.CoroutineHandler
		{
			// Token: 0x060182AC RID: 98988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182AC")]
			[Address(RVA = "0x10A82E0", Offset = "0x10A6EE0", VA = "0x1810A82E0")]
			public TuningChatCoroutineHandler(TuningChatController closure)
			{
			}

			// Token: 0x060182AD RID: 98989 RVA: 0x00099A20 File Offset: 0x00097C20
			[Token(Token = "0x60182AD")]
			[Address(RVA = "0x10A8110", Offset = "0x10A6D10", VA = "0x1810A8110", Slot = "4")]
			public override bool HandleOnEnable()
			{
				return default(bool);
			}

			// Token: 0x060182AE RID: 98990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60182AE")]
			[Address(RVA = "0x10A8170", Offset = "0x10A6D70", VA = "0x1810A8170", Slot = "5")]
			public override Coroutine HandleStartCoroutine(IEnumerator routine)
			{
				return null;
			}

			// Token: 0x060182AF RID: 98991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60182AF")]
			[Address(RVA = "0x10A8240", Offset = "0x10A6E40", VA = "0x1810A8240", Slot = "6")]
			public override void HandleStopCoroutine()
			{
			}

			// Token: 0x0401D651 RID: 120401
			[Token(Token = "0x401D651")]
			[FieldOffset(Offset = "0x10")]
			private TuningChatController m_closure;

			// Token: 0x0401D652 RID: 120402
			[Token(Token = "0x401D652")]
			[FieldOffset(Offset = "0x18")]
			private Coroutine m_activeCoroutine;

			// Token: 0x0401D653 RID: 120403
			[Token(Token = "0x401D653")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D654 RID: 120404
			[Token(Token = "0x401D654")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_HandleOnEnable;

			// Token: 0x0401D655 RID: 120405
			[Token(Token = "0x401D655")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HandleStartCoroutine;

			// Token: 0x0401D656 RID: 120406
			[Token(Token = "0x401D656")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HandleStopCoroutine;
		}
	}
}
