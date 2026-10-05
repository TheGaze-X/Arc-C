using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D0 RID: 18384
	[Token(Token = "0x20047D0")]
	public class PlayerAvatarDisplayView : DataBinder<PlayerAvatarDisplayProperty>
	{
		// Token: 0x0601BD35 RID: 113973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD35")]
		[Address(RVA = "0x1527DF0", Offset = "0x15269F0", VA = "0x181527DF0", Slot = "7")]
		public override void OnValueChanged(PlayerAvatarDisplayProperty property)
		{
		}

		// Token: 0x0601BD36 RID: 113974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD36")]
		[Address(RVA = "0x1528060", Offset = "0x1526C60", VA = "0x181528060")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD37 RID: 113975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD37")]
		[Address(RVA = "0x1528130", Offset = "0x1526D30", VA = "0x181528130")]
		public PlayerAvatarDisplayView()
		{
		}

		// Token: 0x04024344 RID: 148292
		[Token(Token = "0x4024344")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04024345 RID: 148293
		[Token(Token = "0x4024345")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04024346 RID: 148294
		[Token(Token = "0x4024346")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _avatarNameText;

		// Token: 0x04024347 RID: 148295
		[Token(Token = "0x4024347")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _avatarDesText;

		// Token: 0x04024348 RID: 148296
		[Token(Token = "0x4024348")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _avatarObtainText;

		// Token: 0x04024349 RID: 148297
		[Token(Token = "0x4024349")]
		[FieldOffset(Offset = "0x48")]
		private bool m_hasInited;

		// Token: 0x0402434A RID: 148298
		[Token(Token = "0x402434A")]
		[FieldOffset(Offset = "0x50")]
		private PlayerAvatarView m_avatarView;

		// Token: 0x0402434B RID: 148299
		[Token(Token = "0x402434B")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402434C RID: 148300
		[Token(Token = "0x402434C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402434D RID: 148301
		[Token(Token = "0x402434D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402434E RID: 148302
		[Token(Token = "0x402434E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
