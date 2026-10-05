using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006EA2 RID: 28322
	[Token(Token = "0x2006EA2")]
	public class VecBreakV2DefenseStartBattleRequest
	{
		// Token: 0x060284C2 RID: 165058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60284C2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VecBreakV2DefenseStartBattleRequest()
		{
		}

		// Token: 0x0403945A RID: 234586
		[Token(Token = "0x403945A")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403945B RID: 234587
		[Token(Token = "0x403945B")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0403945C RID: 234588
		[Token(Token = "0x403945C")]
		[FieldOffset(Offset = "0x20")]
		public CommonStartBattleRequest.SquadModel squad;
	}
}
