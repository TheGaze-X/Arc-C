using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642D RID: 25645
	[Token(Token = "0x200642D")]
	public class AutoChessBattleSelfChoiceInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EB9 RID: 151225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB9")]
		[Address(RVA = "0x1FB3EF0", Offset = "0x1FB2AF0", VA = "0x181FB3EF0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EBA RID: 151226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EBA")]
		[Address(RVA = "0x1FB3FD0", Offset = "0x1FB2BD0", VA = "0x181FB3FD0")]
		public AutoChessBattleSelfChoiceInfo()
		{
		}

		// Token: 0x04033A37 RID: 211511
		[Token(Token = "0x4033A37")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBattleSpPrepareSlot> options;

		// Token: 0x04033A38 RID: 211512
		[Token(Token = "0x4033A38")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x04033A39 RID: 211513
		[Token(Token = "0x4033A39")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A3A RID: 211514
		[Token(Token = "0x4033A3A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
