using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	public class PayService : BaseService
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x5CE0A00", Offset = "0x5CDF600", VA = "0x185CE0A00")]
		public Task<ResponseResult<object>> CreateOrder(Dictionary<string, object> dataMap)
		{
			return null;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x5CE08F0", Offset = "0x5CDF4F0", VA = "0x185CE08F0")]
		public Task<ResponseResult<object>> ConfirmOrder(Dictionary<string, object> dataMap)
		{
			return null;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x5CE0D10", Offset = "0x5CDF910", VA = "0x185CE0D10")]
		public Task<ResponseResult<object>> OrderDetail(Dictionary<string, object> dataMap)
		{
			return null;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x5CE0C20", Offset = "0x5CDF820", VA = "0x185CE0C20")]
		public Task<ResponseResult<object>> GetCreditCardList()
		{
			return null;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x5CE0B10", Offset = "0x5CDF710", VA = "0x185CE0B10")]
		public Task<ResponseResult<object>> DeleteCreditCard(string cardSeq)
		{
			return null;
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001036")]
		[Address(RVA = "0x5CE0E20", Offset = "0x5CDFA20", VA = "0x185CE0E20")]
		public Task<ResponseResult<object>> SetCreditCard(string token)
		{
			return null;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001037")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public PayService()
		{
		}
	}
}
