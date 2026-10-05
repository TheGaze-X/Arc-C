using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C22 RID: 3106
	[Token(Token = "0x2000C22")]
	[Serializable]
	public class ActArchiveCapsuleData
	{
		// Token: 0x06006901 RID: 26881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006901")]
		[Address(RVA = "0x1FF83A0", Offset = "0x1FF6FA0", VA = "0x181FF83A0")]
		public ActArchiveCapsuleData()
		{
		}

		// Token: 0x04003FA4 RID: 16292
		[Token(Token = "0x4003FA4")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveCapsuleItemData> capsule;
	}
}
