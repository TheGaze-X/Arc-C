using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Permissions
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Obsolete("CAS support is not available with Silverlight applications.")]
	[System.Serializable]
	public enum SecurityAction
	{
		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		Demand = 2,
		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		Assert,
		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[System.Obsolete("This requests should not be used")]
		Deny,
		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		PermitOnly,
		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		LinkDemand,
		// Token: 0x04000D1D RID: 3357
		[Token(Token = "0x4000D1D")]
		InheritanceDemand,
		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		[System.Obsolete("This requests should not be used")]
		RequestMinimum,
		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[System.Obsolete("This requests should not be used")]
		RequestOptional,
		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		[System.Obsolete("This requests should not be used")]
		RequestRefuse
	}
}
