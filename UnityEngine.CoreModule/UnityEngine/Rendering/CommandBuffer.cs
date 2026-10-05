using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
	[NativeHeader("Runtime/Shaders/RayTracingShader.h")]
	public class CommandBuffer : IDisposable
	{
		// Token: 0x06000D9C RID: 3484
		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x597CF50", Offset = "0x597BB50", VA = "0x18597CF50")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Internal_SetSinglePassStereo(SinglePassStereoMode mode);

		// Token: 0x06000D9D RID: 3485
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x597CC70", Offset = "0x597B870", VA = "0x18597CC70")]
		[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
		[MethodImpl(4096)]
		private static extern IntPtr InitBuffer();

		// Token: 0x06000D9E RID: 3486
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x597CF90", Offset = "0x597BB90", VA = "0x18597CF90")]
		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = true, IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void ReleaseBuffer();

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x597D1F0", Offset = "0x597BDF0", VA = "0x18597D1F0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeVectorParam", HasExplicitThis = true)]
		public void SetComputeVectorParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, Vector4 val)
		{
		}

		// Token: 0x06000DA0 RID: 3488
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x597CE70", Offset = "0x597BA70", VA = "0x18597CE70")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Internal_SetComputeFloats([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] float[] values);

		// Token: 0x06000DA1 RID: 3489
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x597CEE0", Offset = "0x597BAE0", VA = "0x18597CEE0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Internal_SetComputeTextureParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element);

		// Token: 0x06000DA2 RID: 3490
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x597CE00", Offset = "0x597BA00", VA = "0x18597CE00")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void Internal_SetComputeBufferParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, ComputeBuffer buffer);

		// Token: 0x06000DA3 RID: 3491
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x597B890", Offset = "0x597A490", VA = "0x18597B890")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void Internal_DispatchCompute([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);

		// Token: 0x170002B5 RID: 693
		// (set) Token: 0x06000DA4 RID: 3492
		[Token(Token = "0x170002B5")]
		public extern string name { [Token(Token = "0x6000DA4")] [Address(RVA = "0x597E3B0", Offset = "0x597CFB0", VA = "0x18597E3B0")] [MethodImpl(4096)] set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000DA5 RID: 3493
		[Token(Token = "0x170002B6")]
		public extern int sizeInBytes { [Token(Token = "0x6000DA5")] [Address(RVA = "0x597E370", Offset = "0x597CF70", VA = "0x18597E370")] [NativeMethod("GetBufferSize")] [MethodImpl(4096)] get; }

		// Token: 0x06000DA6 RID: 3494
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x597B500", Offset = "0x597A100", VA = "0x18597B500")]
		[NativeMethod("ClearCommands")]
		[MethodImpl(4096)]
		public extern void Clear();

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x597CD10", Offset = "0x597B910", VA = "0x18597CD10")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = true)]
		private void Internal_DrawMesh([NotNull("ArgumentNullException")] Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		// Token: 0x06000DA8 RID: 3496
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x597CD90", Offset = "0x597B990", VA = "0x18597CD90")]
		[NativeMethod("AddDrawRenderer")]
		[MethodImpl(4096)]
		private extern void Internal_DrawRenderer([NotNull("ArgumentNullException")] Renderer renderer, Material material, int submeshIndex, int shaderPass);

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x597E290", Offset = "0x597CE90", VA = "0x18597E290")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = true, ThrowsException = true)]
		public void SetViewport(Rect pixelRect)
		{
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x597C0C0", Offset = "0x597ACC0", VA = "0x18597C0C0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		public void EnableScissorRect(Rect scissor)
		{
		}

		// Token: 0x06000DAB RID: 3499
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x597B800", Offset = "0x597A400", VA = "0x18597B800")]
		[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void DisableScissorRect();

		// Token: 0x06000DAC RID: 3500
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x597B540", Offset = "0x597A140", VA = "0x18597B540")]
		[FreeFunction("RenderingCommandBuffer_Bindings::CopyTexture_Internal", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void CopyTexture_Internal(ref RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x597AD50", Offset = "0x5979950", VA = "0x18597AD50")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = true)]
		private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x597AC40", Offset = "0x5979840", VA = "0x18597AC40")]
		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = true)]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		// Token: 0x06000DAF RID: 3503
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x597C9D0", Offset = "0x597B5D0", VA = "0x18597C9D0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRT", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale);

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x597C6C0", Offset = "0x597B2C0", VA = "0x18597C6C0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x597C320", Offset = "0x597AF20", VA = "0x18597C320")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x597C7C0", Offset = "0x597B3C0", VA = "0x18597C7C0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x597C3D0", Offset = "0x597AFD0", VA = "0x18597C3D0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale)
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x597C8D0", Offset = "0x597B4D0", VA = "0x18597C8D0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x597CAD0", Offset = "0x597B6D0", VA = "0x18597CAD0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x597C5D0", Offset = "0x597B1D0", VA = "0x18597C5D0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x597C4E0", Offset = "0x597B0E0", VA = "0x18597C4E0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x597CBD0", Offset = "0x597B7D0", VA = "0x18597CBD0")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x597CA60", Offset = "0x597B660", VA = "0x18597CA60")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter)
		{
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x597C860", Offset = "0x597B460", VA = "0x18597C860")]
		public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x597C2C0", Offset = "0x597AEC0", VA = "0x18597C2C0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = true)]
		private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x597C740", Offset = "0x597B340", VA = "0x18597C740")]
		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		// Token: 0x06000DBD RID: 3517
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x597CFD0", Offset = "0x597BBD0", VA = "0x18597CFD0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void ReleaseTemporaryRT(int nameID);

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x597B490", Offset = "0x597A090", VA = "0x18597B490")]
		[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = true)]
		public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x597B3D0", Offset = "0x5979FD0", VA = "0x18597B3D0")]
		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		// Token: 0x06000DC0 RID: 3520
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x597D2D0", Offset = "0x597BED0", VA = "0x18597D2D0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetGlobalFloat(int nameID, float value);

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x597D5D0", Offset = "0x597C1D0", VA = "0x18597D5D0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = true)]
		public void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		// Token: 0x06000DC2 RID: 3522
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x597C110", Offset = "0x597AD10", VA = "0x18597C110")]
		[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void EnableShaderKeyword(string keyword);

		// Token: 0x06000DC3 RID: 3523
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x597B840", Offset = "0x597A440", VA = "0x18597B840")]
		[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void DisableShaderKeyword(string keyword);

		// Token: 0x06000DC4 RID: 3524
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x597E2E0", Offset = "0x597CEE0", VA = "0x18597E2E0")]
		[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags);

		// Token: 0x06000DC5 RID: 3525
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x597D380", Offset = "0x597BF80", VA = "0x18597D380")]
		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element);

		// Token: 0x06000DC6 RID: 3526
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x597AB80", Offset = "0x5979780", VA = "0x18597AB80")]
		[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void BeginSample(string name);

		// Token: 0x06000DC7 RID: 3527
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x597C160", Offset = "0x597AD60", VA = "0x18597C160")]
		[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void EndSample(string name);

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x597DA80", Offset = "0x597C680", VA = "0x18597DA80")]
		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x597DF00", Offset = "0x597CB00", VA = "0x18597DF00")]
		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x597DB20", Offset = "0x597C720", VA = "0x18597DB20")]
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x597DCC0", Offset = "0x597C8C0", VA = "0x18597DCC0")]
		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x597D910", Offset = "0x597C510", VA = "0x18597D910")]
		public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x597E010", Offset = "0x597CC10", VA = "0x18597E010")]
		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth)
		{
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x597D890", Offset = "0x597C490", VA = "0x18597D890")]
		private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x597D690", Offset = "0x597C290", VA = "0x18597D690")]
		private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x597D790", Offset = "0x597C390", VA = "0x18597D790")]
		private void SetRenderTargetMulti_Internal(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x597C1B0", Offset = "0x597ADB0", VA = "0x18597C1B0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x597B900", Offset = "0x597A500", VA = "0x18597B900", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x597B9A0", Offset = "0x597A5A0", VA = "0x18597B9A0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x597E330", Offset = "0x597CF30", VA = "0x18597E330")]
		public CommandBuffer()
		{
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x597B900", Offset = "0x597A500", VA = "0x18597B900")]
		public void Release()
		{
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x597D260", Offset = "0x597BE60", VA = "0x18597D260")]
		public void SetComputeVectorParam(ComputeShader computeShader, string name, Vector4 val)
		{
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x597D080", Offset = "0x597BC80", VA = "0x18597D080")]
		public void SetComputeFloatParams(ComputeShader computeShader, string name, params float[] values)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x597D0F0", Offset = "0x597BCF0", VA = "0x18597D0F0")]
		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x597D010", Offset = "0x597BC10", VA = "0x18597D010")]
		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, string name, ComputeBuffer buffer)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x597B890", Offset = "0x597A490", VA = "0x18597B890")]
		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x597BB40", Offset = "0x597A740", VA = "0x18597BB40")]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x597BA70", Offset = "0x597A670", VA = "0x18597BA70")]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x597BA10", Offset = "0x597A610", VA = "0x18597BA10")]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x597BAE0", Offset = "0x597A6E0", VA = "0x18597BAE0")]
		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x597BE10", Offset = "0x597AA10", VA = "0x18597BE10")]
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x597C020", Offset = "0x597AC20", VA = "0x18597C020")]
		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x597C040", Offset = "0x597AC40", VA = "0x18597C040")]
		public void DrawRenderer(Renderer renderer, Material material)
		{
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x597B690", Offset = "0x597A290", VA = "0x18597B690")]
		public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x597B740", Offset = "0x597A340", VA = "0x18597B740")]
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, RenderTargetIdentifier dst, int dstElement, int dstMip)
		{
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x597B5B0", Offset = "0x597A1B0", VA = "0x18597B5B0")]
		public void CopyTexture(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x597B0C0", Offset = "0x5979CC0", VA = "0x18597B0C0")]
		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x597ADF0", Offset = "0x59799F0", VA = "0x18597ADF0")]
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x597AEE0", Offset = "0x5979AE0", VA = "0x18597AEE0")]
		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass)
		{
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x597B290", Offset = "0x5979E90", VA = "0x18597B290")]
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x597B1A0", Offset = "0x5979DA0", VA = "0x18597B1A0")]
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x597AFD0", Offset = "0x5979BD0", VA = "0x18597AFD0")]
		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x597D320", Offset = "0x597BF20", VA = "0x18597D320")]
		public void SetGlobalFloat(string name, float value)
		{
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x597D570", Offset = "0x597C170", VA = "0x18597D570")]
		public void SetGlobalVector(string name, Vector4 value)
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x597D4A0", Offset = "0x597C0A0", VA = "0x18597D4A0")]
		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x597D440", Offset = "0x597C040", VA = "0x18597D440")]
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEF")]
		[Address(RVA = "0x597D3E0", Offset = "0x597BFE0", VA = "0x18597D3E0")]
		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF0")]
		[Address(RVA = "0x597CF50", Offset = "0x597BB50", VA = "0x18597CF50")]
		public void SetSinglePassStereo(SinglePassStereoMode mode)
		{
		}

		// Token: 0x06000DF1 RID: 3569
		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x597D180", Offset = "0x597BD80", VA = "0x18597D180")]
		[MethodImpl(4096)]
		private extern void SetComputeVectorParam_Injected(ComputeShader computeShader, int nameID, ref Vector4 val);

		// Token: 0x06000DF2 RID: 3570
		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x597CCA0", Offset = "0x597B8A0", VA = "0x18597CCA0")]
		[MethodImpl(4096)]
		private extern void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties);

		// Token: 0x06000DF3 RID: 3571
		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x597E240", Offset = "0x597CE40", VA = "0x18597E240")]
		[MethodImpl(4096)]
		private extern void SetViewport_Injected(ref Rect pixelRect);

		// Token: 0x06000DF4 RID: 3572
		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x597C070", Offset = "0x597AC70", VA = "0x18597C070")]
		[MethodImpl(4096)]
		private extern void EnableScissorRect_Injected(ref Rect scissor);

		// Token: 0x06000DF5 RID: 3573
		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x597ACE0", Offset = "0x59798E0", VA = "0x18597ACE0")]
		[MethodImpl(4096)]
		private extern void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x06000DF6 RID: 3574
		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x597ABD0", Offset = "0x59797D0", VA = "0x18597ABD0")]
		[MethodImpl(4096)]
		private extern void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice);

		// Token: 0x06000DF7 RID: 3575
		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x597C260", Offset = "0x597AE60", VA = "0x18597C260")]
		[MethodImpl(4096)]
		private extern void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter);

		// Token: 0x06000DF8 RID: 3576
		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x597B370", Offset = "0x5979F70", VA = "0x18597B370")]
		[MethodImpl(4096)]
		private extern void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil);

		// Token: 0x06000DF9 RID: 3577
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x597D520", Offset = "0x597C120", VA = "0x18597D520")]
		[MethodImpl(4096)]
		private extern void SetGlobalVector_Injected(int nameID, ref Vector4 value);

		// Token: 0x06000DFA RID: 3578
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x597D820", Offset = "0x597C420", VA = "0x18597D820")]
		[MethodImpl(4096)]
		private extern void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction);

		// Token: 0x06000DFB RID: 3579
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x597D620", Offset = "0x597C220", VA = "0x18597D620")]
		[MethodImpl(4096)]
		private extern void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags);

		// Token: 0x06000DFC RID: 3580
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x597D720", Offset = "0x597C320", VA = "0x18597D720")]
		[MethodImpl(4096)]
		private extern void SetRenderTargetMulti_Internal_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags);

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
