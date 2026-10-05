using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E81 RID: 28289
	[Token(Token = "0x2006E81")]
	public class VecBreakSquadPage : StateEnginePage
	{
		// Token: 0x06028437 RID: 164919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028437")]
		[Address(RVA = "0x23A3050", Offset = "0x23A1C50", VA = "0x1823A3050")]
		public VecBreakSquadPage()
		{
		}

		// Token: 0x04039396 RID: 234390
		[Token(Token = "0x4039396")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006E82 RID: 28290
		[Token(Token = "0x2006E82")]
		public struct InputParams
		{
			// Token: 0x04039397 RID: 234391
			[Token(Token = "0x4039397")]
			[FieldOffset(Offset = "0x0")]
			public string activityId;

			// Token: 0x04039398 RID: 234392
			[Token(Token = "0x4039398")]
			[FieldOffset(Offset = "0x8")]
			public string stageId;

			// Token: 0x04039399 RID: 234393
			[Token(Token = "0x4039399")]
			[FieldOffset(Offset = "0x10")]
			public VecBreakStageType stageType;

			// Token: 0x0403939A RID: 234394
			[Token(Token = "0x403939A")]
			[FieldOffset(Offset = "0x18")]
			public DataBundle bundleToJumpBack;
		}
	}
}
