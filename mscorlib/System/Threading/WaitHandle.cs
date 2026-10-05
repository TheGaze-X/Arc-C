using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[StructLayout(0)]
	public abstract class WaitHandle : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x4AF4090", Offset = "0x4AF2C90", VA = "0x184AF4090")]
		protected WaitHandle()
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x4AF2F20", Offset = "0x4AF1B20", VA = "0x184AF2F20")]
		private void Init()
		{
		}

		// Token: 0x170001D4 RID: 468
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		[System.Obsolete("Use the SafeWaitHandle property instead.")]
		public virtual System.IntPtr Handle
		{
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x4AF41E0", Offset = "0x4AF2DE0", VA = "0x184AF41E0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001D5")]
		public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle
		{
			[Token(Token = "0x600133B")]
			[Address(RVA = "0x4AF4110", Offset = "0x4AF2D10", VA = "0x184AF4110")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x4AF30C0", Offset = "0x4AF1CC0", VA = "0x184AF30C0")]
		internal void SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x4AF3D50", Offset = "0x4AF2950", VA = "0x184AF3D50", Slot = "8")]
		public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x4AF3F50", Offset = "0x4AF2B50", VA = "0x184AF3F50", Slot = "9")]
		public virtual bool WaitOne(System.TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x4AF3CC0", Offset = "0x4AF28C0", VA = "0x184AF3CC0", Slot = "10")]
		public virtual bool WaitOne()
		{
			return default(bool);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6001340")]
		[Address(RVA = "0x4AF3C70", Offset = "0x4AF2870", VA = "0x184AF3C70", Slot = "11")]
		public virtual bool WaitOne(int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6001341")]
		[Address(RVA = "0x4AF3D00", Offset = "0x4AF2900", VA = "0x184AF3D00", Slot = "12")]
		public virtual bool WaitOne(System.TimeSpan timeout)
		{
			return default(bool);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x6001342")]
		[Address(RVA = "0x4AF3DF0", Offset = "0x4AF29F0", VA = "0x184AF3DF0")]
		private bool WaitOne(long timeout, bool exitContext)
		{
			return default(bool);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x6001343")]
		[Address(RVA = "0x4AF2FA0", Offset = "0x4AF1BA0", VA = "0x184AF2FA0")]
		internal static bool InternalWaitOne(System.Runtime.InteropServices.SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			return default(bool);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x6001344")]
		[Address(RVA = "0x4AF32E0", Offset = "0x4AF1EE0", VA = "0x184AF32E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
		{
			return 0;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x6001345")]
		[Address(RVA = "0x4AF31C0", Offset = "0x4AF1DC0", VA = "0x184AF31C0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static int WaitAny(WaitHandle[] waitHandles, System.TimeSpan timeout, bool exitContext)
		{
			return 0;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001346")]
		[Address(RVA = "0x4AF3170", Offset = "0x4AF1D70", VA = "0x184AF3170")]
		private static void ThrowAbandonedMutexException()
		{
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001347")]
		[Address(RVA = "0x4AF3110", Offset = "0x4AF1D10", VA = "0x184AF3110")]
		private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001348")]
		[Address(RVA = "0x4AF2DF0", Offset = "0x4AF19F0", VA = "0x184AF2DF0", Slot = "13")]
		public virtual void Close()
		{
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x4AF2ED0", Offset = "0x4AF1AD0", VA = "0x184AF2ED0", Slot = "14")]
		protected virtual void Dispose(bool explicitDisposing)
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x4AF2E60", Offset = "0x4AF1A60", VA = "0x184AF2E60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x600134B")]
		[Address(RVA = "0x4AF3A80", Offset = "0x4AF2680", VA = "0x184AF3A80")]
		private static int WaitOneNative(System.Runtime.InteropServices.SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			return 0;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x4AF36D0", Offset = "0x4AF22D0", VA = "0x184AF36D0")]
		private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			return 0;
		}

		// Token: 0x0600134D RID: 4941
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x4AF4040", Offset = "0x4AF2C40", VA = "0x184AF4040")]
		[MethodImpl(4096)]
		internal unsafe static extern int Wait_internal(System.IntPtr* handles, int numHandles, bool waitAll, int ms);

		// Token: 0x04000ABA RID: 2746
		[Token(Token = "0x4000ABA")]
		public const int WaitTimeout = 258;

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		private const int MAX_WAITHANDLES = 64;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private System.IntPtr waitHandle;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Microsoft.Win32.SafeHandles.SafeWaitHandle safeWaitHandle;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool hasThreadAffinity;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		private const int WAIT_OBJECT_0 = 0;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		private const int WAIT_ABANDONED = 128;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		private const int WAIT_FAILED = 2147483647;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		private const int ERROR_TOO_MANY_POSTS = 298;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		private const int ERROR_NOT_OWNED_BY_CALLER = 299;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly System.IntPtr InvalidHandle;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		internal const int MaxWaitHandles = 64;
	}
}
