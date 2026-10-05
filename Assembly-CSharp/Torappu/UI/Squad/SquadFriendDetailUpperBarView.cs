using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E15 RID: 15893
	[Token(Token = "0x2003E15")]
	public class SquadFriendDetailUpperBarView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x06018B87 RID: 101255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B87")]
		[Address(RVA = "0x113A540", Offset = "0x1139140", VA = "0x18113A540", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x06018B88 RID: 101256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B88")]
		[Address(RVA = "0x113A610", Offset = "0x1139210", VA = "0x18113A610")]
		public void Render(SquadAssistCharDetailModel model)
		{
		}

		// Token: 0x06018B89 RID: 101257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B89")]
		[Address(RVA = "0x113A990", Offset = "0x1139590", VA = "0x18113A990")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B8A RID: 101258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8A")]
		[Address(RVA = "0x113ABC0", Offset = "0x11397C0", VA = "0x18113ABC0")]
		public SquadFriendDetailUpperBarView()
		{
		}

		// Token: 0x0401E56D RID: 124269
		[Token(Token = "0x401E56D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _avatarTransform;

		// Token: 0x0401E56E RID: 124270
		[Token(Token = "0x401E56E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _avatarColorGraphic;

		// Token: 0x0401E56F RID: 124271
		[Token(Token = "0x401E56F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _avatarScale;

		// Token: 0x0401E570 RID: 124272
		[Token(Token = "0x401E570")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _levelNumText;

		// Token: 0x0401E571 RID: 124273
		[Token(Token = "0x401E571")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x0401E572 RID: 124274
		[Token(Token = "0x401E572")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _aliasNameText;

		// Token: 0x0401E573 RID: 124275
		[Token(Token = "0x401E573")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TwoStateToggle _onlineState;

		// Token: 0x0401E574 RID: 124276
		[Token(Token = "0x401E574")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _loginTimeText;

		// Token: 0x0401E575 RID: 124277
		[Token(Token = "0x401E575")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TwoStateToggle _requestFriendToggle;

		// Token: 0x0401E576 RID: 124278
		[Token(Token = "0x401E576")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _hideObjectsWhenIsFriend;

		// Token: 0x0401E577 RID: 124279
		[Token(Token = "0x401E577")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform[] _charViewContainerList;

		// Token: 0x0401E578 RID: 124280
		[Token(Token = "0x401E578")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private FriendSharedCharHeadIcon _charViewPrefab;

		// Token: 0x0401E579 RID: 124281
		[Token(Token = "0x401E579")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _nameCardLongBg;

		// Token: 0x0401E57A RID: 124282
		[Token(Token = "0x401E57A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _starFriendIcon;

		// Token: 0x0401E57B RID: 124283
		[Token(Token = "0x401E57B")]
		[FieldOffset(Offset = "0x90")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0401E57C RID: 124284
		[Token(Token = "0x401E57C")]
		[FieldOffset(Offset = "0x98")]
		private SquadAssistData m_cacheData;

		// Token: 0x0401E57D RID: 124285
		[Token(Token = "0x401E57D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0401E57E RID: 124286
		[Token(Token = "0x401E57E")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E57F RID: 124287
		[Token(Token = "0x401E57F")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedUid;

		// Token: 0x0401E580 RID: 124288
		[Token(Token = "0x401E580")]
		[FieldOffset(Offset = "0xC0")]
		private List<FriendSharedCharHeadIcon> m_createdCharViews;

		// Token: 0x0401E581 RID: 124289
		[Token(Token = "0x401E581")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0401E582 RID: 124290
		[Token(Token = "0x401E582")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E583 RID: 124291
		[Token(Token = "0x401E583")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E584 RID: 124292
		[Token(Token = "0x401E584")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
