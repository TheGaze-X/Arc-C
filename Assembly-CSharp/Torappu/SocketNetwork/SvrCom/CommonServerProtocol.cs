using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.SocketNetwork.ServerBase;
using XLua;

namespace Torappu.SocketNetwork.SvrCom
{
	// Token: 0x020014A8 RID: 5288
	[Token(Token = "0x20014A8")]
	public class CommonServerProtocol
	{
		// Token: 0x06007A18 RID: 31256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A18")]
		[Address(RVA = "0x2637070", Offset = "0x2635C70", VA = "0x182637070")]
		public static void Register(ServerProtocolSuite suite)
		{
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonServerProtocol()
		{
		}

		// Token: 0x020014A9 RID: 5289
		[Token(Token = "0x20014A9")]
		public class CommonJoinUp : Protocol
		{
			// Token: 0x06007A1A RID: 31258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1A")]
			[Address(RVA = "0x2637010", Offset = "0x2635C10", VA = "0x182637010")]
			public CommonJoinUp()
			{
			}

			// Token: 0x06007A1B RID: 31259 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1B")]
			[Address(RVA = "0x2636EE0", Offset = "0x2635AE0", VA = "0x182636EE0", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007A1C RID: 31260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1C")]
			[Address(RVA = "0x2636FB0", Offset = "0x2635BB0", VA = "0x182636FB0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x0400782B RID: 30763
			[Token(Token = "0x400782B")]
			public const int ID = 5;

			// Token: 0x0400782C RID: 30764
			[Token(Token = "0x400782C")]
			[FieldOffset(Offset = "0x18")]
			public string uid;

			// Token: 0x0400782D RID: 30765
			[Token(Token = "0x400782D")]
			[FieldOffset(Offset = "0x20")]
			public string svrId;

			// Token: 0x0400782E RID: 30766
			[Token(Token = "0x400782E")]
			[FieldOffset(Offset = "0x28")]
			public string svrToken;

			// Token: 0x0400782F RID: 30767
			[Token(Token = "0x400782F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007830 RID: 30768
			[Token(Token = "0x4007830")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020014AA RID: 5290
		[Token(Token = "0x20014AA")]
		public class CommonJoinDn : Protocol
		{
			// Token: 0x06007A1D RID: 31261 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1D")]
			[Address(RVA = "0x2636E80", Offset = "0x2635A80", VA = "0x182636E80")]
			public CommonJoinDn()
			{
			}

			// Token: 0x06007A1E RID: 31262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1E")]
			[Address(RVA = "0x2636CB0", Offset = "0x26358B0", VA = "0x182636CB0", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007A1F RID: 31263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A1F")]
			[Address(RVA = "0x2636E20", Offset = "0x2635A20", VA = "0x182636E20")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007831 RID: 30769
			[Token(Token = "0x4007831")]
			public const int ID = 6;

			// Token: 0x04007832 RID: 30770
			[Token(Token = "0x4007832")]
			[FieldOffset(Offset = "0x18")]
			public CommonProtocolRetCode retCode;

			// Token: 0x04007833 RID: 30771
			[Token(Token = "0x4007833")]
			[FieldOffset(Offset = "0x20")]
			public string reason;

			// Token: 0x04007834 RID: 30772
			[Token(Token = "0x4007834")]
			[FieldOffset(Offset = "0x28")]
			public long svrTime;

			// Token: 0x04007835 RID: 30773
			[Token(Token = "0x4007835")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007836 RID: 30774
			[Token(Token = "0x4007836")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}
	}
}
