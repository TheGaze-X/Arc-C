using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	[NativeHeader("Runtime/Shaders/GraphicsBuffer.h")]
	[NativeClass("GraphicsBuffer")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Export/Graphics/GraphicsBuffer.bindings.h")]
	public sealed class ComputeBuffer : IDisposable
	{
		// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x59591D0", Offset = "0x5957DD0", VA = "0x1859591D0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x5959030", Offset = "0x5957C30", VA = "0x185959030", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x59590F0", Offset = "0x5957CF0", VA = "0x1859590F0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000A6F RID: 2671
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x5959400", Offset = "0x5958000", VA = "0x185959400")]
		[FreeFunction("GraphicsBuffer_Bindings::InitComputeBuffer")]
		[MethodImpl(4096)]
		private static extern IntPtr InitBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage);

		// Token: 0x06000A70 RID: 2672
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x5958FF0", Offset = "0x5957BF0", VA = "0x185958FF0")]
		[FreeFunction("GraphicsBuffer_Bindings::DestroyBuffer")]
		[MethodImpl(4096)]
		private static extern void DestroyBuffer(ComputeBuffer buf);

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x5959940", Offset = "0x5958540", VA = "0x185959940")]
		public ComputeBuffer(int count, int stride)
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x59596E0", Offset = "0x59582E0", VA = "0x1859596E0")]
		public ComputeBuffer(int count, int stride, ComputeBufferType type)
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x5959710", Offset = "0x5958310", VA = "0x185959710")]
		private ComputeBuffer(int count, int stride, ComputeBufferType type, ComputeBufferMode usage, int stackDepth)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x5959030", Offset = "0x5957C30", VA = "0x185959030")]
		public void Release()
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A75 RID: 2677
		[Token(Token = "0x1700020E")]
		public extern int count { [Token(Token = "0x6000A75")] [Address(RVA = "0x5959970", Offset = "0x5958570", VA = "0x185959970")] [MethodImpl(4096)] get; }

		// Token: 0x06000A76 RID: 2678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x5959540", Offset = "0x5958140", VA = "0x185959540")]
		public void SetData(Array data)
		{
		}

		// Token: 0x06000A77 RID: 2679
		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x59594D0", Offset = "0x59580D0", VA = "0x1859594D0")]
		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalSetData", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void InternalSetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x5959230", Offset = "0x5957E30", VA = "0x185959230")]
		public void GetData(Array data)
		{
		}

		// Token: 0x06000A79 RID: 2681
		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x5959460", Offset = "0x5958060", VA = "0x185959460")]
		[FreeFunction(Name = "GraphicsBuffer_Bindings::InternalGetData", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void InternalGetData(Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

		// Token: 0x06000A7A RID: 2682
		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x5958F90", Offset = "0x5957B90", VA = "0x185958F90")]
		[MethodImpl(4096)]
		public static extern void CopyCount(ComputeBuffer src, ComputeBuffer dst, int dstOffsetBytes);

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
