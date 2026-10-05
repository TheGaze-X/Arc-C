using System;
using Il2CppDummyDll;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public abstract class CrashSightCallback
{
	// Token: 0x06000065 RID: 101
	[Token(Token = "0x6000065")]
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	protected CrashSightCallback()
	{
	}
}
