using System;
using Il2CppDummyDll;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
[Serializable]
public class SerializedTNodeDataAction
{
	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
	public SerializedTNodeDataAction()
	{
	}

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x10")]
	public SerializedTNodeAction action;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x18")]
	public SerializedTNodeData data;
}
