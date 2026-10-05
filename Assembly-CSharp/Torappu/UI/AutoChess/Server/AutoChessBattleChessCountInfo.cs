using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642C RID: 25644
	[Token(Token = "0x200642C")]
	public class AutoChessBattleChessCountInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EB7 RID: 151223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB7")]
		[Address(RVA = "0x1FAF730", Offset = "0x1FAE330", VA = "0x181FAF730", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EB8 RID: 151224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB8")]
		[Address(RVA = "0x1FAF7E0", Offset = "0x1FAE3E0", VA = "0x181FAF7E0")]
		public AutoChessBattleChessCountInfo()
		{
		}

		// Token: 0x04033A33 RID: 211507
		[Token(Token = "0x4033A33")]
		[FieldOffset(Offset = "0x10")]
		public int chessIdentifier;

		// Token: 0x04033A34 RID: 211508
		[Token(Token = "0x4033A34")]
		[FieldOffset(Offset = "0x14")]
		public int count;

		// Token: 0x04033A35 RID: 211509
		[Token(Token = "0x4033A35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A36 RID: 211510
		[Token(Token = "0x4033A36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
