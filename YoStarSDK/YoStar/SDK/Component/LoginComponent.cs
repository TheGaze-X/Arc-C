using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;
using YoStar.SDK.Net.Bean;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x0200024E RID: 590
	[Token(Token = "0x200024E")]
	public class LoginComponent : BaseComponent
	{
		// Token: 0x06000EAB RID: 3755 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x5CA22D0", Offset = "0x5CA0ED0", VA = "0x185CA22D0")]
		public void Login()
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x5CA0C80", Offset = "0x5C9F880", VA = "0x185CA0C80")]
		public void LoginApple()
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x5CA13E0", Offset = "0x5C9FFE0", VA = "0x185CA13E0")]
		public void LoginGoogle()
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x5CA1320", Offset = "0x5C9FF20", VA = "0x185CA1320")]
		public void LoginFacebook()
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x5CA28A0", Offset = "0x5CA14A0", VA = "0x185CA28A0")]
		public void ThirdAuth(LoginPlatform loginPlatform, Dictionary<string, object> ret)
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x5CA2140", Offset = "0x5CA0D40", VA = "0x185CA2140")]
		public void LoginYoStar(string email, string code)
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x5CA20E0", Offset = "0x5CA0CE0", VA = "0x185CA20E0")]
		public void LoginTranscode(string uid, string transcode)
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x5CA1740", Offset = "0x5CA0340", VA = "0x185CA1740")]
		public void LoginResult(ResponseResult<object> responseResult, LoginPlatform loginPlatform)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x5CA0B80", Offset = "0x5C9F780", VA = "0x185CA0B80")]
		private void GeeTest(LoginPlatform platform, CallbackGlobal<Dictionary<string, object>> callback)
		{
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x5CA2A30", Offset = "0x5CA1630", VA = "0x185CA2A30")]
		public void TokenLogin(LoginReq loginReq, [Optional] Dictionary<string, object> geeTestParams)
		{
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x5CA2190", Offset = "0x5CA0D90", VA = "0x185CA2190")]
		private void Login(LoginPlatform loginPlatform, bool geeTest = false, [Optional] Dictionary<string, object> geeTestParams, string transcode = "", string transUID = "", [Optional] Dictionary<string, object> thirdAuthInfo, [Optional] Dictionary<string, object> requestHeader)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x5CA0950", Offset = "0x5C9F550", VA = "0x185CA0950")]
		private Dictionary<string, object> DealLoginParams(string openID, string token, string userName, string type, [Optional] Dictionary<string, object> geeTestMap, string secret = "")
		{
			return null;
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x5CA2330", Offset = "0x5CA0F30", VA = "0x185CA2330")]
		private void RebornLogic(ResponseResult<object> responseResult)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x5CA1220", Offset = "0x5C9FE20", VA = "0x185CA1220")]
		public Task LoginEnd(LoginReq loginReq)
		{
			return null;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x5CA1540", Offset = "0x5CA0140", VA = "0x185CA1540")]
		private void LoginMiddle(LoginPlatform loginPlatform, Dictionary<string, object> paramMap)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x5CA30D0", Offset = "0x5CA1CD0", VA = "0x185CA30D0")]
		private Task UserLoginSuccess(LoginReq loginReq, LoginEntity loginEntity)
		{
			return null;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x5CA2C70", Offset = "0x5CA1870", VA = "0x185CA2C70")]
		private void UserLoginErrorCode900(LoginReq loginReq)
		{
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x5CA2EB0", Offset = "0x5CA1AB0", VA = "0x185CA2EB0")]
		private Task UserLoginErrorCode902And920(LoginReq loginRequest, int resultCode)
		{
			return null;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x5CA2FC0", Offset = "0x5CA1BC0", VA = "0x185CA2FC0")]
		private void UserLoginErrorCodeGeeTestFail(LoginReq loginReq, int resultCode, LoginRet ret)
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x5CA3070", Offset = "0x5CA1C70", VA = "0x185CA3070")]
		private void UserLoginOtherErrorCode(LoginRet loginRet)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x5CA14A0", Offset = "0x5CA00A0", VA = "0x185CA14A0")]
		public void LoginGuest()
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x5CA0D40", Offset = "0x5C9F940", VA = "0x185CA0D40")]
		private Task LoginDeal(int checkAccount, string deviceID, [Optional] Dictionary<string, object> geeTestParams)
		{
			return null;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x5CA0540", Offset = "0x5C9F140", VA = "0x185CA0540")]
		private Task CheckAccountInDeviceLogin(LoginReq loginRequest)
		{
			return null;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x5CA0640", Offset = "0x5C9F240", VA = "0x185CA0640")]
		private LoginReq CreateRequestForDeviceLogin(Dictionary<string, object> paramMap)
		{
			return null;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x5CA0760", Offset = "0x5C9F360", VA = "0x185CA0760")]
		private Dictionary<string, object> DealDeviceParam(string deviceID, int checkAccount = 0, [Optional] Dictionary<string, object> geeTestParams)
		{
			return null;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x5CA1690", Offset = "0x5CA0290", VA = "0x185CA1690")]
		private Task LoginNotTokenMiddle(LoginReq loginReq)
		{
			return null;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x5CA0E70", Offset = "0x5C9FA70", VA = "0x185CA0E70")]
		private void LoginEmailVer(string email, string code, bool geeTest = false, [Optional] Dictionary<string, object> geeTestParams)
		{
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x5CA0F90", Offset = "0x5C9FB90", VA = "0x185CA0F90")]
		private void LoginEmail(ResponseResult<object> responseResult, [Optional] Dictionary<string, object> geeTestMap)
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000EC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginComponent()
		{
		}
	}
}
