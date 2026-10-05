using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	internal class ResourceFallbackManager : System.Collections.Generic.IEnumerable<System.Globalization.CultureInfo>, System.Collections.IEnumerable
	{
		// Token: 0x06002390 RID: 9104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x4BDCE20", Offset = "0x4BDBA20", VA = "0x184BDCE20")]
		internal ResourceFallbackManager(System.Globalization.CultureInfo startingCulture, System.Globalization.CultureInfo neutralResourcesCulture, bool useParents)
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x4BDCE10", Offset = "0x4BDBA10", VA = "0x184BDCE10", Slot = "5")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x4BDCD90", Offset = "0x4BDB990", VA = "0x184BDCD90", Slot = "4")]
		public System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo> GetEnumerator()
		{
			return null;
		}

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0x10")]
		private System.Globalization.CultureInfo m_startingCulture;

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x18")]
		private System.Globalization.CultureInfo m_neutralResourcesCulture;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_useParents;
	}
}
