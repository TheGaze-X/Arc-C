using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013BC RID: 5052
	[Token(Token = "0x20013BC")]
	[Serializable]
	public class VoiceLangInfoData
	{
		// Token: 0x060073A7 RID: 29607 RVA: 0x000336C0 File Offset: 0x000318C0
		[Token(Token = "0x60073A7")]
		[Address(RVA = "0x1FFE4B0", Offset = "0x1FFD0B0", VA = "0x181FFE4B0")]
		public bool ShouldSerializevoicePath()
		{
			return default(bool);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073A8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public VoiceLangInfoData()
		{
		}

		// Token: 0x04007051 RID: 28753
		[Token(Token = "0x4007051")]
		[FieldOffset(Offset = "0x10")]
		public string wordkey;

		// Token: 0x04007052 RID: 28754
		[Token(Token = "0x4007052")]
		[FieldOffset(Offset = "0x18")]
		public VoiceLangType voiceLangType;

		// Token: 0x04007053 RID: 28755
		[Token(Token = "0x4007053")]
		[FieldOffset(Offset = "0x20")]
		public List<string> cvName;

		// Token: 0x04007054 RID: 28756
		[Token(Token = "0x4007054")]
		[FieldOffset(Offset = "0x28")]
		public string voicePath;
	}
}
