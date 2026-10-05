using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
	[NativeHeader("Runtime/Graphics/CopyTexture.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	public class Graphics
	{
		// Token: 0x060002DE RID: 734
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x592B5B0", Offset = "0x592A1B0", VA = "0x18592B5B0")]
		[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount")]
		[MethodImpl(4096)]
		private static extern int Internal_GetMaxDrawMeshInstanceCount();

		// Token: 0x060002DF RID: 735
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x592B6F0", Offset = "0x592A2F0", VA = "0x18592B6F0")]
		[FreeFunction("GraphicsScripting::SetNullRT")]
		[MethodImpl(4096)]
		private static extern void Internal_SetNullRT();

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x592B790", Offset = "0x592A390", VA = "0x18592B790")]
		[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = true, ThrowsException = true)]
		private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x592B650", Offset = "0x592A250", VA = "0x18592B650")]
		[NativeMethod(Name = "GraphicsScripting::SetMRTSimple", IsFreeFunction = true, ThrowsException = true)]
		private static void Internal_SetMRTSimple([NotNull("ArgumentNullException")] RenderBuffer[] color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}

		// Token: 0x060002E2 RID: 738
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x592B830", Offset = "0x592A430", VA = "0x18592B830")]
		[FreeFunction("GraphicsScripting::SetRandomWriteTargetBuffer")]
		[MethodImpl(4096)]
		private static extern void Internal_SetRandomWriteTargetBuffer(int index, ComputeBuffer uav, bool preserveCounterValue);

		// Token: 0x060002E3 RID: 739
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x592A920", Offset = "0x5929520", VA = "0x18592A920")]
		[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
		[MethodImpl(4096)]
		public static extern void ClearRandomWriteTargets();

		// Token: 0x060002E4 RID: 740
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x592A950", Offset = "0x5929550", VA = "0x18592A950")]
		[FreeFunction("CopyTexture")]
		[MethodImpl(4096)]
		private static extern void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY);

		// Token: 0x060002E5 RID: 741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x592B310", Offset = "0x5929F10", VA = "0x18592B310")]
		[FreeFunction("GraphicsScripting::DrawMeshNow")]
		private static void Internal_DrawMeshNow2([NotNull("NullExceptionObject")] Mesh mesh, int subsetIndex, Matrix4x4 matrix)
		{
		}

		// Token: 0x060002E6 RID: 742
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x592B570", Offset = "0x592A170", VA = "0x18592B570")]
		[VisibleToOtherModules(new string[]
		{
			"UnityEngine.IMGUIModule"
		})]
		[FreeFunction("GraphicsScripting::DrawTexture")]
		[MethodImpl(4096)]
		internal static extern void Internal_DrawTexture(ref Internal_DrawTextureArguments args);

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x592B420", Offset = "0x592A020", VA = "0x18592B420")]
		[FreeFunction("GraphicsScripting::DrawMesh")]
		private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		// Token: 0x060002E8 RID: 744
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x592B520", Offset = "0x592A120", VA = "0x18592B520")]
		[FreeFunction("GraphicsScripting::DrawProceduralIndirectNow")]
		[MethodImpl(4096)]
		private static extern void Internal_DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset);

		// Token: 0x060002E9 RID: 745
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x592B1E0", Offset = "0x5929DE0", VA = "0x18592B1E0")]
		[FreeFunction("GraphicsScripting::BlitMaterial")]
		[MethodImpl(4096)]
		private static extern void Internal_BlitMaterial5(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, int pass, bool setRT);

		// Token: 0x060002EA RID: 746
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x592B250", Offset = "0x5929E50", VA = "0x18592B250")]
		[FreeFunction("GraphicsScripting::BlitMultitap")]
		[MethodImpl(4096)]
		private static extern void Internal_BlitMultiTap4(Texture source, RenderTexture dest, [NotNull("ArgumentNullException")] Material mat, [NotNull("ArgumentNullException")] Vector2[] offsets);

		// Token: 0x060002EB RID: 747
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x592A5E0", Offset = "0x59291E0", VA = "0x18592A5E0")]
		[FreeFunction("GraphicsScripting::Blit")]
		[MethodImpl(4096)]
		private static extern void Blit2(Texture source, RenderTexture dest);

		// Token: 0x060002EC RID: 748
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x592B1A0", Offset = "0x5929DA0", VA = "0x18592B1A0")]
		[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public static extern void ExecuteCommandBuffer([NotNull("ArgumentNullException")] CommandBuffer buffer);

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x592BDD0", Offset = "0x592A9D0", VA = "0x18592BDD0")]
		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x592BBE0", Offset = "0x592A7E0", VA = "0x18592BBE0")]
		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x592BB00", Offset = "0x592A700", VA = "0x18592BB00")]
		internal static void SetRenderTargetImpl(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x592C010", Offset = "0x592AC10", VA = "0x18592C010")]
		public static void SetRenderTarget(RenderTexture rt, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x592BEC0", Offset = "0x592AAC0", VA = "0x18592BEC0")]
		public static void SetRenderTarget(RenderBuffer[] colorBuffers, RenderBuffer depthBuffer)
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x592B8F0", Offset = "0x592A4F0", VA = "0x18592B8F0")]
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav, [DefaultValue("false")] bool preserveCounterValue)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x592A9C0", Offset = "0x59295C0", VA = "0x18592A9C0")]
		public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY)
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x592ABF0", Offset = "0x59297F0", VA = "0x18592ABF0")]
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x592AA60", Offset = "0x5929660", VA = "0x18592AA60")]
		public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x592AEC0", Offset = "0x5929AC0", VA = "0x18592AEC0")]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, [DefaultValue("null")] LightProbeProxyVolume lightProbeProxyVolume)
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x592B0C0", Offset = "0x5929CC0", VA = "0x18592B0C0")]
		public static void DrawProceduralIndirectNow(MeshTopology topology, ComputeBuffer bufferWithArgs, int argsOffset = 0)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x592A7E0", Offset = "0x59293E0", VA = "0x18592A7E0")]
		public static void Blit(Texture source, RenderTexture dest)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x592A740", Offset = "0x5929340", VA = "0x18592A740")]
		public static void Blit(Texture source, RenderTexture dest, Material mat, [DefaultValue("-1")] int pass)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x592A860", Offset = "0x5929460", VA = "0x18592A860")]
		public static void Blit(Texture source, RenderTexture dest, Material mat)
		{
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x592A630", Offset = "0x5929230", VA = "0x18592A630")]
		public static void BlitMultiTap(Texture source, RenderTexture dest, Material mat, params Vector2[] offsets)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x592AD50", Offset = "0x5929950", VA = "0x18592AD50")]
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x592BFB0", Offset = "0x592ABB0", VA = "0x18592BFB0")]
		[ExcludeFromDocs]
		public static void SetRenderTarget(RenderTexture rt)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x592B890", Offset = "0x592A490", VA = "0x18592B890")]
		[ExcludeFromDocs]
		public static void SetRandomWriteTarget(int index, ComputeBuffer uav)
		{
		}

		// Token: 0x06000300 RID: 768
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x592B720", Offset = "0x592A320", VA = "0x18592B720")]
		[MethodImpl(4096)]
		private static extern void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x06000301 RID: 769
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x592B5E0", Offset = "0x592A1E0", VA = "0x18592B5E0")]
		[MethodImpl(4096)]
		private static extern void Internal_SetMRTSimple_Injected(RenderBuffer[] color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice);

		// Token: 0x06000302 RID: 770
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x592B2C0", Offset = "0x5929EC0", VA = "0x18592B2C0")]
		[MethodImpl(4096)]
		private static extern void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix);

		// Token: 0x06000303 RID: 771
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x592B3A0", Offset = "0x5929FA0", VA = "0x18592B3A0")]
		[MethodImpl(4096)]
		private static extern void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume);

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int kMaxDrawMeshInstanceCount;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x8")]
		internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;
	}
}
