using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YoStar.SDK.Net
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	public class RetryManage
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000037C4 File Offset: 0x000019C4
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000D5")]
		public int CurrentRetryCount
		{
			[Token(Token = "0x6000BB9")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BBA")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000037DC File Offset: 0x000019DC
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000D6")]
		private int RetryMaxCount
		{
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000037F4 File Offset: 0x000019F4
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000D7")]
		public bool TimeOutRetryEnable
		{
			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private RetryManage()
		{
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x5C8BEE0", Offset = "0x5C8AAE0", VA = "0x185C8BEE0")]
		public RetryManage(bool timeOutRetryEnable, int retryMaxCount)
		{
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x2873F20", Offset = "0x2872B20", VA = "0x182873F20")]
		public void requestCountUp()
		{
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x1AF4C90", Offset = "0x1AF3890", VA = "0x181AF4C90")]
		public void requestCountRest()
		{
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x5C8BED0", Offset = "0x5C8AAD0", VA = "0x185C8BED0")]
		public bool IsRetryComplete()
		{
			return default(bool);
		}
	}
}
