using System;
using System.Collections;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058B9 RID: 22713
	[Token(Token = "0x20058B9")]
	public class RoguelikeChatController : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021267 RID: 135783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021267")]
		[Address(RVA = "0x1B7BB80", Offset = "0x1B7A780", VA = "0x181B7BB80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021268 RID: 135784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021268")]
		[Address(RVA = "0x1B7AE50", Offset = "0x1B79A50", VA = "0x181B7AE50")]
		public IEnumerator Play(RoguelikeChatController.PlayOptions options)
		{
			return null;
		}

		// Token: 0x06021269 RID: 135785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021269")]
		[Address(RVA = "0x1B7AAD0", Offset = "0x1B796D0", VA = "0x181B7AAD0")]
		public void InterruptPlaying()
		{
		}

		// Token: 0x0602126A RID: 135786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602126A")]
		[Address(RVA = "0x1B7AF40", Offset = "0x1B79B40", VA = "0x181B7AF40")]
		public void SetPauseIfPlaying(bool isPaused)
		{
		}

		// Token: 0x0602126B RID: 135787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602126B")]
		[Address(RVA = "0x1B7AB40", Offset = "0x1B79740", VA = "0x181B7AB40")]
		public void Log(RoguelikeChatController.LogOptions options)
		{
		}

		// Token: 0x0602126C RID: 135788 RVA: 0x000B8C08 File Offset: 0x000B6E08
		[Token(Token = "0x602126C")]
		[Address(RVA = "0x1B7B3F0", Offset = "0x1B79FF0", VA = "0x181B7B3F0")]
		private ChatItemOptions _CreateDialogItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x0602126D RID: 135789 RVA: 0x000B8C20 File Offset: 0x000B6E20
		[Token(Token = "0x602126D")]
		[Address(RVA = "0x1B7BA40", Offset = "0x1B7A640", VA = "0x181B7BA40")]
		private ChatItemOptions _CreateTitleItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x0602126E RID: 135790 RVA: 0x000B8C38 File Offset: 0x000B6E38
		[Token(Token = "0x602126E")]
		[Address(RVA = "0x1B7B820", Offset = "0x1B7A420", VA = "0x181B7B820")]
		private ChatItemOptions _CreateDivItem(Command command)
		{
			return default(ChatItemOptions);
		}

		// Token: 0x0602126F RID: 135791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602126F")]
		[Address(RVA = "0x1B7B960", Offset = "0x1B7A560", VA = "0x181B7B960")]
		private IChatDelayView _CreatePreDelayView()
		{
			return null;
		}

		// Token: 0x06021270 RID: 135792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021270")]
		[Address(RVA = "0x1B7AFD0", Offset = "0x1B79BD0", VA = "0x181B7AFD0")]
		private IList<ChatItemOptions> _BaseCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x06021271 RID: 135793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021271")]
		[Address(RVA = "0x1B7BE10", Offset = "0x1B7AA10", VA = "0x181B7BE10")]
		private IList<ChatItemOptions> _PlayModeCommandHandler(IList<Command> commands)
		{
			return null;
		}

		// Token: 0x06021272 RID: 135794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021272")]
		[Address(RVA = "0x1B7BD90", Offset = "0x1B7A990", VA = "0x181B7BD90")]
		private void _InterruptPlayingImpl()
		{
		}

		// Token: 0x06021273 RID: 135795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021273")]
		[Address(RVA = "0x1B7C030", Offset = "0x1B7AC30", VA = "0x181B7C030")]
		public RoguelikeChatController()
		{
		}

		// Token: 0x0402D254 RID: 184916
		[Token(Token = "0x402D254")]
		private const float MOVE_DUR = 0.3f;

		// Token: 0x0402D255 RID: 184917
		[Token(Token = "0x402D255")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGChatBoxController _chatController;

		// Token: 0x0402D256 RID: 184918
		[Token(Token = "0x402D256")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ScrollRect _scrollType;

		// Token: 0x0402D257 RID: 184919
		[Token(Token = "0x402D257")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatDialogComp _dialogPrefab;

		// Token: 0x0402D258 RID: 184920
		[Token(Token = "0x402D258")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatSimpleComp _titlePrefab;

		// Token: 0x0402D259 RID: 184921
		[Token(Token = "0x402D259")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatSimpleComp _divPrefab;

		// Token: 0x0402D25A RID: 184922
		[Token(Token = "0x402D25A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatSimpleComp _endPrefab;

		// Token: 0x0402D25B RID: 184923
		[Token(Token = "0x402D25B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("ChatItems")]
		private RoguelikeChatSimpleComp _loadingPrefab;

		// Token: 0x0402D25C RID: 184924
		[Token(Token = "0x402D25C")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, Func<Command, ChatItemOptions>> m_cmdHandlers;

		// Token: 0x0402D25D RID: 184925
		[Token(Token = "0x402D25D")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeChatController.PlayOptions m_playOptions;

		// Token: 0x0402D25E RID: 184926
		[Token(Token = "0x402D25E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0402D25F RID: 184927
		[Token(Token = "0x402D25F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402D260 RID: 184928
		[Token(Token = "0x402D260")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Play;

		// Token: 0x0402D261 RID: 184929
		[Token(Token = "0x402D261")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InterruptPlaying;

		// Token: 0x0402D262 RID: 184930
		[Token(Token = "0x402D262")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetPauseIfPlaying;

		// Token: 0x0402D263 RID: 184931
		[Token(Token = "0x402D263")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Log;

		// Token: 0x0402D264 RID: 184932
		[Token(Token = "0x402D264")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateDialogItem;

		// Token: 0x0402D265 RID: 184933
		[Token(Token = "0x402D265")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateTitleItem;

		// Token: 0x0402D266 RID: 184934
		[Token(Token = "0x402D266")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateDivItem;

		// Token: 0x0402D267 RID: 184935
		[Token(Token = "0x402D267")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreatePreDelayView;

		// Token: 0x0402D268 RID: 184936
		[Token(Token = "0x402D268")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__BaseCommandHandler;

		// Token: 0x0402D269 RID: 184937
		[Token(Token = "0x402D269")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayModeCommandHandler;

		// Token: 0x0402D26A RID: 184938
		[Token(Token = "0x402D26A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InterruptPlayingImpl;

		// Token: 0x0402D26B RID: 184939
		[Token(Token = "0x402D26B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058BA RID: 22714
		[Token(Token = "0x20058BA")]
		public struct PlayOptions
		{
			// Token: 0x0402D26C RID: 184940
			[Token(Token = "0x402D26C")]
			[FieldOffset(Offset = "0x0")]
			public float delay;

			// Token: 0x0402D26D RID: 184941
			[Token(Token = "0x402D26D")]
			[FieldOffset(Offset = "0x8")]
			public ActArchiveChatItemData chatData;

			// Token: 0x0402D26E RID: 184942
			[Token(Token = "0x402D26E")]
			[FieldOffset(Offset = "0x10")]
			public bool isLastChat;

			// Token: 0x0402D26F RID: 184943
			[Token(Token = "0x402D26F")]
			[FieldOffset(Offset = "0x18")]
			public Action onChatEndClicked;
		}

		// Token: 0x020058BB RID: 22715
		[Token(Token = "0x20058BB")]
		public struct LogOptions
		{
			// Token: 0x0402D270 RID: 184944
			[Token(Token = "0x402D270")]
			[FieldOffset(Offset = "0x0")]
			public List<ActArchiveChatItemData> chatList;
		}

		// Token: 0x020058BC RID: 22716
		[Token(Token = "0x20058BC")]
		private struct TrimTitleCmdHandler : IHotfixable
		{
			// Token: 0x06021274 RID: 135796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021274")]
			[Address(RVA = "0x1B837E0", Offset = "0x1B823E0", VA = "0x181B837E0")]
			public IList<ChatItemOptions> _CommandHandler(IList<Command> commands)
			{
				return null;
			}

			// Token: 0x0402D271 RID: 184945
			[Token(Token = "0x402D271")]
			[FieldOffset(Offset = "0x0")]
			private bool m_hasTitle;

			// Token: 0x0402D272 RID: 184946
			[Token(Token = "0x402D272")]
			[FieldOffset(Offset = "0x8")]
			private List<Command> m_sharedList;

			// Token: 0x0402D273 RID: 184947
			[Token(Token = "0x402D273")]
			[FieldOffset(Offset = "0x10")]
			public Func<IList<Command>, IList<ChatItemOptions>> baseHandler;

			// Token: 0x0402D274 RID: 184948
			[Token(Token = "0x402D274")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__CommandHandler;
		}
	}
}
