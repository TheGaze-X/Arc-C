using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002D9 RID: 729
	[Token(Token = "0x20002D9")]
	public class UserService : BaseService
	{
		// Token: 0x06001044 RID: 4164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001044")]
		[Address(RVA = "0x5CE9CA0", Offset = "0x5CE88A0", VA = "0x185CE9CA0")]
		public Task<ResponseResult<object>> GetDevicesList()
		{
			return null;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001045")]
		[Address(RVA = "0x5CE9B60", Offset = "0x5CE8760", VA = "0x185CE9B60")]
		public Task<ResponseResult<object>> DeleteDevice(string id, string deviceID)
		{
			return null;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001046")]
		[Address(RVA = "0x5CE9A70", Offset = "0x5CE8670", VA = "0x185CE9A70")]
		public Task<ResponseResult<object>> DeleteAccount()
		{
			return null;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x5CE9D90", Offset = "0x5CE8990", VA = "0x185CE9D90")]
		public Task<ResponseResult<object>> RebornAccount(Dictionary<string, object> header)
		{
			return null;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x5CE9EA0", Offset = "0x5CE8AA0", VA = "0x185CE9EA0")]
		public Task<ResponseResult<object>> TokenMigration(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UserService()
		{
		}
	}
}
