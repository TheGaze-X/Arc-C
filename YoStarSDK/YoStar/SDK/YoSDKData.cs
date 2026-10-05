using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YoStar.SDK.LitJson;

namespace YoStar.SDK
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class YoSDKData
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public static YoSDKData Instance
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x5BFD300", Offset = "0x5BFBF00", VA = "0x185BFD300")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5BFD1F0", Offset = "0x5BFBDF0", VA = "0x185BFD1F0")]
		private YoSDKData()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5BFA290", Offset = "0x5BF8E90", VA = "0x185BFA290")]
		public bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5BFC7B0", Offset = "0x5BFB3B0", VA = "0x185BFC7B0")]
		public string SupportAreaServerByConfig()
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5BFA140", Offset = "0x5BF8D40", VA = "0x185BFA140")]
		private string GetLanguageByService(string service)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x5BF9D60", Offset = "0x5BF8960", VA = "0x185BF9D60")]
		private static string CapitalizeFirstLetter(string input)
		{
			return null;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5BFD400", Offset = "0x5BFC000", VA = "0x185BFD400")]
		private Regions.Region parseRegions(JsonData regions, string key)
		{
			return null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5BFA900", Offset = "0x5BF9500", VA = "0x185BFA900")]
		private Ali ParseAli(JsonData jsonData, string key)
		{
			return null;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5BFC3F0", Offset = "0x5BFAFF0", VA = "0x185BFC3F0")]
		private Plist.Tip ParsePlist(JsonData jsonData)
		{
			return null;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5BFC150", Offset = "0x5BFAD50", VA = "0x185BFC150")]
		private Regions.Region.Channel ParseChannel(JsonData jsonData, string key)
		{
			return null;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5BFD260", Offset = "0x5BFBE60", VA = "0x185BFD260")]
		private string getStringByKey(JsonData jsonData, string key)
		{
			return null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public SDKConfigJsonData Config
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002234 File Offset: 0x00000434
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000011")]
		public bool IsShowLog
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000012")]
		public string UserID
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5BF9E30", Offset = "0x5BF8A30", VA = "0x185BF9E30")]
		public Regions.Region GetCurrentRegion()
		{
			return null;
		}

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x0")]
		private static YoSDKData m_instance;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		private SDKConfigJsonData m_config;
	}
}
