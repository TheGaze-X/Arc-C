using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006420 RID: 25632
	[Token(Token = "0x2006420")]
	public class AutoChessBattleSpPreparePlayer : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024E9D RID: 151197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9D")]
		[Address(RVA = "0x1FB4220", Offset = "0x1FB2E20", VA = "0x181FB4220", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E9E RID: 151198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E9E")]
		[Address(RVA = "0x1FB42D0", Offset = "0x1FB2ED0", VA = "0x181FB42D0")]
		public AutoChessBattleSpPreparePlayer()
		{
		}

		// Token: 0x040339E3 RID: 211427
		[Token(Token = "0x40339E3")]
		[FieldOffset(Offset = "0x10")]
		public int uidIndex;

		// Token: 0x040339E4 RID: 211428
		[Token(Token = "0x40339E4")]
		[FieldOffset(Offset = "0x14")]
		public int choice;

		// Token: 0x040339E5 RID: 211429
		[Token(Token = "0x40339E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339E6 RID: 211430
		[Token(Token = "0x40339E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
