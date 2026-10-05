using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[System.Diagnostics.DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
	public readonly struct CancellationToken
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x1700019D")]
		public static CancellationToken None
		{
			[Token(Token = "0x60011B8")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return default(CancellationToken);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x1700019E")]
		public bool IsCancellationRequested
		{
			[Token(Token = "0x60011B9")]
			[Address(RVA = "0x4D4AE60", Offset = "0x4D49A60", VA = "0x184D4AE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x1700019F")]
		public bool CanBeCanceled
		{
			[Token(Token = "0x60011BA")]
			[Address(RVA = "0x11F7680", Offset = "0x11F6280", VA = "0x1811F7680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
		internal CancellationToken(CancellationTokenSource source)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x4D4ADC0", Offset = "0x4D499C0", VA = "0x184D4ADC0")]
		public CancellationToken(bool canceled)
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x4D4A940", Offset = "0x4D49540", VA = "0x184D4A940")]
		public CancellationTokenRegistration Register(System.Action callback)
		{
			return default(CancellationTokenRegistration);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		[Token(Token = "0x60011BE")]
		[Address(RVA = "0x4D4A890", Offset = "0x4D49490", VA = "0x184D4A890")]
		internal CancellationTokenRegistration InternalRegisterWithoutEC(System.Action<object> callback, object state)
		{
			return default(CancellationTokenRegistration);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		[Token(Token = "0x60011BF")]
		[Address(RVA = "0x4D4AA60", Offset = "0x4D49660", VA = "0x184D4AA60")]
		[MethodImpl(8)]
		public CancellationTokenRegistration Register(System.Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext)
		{
			return default(CancellationTokenRegistration);
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x4CDA030", Offset = "0x4CD8C30", VA = "0x184CDA030")]
		public bool Equals(CancellationToken other)
		{
			return default(bool);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x0000E508 File Offset: 0x0000C708
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x4D4A760", Offset = "0x4D49360", VA = "0x184D4A760", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x0000E520 File Offset: 0x0000C720
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x4D4A800", Offset = "0x4D49400", VA = "0x184D4A800", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x4D4AE90", Offset = "0x4D49A90", VA = "0x184D4AE90")]
		public static bool operator ==(CancellationToken left, CancellationToken right)
		{
			return default(bool);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x4D4AEF0", Offset = "0x4D49AF0", VA = "0x184D4AEF0")]
		public static bool operator !=(CancellationToken left, CancellationToken right)
		{
			return default(bool);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x4D4ABF0", Offset = "0x4D497F0", VA = "0x184D4ABF0")]
		public void ThrowIfCancellationRequested()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x4D4AC70", Offset = "0x4D49870", VA = "0x184D4AC70")]
		private void ThrowOperationCanceledException()
		{
		}

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x0")]
		private readonly CancellationTokenSource _source;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Action<object> s_actionToActionObjShunt;
	}
}
