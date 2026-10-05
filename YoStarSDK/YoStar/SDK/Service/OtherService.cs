using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;

namespace YoStar.SDK.Service
{
	// Token: 0x020002C5 RID: 709
	[Token(Token = "0x20002C5")]
	public class OtherService : BaseService
	{
		// Token: 0x0600100C RID: 4108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x5CDFF90", Offset = "0x5CDEB90", VA = "0x185CDFF90")]
		public Task<ResponseResult<object>> QueryTextLegality(string sourceText)
		{
			return null;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100D")]
		[Address(RVA = "0x5CE02F0", Offset = "0x5CDEEF0", VA = "0x185CE02F0")]
		public Task<ResponseResult<object>> ShowAccountCenterNotLogin()
		{
			return null;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100E")]
		[Address(RVA = "0x5CDFD90", Offset = "0x5CDE990", VA = "0x185CDFD90")]
		public Task<ResponseResult<object>> GetUrlBy(Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600100F")]
		[Address(RVA = "0x5CE03E0", Offset = "0x5CDEFE0", VA = "0x185CE03E0")]
		public Task<ResponseResult<object>> ShowSurvey(string activityID, string gameUID, string notifyUrl = "", string extraData = "")
		{
			return null;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001010")]
		[Address(RVA = "0x5CDFEA0", Offset = "0x5CDEAA0", VA = "0x185CDFEA0")]
		public Task<ResponseResult<object>> QuerySkuDetails()
		{
			return null;
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001011")]
		[Address(RVA = "0x5CE0660", Offset = "0x5CDF260", VA = "0x185CE0660")]
		public Task<ResponseResult<object>> UserAgreementAsync(string[] types, bool checkVersion = false, int display = 0)
		{
			return null;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001012")]
		[Address(RVA = "0x5CDFCA0", Offset = "0x5CDE8A0", VA = "0x185CDFCA0")]
		public Task<ResponseResult<object>> GetKmcURL()
		{
			return null;
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001013")]
		[Address(RVA = "0x5CE0550", Offset = "0x5CDF150", VA = "0x185CE0550")]
		public Task<ResponseResult<object>> UploadImage(byte[] imageData)
		{
			return null;
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x5CDFBB0", Offset = "0x5CDE7B0", VA = "0x185CDFBB0")]
		public Task<ResponseResult<object>> GenTranscode()
		{
			return null;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001015")]
		[Address(RVA = "0x5CE00A0", Offset = "0x5CDECA0", VA = "0x185CE00A0")]
		public Task<ResponseResult<object>> SendCode(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001016")]
		[Address(RVA = "0x5CE07B0", Offset = "0x5CDF3B0", VA = "0x185CE07B0")]
		public Task<ResponseResult<object>> VerifyCode(string email, string code)
		{
			return null;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001017")]
		[Address(RVA = "0x5CE01E0", Offset = "0x5CDEDE0", VA = "0x185CE01E0")]
		public Task<ResponseResult<object>> SetFunction(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001018")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public OtherService()
		{
		}
	}
}
