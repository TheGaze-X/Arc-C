using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI
{
	// Token: 0x02001BA2 RID: 7074
	[Token(Token = "0x2001BA2")]
	public struct BuildCostCheckingResult
	{
		// Token: 0x0600B087 RID: 45191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B087")]
		[Address(RVA = "0x32A0F90", Offset = "0x329FB90", VA = "0x1832A0F90")]
		public BuildCostCheckingResult(bool passed, BuildCostCheckingResult.Reason[] reasons)
		{
		}

		// Token: 0x0400AAF9 RID: 43769
		[Token(Token = "0x400AAF9")]
		[FieldOffset(Offset = "0x0")]
		public bool passed;

		// Token: 0x0400AAFA RID: 43770
		[Token(Token = "0x400AAFA")]
		[FieldOffset(Offset = "0x8")]
		public BuildCostCheckingResult.Reason[] reasons;

		// Token: 0x02001BA3 RID: 7075
		[Token(Token = "0x2001BA3")]
		public struct Reason
		{
			// Token: 0x0600B088 RID: 45192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B088")]
			[Address(RVA = "0x32B0C90", Offset = "0x32AF890", VA = "0x1832B0C90")]
			public Reason(bool isLabor, string itemId, int currentCount, int targetCount)
			{
			}

			// Token: 0x0400AAFB RID: 43771
			[Token(Token = "0x400AAFB")]
			[FieldOffset(Offset = "0x0")]
			public bool isLabor;

			// Token: 0x0400AAFC RID: 43772
			[Token(Token = "0x400AAFC")]
			[FieldOffset(Offset = "0x8")]
			public string itemId;

			// Token: 0x0400AAFD RID: 43773
			[Token(Token = "0x400AAFD")]
			[FieldOffset(Offset = "0x10")]
			public int currentCount;

			// Token: 0x0400AAFE RID: 43774
			[Token(Token = "0x400AAFE")]
			[FieldOffset(Offset = "0x14")]
			public int targetCount;
		}
	}
}
