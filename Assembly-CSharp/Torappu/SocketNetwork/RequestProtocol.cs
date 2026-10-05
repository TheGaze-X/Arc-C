using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x0200149D RID: 5277
	[Token(Token = "0x200149D")]
	public class RequestProtocol : Protocol
	{
		// Token: 0x060079EF RID: 31215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EF")]
		[Address(RVA = "0x2646A20", Offset = "0x2645620", VA = "0x182646A20")]
		public RequestProtocol(uint pid, IStreamSerialize body)
		{
		}

		// Token: 0x060079F0 RID: 31216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F0")]
		[Address(RVA = "0x2646880", Offset = "0x2645480", VA = "0x182646880", Slot = "5")]
		protected override void OnWrite(IStreamWriter to)
		{
		}

		// Token: 0x060079F1 RID: 31217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F1")]
		[Address(RVA = "0x2646910", Offset = "0x2645510", VA = "0x182646910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060079F2 RID: 31218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079F2")]
		[Address(RVA = "0x2636FB0", Offset = "0x2635BB0", VA = "0x182636FB0")]
		private void <>xLuaBaseProxy_OnWrite(IStreamWriter P0)
		{
		}

		// Token: 0x060079F3 RID: 31219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60079F3")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040077FB RID: 30715
		[Token(Token = "0x40077FB")]
		[FieldOffset(Offset = "0x18")]
		private IStreamSerialize m_body;

		// Token: 0x040077FC RID: 30716
		[Token(Token = "0x40077FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040077FD RID: 30717
		[Token(Token = "0x40077FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnWrite;

		// Token: 0x040077FE RID: 30718
		[Token(Token = "0x40077FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToString;
	}
}
