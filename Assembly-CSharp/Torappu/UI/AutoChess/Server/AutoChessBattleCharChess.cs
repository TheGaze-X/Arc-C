using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006426 RID: 25638
	[Token(Token = "0x2006426")]
	public class AutoChessBattleCharChess : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EA9 RID: 151209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA9")]
		[Address(RVA = "0x1FAF3D0", Offset = "0x1FADFD0", VA = "0x181FAF3D0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EAA RID: 151210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EAA")]
		[Address(RVA = "0x1FAF4B0", Offset = "0x1FAE0B0", VA = "0x181FAF4B0")]
		public AutoChessBattleCharChess()
		{
		}

		// Token: 0x04033A13 RID: 211475
		[Token(Token = "0x4033A13")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04033A14 RID: 211476
		[Token(Token = "0x4033A14")]
		[FieldOffset(Offset = "0x18")]
		public List<int> equipInstIds;

		// Token: 0x04033A15 RID: 211477
		[Token(Token = "0x4033A15")]
		[FieldOffset(Offset = "0x20")]
		public int chessIdentifier;

		// Token: 0x04033A16 RID: 211478
		[Token(Token = "0x4033A16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A17 RID: 211479
		[Token(Token = "0x4033A17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
