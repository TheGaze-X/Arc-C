using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020B RID: 523
	[Token(Token = "0x200020B")]
	internal static class MeshGenerationContextUtils
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x5B0BD00", Offset = "0x5B0A900", VA = "0x185B0BD00")]
		public static void Rectangle(this MeshGenerationContext mgc, MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x5B0BEA0", Offset = "0x5B0AAA0", VA = "0x185B0BEA0")]
		public static void Text(this MeshGenerationContext mgc, MeshGenerationContextUtils.TextParams textParams, ITextHandle handle, float pixelsPerPoint)
		{
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x5B0BA20", Offset = "0x5B0A620", VA = "0x185B0BA20")]
		private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
		{
			return default(Vector2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x5B0BA80", Offset = "0x5B0A680", VA = "0x185B0BA80")]
		public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
		{
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x5B0B810", Offset = "0x5B0A410", VA = "0x185B0B810")]
		public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref MeshGenerationContextUtils.RectangleParams rectParams)
		{
		}

		// Token: 0x0200020C RID: 524
		[Token(Token = "0x200020C")]
		public struct BorderParams
		{
			// Token: 0x04000740 RID: 1856
			[Token(Token = "0x4000740")]
			[FieldOffset(Offset = "0x0")]
			public Rect rect;

			// Token: 0x04000741 RID: 1857
			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x10")]
			public Color playmodeTintColor;

			// Token: 0x04000742 RID: 1858
			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0x20")]
			public Color leftColor;

			// Token: 0x04000743 RID: 1859
			[Token(Token = "0x4000743")]
			[FieldOffset(Offset = "0x30")]
			public Color topColor;

			// Token: 0x04000744 RID: 1860
			[Token(Token = "0x4000744")]
			[FieldOffset(Offset = "0x40")]
			public Color rightColor;

			// Token: 0x04000745 RID: 1861
			[Token(Token = "0x4000745")]
			[FieldOffset(Offset = "0x50")]
			public Color bottomColor;

			// Token: 0x04000746 RID: 1862
			[Token(Token = "0x4000746")]
			[FieldOffset(Offset = "0x60")]
			public float leftWidth;

			// Token: 0x04000747 RID: 1863
			[Token(Token = "0x4000747")]
			[FieldOffset(Offset = "0x64")]
			public float topWidth;

			// Token: 0x04000748 RID: 1864
			[Token(Token = "0x4000748")]
			[FieldOffset(Offset = "0x68")]
			public float rightWidth;

			// Token: 0x04000749 RID: 1865
			[Token(Token = "0x4000749")]
			[FieldOffset(Offset = "0x6C")]
			public float bottomWidth;

			// Token: 0x0400074A RID: 1866
			[Token(Token = "0x400074A")]
			[FieldOffset(Offset = "0x70")]
			public Vector2 topLeftRadius;

			// Token: 0x0400074B RID: 1867
			[Token(Token = "0x400074B")]
			[FieldOffset(Offset = "0x78")]
			public Vector2 topRightRadius;

			// Token: 0x0400074C RID: 1868
			[Token(Token = "0x400074C")]
			[FieldOffset(Offset = "0x80")]
			public Vector2 bottomRightRadius;

			// Token: 0x0400074D RID: 1869
			[Token(Token = "0x400074D")]
			[FieldOffset(Offset = "0x88")]
			public Vector2 bottomLeftRadius;

			// Token: 0x0400074E RID: 1870
			[Token(Token = "0x400074E")]
			[FieldOffset(Offset = "0x90")]
			public Material material;

			// Token: 0x0400074F RID: 1871
			[Token(Token = "0x400074F")]
			[FieldOffset(Offset = "0x98")]
			internal ColorPage leftColorPage;

			// Token: 0x04000750 RID: 1872
			[Token(Token = "0x4000750")]
			[FieldOffset(Offset = "0xA0")]
			internal ColorPage topColorPage;

			// Token: 0x04000751 RID: 1873
			[Token(Token = "0x4000751")]
			[FieldOffset(Offset = "0xA8")]
			internal ColorPage rightColorPage;

			// Token: 0x04000752 RID: 1874
			[Token(Token = "0x4000752")]
			[FieldOffset(Offset = "0xB0")]
			internal ColorPage bottomColorPage;
		}

		// Token: 0x0200020D RID: 525
		[Token(Token = "0x200020D")]
		public struct RectangleParams
		{
			// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x5B104D0", Offset = "0x5B0F0D0", VA = "0x185B104D0")]
			private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x5B0F970", Offset = "0x5B0E570", VA = "0x185B0F970")]
			private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
			{
			}

			// Token: 0x06000DF0 RID: 3568 RVA: 0x00006E10 File Offset: 0x00005010
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x5B11D70", Offset = "0x5B10970", VA = "0x185B11D70")]
			private static Rect RectIntersection(Rect a, Rect b)
			{
				return default(Rect);
			}

			// Token: 0x06000DF1 RID: 3569 RVA: 0x00006E28 File Offset: 0x00005028
			[Token(Token = "0x6000DF1")]
			[Address(RVA = "0x5B10A40", Offset = "0x5B0F640", VA = "0x185B10A40")]
			private static Rect ComputeGeomRect(Sprite sprite)
			{
				return default(Rect);
			}

			// Token: 0x06000DF2 RID: 3570 RVA: 0x00006E40 File Offset: 0x00005040
			[Token(Token = "0x6000DF2")]
			[Address(RVA = "0x5B10B70", Offset = "0x5B0F770", VA = "0x185B10B70")]
			private static Rect ComputeUVRect(Sprite sprite)
			{
				return default(Rect);
			}

			// Token: 0x06000DF3 RID: 3571 RVA: 0x00006E58 File Offset: 0x00005058
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x5B10870", Offset = "0x5B0F470", VA = "0x185B10870")]
			private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation)
			{
				return default(Rect);
			}

			// Token: 0x06000DF4 RID: 3572 RVA: 0x00006E70 File Offset: 0x00005070
			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x5B119A0", Offset = "0x5B105A0", VA = "0x185B119A0")]
			public static MeshGenerationContextUtils.RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext)
			{
				return default(MeshGenerationContextUtils.RectangleParams);
			}

			// Token: 0x06000DF5 RID: 3573 RVA: 0x00006E88 File Offset: 0x00005088
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x5B10D00", Offset = "0x5B0F900", VA = "0x185B10D00")]
			public static MeshGenerationContextUtils.RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices)
			{
				return default(MeshGenerationContextUtils.RectangleParams);
			}

			// Token: 0x06000DF6 RID: 3574 RVA: 0x00006EA0 File Offset: 0x000050A0
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x5B11BB0", Offset = "0x5B107B0", VA = "0x185B11BB0")]
			public static MeshGenerationContextUtils.RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext)
			{
				return default(MeshGenerationContextUtils.RectangleParams);
			}

			// Token: 0x06000DF7 RID: 3575 RVA: 0x00006EB8 File Offset: 0x000050B8
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x5B10CA0", Offset = "0x5B0F8A0", VA = "0x185B10CA0")]
			internal bool HasRadius(float epsilon)
			{
				return default(bool);
			}

			// Token: 0x04000753 RID: 1875
			[Token(Token = "0x4000753")]
			[FieldOffset(Offset = "0x0")]
			public Rect rect;

			// Token: 0x04000754 RID: 1876
			[Token(Token = "0x4000754")]
			[FieldOffset(Offset = "0x10")]
			public Rect uv;

			// Token: 0x04000755 RID: 1877
			[Token(Token = "0x4000755")]
			[FieldOffset(Offset = "0x20")]
			public Color color;

			// Token: 0x04000756 RID: 1878
			[Token(Token = "0x4000756")]
			[FieldOffset(Offset = "0x30")]
			public Texture texture;

			// Token: 0x04000757 RID: 1879
			[Token(Token = "0x4000757")]
			[FieldOffset(Offset = "0x38")]
			public Sprite sprite;

			// Token: 0x04000758 RID: 1880
			[Token(Token = "0x4000758")]
			[FieldOffset(Offset = "0x40")]
			public VectorImage vectorImage;

			// Token: 0x04000759 RID: 1881
			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x48")]
			public Material material;

			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x50")]
			public ScaleMode scaleMode;

			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x54")]
			public Color playmodeTintColor;

			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x64")]
			public Vector2 topLeftRadius;

			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x6C")]
			public Vector2 topRightRadius;

			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x74")]
			public Vector2 bottomRightRadius;

			// Token: 0x0400075F RID: 1887
			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0x7C")]
			public Vector2 bottomLeftRadius;

			// Token: 0x04000760 RID: 1888
			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x84")]
			public int leftSlice;

			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x88")]
			public int topSlice;

			// Token: 0x04000762 RID: 1890
			[Token(Token = "0x4000762")]
			[FieldOffset(Offset = "0x8C")]
			public int rightSlice;

			// Token: 0x04000763 RID: 1891
			[Token(Token = "0x4000763")]
			[FieldOffset(Offset = "0x90")]
			public int bottomSlice;

			// Token: 0x04000764 RID: 1892
			[Token(Token = "0x4000764")]
			[FieldOffset(Offset = "0x94")]
			public float sliceScale;

			// Token: 0x04000765 RID: 1893
			[Token(Token = "0x4000765")]
			[FieldOffset(Offset = "0x98")]
			internal Rect spriteGeomRect;

			// Token: 0x04000766 RID: 1894
			[Token(Token = "0x4000766")]
			[FieldOffset(Offset = "0xA8")]
			public Vector4 rectInset;

			// Token: 0x04000767 RID: 1895
			[Token(Token = "0x4000767")]
			[FieldOffset(Offset = "0xB8")]
			internal ColorPage colorPage;

			// Token: 0x04000768 RID: 1896
			[Token(Token = "0x4000768")]
			[FieldOffset(Offset = "0xC0")]
			internal MeshGenerationContext.MeshFlags meshFlags;
		}

		// Token: 0x0200020E RID: 526
		[Token(Token = "0x200020E")]
		public struct TextParams
		{
			// Token: 0x06000DF8 RID: 3576 RVA: 0x00006ED0 File Offset: 0x000050D0
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x5B134C0", Offset = "0x5B120C0", VA = "0x185B134C0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06000DF9 RID: 3577 RVA: 0x00006EE8 File Offset: 0x000050E8
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x5B138D0", Offset = "0x5B124D0", VA = "0x185B138D0")]
			internal static MeshGenerationContextUtils.TextParams MakeStyleBased(VisualElement ve, string text)
			{
				return default(MeshGenerationContextUtils.TextParams);
			}

			// Token: 0x06000DFA RID: 3578 RVA: 0x00006F00 File Offset: 0x00005100
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x5B13700", Offset = "0x5B12300", VA = "0x185B13700")]
			internal static TextNativeSettings GetTextNativeSettings(MeshGenerationContextUtils.TextParams textParams, float scaling)
			{
				return default(TextNativeSettings);
			}

			// Token: 0x04000769 RID: 1897
			[Token(Token = "0x4000769")]
			[FieldOffset(Offset = "0x0")]
			public Rect rect;

			// Token: 0x0400076A RID: 1898
			[Token(Token = "0x400076A")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			// Token: 0x0400076B RID: 1899
			[Token(Token = "0x400076B")]
			[FieldOffset(Offset = "0x18")]
			public Font font;

			// Token: 0x0400076C RID: 1900
			[Token(Token = "0x400076C")]
			[FieldOffset(Offset = "0x20")]
			public FontDefinition fontDefinition;

			// Token: 0x0400076D RID: 1901
			[Token(Token = "0x400076D")]
			[FieldOffset(Offset = "0x30")]
			public int fontSize;

			// Token: 0x0400076E RID: 1902
			[Token(Token = "0x400076E")]
			[FieldOffset(Offset = "0x34")]
			public Length letterSpacing;

			// Token: 0x0400076F RID: 1903
			[Token(Token = "0x400076F")]
			[FieldOffset(Offset = "0x3C")]
			public Length wordSpacing;

			// Token: 0x04000770 RID: 1904
			[Token(Token = "0x4000770")]
			[FieldOffset(Offset = "0x44")]
			public Length paragraphSpacing;

			// Token: 0x04000771 RID: 1905
			[Token(Token = "0x4000771")]
			[FieldOffset(Offset = "0x4C")]
			public FontStyle fontStyle;

			// Token: 0x04000772 RID: 1906
			[Token(Token = "0x4000772")]
			[FieldOffset(Offset = "0x50")]
			public Color fontColor;

			// Token: 0x04000773 RID: 1907
			[Token(Token = "0x4000773")]
			[FieldOffset(Offset = "0x60")]
			public TextAnchor anchor;

			// Token: 0x04000774 RID: 1908
			[Token(Token = "0x4000774")]
			[FieldOffset(Offset = "0x64")]
			public bool wordWrap;

			// Token: 0x04000775 RID: 1909
			[Token(Token = "0x4000775")]
			[FieldOffset(Offset = "0x68")]
			public float wordWrapWidth;

			// Token: 0x04000776 RID: 1910
			[Token(Token = "0x4000776")]
			[FieldOffset(Offset = "0x6C")]
			public bool richText;

			// Token: 0x04000777 RID: 1911
			[Token(Token = "0x4000777")]
			[FieldOffset(Offset = "0x70")]
			public Color playmodeTintColor;

			// Token: 0x04000778 RID: 1912
			[Token(Token = "0x4000778")]
			[FieldOffset(Offset = "0x80")]
			public TextOverflow textOverflow;

			// Token: 0x04000779 RID: 1913
			[Token(Token = "0x4000779")]
			[FieldOffset(Offset = "0x84")]
			public TextOverflowPosition textOverflowPosition;

			// Token: 0x0400077A RID: 1914
			[Token(Token = "0x400077A")]
			[FieldOffset(Offset = "0x88")]
			public OverflowInternal overflow;

			// Token: 0x0400077B RID: 1915
			[Token(Token = "0x400077B")]
			[FieldOffset(Offset = "0x90")]
			public IPanel panel;
		}
	}
}
