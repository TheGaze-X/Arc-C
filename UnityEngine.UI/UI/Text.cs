using System;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	[AddComponentMenu("UI/Legacy/Text", 100)]
	[RequireComponent(typeof(CanvasRenderer))]
	public class Text : MaskableGraphic, ILayoutElement
	{
		// Token: 0x060004D8 RID: 1240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x5B7DF20", Offset = "0x5B7CB20", VA = "0x185B7DF20")]
		protected Text()
		{
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public TextGenerator cachedTextGenerator
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x5B7E0D0", Offset = "0x5B7CCD0", VA = "0x185B7E0D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public TextGenerator cachedTextGeneratorForLayout
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x5B7E050", Offset = "0x5B7CC50", VA = "0x185B7E050")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public override Texture mainTexture
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x5B7E2D0", Offset = "0x5B7CED0", VA = "0x185B7E2D0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x5B7D050", Offset = "0x5B7BC50", VA = "0x185B7D050")]
		public void FontTextureChanged()
		{
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014D")]
		public Font font
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x5B7E270", Offset = "0x5B7CE70", VA = "0x185B7E270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x5B7EDA0", Offset = "0x5B7D9A0", VA = "0x185B7EDA0")]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014E")]
		public virtual string text
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x5B7EAC0", Offset = "0x5B7D6C0", VA = "0x185B7EAC0", Slot = "76")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x5B7F1E0", Offset = "0x5B7DDE0", VA = "0x185B7F1E0", Slot = "77")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003EB8 File Offset: 0x000020B8
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014F")]
		public bool supportRichText
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x5B7EAA0", Offset = "0x5B7D6A0", VA = "0x185B7EAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x5B7F160", Offset = "0x5B7DD60", VA = "0x185B7F160")]
			set
			{
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00003ED0 File Offset: 0x000020D0
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000150")]
		public bool resizeTextForBestFit
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x5B7EA40", Offset = "0x5B7D640", VA = "0x185B7EA40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x5B7EFE0", Offset = "0x5B7DBE0", VA = "0x185B7EFE0")]
			set
			{
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00003EE8 File Offset: 0x000020E8
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000151")]
		public int resizeTextMinSize
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x5B7EA80", Offset = "0x5B7D680", VA = "0x185B7EA80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x5B7F0E0", Offset = "0x5B7DCE0", VA = "0x185B7F0E0")]
			set
			{
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000152")]
		public int resizeTextMaxSize
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x5B7EA60", Offset = "0x5B7D660", VA = "0x185B7EA60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x5B7F060", Offset = "0x5B7DC60", VA = "0x185B7F060")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003F18 File Offset: 0x00002118
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000153")]
		public TextAnchor alignment
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x5B7E030", Offset = "0x5B7CC30", VA = "0x185B7E030")]
			get
			{
				return TextAnchor.UpperLeft;
			}
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x5B7EC20", Offset = "0x5B7D820", VA = "0x185B7EC20")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00003F30 File Offset: 0x00002130
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000154")]
		public bool alignByGeometry
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x5B7E010", Offset = "0x5B7CC10", VA = "0x185B7E010")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x5B7EBC0", Offset = "0x5B7D7C0", VA = "0x185B7EBC0")]
			set
			{
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003F48 File Offset: 0x00002148
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000155")]
		public int fontSize
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x5B7E230", Offset = "0x5B7CE30", VA = "0x185B7E230")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x5B7ECA0", Offset = "0x5B7D8A0", VA = "0x185B7ECA0")]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00003F60 File Offset: 0x00002160
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000156")]
		public HorizontalWrapMode horizontalOverflow
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x5B7E290", Offset = "0x5B7CE90", VA = "0x185B7E290")]
			get
			{
				return HorizontalWrapMode.Wrap;
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x5B7EED0", Offset = "0x5B7DAD0", VA = "0x185B7EED0")]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00003F78 File Offset: 0x00002178
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000157")]
		public VerticalWrapMode verticalOverflow
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x5B7EBA0", Offset = "0x5B7D7A0", VA = "0x185B7EBA0")]
			get
			{
				return VerticalWrapMode.Truncate;
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x5B7F310", Offset = "0x5B7DF10", VA = "0x185B7F310")]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00003F90 File Offset: 0x00002190
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000158")]
		public float lineSpacing
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x5B7E2B0", Offset = "0x5B7CEB0", VA = "0x185B7E2B0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x5B7EF50", Offset = "0x5B7DB50", VA = "0x185B7EF50")]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00003FA8 File Offset: 0x000021A8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000159")]
		public FontStyle fontStyle
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0x5B7E250", Offset = "0x5B7CE50", VA = "0x185B7E250")]
			get
			{
				return FontStyle.Normal;
			}
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0x5B7ED20", Offset = "0x5B7D920", VA = "0x185B7ED20")]
			set
			{
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x1700015A")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x5B7E4D0", Offset = "0x5B7D0D0", VA = "0x185B7E4D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015B")]
		public string aspectsOnlyLegacyText
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x4D6C780", Offset = "0x4D6B380", VA = "0x184D6C780")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x4D6CFE0", Offset = "0x4D6BBE0", VA = "0x184D6CFE0")]
			set
			{
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015C")]
		public string inputText
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x22F8830", Offset = "0x22F7430", VA = "0x1822F8830")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x22F8A30", Offset = "0x22F7630", VA = "0x1822F8A30")]
			set
			{
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00003FD8 File Offset: 0x000021D8
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015D")]
		public TextMode mode
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0x5A12510", Offset = "0x5A11110", VA = "0x185A12510")]
			get
			{
				return TextMode.Localized;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x5B7EFD0", Offset = "0x5B7DBD0", VA = "0x185B7EFD0")]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015E")]
		public string textId
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x4FAD760", Offset = "0x4FAC360", VA = "0x184FAD760")]
			set
			{
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x5B7DE60", Offset = "0x5B7CA60", VA = "0x185B7DE60")]
		private static TextAspects _EnsureAspectsDefault()
		{
			return null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x5B7CFF0", Offset = "0x5B7BBF0", VA = "0x185B7CFF0")]
		public static void BindAspects(TextAspects aspects)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x5B7D5A0", Offset = "0x5B7C1A0", VA = "0x185B7D5A0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x5B7D540", Offset = "0x5B7C140", VA = "0x185B7D540", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x5B7DDE0", Offset = "0x5B7C9E0", VA = "0x185B7DDE0", Slot = "43")]
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x5B7CF90", Offset = "0x5B7BB90", VA = "0x185B7CF90")]
		internal void AssignDefaultFont()
		{
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x5B7CEE0", Offset = "0x5B7BAE0", VA = "0x185B7CEE0")]
		internal void AssignDefaultFontIfNecessary()
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x5B7D170", Offset = "0x5B7BD70", VA = "0x185B7D170")]
		public TextGenerationSettings GetGenerationSettings(Vector2 extents)
		{
			return default(TextGenerationSettings);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x5B7D3D0", Offset = "0x5B7BFD0", VA = "0x185B7D3D0")]
		public static Vector2 GetTextAnchorPivot(TextAnchor anchor)
		{
			return default(Vector2);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x5B7D620", Offset = "0x5B7C220", VA = "0x185B7D620", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "78")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "79")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x1700015F")]
		public virtual float minWidth
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x17000160")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x5B7E840", Offset = "0x5B7D440", VA = "0x185B7E840", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x17000161")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "82")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x17000162")]
		public virtual float minHeight
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "83")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x17000163")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x5B7E640", Offset = "0x5B7D240", VA = "0x185B7E640", Slot = "84")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x17000164")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "85")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x17000165")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "86")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private FontData m_FontData;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xF0")]
		[TextArea(3, 10)]
		[SerializeField]
		protected string m_Text;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xF8")]
		private TextGenerator m_TextCache;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x100")]
		private TextGenerator m_TextCacheForLayout;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_DefaultText;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		protected bool m_DisableFontTextureRebuiltCallback;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x110")]
		[TextArea(3, 10)]
		[SerializeField]
		protected string m_InputText;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string m_TextId;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private TextMode m_Mode;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x128")]
		private string m_TextToShow;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x130")]
		private bool m_TextNotFound;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x138")]
		[NonSerialized]
		public string aspectsOnlyCachedTextId;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x140")]
		[NonSerialized]
		public string aspectsOnlyCachedTextGetById;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x8")]
		private static TextAspects s_aspects;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x148")]
		private readonly UIVertex[] m_TempVerts;
	}
}
