using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace Torappu.Battle.AntiCheat
{
	// Token: 0x02002A88 RID: 10888
	[Token(Token = "0x2002A88")]
	public class BlackboardSnapshot
	{
		// Token: 0x0601214F RID: 74063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601214F")]
		[Address(RVA = "0xA1F680", Offset = "0xA1E280", VA = "0x180A1F680")]
		public static BlackboardSnapshot CreateFrom(Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x06012150 RID: 74064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012150")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BlackboardSnapshot()
		{
		}

		// Token: 0x04014767 RID: 83815
		[Token(Token = "0x4014767")]
		[FieldOffset(Offset = "0x10")]
		public ObscuredFloat[] values;
	}
}
