using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using YoStar.SDK.Bean;
using YoStar.SDK.Net;

namespace YoStar.SDK.Component
{
	// Token: 0x02000283 RID: 643
	[Token(Token = "0x2000283")]
	public class UserComponent : BaseComponent
	{
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		public static UserComponent Instance
		{
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x5CCEC50", Offset = "0x5CCD850", VA = "0x185CCEC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x5CCE900", Offset = "0x5CCD500", VA = "0x185CCE900")]
		public Task<List<ManageDevicesItem>> GetDevicesList()
		{
			return null;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x5CCE7E0", Offset = "0x5CCD3E0", VA = "0x185CCE7E0")]
		public Task<bool> DeleteDevice(string id, string deviceID)
		{
			return null;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x5CCE750", Offset = "0x5CCD350", VA = "0x185CCE750")]
		public void DeleteAccount()
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x5CCE9E0", Offset = "0x5CCD5E0", VA = "0x185CCE9E0")]
		public Task<ResponseResult<object>> RebornAccount(Dictionary<string, object> header)
		{
			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x5CCEAD0", Offset = "0x5CCD6D0", VA = "0x185CCEAD0")]
		public Task<Dictionary<string, object>> TokenMigration(Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public UserComponent()
		{
		}

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		private const string FILE_NAME_USER = "user_info";

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		private const string USER_KEY = "userinfo";

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x0")]
		private static UserComponent instance;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object lockObject;
	}
}
