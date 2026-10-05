using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Net;
using YoStar.SDK.Net.Bean;
using YoStar.SDK.Service;

namespace YoStar.SDK.Component
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public class CoreComponent : BaseComponent
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public static CoreComponent Instance
		{
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x5C9F740", Offset = "0x5C9E340", VA = "0x185C9F740")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E81")]
		[Address(RVA = "0x5C9F580", Offset = "0x5C9E180", VA = "0x185C9F580")]
		public Task<ResponseResult<object>> UserDetail(LoginReq loginReq, bool returnOriginal = false)
		{
			return null;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x5C9F4A0", Offset = "0x5C9E0A0", VA = "0x185C9F4A0")]
		public Task<bool> UploadENLastReceive(bool Update)
		{
			return null;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x5C9F280", Offset = "0x5C9DE80", VA = "0x185C9F280")]
		private void OpenServiceUrl()
		{
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E84")]
		[Address(RVA = "0x5C9F160", Offset = "0x5C9DD60", VA = "0x185C9F160")]
		private void OpenServiceEmail()
		{
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E85")]
		[Address(RVA = "0x5C9E210", Offset = "0x5C9CE10", VA = "0x185C9E210")]
		private void OpenAiHelpService()
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E86")]
		[Address(RVA = "0x5C9E030", Offset = "0x5C9CC30", VA = "0x185C9E030")]
		public void CustomService()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000E87")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CoreComponent()
		{
		}

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x0")]
		private static CoreComponent instance;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x10")]
		protected CoreService coreService;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x18")]
		protected PayService payService;

		// Token: 0x04000B49 RID: 2889
		[Token(Token = "0x4000B49")]
		[FieldOffset(Offset = "0x20")]
		protected InitService initService;
	}
}
