using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	[StructLayout(0)]
	public class AsyncOperation : YieldInstruction
	{
		// Token: 0x060008F6 RID: 2294
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x5947280", Offset = "0x5945E80", VA = "0x185947280")]
		[NativeMethod(IsThreadSafe = true)]
		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void InternalDestroy(IntPtr ptr);

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008F7 RID: 2295
		[Token(Token = "0x170001E9")]
		public extern bool isDone { [Token(Token = "0x60008F7")] [Address(RVA = "0x5947400", Offset = "0x5946000", VA = "0x185947400")] [NativeMethod("IsDone")] [MethodImpl(4096)] get; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008F8 RID: 2296
		[Token(Token = "0x170001EA")]
		public extern float progress { [Token(Token = "0x60008F8")] [Address(RVA = "0x5947440", Offset = "0x5946040", VA = "0x185947440")] [NativeMethod("GetProgress")] [MethodImpl(4096)] get; }

		// Token: 0x170001EB RID: 491
		// (set) Token: 0x060008F9 RID: 2297
		[Token(Token = "0x170001EB")]
		public extern bool allowSceneActivation { [Token(Token = "0x60008F9")] [Address(RVA = "0x5947530", Offset = "0x5946130", VA = "0x185947530")] [NativeMethod("SetAllowSceneActivation")] [MethodImpl(4096)] set; }

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x5947200", Offset = "0x5945E00", VA = "0x185947200", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x59472C0", Offset = "0x5945EC0", VA = "0x1859472C0")]
		[RequiredByNativeCode]
		internal void InvokeCompletionEvent()
		{
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000B")]
		public event Action<AsyncOperation> completed
		{
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x5947300", Offset = "0x5945F00", VA = "0x185947300")]
			add
			{
			}
			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x5947480", Offset = "0x5946080", VA = "0x185947480")]
			remove
			{
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public AsyncOperation()
		{
		}

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action<AsyncOperation> m_completeCallback;
	}
}
