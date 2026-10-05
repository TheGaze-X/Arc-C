using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public sealed class CallResult<T> : CallResult, IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060008DB RID: 2267 RVA: 0x00002142 File Offset: 0x00000342
		// (remove) Token: 0x060008DC RID: 2268 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x14000002")]
		private event CallResult<T>.APIDispatchDelegate m_Func
		{
			[Token(Token = "0x60008DB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00007DB4 File Offset: 0x00005FB4
		[Token(Token = "0x17000024")]
		public SteamAPICall_t Handle
		{
			[Token(Token = "0x60008DD")]
			get
			{
				return default(SteamAPICall_t);
			}
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008DE")]
		public static CallResult<T> Create([Optional] CallResult<T>.APIDispatchDelegate func)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008DF")]
		public CallResult([Optional] CallResult<T>.APIDispatchDelegate func)
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E0")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E1")]
		public void Dispose()
		{
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E2")]
		public void Set(SteamAPICall_t hAPICall, [Optional] CallResult<T>.APIDispatchDelegate func)
		{
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00007DCC File Offset: 0x00005FCC
		[Token(Token = "0x60008E3")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E4")]
		public void Cancel()
		{
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008E5")]
		internal override Type GetCallbackType()
		{
			return null;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E6")]
		internal override void OnRunCallResult(IntPtr pvParam, bool bFailed, ulong hSteamAPICall_)
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008E7")]
		internal override void SetUnregistered()
		{
		}

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private SteamAPICall_t m_hAPICall;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		// Token: 0x02000186 RID: 390
		// (Invoke) Token: 0x060008E9 RID: 2281
		[Token(Token = "0x2000186")]
		public delegate void APIDispatchDelegate(T param, bool bIOFailure);
	}
}
