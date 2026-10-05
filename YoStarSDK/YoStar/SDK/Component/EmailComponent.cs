using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YoStar.SDK.Component
{
	// Token: 0x02000242 RID: 578
	[Token(Token = "0x2000242")]
	public class EmailComponent : BaseComponent
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x5C9FD50", Offset = "0x5C9E950", VA = "0x185C9FD50")]
		public static Task<LinkRet> Link(string type, string email, string code)
		{
			return null;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8E")]
		[Address(RVA = "0x5C9FE90", Offset = "0x5C9EA90", VA = "0x185C9FE90")]
		public static Task<UnLinkRet> Unlink(string type, [Optional] Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8F")]
		[Address(RVA = "0x5C9FAD0", Offset = "0x5C9E6D0", VA = "0x185C9FAD0")]
		private static Dictionary<string, object> DealParamData(string type, [Optional] Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E90")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EmailComponent()
		{
		}
	}
}
