using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class StaticDiskDataSource : IStaticDataSource
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public StaticDiskDataSource(string fileName)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x4A5ECE0", Offset = "0x4A5D8E0", VA = "0x184A5ECE0", Slot = "4")]
		public Stream GetSource()
		{
			return null;
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x10")]
		private string fileName_;
	}
}
