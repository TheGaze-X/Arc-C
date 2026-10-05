using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class PathFilter : IScanFilter
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4A40900", Offset = "0x4A3F500", VA = "0x184A40900")]
		public PathFilter(string filter)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4A40830", Offset = "0x4A3F430", VA = "0x184A40830", Slot = "5")]
		public virtual bool IsMatch(string name)
		{
			return default(bool);
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		private NameFilter nameFilter_;
	}
}
