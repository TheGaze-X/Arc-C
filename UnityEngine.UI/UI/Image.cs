using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Serialization;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[RequireComponent(typeof(CanvasRenderer))]
	[AddComponentMenu("UI/Image", 11)]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002568 File Offset: 0x00000768
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public Rect runtimeAtlasRect
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x5A21EF0", Offset = "0x5A20AF0", VA = "0x185A21EF0")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x5A22510", Offset = "0x5A21110", VA = "0x185A22510")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002580 File Offset: 0x00000780
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public Rect runtimeAtlasTextureRect
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x5A220A0", Offset = "0x5A20CA0", VA = "0x185A220A0")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x5A22520", Offset = "0x5A21120", VA = "0x185A22520")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x06000144 RID: 324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public Vector4 runtimeAtlasBorder
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x5A21ED0", Offset = "0x5A20AD0", VA = "0x185A21ED0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x5A224F0", Offset = "0x5A210F0", VA = "0x185A224F0")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000146 RID: 326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000050")]
		public float runtimeAtlasPixelsPerUnit
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x5A21EE0", Offset = "0x5A20AE0", VA = "0x185A21EE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x5A22500", Offset = "0x5A21100", VA = "0x185A22500")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000147 RID: 327 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000051")]
		public int atlasHandleId
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x58881E0", Offset = "0x5886DE0", VA = "0x1858881E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x5A220D0", Offset = "0x5A20CD0", VA = "0x185A220D0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x17000052")]
		public virtual bool packIntoRuntimeAtlas
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xD742E0", Offset = "0xD72EE0", VA = "0x180D742E0", Slot = "79")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public ref RuntimeAtlas.AtlasHandle atlasHandle
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x5A21320", Offset = "0x5A1FF20", VA = "0x185A21320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600014B RID: 331 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x17000054")]
		public int panelLevel
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x5A21A10", Offset = "0x5A20610", VA = "0x185A21A10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000055")]
		public Sprite sprite
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x5A22530", Offset = "0x5A21130", VA = "0x185A22530")]
			set
			{
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x17000056")]
		public bool enableRuntimeAtlasRaw
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000057")]
		public override bool enableRuntimeAtlas
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x5A21430", Offset = "0x5A20030", VA = "0x185A21430", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x5A19200", Offset = "0x5A17E00", VA = "0x185A19200", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5A20590", Offset = "0x5A1F190", VA = "0x185A20590")]
		public void ReleaseSprite()
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5A204E0", Offset = "0x5A1F0E0", VA = "0x185A204E0")]
		public void RegisterOnEnableRuntimeAtlas(Action callBack)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x5A20D40", Offset = "0x5A1F940", VA = "0x185A20D40")]
		public void UnregisterOnEnableRuntimeAtlas(Action callBack)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5A1F8A0", Offset = "0x5A1E4A0", VA = "0x185A1F8A0")]
		public void OnEnableRuntimeAtlas()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5A198E0", Offset = "0x5A184E0", VA = "0x185A198E0")]
		public void DisableSpriteOptimizations()
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000058")]
		public Sprite overrideSprite
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x5A21A00", Offset = "0x5A20600", VA = "0x185A21A00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x5A223A0", Offset = "0x5A20FA0", VA = "0x185A223A0")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		private Sprite activeSprite
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x5A21290", Offset = "0x5A1FE90", VA = "0x185A21290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005A")]
		public Image.Type type
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x5A220B0", Offset = "0x5A20CB0", VA = "0x185A220B0")]
			get
			{
				return Image.Type.Simple;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x5A22880", Offset = "0x5A21480", VA = "0x185A22880")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005B")]
		public bool preserveAspect
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x5A21EC0", Offset = "0x5A20AC0", VA = "0x185A21EC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x5A22470", Offset = "0x5A21070", VA = "0x185A22470")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005C")]
		public bool fillCenter
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x5A214C0", Offset = "0x5A200C0", VA = "0x185A214C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x5A221A0", Offset = "0x5A20DA0", VA = "0x185A221A0")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005D")]
		public Image.FillMethod fillMethod
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x5A214D0", Offset = "0x5A200D0", VA = "0x185A214D0")]
			get
			{
				return Image.FillMethod.Horizontal;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x5A222A0", Offset = "0x5A20EA0", VA = "0x185A222A0")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005E")]
		public float fillAmount
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x58A1730", Offset = "0x58A0330", VA = "0x1858A1730")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x5A22100", Offset = "0x5A20D00", VA = "0x185A22100")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005F")]
		public bool fillClockwise
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xF9BA40", Offset = "0xF9A640", VA = "0x180F9BA40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x5A22220", Offset = "0x5A20E20", VA = "0x185A22220")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000165 RID: 357 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000060")]
		public int fillOrigin
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x58A1290", Offset = "0x589FE90", VA = "0x1858A1290")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x5A22320", Offset = "0x5A20F20", VA = "0x185A22320")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000061")]
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		public float eventAlphaThreshold
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x5A214A0", Offset = "0x5A200A0", VA = "0x185A214A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x5A220E0", Offset = "0x5A20CE0", VA = "0x185A220E0")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000062")]
		public float alphaHitTestMinimumThreshold
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x5A21310", Offset = "0x5A1FF10", VA = "0x185A21310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x59F25F0", Offset = "0x59F11F0", VA = "0x1859F25F0")]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000063")]
		public bool useSpriteMesh
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x5A220C0", Offset = "0x5A20CC0", VA = "0x185A220C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x5A22900", Offset = "0x5A21500", VA = "0x185A22900")]
			set
			{
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5A21200", Offset = "0x5A1FE00", VA = "0x185A21200")]
		protected Image()
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public static Material defaultETC1GraphicMaterial
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x5A21330", Offset = "0x5A1FF30", VA = "0x185A21330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x5A21600", Offset = "0x5A20200", VA = "0x185A21600", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000066")]
		public Texture runtimeAtlasSource
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x5A21F00", Offset = "0x5A20B00", VA = "0x185A21F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x17000067")]
		public bool hasBorder
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x5A214E0", Offset = "0x5A200E0", VA = "0x185A214E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002748 File Offset: 0x00000948
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000068")]
		public float pixelsPerUnitMultiplier
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x5A21A20", Offset = "0x5A20620", VA = "0x185A21A20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x5A22420", Offset = "0x5A21020", VA = "0x185A22420")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x17000069")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x5A21A30", Offset = "0x5A20630", VA = "0x185A21A30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x1700006A")]
		protected float multipliedPixelsPerUnit
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x5A219E0", Offset = "0x5A205E0", VA = "0x185A219E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006B")]
		public override Material material
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x5A217B0", Offset = "0x5A203B0", VA = "0x185A217B0", Slot = "34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x5A19260", Offset = "0x5A17E60", VA = "0x185A19260", Slot = "35")]
			set
			{
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "80")]
		public virtual void OnBeforeSerialize()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5A1F3B0", Offset = "0x5A1DFB0", VA = "0x185A1F3B0", Slot = "81")]
		public virtual void OnAfterDeserialize()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5A1FAB0", Offset = "0x5A1E6B0", VA = "0x185A1FAB0")]
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5A1E0C0", Offset = "0x5A1CCC0", VA = "0x185A1E0C0")]
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x5A205B0", Offset = "0x5A1F1B0", VA = "0x185A205B0", Slot = "47")]
		public override void SetNativeSize()
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5A1F960", Offset = "0x5A1E560", VA = "0x185A1F960", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5A20AD0", Offset = "0x5A1F6D0", VA = "0x185A20AD0")]
		private void TrackSprite()
		{
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5A19870", Offset = "0x5A18470", VA = "0x185A19870")]
		public static void BindAspects(ImageAspects aspects)
		{
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5A197D0", Offset = "0x5A183D0", VA = "0x185A197D0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5A1F590", Offset = "0x5A1E190", VA = "0x185A1F590", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5A1F8C0", Offset = "0x5A1E4C0", VA = "0x185A1F8C0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x5A1F7D0", Offset = "0x5A1E3D0", VA = "0x185A1F7D0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5A20DF0", Offset = "0x5A1F9F0", VA = "0x185A20DF0", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5A1F410", Offset = "0x5A1E010", VA = "0x185A1F410", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5A1B150", Offset = "0x5A19D50", VA = "0x185A1B150")]
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x5A1BF60", Offset = "0x5A1AB60", VA = "0x185A1BF60")]
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5A1B550", Offset = "0x5A1A150", VA = "0x185A1B550")]
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x5A1C570", Offset = "0x5A1B170", VA = "0x185A1C570")]
		private void GenerateTiledSprite(VertexHelper toFill)
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5A19680", Offset = "0x5A18280", VA = "0x185A19680")]
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5A19440", Offset = "0x5A18040", VA = "0x185A19440")]
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5A1DD50", Offset = "0x5A1C950", VA = "0x185A1DD50")]
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			return default(Vector4);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5A198F0", Offset = "0x5A184F0", VA = "0x185A198F0")]
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5A1FCB0", Offset = "0x5A1E8B0", VA = "0x185A1FCB0")]
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			return default(bool);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5A1FE00", Offset = "0x5A1EA00", VA = "0x185A1FE00")]
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "82")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "83")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x1700006C")]
		public virtual float minWidth
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "84")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000193 RID: 403 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x1700006D")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5A21D10", Offset = "0x5A20910", VA = "0x185A21D10", Slot = "85")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700006E")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "86")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x1700006F")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "87")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x17000070")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x5A21BB0", Offset = "0x5A207B0", VA = "0x185A21BB0", Slot = "88")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000071")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "89")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000072")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5A1EA60", Offset = "0x5A1D660", VA = "0x185A1EA60", Slot = "91")]
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			return default(bool);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5A1EE30", Offset = "0x5A1DA30", VA = "0x185A1EE30")]
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			return default(Vector2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x5A202E0", Offset = "0x5A1EEE0", VA = "0x185A202E0")]
		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5A209A0", Offset = "0x5A1F5A0", VA = "0x185A209A0")]
		private static void TrackImage(Image g)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5A20CC0", Offset = "0x5A1F8C0", VA = "0x185A20CC0")]
		private static void UnTrackImage(Image g)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5A1F770", Offset = "0x5A1E370", VA = "0x185A1F770", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5A1E980", Offset = "0x5A1D580", VA = "0x185A1E980")]
		protected Vector4 GetRuntimeAtlasSpritePadding()
		{
			return default(Vector4);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x5A1E7E0", Offset = "0x5A1D3E0", VA = "0x185A1E7E0")]
		protected Vector4 GetRuntimeAtlasSpriteOuterUV()
		{
			return default(Vector4);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x5A1E4F0", Offset = "0x5A1D0F0", VA = "0x185A1E4F0")]
		protected Vector4 GetRuntimeAtlasSpriteInnerUV()
		{
			return default(Vector4);
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		protected static Material s_ETC1DefaultUI;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xE8")]
		[FormerlySerializedAs("m_Frame")]
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		protected Rect m_RuntimeAtlasRect;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		protected Rect m_RuntimeAtlasTextureRect;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x110")]
		[NonSerialized]
		protected Vector4 m_RuntimeAtlasBorder;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x120")]
		[NonSerialized]
		protected float m_RuntimeAtlasPixelsPerUnit;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool m_PackIntoRuntimeAtlas;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private int m_AtlasHandleId;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x12C")]
		private RuntimeAtlas.AtlasHandle m_atlasHandle;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x150")]
		private int m_panelLevel;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x158")]
		private Action m_onEnableRuntimeAtlas;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x160")]
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Image.Type m_Type;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private bool m_PreserveAspect;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x16D")]
		[SerializeField]
		private bool m_FillCenter;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Image.FillMethod m_FillMethod;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_FillAmount;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private bool m_FillClockwise;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private int m_FillOrigin;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x180")]
		private float m_AlphaHitTestMinimumThreshold;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x184")]
		private bool m_Tracked;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x185")]
		[SerializeField]
		private bool m_UseSpriteMesh;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private float m_PixelsPerUnitMultiplier;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18C")]
		private float m_CachedReferencePixelsPerUnit;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x8")]
		private static ImageAspects s_aspects;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2[] s_VertScratch;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector2[] s_UVScratch;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector3[] s_Xy;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Vector3[] s_Uv;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x30")]
		private static List<Image> m_TrackedTexturelessImages;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x38")]
		private static bool s_Initialized;

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public enum Type
		{
			// Token: 0x040000B3 RID: 179
			[Token(Token = "0x40000B3")]
			Simple,
			// Token: 0x040000B4 RID: 180
			[Token(Token = "0x40000B4")]
			Sliced,
			// Token: 0x040000B5 RID: 181
			[Token(Token = "0x40000B5")]
			Tiled,
			// Token: 0x040000B6 RID: 182
			[Token(Token = "0x40000B6")]
			Filled
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public enum FillMethod
		{
			// Token: 0x040000B8 RID: 184
			[Token(Token = "0x40000B8")]
			Horizontal,
			// Token: 0x040000B9 RID: 185
			[Token(Token = "0x40000B9")]
			Vertical,
			// Token: 0x040000BA RID: 186
			[Token(Token = "0x40000BA")]
			Radial90,
			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			Radial180,
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			Radial360
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public enum OriginHorizontal
		{
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			Left,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			Right
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public enum OriginVertical
		{
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			Bottom,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			Top
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public enum Origin90
		{
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			BottomLeft,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			TopLeft,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			TopRight,
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			BottomRight
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public enum Origin180
		{
			// Token: 0x040000C9 RID: 201
			[Token(Token = "0x40000C9")]
			Bottom,
			// Token: 0x040000CA RID: 202
			[Token(Token = "0x40000CA")]
			Left,
			// Token: 0x040000CB RID: 203
			[Token(Token = "0x40000CB")]
			Top,
			// Token: 0x040000CC RID: 204
			[Token(Token = "0x40000CC")]
			Right
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public enum Origin360
		{
			// Token: 0x040000CE RID: 206
			[Token(Token = "0x40000CE")]
			Bottom,
			// Token: 0x040000CF RID: 207
			[Token(Token = "0x40000CF")]
			Right,
			// Token: 0x040000D0 RID: 208
			[Token(Token = "0x40000D0")]
			Top,
			// Token: 0x040000D1 RID: 209
			[Token(Token = "0x40000D1")]
			Left
		}
	}
}
