using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047C9 RID: 18377
	[Token(Token = "0x20047C9")]
	public class PlayerAvatarDisplayState : PopupFloatState
	{
		// Token: 0x0601BD13 RID: 113939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD13")]
		[Address(RVA = "0x1527850", Offset = "0x1526450", VA = "0x181527850", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601BD14 RID: 113940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD14")]
		[Address(RVA = "0x15278B0", Offset = "0x15264B0", VA = "0x1815278B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601BD15 RID: 113941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD15")]
		[Address(RVA = "0x1527A80", Offset = "0x1526680", VA = "0x181527A80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BD16 RID: 113942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD16")]
		[Address(RVA = "0x1527720", Offset = "0x1526320", VA = "0x181527720")]
		public void CloseState()
		{
		}

		// Token: 0x0601BD17 RID: 113943 RVA: 0x000A65C0 File Offset: 0x000A47C0
		[Token(Token = "0x601BD17")]
		[Address(RVA = "0x1527BD0", Offset = "0x15267D0", VA = "0x181527BD0")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601BD18 RID: 113944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD18")]
		[Address(RVA = "0x1527C80", Offset = "0x1526880", VA = "0x181527C80")]
		public PlayerAvatarDisplayState()
		{
		}

		// Token: 0x0601BD19 RID: 113945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD19")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04024313 RID: 148243
		[Token(Token = "0x4024313")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PlayerAvatarDisplayView _view;

		// Token: 0x04024314 RID: 148244
		[Token(Token = "0x4024314")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backClick;

		// Token: 0x04024315 RID: 148245
		[Token(Token = "0x4024315")]
		[FieldOffset(Offset = "0x80")]
		private PlayerAvatarDisplayStateBean m_stateBean;

		// Token: 0x04024316 RID: 148246
		[Token(Token = "0x4024316")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04024317 RID: 148247
		[Token(Token = "0x4024317")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024318 RID: 148248
		[Token(Token = "0x4024318")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024319 RID: 148249
		[Token(Token = "0x4024319")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402431A RID: 148250
		[Token(Token = "0x402431A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseState;

		// Token: 0x0402431B RID: 148251
		[Token(Token = "0x402431B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x0402431C RID: 148252
		[Token(Token = "0x402431C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
