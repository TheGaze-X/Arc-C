using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Mono.Interop;

namespace System.Threading
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	internal class OSSpecificSynchronizationContext : SynchronizationContext
	{
		// Token: 0x060012A5 RID: 4773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		private OSSpecificSynchronizationContext(object osContext)
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x4D57F70", Offset = "0x4D56B70", VA = "0x184D57F70")]
		public static OSSpecificSynchronizationContext Get()
		{
			return null;
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x4D57EF0", Offset = "0x4D56AF0", VA = "0x184D57EF0", Slot = "9")]
		public override SynchronizationContext CreateCopy()
		{
			return null;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x4D583F0", Offset = "0x4D56FF0", VA = "0x184D583F0", Slot = "4")]
		public override void Send(SendOrPostCallback d, object state)
		{
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x4D58290", Offset = "0x4D56E90", VA = "0x184D58290", Slot = "5")]
		public override void Post(SendOrPostCallback d, object state)
		{
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x4D58100", Offset = "0x4D56D00", VA = "0x184D58100")]
		[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
		private static void InvocationEntry(System.IntPtr arg)
		{
		}

		// Token: 0x060012AB RID: 4779
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x4D57F60", Offset = "0x4D56B60", VA = "0x184D57F60")]
		[MethodImpl(4096)]
		private static extern object GetOSContext();

		// Token: 0x060012AC RID: 4780
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x4D58280", Offset = "0x4D56E80", VA = "0x184D58280")]
		[MethodImpl(4096)]
		private static extern void PostInternal(object osSynchronizationContext, System.IntPtr callback, System.IntPtr arg);

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x18")]
		private object m_OSSynchronizationContext;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache;

		// Token: 0x02000220 RID: 544
		// (Invoke) Token: 0x060012AF RID: 4783
		[Token(Token = "0x2000220")]
		private delegate void InvocationEntryDelegate(System.IntPtr arg);

		// Token: 0x02000221 RID: 545
		[Token(Token = "0x2000221")]
		private class InvocationContext
		{
			// Token: 0x060012B0 RID: 4784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012B0")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public InvocationContext(SendOrPostCallback d, object state)
			{
			}

			// Token: 0x060012B1 RID: 4785 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012B1")]
			[Address(RVA = "0x1A735C0", Offset = "0x1A721C0", VA = "0x181A735C0")]
			public void Invoke()
			{
			}

			// Token: 0x04000A84 RID: 2692
			[Token(Token = "0x4000A84")]
			[FieldOffset(Offset = "0x10")]
			private SendOrPostCallback m_Delegate;

			// Token: 0x04000A85 RID: 2693
			[Token(Token = "0x4000A85")]
			[FieldOffset(Offset = "0x18")]
			private object m_State;
		}
	}
}
