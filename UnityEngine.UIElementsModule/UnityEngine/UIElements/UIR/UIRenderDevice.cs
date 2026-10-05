using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	internal class UIRenderDevice : IDisposable
	{
		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x170004B4")]
		internal uint maxVerticesPerPage
		{
			[Token(Token = "0x6001348")]
			[Address(RVA = "0x538F7E0", Offset = "0x538E3E0", VA = "0x18538F7E0")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0000A200 File Offset: 0x00008400
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B5")]
		internal bool breakBatches
		{
			[Token(Token = "0x6001349")]
			[Address(RVA = "0x5A65650", Offset = "0x5A64250", VA = "0x185A65650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600134A")]
			[Address(RVA = "0x5A663F0", Offset = "0x5A64FF0", VA = "0x185A663F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134C")]
		[Address(RVA = "0x5A65630", Offset = "0x5A64230", VA = "0x185A65630")]
		public UIRenderDevice(uint initialVertexCapacity = 0U, uint initialIndexCapacity = 0U)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134D")]
		[Address(RVA = "0x5A64D90", Offset = "0x5A63990", VA = "0x185A64D90")]
		protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice)
		{
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004B6")]
		internal static Texture2D defaultShaderInfoTexFloat
		{
			[Token(Token = "0x600134E")]
			[Address(RVA = "0x5A65A40", Offset = "0x5A64640", VA = "0x185A65A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170004B7")]
		internal static Texture2D defaultShaderInfoTexARGB8
		{
			[Token(Token = "0x600134F")]
			[Address(RVA = "0x5A65660", Offset = "0x5A64260", VA = "0x185A65660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x170004B8")]
		internal static bool vertexTexturingIsAvailable
		{
			[Token(Token = "0x6001350")]
			[Address(RVA = "0x5A66210", Offset = "0x5A64E10", VA = "0x185A66210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x170004B9")]
		internal static bool shaderModelIs35
		{
			[Token(Token = "0x6001351")]
			[Address(RVA = "0x5A66030", Offset = "0x5A64C30", VA = "0x185A66030")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x5A62950", Offset = "0x5A61550", VA = "0x185A62950")]
		private void InitVertexDeclaration()
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x5A60DF0", Offset = "0x5A5F9F0", VA = "0x185A60DF0")]
		private void CompleteCreation()
		{
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x170004BA")]
		private bool fullyCreated
		{
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x5A66020", Offset = "0x5A64C20", VA = "0x185A66020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0000A260 File Offset: 0x00008460
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BB")]
		private protected bool disposed
		{
			[Token(Token = "0x6001355")]
			[Address(RVA = "0x5A66010", Offset = "0x5A64C10", VA = "0x185A66010")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6001356")]
			[Address(RVA = "0x5A66400", Offset = "0x5A65000", VA = "0x185A66400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x5A61140", Offset = "0x5A5FD40", VA = "0x185A61140", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x5A60FC0", Offset = "0x5A5FBC0", VA = "0x185A60FC0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x5A60060", Offset = "0x5A5EC60", VA = "0x185A60060")]
		public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
			return null;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x5A643B0", Offset = "0x5A62FB0", VA = "0x185A643B0")]
		public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
		{
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x5A645F0", Offset = "0x5A631F0", VA = "0x185A645F0")]
		public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
		{
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x5A641A0", Offset = "0x5A62DA0", VA = "0x185A641A0")]
		private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices)
		{
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x5A5F4C0", Offset = "0x5A5E0C0", VA = "0x185A5F4C0")]
		internal List<UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh)
		{
			return null;
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x600135E")]
		[Address(RVA = "0x5A638E0", Offset = "0x5A624E0", VA = "0x185A638E0")]
		private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
		{
			return default(bool);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x5A60130", Offset = "0x5A5ED30", VA = "0x185A60130")]
		private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
		{
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x5A63A80", Offset = "0x5A62680", VA = "0x185A63A80")]
		private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out UIRenderDevice.AllocToUpdate allocToUpdate, bool copyBackIndices)
		{
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x5A62110", Offset = "0x5A60D10", VA = "0x185A62110")]
		public void Free(MeshHandle mesh)
		{
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x5A62810", Offset = "0x5A61410", VA = "0x185A62810")]
		private static Vector4 GetClipSpaceParams()
		{
			return default(Vector4);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x5A62F40", Offset = "0x5A61B40", VA = "0x185A62F40")]
		public void OnFrameRenderingBegin()
		{
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6001364")]
		private unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : struct
		{
			return default(NativeSlice<T>);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x5A60BB0", Offset = "0x5A5F7B0", VA = "0x185A60BB0")]
		[MethodImpl(256)]
		private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, bool newFontDiffers, ref UIRenderDevice.EvaluationState st)
		{
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x5A609E0", Offset = "0x5A5F5E0", VA = "0x185A609E0")]
		private void ApplyBatchState(ref UIRenderDevice.EvaluationState st, bool allowMaterialChange)
		{
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001367")]
		[Address(RVA = "0x5A611B0", Offset = "0x5A5FDB0", VA = "0x185A611B0")]
		public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException)
		{
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001368")]
		[Address(RVA = "0x5A642F0", Offset = "0x5A62EF0", VA = "0x185A642F0")]
		private void UpdateFenceValue()
		{
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001369")]
		[Address(RVA = "0x5A62BF0", Offset = "0x5A617F0", VA = "0x185A62BF0")]
		private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage)
		{
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136A")]
		private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) where I : struct where T : struct
		{
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136B")]
		[Address(RVA = "0x5A648D0", Offset = "0x5A634D0", VA = "0x185A648D0")]
		private void WaitOnCpuFence(uint fence)
		{
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136C")]
		[Address(RVA = "0x5A5F530", Offset = "0x5A5E130", VA = "0x185A5F530")]
		public void AdvanceFrame()
		{
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136D")]
		[Address(RVA = "0x5A636F0", Offset = "0x5A622F0", VA = "0x185A636F0")]
		private void PruneUnusedPages()
		{
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x5A63050", Offset = "0x5A61C50", VA = "0x185A63050")]
		internal static void PrepareForGfxDeviceRecreate()
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x5A649A0", Offset = "0x5A635A0", VA = "0x185A649A0")]
		internal static void WrapUpGfxDeviceRecreate()
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x5A620A0", Offset = "0x5A60CA0", VA = "0x185A620A0")]
		internal static void FlushAllPendingDeviceDisposes()
		{
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x5A627F0", Offset = "0x5A613F0", VA = "0x185A627F0")]
		internal UIRenderDevice.DrawStatistics GatherDrawStatistics()
		{
			return default(UIRenderDevice.DrawStatistics);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x5A63240", Offset = "0x5A61E40", VA = "0x185A63240")]
		private static void ProcessDeviceFreeQueue()
		{
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x5A62EA0", Offset = "0x5A61AA0", VA = "0x185A62EA0")]
		private static void OnEngineUpdateGlobal()
		{
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001374")]
		[Address(RVA = "0x5A62EE0", Offset = "0x5A61AE0", VA = "0x185A62EE0")]
		private static void OnFlushPendingResources()
		{
		}

		// Token: 0x04000ADA RID: 2778
		[Token(Token = "0x4000ADA")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool m_MockDevice;

		// Token: 0x04000ADB RID: 2779
		[Token(Token = "0x4000ADB")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_DefaultStencilState;

		// Token: 0x04000ADC RID: 2780
		[Token(Token = "0x4000ADC")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_VertexDecl;

		// Token: 0x04000ADD RID: 2781
		[Token(Token = "0x4000ADD")]
		[FieldOffset(Offset = "0x28")]
		private Page m_FirstPage;

		// Token: 0x04000ADE RID: 2782
		[Token(Token = "0x4000ADE")]
		[FieldOffset(Offset = "0x30")]
		private uint m_NextPageVertexCount;

		// Token: 0x04000ADF RID: 2783
		[Token(Token = "0x4000ADF")]
		[FieldOffset(Offset = "0x34")]
		private uint m_LargeMeshVertexCount;

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x38")]
		private float m_IndexToVertexCountRatio;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x40")]
		private List<List<UIRenderDevice.AllocToFree>> m_DeferredFrees;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x48")]
		private List<List<UIRenderDevice.AllocToUpdate>> m_Updates;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x50")]
		private uint[] m_Fences;

		// Token: 0x04000AE4 RID: 2788
		[Token(Token = "0x4000AE4")]
		[FieldOffset(Offset = "0x58")]
		private MaterialPropertyBlock m_StandardMatProps;

		// Token: 0x04000AE5 RID: 2789
		[Token(Token = "0x4000AE5")]
		[FieldOffset(Offset = "0x60")]
		private uint m_FrameIndex;

		// Token: 0x04000AE6 RID: 2790
		[Token(Token = "0x4000AE6")]
		[FieldOffset(Offset = "0x64")]
		private uint m_NextUpdateID;

		// Token: 0x04000AE7 RID: 2791
		[Token(Token = "0x4000AE7")]
		[FieldOffset(Offset = "0x68")]
		private UIRenderDevice.DrawStatistics m_DrawStats;

		// Token: 0x04000AE8 RID: 2792
		[Token(Token = "0x4000AE8")]
		[FieldOffset(Offset = "0x90")]
		private readonly LinkedPool<MeshHandle> m_MeshHandles;

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x98")]
		private readonly DrawParams m_DrawParams;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0xA0")]
		private readonly TextureSlotManager m_TextureSlotManager;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x0")]
		private static LinkedList<UIRenderDevice.DeviceToFree> m_DeviceFreeQueue;

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0x8")]
		private static int m_ActiveDeviceCount;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0xC")]
		private static bool m_SubscribedToNotifications;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0xD")]
		private static bool m_SynchronousFree;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int s_FontTexPropID;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int s_FontTexSDFScaleID;

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int s_GradientSettingsTexID;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int s_ShaderInfoTexID;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int s_TransformsPropID;

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int s_ClipRectsPropID;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int s_ClipSpaceParamsID;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker s_MarkerAllocate;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x38")]
		private static ProfilerMarker s_MarkerFree;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x40")]
		private static ProfilerMarker s_MarkerAdvanceFrame;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x48")]
		private static ProfilerMarker s_MarkerFence;

		// Token: 0x04000AFA RID: 2810
		[Token(Token = "0x4000AFA")]
		[FieldOffset(Offset = "0x50")]
		private static ProfilerMarker s_MarkerBeforeDraw;

		// Token: 0x04000AFB RID: 2811
		[Token(Token = "0x4000AFB")]
		[FieldOffset(Offset = "0x58")]
		private static bool? s_VertexTexturingIsAvailable;

		// Token: 0x04000AFC RID: 2812
		[Token(Token = "0x4000AFC")]
		[FieldOffset(Offset = "0x5A")]
		private static bool? s_ShaderModelIs35;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0x60")]
		private static Texture2D s_DefaultShaderInfoTexFloat;

		// Token: 0x04000B00 RID: 2816
		[Token(Token = "0x4000B00")]
		[FieldOffset(Offset = "0x68")]
		private static Texture2D s_DefaultShaderInfoTexARGB8;

		// Token: 0x020002C7 RID: 711
		[Token(Token = "0x20002C7")]
		internal struct AllocToUpdate
		{
			// Token: 0x04000B02 RID: 2818
			[Token(Token = "0x4000B02")]
			[FieldOffset(Offset = "0x0")]
			public uint id;

			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			[FieldOffset(Offset = "0x4")]
			public uint allocTime;

			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			[FieldOffset(Offset = "0x8")]
			public MeshHandle meshHandle;

			// Token: 0x04000B05 RID: 2821
			[Token(Token = "0x4000B05")]
			[FieldOffset(Offset = "0x10")]
			public Alloc permAllocVerts;

			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			[FieldOffset(Offset = "0x28")]
			public Alloc permAllocIndices;

			// Token: 0x04000B07 RID: 2823
			[Token(Token = "0x4000B07")]
			[FieldOffset(Offset = "0x40")]
			public Page permPage;

			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4000B08")]
			[FieldOffset(Offset = "0x48")]
			public bool copyBackIndices;
		}

		// Token: 0x020002C8 RID: 712
		[Token(Token = "0x20002C8")]
		private struct AllocToFree
		{
			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4000B09")]
			[FieldOffset(Offset = "0x0")]
			public Alloc alloc;

			// Token: 0x04000B0A RID: 2826
			[Token(Token = "0x4000B0A")]
			[FieldOffset(Offset = "0x18")]
			public Page page;

			// Token: 0x04000B0B RID: 2827
			[Token(Token = "0x4000B0B")]
			[FieldOffset(Offset = "0x20")]
			public bool vertices;
		}

		// Token: 0x020002C9 RID: 713
		[Token(Token = "0x20002C9")]
		private struct DeviceToFree
		{
			// Token: 0x06001375 RID: 4981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001375")]
			[Address(RVA = "0x5A58210", Offset = "0x5A56E10", VA = "0x185A58210")]
			public void Dispose()
			{
			}

			// Token: 0x04000B0C RID: 2828
			[Token(Token = "0x4000B0C")]
			[FieldOffset(Offset = "0x0")]
			public uint handle;

			// Token: 0x04000B0D RID: 2829
			[Token(Token = "0x4000B0D")]
			[FieldOffset(Offset = "0x8")]
			public Page page;
		}

		// Token: 0x020002CA RID: 714
		[Token(Token = "0x20002CA")]
		private struct EvaluationState
		{
			// Token: 0x04000B0E RID: 2830
			[Token(Token = "0x4000B0E")]
			[FieldOffset(Offset = "0x0")]
			public MaterialPropertyBlock stateMatProps;

			// Token: 0x04000B0F RID: 2831
			[Token(Token = "0x4000B0F")]
			[FieldOffset(Offset = "0x8")]
			public Material defaultMat;

			// Token: 0x04000B10 RID: 2832
			[Token(Token = "0x4000B10")]
			[FieldOffset(Offset = "0x10")]
			public State curState;

			// Token: 0x04000B11 RID: 2833
			[Token(Token = "0x4000B11")]
			[FieldOffset(Offset = "0x30")]
			public Page curPage;

			// Token: 0x04000B12 RID: 2834
			[Token(Token = "0x4000B12")]
			[FieldOffset(Offset = "0x38")]
			public bool mustApplyMaterial;

			// Token: 0x04000B13 RID: 2835
			[Token(Token = "0x4000B13")]
			[FieldOffset(Offset = "0x39")]
			public bool mustApplyCommonBlock;

			// Token: 0x04000B14 RID: 2836
			[Token(Token = "0x4000B14")]
			[FieldOffset(Offset = "0x3A")]
			public bool mustApplyStateBlock;

			// Token: 0x04000B15 RID: 2837
			[Token(Token = "0x4000B15")]
			[FieldOffset(Offset = "0x3B")]
			public bool mustApplyStencil;
		}

		// Token: 0x020002CB RID: 715
		[Token(Token = "0x20002CB")]
		internal struct DrawStatistics
		{
			// Token: 0x04000B16 RID: 2838
			[Token(Token = "0x4000B16")]
			[FieldOffset(Offset = "0x0")]
			public int currentFrameIndex;

			// Token: 0x04000B17 RID: 2839
			[Token(Token = "0x4000B17")]
			[FieldOffset(Offset = "0x4")]
			public uint totalIndices;

			// Token: 0x04000B18 RID: 2840
			[Token(Token = "0x4000B18")]
			[FieldOffset(Offset = "0x8")]
			public uint commandCount;

			// Token: 0x04000B19 RID: 2841
			[Token(Token = "0x4000B19")]
			[FieldOffset(Offset = "0xC")]
			public uint drawCommandCount;

			// Token: 0x04000B1A RID: 2842
			[Token(Token = "0x4000B1A")]
			[FieldOffset(Offset = "0x10")]
			public uint materialSetCount;

			// Token: 0x04000B1B RID: 2843
			[Token(Token = "0x4000B1B")]
			[FieldOffset(Offset = "0x14")]
			public uint drawRangeCount;

			// Token: 0x04000B1C RID: 2844
			[Token(Token = "0x4000B1C")]
			[FieldOffset(Offset = "0x18")]
			public uint drawRangeCallCount;

			// Token: 0x04000B1D RID: 2845
			[Token(Token = "0x4000B1D")]
			[FieldOffset(Offset = "0x1C")]
			public uint immediateDraws;

			// Token: 0x04000B1E RID: 2846
			[Token(Token = "0x4000B1E")]
			[FieldOffset(Offset = "0x20")]
			public uint stencilRefChanges;
		}
	}
}
