using System;
using Il2CppDummyDll;
using XLua;

namespace XDSDK
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StringRes
	{
		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		public const string SDK_INTERNAL_ERROR = "SDK内部错误，请联系客服";

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		public const string ALERT_LOGIN_ERROR_ACCOUNT_OR_PWD = "用户名或密码错误，请重新登录";

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		public const string ALERT_LOGIN_IOS_NOT_ACTIVATED = "此账号未申请IOS平台测试资格，如有疑问请联系客服";

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		public const string ALERT_LOGIN_ACCOUNT_NOT_ACTIVATED = "此账号尚未激活，如有疑问请联系客服";

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		public const string ALERT_LOGIN_PHONE_NUMBER_NOT_EXIST = "此手机账号尚不存在，请先注册";

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		public const string ALERT_USERNAME_OR_PASSWORD_INVALID = "无效的用户名或密码，请重新输入";

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		public const string ALERT_LOGIN_TOKEN_TIMEOUT = "记忆已经模糊，请重新输入登录信息";

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		public const string ERROR_NETWORK_LOGIN = "网络异常，登录失败，请稍后重试。\n错误号{0}";

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		public const string ERROR_LOGIN_SMS_CODE_USER_UNREGISTER = "该用户尚不存在，请先注册";

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		public const string ERROR_LOGIN_SMS_CODE_INVALID = "验证码错误或已失效，请重新输入";

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		public const string ERROR_LOGIN_UNKNOWN_ERROR = "登录时遭遇未知错误，请稍后重试。\n错误号{0}";

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		public const string ALERT_INVALID_PHONE_NUMBER = "手机号格式错误，请重新输入";

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		public const string ERROR_SEND_CAPTCHA_NETWORK = "网络异常，验证码发送失败，请稍后重试。\n错误号{0}";

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		public const string ERROR_SEND_CAPTCHA_TOO_FAST = "请求验证码过于频繁，请稍候";

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		public const string ERROR_CAPTCHA_MSG_CENTER_FAILED = "验证码平台正忙，发送失败，请稍后重试";

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		public const string ERROR_CAPTCHA_UNKNOWN_ERROR = "发送验证码时遭遇未知错误，请稍后重试";

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		public const string ALERT_IDENTITY_AUTH_SUC = "实名认证已完成";

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		public const string ALERT_IDENTIFY_MINOR_USER = "实名认证成功！您目前认证的身份信息为未成年人，请您在监护人监督下进行游戏。";

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		public const string ERROR_IDENTITY_AUTH_INVALID_CARD = "证件信息填写有误，请检查后重试";

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		public const string ERROR_IDENTITY_AUTH_NETWORK = "网络异常，实名认证失败，请稍后重试。\n错误号{0}";

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		public const string ERROR_REGISTER_ALREADY_EXIST_USER = "该用户已存在，请确认注册信息";

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		public const string ERROR_REGISTER_NETWORK = "网络异常，注册失败，请稍后重试。\n错误号{0}";

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		public const string ERROR_REGISTER_SMS_CODE_INVALID = "验证码错误或已失效，请重新输入";

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		public const string ERROR_REGISTER_SUC_GUEST_UPGRADE_FAIL = "注册成功，但游客账号绑定失败。\n请点击<color=#22bbff>已有账号绑定</color>以重试";

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		public const string ERROR_REGISTER_ALREADY_EXIST_BEFORE_PAY = "该用户已存在，请登录后进行绑定";

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		public const string ERROR_REGISTER_SUC_GUEST_UPGRADE_FAIL_BEFORE_PAY = "注册成功，但游客账号绑定失败。\n请重新登录后进行绑定";

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		public const string ERROR_GUEST_UPGRADE_NOT_EXIST = "该游客账号信息为空，暂时无法进行绑定操作，请创建角色后再次尝试绑定";

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		public const string CONFIRM_ACCOUNT_LOGIN_CLEAR_GUEST = "您当前正处于游客登录状态，继续登录新账号将会造成<color=#F40002>当前游客{0}的账户信息被永久删除</color>\n是否确认继续？";

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		public const string TOAST_GUEST_SHOULD_USE_UPGRADE = "请返回至<color=#22bbff>升级账号</color>\n进行已有账号绑定";

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		public const string ERROR_GUEST_LOGIN_NETWORK = "网络异常，游客登录失败。\n错误号{0}";

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		public const string FORMAT_SEND_CAPTCHA = "发送验证码";

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		public const string FORMAT_SEND_CAPTCHA_CD = "{0,2}秒后再次发送";

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		public const string TEXT_LOGIN = "登录";

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		public const string TEXT_BIND_AND_LOGIN = "绑定并登录";

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		public const string USER_TITLE_PLAYER = "玩家";

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		public const string USER_TITLE_GUEST = "游客";

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		public const string ERROR_CREATE_ORDER_APPSTORE = "创建订单服务失败。错误号:{0}";

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		public const string ERROR_PAY_NOT_COMPLETE_APPSTORE = "支付未完成";

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		public const string ERROR_PAY_CONFIRM_FAILED_APPSTORE = "获取支付结果失败，请重启游戏后以实际结果为准，如有问题请联系客服。\n错误号:{0}";

		// Token: 0x0400039D RID: 925
		[Token(Token = "0x400039D")]
		public const string RECEIPT_MAKEUP_NETWORK_ERROR = "提交未完成订单时发生网络异常，请重新登录\n错误号{0}";

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		public const string RECEIPT_MAKEUP_NETWORK_TIMEOUT = "提交未完成订单时发生网络异常，请重新登录";

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		public const string DEBUG_PAY_CONFIRM = "在测试模式尝试购买<color=#22bbff>{0}</color>";

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		public const string TEXT_MINOR_POLICYJUDGE_POSITIVE = "继续认证";

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		public const string TEXT_MINOR_POLICYJUDGE_NEGATIVE = "取消";

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		public const string ALERT_GUEST_CAPTCHA_SERVICE_FAILED = "游客登录验证服务失败，请重试\n错误号:{0}";

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		public const string ERROR_XD_ORDER_CENTER_BROKEN = "游戏订单系统发生异常，请尝试重新启动游戏\n如有问题请联系客服";

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		public const string ERROR_XD_STORE_CONFIG_ERROR = "支付系统初始化失败，请重启游戏后重试";

		// Token: 0x040003A5 RID: 933
		[Token(Token = "0x40003A5")]
		public const string ERROR_XD_STORE_SHOULD_LOGIN = "支付时获取用户信息失败，请重新登录后重试";

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		public const string ERROR_XD_STORE_HAS_PENDING_ORDER = "存在其他用户(UID {0})的未完成订单，请重新登录该账户以完成交易\n如有问题请联系客服";

		// Token: 0x040003A7 RID: 935
		[Token(Token = "0x40003A7")]
		public const string ERROR_XD_STORE_ITUNES_CANT_PAY = "当前Apple用户无法进行支付，请确认Apple登录状态、网络配置以及支付设置后重试";

		// Token: 0x040003A8 RID: 936
		[Token(Token = "0x40003A8")]
		public const string ERROR_XD_STORE_IS_PAYING = "存在正在进行中的交易\n如无响应，请重启游戏后重试";

		// Token: 0x040003A9 RID: 937
		[Token(Token = "0x40003A9")]
		public const string ERROR_XD_STORE_INVALID_PRODUCT = "未能获取到当前付费商品信息\n请重新登录后重试";

		// Token: 0x040003AA RID: 938
		[Token(Token = "0x40003AA")]
		public const string ERROR_XD_STORE_TRANSACTION_IO = "缓存订单信息失败，可能造成未知风险\n请暂时不要进行支付，并重启游戏后重试";

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		public const string ERROR_XD_STORE_HAS_UNFINISHED_ORDERS = "存在未完成的交易，请重新启动游戏后重试\n如仍出现此提示，请联系客服";

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		public const string ERROR_XD_STORE_RECEIPT_UPLOAD_ERROR = "交易信息提交失败，请重新登录后重试";

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		public const string ERROR_XD_STORE_RECONFIRMED_PENDING_ORDERS = "检测到未完成交易，尝试进行兑付\n请重新登录游戏";

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		public const string ERROR_XD_STORE_CONFIRM_STORE_ORDER_FAILED = "尝试兑付未完成交易时发生异常，请重新登录\n如始终出现此问题请联系客服";

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		public const string ERROR_XD_STORE_PURCHASE_PURCHASING = "当前商品存在未完成交易，请检查用户iTunes交易记录，确认交易结果";
	}
}
