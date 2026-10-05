using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class ResolveEventArgs : System.EventArgs
	{
		// Token: 0x060009D9 RID: 2521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x4CF7540", Offset = "0x4CF6140", VA = "0x184CF7540")]
		public ResolveEventArgs(string name)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x4CF74C0", Offset = "0x4CF60C0", VA = "0x184CF74C0")]
		public ResolveEventArgs(string name, System.Reflection.Assembly requestingAssembly)
		{
		}
	}
}
