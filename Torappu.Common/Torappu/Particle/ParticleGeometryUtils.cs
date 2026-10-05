using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using XLua;

namespace Torappu.Particle
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public static class ParticleGeometryUtils
	{
		// Token: 0x06000B29 RID: 2857 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x55559D0", Offset = "0x55545D0", VA = "0x1855559D0")]
		private static bool _MathEquals(float a, float b)
		{
			return default(bool);
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00007B44 File Offset: 0x00005D44
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x5555930", Offset = "0x5554530", VA = "0x185555930")]
		private static bool _MathEquals(Vector3 a, Vector3 b)
		{
			return default(bool);
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00007B5C File Offset: 0x00005D5C
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x55557B0", Offset = "0x55543B0", VA = "0x1855557B0")]
		private static Vector3 _GetParticleSize(ParticleSystem.Particle ps, ParticleSystem system, bool useSize3D, Vector3 scale)
		{
			return default(Vector3);
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00007B74 File Offset: 0x00005D74
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x5555A00", Offset = "0x5554600", VA = "0x185555A00")]
		private static Vector3 _NormalizeSafe(Vector3 target, Vector3 defVal)
		{
			return default(Vector3);
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00007B8C File Offset: 0x00005D8C
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x5555730", Offset = "0x5554330", VA = "0x185555730")]
		private static float _GenerateRandom(uint seed)
		{
			return 0f;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x5555B60", Offset = "0x5554760", VA = "0x185555B60")]
		private static float _NormalizeTime(float startLifeTime, float remainingLifetime)
		{
			return 0f;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x5551260", Offset = "0x554FE60", VA = "0x185551260")]
		private static void _ApplyColorGradient(uint randomSeed, float normalizeTime, ParticleSystem.MinMaxGradient gradient, ref Color32 inColor)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00007BBC File Offset: 0x00005DBC
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x5555770", Offset = "0x5554370", VA = "0x185555770")]
		private static float _GetCurveScalar(ParticleSystem.MinMaxCurve curve)
		{
			return 0f;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5550E00", Offset = "0x554FA00", VA = "0x185550E00")]
		public static ParticleGeometryUtils.BakeOutput BakeMesh(ParticleGeometryUtils.BakeInput input, Mesh targetMesh)
		{
			return default(ParticleGeometryUtils.BakeOutput);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x5551D40", Offset = "0x5550940", VA = "0x185551D40")]
		private static string _DrawMeshParticles(ParticleGeometryUtils.ContextData context)
		{
			return null;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x5558270", Offset = "0x5556E70", VA = "0x185558270")]
		private static void _TransformParticleMesh(ParticleSystem.Particle ps, int pIndex, ParticleGeometryUtils.BuiltMesh renderMesh, Matrix4x4 xform, Matrix4x4 xformnoscale, Vector3 pivot, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x5554260", Offset = "0x5552E60", VA = "0x185554260")]
		private static void _GenerateParticleGeometry(ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x55562A0", Offset = "0x5554EA0", VA = "0x1855562A0")]
		private static void _ParticleGeomBillboardFacingOrVelocity(ParticleSystemRenderSpace renderSpace, bool useRotation3D, Vector3 positionWS, Vector3 rotationEular, Vector3 velocity, Vector2 hsize, Vector3 pivot, Vector3 axisX, Vector3 axisZ, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5557420", Offset = "0x5556020", VA = "0x185557420")]
		private static void _ParticleGeomBillboardPivotOffset(bool useRotation3D, Matrix4x4 rotationWS, Vector3 positionWS, Vector3 rotationEular, Vector2 hsize, Vector3 pivot, Vector3 axisZ, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x5556BA0", Offset = "0x55557A0", VA = "0x185556BA0")]
		private static void _ParticleGeomBillboardFixed(ParticleSystemRenderMode renderMode, bool pivotOffset, Vector3 positionWS, Vector3 rotationEular, Matrix4x4 rotationWS, Vector2 hsize, Vector3 pivot, Vector3 xSpan, Vector3 ySpan, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x5557A80", Offset = "0x5556680", VA = "0x185557A80")]
		private static void _ParticleGeomStretch3D(bool pivotOffset, Vector3 positionWS, Vector3 velocity, Vector3 size, float velocityScale, float lengthScale, Vector3 pivotPercentage, Matrix4x4 transformMatrix, Matrix4x4 invTransformMatrix, Vector2 hsize, Matrix4x4 rotationWS, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x55578C0", Offset = "0x55564C0", VA = "0x1855578C0")]
		private static void _ParticleGeomFlipUVs(float flipU, float flipV, uint randomSeed, int[] uvOrder)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x5555BE0", Offset = "0x55547E0", VA = "0x185555BE0")]
		private static void _ParticleGeomAnimateUVs(float sheetIndex, Vector2[] uv, Vector4[] uv2, ParticleGeometryUtils.ContextData context)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00007BEC File Offset: 0x00005DEC
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x5551090", Offset = "0x554FC90", VA = "0x185551090")]
		public static ParticleGeometryUtils.BakeOutput BakeTrailMesh(ParticleGeometryUtils.BakeInput input, Mesh targetMesh)
		{
			return default(ParticleGeometryUtils.BakeOutput);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x5553510", Offset = "0x5552110", VA = "0x185553510")]
		private static void _DrawTrailMesh(ParticleGeometryUtils.TrailContextData context)
		{
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x55517B0", Offset = "0x55503B0", VA = "0x1855517B0")]
		private static void _BuildParticleLine(ParticleGeometryUtils.TrailContextData context, ParticleGeometryUtils.ParticleLineParameters lineParam, List<Vector3> lineVerts)
		{
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x5551340", Offset = "0x554FF40", VA = "0x185551340")]
		private static void _BuildParticleLineSegment(int i, ParticleGeometryUtils.TrailContextData context, LineBuilderData lineData, float width, float textureU, Color32 color)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5558A60", Offset = "0x5557660", VA = "0x185558A60")]
		private static void _WriteLineVertex(ParticleGeometryUtils.TrailContextData context, Vector3 viewPos, Vector2 uv, Color32 color)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5558140", Offset = "0x5556D40", VA = "0x185558140")]
		private static void _TrailAddLineTriangles(ParticleGeometryUtils.TrailContextData context, int fromVertIndex, int toVertIndex)
		{
		}

		// Token: 0x04000ABB RID: 2747
		[Token(Token = "0x4000ABB")]
		private const uint FLIP_U_ID = 693089735U;

		// Token: 0x04000ABC RID: 2748
		[Token(Token = "0x4000ABC")]
		private const uint FLIP_V_ID = 13945730U;

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		private const uint UV_START_FRAME_ID = 1454627760U;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		private const uint UV_FRAME_OVER_TIME_ID = 326370691U;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		private const uint UV_ROW_SELECTION_ID = 2941263940U;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		private const uint MESH_SELECTION_ID = 3159510623U;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		private const uint TRAIL_WIDTH_CURVE_ID = 4275844187U;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		private const uint TRAIL_LIFETIME_CURVE_ID = 884714267U;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		private const uint TRAIL_COLOR_CURVE_ID = 1827843104U;

		// Token: 0x04000AC4 RID: 2756
		[Token(Token = "0x4000AC4")]
		private const uint COLOR_GRADIENT_ID = 1494990940U;

		// Token: 0x04000AC5 RID: 2757
		[Token(Token = "0x4000AC5")]
		private const uint TRAIL_RATIO_ID = 2327835488U;

		// Token: 0x04000AC6 RID: 2758
		[Token(Token = "0x4000AC6")]
		public const float LARGE_EPS = 1E-05f;

		// Token: 0x04000AC7 RID: 2759
		[Token(Token = "0x4000AC7")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2[] UV;

		// Token: 0x04000AC8 RID: 2760
		[Token(Token = "0x4000AC8")]
		[FieldOffset(Offset = "0x8")]
		private static Vector4[] UV2;

		// Token: 0x04000AC9 RID: 2761
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x10")]
		private static int[] RECT_VERT_INDEX;

		// Token: 0x020001DD RID: 477
		[Token(Token = "0x20001DD")]
		private class Pools : SingletonInScene<ParticleGeometryUtils.Pools>
		{
			// Token: 0x17000107 RID: 263
			// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000107")]
			public LocalGenericPool<Dictionary<int, ParticleGeometryUtils.BuiltMesh>> meshDictPool
			{
				[Token(Token = "0x6000B42")]
				[Address(RVA = "0x5573AF0", Offset = "0x55726F0", VA = "0x185573AF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x5573660", Offset = "0x5572260", VA = "0x185573660")]
			private void _ReleaseMeshDict(Dictionary<int, ParticleGeometryUtils.BuiltMesh> dict)
			{
			}

			// Token: 0x06000B44 RID: 2884 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x5573810", Offset = "0x5572410", VA = "0x185573810")]
			private Pools()
			{
			}

			// Token: 0x04000ACA RID: 2762
			[Token(Token = "0x4000ACA")]
			[FieldOffset(Offset = "0x18")]
			public LocalGenericPool<ParticleGeometryUtils.BuiltMesh> meshPool;

			// Token: 0x04000ACB RID: 2763
			[Token(Token = "0x4000ACB")]
			[FieldOffset(Offset = "0x20")]
			public LocalGenericPool<ParticleGeometryUtils.ContextData> contextPool;

			// Token: 0x04000ACC RID: 2764
			[Token(Token = "0x4000ACC")]
			[FieldOffset(Offset = "0x28")]
			public LocalGenericPool<ParticleGeometryUtils.TrailContextData> trailContextPool;

			// Token: 0x04000ACD RID: 2765
			[Token(Token = "0x4000ACD")]
			[FieldOffset(Offset = "0x30")]
			private LocalGenericPool<Dictionary<int, ParticleGeometryUtils.BuiltMesh>> m_meshDictPool;

			// Token: 0x04000ACE RID: 2766
			[Token(Token = "0x4000ACE")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate245 __Hotfix0_get_meshDictPool;

			// Token: 0x04000ACF RID: 2767
			[Token(Token = "0x4000ACF")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate0 __Hotfix0__ReleaseMeshDict;

			// Token: 0x04000AD0 RID: 2768
			[Token(Token = "0x4000AD0")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
		}

		// Token: 0x020001DF RID: 479
		[Token(Token = "0x20001DF")]
		public struct BakeInput
		{
			// Token: 0x06000B48 RID: 2888 RVA: 0x00007C04 File Offset: 0x00005E04
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x5564120", Offset = "0x5562D20", VA = "0x185564120")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x04000AD3 RID: 2771
			[Token(Token = "0x4000AD3")]
			[FieldOffset(Offset = "0x0")]
			public ParticleSystem system;

			// Token: 0x04000AD4 RID: 2772
			[Token(Token = "0x4000AD4")]
			[FieldOffset(Offset = "0x8")]
			public ParticleSystemRenderer renderer;

			// Token: 0x04000AD5 RID: 2773
			[Token(Token = "0x4000AD5")]
			[FieldOffset(Offset = "0x10")]
			public Camera camera;

			// Token: 0x04000AD6 RID: 2774
			[Token(Token = "0x4000AD6")]
			[FieldOffset(Offset = "0x18")]
			public ParticleGeometryUtils.BakeCache cache;

			// Token: 0x04000AD7 RID: 2775
			[Token(Token = "0x4000AD7")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 particleScale;
		}

		// Token: 0x020001E0 RID: 480
		[Token(Token = "0x20001E0")]
		public struct BakeOutput
		{
			// Token: 0x04000AD8 RID: 2776
			[Token(Token = "0x4000AD8")]
			[FieldOffset(Offset = "0x0")]
			public Texture overrideMainTexture;
		}

		// Token: 0x020001E1 RID: 481
		[Token(Token = "0x20001E1")]
		public class BakeCache
		{
			// Token: 0x06000B49 RID: 2889 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x55640C0", Offset = "0x5562CC0", VA = "0x1855640C0")]
			public void ClearMemo(string key)
			{
			}

			// Token: 0x06000B4A RID: 2890 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x5564050", Offset = "0x5562C50", VA = "0x185564050")]
			public void ClearAllMemo()
			{
			}

			// Token: 0x06000B4B RID: 2891 RVA: 0x00007C1C File Offset: 0x00005E1C
			[Token(Token = "0x6000B4B")]
			public static ParticleSystem.MinMaxCurve ReadCurveMemo<TContext>(ParticleGeometryUtils.BakeCache nullableCache, string key, TContext context, Func<TContext, ParticleSystem.MinMaxCurve> reader)
			{
				return default(ParticleSystem.MinMaxCurve);
			}

			// Token: 0x06000B4C RID: 2892 RVA: 0x00007C34 File Offset: 0x00005E34
			[Token(Token = "0x6000B4C")]
			public static ParticleSystem.MinMaxGradient ReadGradientMemo<TContext>(ParticleGeometryUtils.BakeCache nullableCache, string key, TContext context, Func<TContext, ParticleSystem.MinMaxGradient> reader)
			{
				return default(ParticleSystem.MinMaxGradient);
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B4D")]
			private static TData _ReadStructMemo<TData, TContext>(string key, TContext context, Func<TContext, TData> reader, ref Dictionary<string, TData?> memo) where TData : struct
			{
				return null;
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BakeCache()
			{
			}

			// Token: 0x04000AD9 RID: 2777
			[Token(Token = "0x4000AD9")]
			public const string KEY_UV_FRAME_OVERTIME = "uvFrameOverTime";

			// Token: 0x04000ADA RID: 2778
			[Token(Token = "0x4000ADA")]
			public const string KEY_TRAIL_WIDTH = "trailWidth";

			// Token: 0x04000ADB RID: 2779
			[Token(Token = "0x4000ADB")]
			public const string KEY_TRAIL_COLOR = "trailColor";

			// Token: 0x04000ADC RID: 2780
			[Token(Token = "0x4000ADC")]
			public const string KEY_COLOR_OVER_LIFETIME = "colorOverLifetime";

			// Token: 0x04000ADD RID: 2781
			[Token(Token = "0x4000ADD")]
			public const string KEY_COLOR_BY_SPEED = "colorBySpeed";

			// Token: 0x04000ADE RID: 2782
			[Token(Token = "0x4000ADE")]
			public const string KEY_TRAIL_COLOR_LIFETIME = "trailColorOverLifetime";

			// Token: 0x04000ADF RID: 2783
			[Token(Token = "0x4000ADF")]
			public const string KEY_TRAIL_LIFETIME = "trailLifetime";

			// Token: 0x04000AE0 RID: 2784
			[Token(Token = "0x4000AE0")]
			public const string KEY_START_TIME = "startTime";

			// Token: 0x04000AE1 RID: 2785
			[Token(Token = "0x4000AE1")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, ParticleSystem.MinMaxCurve?> m_curveMemo;

			// Token: 0x04000AE2 RID: 2786
			[Token(Token = "0x4000AE2")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, ParticleSystem.MinMaxGradient?> m_gradientMemo;

			// Token: 0x04000AE3 RID: 2787
			[Token(Token = "0x4000AE3")]
			[FieldOffset(Offset = "0x20")]
			public TrailContext trailContext;
		}

		// Token: 0x020001E2 RID: 482
		[Token(Token = "0x20001E2")]
		public class BuiltMesh
		{
			// Token: 0x17000108 RID: 264
			// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B50 RID: 2896 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000108")]
			public List<Vector3> vertices
			{
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B50")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000109 RID: 265
			// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000109")]
			public List<Vector2> uv0
			{
				[Token(Token = "0x6000B51")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B52")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700010A")]
			public List<Vector2> uv1
			{
				[Token(Token = "0x6000B53")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B56 RID: 2902 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700010B")]
			public List<int> triangles
			{
				[Token(Token = "0x6000B55")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B56")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B58 RID: 2904 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700010C")]
			public List<Color32> colors
			{
				[Token(Token = "0x6000B57")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B58")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700010D")]
			public List<Vector3> normals
			{
				[Token(Token = "0x6000B59")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000B5B RID: 2907 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700010E")]
			public List<Vector4> tangents
			{
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5C")]
				[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x5564CB0", Offset = "0x55638B0", VA = "0x185564CB0")]
			public BuiltMesh()
			{
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x5564BE0", Offset = "0x55637E0", VA = "0x185564BE0")]
			public void Reset()
			{
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B5F")]
			[Address(RVA = "0x5564A90", Offset = "0x5563690", VA = "0x185564A90")]
			public void PopulateMesh(Mesh mesh)
			{
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x5564820", Offset = "0x5563420", VA = "0x185564820")]
			public void FromMesh(Mesh mesh)
			{
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x55641E0", Offset = "0x5562DE0", VA = "0x1855641E0")]
			public void AddVert(Vector3 vert, Vector2 uv0, Vector2 uv1, Color32 color)
			{
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x5564380", Offset = "0x5562F80", VA = "0x185564380")]
			public void AddVert(Vector3 vert, Vector2 uv0, Vector2 uv1, Color32 color, Vector3 normal, Vector4 tangent)
			{
			}

			// Token: 0x06000B63 RID: 2915 RVA: 0x00007C4C File Offset: 0x00005E4C
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x5564640", Offset = "0x5563240", VA = "0x185564640")]
			public bool CalcTriangleCenter(int v1, int v2, int v3, out Vector3 center)
			{
				return default(bool);
			}

			// Token: 0x06000B64 RID: 2916 RVA: 0x00007C64 File Offset: 0x00005E64
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x5564A10", Offset = "0x5563610", VA = "0x185564A10")]
			public bool HasVerticeProperty(IList propList)
			{
				return default(bool);
			}
		}

		// Token: 0x020001E3 RID: 483
		[Token(Token = "0x20001E3")]
		private struct ParticleTriangle
		{
			// Token: 0x06000B65 RID: 2917 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x5573640", Offset = "0x5572240", VA = "0x185573640")]
			public void SetVertexIndex(int v1, int v2, int v3, int offset = 0)
			{
			}

			// Token: 0x04000AEB RID: 2795
			[Token(Token = "0x4000AEB")]
			[FieldOffset(Offset = "0x0")]
			public int v1;

			// Token: 0x04000AEC RID: 2796
			[Token(Token = "0x4000AEC")]
			[FieldOffset(Offset = "0x4")]
			public int v2;

			// Token: 0x04000AED RID: 2797
			[Token(Token = "0x4000AED")]
			[FieldOffset(Offset = "0x8")]
			public int v3;

			// Token: 0x04000AEE RID: 2798
			[Token(Token = "0x4000AEE")]
			[FieldOffset(Offset = "0xC")]
			public int particleIndex;

			// Token: 0x04000AEF RID: 2799
			[Token(Token = "0x4000AEF")]
			[FieldOffset(Offset = "0x10")]
			public float aliveTimePercent;

			// Token: 0x04000AF0 RID: 2800
			[Token(Token = "0x4000AF0")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 centerVS;

			// Token: 0x04000AF1 RID: 2801
			[Token(Token = "0x4000AF1")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 particlePosVS;
		}

		// Token: 0x020001E4 RID: 484
		[Token(Token = "0x20001E4")]
		private class TriangleSortInfo
		{
			// Token: 0x06000B66 RID: 2918 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x55767D0", Offset = "0x55753D0", VA = "0x1855767D0")]
			public void Init(ParticleGeometryUtils.ParticleTriangle triangle)
			{
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TriangleSortInfo()
			{
			}

			// Token: 0x04000AF2 RID: 2802
			[Token(Token = "0x4000AF2")]
			[FieldOffset(Offset = "0x10")]
			public ParticleGeometryUtils.ParticleTriangle triangle;

			// Token: 0x04000AF3 RID: 2803
			[Token(Token = "0x4000AF3")]
			[FieldOffset(Offset = "0x3C")]
			public float triangleZ;

			// Token: 0x04000AF4 RID: 2804
			[Token(Token = "0x4000AF4")]
			[FieldOffset(Offset = "0x40")]
			public float particleZ;

			// Token: 0x04000AF5 RID: 2805
			[Token(Token = "0x4000AF5")]
			[FieldOffset(Offset = "0x44")]
			public float aliveTimePercent;

			// Token: 0x04000AF6 RID: 2806
			[Token(Token = "0x4000AF6")]
			[FieldOffset(Offset = "0x48")]
			public int particleIndex;
		}

		// Token: 0x020001E5 RID: 485
		[Token(Token = "0x20001E5")]
		private class ContextData
		{
			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700010F")]
			public ParticleSystem.Particle[] particleBuffer
			{
				[Token(Token = "0x6000B68")]
				[Address(RVA = "0x5568BE0", Offset = "0x55677E0", VA = "0x185568BE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000B69 RID: 2921 RVA: 0x00007C7C File Offset: 0x00005E7C
			[Token(Token = "0x17000110")]
			public int particleCount
			{
				[Token(Token = "0x6000B69")]
				[Address(RVA = "0x5568C30", Offset = "0x5567830", VA = "0x185568C30")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x5566990", Offset = "0x5565590", VA = "0x185566990")]
			public static void OnRecycle(ParticleGeometryUtils.ContextData inst)
			{
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x00007C94 File Offset: 0x00005E94
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x55663B0", Offset = "0x5564FB0", VA = "0x1855663B0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x55662C0", Offset = "0x5564EC0", VA = "0x1855662C0")]
			public static ParticleGeometryUtils.ContextData Init(ParticleGeometryUtils.BakeInput input, ParticleGeometryUtils.Pools pools)
			{
				return null;
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x5567310", Offset = "0x5565F10", VA = "0x185567310")]
			private void _Init(ParticleGeometryUtils.BakeInput input, ParticleGeometryUtils.BuiltMesh dstMesh, ParticleGeometryUtils.Pools pools)
			{
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x55674D0", Offset = "0x55660D0", VA = "0x1855674D0")]
			private void _PrepareData()
			{
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x00007CAC File Offset: 0x00005EAC
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x55661E0", Offset = "0x5564DE0", VA = "0x1855661E0")]
			public float GetParticleUVFrameIndex(int pIndex)
			{
				return 0f;
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x55661A0", Offset = "0x5564DA0", VA = "0x1855661A0")]
			public Mesh GetMesh(int index)
			{
				return null;
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x00007CC4 File Offset: 0x00005EC4
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x5566C20", Offset = "0x5565820", VA = "0x185566C20")]
			public ParticleSystem.MinMaxCurve ReadFrameOverTimeWithCache(ParticleSystem.TextureSheetAnimationModule tsaModule)
			{
				return default(ParticleSystem.MinMaxCurve);
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x5566BD0", Offset = "0x55657D0", VA = "0x185566BD0")]
			public void PrepareVertBuffer()
			{
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x5565EC0", Offset = "0x5564AC0", VA = "0x185565EC0")]
			public void FlushVertBufferBillboard(Vector3 v1, Vector3 v2, Vector3 v3, Vector3 v4)
			{
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x55662B0", Offset = "0x5564EB0", VA = "0x1855662B0")]
			public IList<Vector3> GetVertBuffer()
			{
				return null;
			}

			// Token: 0x06000B75 RID: 2933 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x55668F0", Offset = "0x55654F0", VA = "0x1855668F0")]
			public int[] MakeUVOrderBuffer()
			{
				return null;
			}

			// Token: 0x06000B76 RID: 2934 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x5566780", Offset = "0x5565380", VA = "0x185566780")]
			public Vector2[] MakeUVBuffer()
			{
				return null;
			}

			// Token: 0x06000B77 RID: 2935 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x5566610", Offset = "0x5565210", VA = "0x185566610")]
			public Vector4[] MakeUV2Buffer()
			{
				return null;
			}

			// Token: 0x06000B78 RID: 2936 RVA: 0x00007CDC File Offset: 0x00005EDC
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x5565DD0", Offset = "0x55649D0", VA = "0x185565DD0")]
			public Vector3 CalcViewSpaceCenter(Vector3 v1WS, Vector3 v2WS, Vector3 v3WS)
			{
				return default(Vector3);
			}

			// Token: 0x06000B79 RID: 2937 RVA: 0x00007CF4 File Offset: 0x00005EF4
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x5566480", Offset = "0x5565080", VA = "0x185566480")]
			public ParticleGeometryUtils.ParticleTriangle MakeBaseTriangle(int index, ParticleSystem.Particle particle)
			{
				return default(ParticleGeometryUtils.ParticleTriangle);
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x55657A0", Offset = "0x55643A0", VA = "0x1855657A0")]
			public void AddParticleTriangleOfDstMesh(ParticleGeometryUtils.ParticleTriangle baseTriangle, int offset, IList<int> indexList)
			{
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x5566DA0", Offset = "0x55659A0", VA = "0x185566DA0")]
			public void SortAndWriteTrianglesToDstMesh()
			{
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x00007D0C File Offset: 0x00005F0C
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x5567200", Offset = "0x5565E00", VA = "0x185567200")]
			private static int _ComparisonSortModeNone(ParticleGeometryUtils.TriangleSortInfo lhs, ParticleGeometryUtils.TriangleSortInfo rhs)
			{
				return 0;
			}

			// Token: 0x06000B7D RID: 2941 RVA: 0x00007D24 File Offset: 0x00005F24
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x5567190", Offset = "0x5565D90", VA = "0x185567190")]
			private static int _ComparisonSortModeDistance(ParticleGeometryUtils.TriangleSortInfo lhs, ParticleGeometryUtils.TriangleSortInfo rhs)
			{
				return 0;
			}

			// Token: 0x06000B7E RID: 2942 RVA: 0x00007D3C File Offset: 0x00005F3C
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x55672A0", Offset = "0x5565EA0", VA = "0x1855672A0")]
			private static int _ComparisonSortModeYoungestFront(ParticleGeometryUtils.TriangleSortInfo lhs, ParticleGeometryUtils.TriangleSortInfo rhs)
			{
				return 0;
			}

			// Token: 0x06000B7F RID: 2943 RVA: 0x00007D54 File Offset: 0x00005F54
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x5567230", Offset = "0x5565E30", VA = "0x185567230")]
			private static int _ComparisonSortModeOldestFront(ParticleGeometryUtils.TriangleSortInfo lhs, ParticleGeometryUtils.TriangleSortInfo rhs)
			{
				return 0;
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x55689C0", Offset = "0x55675C0", VA = "0x1855689C0")]
			public ContextData()
			{
			}

			// Token: 0x04000AF7 RID: 2807
			[Token(Token = "0x4000AF7")]
			[FieldOffset(Offset = "0x10")]
			public ParticleGeometryUtils.BuiltMesh dstMesh;

			// Token: 0x04000AF8 RID: 2808
			[Token(Token = "0x4000AF8")]
			[FieldOffset(Offset = "0x18")]
			private ParticleGeometryUtils.BakeCache m_cache;

			// Token: 0x04000AF9 RID: 2809
			[Token(Token = "0x4000AF9")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystem system;

			// Token: 0x04000AFA RID: 2810
			[Token(Token = "0x4000AFA")]
			[FieldOffset(Offset = "0x28")]
			public ParticleSystemRenderer renderer;

			// Token: 0x04000AFB RID: 2811
			[Token(Token = "0x4000AFB")]
			[FieldOffset(Offset = "0x30")]
			public Transform srcTransform;

			// Token: 0x04000AFC RID: 2812
			[Token(Token = "0x4000AFC")]
			[FieldOffset(Offset = "0x38")]
			public Camera camera;

			// Token: 0x04000AFD RID: 2813
			[Token(Token = "0x4000AFD")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 externParticleScale;

			// Token: 0x04000AFE RID: 2814
			[Token(Token = "0x4000AFE")]
			[FieldOffset(Offset = "0x4C")]
			public Matrix4x4 worldRotation;

			// Token: 0x04000AFF RID: 2815
			[Token(Token = "0x4000AFF")]
			[FieldOffset(Offset = "0x8C")]
			public Matrix4x4 worldMatrix;

			// Token: 0x04000B00 RID: 2816
			[Token(Token = "0x4000B00")]
			[FieldOffset(Offset = "0xCC")]
			public Matrix4x4 worldViewMatrix;

			// Token: 0x04000B01 RID: 2817
			[Token(Token = "0x4000B01")]
			[FieldOffset(Offset = "0x10C")]
			public Matrix4x4 viewMatrix;

			// Token: 0x04000B02 RID: 2818
			[Token(Token = "0x4000B02")]
			[FieldOffset(Offset = "0x14C")]
			public Matrix4x4 invViewMatrix;

			// Token: 0x04000B03 RID: 2819
			[Token(Token = "0x4000B03")]
			[FieldOffset(Offset = "0x18C")]
			public Vector3 cameraPos;

			// Token: 0x04000B04 RID: 2820
			[Token(Token = "0x4000B04")]
			[FieldOffset(Offset = "0x198")]
			public Vector3 cameraVelocityVS;

			// Token: 0x04000B05 RID: 2821
			[Token(Token = "0x4000B05")]
			[FieldOffset(Offset = "0x1A4")]
			public Vector3 cameraUp;

			// Token: 0x04000B06 RID: 2822
			[Token(Token = "0x4000B06")]
			[FieldOffset(Offset = "0x1B0")]
			public Vector2 minMaxParticleSize;

			// Token: 0x04000B07 RID: 2823
			[Token(Token = "0x4000B07")]
			[FieldOffset(Offset = "0x1B8")]
			public Vector3 xSpan;

			// Token: 0x04000B08 RID: 2824
			[Token(Token = "0x4000B08")]
			[FieldOffset(Offset = "0x1C4")]
			public Vector3 ySpan;

			// Token: 0x04000B09 RID: 2825
			[Token(Token = "0x4000B09")]
			[FieldOffset(Offset = "0x1D0")]
			public Vector3 renderScale;

			// Token: 0x04000B0A RID: 2826
			[Token(Token = "0x4000B0A")]
			[FieldOffset(Offset = "0x1DC")]
			public int numUVFrame;

			// Token: 0x04000B0B RID: 2827
			[Token(Token = "0x4000B0B")]
			[FieldOffset(Offset = "0x1E0")]
			public int numTilesX;

			// Token: 0x04000B0C RID: 2828
			[Token(Token = "0x4000B0C")]
			[FieldOffset(Offset = "0x1E4")]
			public int numTilesY;

			// Token: 0x04000B0D RID: 2829
			[Token(Token = "0x4000B0D")]
			[FieldOffset(Offset = "0x1E8")]
			public float animUScale;

			// Token: 0x04000B0E RID: 2830
			[Token(Token = "0x4000B0E")]
			[FieldOffset(Offset = "0x1EC")]
			public float animVScale;

			// Token: 0x04000B0F RID: 2831
			[Token(Token = "0x4000B0F")]
			[FieldOffset(Offset = "0x1F0")]
			public UVChannelFlags animateUVChannels;

			// Token: 0x04000B10 RID: 2832
			[Token(Token = "0x4000B10")]
			[FieldOffset(Offset = "0x1F4")]
			public bool animateUVs;

			// Token: 0x04000B11 RID: 2833
			[Token(Token = "0x4000B11")]
			[FieldOffset(Offset = "0x1F5")]
			public bool flipUVs;

			// Token: 0x04000B12 RID: 2834
			[Token(Token = "0x4000B12")]
			[FieldOffset(Offset = "0x1F8")]
			public Vector3 bentNormalVector;

			// Token: 0x04000B13 RID: 2835
			[Token(Token = "0x4000B13")]
			[FieldOffset(Offset = "0x204")]
			public float bentNormalFactor;

			// Token: 0x04000B14 RID: 2836
			[Token(Token = "0x4000B14")]
			[FieldOffset(Offset = "0x208")]
			public Vector4 minMaxScaleVector;

			// Token: 0x04000B15 RID: 2837
			[Token(Token = "0x4000B15")]
			[FieldOffset(Offset = "0x218")]
			public Vector2 minMaxPlaneScale;

			// Token: 0x04000B16 RID: 2838
			[Token(Token = "0x4000B16")]
			[FieldOffset(Offset = "0x220")]
			public Vector2 minMaxOrthoSize;

			// Token: 0x04000B17 RID: 2839
			[Token(Token = "0x4000B17")]
			[FieldOffset(Offset = "0x228")]
			public bool use3DRotation;

			// Token: 0x04000B18 RID: 2840
			[Token(Token = "0x4000B18")]
			[FieldOffset(Offset = "0x229")]
			public bool use3DSize;

			// Token: 0x04000B19 RID: 2841
			[Token(Token = "0x4000B19")]
			[FieldOffset(Offset = "0x230")]
			public ParticleGeometryUtils.UVModule uvModule;

			// Token: 0x04000B1A RID: 2842
			[Token(Token = "0x4000B1A")]
			[FieldOffset(Offset = "0x238")]
			public bool useMesh;

			// Token: 0x04000B1B RID: 2843
			[Token(Token = "0x4000B1B")]
			[FieldOffset(Offset = "0x23C")]
			public int meshCount;

			// Token: 0x04000B1C RID: 2844
			[Token(Token = "0x4000B1C")]
			[FieldOffset(Offset = "0x240")]
			public Mesh[] m_meshBuffer;

			// Token: 0x04000B1D RID: 2845
			[Token(Token = "0x4000B1D")]
			[FieldOffset(Offset = "0x248")]
			public ParticleGeometryUtils.Pools pools;

			// Token: 0x04000B1E RID: 2846
			[Token(Token = "0x4000B1E")]
			[FieldOffset(Offset = "0x250")]
			private GenericPool<ParticleArray>.Ref m_particleArrayRef;

			// Token: 0x04000B1F RID: 2847
			[Token(Token = "0x4000B1F")]
			[FieldOffset(Offset = "0x260")]
			private List<Vector3> m_vertBuffer;

			// Token: 0x04000B20 RID: 2848
			[Token(Token = "0x4000B20")]
			[FieldOffset(Offset = "0x268")]
			private int[] m_uvOrderBuffer;

			// Token: 0x04000B21 RID: 2849
			[Token(Token = "0x4000B21")]
			[FieldOffset(Offset = "0x270")]
			private Vector2[] m_uvBuffer;

			// Token: 0x04000B22 RID: 2850
			[Token(Token = "0x4000B22")]
			[FieldOffset(Offset = "0x278")]
			private Vector4[] m_uv2Buffer;

			// Token: 0x04000B23 RID: 2851
			[Token(Token = "0x4000B23")]
			[FieldOffset(Offset = "0x280")]
			private LocalGenericPool<ParticleGeometryUtils.TriangleSortInfo> m_sortInfoPool;

			// Token: 0x04000B24 RID: 2852
			[Token(Token = "0x4000B24")]
			[FieldOffset(Offset = "0x288")]
			private List<ParticleGeometryUtils.TriangleSortInfo> m_trianglesToSort;

			// Token: 0x04000B25 RID: 2853
			[Token(Token = "0x4000B25")]
			[FieldOffset(Offset = "0x0")]
			private static Comparison<ParticleGeometryUtils.TriangleSortInfo> s_comparisonSortModeNone;

			// Token: 0x04000B26 RID: 2854
			[Token(Token = "0x4000B26")]
			[FieldOffset(Offset = "0x8")]
			private static Comparison<ParticleGeometryUtils.TriangleSortInfo> s_comparisonSortModeDistance;

			// Token: 0x04000B27 RID: 2855
			[Token(Token = "0x4000B27")]
			[FieldOffset(Offset = "0x10")]
			private static Comparison<ParticleGeometryUtils.TriangleSortInfo> s_comparisonSortModeYoungestFront;

			// Token: 0x04000B28 RID: 2856
			[Token(Token = "0x4000B28")]
			[FieldOffset(Offset = "0x18")]
			private static Comparison<ParticleGeometryUtils.TriangleSortInfo> s_comparisonSortModeOldestFront;
		}

		// Token: 0x020001E7 RID: 487
		[Token(Token = "0x20001E7")]
		private class ParticleTrailContext : TrailContext
		{
			// Token: 0x06000B85 RID: 2949 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x55735B0", Offset = "0x55721B0", VA = "0x1855735B0")]
			public ParticleTrailContext()
			{
			}

			// Token: 0x04000B2B RID: 2859
			[Token(Token = "0x4000B2B")]
			[FieldOffset(Offset = "0x28")]
			public List<float> lastParticleRemainLifetime;
		}

		// Token: 0x020001E8 RID: 488
		[Token(Token = "0x20001E8")]
		private class TrailModule : TrailContext.IHost
		{
			// Token: 0x06000B86 RID: 2950 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x5575D00", Offset = "0x5574900", VA = "0x185575D00")]
			public void Init(ParticleGeometryUtils.TrailContextData context, ParticleGeometryUtils.BakeCache nullableCache)
			{
			}

			// Token: 0x06000B87 RID: 2951 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x55765D0", Offset = "0x55751D0", VA = "0x1855765D0")]
			public void ReadTrailPositions(int index, List<Vector3> output)
			{
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x00007D84 File Offset: 0x00005F84
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x5575CB0", Offset = "0x55748B0", VA = "0x185575CB0", Slot = "4")]
			public int GetTrailCount()
			{
				return 0;
			}

			// Token: 0x06000B89 RID: 2953 RVA: 0x00007D9C File Offset: 0x00005F9C
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x55755F0", Offset = "0x55741F0", VA = "0x1855755F0", Slot = "5")]
			public float CalcTrailLifetime(int index)
			{
				return 0f;
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x00007DB4 File Offset: 0x00005FB4
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x55765C0", Offset = "0x55751C0", VA = "0x1855765C0", Slot = "6")]
			public float MinPointDistance()
			{
				return 0f;
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x00007DCC File Offset: 0x00005FCC
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x5575980", Offset = "0x5574580", VA = "0x185575980", Slot = "7")]
			public bool CheckTrailExpired(int index)
			{
				return default(bool);
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x00007DE4 File Offset: 0x00005FE4
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x5575A50", Offset = "0x5574650", VA = "0x185575A50", Slot = "8")]
			public bool GetCurrentPosition(int index, out Vector3 position)
			{
				return default(bool);
			}

			// Token: 0x06000B8D RID: 2957 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrailModule()
			{
			}

			// Token: 0x04000B2C RID: 2860
			[Token(Token = "0x4000B2C")]
			[FieldOffset(Offset = "0x10")]
			private ParticleGeometryUtils.TrailContextData m_context;

			// Token: 0x04000B2D RID: 2861
			[Token(Token = "0x4000B2D")]
			[FieldOffset(Offset = "0x18")]
			public ParticleSystem.TrailModule trails;

			// Token: 0x04000B2E RID: 2862
			[Token(Token = "0x4000B2E")]
			[FieldOffset(Offset = "0x20")]
			public ParticleGeometryUtils.ParticleLineParameters lineParams;

			// Token: 0x04000B2F RID: 2863
			[Token(Token = "0x4000B2F")]
			[FieldOffset(Offset = "0x98")]
			public int trailStripLength;

			// Token: 0x04000B30 RID: 2864
			[Token(Token = "0x4000B30")]
			[FieldOffset(Offset = "0xA0")]
			public ParticleSystem.MinMaxGradient colorOverLifetime;

			// Token: 0x04000B31 RID: 2865
			[Token(Token = "0x4000B31")]
			[FieldOffset(Offset = "0xD8")]
			public ParticleSystem.MinMaxCurve lifetime;

			// Token: 0x04000B32 RID: 2866
			[Token(Token = "0x4000B32")]
			[FieldOffset(Offset = "0xF8")]
			public float minVertexDist;

			// Token: 0x04000B33 RID: 2867
			[Token(Token = "0x4000B33")]
			[FieldOffset(Offset = "0xFC")]
			public bool sizeAffectsLifetime;

			// Token: 0x04000B34 RID: 2868
			[Token(Token = "0x4000B34")]
			[FieldOffset(Offset = "0x100")]
			public List<float> lastParticleRemainLifetime;

			// Token: 0x04000B35 RID: 2869
			[Token(Token = "0x4000B35")]
			[FieldOffset(Offset = "0x108")]
			public float ratio;

			// Token: 0x04000B36 RID: 2870
			[Token(Token = "0x4000B36")]
			[FieldOffset(Offset = "0x110")]
			private TrailContext m_trailRecords;
		}

		// Token: 0x020001EA RID: 490
		[Token(Token = "0x20001EA")]
		private class SpriteRectData
		{
			// Token: 0x06000B94 RID: 2964 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x5573E60", Offset = "0x5572A60", VA = "0x185573E60")]
			public void CopyTo(ParticleGeometryUtils.SpriteRectData other)
			{
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SpriteRectData()
			{
			}

			// Token: 0x04000B3C RID: 2876
			[Token(Token = "0x4000B3C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly ParticleGeometryUtils.SpriteRectData ZERO;

			// Token: 0x04000B3D RID: 2877
			[Token(Token = "0x4000B3D")]
			[FieldOffset(Offset = "0x10")]
			public Rect rect;

			// Token: 0x04000B3E RID: 2878
			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 pivot;

			// Token: 0x04000B3F RID: 2879
			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 sizeMul;
		}

		// Token: 0x020001EB RID: 491
		[Token(Token = "0x20001EB")]
		private class UVModule
		{
			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000B97 RID: 2967 RVA: 0x00007E5C File Offset: 0x0000605C
			// (set) Token: 0x06000B98 RID: 2968 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000111")]
			public bool enabled
			{
				[Token(Token = "0x6000B97")]
				[Address(RVA = "0x1692620", Offset = "0x1691220", VA = "0x181692620")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B98")]
				[Address(RVA = "0x1692B10", Offset = "0x1691710", VA = "0x181692B10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000B99 RID: 2969 RVA: 0x00007E74 File Offset: 0x00006074
			// (set) Token: 0x06000B9A RID: 2970 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000112")]
			public ParticleSystemAnimationMode mode
			{
				[Token(Token = "0x6000B99")]
				[Address(RVA = "0x557C480", Offset = "0x557B080", VA = "0x18557C480")]
				[CompilerGenerated]
				get
				{
					return ParticleSystemAnimationMode.Grid;
				}
				[Token(Token = "0x6000B9A")]
				[Address(RVA = "0x557C490", Offset = "0x557B090", VA = "0x18557C490")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000B9B RID: 2971 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x557A9C0", Offset = "0x55795C0", VA = "0x18557A9C0")]
			public void PrepareForRender(ParticleGeometryUtils.ContextData context)
			{
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x557B230", Offset = "0x5579E30", VA = "0x18557B230")]
			public void Update(ParticleGeometryUtils.ContextData context)
			{
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x557BAB0", Offset = "0x557A6B0", VA = "0x18557BAB0")]
			private void _UpdateSpritesTpl(ParticleGeometryUtils.ContextData context)
			{
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x557B2E0", Offset = "0x5579EE0", VA = "0x18557B2E0")]
			private void _UpdateSingleRowTpl(ParticleGeometryUtils.ContextData context)
			{
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x557BF10", Offset = "0x557AB10", VA = "0x18557BF10")]
			private void _UpdateWholeSheetTpl(ParticleGeometryUtils.ContextData context)
			{
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x557C360", Offset = "0x557AF60", VA = "0x18557C360")]
			public UVModule()
			{
			}

			// Token: 0x04000B40 RID: 2880
			[Token(Token = "0x4000B40")]
			[FieldOffset(Offset = "0x10")]
			private LocalGenericPool<ParticleGeometryUtils.SpriteRectData> m_rectDataPool;

			// Token: 0x04000B41 RID: 2881
			[Token(Token = "0x4000B41")]
			[FieldOffset(Offset = "0x18")]
			private ParticleSystem.TextureSheetAnimationModule m_module;

			// Token: 0x04000B42 RID: 2882
			[Token(Token = "0x4000B42")]
			[FieldOffset(Offset = "0x20")]
			private ParticleSystem.MinMaxCurve m_frameOverTime;

			// Token: 0x04000B43 RID: 2883
			[Token(Token = "0x4000B43")]
			[FieldOffset(Offset = "0x40")]
			private ParticleSystem.MinMaxCurve m_startFrame;

			// Token: 0x04000B44 RID: 2884
			[Token(Token = "0x4000B44")]
			[FieldOffset(Offset = "0x60")]
			public List<ParticleGeometryUtils.SpriteRectData> spriteRectData;

			// Token: 0x04000B45 RID: 2885
			[Token(Token = "0x4000B45")]
			[FieldOffset(Offset = "0x68")]
			public List<float> normalizedSheetIndex;

			// Token: 0x04000B46 RID: 2886
			[Token(Token = "0x4000B46")]
			[FieldOffset(Offset = "0x70")]
			public Texture mainTexture;
		}

		// Token: 0x020001EC RID: 492
		[Token(Token = "0x20001EC")]
		private struct ParticleLineParameters
		{
			// Token: 0x06000BA1 RID: 2977 RVA: 0x00007E8C File Offset: 0x0000608C
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x5572810", Offset = "0x5571410", VA = "0x185572810")]
			public static ParticleGeometryUtils.ParticleLineParameters CreateFromParticle(int psIndex, ParticleGeometryUtils.ParticleLineParameters lineParam, float widthScale, ParticleSystem.Particle particle, ParticleGeometryUtils.TrailContextData context)
			{
				return default(ParticleGeometryUtils.ParticleLineParameters);
			}

			// Token: 0x04000B49 RID: 2889
			[Token(Token = "0x4000B49")]
			[FieldOffset(Offset = "0x0")]
			public ParticleSystem.MinMaxCurve widthCurve;

			// Token: 0x04000B4A RID: 2890
			[Token(Token = "0x4000B4A")]
			[FieldOffset(Offset = "0x20")]
			public ParticleSystem.MinMaxGradient colorGradient;

			// Token: 0x04000B4B RID: 2891
			[Token(Token = "0x4000B4B")]
			[FieldOffset(Offset = "0x58")]
			public float widthCurveFactor;

			// Token: 0x04000B4C RID: 2892
			[Token(Token = "0x4000B4C")]
			[FieldOffset(Offset = "0x5C")]
			public float colorGradientFactor;

			// Token: 0x04000B4D RID: 2893
			[Token(Token = "0x4000B4D")]
			[FieldOffset(Offset = "0x60")]
			public float widthCurveMultiplier;

			// Token: 0x04000B4E RID: 2894
			[Token(Token = "0x4000B4E")]
			[FieldOffset(Offset = "0x64")]
			public Color32 colorGradientMultiplier;

			// Token: 0x04000B4F RID: 2895
			[Token(Token = "0x4000B4F")]
			[FieldOffset(Offset = "0x68")]
			public int numCornerVertices;

			// Token: 0x04000B50 RID: 2896
			[Token(Token = "0x4000B50")]
			[FieldOffset(Offset = "0x6C")]
			public int numCapVertices;

			// Token: 0x04000B51 RID: 2897
			[Token(Token = "0x4000B51")]
			[FieldOffset(Offset = "0x70")]
			public ParticleSystemTrailTextureMode textureMode;
		}

		// Token: 0x020001ED RID: 493
		[Token(Token = "0x20001ED")]
		private class TrailContextData
		{
			// Token: 0x06000BA2 RID: 2978 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x55740A0", Offset = "0x5572CA0", VA = "0x1855740A0")]
			public static void OnRecycle(ParticleGeometryUtils.TrailContextData inst)
			{
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000113")]
			public ParticleSystem.Particle[] particleBuffer
			{
				[Token(Token = "0x6000BA3")]
				[Address(RVA = "0x5575560", Offset = "0x5574160", VA = "0x185575560")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x00007EA4 File Offset: 0x000060A4
			[Token(Token = "0x17000114")]
			public int particleCount
			{
				[Token(Token = "0x6000BA4")]
				[Address(RVA = "0x55755B0", Offset = "0x55741B0", VA = "0x1855755B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000BA5 RID: 2981 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x5573FB0", Offset = "0x5572BB0", VA = "0x185573FB0")]
			public static ParticleGeometryUtils.TrailContextData Init(ParticleGeometryUtils.BakeInput input, ParticleGeometryUtils.Pools pools)
			{
				return null;
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x5574370", Offset = "0x5572F70", VA = "0x185574370")]
			private void _Init(ParticleGeometryUtils.BakeInput input, ParticleGeometryUtils.BuiltMesh dstMesh, ParticleGeometryUtils.Pools pools)
			{
			}

			// Token: 0x06000BA7 RID: 2983 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x55747E0", Offset = "0x55733E0", VA = "0x1855747E0")]
			private void _UpdateStatus()
			{
			}

			// Token: 0x06000BA8 RID: 2984 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x5574140", Offset = "0x5572D40", VA = "0x185574140")]
			public void SortParticleIndexByRemainTimeIncreasing(List<int> outputList)
			{
			}

			// Token: 0x06000BA9 RID: 2985 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x55753D0", Offset = "0x5573FD0", VA = "0x1855753D0")]
			public TrailContextData()
			{
			}

			// Token: 0x04000B52 RID: 2898
			[Token(Token = "0x4000B52")]
			[FieldOffset(Offset = "0x10")]
			public Camera camera;

			// Token: 0x04000B53 RID: 2899
			[Token(Token = "0x4000B53")]
			[FieldOffset(Offset = "0x18")]
			private ParticleGeometryUtils.BakeCache m_cache;

			// Token: 0x04000B54 RID: 2900
			[Token(Token = "0x4000B54")]
			[FieldOffset(Offset = "0x20")]
			public ParticleGeometryUtils.BuiltMesh dstMesh;

			// Token: 0x04000B55 RID: 2901
			[Token(Token = "0x4000B55")]
			[FieldOffset(Offset = "0x28")]
			public ParticleGeometryUtils.Pools pools;

			// Token: 0x04000B56 RID: 2902
			[Token(Token = "0x4000B56")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 externParticleScale;

			// Token: 0x04000B57 RID: 2903
			[Token(Token = "0x4000B57")]
			[FieldOffset(Offset = "0x3C")]
			public float externWidthScale;

			// Token: 0x04000B58 RID: 2904
			[Token(Token = "0x4000B58")]
			[FieldOffset(Offset = "0x40")]
			public Transform srcTransform;

			// Token: 0x04000B59 RID: 2905
			[Token(Token = "0x4000B59")]
			[FieldOffset(Offset = "0x48")]
			public Vector3 renderScale;

			// Token: 0x04000B5A RID: 2906
			[Token(Token = "0x4000B5A")]
			[FieldOffset(Offset = "0x58")]
			public ParticleSystem system;

			// Token: 0x04000B5B RID: 2907
			[Token(Token = "0x4000B5B")]
			[FieldOffset(Offset = "0x60")]
			public ParticleSystemRenderer renderer;

			// Token: 0x04000B5C RID: 2908
			[Token(Token = "0x4000B5C")]
			[FieldOffset(Offset = "0x68")]
			public ParticleSystem.ColorBySpeedModule colorBySpeed;

			// Token: 0x04000B5D RID: 2909
			[Token(Token = "0x4000B5D")]
			[FieldOffset(Offset = "0x70")]
			public ParticleSystem.ColorOverLifetimeModule colorOverLifetime;

			// Token: 0x04000B5E RID: 2910
			[Token(Token = "0x4000B5E")]
			[FieldOffset(Offset = "0x78")]
			public bool enableColorOverLifetime;

			// Token: 0x04000B5F RID: 2911
			[Token(Token = "0x4000B5F")]
			[FieldOffset(Offset = "0x80")]
			public ParticleSystem.MinMaxGradient colorOverLifetimeGradient;

			// Token: 0x04000B60 RID: 2912
			[Token(Token = "0x4000B60")]
			[FieldOffset(Offset = "0xB8")]
			public bool enableColorBySpeed;

			// Token: 0x04000B61 RID: 2913
			[Token(Token = "0x4000B61")]
			[FieldOffset(Offset = "0xC0")]
			public ParticleSystem.MinMaxGradient colorBySpeedGradient;

			// Token: 0x04000B62 RID: 2914
			[Token(Token = "0x4000B62")]
			[FieldOffset(Offset = "0xF8")]
			public bool use3DSize;

			// Token: 0x04000B63 RID: 2915
			[Token(Token = "0x4000B63")]
			[FieldOffset(Offset = "0xF9")]
			public bool use3DRotation;

			// Token: 0x04000B64 RID: 2916
			[Token(Token = "0x4000B64")]
			[FieldOffset(Offset = "0xFA")]
			public bool isMeshMode;

			// Token: 0x04000B65 RID: 2917
			[Token(Token = "0x4000B65")]
			[FieldOffset(Offset = "0xFB")]
			public bool useWorldSpace;

			// Token: 0x04000B66 RID: 2918
			[Token(Token = "0x4000B66")]
			[FieldOffset(Offset = "0xFC")]
			public Matrix4x4 worldToCameraMatrix;

			// Token: 0x04000B67 RID: 2919
			[Token(Token = "0x4000B67")]
			[FieldOffset(Offset = "0x13C")]
			public Matrix4x4 cameraToWorldMatrix;

			// Token: 0x04000B68 RID: 2920
			[Token(Token = "0x4000B68")]
			[FieldOffset(Offset = "0x17C")]
			public Matrix4x4 localToWorldMatrix;

			// Token: 0x04000B69 RID: 2921
			[Token(Token = "0x4000B69")]
			[FieldOffset(Offset = "0x1BC")]
			public Matrix4x4 worldMatrix;

			// Token: 0x04000B6A RID: 2922
			[Token(Token = "0x4000B6A")]
			[FieldOffset(Offset = "0x200")]
			public ParticleGeometryUtils.TrailModule trailModule;

			// Token: 0x04000B6B RID: 2923
			[Token(Token = "0x4000B6B")]
			[FieldOffset(Offset = "0x208")]
			private GenericPool<ParticleArray>.Ref m_particleArrayRef;

			// Token: 0x04000B6C RID: 2924
			[Token(Token = "0x4000B6C")]
			[FieldOffset(Offset = "0x218")]
			public List<float> particleAliveTimePercent;

			// Token: 0x04000B6D RID: 2925
			[Token(Token = "0x4000B6D")]
			[FieldOffset(Offset = "0x220")]
			public List<float> particleRemainLifetime;

			// Token: 0x04000B6E RID: 2926
			[Token(Token = "0x4000B6E")]
			[FieldOffset(Offset = "0x228")]
			public List<Vector3> particlePositions;

			// Token: 0x04000B6F RID: 2927
			[Token(Token = "0x4000B6F")]
			[FieldOffset(Offset = "0x230")]
			public LineBuilderData lineBuilderData;

			// Token: 0x04000B70 RID: 2928
			[Token(Token = "0x4000B70")]
			[FieldOffset(Offset = "0x238")]
			private Comparison<int> m_sortParticleRemainTimeIncreasing;
		}
	}
}
