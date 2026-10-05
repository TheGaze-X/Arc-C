using System;
using Il2CppDummyDll;

namespace FullInspector.BackupService
{
	// Token: 0x02007C6A RID: 31850
	[Token(Token = "0x2007C6A")]
	public class fiDeserializedMember
	{
		// Token: 0x0602C81D RID: 182301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C81D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiDeserializedMember()
		{
		}

		// Token: 0x04040346 RID: 262982
		[Token(Token = "0x4040346")]
		[FieldOffset(Offset = "0x10")]
		public InspectedProperty InspectedProperty;

		// Token: 0x04040347 RID: 262983
		[Token(Token = "0x4040347")]
		[FieldOffset(Offset = "0x18")]
		public object Value;

		// Token: 0x04040348 RID: 262984
		[Token(Token = "0x4040348")]
		[FieldOffset(Offset = "0x20")]
		public fiEnableRestore ShouldRestore;
	}
}
