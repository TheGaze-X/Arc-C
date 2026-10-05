using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector.Internal
{
	// Token: 0x02007C86 RID: 31878
	[Token(Token = "0x2007C86")]
	public static class fiDirectory
	{
		// Token: 0x0602C88B RID: 182411 RVA: 0x000E0988 File Offset: 0x000DEB88
		[Token(Token = "0x602C88B")]
		[Address(RVA = "0x28674F0", Offset = "0x28660F0", VA = "0x1828674F0")]
		public static bool Exists(string path)
		{
			return default(bool);
		}

		// Token: 0x0602C88C RID: 182412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C88C")]
		[Address(RVA = "0x28674E0", Offset = "0x28660E0", VA = "0x1828674E0")]
		public static void CreateDirectory(string path)
		{
		}

		// Token: 0x0602C88D RID: 182413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C88D")]
		[Address(RVA = "0x2867500", Offset = "0x2866100", VA = "0x182867500")]
		public static IEnumerable<string> GetDirectories(string path)
		{
			return null;
		}
	}
}
