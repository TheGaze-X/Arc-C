using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;
using YoStar.SDK.Net.Bean;

namespace YoStar.SDK.Service
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class CoreService : BaseService
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FEB")]
		[Address(RVA = "0x5CBB9F0", Offset = "0x5CBA5F0", VA = "0x185CBB9F0")]
		private void UploadEvent(LoginReq loginReq, string uid, string yostarID)
		{
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x5CBBCB0", Offset = "0x5CBA8B0", VA = "0x185CBBCB0")]
		public Task<ResponseResult<object>> UserDetail(LoginReq loginReq, bool returnOriginal = false)
		{
			return null;
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x5CBADD0", Offset = "0x5CB99D0", VA = "0x185CBADD0")]
		private ResponseResult<object> DealUserInfo(ResponseResult<object> response, LoginReq loginReq, string deviceIDInHeader)
		{
			return null;
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x5CB8CB0", Offset = "0x5CB78B0", VA = "0x185CB8CB0")]
		private ResponseResult<object> DealOkInfo(ResponseResult<object> response, LoginReq loginReq, string deviceIDInHeader)
		{
			return null;
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x5CBB2B0", Offset = "0x5CB9EB0", VA = "0x185CBB2B0")]
		private void LoginRetention()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x5CBB8F0", Offset = "0x5CBA4F0", VA = "0x185CBB8F0")]
		public Task<ResponseResult<object>> UploadENLastReceive(bool Update)
		{
			return null;
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CoreService()
		{
		}
	}
}
