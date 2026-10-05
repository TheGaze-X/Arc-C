using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace Assets.AiriSDK.API.Source.Steam.pay
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class PurchaseTask
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000008")]
		public string ExtraData
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000009")]
		public Dictionary<string, object> EventParams
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000A")]
		public CancellationTokenSource Cts
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700000B")]
		public SteamPayResponse<Dictionary<string, object>> Callback
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x444A690", Offset = "0x4449290", VA = "0x18444A690")]
		public PurchaseTask(string extraData, Dictionary<string, object> eventParams, CancellationTokenSource cts, SteamPayResponse<Dictionary<string, object>> callback)
		{
		}
	}
}
