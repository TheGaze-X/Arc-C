using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ChatBox;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F7B RID: 8059
	[Token(Token = "0x2001F7B")]
	public class AVGChatBoxController : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C849 RID: 51273 RVA: 0x00048D50 File Offset: 0x00046F50
		[Token(Token = "0x600C849")]
		[Address(RVA = "0x3489B00", Offset = "0x3488700", VA = "0x183489B00")]
		public bool Play(AVGChatBoxController.PlayOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00048D68 File Offset: 0x00046F68
		[Token(Token = "0x600C84A")]
		[Address(RVA = "0x34898F0", Offset = "0x34884F0", VA = "0x1834898F0")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84B")]
		[Address(RVA = "0x3489890", Offset = "0x3488490", VA = "0x183489890")]
		public void InterruptPlaying()
		{
		}

		// Token: 0x0600C84C RID: 51276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84C")]
		[Address(RVA = "0x3489CB0", Offset = "0x34888B0", VA = "0x183489CB0")]
		public void SetPauseIfPlaying(bool isPaused)
		{
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x00048D80 File Offset: 0x00046F80
		[Token(Token = "0x600C84D")]
		[Address(RVA = "0x3489950", Offset = "0x3488550", VA = "0x183489950")]
		public bool Log(AVGChatBoxController.LogOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84E")]
		[Address(RVA = "0x3489C00", Offset = "0x3488800", VA = "0x183489C00")]
		public void Reset()
		{
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C84F")]
		[Address(RVA = "0x3489A00", Offset = "0x3488600", VA = "0x183489A00")]
		private void OnEnable()
		{
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C850")]
		[Address(RVA = "0x3489820", Offset = "0x3488420", VA = "0x183489820")]
		public void EventOnContentClicked()
		{
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x00048D98 File Offset: 0x00046F98
		[Token(Token = "0x600C851")]
		[Address(RVA = "0x348B010", Offset = "0x3489C10", VA = "0x18348B010")]
		private bool _PlayImpl(AVGChatBoxController.PlayOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C852")]
		[Address(RVA = "0x3489D20", Offset = "0x3488920", VA = "0x183489D20")]
		private void _CancelPlaying()
		{
		}

		// Token: 0x0600C853 RID: 51283 RVA: 0x00048DB0 File Offset: 0x00046FB0
		[Token(Token = "0x600C853")]
		[Address(RVA = "0x348A920", Offset = "0x3489520", VA = "0x18348A920")]
		private bool _LogImpl(AVGChatBoxController.LogOptions options)
		{
			return default(bool);
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C854")]
		[Address(RVA = "0x348A670", Offset = "0x3489270", VA = "0x18348A670")]
		private IList<ChatItemOptions> _LoadViewsFromScript(string storyId, Func<IList<Command>, IList<ChatItemOptions>> cmdHandler)
		{
			return null;
		}

		// Token: 0x0600C855 RID: 51285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C855")]
		[Address(RVA = "0x3489E10", Offset = "0x3488A10", VA = "0x183489E10")]
		private static AVGParser _CreateAVGParser()
		{
			return null;
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C856")]
		[Address(RVA = "0x348AF60", Offset = "0x3489B60", VA = "0x18348AF60")]
		private IEnumerator _PlayCoroutine()
		{
			return null;
		}

		// Token: 0x0600C857 RID: 51287 RVA: 0x00048DC8 File Offset: 0x00046FC8
		[Token(Token = "0x600C857")]
		[Address(RVA = "0x348B7E0", Offset = "0x348A3E0", VA = "0x18348B7E0")]
		private bool _SearchInsertForRecord(ChatItemOptions record, bool needSkip)
		{
			return default(bool);
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x00048DE0 File Offset: 0x00046FE0
		[Token(Token = "0x600C858")]
		[Address(RVA = "0x348B5A0", Offset = "0x348A1A0", VA = "0x18348B5A0")]
		private bool _SearchInsertForPlayable(ChatItemOptions playable, bool needSkip)
		{
			return default(bool);
		}

		// Token: 0x0600C859 RID: 51289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C859")]
		[Address(RVA = "0x3489EF0", Offset = "0x3488AF0", VA = "0x183489EF0")]
		private static void _ExtractRecords(List<Queue<ChatItemOptions>> doubtingRecords, List<UIRecycleLayoutAdapter.IVirtualView> recordedViews)
		{
		}

		// Token: 0x0600C85A RID: 51290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C85A")]
		[Address(RVA = "0x348BB40", Offset = "0x348A740", VA = "0x18348BB40")]
		private IEnumerator _TraverseCoroutine(UIChatBoxView.PlayHandler playHandler, bool needSkip)
		{
			return null;
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C85B")]
		[Address(RVA = "0x348B480", Offset = "0x348A080", VA = "0x18348B480")]
		private static IEnumerator _PlayItemCoroutine(UIChatBoxView.PlayHandler playHandler, ChatItemOptions playable, IChatDelayView preDelayView)
		{
			return null;
		}

		// Token: 0x0600C85C RID: 51292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C85C")]
		[Address(RVA = "0x348AE60", Offset = "0x3489A60", VA = "0x18348AE60")]
		private void _OnChatEnd()
		{
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C85D")]
		[Address(RVA = "0x348AED0", Offset = "0x3489AD0", VA = "0x18348AED0")]
		private void _OnPlayFinish()
		{
		}

		// Token: 0x0600C85E RID: 51294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C85E")]
		[Address(RVA = "0x348A2E0", Offset = "0x3488EE0", VA = "0x18348A2E0")]
		private string _LoadScriptContent(string id)
		{
			return null;
		}

		// Token: 0x0600C85F RID: 51295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C85F")]
		[Address(RVA = "0x348BC30", Offset = "0x348A830", VA = "0x18348BC30")]
		private IEnumerator _WaitForNextClick(float timeout)
		{
			return null;
		}

		// Token: 0x0600C860 RID: 51296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C860")]
		[Address(RVA = "0x348A060", Offset = "0x3488C60", VA = "0x18348A060")]
		private void _FilterRecorded(Action<IList<ChatItemOptions>, List<ChatItemOptions>, List<ChatItemOptions>> filter, IList<ChatItemOptions> items, out bool meetPlayable)
		{
		}

		// Token: 0x0600C861 RID: 51297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C861")]
		[Address(RVA = "0x348BD00", Offset = "0x348A900", VA = "0x18348BD00")]
		public AVGChatBoxController()
		{
		}

		// Token: 0x0400CECB RID: 52939
		[Token(Token = "0x400CECB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIChatBoxView _chatBox;

		// Token: 0x0400CECC RID: 52940
		[Token(Token = "0x400CECC")]
		[FieldOffset(Offset = "0x20")]
		private AVGParser m_parser;

		// Token: 0x0400CECD RID: 52941
		[Token(Token = "0x400CECD")]
		[FieldOffset(Offset = "0x28")]
		private AVGChatBoxController.PlayContext m_activePlay;

		// Token: 0x0400CECE RID: 52942
		[Token(Token = "0x400CECE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0400CECF RID: 52943
		[Token(Token = "0x400CECF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsPlaying;

		// Token: 0x0400CED0 RID: 52944
		[Token(Token = "0x400CED0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InterruptPlaying;

		// Token: 0x0400CED1 RID: 52945
		[Token(Token = "0x400CED1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetPauseIfPlaying;

		// Token: 0x0400CED2 RID: 52946
		[Token(Token = "0x400CED2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Log;

		// Token: 0x0400CED3 RID: 52947
		[Token(Token = "0x400CED3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0400CED4 RID: 52948
		[Token(Token = "0x400CED4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400CED5 RID: 52949
		[Token(Token = "0x400CED5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnContentClicked;

		// Token: 0x0400CED6 RID: 52950
		[Token(Token = "0x400CED6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayImpl;

		// Token: 0x0400CED7 RID: 52951
		[Token(Token = "0x400CED7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CancelPlaying;

		// Token: 0x0400CED8 RID: 52952
		[Token(Token = "0x400CED8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LogImpl;

		// Token: 0x0400CED9 RID: 52953
		[Token(Token = "0x400CED9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadViewsFromScript;

		// Token: 0x0400CEDA RID: 52954
		[Token(Token = "0x400CEDA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateAVGParser;

		// Token: 0x0400CEDB RID: 52955
		[Token(Token = "0x400CEDB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__PlayCoroutine;

		// Token: 0x0400CEDC RID: 52956
		[Token(Token = "0x400CEDC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SearchInsertForRecord;

		// Token: 0x0400CEDD RID: 52957
		[Token(Token = "0x400CEDD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SearchInsertForPlayable;

		// Token: 0x0400CEDE RID: 52958
		[Token(Token = "0x400CEDE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ExtractRecords;

		// Token: 0x0400CEDF RID: 52959
		[Token(Token = "0x400CEDF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TraverseCoroutine;

		// Token: 0x0400CEE0 RID: 52960
		[Token(Token = "0x400CEE0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayItemCoroutine;

		// Token: 0x0400CEE1 RID: 52961
		[Token(Token = "0x400CEE1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnChatEnd;

		// Token: 0x0400CEE2 RID: 52962
		[Token(Token = "0x400CEE2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnPlayFinish;

		// Token: 0x0400CEE3 RID: 52963
		[Token(Token = "0x400CEE3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__LoadScriptContent;

		// Token: 0x0400CEE4 RID: 52964
		[Token(Token = "0x400CEE4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__WaitForNextClick;

		// Token: 0x0400CEE5 RID: 52965
		[Token(Token = "0x400CEE5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__FilterRecorded;

		// Token: 0x0400CEE6 RID: 52966
		[Token(Token = "0x400CEE6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F7C RID: 8060
		[Token(Token = "0x2001F7C")]
		public struct LogOptions
		{
			// Token: 0x0600C862 RID: 51298 RVA: 0x00048DF8 File Offset: 0x00046FF8
			[Token(Token = "0x600C862")]
			[Address(RVA = "0x3498740", Offset = "0x3497340", VA = "0x183498740")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0400CEE7 RID: 52967
			[Token(Token = "0x400CEE7")]
			[FieldOffset(Offset = "0x0")]
			public List<string> idList;

			// Token: 0x0400CEE8 RID: 52968
			[Token(Token = "0x400CEE8")]
			[FieldOffset(Offset = "0x8")]
			public Func<IList<Command>, IList<ChatItemOptions>> mainHandler;

			// Token: 0x0400CEE9 RID: 52969
			[Token(Token = "0x400CEE9")]
			[FieldOffset(Offset = "0x10")]
			public Func<IList<Command>, IList<ChatItemOptions>> insertHandler;

			// Token: 0x0400CEEA RID: 52970
			[Token(Token = "0x400CEEA")]
			[FieldOffset(Offset = "0x18")]
			public Func<string, string> insertFetcher;
		}

		// Token: 0x02001F7D RID: 8061
		[Token(Token = "0x2001F7D")]
		public struct PlayOptions
		{
			// Token: 0x0600C863 RID: 51299 RVA: 0x00048E10 File Offset: 0x00047010
			[Token(Token = "0x600C863")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0400CEEB RID: 52971
			[Token(Token = "0x400CEEB")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			// Token: 0x0400CEEC RID: 52972
			[Token(Token = "0x400CEEC")]
			[FieldOffset(Offset = "0x8")]
			public Func<IList<Command>, IList<ChatItemOptions>> mainHandler;

			// Token: 0x0400CEED RID: 52973
			[Token(Token = "0x400CEED")]
			[FieldOffset(Offset = "0x10")]
			public Func<IList<Command>, IList<ChatItemOptions>> insertHandler;

			// Token: 0x0400CEEE RID: 52974
			[Token(Token = "0x400CEEE")]
			[FieldOffset(Offset = "0x18")]
			public Action<IList<ChatItemOptions>, List<ChatItemOptions>, List<ChatItemOptions>> playFilter;

			// Token: 0x0400CEEF RID: 52975
			[Token(Token = "0x400CEEF")]
			[FieldOffset(Offset = "0x20")]
			public Action<IList<ChatItemOptions>, List<ChatItemOptions>, List<ChatItemOptions>> skipFilter;

			// Token: 0x0400CEF0 RID: 52976
			[Token(Token = "0x400CEF0")]
			[FieldOffset(Offset = "0x28")]
			public Func<string, string> insertFetcher;

			// Token: 0x0400CEF1 RID: 52977
			[Token(Token = "0x400CEF1")]
			[FieldOffset(Offset = "0x30")]
			public float scrollDuration;

			// Token: 0x0400CEF2 RID: 52978
			[Token(Token = "0x400CEF2")]
			[FieldOffset(Offset = "0x38")]
			public IChatDelayView prevDelayView;

			// Token: 0x0400CEF3 RID: 52979
			[Token(Token = "0x400CEF3")]
			[FieldOffset(Offset = "0x40")]
			public Action onPlayFinish;

			// Token: 0x0400CEF4 RID: 52980
			[Token(Token = "0x400CEF4")]
			[FieldOffset(Offset = "0x48")]
			public AVGChatBoxController.CoroutineHandler coroutineHandler;

			// Token: 0x0400CEF5 RID: 52981
			[Token(Token = "0x400CEF5")]
			[FieldOffset(Offset = "0x50")]
			public float playStartDelay;
		}

		// Token: 0x02001F7E RID: 8062
		[Token(Token = "0x2001F7E")]
		private struct PlayContext
		{
			// Token: 0x0600C864 RID: 51300 RVA: 0x00048E28 File Offset: 0x00047028
			[Token(Token = "0x600C864")]
			[Address(RVA = "0x2008220", Offset = "0x2006E20", VA = "0x182008220")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x0400CEF6 RID: 52982
			[Token(Token = "0x400CEF6")]
			[FieldOffset(Offset = "0x0")]
			public AVGChatBoxController.PlayOptions options;

			// Token: 0x0400CEF7 RID: 52983
			[Token(Token = "0x400CEF7")]
			[FieldOffset(Offset = "0x58")]
			public Stack<Queue<ChatItemOptions>> stackedRecords;

			// Token: 0x0400CEF8 RID: 52984
			[Token(Token = "0x400CEF8")]
			[FieldOffset(Offset = "0x60")]
			public Stack<Queue<ChatItemOptions>> stackedPlayables;

			// Token: 0x0400CEF9 RID: 52985
			[Token(Token = "0x400CEF9")]
			[FieldOffset(Offset = "0x68")]
			public List<UIRecycleLayoutAdapter.IVirtualView> recordedViews;

			// Token: 0x0400CEFA RID: 52986
			[Token(Token = "0x400CEFA")]
			[FieldOffset(Offset = "0x70")]
			public ListSet<string> cachedStoryIds;

			// Token: 0x0400CEFB RID: 52987
			[Token(Token = "0x400CEFB")]
			[FieldOffset(Offset = "0x78")]
			public List<Queue<ChatItemOptions>> doubtingRecords;

			// Token: 0x0400CEFC RID: 52988
			[Token(Token = "0x400CEFC")]
			[FieldOffset(Offset = "0x80")]
			public IEnumerator playCoroutine;

			// Token: 0x0400CEFD RID: 52989
			[Token(Token = "0x400CEFD")]
			[FieldOffset(Offset = "0x88")]
			public bool waitForNextClick;

			// Token: 0x0400CEFE RID: 52990
			[Token(Token = "0x400CEFE")]
			[FieldOffset(Offset = "0x89")]
			public bool isPaused;
		}

		// Token: 0x02001F7F RID: 8063
		[Token(Token = "0x2001F7F")]
		public abstract class CoroutineHandler : IHotfixable
		{
			// Token: 0x0600C865 RID: 51301
			[Token(Token = "0x600C865")]
			public abstract bool HandleOnEnable();

			// Token: 0x0600C866 RID: 51302
			[Token(Token = "0x600C866")]
			public abstract Coroutine HandleStartCoroutine(IEnumerator routine);

			// Token: 0x0600C867 RID: 51303
			[Token(Token = "0x600C867")]
			public abstract void HandleStopCoroutine();

			// Token: 0x0600C868 RID: 51304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C868")]
			[Address(RVA = "0x3498630", Offset = "0x3497230", VA = "0x183498630")]
			protected CoroutineHandler()
			{
			}

			// Token: 0x0400CEFF RID: 52991
			[Token(Token = "0x400CEFF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
