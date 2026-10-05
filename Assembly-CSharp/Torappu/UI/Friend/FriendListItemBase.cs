using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DAB RID: 19883
	[Token(Token = "0x2004DAB")]
	public abstract class FriendListItemBase : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x0601DBC5 RID: 121797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC5")]
		[Address(RVA = "0x1740EE0", Offset = "0x173FAE0", VA = "0x181740EE0")]
		private new void Start()
		{
		}

		// Token: 0x0601DBC6 RID: 121798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC6")]
		[Address(RVA = "0x1740C80", Offset = "0x173F880", VA = "0x181740C80")]
		public void OpenBuilding()
		{
		}

		// Token: 0x0601DBC7 RID: 121799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC7")]
		[Address(RVA = "0x1740B80", Offset = "0x173F780", VA = "0x181740B80")]
		public void OnOpenShow()
		{
		}

		// Token: 0x0601DBC8 RID: 121800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC8")]
		[Address(RVA = "0x1740800", Offset = "0x173F400", VA = "0x181740800")]
		public void OnHideView(int focusIndex)
		{
		}

		// Token: 0x0601DBC9 RID: 121801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBC9")]
		[Address(RVA = "0x1740500", Offset = "0x173F100", VA = "0x181740500")]
		public void OnDetailClick()
		{
		}

		// Token: 0x0601DBCA RID: 121802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCA")]
		[Address(RVA = "0x17403B0", Offset = "0x173EFB0", VA = "0x1817403B0")]
		public void OnCloseDetail()
		{
		}

		// Token: 0x0601DBCB RID: 121803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCB")]
		[Address(RVA = "0x17408F0", Offset = "0x173F4F0", VA = "0x1817408F0")]
		public void OnNameCardClick()
		{
		}

		// Token: 0x0601DBCC RID: 121804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCC")]
		[Address(RVA = "0x1741410", Offset = "0x1740010", VA = "0x181741410")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x0601DBCD RID: 121805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCD")]
		[Address(RVA = "0x1740470", Offset = "0x173F070", VA = "0x181740470")]
		public void OnDeleteFriend()
		{
		}

		// Token: 0x0601DBCE RID: 121806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCE")]
		[Address(RVA = "0x1740BF0", Offset = "0x173F7F0", VA = "0x181740BF0")]
		public void OnSetAlias()
		{
		}

		// Token: 0x0601DBCF RID: 121807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBCF")]
		[Address(RVA = "0x17401D0", Offset = "0x173EDD0", VA = "0x1817401D0")]
		public void ApplyData(FriendData data, Vector3 parentViewPos, string alias)
		{
		}

		// Token: 0x0601DBD0 RID: 121808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DBD0")]
		[Address(RVA = "0x17410B0", Offset = "0x173FCB0", VA = "0x1817410B0")]
		private IEnumerator UpdateLayout(Vector3 parentViewPos)
		{
			return null;
		}

		// Token: 0x0601DBD1 RID: 121809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBD1")]
		[Address(RVA = "0x173F9F0", Offset = "0x173E5F0", VA = "0x18173F9F0")]
		public void ApplyData(FriendData data, [Optional] string alias)
		{
		}

		// Token: 0x0601DBD2 RID: 121810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBD2")]
		[Address(RVA = "0x173FFB0", Offset = "0x173EBB0", VA = "0x18173FFB0")]
		public void ApplyData(SquadFriendData data, [Optional] string alias)
		{
		}

		// Token: 0x0601DBD3 RID: 121811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBD3")]
		[Address(RVA = "0x1741190", Offset = "0x173FD90", VA = "0x181741190")]
		private void _ApplyAvatar(FriendCommonData data)
		{
		}

		// Token: 0x0601DBD4 RID: 121812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBD4")]
		[Address(RVA = "0x17402D0", Offset = "0x173EED0", VA = "0x1817402D0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0601DBD5 RID: 121813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DBD5")]
		[Address(RVA = "0x1741540", Offset = "0x1740140", VA = "0x181741540")]
		protected FriendListItemBase()
		{
		}

		// Token: 0x04027533 RID: 161075
		[Token(Token = "0x4027533")]
		private const string FRIEND_NAME_FORMAT = "{0}#{1}";

		// Token: 0x04027534 RID: 161076
		[Token(Token = "0x4027534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public FriendListState state;

		// Token: 0x04027535 RID: 161077
		[Token(Token = "0x4027535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FriendSharedCharHeadIcon[] _charList;

		// Token: 0x04027536 RID: 161078
		[Token(Token = "0x4027536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _emptyList;

		// Token: 0x04027537 RID: 161079
		[Token(Token = "0x4027537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _friendName;

		// Token: 0x04027538 RID: 161080
		[Token(Token = "0x4027538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _awayTime;

		// Token: 0x04027539 RID: 161081
		[Token(Token = "0x4027539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _friendLvl;

		// Token: 0x0402753A RID: 161082
		[Token(Token = "0x402753A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _aliasName;

		// Token: 0x0402753B RID: 161083
		[Token(Token = "0x402753B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0402753C RID: 161084
		[Token(Token = "0x402753C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIRenderTextureImage _backImage;

		// Token: 0x0402753D RID: 161085
		[Token(Token = "0x402753D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x0402753E RID: 161086
		[Token(Token = "0x402753E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _buttonContainer;

		// Token: 0x0402753F RID: 161087
		[Token(Token = "0x402753F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _buttonContainerDown;

		// Token: 0x04027540 RID: 161088
		[Token(Token = "0x4027540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _iconVisited;

		// Token: 0x04027541 RID: 161089
		[Token(Token = "0x4027541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04027542 RID: 161090
		[Token(Token = "0x4027542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private FriendListItemBase.InfoShareWidget _infoShareWidget;

		// Token: 0x04027543 RID: 161091
		[Token(Token = "0x4027543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x04027544 RID: 161092
		[Token(Token = "0x4027544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _avatarViewScale;

		// Token: 0x04027545 RID: 161093
		[Token(Token = "0x4027545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _background;

		// Token: 0x04027546 RID: 161094
		[Token(Token = "0x4027546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public FriendListView parentView;

		// Token: 0x04027547 RID: 161095
		[Token(Token = "0x4027547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public int index;

		// Token: 0x04027548 RID: 161096
		[Token(Token = "0x4027548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected FriendData m_friendData;

		// Token: 0x04027549 RID: 161097
		[Token(Token = "0x4027549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected string m_cachedUid;

		// Token: 0x0402754A RID: 161098
		[Token(Token = "0x402754A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected GetOtherPlayerNameCardResponse m_cachedResponse;

		// Token: 0x0402754B RID: 161099
		[Token(Token = "0x402754B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected string m_alias;

		// Token: 0x0402754C RID: 161100
		[Token(Token = "0x402754C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 _parentViewPos;

		// Token: 0x0402754D RID: 161101
		[Token(Token = "0x402754D")]
		private const float UPDOWNTHERSOLD = -100f;

		// Token: 0x0402754E RID: 161102
		[Token(Token = "0x402754E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402754F RID: 161103
		[Token(Token = "0x402754F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x04027550 RID: 161104
		[Token(Token = "0x4027550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04027551 RID: 161105
		[Token(Token = "0x4027551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenBuilding;

		// Token: 0x04027552 RID: 161106
		[Token(Token = "0x4027552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenShow;

		// Token: 0x04027553 RID: 161107
		[Token(Token = "0x4027553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHideView;

		// Token: 0x04027554 RID: 161108
		[Token(Token = "0x4027554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x04027555 RID: 161109
		[Token(Token = "0x4027555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCloseDetail;

		// Token: 0x04027556 RID: 161110
		[Token(Token = "0x4027556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnNameCardClick;

		// Token: 0x04027557 RID: 161111
		[Token(Token = "0x4027557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x04027558 RID: 161112
		[Token(Token = "0x4027558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnDeleteFriend;

		// Token: 0x04027559 RID: 161113
		[Token(Token = "0x4027559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnSetAlias;

		// Token: 0x0402755A RID: 161114
		[Token(Token = "0x402755A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402755B RID: 161115
		[Token(Token = "0x402755B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateLayout;

		// Token: 0x0402755C RID: 161116
		[Token(Token = "0x402755C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix1_ApplyData;

		// Token: 0x0402755D RID: 161117
		[Token(Token = "0x402755D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix2_ApplyData;

		// Token: 0x0402755E RID: 161118
		[Token(Token = "0x402755E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ApplyAvatar;

		// Token: 0x0402755F RID: 161119
		[Token(Token = "0x402755F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x04027560 RID: 161120
		[Token(Token = "0x4027560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004DAC RID: 19884
		[Token(Token = "0x2004DAC")]
		[Serializable]
		public class InfoShareWidget
		{
			// Token: 0x0601DBD7 RID: 121815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DBD7")]
			[Address(RVA = "0x1755710", Offset = "0x1754310", VA = "0x181755710")]
			public void Setup(FriendData data)
			{
			}

			// Token: 0x0601DBD8 RID: 121816 RVA: 0x000AC668 File Offset: 0x000AA868
			[Token(Token = "0x601DBD8")]
			[Address(RVA = "0x17558C0", Offset = "0x17544C0", VA = "0x1817558C0")]
			private bool _ShowCardOwnershipCornerIcon(FriendData data)
			{
				return default(bool);
			}

			// Token: 0x0601DBD9 RID: 121817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DBD9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InfoShareWidget()
			{
			}

			// Token: 0x04027561 RID: 161121
			[Token(Token = "0x4027561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _panel;

			// Token: 0x04027562 RID: 161122
			[Token(Token = "0x4027562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Image _progress;

			// Token: 0x04027563 RID: 161123
			[Token(Token = "0x4027563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _selfHasFriendNotOwnedClueIcon;
		}
	}
}
