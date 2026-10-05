using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200035E RID: 862
	[Token(Token = "0x200035E")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class ActivatedServiceTypeEntry : TypeEntry
	{
		// Token: 0x06001C62 RID: 7266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C62")]
		[Address(RVA = "0x4B52C90", Offset = "0x4B51890", VA = "0x184B52C90")]
		public ActivatedServiceTypeEntry(string typeName, string assemblyName)
		{
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000337")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001C63")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x4B52C80", Offset = "0x4B51880", VA = "0x184B52C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Type obj_type;
	}
}
