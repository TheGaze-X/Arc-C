using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	internal sealed class BinaryAssemblyInfo
	{
		// Token: 0x06002084 RID: 8324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal BinaryAssemblyInfo(string assemblyString)
		{
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal BinaryAssemblyInfo(string assemblyString, System.Reflection.Assembly assembly)
		{
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x4B93B80", Offset = "0x4B92780", VA = "0x184B93B80")]
		internal System.Reflection.Assembly GetAssembly()
		{
			return null;
		}

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x10")]
		internal string assemblyString;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x18")]
		private System.Reflection.Assembly assembly;
	}
}
