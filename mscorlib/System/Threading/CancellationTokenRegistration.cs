using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	public readonly struct CancellationTokenRegistration : System.IEquatable<CancellationTokenRegistration>, System.IDisposable
	{
		// Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x40068E0", Offset = "0x40054E0", VA = "0x1840068E0")]
		internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x4D48EB0", Offset = "0x4D47AB0", VA = "0x184D48EB0")]
		public bool Unregister()
		{
			return default(bool);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x4D48B20", Offset = "0x4D47720", VA = "0x184D48B20", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x4D48D00", Offset = "0x4D47900", VA = "0x184D48D00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x4D48C60", Offset = "0x4D47860", VA = "0x184D48C60", Slot = "4")]
		public bool Equals(CancellationTokenRegistration other)
		{
			return default(bool);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x4D48DF0", Offset = "0x4D479F0", VA = "0x184D48DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000A21 RID: 2593
		[Token(Token = "0x4000A21")]
		[FieldOffset(Offset = "0x0")]
		private readonly CancellationCallbackInfo m_callbackInfo;

		// Token: 0x04000A22 RID: 2594
		[Token(Token = "0x4000A22")]
		[FieldOffset(Offset = "0x8")]
		private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;
	}
}
