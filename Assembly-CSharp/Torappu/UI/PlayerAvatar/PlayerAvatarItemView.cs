using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047D5 RID: 18389
	[Token(Token = "0x20047D5")]
	public class PlayerAvatarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BD46 RID: 113990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD46")]
		[Address(RVA = "0x1529090", Offset = "0x1527C90", VA = "0x181529090")]
		public void Render(PlayerAvatarItemViewModel viewModel)
		{
		}

		// Token: 0x0601BD47 RID: 113991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD47")]
		[Address(RVA = "0x1529000", Offset = "0x1527C00", VA = "0x181529000")]
		public void OnClick()
		{
		}

		// Token: 0x0601BD48 RID: 113992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD48")]
		[Address(RVA = "0x15291C0", Offset = "0x1527DC0", VA = "0x1815291C0")]
		public PlayerAvatarItemView()
		{
		}

		// Token: 0x0402436B RID: 148331
		[Token(Token = "0x402436B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _selectTransform;

		// Token: 0x0402436C RID: 148332
		[Token(Token = "0x402436C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _avatarImage;

		// Token: 0x0402436D RID: 148333
		[Token(Token = "0x402436D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0402436E RID: 148334
		[Token(Token = "0x402436E")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public UIPlayerAvatarEvent clickEvent;

		// Token: 0x0402436F RID: 148335
		[Token(Token = "0x402436F")]
		[FieldOffset(Offset = "0x38")]
		private PlayerAvatarItemViewModel m_viewModel;

		// Token: 0x04024370 RID: 148336
		[Token(Token = "0x4024370")]
		[FieldOffset(Offset = "0x40")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024371 RID: 148337
		[Token(Token = "0x4024371")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024372 RID: 148338
		[Token(Token = "0x4024372")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04024373 RID: 148339
		[Token(Token = "0x4024373")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
