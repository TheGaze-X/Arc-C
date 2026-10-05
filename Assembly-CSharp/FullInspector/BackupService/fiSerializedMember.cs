using System;
using Il2CppDummyDll;

namespace FullInspector.BackupService
{
	// Token: 0x02007C6D RID: 31853
	[Token(Token = "0x2007C6D")]
	[Serializable]
	public class fiSerializedMember
	{
		// Token: 0x0602C822 RID: 182306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C822")]
		[Address(RVA = "0x2872630", Offset = "0x2871230", VA = "0x182872630")]
		public fiSerializedMember()
		{
		}

		// Token: 0x04040350 RID: 262992
		[Token(Token = "0x4040350")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04040351 RID: 262993
		[Token(Token = "0x4040351")]
		[FieldOffset(Offset = "0x18")]
		public string Value;

		// Token: 0x04040352 RID: 262994
		[Token(Token = "0x4040352")]
		[FieldOffset(Offset = "0x20")]
		public fiEnableRestore ShouldRestore;
	}
}
