using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.UI.AutoChess.Server;
using XLua;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050F2 RID: 20722
	[Token(Token = "0x20050F2")]
	public abstract class UIDebugAutoChessProtocol
	{
		// Token: 0x0601EA02 RID: 125442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA02")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected UIDebugAutoChessProtocol()
		{
		}

		// Token: 0x020050F3 RID: 20723
		[Token(Token = "0x20050F3")]
		public class AutoChessBattleGmRequest : AutoChessServiceBattleRequest
		{
			// Token: 0x0601EA03 RID: 125443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA03")]
			[Address(RVA = "0x184F0A0", Offset = "0x184DCA0", VA = "0x18184F0A0")]
			public AutoChessBattleGmRequest()
			{
			}

			// Token: 0x0601EA04 RID: 125444 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA04")]
			[Address(RVA = "0x184EF60", Offset = "0x184DB60", VA = "0x18184EF60", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x0601EA05 RID: 125445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA05")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x040290C4 RID: 168132
			[Token(Token = "0x40290C4")]
			public const int ID = 1001;

			// Token: 0x040290C5 RID: 168133
			[Token(Token = "0x40290C5")]
			[FieldOffset(Offset = "0x18")]
			public string code;

			// Token: 0x040290C6 RID: 168134
			[Token(Token = "0x40290C6")]
			[FieldOffset(Offset = "0x20")]
			public List<string> paramList;

			// Token: 0x040290C7 RID: 168135
			[Token(Token = "0x40290C7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040290C8 RID: 168136
			[Token(Token = "0x40290C8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}
	}
}
