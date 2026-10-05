using System;
using Il2CppDummyDll;

namespace FullInspector.BackupService
{
	// Token: 0x02007C68 RID: 31848
	[Token(Token = "0x2007C68")]
	[Serializable]
	public class fiEnableRestore
	{
		// Token: 0x0602C81B RID: 182299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C81B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public fiEnableRestore()
		{
		}

		// Token: 0x04040344 RID: 262980
		[Token(Token = "0x4040344")]
		[FieldOffset(Offset = "0x10")]
		public bool Enabled;
	}
}
