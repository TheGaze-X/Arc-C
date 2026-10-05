using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001339 RID: 4921
	[Token(Token = "0x2001339")]
	public class SpecialOperatorDetailEvolveNodeData
	{
		// Token: 0x060072F6 RID: 29430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorDetailEvolveNodeData()
		{
		}

		// Token: 0x04006D2F RID: 27951
		[Token(Token = "0x4006D2F")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04006D30 RID: 27952
		[Token(Token = "0x4006D30")]
		[FieldOffset(Offset = "0x18")]
		public EvolvePhase toEvolvePhase;
	}
}
