using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;
using YoStar.SDK.Net.Bean;

namespace YoStar.SDK.Component
{
	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public class OtherComponent : BaseComponent
	{
		// Token: 0x06000EF6 RID: 3830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF6")]
		[Address(RVA = "0x5CA3560", Offset = "0x5CA2160", VA = "0x185CA3560")]
		public string QueryErrorMsg(int code)
		{
			return null;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EF7")]
		[Address(RVA = "0x5CA3740", Offset = "0x5CA2340", VA = "0x185CA3740")]
		public void QueryTextLegality(string sourceText)
		{
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF8")]
		[Address(RVA = "0x5CA40C0", Offset = "0x5CA2CC0", VA = "0x185CA40C0")]
		public Task<string> ShowAccountCenterNotLogin()
		{
			return null;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x5CA3470", Offset = "0x5CA2070", VA = "0x185CA3470")]
		public Task<string> GetUrlBy(Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x5CA4360", Offset = "0x5CA2F60", VA = "0x185CA4360")]
		public void ShowWebView(string webUrl, string title = "")
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x5CA4250", Offset = "0x5CA2E50", VA = "0x185CA4250")]
		public void ShowSurvey(string activityID, string gameUID, string notifyUrl, string extraData)
		{
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x5CA41A0", Offset = "0x5CA2DA0", VA = "0x185CA41A0")]
		public void ShowAgreement(string[] agreementTypes, string title = "", int display = 0)
		{
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x5CA3690", Offset = "0x5CA2290", VA = "0x185CA3690")]
		public void QuerySkuDetails(string[] skus)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x5CA4620", Offset = "0x5CA3220", VA = "0x185CA4620")]
		public Task<AgreementEntity> UserAgreement(string[] types, bool checkVersion = false, int display = 0)
		{
			return null;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x5CA4740", Offset = "0x5CA3340", VA = "0x185CA4740")]
		public void UserEventUpload(string strEventName, [Optional] Dictionary<string, string> parameter)
		{
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x5CA3390", Offset = "0x5CA1F90", VA = "0x185CA3390")]
		public Task<string> GetKmcURL()
		{
			return null;
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x5CA4530", Offset = "0x5CA3130", VA = "0x185CA4530")]
		public Task<ResponseResult<object>> UploadImage(byte[] imageData)
		{
			return null;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x5CA3E10", Offset = "0x5CA2A10", VA = "0x185CA3E10")]
		public void Share(ShareContent shareContent)
		{
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x5CA37E0", Offset = "0x5CA23E0", VA = "0x185CA37E0")]
		public void RoleInfoUpload(string serverId, string roleUid, string roleName, string[] tags, Dictionary<string, string> customField)
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x5CA31F0", Offset = "0x5CA1DF0", VA = "0x185CA31F0")]
		public void FetchDeviceTrackingID()
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x5CA32B0", Offset = "0x5CA1EB0", VA = "0x185CA32B0")]
		public Task<ResponseResult<object>> GenTranscode()
		{
			return null;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x5CA3AE0", Offset = "0x5CA26E0", VA = "0x185CA3AE0")]
		public Task<ResponseResult<object>> SendCode(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x5CA4900", Offset = "0x5CA3500", VA = "0x185CA4900")]
		public Task<ResponseResult<object>> VerifyCode(string email, string code)
		{
			return null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x5CA3BF0", Offset = "0x5CA27F0", VA = "0x185CA3BF0")]
		public Task<ResponseResult<object>> SetBirthday(string birth, bool confirmed = true)
		{
			return null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x5CA3D20", Offset = "0x5CA2920", VA = "0x185CA3D20")]
		public Task<ResponseResult<object>> SetFunction(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OtherComponent()
		{
		}
	}
}
