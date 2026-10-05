using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	internal sealed class TypeInformation
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000459")]
		internal string FullTypeName
		{
			[Token(Token = "0x6002158")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700045A")]
		internal string AssemblyString
		{
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x1700045B")]
		internal bool HasTypeForwardedFrom
		{
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215B")]
		[Address(RVA = "0x4AE4B20", Offset = "0x4AE3720", VA = "0x184AE4B20")]
		internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom)
		{
		}

		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x10")]
		private string fullTypeName;

		// Token: 0x04001260 RID: 4704
		[Token(Token = "0x4001260")]
		[FieldOffset(Offset = "0x18")]
		private string assemblyString;

		// Token: 0x04001261 RID: 4705
		[Token(Token = "0x4001261")]
		[FieldOffset(Offset = "0x20")]
		private bool hasTypeForwardedFrom;
	}
}
