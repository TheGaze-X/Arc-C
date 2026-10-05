using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	internal class TextGenerator
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x59DFFD0", Offset = "0x59DEBD0", VA = "0x1859DFFD0")]
		private static TextGenerator GetTextGenerator()
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x59DF130", Offset = "0x59DDD30", VA = "0x1859DF130")]
		public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x59DF2E0", Offset = "0x59DDEE0", VA = "0x1859DF2E0")]
		public static Vector2 GetCursorPosition(TextInfo textInfo, Rect screenRect, int index, bool inverseYAxis = true)
		{
			return default(Vector2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x59DF990", Offset = "0x59DE590", VA = "0x1859DF990")]
		public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x59E01E0", Offset = "0x59DEDE0", VA = "0x1859E01E0")]
		private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x59D1F20", Offset = "0x59D0B20", VA = "0x1859D1F20")]
		private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x59E1FD0", Offset = "0x59E0BD0", VA = "0x1859E1FD0")]
		private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x59E04D0", Offset = "0x59DF0D0", VA = "0x1859E04D0")]
		protected int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo)
		{
			return 0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x59E36B0", Offset = "0x59E22B0", VA = "0x1859E36B0")]
		protected bool ValidateHtmlTag(int[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(bool);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x59E0910", Offset = "0x59DF510", VA = "0x1859E0910")]
		private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x59E1640", Offset = "0x59E0240", VA = "0x1859E1640")]
		private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x59DDD80", Offset = "0x59DC980", VA = "0x1859DDD80")]
		private void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x59DD710", Offset = "0x59DC310", VA = "0x1859DD710")]
		private void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x59DD580", Offset = "0x59DC180", VA = "0x1859DD580")]
		private static void ClearMesh(bool updateMesh, TextInfo textInfo)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x59DF120", Offset = "0x59DDD20", VA = "0x1859DF120")]
		private void EnableMasking()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x59DD700", Offset = "0x59DC300", VA = "0x1859DD700")]
		private void DisableMasking()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x59E2400", Offset = "0x59E1000", VA = "0x1859E2400")]
		private void SetArraySizes(int[] chars, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x59DFC60", Offset = "0x59DE860", VA = "0x1859DFC60")]
		internal TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x59DD5B0", Offset = "0x59DC1B0", VA = "0x1859DD5B0")]
		private void ComputeMarginSize(Rect rect, Vector4 margins)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x59DFC30", Offset = "0x59DE830", VA = "0x1859DFC30")]
		protected void GetSpecialCharacters(TextGenerationSettings generationSettings)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x59DF500", Offset = "0x59DE100", VA = "0x1859DF500")]
		protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x59E0070", Offset = "0x59DEC70", VA = "0x1859E0070")]
		protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x59DF700", Offset = "0x59DE300", VA = "0x1859DF700")]
		private float GetPaddingForMaterial(Material material, bool extraPadding)
		{
			return 0f;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x59DF830", Offset = "0x59DE430", VA = "0x1859DF830")]
		private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x59DB060", Offset = "0x59D9C60", VA = "0x1859DB060", Slot = "4")]
		protected virtual Vector2 CalculatePreferredValues(float defaultFontSize, Vector2 marginSize, bool ignoreTextAutoSizing, TextGenerationSettings generationSettings, TextInfo textInfo)
		{
			return default(Vector2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x59E7DF0", Offset = "0x59E69F0", VA = "0x1859E7DF0")]
		public TextGenerator()
		{
		}

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		private static TextGenerator s_TextGenerator;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] m_RectTransformCorners;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x18")]
		private float m_MarginWidth;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x1C")]
		private float m_MarginHeight;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x20")]
		private int[] m_CharBuffer;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x28")]
		private float m_PreferredWidth;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x2C")]
		private float m_PreferredHeight;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x30")]
		private FontAsset m_CurrentFontAsset;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x38")]
		private Material m_CurrentMaterial;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x40")]
		private int m_CurrentMaterialIndex;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x48")]
		private TextProcessingStack<MaterialReference> m_MaterialReferenceStack;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xA0")]
		private float m_Padding;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0xA8")]
		private SpriteAsset m_CurrentSpriteAsset;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0xB0")]
		private int m_TotalCharacterCount;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0xB4")]
		private float m_FontScale;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0xB8")]
		private float m_FontSize;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xBC")]
		private float m_FontScaleMultiplier;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xC0")]
		private float m_CurrentFontSize;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xC8")]
		private TextProcessingStack<float> m_SizeStack;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xE8")]
		private FontStyles m_FontStyleInternal;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xEC")]
		private FontStyleStack m_FontStyleStack;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xF8")]
		private TextFontWeight m_FontWeightInternal;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x100")]
		private TextProcessingStack<TextFontWeight> m_FontWeightStack;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x120")]
		private TextAlignment m_LineJustification;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x128")]
		private TextProcessingStack<TextAlignment> m_LineJustificationStack;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x148")]
		private float m_BaselineOffset;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x150")]
		private TextProcessingStack<float> m_BaselineOffsetStack;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x170")]
		private Color32 m_FontColor32;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x174")]
		private Color32 m_HtmlColor;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x178")]
		private Color32 m_UnderlineColor;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x17C")]
		private Color32 m_StrikethroughColor;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x180")]
		private TextProcessingStack<Color32> m_ColorStack;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x1A0")]
		private TextProcessingStack<Color32> m_UnderlineColorStack;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x1C0")]
		private TextProcessingStack<Color32> m_StrikethroughColorStack;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x1E0")]
		private TextProcessingStack<Color32> m_HighlightColorStack;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x200")]
		private TextColorGradient m_ColorGradientPreset;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x208")]
		private TextProcessingStack<TextColorGradient> m_ColorGradientStack;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x230")]
		private TextProcessingStack<int> m_ActionStack;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x250")]
		private bool m_IsFxMatrixSet;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x254")]
		private float m_LineOffset;

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x258")]
		private float m_LineHeight;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x25C")]
		private float m_CSpacing;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x260")]
		private float m_MonoSpacing;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x264")]
		private float m_XAdvance;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x268")]
		private float m_TagLineIndent;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x26C")]
		private float m_TagIndent;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x270")]
		private TextProcessingStack<float> m_IndentStack;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x290")]
		private bool m_TagNoParsing;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x294")]
		private int m_CharacterCount;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x298")]
		private int m_FirstCharacterOfLine;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x29C")]
		private int m_LastCharacterOfLine;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x2A0")]
		private int m_FirstVisibleCharacterOfLine;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x2A4")]
		private int m_LastVisibleCharacterOfLine;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x2A8")]
		private float m_MaxLineAscender;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x2AC")]
		private float m_MaxLineDescender;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x2B0")]
		private int m_LineNumber;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x2B4")]
		private int m_LineVisibleCharacterCount;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x2B8")]
		private int m_FirstOverflowCharacterIndex;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x2BC")]
		private int m_PageNumber;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x2C0")]
		private float m_MarginLeft;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x2C4")]
		private float m_MarginRight;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x2C8")]
		private float m_Width;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x2CC")]
		private Extents m_MeshExtents;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x2DC")]
		private float m_MaxCapHeight;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x2E0")]
		private float m_MaxAscender;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x2E4")]
		private float m_MaxDescender;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x2E8")]
		private bool m_IsNewPage;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x2E9")]
		private bool m_IsNonBreakingSpace;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x2F0")]
		private WordWrapState m_SavedWordWrapState;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x600")]
		private WordWrapState m_SavedLineState;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x910")]
		private int m_LoopCountA;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x914")]
		private TextElementType m_TextElementType;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x915")]
		private bool m_IsParsingText;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x918")]
		private int m_SpriteIndex;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x91C")]
		private Color32 m_SpriteColor;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x920")]
		private TextElement m_CachedTextElement;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x928")]
		private Color32 m_HighlightColor;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x92C")]
		private float m_CharWidthAdjDelta;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x930")]
		private Matrix4x4 m_FxMatrix;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x970")]
		private float m_MaxFontSize;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x974")]
		private float m_MinFontSize;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x978")]
		private bool m_IsCharacterWrappingEnabled;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x97C")]
		private float m_StartOfLineAscender;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x980")]
		private float m_LineSpacingDelta;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x984")]
		private bool m_IsMaskingEnabled;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x988")]
		private MaterialReference[] m_MaterialReferences;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x990")]
		private int m_SpriteCount;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x998")]
		private TextProcessingStack<int> m_StyleStack;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x9B8")]
		private int m_SpriteAnimationId;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x9C0")]
		private uint[] m_InternalTextParsingBuffer;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x9C8")]
		private RichTextTagAttribute[] m_Attributes;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x9D0")]
		private XmlTagAttribute[] m_XmlAttribute;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x9D8")]
		private char[] m_RichTextTag;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x9E0")]
		private Dictionary<int, int> m_MaterialReferenceIndexLookup;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x9E8")]
		private bool m_IsCalculatingPreferredValues;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x9F0")]
		private SpriteAsset m_DefaultSpriteAsset;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x9F8")]
		private bool m_TintSprite;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0xA00")]
		protected TextGenerator.SpecialCharacter m_Ellipsis;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0xA20")]
		protected TextGenerator.SpecialCharacter m_Underline;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0xA40")]
		private bool m_IsUsingBold;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0xA41")]
		private bool m_IsSdfShader;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0xA48")]
		private TextElementInfo[] m_InternalTextElementInfo;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xA50")]
		private int m_RecursiveCount;

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		protected struct SpecialCharacter
		{
			// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x59F5250", Offset = "0x59F3E50", VA = "0x1859F5250")]
			public SpecialCharacter(Character character, int materialIndex)
			{
			}

			// Token: 0x0400018E RID: 398
			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x0")]
			public Character character;

			// Token: 0x0400018F RID: 399
			[Token(Token = "0x400018F")]
			[FieldOffset(Offset = "0x8")]
			public FontAsset fontAsset;

			// Token: 0x04000190 RID: 400
			[Token(Token = "0x4000190")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			// Token: 0x04000191 RID: 401
			[Token(Token = "0x4000191")]
			[FieldOffset(Offset = "0x18")]
			public int materialIndex;
		}
	}
}
