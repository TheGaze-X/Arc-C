using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class DynamicDiskDataSource : IDynamicDataSource
	{
		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DynamicDiskDataSource()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x4A5C7C0", Offset = "0x4A5B3C0", VA = "0x184A5C7C0", Slot = "4")]
		public Stream GetSource(ZipEntry entry, string name)
		{
			return null;
		}
	}
}
