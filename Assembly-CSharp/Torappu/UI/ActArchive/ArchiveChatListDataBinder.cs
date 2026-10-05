using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.Chat;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B40 RID: 27456
	[Token(Token = "0x2006B40")]
	public class ArchiveChatListDataBinder : DataBinder<ChatProperty>
	{
		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x060273F5 RID: 160757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060273F6 RID: 160758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CC0")]
		public ArchiveChatController controller
		{
			[Token(Token = "0x60273F5")]
			[Address(RVA = "0x226CD60", Offset = "0x226B960", VA = "0x18226CD60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60273F6")]
			[Address(RVA = "0x226CDC0", Offset = "0x226B9C0", VA = "0x18226CDC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060273F7 RID: 160759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273F7")]
		[Address(RVA = "0x226C0B0", Offset = "0x226ACB0", VA = "0x18226C0B0", Slot = "7")]
		public override void OnValueChanged(ChatProperty property)
		{
		}

		// Token: 0x060273F8 RID: 160760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273F8")]
		[Address(RVA = "0x226C320", Offset = "0x226AF20", VA = "0x18226C320")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060273F9 RID: 160761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273F9")]
		[Address(RVA = "0x226C4F0", Offset = "0x226B0F0", VA = "0x18226C4F0")]
		private void _RefreshAllContent(bool isInit)
		{
		}

		// Token: 0x060273FA RID: 160762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273FA")]
		[Address(RVA = "0x226C7C0", Offset = "0x226B3C0", VA = "0x18226C7C0")]
		private void _RefreshChatPortraits(bool isInit, List<RoguelikeTopicMonthSquadTeamChar> selectedCharIds)
		{
		}

		// Token: 0x060273FB RID: 160763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273FB")]
		[Address(RVA = "0x226C9C0", Offset = "0x226B5C0", VA = "0x18226C9C0")]
		private void _RenderFadeSwitchContents(ChatItemModel selectedItem)
		{
		}

		// Token: 0x060273FC RID: 160764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273FC")]
		[Address(RVA = "0x226BDB0", Offset = "0x226A9B0", VA = "0x18226BDB0")]
		public void OnNextBtnClick()
		{
		}

		// Token: 0x060273FD RID: 160765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273FD")]
		[Address(RVA = "0x226BF30", Offset = "0x226AB30", VA = "0x18226BF30")]
		public void OnPrevBtnClick()
		{
		}

		// Token: 0x060273FE RID: 160766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60273FE")]
		[Address(RVA = "0x226CCF0", Offset = "0x226B8F0", VA = "0x18226CCF0")]
		public ArchiveChatListDataBinder()
		{
		}

		// Token: 0x04037894 RID: 227476
		[Token(Token = "0x4037894")]
		private const int CHAR_SLOT_NUM = 3;

		// Token: 0x04037895 RID: 227477
		[Token(Token = "0x4037895")]
		private const float FADE_SWITCH_DUR = 0.15f;

		// Token: 0x04037896 RID: 227478
		[Token(Token = "0x4037896")]
		private const float FADE_RENDER_DELAY = 0.05f;

		// Token: 0x04037897 RID: 227479
		[Token(Token = "0x4037897")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelFadeSwitch;

		// Token: 0x04037898 RID: 227480
		[Token(Token = "0x4037898")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Detail Part")]
		private ArchiveChatDetailItemView _viewDetail;

		// Token: 0x04037899 RID: 227481
		[Token(Token = "0x4037899")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Detail Part")]
		private RoguelikeTopicMonthSquadCharPortraitView _charPrefab;

		// Token: 0x0403789A RID: 227482
		[Token(Token = "0x403789A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Detail Part")]
		private Transform _charContainer;

		// Token: 0x0403789B RID: 227483
		[Token(Token = "0x403789B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Detail Part")]
		private EasyInstancePool _togglePool;

		// Token: 0x0403789C RID: 227484
		[Token(Token = "0x403789C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Chat Part")]
		private GameObject _panelLocked;

		// Token: 0x0403789D RID: 227485
		[Token(Token = "0x403789D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Chat Part")]
		private GameObject _textLocked;

		// Token: 0x0403789E RID: 227486
		[Token(Token = "0x403789E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Chat Part")]
		private Transform _panelChat;

		// Token: 0x0403789F RID: 227487
		[Token(Token = "0x403789F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Chat Part")]
		private RoguelikeChatController _chatPrefab;

		// Token: 0x040378A0 RID: 227488
		[Token(Token = "0x40378A0")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<string, ChatItemModel> m_cachedChatItems;

		// Token: 0x040378A1 RID: 227489
		[Token(Token = "0x40378A1")]
		[FieldOffset(Offset = "0x70")]
		private int m_cachedItemIndex;

		// Token: 0x040378A2 RID: 227490
		[Token(Token = "0x40378A2")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween.TweenWrapper m_tween;

		// Token: 0x040378A3 RID: 227491
		[Token(Token = "0x40378A3")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInit;

		// Token: 0x040378A4 RID: 227492
		[Token(Token = "0x40378A4")]
		[FieldOffset(Offset = "0x84")]
		private ArchiveChatListDataBinder.ChatSwitchDirection m_cachedDirection;

		// Token: 0x040378A5 RID: 227493
		[Token(Token = "0x40378A5")]
		[FieldOffset(Offset = "0x88")]
		private List<RoguelikeTopicMonthSquadCharPortraitView> m_charPortraitViews;

		// Token: 0x040378A6 RID: 227494
		[Token(Token = "0x40378A6")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeChatController m_chatView;

		// Token: 0x040378A8 RID: 227496
		[Token(Token = "0x40378A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040378A9 RID: 227497
		[Token(Token = "0x40378A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040378AA RID: 227498
		[Token(Token = "0x40378AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040378AB RID: 227499
		[Token(Token = "0x40378AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040378AC RID: 227500
		[Token(Token = "0x40378AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshAllContent;

		// Token: 0x040378AD RID: 227501
		[Token(Token = "0x40378AD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshChatPortraits;

		// Token: 0x040378AE RID: 227502
		[Token(Token = "0x40378AE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderFadeSwitchContents;

		// Token: 0x040378AF RID: 227503
		[Token(Token = "0x40378AF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnNextBtnClick;

		// Token: 0x040378B0 RID: 227504
		[Token(Token = "0x40378B0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPrevBtnClick;

		// Token: 0x040378B1 RID: 227505
		[Token(Token = "0x40378B1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B41 RID: 27457
		[Token(Token = "0x2006B41")]
		public enum ChatSwitchDirection
		{
			// Token: 0x040378B3 RID: 227507
			[Token(Token = "0x40378B3")]
			PREV,
			// Token: 0x040378B4 RID: 227508
			[Token(Token = "0x40378B4")]
			NEXT
		}
	}
}
