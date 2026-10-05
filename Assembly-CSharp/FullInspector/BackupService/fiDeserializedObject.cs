using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.BackupService
{
	// Token: 0x02007C69 RID: 31849
	[Token(Token = "0x2007C69")]
	public class fiDeserializedObject
	{
		// Token: 0x0602C81C RID: 182300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C81C")]
		[Address(RVA = "0x2866F50", Offset = "0x2865B50", VA = "0x182866F50")]
		public fiDeserializedObject(fiSerializedObject serializedState)
		{
		}

		// Token: 0x04040345 RID: 262981
		[Token(Token = "0x4040345")]
		[FieldOffset(Offset = "0x10")]
		public List<fiDeserializedMember> Members;
	}
}
