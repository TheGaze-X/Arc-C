using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	internal class Page : IDisposable
	{
		// Token: 0x0600138C RID: 5004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x5A58DD0", Offset = "0x5A579D0", VA = "0x185A58DD0")]
		public Page(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage)
		{
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0000A380 File Offset: 0x00008580
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C0")]
		private protected bool disposed
		{
			[Token(Token = "0x600138D")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600138E")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x5A58D60", Offset = "0x5A57960", VA = "0x185A58D60", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x5A58CD0", Offset = "0x5A578D0", VA = "0x185A58CD0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001391 RID: 5009 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x170004C1")]
		public bool isEmpty
		{
			[Token(Token = "0x6001391")]
			[Address(RVA = "0x5A58F40", Offset = "0x5A57B40", VA = "0x185A58F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x18")]
		public Page.DataSet<Vertex> vertices;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x20")]
		public Page.DataSet<ushort> indices;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x28")]
		public Page next;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x30")]
		public int framesEmpty;

		// Token: 0x020002D3 RID: 723
		[Token(Token = "0x20002D3")]
		public class DataSet<T> : IDisposable where T : struct
		{
			// Token: 0x06001392 RID: 5010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001392")]
			public DataSet(Utility.GPUBufferType bufferType, uint totalCount, uint maxQueuedFrameCount, uint updateRangePoolSize, bool mockBuffer)
			{
			}

			// Token: 0x170004C2 RID: 1218
			// (get) Token: 0x06001393 RID: 5011 RVA: 0x0000A3B0 File Offset: 0x000085B0
			// (set) Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170004C2")]
			private protected bool disposed
			{
				[Token(Token = "0x6001393")]
				[CompilerGenerated]
				protected get
				{
					return default(bool);
				}
				[Token(Token = "0x6001394")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001395 RID: 5013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001395")]
			public void Dispose()
			{
			}

			// Token: 0x06001396 RID: 5014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001396")]
			public void Dispose(bool disposing)
			{
			}

			// Token: 0x06001397 RID: 5015 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001397")]
			public void RegisterUpdate(uint start, uint size)
			{
			}

			// Token: 0x06001398 RID: 5016 RVA: 0x0000A3C8 File Offset: 0x000085C8
			[Token(Token = "0x6001398")]
			private bool HasMappedBufferRange()
			{
				return default(bool);
			}

			// Token: 0x06001399 RID: 5017 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001399")]
			public void SendUpdates()
			{
			}

			// Token: 0x0600139A RID: 5018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600139A")]
			public void SendFullRange()
			{
			}

			// Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600139B")]
			public void SendPartialRanges()
			{
			}

			// Token: 0x0600139C RID: 5020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600139C")]
			private void ResetUpdateState()
			{
			}

			// Token: 0x04000B3A RID: 2874
			[Token(Token = "0x4000B3A")]
			[FieldOffset(Offset = "0x0")]
			public Utility.GPUBuffer<T> gpuData;

			// Token: 0x04000B3B RID: 2875
			[Token(Token = "0x4000B3B")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<T> cpuData;

			// Token: 0x04000B3C RID: 2876
			[Token(Token = "0x4000B3C")]
			[FieldOffset(Offset = "0x0")]
			public NativeArray<GfxUpdateBufferRange> updateRanges;

			// Token: 0x04000B3D RID: 2877
			[Token(Token = "0x4000B3D")]
			[FieldOffset(Offset = "0x0")]
			public GPUBufferAllocator allocator;

			// Token: 0x04000B3E RID: 2878
			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x0")]
			private readonly uint m_UpdateRangePoolSize;

			// Token: 0x04000B3F RID: 2879
			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0x0")]
			private uint m_ElemStride;

			// Token: 0x04000B40 RID: 2880
			[Token(Token = "0x4000B40")]
			[FieldOffset(Offset = "0x0")]
			private uint m_UpdateRangeMin;

			// Token: 0x04000B41 RID: 2881
			[Token(Token = "0x4000B41")]
			[FieldOffset(Offset = "0x0")]
			private uint m_UpdateRangeMax;

			// Token: 0x04000B42 RID: 2882
			[Token(Token = "0x4000B42")]
			[FieldOffset(Offset = "0x0")]
			private uint m_UpdateRangesEnqueued;

			// Token: 0x04000B43 RID: 2883
			[Token(Token = "0x4000B43")]
			[FieldOffset(Offset = "0x0")]
			private uint m_UpdateRangesBatchStart;

			// Token: 0x04000B44 RID: 2884
			[Token(Token = "0x4000B44")]
			[FieldOffset(Offset = "0x0")]
			private bool m_UpdateRangesSaturated;
		}
	}
}
