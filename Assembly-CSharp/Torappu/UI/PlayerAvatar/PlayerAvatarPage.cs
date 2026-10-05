using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.PlayerAvatar
{
	// Token: 0x020047C7 RID: 18375
	[Token(Token = "0x20047C7")]
	public class PlayerAvatarPage : StateEnginePage
	{
		// Token: 0x0601BD09 RID: 113929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD09")]
		[Address(RVA = "0x1529220", Offset = "0x1527E20", VA = "0x181529220", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601BD0A RID: 113930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BD0A")]
		[Address(RVA = "0x15292E0", Offset = "0x1527EE0", VA = "0x1815292E0")]
		public PlayerAvatarPage()
		{
		}

		// Token: 0x0601BD0C RID: 113932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BD0C")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0402430B RID: 148235
		[Token(Token = "0x402430B")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0402430C RID: 148236
		[Token(Token = "0x402430C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0402430D RID: 148237
		[Token(Token = "0x402430D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0402430E RID: 148238
		[Token(Token = "0x402430E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
