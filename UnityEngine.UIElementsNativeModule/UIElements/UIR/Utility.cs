using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[NativeHeader("Modules/UIElementsNative/UIRendererUtility.h")]
	[VisibleToOtherModules(new string[]
	{
		"Unity.UIElements"
	})]
	internal class Utility
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		public static void SetVectorArray<T>(MaterialPropertyBlock props, int name, NativeSlice<T> vector4s) where T : struct
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000C4 RID: 196 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public static event Action<bool> GraphicsResourcesRecreate
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x5B4E700", Offset = "0x5B4D300", VA = "0x185B4E700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x5B4EC30", Offset = "0x5B4D830", VA = "0x185B4EC30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public static event Action EngineUpdate
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x5B4E500", Offset = "0x5B4D100", VA = "0x185B4E500")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x5B4EA30", Offset = "0x5B4D630", VA = "0x185B4EA30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000003")]
		public static event Action FlushPendingResources
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x5B4E600", Offset = "0x5B4D200", VA = "0x185B4E600")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x5B4EB30", Offset = "0x5B4D730", VA = "0x185B4EB30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000CB RID: 203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000004")]
		public static event Action<Camera> RegisterIntermediateRenderers
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x5B4E810", Offset = "0x5B4D410", VA = "0x185B4E810")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x5B4ED40", Offset = "0x5B4D940", VA = "0x185B4ED40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000005")]
		public static event Action<IntPtr> RenderNodeExecute
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x5B4E920", Offset = "0x5B4D520", VA = "0x185B4E920")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x5B4EE50", Offset = "0x5B4DA50", VA = "0x185B4EE50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x5B4DE80", Offset = "0x5B4CA80", VA = "0x185B4DE80")]
		[RequiredByNativeCode]
		internal static void RaiseGraphicsResourcesRecreate(bool recreate)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5B4DD50", Offset = "0x5B4C950", VA = "0x185B4DD50")]
		[RequiredByNativeCode]
		internal static void RaiseEngineUpdate()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x5B4DE10", Offset = "0x5B4CA10", VA = "0x185B4DE10")]
		[RequiredByNativeCode]
		internal static void RaiseFlushPendingResources()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5B4DEF0", Offset = "0x5B4CAF0", VA = "0x185B4DEF0")]
		[RequiredByNativeCode]
		internal static void RaiseRegisterIntermediateRenderers(Camera camera)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x5B4DF60", Offset = "0x5B4CB60", VA = "0x185B4DF60")]
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeAdd(IntPtr userData)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x5B4E040", Offset = "0x5B4CC40", VA = "0x185B4E040")]
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeExecute(IntPtr userData)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x5B4DFD0", Offset = "0x5B4CBD0", VA = "0x185B4DFD0")]
		[RequiredByNativeCode]
		internal static void RaiseRenderNodeCleanup(IntPtr userData)
		{
		}

		// Token: 0x060000D5 RID: 213
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5B4D880", Offset = "0x5B4C480", VA = "0x185B4D880")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer);

		// Token: 0x060000D6 RID: 214
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5B4DA60", Offset = "0x5B4C660", VA = "0x185B4DA60")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern void FreeBuffer(IntPtr buffer);

		// Token: 0x060000D7 RID: 215
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5B4E3F0", Offset = "0x5B4CFF0", VA = "0x185B4E3F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd);

		// Token: 0x060000D8 RID: 216
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5B4E360", Offset = "0x5B4CF60", VA = "0x185B4E360")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count);

		// Token: 0x060000D9 RID: 217
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5B4DC10", Offset = "0x5B4C810", VA = "0x185B4DC10")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes);

		// Token: 0x060000DA RID: 218 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5B4E130", Offset = "0x5B4CD30", VA = "0x185B4E130")]
		public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize)
		{
		}

		// Token: 0x060000DB RID: 219
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5B4D9F0", Offset = "0x5B4C5F0", VA = "0x185B4D9F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public unsafe static extern void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl);

		// Token: 0x060000DC RID: 220
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5B4E230", Offset = "0x5B4CE30", VA = "0x185B4E230")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void SetPropertyBlock(MaterialPropertyBlock props);

		// Token: 0x060000DD RID: 221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5B4E2B0", Offset = "0x5B4CEB0", VA = "0x185B4E2B0")]
		[ThreadSafe]
		public static void SetScissorRect(RectInt scissorRect)
		{
		}

		// Token: 0x060000DE RID: 222
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5B4D9C0", Offset = "0x5B4C5C0", VA = "0x185B4D9C0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void DisableScissor();

		// Token: 0x060000DF RID: 223 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5B4D950", Offset = "0x5B4C550", VA = "0x185B4D950")]
		[ThreadSafe]
		public static IntPtr CreateStencilState(StencilState stencilState)
		{
			return 0;
		}

		// Token: 0x060000E0 RID: 224
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x5B4E320", Offset = "0x5B4CF20", VA = "0x185B4E320")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void SetStencilState(IntPtr stencilState, int stencilRef);

		// Token: 0x060000E1 RID: 225
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5B4DC50", Offset = "0x5B4C850", VA = "0x185B4DC50")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool HasMappedBufferRange();

		// Token: 0x060000E2 RID: 226
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5B4DC80", Offset = "0x5B4C880", VA = "0x185B4DC80")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern uint InsertCPUFence();

		// Token: 0x060000E3 RID: 227
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5B4D8D0", Offset = "0x5B4C4D0", VA = "0x185B4D8D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool CPUFencePassed(uint fence);

		// Token: 0x060000E4 RID: 228
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x5B4E460", Offset = "0x5B4D060", VA = "0x185B4E460")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void WaitForCPUFencePassed(uint fence);

		// Token: 0x060000E5 RID: 229
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5B4E3C0", Offset = "0x5B4CFC0", VA = "0x185B4E3C0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void SyncRenderThread();

		// Token: 0x060000E6 RID: 230 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x5B4DAE0", Offset = "0x5B4C6E0", VA = "0x185B4DAE0")]
		[ThreadSafe]
		public static RectInt GetActiveViewport()
		{
			return default(RectInt);
		}

		// Token: 0x060000E7 RID: 231
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5B4DCF0", Offset = "0x5B4C8F0", VA = "0x185B4DCF0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void ProfileDrawChainBegin();

		// Token: 0x060000E8 RID: 232
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x5B4DD20", Offset = "0x5B4C920", VA = "0x185B4DD20")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void ProfileDrawChainEnd();

		// Token: 0x060000E9 RID: 233
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x5B4DCB0", Offset = "0x5B4C8B0", VA = "0x185B4DCB0")]
		[MethodImpl(4096)]
		public static extern void NotifyOfUIREvents(bool subscribe);

		// Token: 0x060000EA RID: 234 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5B4DB90", Offset = "0x5B4C790", VA = "0x185B4DB90")]
		[ThreadSafe]
		public static Matrix4x4 GetUnityProjectionMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x060000EC RID: 236
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5B4E0B0", Offset = "0x5B4CCB0", VA = "0x185B4E0B0")]
		[MethodImpl(4096)]
		private static extern void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, ulong sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize);

		// Token: 0x060000ED RID: 237
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5B4E270", Offset = "0x5B4CE70", VA = "0x185B4E270")]
		[MethodImpl(4096)]
		private static extern void SetScissorRect_Injected(ref RectInt scissorRect);

		// Token: 0x060000EE RID: 238
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5B4D910", Offset = "0x5B4C510", VA = "0x185B4D910")]
		[MethodImpl(4096)]
		private static extern IntPtr CreateStencilState_Injected(ref StencilState stencilState);

		// Token: 0x060000EF RID: 239
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5B4DAA0", Offset = "0x5B4C6A0", VA = "0x185B4DAA0")]
		[MethodImpl(4096)]
		private static extern void GetActiveViewport_Injected(out RectInt ret);

		// Token: 0x060000F0 RID: 240
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5B4DB50", Offset = "0x5B4C750", VA = "0x185B4DB50")]
		[MethodImpl(4096)]
		private static extern void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x20")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<IntPtr> RenderNodeAdd;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<IntPtr> RenderNodeCleanup;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker s_MarkerRaiseEngineUpdate;

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		internal enum GPUBufferType
		{
			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			Vertex,
			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			Index
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public class GPUBuffer<T> : IDisposable where T : struct
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F1")]
			public GPUBuffer(int elementCount, Utility.GPUBufferType type)
			{
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F2")]
			public void Dispose()
			{
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000F3")]
			public void UpdateRanges(NativeSlice<GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax)
			{
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000251C File Offset: 0x0000071C
			[Token(Token = "0x17000041")]
			public int ElementStride
			{
				[Token(Token = "0x60000F4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002534 File Offset: 0x00000734
			[Token(Token = "0x17000042")]
			internal IntPtr BufferPointer
			{
				[Token(Token = "0x60000F5")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x0")]
			private IntPtr buffer;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x0")]
			private int elemCount;

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x0")]
			private int elemStride;
		}
	}
}
