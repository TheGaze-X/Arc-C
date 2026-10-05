using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	internal class StylePropertyReader
	{
		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000519")]
		public StyleProperty property
		{
			[Token(Token = "0x6001483")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001484")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0000AE00 File Offset: 0x00009000
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051A")]
		public StylePropertyId propertyId
		{
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x509F60", Offset = "0x508B60", VA = "0x180509F60")]
			[CompilerGenerated]
			get
			{
				return StylePropertyId.Unknown;
			}
			[Token(Token = "0x6001486")]
			[Address(RVA = "0x509F70", Offset = "0x508B70", VA = "0x180509F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0000AE18 File Offset: 0x00009018
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public int valueCount
		{
			[Token(Token = "0x6001487")]
			[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x53DA830", Offset = "0x53D9430", VA = "0x1853DA830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0000AE30 File Offset: 0x00009030
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051C")]
		public float dpiScaling
		{
			[Token(Token = "0x6001489")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x5A82A30", Offset = "0x5A81630", VA = "0x185A82A30")]
		public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f)
		{
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x5A82BF0", Offset = "0x5A817F0", VA = "0x185A82BF0")]
		public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1f)
		{
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x5A7F920", Offset = "0x5A7E520", VA = "0x185A7F920")]
		public StylePropertyId MoveNextProperty()
		{
			return StylePropertyId.Unknown;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x5A7F390", Offset = "0x5A7DF90", VA = "0x185A7F390")]
		public StylePropertyValue GetValue(int index)
		{
			return default(StylePropertyValue);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x5A7F310", Offset = "0x5A7DF10", VA = "0x185A7F310")]
		public StyleValueType GetValueType(int index)
		{
			return StyleValueType.Invalid;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x5A7F4B0", Offset = "0x5A7E0B0", VA = "0x185A7F4B0")]
		public bool IsValueType(int index, StyleValueType type)
		{
			return default(bool);
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x5A7F410", Offset = "0x5A7E010", VA = "0x185A7F410")]
		public bool IsKeyword(int index, StyleValueKeyword keyword)
		{
			return default(bool);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x5A7FAA0", Offset = "0x5A7E6A0", VA = "0x185A7FAA0")]
		public string ReadAsString(int index)
		{
			return null;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x5A80CD0", Offset = "0x5A7F8D0", VA = "0x185A80CD0")]
		public Length ReadLength(int index)
		{
			return default(Length);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x5A81EF0", Offset = "0x5A80AF0", VA = "0x185A81EF0")]
		public TimeValue ReadTimeValue(int index)
		{
			return default(TimeValue);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x5A825F0", Offset = "0x5A811F0", VA = "0x185A825F0")]
		public Translate ReadTranslate(int index)
		{
			return default(Translate);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x5A821D0", Offset = "0x5A80DD0", VA = "0x185A821D0")]
		public TransformOrigin ReadTransformOrigin(int index)
		{
			return default(TransformOrigin);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x5A81530", Offset = "0x5A80130", VA = "0x185A81530")]
		public Rotate ReadRotate(int index)
		{
			return default(Rotate);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x5A81A10", Offset = "0x5A80610", VA = "0x185A81A10")]
		public Scale ReadScale(int index)
		{
			return default(Scale);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x5A80420", Offset = "0x5A7F020", VA = "0x185A80420")]
		public float ReadFloat(int index)
		{
			return 0f;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x5A80C50", Offset = "0x5A7F850", VA = "0x185A80C50")]
		public int ReadInt(int index)
		{
			return 0;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x5A7FD80", Offset = "0x5A7E980", VA = "0x185A7FD80")]
		public Color ReadColor(int index)
		{
			return default(Color);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x5A80320", Offset = "0x5A7EF20", VA = "0x185A80320")]
		public int ReadEnum(StyleEnumType enumType, int index)
		{
			return 0;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x5A804A0", Offset = "0x5A7F0A0", VA = "0x185A804A0")]
		public FontDefinition ReadFontDefinition(int index)
		{
			return default(FontDefinition);
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x5A80950", Offset = "0x5A7F550", VA = "0x185A80950")]
		public Font ReadFont(int index)
		{
			return null;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x5A7FB10", Offset = "0x5A7E710", VA = "0x185A7FB10")]
		public Background ReadBackground(int index)
		{
			return default(Background);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x5A7FEA0", Offset = "0x5A7EAA0", VA = "0x185A7FEA0")]
		public Cursor ReadCursor(int index)
		{
			return default(Cursor);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x5A81B50", Offset = "0x5A80750", VA = "0x185A81B50")]
		public TextShadow ReadTextShadow(int index)
		{
			return default(TextShadow);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x5A80DE0", Offset = "0x5A7F9E0", VA = "0x185A80DE0")]
		public void ReadListEasingFunction(List<EasingFunction> list, int index)
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x5A811B0", Offset = "0x5A7FDB0", VA = "0x185A811B0")]
		public void ReadListTimeValue(List<TimeValue> list, int index)
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x5A80FE0", Offset = "0x5A7FBE0", VA = "0x185A80FE0")]
		public void ReadListStylePropertyName(List<StylePropertyName> list, int index)
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x5A7F540", Offset = "0x5A7E140", VA = "0x185A7F540")]
		private void LoadProperties()
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x5A82B30", Offset = "0x5A81730", VA = "0x185A82B30")]
		private void SetCurrentProperty()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x5A82440", Offset = "0x5A81040", VA = "0x185A82440")]
		public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue)
		{
			return default(TransformOrigin);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x5A81FA0", Offset = "0x5A80BA0", VA = "0x185A81FA0")]
		private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal)
		{
			return default(Length);
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x5A82750", Offset = "0x5A81350", VA = "0x185A82750")]
		public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
		{
			return default(Translate);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x5A817E0", Offset = "0x5A803E0", VA = "0x185A817E0")]
		public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
		{
			return default(Scale);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x5A81350", Offset = "0x5A7FF50", VA = "0x185A81350")]
		public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4)
		{
			return default(Rotate);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x5A80250", Offset = "0x5A7EE50", VA = "0x185A80250")]
		private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value)
		{
			return 0;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x5A7F950", Offset = "0x5A7E550", VA = "0x185A7F950")]
		public static Angle ReadAngle(StylePropertyValue value)
		{
			return default(Angle);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x5A82C60", Offset = "0x5A81860", VA = "0x185A82C60")]
		internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source)
		{
			return default(bool);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x5A832E0", Offset = "0x5A81EE0", VA = "0x185A832E0")]
		public StylePropertyReader()
		{
		}

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[FieldOffset(Offset = "0x0")]
		internal static StylePropertyReader.GetCursorIdFunction getCursorIdFunc;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x10")]
		private List<StylePropertyValue> m_Values;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x18")]
		private List<int> m_ValueCount;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x20")]
		private StyleVariableResolver m_Resolver;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x28")]
		private StyleSheet m_Sheet;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x30")]
		private StyleProperty[] m_Properties;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x38")]
		private StylePropertyId[] m_PropertyIds;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x40")]
		private int m_CurrentValueIndex;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x44")]
		private int m_CurrentPropertyIndex;

		// Token: 0x020002EE RID: 750
		// (Invoke) Token: 0x060014B1 RID: 5297
		[Token(Token = "0x20002EE")]
		internal delegate int GetCursorIdFunction(StyleSheet sheet, StyleValueHandle handle);
	}
}
