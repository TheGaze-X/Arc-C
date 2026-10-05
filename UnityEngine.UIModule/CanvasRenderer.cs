using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[NativeHeader("Modules/UI/CanvasRenderer.h")]
	[NativeClass("UI::CanvasRenderer")]
	public sealed class CanvasRenderer : Component
	{
		// Token: 0x17000005 RID: 5
		// (set) Token: 0x0600000C RID: 12
		[Token(Token = "0x17000005")]
		public extern bool hasPopInstruction { [Token(Token = "0x600000C")] [Address(RVA = "0x5B520E0", Offset = "0x5B50CE0", VA = "0x185B520E0")] [MethodImpl(4096)] set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13
		// (set) Token: 0x0600000E RID: 14
		[Token(Token = "0x17000006")]
		public extern int materialCount { [Token(Token = "0x600000D")] [Address(RVA = "0x5B51F70", Offset = "0x5B50B70", VA = "0x185B51F70")] [MethodImpl(4096)] get; [Token(Token = "0x600000E")] [Address(RVA = "0x5B52130", Offset = "0x5B50D30", VA = "0x185B52130")] [MethodImpl(4096)] set; }

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x0600000F RID: 15
		[Token(Token = "0x17000007")]
		public extern int popMaterialCount { [Token(Token = "0x600000F")] [Address(RVA = "0x5B52170", Offset = "0x5B50D70", VA = "0x185B52170")] [MethodImpl(4096)] set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16
		[Token(Token = "0x17000008")]
		public extern int absoluteDepth { [Token(Token = "0x6000010")] [Address(RVA = "0x5B51E70", Offset = "0x5B50A70", VA = "0x185B51E70")] [MethodImpl(4096)] get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000011 RID: 17
		[Token(Token = "0x17000009")]
		public extern bool hasMoved { [Token(Token = "0x6000011")] [Address(RVA = "0x5B51F30", Offset = "0x5B50B30", VA = "0x185B51F30")] [MethodImpl(4096)] get; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		[Token(Token = "0x1700000A")]
		public extern bool cullTransparentMesh { [Token(Token = "0x6000012")] [Address(RVA = "0x5B51EB0", Offset = "0x5B50AB0", VA = "0x185B51EB0")] [MethodImpl(4096)] get; [Token(Token = "0x6000013")] [Address(RVA = "0x5B52040", Offset = "0x5B50C40", VA = "0x185B52040")] [MethodImpl(4096)] set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		[Token(Token = "0x1700000B")]
		[NativeProperty("ShouldCull", false, TargetType.Function)]
		public extern bool cull { [Token(Token = "0x6000014")] [Address(RVA = "0x5B51EF0", Offset = "0x5B50AF0", VA = "0x185B51EF0")] [MethodImpl(4096)] get; [Token(Token = "0x6000015")] [Address(RVA = "0x5B52090", Offset = "0x5B50C90", VA = "0x185B52090")] [MethodImpl(4096)] set; }

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5B51A90", Offset = "0x5B50690", VA = "0x185B51A90")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5B51920", Offset = "0x5B50520", VA = "0x185B51920")]
		public Color GetColor()
		{
			return default(Color);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5B51830", Offset = "0x5B50430", VA = "0x185B51830")]
		public void EnableRectClipping(Rect rect)
		{
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000C")]
		public Vector2 clippingSoftness
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x5B52000", Offset = "0x5B50C00", VA = "0x185B52000")]
			set
			{
			}
		}

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5B517A0", Offset = "0x5B503A0", VA = "0x185B517A0")]
		[MethodImpl(4096)]
		public extern void DisableRectClipping();

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x5B51BF0", Offset = "0x5B507F0", VA = "0x185B51BF0")]
		[MethodImpl(4096)]
		public extern void SetMaterial(Material material, int index);

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x5B519B0", Offset = "0x5B505B0", VA = "0x185B519B0")]
		[MethodImpl(4096)]
		public extern Material GetMaterial(int index);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x5B51CA0", Offset = "0x5B508A0", VA = "0x185B51CA0")]
		[MethodImpl(4096)]
		public extern void SetPopMaterial(Material material, int index);

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x5B51D00", Offset = "0x5B50900", VA = "0x185B51D00")]
		[MethodImpl(4096)]
		public extern void SetTexture(Texture texture);

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5B519F0", Offset = "0x5B505F0", VA = "0x185B519F0")]
		[MethodImpl(4096)]
		public extern void SetAlphaTexture(Texture texture);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x5B51C50", Offset = "0x5B50850", VA = "0x185B51C50")]
		[MethodImpl(4096)]
		public extern void SetMesh(Mesh mesh);

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5B516F0", Offset = "0x5B502F0", VA = "0x185B516F0")]
		[MethodImpl(4096)]
		public extern void Clear();

		// Token: 0x06000022 RID: 34 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5B51880", Offset = "0x5B50480", VA = "0x185B51880")]
		public float GetAlpha()
		{
			return 0f;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x5B51AE0", Offset = "0x5B506E0", VA = "0x185B51AE0")]
		public void SetMaterial(Material material, Texture texture)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x5B51970", Offset = "0x5B50570", VA = "0x185B51970")]
		public Material GetMaterial()
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x5B51DA0", Offset = "0x5B509A0", VA = "0x185B51DA0")]
		public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x5B51730", Offset = "0x5B50330", VA = "0x185B51730")]
		public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x5B51680", Offset = "0x5B50280", VA = "0x185B51680")]
		public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
		{
		}

		// Token: 0x06000028 RID: 40
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x5B51D50", Offset = "0x5B50950", VA = "0x185B51D50")]
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void SplitIndicesStreamsInternal(object verts, object indices);

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5B51680", Offset = "0x5B50280", VA = "0x185B51680")]
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents);

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5B51730", Offset = "0x5B50330", VA = "0x185B51730")]
		[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
		[MethodImpl(4096)]
		private static extern void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices);

		// Token: 0x0600002B RID: 43
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5B51A40", Offset = "0x5B50640", VA = "0x185B51A40")]
		[MethodImpl(4096)]
		private extern void SetColor_Injected(ref Color color);

		// Token: 0x0600002C RID: 44
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5B518D0", Offset = "0x5B504D0", VA = "0x185B518D0")]
		[MethodImpl(4096)]
		private extern void GetColor_Injected(out Color ret);

		// Token: 0x0600002D RID: 45
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5B517E0", Offset = "0x5B503E0", VA = "0x185B517E0")]
		[MethodImpl(4096)]
		private extern void EnableRectClipping_Injected(ref Rect rect);

		// Token: 0x0600002E RID: 46
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5B51FB0", Offset = "0x5B50BB0", VA = "0x185B51FB0")]
		[MethodImpl(4096)]
		private extern void set_clippingSoftness_Injected(ref Vector2 value);
	}
}
