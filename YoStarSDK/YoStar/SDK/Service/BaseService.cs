using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002B8 RID: 696
	[Token(Token = "0x20002B8")]
	public class BaseService
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BaseService()
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x5CB8810", Offset = "0x5CB7410", VA = "0x185CB8810")]
		public Request CreateRequest()
		{
			return null;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x5CB8700", Offset = "0x5CB7300", VA = "0x185CB8700")]
		protected Task<Response<object>> BaseRequest(Request request)
		{
			return null;
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x5CB88E0", Offset = "0x5CB74E0", VA = "0x185CB88E0")]
		private bool DealCommonBusiness(Response<object> response)
		{
			return default(bool);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x5CB8B90", Offset = "0x5CB7790", VA = "0x185CB8B90")]
		private void Logout(string authInfo, bool deleteHistory = true)
		{
		}

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x10")]
		protected string sdkHostUrl;
	}
}
