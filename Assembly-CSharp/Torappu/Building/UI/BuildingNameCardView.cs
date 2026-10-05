using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B1A RID: 6938
	[Token(Token = "0x2001B1A")]
	public class BuildingNameCardView : UIStylerApplier<NameCardV2SkinStyle>
	{
		// Token: 0x0600AEBE RID: 44734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEBE")]
		[Address(RVA = "0x3291CC0", Offset = "0x32908C0", VA = "0x183291CC0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0600AEBF RID: 44735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEBF")]
		[Address(RVA = "0x3291D50", Offset = "0x3290950", VA = "0x183291D50")]
		public void Render(BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor visitorData)
		{
		}

		// Token: 0x0600AEC0 RID: 44736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC0")]
		[Address(RVA = "0x3291FE0", Offset = "0x3290BE0", VA = "0x183291FE0")]
		public void Render(VisitBuildingResponse.RoomOwner visitorData)
		{
		}

		// Token: 0x0600AEC1 RID: 44737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC1")]
		[Address(RVA = "0x32921F0", Offset = "0x3290DF0", VA = "0x1832921F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC2")]
		[Address(RVA = "0x3292310", Offset = "0x3290F10", VA = "0x183292310")]
		public BuildingNameCardView()
		{
		}

		// Token: 0x0400A7C4 RID: 42948
		[Token(Token = "0x400A7C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageBG;

		// Token: 0x0400A7C5 RID: 42949
		[Token(Token = "0x400A7C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0400A7C6 RID: 42950
		[Token(Token = "0x400A7C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textVisitorName;

		// Token: 0x0400A7C7 RID: 42951
		[Token(Token = "0x400A7C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUid;

		// Token: 0x0400A7C8 RID: 42952
		[Token(Token = "0x400A7C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textVisitorLevel;

		// Token: 0x0400A7C9 RID: 42953
		[Token(Token = "0x400A7C9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0400A7CA RID: 42954
		[Token(Token = "0x400A7CA")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400A7CB RID: 42955
		[Token(Token = "0x400A7CB")]
		[FieldOffset(Offset = "0x60")]
		private PlayerAvatarView m_avatar;

		// Token: 0x0400A7CC RID: 42956
		[Token(Token = "0x400A7CC")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x0400A7CD RID: 42957
		[Token(Token = "0x400A7CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0400A7CE RID: 42958
		[Token(Token = "0x400A7CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A7CF RID: 42959
		[Token(Token = "0x400A7CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0400A7D0 RID: 42960
		[Token(Token = "0x400A7D0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A7D1 RID: 42961
		[Token(Token = "0x400A7D1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
