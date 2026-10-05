using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047CA RID: 18378
	[Token(Token = "0x20047CA")]
	public class PlayerAvatarSelectState : PopupFloatState
	{
		// Token: 0x0601BD1A RID: 113946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD1A")]
		[Address(RVA = "0x152A090", Offset = "0x1528C90", VA = "0x18152A090", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BD1B RID: 113947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD1B")]
		[Address(RVA = "0x152A890", Offset = "0x1529490", VA = "0x18152A890")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD1C RID: 113948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD1C")]
		[Address(RVA = "0x152AA10", Offset = "0x1529610", VA = "0x18152AA10")]
		private void _UpdateAvatarIconAndDesc(PlayerAvatarItemViewModel viewModel)
		{
		}

		// Token: 0x0601BD1D RID: 113949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD1D")]
		[Address(RVA = "0x152A570", Offset = "0x1529170", VA = "0x18152A570", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BD1E RID: 113950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD1E")]
		[Address(RVA = "0x152A0F0", Offset = "0x1528CF0", VA = "0x18152A0F0")]
		public void OnClickAvatarEvent(PlayerAvatarItemViewModel viewModel)
		{
		}

		// Token: 0x0601BD1F RID: 113951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD1F")]
		[Address(RVA = "0x152A260", Offset = "0x1528E60", VA = "0x18152A260")]
		public void OnClickSendNewAvatar()
		{
		}

		// Token: 0x0601BD20 RID: 113952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD20")]
		[Address(RVA = "0x152A020", Offset = "0x1528C20", VA = "0x18152A020")]
		public void ClosePage()
		{
		}

		// Token: 0x0601BD21 RID: 113953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD21")]
		[Address(RVA = "0x152AC00", Offset = "0x1529800", VA = "0x18152AC00")]
		public PlayerAvatarSelectState()
		{
		}

		// Token: 0x0601BD24 RID: 113956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD24")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402431D RID: 148253
		[Token(Token = "0x402431D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PlayerAvatarGroupListView _listView;

		// Token: 0x0402431E RID: 148254
		[Token(Token = "0x402431E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PlayerAvatarSelectStateBean _stateBean;

		// Token: 0x0402431F RID: 148255
		[Token(Token = "0x402431F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x04024320 RID: 148256
		[Token(Token = "0x4024320")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x04024321 RID: 148257
		[Token(Token = "0x4024321")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x04024322 RID: 148258
		[Token(Token = "0x4024322")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _descText;

		// Token: 0x04024323 RID: 148259
		[Token(Token = "0x4024323")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04024324 RID: 148260
		[Token(Token = "0x4024324")]
		[FieldOffset(Offset = "0xA8")]
		private PlayerAvatarView m_displayAvatar;

		// Token: 0x04024325 RID: 148261
		[Token(Token = "0x4024325")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024326 RID: 148262
		[Token(Token = "0x4024326")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024327 RID: 148263
		[Token(Token = "0x4024327")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateAvatarIconAndDesc;

		// Token: 0x04024328 RID: 148264
		[Token(Token = "0x4024328")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024329 RID: 148265
		[Token(Token = "0x4024329")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickAvatarEvent;

		// Token: 0x0402432A RID: 148266
		[Token(Token = "0x402432A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickSendNewAvatar;

		// Token: 0x0402432B RID: 148267
		[Token(Token = "0x402432B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ClosePage;

		// Token: 0x0402432C RID: 148268
		[Token(Token = "0x402432C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
