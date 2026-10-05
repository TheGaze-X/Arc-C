using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E16 RID: 15894
	[Token(Token = "0x2003E16")]
	public class SquadFriendDetailView : DataBinder<SquadAssistCharDetailProperty>, IHotfixable
	{
		// Token: 0x06018B8B RID: 101259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8B")]
		[Address(RVA = "0x113B380", Offset = "0x1139F80", VA = "0x18113B380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B8C RID: 101260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8C")]
		[Address(RVA = "0x113AD20", Offset = "0x1139920", VA = "0x18113AD20")]
		public void OnAlreadyRequestClick()
		{
		}

		// Token: 0x06018B8D RID: 101261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8D")]
		[Address(RVA = "0x113AFD0", Offset = "0x1139BD0", VA = "0x18113AFD0")]
		public void OnFriendRequestClick()
		{
		}

		// Token: 0x06018B8E RID: 101262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8E")]
		[Address(RVA = "0x113ADD0", Offset = "0x11399D0", VA = "0x18113ADD0")]
		public void OnApplyAssistClick()
		{
		}

		// Token: 0x06018B8F RID: 101263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B8F")]
		[Address(RVA = "0x113AC90", Offset = "0x1139890", VA = "0x18113AC90")]
		public void Dismiss()
		{
		}

		// Token: 0x06018B90 RID: 101264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B90")]
		[Address(RVA = "0x113AEF0", Offset = "0x1139AF0", VA = "0x18113AEF0")]
		public void OnFriendAvatarClick()
		{
		}

		// Token: 0x06018B91 RID: 101265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B91")]
		[Address(RVA = "0x113AE60", Offset = "0x1139A60", VA = "0x18113AE60")]
		public void OnCharShowClick()
		{
		}

		// Token: 0x06018B92 RID: 101266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B92")]
		[Address(RVA = "0x113B0D0", Offset = "0x1139CD0", VA = "0x18113B0D0", Slot = "7")]
		public override void OnValueChanged(SquadAssistCharDetailProperty property)
		{
		}

		// Token: 0x06018B93 RID: 101267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B93")]
		[Address(RVA = "0x113B4A0", Offset = "0x113A0A0", VA = "0x18113B4A0")]
		public SquadFriendDetailView()
		{
		}

		// Token: 0x0401E585 RID: 124293
		[Token(Token = "0x401E585")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIBlurFloatPanel _fullScreenImg;

		// Token: 0x0401E586 RID: 124294
		[Token(Token = "0x401E586")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0401E587 RID: 124295
		[Token(Token = "0x401E587")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SquadFriendDetailUpperBarView _upperBarView;

		// Token: 0x0401E588 RID: 124296
		[Token(Token = "0x401E588")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SquadFriendDetailLowerView _lowerCharInfoView;

		// Token: 0x0401E589 RID: 124297
		[Token(Token = "0x401E589")]
		[FieldOffset(Offset = "0x40")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0401E58A RID: 124298
		[Token(Token = "0x401E58A")]
		[FieldOffset(Offset = "0x48")]
		private SquadAssistData m_cacheData;

		// Token: 0x0401E58B RID: 124299
		[Token(Token = "0x401E58B")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0401E58C RID: 124300
		[Token(Token = "0x401E58C")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E58D RID: 124301
		[Token(Token = "0x401E58D")]
		[FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E58E RID: 124302
		[Token(Token = "0x401E58E")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedUid;

		// Token: 0x0401E58F RID: 124303
		[Token(Token = "0x401E58F")]
		[FieldOffset(Offset = "0x80")]
		private List<FriendSharedCharHeadIcon> m_createdCharViews;

		// Token: 0x0401E590 RID: 124304
		[Token(Token = "0x401E590")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E591 RID: 124305
		[Token(Token = "0x401E591")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnAlreadyRequestClick;

		// Token: 0x0401E592 RID: 124306
		[Token(Token = "0x401E592")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFriendRequestClick;

		// Token: 0x0401E593 RID: 124307
		[Token(Token = "0x401E593")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnApplyAssistClick;

		// Token: 0x0401E594 RID: 124308
		[Token(Token = "0x401E594")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0401E595 RID: 124309
		[Token(Token = "0x401E595")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnFriendAvatarClick;

		// Token: 0x0401E596 RID: 124310
		[Token(Token = "0x401E596")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCharShowClick;

		// Token: 0x0401E597 RID: 124311
		[Token(Token = "0x401E597")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401E598 RID: 124312
		[Token(Token = "0x401E598")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E17 RID: 15895
		[Token(Token = "0x2003E17")]
		public struct Options
		{
			// Token: 0x0401E599 RID: 124313
			[Token(Token = "0x401E599")]
			[FieldOffset(Offset = "0x0")]
			public bool isFriendReqAsked;
		}
	}
}
