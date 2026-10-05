using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013BA RID: 5050
	[Token(Token = "0x20013BA")]
	[Serializable]
	public class VoiceLangTypeData
	{
		// Token: 0x060073A5 RID: 29605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoiceLangTypeData()
		{
		}

		// Token: 0x0400704D RID: 28749
		[Token(Token = "0x400704D")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400704E RID: 28750
		[Token(Token = "0x400704E")]
		[FieldOffset(Offset = "0x18")]
		public VoiceLangGroupType groupType;
	}
}
