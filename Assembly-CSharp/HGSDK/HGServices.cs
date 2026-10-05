using System;
using Il2CppDummyDll;
using XLua;

namespace HGSDK
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class HGServices
	{
		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		public const string SDK_LOGIN_BY_PWD = "/user/login";

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		public const string SDK_AUTH = "/user/auth";

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		public const string SDK_PAY_CREATE_ORDER_APPSTORE = "/pay/createOrderAppstore";

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		public const string SDK_LEGACY_PAY_CONFIRM_ORDER_APPSTORE = "/pay/confirmOrderAppstore";

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		public const string SDK_PAY_CONFIRM_ORDER_APPSTORE = "/pay/confirmOrderAppstoreNew";

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		public const string SDK_SEND_SMS_CODE = "/user/sendSmsCode";

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		public const string SDK_USER_REGISTER = "/user/register";

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		public const string SDK_USER_IDENTITY_AUTH = "/user/authenticateUserIdentity";

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		public const string SDK_USER_CHECK_ID_CARD = "/user/checkIdCard";

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		public const string SDK_GUEST_CAPTCHA = "/captcha/v1/register";

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		public const string SDK_GUEST_LOGIN = "/user/v1/guestLogin";

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		public const string SDK_LOGIN_BY_SMS = "/user/loginBySmsCode";

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		public const string SDK_PING = "/online/v1/ping";

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		public const string SDK_LOGINOUT = "/online/v1/loginout";

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		public const string SDK_UPDATE_AGREEMENT = "/user/updateAgreement";

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		public const string SDK_CHANGE_PWD = "/user/changePassword";

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		public const string SDK_CHANGE_PHONE_CHECK = "/user/changePhoneCheck";

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		public const string SDK_CHANGE_PHONE = "/user/changePhone";

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		public const string SDK_NEED_CLOUD_AUTH = "/user/info/v1/need_cloud_auth";

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		public const string SDK_CLOUD_AUTH = "/user/info/v1/cloud_auth";

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		public const string SDK_VERIFY_CLOUD_AUTH = "/user/info/v1/verify_cloud_auth_result";

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		public const string SDK_UNBIND_GRANT = "/user/oauth2/v1/unbind_grant";

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		public const string SDK_SEND_PHONE_CODE_V2 = "/user/info/v1/send_phone_code";

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		public const string SDK_GRANT_INFO = "/user/oauth2/v1/grant";
	}
}
