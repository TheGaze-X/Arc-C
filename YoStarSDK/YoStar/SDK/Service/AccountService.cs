using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	public class AccountService : BaseService
	{
		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x5CB8340", Offset = "0x5CB6F40", VA = "0x185CB8340")]
		public Task<ResponseResult<object>> Link(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x5CB8590", Offset = "0x5CB7190", VA = "0x185CB8590")]
		public Task<ResponseResult<object>> Unlink(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x5CB8450", Offset = "0x5CB7050", VA = "0x185CB8450")]
		private Task<ResponseResult<object>> UnlinkAndLink(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AccountService()
		{
		}
	}
}
