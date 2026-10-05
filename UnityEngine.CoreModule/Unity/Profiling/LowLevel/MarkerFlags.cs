using System;
using Il2CppDummyDll;

namespace Unity.Profiling.LowLevel
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Flags]
	public enum MarkerFlags : ushort
	{
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		Default = 0,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		Script = 2,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		ScriptInvoke = 32,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		ScriptDeepProfiler = 64,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		AvailabilityEditor = 4,
		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		AvailabilityNonDevelopment = 8,
		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		Warning = 16,
		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		Counter = 128,
		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		SampleGPU = 256
	}
}
