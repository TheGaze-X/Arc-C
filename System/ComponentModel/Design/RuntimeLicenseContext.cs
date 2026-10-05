using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	internal class RuntimeLicenseContext : LicenseContext
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x5187D90", Offset = "0x5186990", VA = "0x185187D90")]
		private string GetLocalPath(string fileName)
		{
			return null;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x5187E10", Offset = "0x5186A10", VA = "0x185187E10", Slot = "6")]
		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return null;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x5187B50", Offset = "0x5186750", VA = "0x185187B50")]
		private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
		{
			return null;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public RuntimeLicenseContext()
		{
		}

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x0")]
		private static TraceSwitch s_runtimeLicenseContextSwitch;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x10")]
		internal Hashtable savedLicenseKeys;
	}
}
