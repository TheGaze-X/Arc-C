using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062A7 RID: 25255
	[Token(Token = "0x20062A7")]
	public class AutoChessBattleReadyPlayerModel
	{
		// Token: 0x0602467E RID: 149118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602467E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessBattleReadyPlayerModel()
		{
		}

		// Token: 0x04032A98 RID: 207512
		[Token(Token = "0x4032A98")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04032A99 RID: 207513
		[Token(Token = "0x4032A99")]
		[FieldOffset(Offset = "0x18")]
		public PlayerAvatarQuery avatar;
	}
}
