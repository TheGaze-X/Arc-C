using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	[HelpURL("UIE-USS")]
	[Serializable]
	public class StyleSheet : ScriptableObject
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00009300 File Offset: 0x00007500
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044D")]
		public bool importedWithErrors
		{
			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x5B238D0", Offset = "0x5B224D0", VA = "0x185B238D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			internal set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00009318 File Offset: 0x00007518
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044E")]
		public bool importedWithWarnings
		{
			[Token(Token = "0x60010E2")]
			[Address(RVA = "0x5B238E0", Offset = "0x5B224E0", VA = "0x185B238E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010E3")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			internal set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044F")]
		internal StyleRule[] rules
		{
			[Token(Token = "0x60010E4")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E5")]
			[Address(RVA = "0x5B23A40", Offset = "0x5B22640", VA = "0x185B23A40")]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000450")]
		internal StyleComplexSelector[] complexSelectors
		{
			[Token(Token = "0x60010E6")]
			[Address(RVA = "0x5911BD0", Offset = "0x59107D0", VA = "0x185911BD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x5B23900", Offset = "0x5B22500", VA = "0x185B23900")]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000451")]
		internal List<StyleSheet> flattenedRecursiveImports
		{
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x5997680", Offset = "0x5996280", VA = "0x185997680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00009330 File Offset: 0x00007530
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		public int contentHash
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x5B238C0", Offset = "0x5B224C0", VA = "0x185B238C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x4A55A20", Offset = "0x4A54620", VA = "0x184A55A20")]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00009348 File Offset: 0x00007548
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		internal bool isDefaultStyleSheet
		{
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x5B238F0", Offset = "0x5B224F0", VA = "0x185B238F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x5B23930", Offset = "0x5B22530", VA = "0x185B23930")]
			set
			{
			}
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x60010ED")]
		private static bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value)
		{
			return default(bool);
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010EE")]
		private static T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x5B224A0", Offset = "0x5B210A0", VA = "0x185B224A0", Slot = "4")]
		internal virtual void OnEnable()
		{
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x5B22410", Offset = "0x5B21010", VA = "0x185B22410")]
		internal void FlattenImportedStyleSheetsRecursive()
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x5B222F0", Offset = "0x5B20EF0", VA = "0x185B222F0")]
		private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
		{
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x5B22CD0", Offset = "0x5B218D0", VA = "0x185B22CD0")]
		private void SetupReferences()
		{
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x5B22A20", Offset = "0x5B21620", VA = "0x185B22A20")]
		internal StyleValueKeyword ReadKeyword(StyleValueHandle handle)
		{
			return StyleValueKeyword.Inherit;
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x5B22730", Offset = "0x5B21330", VA = "0x185B22730")]
		internal float ReadFloat(StyleValueHandle handle)
		{
			return 0f;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x5B235A0", Offset = "0x5B221A0", VA = "0x185B235A0")]
		internal bool TryReadFloat(StyleValueHandle handle, out float value)
		{
			return default(bool);
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x60010F6")]
		[Address(RVA = "0x5B225D0", Offset = "0x5B211D0", VA = "0x185B225D0")]
		internal Dimension ReadDimension(StyleValueHandle handle)
		{
			return default(Dimension);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x60010F7")]
		[Address(RVA = "0x5B233F0", Offset = "0x5B21FF0", VA = "0x185B233F0")]
		internal bool TryReadDimension(StyleValueHandle handle, out Dimension value)
		{
			return default(bool);
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x60010F8")]
		[Address(RVA = "0x5B22530", Offset = "0x5B21130", VA = "0x185B22530")]
		internal Color ReadColor(StyleValueHandle handle)
		{
			return default(Color);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x60010F9")]
		[Address(RVA = "0x5B23360", Offset = "0x5B21F60", VA = "0x185B23360")]
		internal bool TryReadColor(StyleValueHandle handle, out Color value)
		{
			return default(bool);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010FA")]
		[Address(RVA = "0x5B22BD0", Offset = "0x5B217D0", VA = "0x185B22BD0")]
		internal string ReadString(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x5B23730", Offset = "0x5B22330", VA = "0x185B23730")]
		internal bool TryReadString(StyleValueHandle handle, out string value)
		{
			return default(bool);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x5B226B0", Offset = "0x5B212B0", VA = "0x185B226B0")]
		internal string ReadEnum(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x5B23510", Offset = "0x5B22110", VA = "0x185B23510")]
		internal bool TryReadEnum(StyleValueHandle handle, out string value)
		{
			return default(bool);
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x5B22C50", Offset = "0x5B21850", VA = "0x185B22C50")]
		internal string ReadVariable(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x5B237C0", Offset = "0x5B223C0", VA = "0x185B237C0")]
		internal bool TryReadVariable(StyleValueHandle handle, out string value)
		{
			return default(bool);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x5B22AB0", Offset = "0x5B216B0", VA = "0x185B22AB0")]
		internal string ReadResourcePath(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x5B236A0", Offset = "0x5B222A0", VA = "0x185B236A0")]
		internal bool TryReadResourcePath(StyleValueHandle handle, out string value)
		{
			return default(bool);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x5B224B0", Offset = "0x5B210B0", VA = "0x185B224B0")]
		internal Object ReadAssetReference(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x5B22A30", Offset = "0x5B21630", VA = "0x185B22A30")]
		internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x5B232D0", Offset = "0x5B21ED0", VA = "0x185B232D0")]
		internal bool TryReadAssetReference(StyleValueHandle handle, out Object value)
		{
			return default(bool);
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x5B22A20", Offset = "0x5B21620", VA = "0x185B22A20")]
		internal StyleValueFunction ReadFunction(StyleValueHandle handle)
		{
			return StyleValueFunction.Unknown;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x5B22800", Offset = "0x5B21400", VA = "0x185B22800")]
		internal string ReadFunctionName(StyleValueHandle handle)
		{
			return null;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x5B22B30", Offset = "0x5B21730", VA = "0x185B22B30")]
		internal ScalableImage ReadScalableImage(StyleValueHandle handle)
		{
			return default(ScalableImage);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x5B22220", Offset = "0x5B20E20", VA = "0x185B22220")]
		private static bool CustomStartsWith(string originalString, string pattern)
		{
			return default(bool);
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public StyleSheet()
		{
		}

		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x40008B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_ImportedWithErrors;

		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x40008B1")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_ImportedWithWarnings;

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StyleRule[] m_Rules;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StyleComplexSelector[] m_ComplexSelectors;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		internal float[] floats;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal Dimension[] dimensions;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal Color[] colors;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal string[] strings;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal Object[] assets;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		internal StyleSheet.ImportStruct[] imports;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<StyleSheet> m_FlattenedImportedStyleSheets;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int m_ContentHash;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		internal ScalableImage[] scalableImages;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedNameSelectors;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector> orderedClassSelectors;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		private bool m_IsDefaultStyleSheet;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x0")]
		private static string kCustomPropertyMarker;

		// Token: 0x02000253 RID: 595
		[Token(Token = "0x2000253")]
		[Serializable]
		internal struct ImportStruct
		{
			// Token: 0x040008C2 RID: 2242
			[Token(Token = "0x40008C2")]
			[FieldOffset(Offset = "0x0")]
			public StyleSheet styleSheet;

			// Token: 0x040008C3 RID: 2243
			[Token(Token = "0x40008C3")]
			[FieldOffset(Offset = "0x8")]
			public string[] mediaQueries;
		}
	}
}
