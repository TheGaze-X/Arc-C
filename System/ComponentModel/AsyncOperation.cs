using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public sealed class AsyncOperation
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x511ECF0", Offset = "0x511D8F0", VA = "0x18511ECF0")]
		private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x511E640", Offset = "0x511D240", VA = "0x18511E640", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AF")]
		public object UserSuppliedState
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B0")]
		public SynchronizationContext SynchronizationContext
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x511EA90", Offset = "0x511D690", VA = "0x18511EA90")]
		public void Post(SendOrPostCallback d, object arg)
		{
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x511E950", Offset = "0x511D550", VA = "0x18511E950")]
		public void PostOperationCompleted(SendOrPostCallback d, object arg)
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x511E7A0", Offset = "0x511D3A0", VA = "0x18511E7A0")]
		public void OperationCompleted()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x511E820", Offset = "0x511D420", VA = "0x18511E820")]
		private void PostCore(SendOrPostCallback d, object arg, bool markCompleted)
		{
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x511E6D0", Offset = "0x511D2D0", VA = "0x18511E6D0")]
		private void OperationCompletedCore()
		{
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x511EC50", Offset = "0x511D850", VA = "0x18511EC50")]
		private void VerifyNotCompleted()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x511EBC0", Offset = "0x511D7C0", VA = "0x18511EBC0")]
		private void VerifyDelegateNotNull(SendOrPostCallback d)
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x511E580", Offset = "0x511D180", VA = "0x18511E580")]
		internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
		{
			return null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x511ECC0", Offset = "0x511D8C0", VA = "0x18511ECC0")]
		internal AsyncOperation()
		{
		}

		// Token: 0x040005FE RID: 1534
		[Token(Token = "0x40005FE")]
		[FieldOffset(Offset = "0x10")]
		private readonly SynchronizationContext _syncContext;

		// Token: 0x040005FF RID: 1535
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x18")]
		private readonly object _userSuppliedState;

		// Token: 0x04000600 RID: 1536
		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x20")]
		private bool _alreadyCompleted;
	}
}
