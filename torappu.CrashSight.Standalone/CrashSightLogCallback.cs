using System;
using Il2CppDummyDll;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public abstract class CrashSightLogCallback
{
	// Token: 0x06000067 RID: 103
	[Token(Token = "0x6000067")]
	public abstract string OnSetLogPathEvent(int methodId, int crashType);

	// Token: 0x06000068 RID: 104
	[Token(Token = "0x6000068")]
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	protected CrashSightLogCallback()
	{
	}
}
