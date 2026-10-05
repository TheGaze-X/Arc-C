using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013BB RID: 5051
	[Token(Token = "0x20013BB")]
	[Serializable]
	public class VoiceLangGroupData
	{
		// Token: 0x060073A6 RID: 29606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoiceLangGroupData()
		{
		}

		// Token: 0x0400704F RID: 28751
		[Token(Token = "0x400704F")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04007050 RID: 28752
		[Token(Token = "0x4007050")]
		[FieldOffset(Offset = "0x18")]
		public List<VoiceLangType> members;
	}
}
