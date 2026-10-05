using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	public class PlayerDataTracker : SingletonInScene<PlayerDataTracker>
	{
		// Token: 0x06005B6F RID: 23407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B6F")]
		[Address(RVA = "0x1AF7790", Offset = "0x1AF6390", VA = "0x181AF7790")]
		private PlayerDataTracker()
		{
		}

		// Token: 0x06005B70 RID: 23408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B70")]
		[Address(RVA = "0x1AF75C0", Offset = "0x1AF61C0", VA = "0x181AF75C0")]
		public static void Register(IPlayerDataListener listener)
		{
		}

		// Token: 0x06005B71 RID: 23409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B71")]
		[Address(RVA = "0x1AF76F0", Offset = "0x1AF62F0", VA = "0x181AF76F0")]
		public static void Unregister(IPlayerDataListener listener)
		{
		}

		// Token: 0x06005B72 RID: 23410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B72")]
		[Address(RVA = "0x1AF73D0", Offset = "0x1AF5FD0", VA = "0x181AF73D0")]
		public static void PlayerDataOnlyNotifyDataChanged(PlayerDataModel prevData, PlayerDataDelta delta)
		{
		}

		// Token: 0x040020FC RID: 8444
		[Token(Token = "0x40020FC")]
		[FieldOffset(Offset = "0x18")]
		private List<IPlayerDataListener> m_listeners;

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Unregister;

		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayerDataOnlyNotifyDataChanged;
	}
}
