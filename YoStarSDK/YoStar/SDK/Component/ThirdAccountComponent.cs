using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YoStar.SDK.Util;

namespace YoStar.SDK.Component
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public class ThirdAccountComponent : BaseComponent
	{
		// Token: 0x06000F50 RID: 3920 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x5CC1BD0", Offset = "0x5CC07D0", VA = "0x185CC1BD0")]
		public static void Link(string type, CallbackGlobal<LinkRet> callback)
		{
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x5CC1CB0", Offset = "0x5CC08B0", VA = "0x185CC1CB0")]
		public static void Unlink(string type, CallbackGlobal<UnLinkRet> callback)
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x5CC15E0", Offset = "0x5CC01E0", VA = "0x185CC15E0")]
		private static void Auth(string type, CallbackGlobal<Dictionary<string, object>> callback)
		{
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x5CC1870", Offset = "0x5CC0470", VA = "0x185CC1870")]
		private static Dictionary<string, object> DealParam(string type, [Optional] Dictionary<string, object> thirdAuthInfo)
		{
			return null;
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x5CC1710", Offset = "0x5CC0310", VA = "0x185CC1710")]
		private static Dictionary<string, object> DealLoginParams(string openID = "", string token = "", string userName = "", string type = "", string secret = "")
		{
			return null;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ThirdAccountComponent()
		{
		}
	}
}
