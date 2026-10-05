using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	internal abstract class MonoBtlsObject : IDisposable
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal MonoBtlsObject(MonoBtlsObject.MonoBtlsHandle handle)
		{
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		internal MonoBtlsObject.MonoBtlsHandle Handle
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x4F589A0", Offset = "0x4F575A0", VA = "0x184F589A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000067")]
		public bool IsValid
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x4F589C0", Offset = "0x4F575C0", VA = "0x184F589C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4F58670", Offset = "0x4F57270", VA = "0x184F58670")]
		protected void CheckThrow()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4F58970", Offset = "0x4F57570", VA = "0x184F58970")]
		protected Exception SetException(Exception ex)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4F581B0", Offset = "0x4F56DB0", VA = "0x184F581B0")]
		protected void CheckError(bool ok, [CallerMemberName] [Optional] string callerName)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4F583A0", Offset = "0x4F56FA0", VA = "0x184F583A0")]
		protected void CheckError(int ret, [CallerMemberName] [Optional] string callerName)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4F583B0", Offset = "0x4F56FB0", VA = "0x184F583B0")]
		protected internal void CheckLastError([CallerMemberName] [Optional] string callerName)
		{
		}

		// Token: 0x060001EF RID: 495
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4F58A10", Offset = "0x4F57610", VA = "0x184F58A10")]
		[PreserveSig]
		private static extern void mono_btls_free(IntPtr data);

		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4F588F0", Offset = "0x4F574F0", VA = "0x184F588F0")]
		protected void FreeDataPtr(IntPtr data)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Close()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4F58730", Offset = "0x4F57330", VA = "0x184F58730")]
		protected void Dispose(bool disposing)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4F58830", Offset = "0x4F57430", VA = "0x184F58830", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4F58890", Offset = "0x4F57490", VA = "0x184F58890", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MonoBtlsObject.MonoBtlsHandle handle;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Exception lastError;

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		protected internal abstract class MonoBtlsHandle : SafeHandle
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x4F57850", Offset = "0x4F56450", VA = "0x184F57850")]
			internal MonoBtlsHandle(IntPtr handle, bool ownsHandle)
			{
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x000029D0 File Offset: 0x00000BD0
			[Token(Token = "0x17000068")]
			public override bool IsInvalid
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0x4F57860", Offset = "0x4F56460", VA = "0x184F57860", Slot = "5")]
				get
				{
					return default(bool);
				}
			}
		}
	}
}
