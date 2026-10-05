using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Squad;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200767E RID: 30334
	[Token(Token = "0x200767E")]
	public class Act20sideCarVotePlayerDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x0602AAAA RID: 174762 RVA: 0x000D95C0 File Offset: 0x000D77C0
		[Token(Token = "0x1700643F")]
		public bool isShow
		{
			[Token(Token = "0x602AAAA")]
			[Address(RVA = "0x266C1D0", Offset = "0x266ADD0", VA = "0x18266C1D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AAAB RID: 174763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAAB")]
		[Address(RVA = "0x266BC80", Offset = "0x266A880", VA = "0x18266BC80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AAAC RID: 174764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAAC")]
		[Address(RVA = "0x266B480", Offset = "0x266A080", VA = "0x18266B480")]
		public void Render(ExhibitionFriendCard friendCard, bool canRequest)
		{
		}

		// Token: 0x0602AAAD RID: 174765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAAD")]
		[Address(RVA = "0x266BF40", Offset = "0x266AB40", VA = "0x18266BF40")]
		private void _SendFriendProcessRequestListRequest(ExhibitionFriendCard friendData)
		{
		}

		// Token: 0x0602AAAE RID: 174766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAAE")]
		[Address(RVA = "0x266BE60", Offset = "0x266AA60", VA = "0x18266BE60")]
		private void _OnSendFriendReqSuc()
		{
		}

		// Token: 0x0602AAAF RID: 174767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAAF")]
		[Address(RVA = "0x266B350", Offset = "0x2669F50", VA = "0x18266B350")]
		public void OnAlreadyRequestClick()
		{
		}

		// Token: 0x0602AAB0 RID: 174768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB0")]
		[Address(RVA = "0x266B400", Offset = "0x266A000", VA = "0x18266B400")]
		public void OnFriendRequestClick()
		{
		}

		// Token: 0x0602AAB1 RID: 174769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB1")]
		[Address(RVA = "0x266B2C0", Offset = "0x2669EC0", VA = "0x18266B2C0")]
		public void Dismiss()
		{
		}

		// Token: 0x0602AAB2 RID: 174770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AAB2")]
		[Address(RVA = "0x266C160", Offset = "0x266AD60", VA = "0x18266C160")]
		public Act20sideCarVotePlayerDetailView()
		{
		}

		// Token: 0x0403D748 RID: 251720
		[Token(Token = "0x403D748")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _fullScreenImg;

		// Token: 0x0403D749 RID: 251721
		[Token(Token = "0x403D749")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _avatarTransform;

		// Token: 0x0403D74A RID: 251722
		[Token(Token = "0x403D74A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0403D74B RID: 251723
		[Token(Token = "0x403D74B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelNumText;

		// Token: 0x0403D74C RID: 251724
		[Token(Token = "0x403D74C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0403D74D RID: 251725
		[Token(Token = "0x403D74D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0403D74E RID: 251726
		[Token(Token = "0x403D74E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _loginTimeText;

		// Token: 0x0403D74F RID: 251727
		[Token(Token = "0x403D74F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _requestFriendToggle;

		// Token: 0x0403D750 RID: 251728
		[Token(Token = "0x403D750")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform[] _charViewContainerList;

		// Token: 0x0403D751 RID: 251729
		[Token(Token = "0x403D751")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SquadFriendCharView _charViewPrefab;

		// Token: 0x0403D752 RID: 251730
		[Token(Token = "0x403D752")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _onFriendRequestSucEvent;

		// Token: 0x0403D753 RID: 251731
		[Token(Token = "0x403D753")]
		[FieldOffset(Offset = "0x70")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0403D754 RID: 251732
		[Token(Token = "0x403D754")]
		[FieldOffset(Offset = "0x78")]
		private ExhibitionFriendCard m_cacheData;

		// Token: 0x0403D755 RID: 251733
		[Token(Token = "0x403D755")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x0403D756 RID: 251734
		[Token(Token = "0x403D756")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D757 RID: 251735
		[Token(Token = "0x403D757")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D758 RID: 251736
		[Token(Token = "0x403D758")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D759 RID: 251737
		[Token(Token = "0x403D759")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendFriendProcessRequestListRequest;

		// Token: 0x0403D75A RID: 251738
		[Token(Token = "0x403D75A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSendFriendReqSuc;

		// Token: 0x0403D75B RID: 251739
		[Token(Token = "0x403D75B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAlreadyRequestClick;

		// Token: 0x0403D75C RID: 251740
		[Token(Token = "0x403D75C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnFriendRequestClick;

		// Token: 0x0403D75D RID: 251741
		[Token(Token = "0x403D75D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0403D75E RID: 251742
		[Token(Token = "0x403D75E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
