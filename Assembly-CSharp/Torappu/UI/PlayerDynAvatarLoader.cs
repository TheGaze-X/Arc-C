using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AEF RID: 15087
	[Token(Token = "0x2003AEF")]
	public class PlayerDynAvatarLoader : PageAssetPool<PlayerDynAvatarView>
	{
		// Token: 0x06017C88 RID: 97416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017C88")]
		[Address(RVA = "0x1003D10", Offset = "0x1002910", VA = "0x181003D10")]
		public PlayerDynAvatarView LoadDynAvatar(string dynAvatarId, Transform parent)
		{
			return null;
		}

		// Token: 0x06017C89 RID: 97417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C89")]
		[Address(RVA = "0x1003ED0", Offset = "0x1002AD0", VA = "0x181003ED0")]
		public void NotifyDynAvatarUsed(string dynAvatarId)
		{
		}

		// Token: 0x06017C8A RID: 97418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017C8A")]
		[Address(RVA = "0x1003F60", Offset = "0x1002B60", VA = "0x181003F60")]
		public PlayerDynAvatarLoader()
		{
		}

		// Token: 0x0401CB8D RID: 117645
		[Token(Token = "0x401CB8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadDynAvatar;

		// Token: 0x0401CB8E RID: 117646
		[Token(Token = "0x401CB8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyDynAvatarUsed;

		// Token: 0x0401CB8F RID: 117647
		[Token(Token = "0x401CB8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
