using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	[NativeType("Runtime/Graphics/SpriteFrame.h")]
	[ExcludeFromPreset]
	[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
	[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
	[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
	public sealed class Sprite : Object
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x596E0A0", Offset = "0x596CCA0", VA = "0x18596E0A0")]
		[RequiredByNativeCode]
		private Sprite()
		{
		}

		// Token: 0x06000BE0 RID: 3040
		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x596DE40", Offset = "0x596CA40", VA = "0x18596DE40")]
		[MethodImpl(4096)]
		internal extern int GetPackingMode();

		// Token: 0x06000BE1 RID: 3041
		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x596DE80", Offset = "0x596CA80", VA = "0x18596DE80")]
		[MethodImpl(4096)]
		internal extern int GetPackingRotation();

		// Token: 0x06000BE2 RID: 3042
		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x596DE00", Offset = "0x596CA00", VA = "0x18596DE00")]
		[MethodImpl(4096)]
		internal extern int GetPacked();

		// Token: 0x06000BE3 RID: 3043 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x596E050", Offset = "0x596CC50", VA = "0x18596E050")]
		internal Rect GetTextureRect()
		{
			return default(Rect);
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x596DFB0", Offset = "0x596CBB0", VA = "0x18596DFB0")]
		internal Vector2 GetTextureRectOffset()
		{
			return default(Vector2);
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x596DD10", Offset = "0x596C910", VA = "0x18596DD10")]
		internal Vector4 GetInnerUVs()
		{
			return default(Vector4);
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x596DDB0", Offset = "0x596C9B0", VA = "0x18596DDB0")]
		internal Vector4 GetOuterUVs()
		{
			return default(Vector4);
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x596DF10", Offset = "0x596CB10", VA = "0x18596DF10")]
		internal Vector4 GetPadding()
		{
			return default(Vector4);
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x596D380", Offset = "0x596BF80", VA = "0x18596D380")]
		[FreeFunction("SpritesBindings::CreateSprite")]
		internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			return null;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x17000278")]
		public Bounds bounds
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x596E220", Offset = "0x596CE20", VA = "0x18596E220")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x17000279")]
		public Rect rect
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x596E3F0", Offset = "0x596CFF0", VA = "0x18596E3F0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x1700027A")]
		public Vector4 border
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x596E180", Offset = "0x596CD80", VA = "0x18596E180")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000BEC RID: 3052
		[Token(Token = "0x1700027B")]
		public extern Texture2D texture { [Token(Token = "0x6000BEC")] [Address(RVA = "0x596E5F0", Offset = "0x596D1F0", VA = "0x18596E5F0")] [MethodImpl(4096)] get; }

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000BED RID: 3053
		[Token(Token = "0x1700027C")]
		public extern float pixelsPerUnit { [Token(Token = "0x6000BED")] [Address(RVA = "0x596E360", Offset = "0x596CF60", VA = "0x18596E360")] [NativeMethod("GetPixelsToUnits")] [MethodImpl(4096)] get; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000BEE RID: 3054
		[Token(Token = "0x1700027D")]
		public extern Texture2D associatedAlphaSplitTexture { [Token(Token = "0x6000BEE")] [Address(RVA = "0x596E0F0", Offset = "0x596CCF0", VA = "0x18596E0F0")] [NativeMethod("GetAlphaTexture")] [MethodImpl(4096)] get; }

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x1700027E")]
		public Vector2 pivot
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x596E310", Offset = "0x596CF10", VA = "0x18596E310")]
			[NativeMethod("GetPivotInPixels")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x1700027F")]
		public bool packed
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x596E280", Offset = "0x596CE80", VA = "0x18596E280")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x17000280")]
		public SpritePackingMode packingMode
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x596DE40", Offset = "0x596CA40", VA = "0x18596DE40")]
			get
			{
				return SpritePackingMode.Tight;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x17000281")]
		public SpritePackingRotation packingRotation
		{
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x596DE80", Offset = "0x596CA80", VA = "0x18596DE80")]
			get
			{
				return SpritePackingRotation.None;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x17000282")]
		public Rect textureRect
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x596E520", Offset = "0x596D120", VA = "0x18596E520")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x17000283")]
		public Vector2 textureRectOffset
		{
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x596E440", Offset = "0x596D040", VA = "0x18596E440")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000BF5 RID: 3061
		[Token(Token = "0x17000284")]
		public extern Vector2[] vertices { [Token(Token = "0x6000BF5")] [Address(RVA = "0x596E6B0", Offset = "0x596D2B0", VA = "0x18596E6B0")] [FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000BF6 RID: 3062
		[Token(Token = "0x17000285")]
		public extern ushort[] triangles { [Token(Token = "0x6000BF6")] [Address(RVA = "0x596E630", Offset = "0x596D230", VA = "0x18596E630")] [FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000BF7 RID: 3063
		[Token(Token = "0x17000286")]
		public extern Vector2[] uv { [Token(Token = "0x6000BF7")] [Address(RVA = "0x596E670", Offset = "0x596D270", VA = "0x18596E670")] [FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF8")]
		[Address(RVA = "0x596D6B0", Offset = "0x596C2B0", VA = "0x18596D6B0")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
		{
			return null;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BF9")]
		[Address(RVA = "0x596D410", Offset = "0x596C010", VA = "0x18596D410")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
		{
			return null;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x596D470", Offset = "0x596C070", VA = "0x18596D470")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
		{
			return null;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x596DBF0", Offset = "0x596C7F0", VA = "0x18596DBF0")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
		{
			return null;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFC")]
		[Address(RVA = "0x596D5F0", Offset = "0x596C1F0", VA = "0x18596D5F0")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
		{
			return null;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BFD")]
		[Address(RVA = "0x596D540", Offset = "0x596C140", VA = "0x18596D540")]
		public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
		{
			return null;
		}

		// Token: 0x06000BFE RID: 3070
		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x596E000", Offset = "0x596CC00", VA = "0x18596E000")]
		[MethodImpl(4096)]
		private extern void GetTextureRect_Injected(out Rect ret);

		// Token: 0x06000BFF RID: 3071
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x596DF60", Offset = "0x596CB60", VA = "0x18596DF60")]
		[MethodImpl(4096)]
		private extern void GetTextureRectOffset_Injected(out Vector2 ret);

		// Token: 0x06000C00 RID: 3072
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x596DCC0", Offset = "0x596C8C0", VA = "0x18596DCC0")]
		[MethodImpl(4096)]
		private extern void GetInnerUVs_Injected(out Vector4 ret);

		// Token: 0x06000C01 RID: 3073
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x596DD60", Offset = "0x596C960", VA = "0x18596DD60")]
		[MethodImpl(4096)]
		private extern void GetOuterUVs_Injected(out Vector4 ret);

		// Token: 0x06000C02 RID: 3074
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x596DEC0", Offset = "0x596CAC0", VA = "0x18596DEC0")]
		[MethodImpl(4096)]
		private extern void GetPadding_Injected(out Vector4 ret);

		// Token: 0x06000C03 RID: 3075
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x596D300", Offset = "0x596BF00", VA = "0x18596D300")]
		[MethodImpl(4096)]
		private static extern Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape);

		// Token: 0x06000C04 RID: 3076
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x596E1D0", Offset = "0x596CDD0", VA = "0x18596E1D0")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x06000C05 RID: 3077
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x596E3A0", Offset = "0x596CFA0", VA = "0x18596E3A0")]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x06000C06 RID: 3078
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x596E130", Offset = "0x596CD30", VA = "0x18596E130")]
		[MethodImpl(4096)]
		private extern void get_border_Injected(out Vector4 ret);

		// Token: 0x06000C07 RID: 3079
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x596E2C0", Offset = "0x596CEC0", VA = "0x18596E2C0")]
		[MethodImpl(4096)]
		private extern void get_pivot_Injected(out Vector2 ret);
	}
}
