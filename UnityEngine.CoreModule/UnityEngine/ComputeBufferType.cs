using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000098 RID: 152
	[Token(Token = "0x2000098")]
	[Flags]
	public enum ComputeBufferType
	{
		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		Default = 0,
		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		Raw = 1,
		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		Append = 2,
		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		Counter = 4,
		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		Constant = 8,
		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		Structured = 16,
		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[Obsolete("Enum member DrawIndirect has been deprecated. Use IndirectArguments instead (UnityUpgradable) -> IndirectArguments", false)]
		DrawIndirect = 256,
		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		IndirectArguments = 256,
		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[Obsolete("Enum member GPUMemory has been deprecated. All compute buffers now follow the behavior previously defined by this member.", false)]
		GPUMemory = 512
	}
}
