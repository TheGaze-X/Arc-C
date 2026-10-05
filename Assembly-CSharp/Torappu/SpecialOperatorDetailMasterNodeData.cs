using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200133C RID: 4924
	[Token(Token = "0x200133C")]
	public class SpecialOperatorDetailMasterNodeData
	{
		// Token: 0x060072F9 RID: 29433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorDetailMasterNodeData()
		{
		}

		// Token: 0x04006D38 RID: 27960
		[Token(Token = "0x4006D38")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006D39 RID: 27961
		[Token(Token = "0x4006D39")]
		[FieldOffset(Offset = "0x18")]
		public string masterId;

		// Token: 0x04006D3A RID: 27962
		[Token(Token = "0x4006D3A")]
		[FieldOffset(Offset = "0x20")]
		public int level;
	}
}
