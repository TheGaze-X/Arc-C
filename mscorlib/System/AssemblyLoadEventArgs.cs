using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public class AssemblyLoadEventArgs : System.EventArgs
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x4CA5320", Offset = "0x4CA3F20", VA = "0x184CA5320")]
		public AssemblyLoadEventArgs(System.Reflection.Assembly loadedAssembly)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000068")]
		public System.Reflection.Assembly LoadedAssembly
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
