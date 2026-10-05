using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x02000377 RID: 887
	[Token(Token = "0x2000377")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class TypeEntry
	{
		// Token: 0x06001D22 RID: 7458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TypeEntry()
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000356")]
		public string AssemblyName
		{
			[Token(Token = "0x6001D23")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D24")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000357")]
		public string TypeName
		{
			[Token(Token = "0x6001D25")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D26")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string assembly_name;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string type_name;
	}
}
