using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.Caching
{
	// Token: 0x0200050A RID: 1290
	[Token(Token = "0x200050A")]
	public sealed class UriComparer : IEqualityComparer<Uri>
	{
		// Token: 0x06002AB4 RID: 10932 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x6002AB4")]
		[Address(RVA = "0x53DD820", Offset = "0x53DC420", VA = "0x1853DD820", Slot = "4")]
		public bool Equals(Uri x, Uri y)
		{
			return default(bool);
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x6002AB5")]
		[Address(RVA = "0x53DD8A0", Offset = "0x53DC4A0", VA = "0x1853DD8A0", Slot = "5")]
		public int GetHashCode(Uri uri)
		{
			return 0;
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AB6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UriComparer()
		{
		}
	}
}
