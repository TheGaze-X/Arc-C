using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D28 RID: 7464
	[Token(Token = "0x2001D28")]
	public class BuildingMessageLeaveBoardVisitorItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B83E RID: 47166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83E")]
		[Address(RVA = "0x335FB50", Offset = "0x335E750", VA = "0x18335FB50")]
		private void _RenderThisWeekVisitor(BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor thisWeekVisitor, long lastVisitBoardTs, Action<IMessageBoardVisitorData> onClickAvatar)
		{
		}

		// Token: 0x0600B83F RID: 47167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B83F")]
		[Address(RVA = "0x335F8A0", Offset = "0x335E4A0", VA = "0x18335F8A0")]
		private void _RenderLastWeekVisitor(BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardLastWeekVisitor lastWeekVisitor)
		{
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B840")]
		[Address(RVA = "0x335F540", Offset = "0x335E140", VA = "0x18335F540")]
		private void _RenderEmoji(string emojiName)
		{
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B841")]
		[Address(RVA = "0x335F970", Offset = "0x335E570", VA = "0x18335F970")]
		private void _RenderOtherWeekVisitor(BuildingPayloadGetOthersMessageBoardContentResponse.PayloadOthersMessageBoardThisWeekVisitor otherBoardVisitor)
		{
		}

		// Token: 0x0600B842 RID: 47170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B842")]
		[Address(RVA = "0x335ECF0", Offset = "0x335D8F0", VA = "0x18335ECF0")]
		public void Render(IMessageBoardVisitorData visitorData, long lastVisitBoardTs, Action<IMessageBoardVisitorData> onClickAvatar)
		{
		}

		// Token: 0x0600B843 RID: 47171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B843")]
		[Address(RVA = "0x335F090", Offset = "0x335DC90", VA = "0x18335F090")]
		private void _KillPrefAnim()
		{
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B844")]
		[Address(RVA = "0x335EFC0", Offset = "0x335DBC0", VA = "0x18335EFC0")]
		private void _CheckAndPlayNewVisitorAnim(BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor thisWeekVisitor, long lastVisitBoardTs)
		{
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B845")]
		[Address(RVA = "0x335F180", Offset = "0x335DD80", VA = "0x18335F180")]
		private void _PlayNewVisitorAnim()
		{
		}

		// Token: 0x0600B846 RID: 47174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B846")]
		[Address(RVA = "0x335F2E0", Offset = "0x335DEE0", VA = "0x18335F2E0")]
		private void _RendBasicInfo(bool showAdditionalInfo, IMessageBoardVisitorData visitorData, bool forceUseStaticAvatar = false)
		{
		}

		// Token: 0x0600B847 RID: 47175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B847")]
		[Address(RVA = "0x335F120", Offset = "0x335DD20", VA = "0x18335F120")]
		private void _OnAnimEnd()
		{
		}

		// Token: 0x0600B848 RID: 47176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B848")]
		[Address(RVA = "0x335EC70", Offset = "0x335D870", VA = "0x18335EC70")]
		public void EventOnClickAvatar()
		{
		}

		// Token: 0x0600B849 RID: 47177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B849")]
		[Address(RVA = "0x335FD70", Offset = "0x335E970", VA = "0x18335FD70")]
		public BuildingMessageLeaveBoardVisitorItemView()
		{
		}

		// Token: 0x0400B656 RID: 46678
		[Token(Token = "0x400B656")]
		public const float EMOJI_FADE_DELAY = 1f;

		// Token: 0x0400B657 RID: 46679
		[Token(Token = "0x400B657")]
		private const float EMOJI_FADE_KEEP = 4f;

		// Token: 0x0400B658 RID: 46680
		[Token(Token = "0x400B658")]
		private const float EMOJI_FADE_DURATION = 0.5f;

		// Token: 0x0400B659 RID: 46681
		[Token(Token = "0x400B659")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0400B65A RID: 46682
		[Token(Token = "0x400B65A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _avatarBorder;

		// Token: 0x0400B65B RID: 46683
		[Token(Token = "0x400B65B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textVisitorLevel;

		// Token: 0x0400B65C RID: 46684
		[Token(Token = "0x400B65C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _visitorLevelHolder;

		// Token: 0x0400B65D RID: 46685
		[Token(Token = "0x400B65D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textVisitorName;

		// Token: 0x0400B65E RID: 46686
		[Token(Token = "0x400B65E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _emojiHolder;

		// Token: 0x0400B65F RID: 46687
		[Token(Token = "0x400B65F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _emoji;

		// Token: 0x0400B660 RID: 46688
		[Token(Token = "0x400B660")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _emojiCanvasGroup;

		// Token: 0x0400B661 RID: 46689
		[Token(Token = "0x400B661")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _btnPlayerInfo;

		// Token: 0x0400B662 RID: 46690
		[Token(Token = "0x400B662")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelNewVisitor;

		// Token: 0x0400B663 RID: 46691
		[Token(Token = "0x400B663")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAnimationLocation _animNewVisitor;

		// Token: 0x0400B664 RID: 46692
		[Token(Token = "0x400B664")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIColorGraphic _headIconColorGraphic;

		// Token: 0x0400B665 RID: 46693
		[Token(Token = "0x400B665")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400B666 RID: 46694
		[Token(Token = "0x400B666")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_newVisitorTween;

		// Token: 0x0400B667 RID: 46695
		[Token(Token = "0x400B667")]
		[FieldOffset(Offset = "0x98")]
		private BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor m_thisWeekVisitor;

		// Token: 0x0400B668 RID: 46696
		[Token(Token = "0x400B668")]
		[FieldOffset(Offset = "0xA0")]
		private Action<IMessageBoardVisitorData> m_onClickAvatar;

		// Token: 0x0400B669 RID: 46697
		[Token(Token = "0x400B669")]
		[FieldOffset(Offset = "0xA8")]
		private Sequence m_fadeSequence;

		// Token: 0x0400B66A RID: 46698
		[Token(Token = "0x400B66A")]
		[FieldOffset(Offset = "0xB0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0400B66B RID: 46699
		[Token(Token = "0x400B66B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderThisWeekVisitor;

		// Token: 0x0400B66C RID: 46700
		[Token(Token = "0x400B66C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderLastWeekVisitor;

		// Token: 0x0400B66D RID: 46701
		[Token(Token = "0x400B66D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEmoji;

		// Token: 0x0400B66E RID: 46702
		[Token(Token = "0x400B66E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderOtherWeekVisitor;

		// Token: 0x0400B66F RID: 46703
		[Token(Token = "0x400B66F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B670 RID: 46704
		[Token(Token = "0x400B670")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__KillPrefAnim;

		// Token: 0x0400B671 RID: 46705
		[Token(Token = "0x400B671")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckAndPlayNewVisitorAnim;

		// Token: 0x0400B672 RID: 46706
		[Token(Token = "0x400B672")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayNewVisitorAnim;

		// Token: 0x0400B673 RID: 46707
		[Token(Token = "0x400B673")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RendBasicInfo;

		// Token: 0x0400B674 RID: 46708
		[Token(Token = "0x400B674")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnAnimEnd;

		// Token: 0x0400B675 RID: 46709
		[Token(Token = "0x400B675")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnClickAvatar;

		// Token: 0x0400B676 RID: 46710
		[Token(Token = "0x400B676")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
