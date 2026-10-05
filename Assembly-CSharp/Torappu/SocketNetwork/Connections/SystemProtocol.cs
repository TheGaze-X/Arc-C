using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork.Connections
{
	// Token: 0x020014D2 RID: 5330
	[Token(Token = "0x20014D2")]
	public static class SystemProtocol
	{
		// Token: 0x020014D3 RID: 5331
		[Token(Token = "0x20014D3")]
		public class HeartBeat : Protocol
		{
			// Token: 0x06007AFD RID: 31485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFD")]
			[Address(RVA = "0x273C010", Offset = "0x273AC10", VA = "0x18273C010")]
			public HeartBeat()
			{
			}

			// Token: 0x06007AFE RID: 31486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFE")]
			[Address(RVA = "0x273B470", Offset = "0x273A070", VA = "0x18273B470", Slot = "5")]
			protected override void OnWrite(IStreamWriter to)
			{
			}

			// Token: 0x06007AFF RID: 31487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007AFF")]
			[Address(RVA = "0x1838FD0", Offset = "0x1837BD0", VA = "0x181838FD0")]
			private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
			{
			}

			// Token: 0x04007930 RID: 31024
			[Token(Token = "0x4007930")]
			public const uint ID = 1U;

			// Token: 0x04007931 RID: 31025
			[Token(Token = "0x4007931")]
			[FieldOffset(Offset = "0x18")]
			public uint seq;

			// Token: 0x04007932 RID: 31026
			[Token(Token = "0x4007932")]
			[FieldOffset(Offset = "0x20")]
			public long time;

			// Token: 0x04007933 RID: 31027
			[Token(Token = "0x4007933")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007934 RID: 31028
			[Token(Token = "0x4007934")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnWrite;
		}

		// Token: 0x020014D4 RID: 5332
		[Token(Token = "0x20014D4")]
		public class HeartBeatRet : Protocol
		{
			// Token: 0x06007B00 RID: 31488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B00")]
			[Address(RVA = "0x273B410", Offset = "0x273A010", VA = "0x18273B410")]
			public HeartBeatRet()
			{
			}

			// Token: 0x06007B01 RID: 31489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B01")]
			[Address(RVA = "0x273B250", Offset = "0x2739E50", VA = "0x18273B250", Slot = "4")]
			protected override void OnRead(IStreamReader from)
			{
			}

			// Token: 0x06007B02 RID: 31490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B02")]
			[Address(RVA = "0x1838E80", Offset = "0x1837A80", VA = "0x181838E80")]
			private void <>xLuaBaseProxy_OnRead(IStreamReader P0)
			{
			}

			// Token: 0x04007935 RID: 31029
			[Token(Token = "0x4007935")]
			public const uint ID = 2U;

			// Token: 0x04007936 RID: 31030
			[Token(Token = "0x4007936")]
			[FieldOffset(Offset = "0x18")]
			public uint seq;

			// Token: 0x04007937 RID: 31031
			[Token(Token = "0x4007937")]
			[FieldOffset(Offset = "0x20")]
			public long time;

			// Token: 0x04007938 RID: 31032
			[Token(Token = "0x4007938")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04007939 RID: 31033
			[Token(Token = "0x4007939")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnRead;
		}
	}
}
