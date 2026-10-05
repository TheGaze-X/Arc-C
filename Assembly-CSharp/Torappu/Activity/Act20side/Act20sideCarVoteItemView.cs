using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200767C RID: 30332
	[Token(Token = "0x200767C")]
	public class Act20sideCarVoteItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AA9E RID: 174750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA9E")]
		[Address(RVA = "0x266B000", Offset = "0x2669C00", VA = "0x18266B000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AA9F RID: 174751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA9F")]
		[Address(RVA = "0x266A9C0", Offset = "0x26695C0", VA = "0x18266A9C0")]
		public void Render(VoteCarViewModel data, int index, bool isFocused)
		{
		}

		// Token: 0x0602AAA0 RID: 174752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAA0")]
		[Address(RVA = "0x266A890", Offset = "0x2669490", VA = "0x18266A890")]
		public void OnClick()
		{
		}

		// Token: 0x0602AAA1 RID: 174753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAA1")]
		[Address(RVA = "0x266A920", Offset = "0x2669520", VA = "0x18266A920")]
		public void OnFriendRequestClick()
		{
		}

		// Token: 0x0602AAA2 RID: 174754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAA2")]
		[Address(RVA = "0x266A800", Offset = "0x2669400", VA = "0x18266A800")]
		public void OnCarDetailClick()
		{
		}

		// Token: 0x0602AAA3 RID: 174755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAA3")]
		[Address(RVA = "0x266AE10", Offset = "0x2669A10", VA = "0x18266AE10")]
		private void _ApplyAvatar(AvatarInfo avatarInfo)
		{
		}

		// Token: 0x0602AAA4 RID: 174756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAA4")]
		[Address(RVA = "0x266B250", Offset = "0x2669E50", VA = "0x18266B250")]
		public Act20sideCarVoteItemView()
		{
		}

		// Token: 0x0403D71F RID: 251679
		[Token(Token = "0x403D71F")]
		private const float SHOW_ANIM_DURATION = 0.25f;

		// Token: 0x0403D720 RID: 251680
		[Token(Token = "0x403D720")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelFriendInfo;

		// Token: 0x0403D721 RID: 251681
		[Token(Token = "0x403D721")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Friend Info")]
		private Transform _avatarContainer;

		// Token: 0x0403D722 RID: 251682
		[Token(Token = "0x403D722")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Friend Info")]
		private float _avatarViewScale;

		// Token: 0x0403D723 RID: 251683
		[Token(Token = "0x403D723")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _levelNum;

		// Token: 0x0403D724 RID: 251684
		[Token(Token = "0x403D724")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _name;

		// Token: 0x0403D725 RID: 251685
		[Token(Token = "0x403D725")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _nickName;

		// Token: 0x0403D726 RID: 251686
		[Token(Token = "0x403D726")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelName;

		// Token: 0x0403D727 RID: 251687
		[Token(Token = "0x403D727")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Friend Info")]
		private Text _note;

		// Token: 0x0403D728 RID: 251688
		[Token(Token = "0x403D728")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelNote;

		// Token: 0x0403D729 RID: 251689
		[Token(Token = "0x403D729")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Friend Info")]
		private Button _btnRequest;

		// Token: 0x0403D72A RID: 251690
		[Token(Token = "0x403D72A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelRequest;

		// Token: 0x0403D72B RID: 251691
		[Token(Token = "0x403D72B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Friend Info")]
		private GameObject _panelLevel;

		// Token: 0x0403D72C RID: 251692
		[Token(Token = "0x403D72C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Friend Info")]
		private UIAtlasImage _npcAvatar;

		// Token: 0x0403D72D RID: 251693
		[Token(Token = "0x403D72D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelChoose;

		// Token: 0x0403D72E RID: 251694
		[Token(Token = "0x403D72E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelVote;

		// Token: 0x0403D72F RID: 251695
		[Token(Token = "0x403D72F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasImage _iconNew;

		// Token: 0x0403D730 RID: 251696
		[Token(Token = "0x403D730")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Act20sideCarObject _carPrefab;

		// Token: 0x0403D731 RID: 251697
		[Token(Token = "0x403D731")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform _carContainer;

		// Token: 0x0403D732 RID: 251698
		[Token(Token = "0x403D732")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _carViewScale;

		// Token: 0x0403D733 RID: 251699
		[Token(Token = "0x403D733")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0403D734 RID: 251700
		[Token(Token = "0x403D734")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIIntEvent _onClickEvent;

		// Token: 0x0403D735 RID: 251701
		[Token(Token = "0x403D735")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIIntEvent _onFriendRequestEvent;

		// Token: 0x0403D736 RID: 251702
		[Token(Token = "0x403D736")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIIntEvent _onCarDetailEvent;

		// Token: 0x0403D737 RID: 251703
		[Token(Token = "0x403D737")]
		[FieldOffset(Offset = "0xD8")]
		private Act20sideCarVoteItemView.CarVoteBtnSwitchTween m_switchTween;

		// Token: 0x0403D738 RID: 251704
		[Token(Token = "0x403D738")]
		[FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x0403D739 RID: 251705
		[Token(Token = "0x403D739")]
		[FieldOffset(Offset = "0xE4")]
		private int m_cachedIndex;

		// Token: 0x0403D73A RID: 251706
		[Token(Token = "0x403D73A")]
		[FieldOffset(Offset = "0xE8")]
		private Act20sideCarObject m_carView;

		// Token: 0x0403D73B RID: 251707
		[Token(Token = "0x403D73B")]
		[FieldOffset(Offset = "0xF0")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0403D73C RID: 251708
		[Token(Token = "0x403D73C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D73D RID: 251709
		[Token(Token = "0x403D73D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D73E RID: 251710
		[Token(Token = "0x403D73E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403D73F RID: 251711
		[Token(Token = "0x403D73F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFriendRequestClick;

		// Token: 0x0403D740 RID: 251712
		[Token(Token = "0x403D740")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCarDetailClick;

		// Token: 0x0403D741 RID: 251713
		[Token(Token = "0x403D741")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyAvatar;

		// Token: 0x0403D742 RID: 251714
		[Token(Token = "0x403D742")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200767D RID: 30333
		[Token(Token = "0x200767D")]
		private class CarVoteBtnSwitchTween : UISwitchTween
		{
			// Token: 0x0602AAA5 RID: 174757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAA5")]
			[Address(RVA = "0x267CB70", Offset = "0x267B770", VA = "0x18267CB70")]
			public CarVoteBtnSwitchTween(Act20sideCarVoteItemView itemView)
			{
			}

			// Token: 0x0602AAA6 RID: 174758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AAA6")]
			[Address(RVA = "0x267C780", Offset = "0x267B380", VA = "0x18267C780", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AAA7 RID: 174759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AAA7")]
			[Address(RVA = "0x267C910", Offset = "0x267B510", VA = "0x18267C910", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AAA8 RID: 174760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAA8")]
			[Address(RVA = "0x267CAA0", Offset = "0x267B6A0", VA = "0x18267CAA0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AAA9 RID: 174761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AAA9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403D743 RID: 251715
			[Token(Token = "0x403D743")]
			[FieldOffset(Offset = "0x48")]
			private Act20sideCarVoteItemView m_closure;

			// Token: 0x0403D744 RID: 251716
			[Token(Token = "0x403D744")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D745 RID: 251717
			[Token(Token = "0x403D745")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403D746 RID: 251718
			[Token(Token = "0x403D746")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403D747 RID: 251719
			[Token(Token = "0x403D747")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
