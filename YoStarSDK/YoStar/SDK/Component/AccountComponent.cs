using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YoStar.SDK.Component
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public class AccountComponent : BaseComponent
	{
		// Token: 0x06000E77 RID: 3703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x5C9D910", Offset = "0x5C9C510", VA = "0x185C9D910")]
		public Task<LinkRet> Link(string type, [Optional] Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x5C9DA20", Offset = "0x5C9C620", VA = "0x185C9DA20")]
		public Task<UnLinkRet> Unlink([Optional] Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AccountComponent()
		{
		}
	}
}
