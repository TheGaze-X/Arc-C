using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YoStar.SDK.Net
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	public class ResponseResult<T>
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x00003824 File Offset: 0x00001A24
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000D8")]
		public int code
		{
			[Token(Token = "0x6000BC5")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000D9")]
		public string msg
		{
			[Token(Token = "0x6000BC7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000DA")]
		public T data
		{
			[Token(Token = "0x6000BC9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BCA")]
		public ResponseResult(int code, string msg, T data)
		{
		}
	}
}
