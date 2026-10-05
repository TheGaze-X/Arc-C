using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000118 RID: 280
	[Token(Token = "0x2000118")]
	public class Image : VisualElement
	{
		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001AB")]
		public Texture image
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x5AB52A0", Offset = "0x5AB3EA0", VA = "0x185AB52A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001AC")]
		public Sprite sprite
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x5A91260", Offset = "0x5A8FE60", VA = "0x185A91260")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001AD")]
		public VectorImage vectorImage
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x5A8FDA0", Offset = "0x5A8E9A0", VA = "0x185A8FDA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x170001AE")]
		public Rect sourceRect
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x5AB52C0", Offset = "0x5AB3EC0", VA = "0x185AB52C0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x170001AF")]
		public Rect uv
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x5AB5300", Offset = "0x5AB3F00", VA = "0x185AB5300")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x170001B0")]
		public ScaleMode scaleMode
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x5AB52B0", Offset = "0x5AB3EB0", VA = "0x185AB52B0")]
			get
			{
				return ScaleMode.StretchToFill;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x170001B1")]
		public Color tintColor
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x5AB52F0", Offset = "0x5AB3EF0", VA = "0x185AB52F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x5AB5090", Offset = "0x5AB3C90", VA = "0x185AB5090")]
		public Image()
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x5AB4110", Offset = "0x5AB2D10", VA = "0x185AB4110")]
		private Vector2 GetTextureDisplaySize(Texture texture)
		{
			return default(Vector2);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x5AB4230", Offset = "0x5AB2E30", VA = "0x185AB4230")]
		private Vector2 GetTextureDisplaySize(Sprite sprite)
		{
			return default(Vector2);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x5AB3AE0", Offset = "0x5AB26E0", VA = "0x185AB3AE0", Slot = "95")]
		protected internal override Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x5AB4950", Offset = "0x5AB3550", VA = "0x185AB4950")]
		private void OnGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x5AB4330", Offset = "0x5AB2F30", VA = "0x185AB4330")]
		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x5AB4E20", Offset = "0x5AB3A20", VA = "0x185AB4E20")]
		private void SetScaleMode(ScaleMode mode)
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x5AB3E90", Offset = "0x5AB2A90", VA = "0x185AB3E90")]
		private Rect GetSourceRect()
		{
			return default(Rect);
		}

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x3B0")]
		private ScaleMode m_ScaleMode;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x3B8")]
		private Texture m_Image;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x3C0")]
		private Sprite m_Sprite;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x3C8")]
		private VectorImage m_VectorImage;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x3D0")]
		private Rect m_UV;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x3E0")]
		private Color m_TintColor;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x3F0")]
		private bool m_ImageIsInline;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x3F1")]
		private bool m_ScaleModeIsInline;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x3F2")]
		private bool m_TintColorIsInline;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x8")]
		private static CustomStyleProperty<Texture2D> s_ImageProperty;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x10")]
		private static CustomStyleProperty<Sprite> s_SpriteProperty;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x18")]
		private static CustomStyleProperty<VectorImage> s_VectorImageProperty;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x20")]
		private static CustomStyleProperty<string> s_ScaleModeProperty;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x28")]
		private static CustomStyleProperty<Color> s_TintColorProperty;

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		public new class UxmlFactory : UxmlFactory<Image, Image.UxmlTraits>
		{
			// Token: 0x0600081A RID: 2074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x5ABD2E0", Offset = "0x5ABBEE0", VA = "0x185ABD2E0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200011A RID: 282
		[Token(Token = "0x200011A")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x5ABEFF0", Offset = "0x5ABDBF0", VA = "0x185ABEFF0")]
			public UxmlTraits()
			{
			}
		}
	}
}
