using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net.Bean;

namespace YoStar.SDK.Service
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	public class LoginService : BaseService
	{
		// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x5CDF610", Offset = "0x5CDE210", VA = "0x185CDF610")]
		public Task<LoginEntity> CheckAccount(LoginReq loginReq)
		{
			return null;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x5CDF720", Offset = "0x5CDE320", VA = "0x185CDF720")]
		public Task<LoginEntity> Login(LoginReq loginReq)
		{
			return null;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public LoginService()
		{
		}
	}
}
