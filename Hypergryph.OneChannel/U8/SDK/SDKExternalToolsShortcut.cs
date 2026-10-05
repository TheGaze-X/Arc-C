using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	public abstract class SDKExternalToolsShortcut : SDKExternalTools
	{
		// Token: 0x060000FB RID: 251 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4A0DFD0", Offset = "0x4A0CBD0", VA = "0x184A0DFD0", Slot = "13")]
		protected sealed override SDKPromise<U8LoginResult> SendSDKAuthRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4A0E470", Offset = "0x4A0D070", VA = "0x184A0E470", Slot = "15")]
		protected sealed override SDKPromise<object> SendSDKVerifyAccountRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4A0DD80", Offset = "0x4A0C980", VA = "0x184A0DD80", Slot = "17")]
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4A0DB30", Offset = "0x4A0C730", VA = "0x184A0DB30", Slot = "18")]
		protected sealed override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr)
		{
			return null;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4A0E6C0", Offset = "0x4A0D2C0", VA = "0x184A0E6C0", Slot = "19")]
		protected override SDKPromise<object> SendUpgradeGuestRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4A0E220", Offset = "0x4A0CE20", VA = "0x184A0E220", Slot = "14")]
		protected sealed override SDKPromise<U8CaptchaResult> SendSDKGetCaptchaRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4A0D9C0", Offset = "0x4A0C5C0", VA = "0x184A0D9C0", Slot = "16")]
		protected sealed override SDKPromise<U8ConfirmOrderResult> SendConfirmOrderRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4A0E7A0", Offset = "0x4A0D3A0", VA = "0x184A0E7A0")]
		private IEnumerator _ConfirmOrderCoroutine(SDKPromise<U8ConfirmOrderResult> promise, string paramStr)
		{
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4A0D700", Offset = "0x4A0C300", VA = "0x184A0D700", Slot = "12")]
		public override Dictionary<string, string> GetDeviceIDs()
		{
			return null;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4A0D810", Offset = "0x4A0C410", VA = "0x184A0D810")]
		public static string GetU8DeviceID()
		{
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x4A0D8E0", Offset = "0x4A0C4E0", VA = "0x184A0D8E0")]
		public static void InjectRequestHeaders(ref Dictionary<string, string> headers, SDKExternalToolsShortcut.RequestHeaderInjectOptions policy)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x4A0E720", Offset = "0x4A0D320", VA = "0x184A0E720")]
		private string _AuthUrl()
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x4A0E760", Offset = "0x4A0D360", VA = "0x184A0E760")]
		private string _CaptchaUrl()
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4A0E8D0", Offset = "0x4A0D4D0", VA = "0x184A0E8D0")]
		private string _GetProductListUrl()
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4A0E910", Offset = "0x4A0D510", VA = "0x184A0E910")]
		private string _GetProductListV1Url()
		{
			return null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x4A0E890", Offset = "0x4A0D490", VA = "0x184A0E890")]
		private string _CreateOrderUrl()
		{
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x4A0E850", Offset = "0x4A0D450", VA = "0x184A0E850")]
		private string _ConfirmOrderUrl()
		{
			return null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4A0E950", Offset = "0x4A0D550", VA = "0x184A0E950")]
		private string _UpdateGuestUserUrl()
		{
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x4A0E990", Offset = "0x4A0D590", VA = "0x184A0E990")]
		private string _VerifyAccountUrl()
		{
			return null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x4A0E9D0", Offset = "0x4A0D5D0", VA = "0x184A0E9D0")]
		protected SDKExternalToolsShortcut()
		{
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		protected struct U8ProductListData : SDKExternalTools.IFromJSON
		{
			// Token: 0x0600010F RID: 271 RVA: 0x00002444 File Offset: 0x00000644
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x4A22D00", Offset = "0x4A21900", VA = "0x184A22D00", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x06000110 RID: 272 RVA: 0x0000245C File Offset: 0x0000065C
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x4A23010", Offset = "0x4A21C10", VA = "0x184A23010")]
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict)
			{
				return default(bool);
			}

			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			[FieldOffset(Offset = "0x0")]
			public List<U8ProductInfo> productList;
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		protected struct U8ProductListDataV2 : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00002474 File Offset: 0x00000674
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x4A227D0", Offset = "0x4A213D0", VA = "0x184A227D0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x0000248C File Offset: 0x0000068C
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x4A22B10", Offset = "0x4A21710", VA = "0x184A22B10")]
			private static bool _BuildProductInfo(U8ProductInfo outInfo, Dictionary<string, object> dict)
			{
				return default(bool);
			}

			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			[FieldOffset(Offset = "0x0")]
			public List<U8ProductInfo> productList;
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		protected struct U8UpdateGuestResponse : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000113 RID: 275 RVA: 0x000024A4 File Offset: 0x000006A4
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x4A2A3D0", Offset = "0x4A28FD0", VA = "0x184A2A3D0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			[FieldOffset(Offset = "0x0")]
			public int result;
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		protected struct U8VerifyAccountResponse : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000114 RID: 276 RVA: 0x000024BC File Offset: 0x000006BC
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x4A2A490", Offset = "0x4A29090", VA = "0x184A2A490", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x0")]
			public string uid;
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		protected struct U8GetCaptchaResponse : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000115 RID: 277 RVA: 0x000024D4 File Offset: 0x000006D4
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x4A21910", Offset = "0x4A20510", VA = "0x184A21910", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x0")]
			public int result;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, object> data;
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		protected struct U8AuthResponse : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000116 RID: 278 RVA: 0x000024EC File Offset: 0x000006EC
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x4A215C0", Offset = "0x4A201C0", VA = "0x184A215C0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00002504 File Offset: 0x00000704
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x4A21870", Offset = "0x4A20470", VA = "0x184A21870")]
			public U8LoginResult ToLoginResult()
			{
				return default(U8LoginResult);
			}

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x0")]
			public int result;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x8")]
			public string uid;

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x10")]
			public string channelUid;

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x18")]
			public string token;

			// Token: 0x04000103 RID: 259
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x20")]
			public string extension;

			// Token: 0x04000104 RID: 260
			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x28")]
			public bool isGuest;

			// Token: 0x04000105 RID: 261
			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x30")]
			public string error;

			// Token: 0x04000106 RID: 262
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x38")]
			public string captchaTips;

			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x40")]
			public bool isNew;

			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<string, object> captcha;
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		protected struct U8PayConfirmResponse : SDKExternalTools.IFromJSON
		{
			// Token: 0x06000118 RID: 280 RVA: 0x0000251C File Offset: 0x0000071C
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x4A21F30", Offset = "0x4A20B30", VA = "0x184A21F30", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x0")]
			public int payState;
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		public enum RequestConnPolicy
		{
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			DEFAULT,
			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			CLOSE_EACH_CON
		}

		// Token: 0x02000037 RID: 55
		[Token(Token = "0x2000037")]
		public struct RequestHeaderInjectOptions
		{
			// Token: 0x0400010D RID: 269
			[Token(Token = "0x400010D")]
			[FieldOffset(Offset = "0x0")]
			public SDKExternalToolsShortcut.RequestConnPolicy policy;
		}
	}
}
