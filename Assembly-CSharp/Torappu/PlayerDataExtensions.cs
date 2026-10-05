using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000C16 RID: 3094
	[Token(Token = "0x2000C16")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class PlayerDataExtensions
	{
		// Token: 0x060068E7 RID: 26855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068E7")]
		[Address(RVA = "0x200BC50", Offset = "0x200A850", VA = "0x18200BC50")]
		public static PlayerInviteData GetInvite(this PlayerData playerData, PlayerInviteType type, string id)
		{
			return null;
		}

		// Token: 0x04003F75 RID: 16245
		[Token(Token = "0x4003F75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetInvite;
	}
}
