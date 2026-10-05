using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YoStar.SDK.Net
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public class Response<T>
	{
		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0000383C File Offset: 0x00001A3C
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DB")]
		public long HttpCode
		{
			[Token(Token = "0x6000BCC")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000BCB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00003854 File Offset: 0x00001A54
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DC")]
		private bool Timeout
		{
			[Token(Token = "0x6000BCE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BCD")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DD")]
		public string AuthInfo
		{
			[Token(Token = "0x6000BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DE")]
		public ResponseResult<T> responseResult
		{
			[Token(Token = "0x6000BD2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DF")]
		public Request Request
		{
			[Token(Token = "0x6000BD4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BD3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BD5")]
		public Response(long httpCode, ResponseResult<T> responseResult, [Optional] Request request, bool timeout = false, [Optional] string authInfo)
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x6000BD6")]
		public bool ShouldRetryRequest()
		{
			return default(bool);
		}
	}
}
