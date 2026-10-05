using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine.FMOD
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public class FMODData
	{
		// Token: 0x06000E42 RID: 3650 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x55816E0", Offset = "0x55802E0", VA = "0x1855816E0")]
		public FMODData()
		{
		}

		// Token: 0x04000EC5 RID: 3781
		[Token(Token = "0x4000EC5")]
		[FieldOffset(Offset = "0x10")]
		public List<BankData> banks;

		// Token: 0x04000EC6 RID: 3782
		[Token(Token = "0x4000EC6")]
		[FieldOffset(Offset = "0x18")]
		public List<BankData> masters;

		// Token: 0x04000EC7 RID: 3783
		[Token(Token = "0x4000EC7")]
		[FieldOffset(Offset = "0x20")]
		public string paramSpatial;

		// Token: 0x04000EC8 RID: 3784
		[Token(Token = "0x4000EC8")]
		[FieldOffset(Offset = "0x28")]
		public string paramIntensity;

		// Token: 0x04000EC9 RID: 3785
		[Token(Token = "0x4000EC9")]
		[FieldOffset(Offset = "0x30")]
		public List<string> soundEvents;

		// Token: 0x04000ECA RID: 3786
		[Token(Token = "0x4000ECA")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ParamData> paramsInfo;

		// Token: 0x04000ECB RID: 3787
		[Token(Token = "0x4000ECB")]
		[FieldOffset(Offset = "0x40")]
		public string rawRoot;

		// Token: 0x04000ECC RID: 3788
		[Token(Token = "0x4000ECC")]
		[FieldOffset(Offset = "0x48")]
		public string resRoot;
	}
}
