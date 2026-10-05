using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	internal class ContextAwareResult : LazyAsyncResult
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void SafeCaptureIdentity()
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void CleanupInternal()
		{
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x519C2F0", Offset = "0x519AEF0", VA = "0x18519C2F0")]
		internal ContextAwareResult(object myObject, object myState, AsyncCallback myCallBack)
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x519C290", Offset = "0x519AE90", VA = "0x18519C290")]
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack)
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x519C220", Offset = "0x519AE20", VA = "0x18519C220")]
		internal ContextAwareResult(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x519C140", Offset = "0x519AD40", VA = "0x18519C140")]
		internal object StartPostingAsyncOp()
		{
			return null;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x519C050", Offset = "0x519AC50", VA = "0x18519C050")]
		internal object StartPostingAsyncOp(bool lockCapture)
		{
			return null;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x519C010", Offset = "0x519AC10", VA = "0x18519C010")]
		internal bool FinishPostingAsyncOp()
		{
			return default(bool);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x519BA90", Offset = "0x519A690", VA = "0x18519BA90", Slot = "9")]
		protected override void Cleanup()
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x519B580", Offset = "0x519A180", VA = "0x18519B580")]
		private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext)
		{
			return default(bool);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x519BC80", Offset = "0x519A880", VA = "0x18519BC80", Slot = "8")]
		protected override void Complete(IntPtr userToken)
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x519BB70", Offset = "0x519A770", VA = "0x18519BB70")]
		private void CompleteCallback()
		{
		}

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x40")]
		private ExecutionContext _context;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x48")]
		private object _lock;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x50")]
		private ContextAwareResult.StateFlags _flags;

		// Token: 0x0200027D RID: 637
		[Token(Token = "0x200027D")]
		[Flags]
		private enum StateFlags : byte
		{
			// Token: 0x040008C8 RID: 2248
			[Token(Token = "0x40008C8")]
			None = 0,
			// Token: 0x040008C9 RID: 2249
			[Token(Token = "0x40008C9")]
			CaptureIdentity = 1,
			// Token: 0x040008CA RID: 2250
			[Token(Token = "0x40008CA")]
			CaptureContext = 2,
			// Token: 0x040008CB RID: 2251
			[Token(Token = "0x40008CB")]
			ThreadSafeContextCopy = 4,
			// Token: 0x040008CC RID: 2252
			[Token(Token = "0x40008CC")]
			PostBlockStarted = 8,
			// Token: 0x040008CD RID: 2253
			[Token(Token = "0x40008CD")]
			PostBlockFinished = 16
		}
	}
}
