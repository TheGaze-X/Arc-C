using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	public class InitService : BaseService
	{
		// Token: 0x06000FFB RID: 4091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x5CD29E0", Offset = "0x5CD15E0", VA = "0x185CD29E0")]
		public Task<ResponseResult<object>> Init()
		{
			return null;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x5CD2830", Offset = "0x5CD1430", VA = "0x185CD2830")]
		private Task<ResponseResult<object>> AllErrorMsg()
		{
			return null;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x5CD2920", Offset = "0x5CD1520", VA = "0x185CD2920")]
		private void ErrorCode(string codeVersion)
		{
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public InitService()
		{
		}
	}
}
