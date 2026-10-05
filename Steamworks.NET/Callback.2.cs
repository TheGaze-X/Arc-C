using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public sealed class Callback<T> : Callback, IDisposable
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060008C6 RID: 2246 RVA: 0x00002142 File Offset: 0x00000342
		// (remove) Token: 0x060008C7 RID: 2247 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x14000001")]
		private event Callback<T>.DispatchDelegate m_Func
		{
			[Token(Token = "0x60008C6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008C7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008C8")]
		public static Callback<T> Create(Callback<T>.DispatchDelegate func)
		{
			return null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008C9")]
		public static Callback<T> CreateGameServer(Callback<T>.DispatchDelegate func)
		{
			return null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008CA")]
		public Callback(Callback<T>.DispatchDelegate func, bool bGameServer = false)
		{
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008CB")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008CC")]
		public void Dispose()
		{
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008CD")]
		public void Register(Callback<T>.DispatchDelegate func)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008CE")]
		public void Unregister()
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00007D9C File Offset: 0x00005F9C
		[Token(Token = "0x17000023")]
		public override bool IsGameServer
		{
			[Token(Token = "0x60008CF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60008D0")]
		internal override Type GetCallbackType()
		{
			return null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008D1")]
		internal override void OnRunCallback(IntPtr pvParam)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60008D2")]
		internal override void SetUnregistered()
		{
		}

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bGameServer;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bIsRegistered;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x0")]
		private bool m_bDisposed;

		// Token: 0x02000183 RID: 387
		// (Invoke) Token: 0x060008D4 RID: 2260
		[Token(Token = "0x2000183")]
		public delegate void DispatchDelegate(T param);
	}
}
