using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	[HelpURL("UIE-Runtime-Panel-Settings")]
	public class PanelSettings : ScriptableObject
	{
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000304")]
		public ThemeStyleSheet themeStyleSheet
		{
			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x5B0EDC0", Offset = "0x5B0D9C0", VA = "0x185B0EDC0")]
			set
			{
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		public RenderTexture targetTexture
		{
			[Token(Token = "0x6000D43")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x5B0ED60", Offset = "0x5B0D960", VA = "0x185B0ED60")]
			set
			{
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000069F0 File Offset: 0x00004BF0
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		public PanelScaleMode scaleMode
		{
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return PanelScaleMode.ConstantPixelSize;
			}
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00006A08 File Offset: 0x00004C08
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000307")]
		public float scale
		{
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x00006A20 File Offset: 0x00004C20
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		public float referenceDpi
		{
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x5B0ECB0", Offset = "0x5B0D8B0", VA = "0x185B0ECB0")]
			set
			{
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x00006A38 File Offset: 0x00004C38
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000309")]
		public float fallbackDpi
		{
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x5B0EC80", Offset = "0x5B0D880", VA = "0x185B0EC80")]
			set
			{
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030A")]
		public Vector2Int referenceResolution
		{
			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			set
			{
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x00006A68 File Offset: 0x00004C68
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030B")]
		public PanelScreenMatchMode screenMatchMode
		{
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return PanelScreenMatchMode.MatchWidthOrHeight;
			}
			[Token(Token = "0x6000D50")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			set
			{
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		public float match
		{
			[Token(Token = "0x6000D51")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D52")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			set
			{
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		public float sortingOrder
		{
			[Token(Token = "0x6000D53")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0x5B0ECE0", Offset = "0x5B0D8E0", VA = "0x185B0ECE0")]
			set
			{
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x5B0DF10", Offset = "0x5B0CB10", VA = "0x185B0DF10")]
		internal void ApplySortingOrder()
		{
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00006AB0 File Offset: 0x00004CB0
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		public int targetDisplay
		{
			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x150B0C0", Offset = "0x1509CC0", VA = "0x18150B0C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x5B0ED20", Offset = "0x5B0D920", VA = "0x185B0ED20")]
			set
			{
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000D58 RID: 3416 RVA: 0x00006AC8 File Offset: 0x00004CC8
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030F")]
		public bool clearDepthStencil
		{
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D59")]
			[Address(RVA = "0x150B0D0", Offset = "0x1509CD0", VA = "0x18150B0D0")]
			set
			{
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000D5A RID: 3418 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x17000310")]
		public float depthClearValue
		{
			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x5B0EBE0", Offset = "0x5B0D7E0", VA = "0x185B0EBE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00006AF8 File Offset: 0x00004CF8
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000311")]
		public bool clearColor
		{
			[Token(Token = "0x6000D5B")]
			[Address(RVA = "0x150B0B0", Offset = "0x1509CB0", VA = "0x18150B0B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D5C")]
			[Address(RVA = "0x150B0F0", Offset = "0x1509CF0", VA = "0x18150B0F0")]
			set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00006B10 File Offset: 0x00004D10
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000312")]
		public Color colorClearValue
		{
			[Token(Token = "0x6000D5D")]
			[Address(RVA = "0x5B0EBD0", Offset = "0x5B0D7D0", VA = "0x185B0EBD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0x5B0EC70", Offset = "0x5B0D870", VA = "0x185B0EC70")]
			set
			{
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000313")]
		internal BaseRuntimePanel panel
		{
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x5B0EBF0", Offset = "0x5B0D7F0", VA = "0x185B0EBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000314")]
		internal VisualElement visualTree
		{
			[Token(Token = "0x6000D60")]
			[Address(RVA = "0x5B0EC10", Offset = "0x5B0D810", VA = "0x185B0EC10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000315")]
		public DynamicAtlasSettings dynamicAtlasSettings
		{
			[Token(Token = "0x6000D61")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D62")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			set
			{
			}
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x5B0EA70", Offset = "0x5B0D670", VA = "0x185B0EA70")]
		private PanelSettings()
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Reset()
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x5B0E770", Offset = "0x5B0D370", VA = "0x185B0E770")]
		private void OnEnable()
		{
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x5B0E340", Offset = "0x5B0CF40", VA = "0x185B0E340")]
		private void OnDisable()
		{
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x5B0E340", Offset = "0x5B0CF40", VA = "0x185B0E340")]
		internal void DisposePanel()
		{
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00006B28 File Offset: 0x00004D28
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000316")]
		private float ScreenDPI
		{
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x4E48950", Offset = "0x4E47550", VA = "0x184E48950")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x4E489A0", Offset = "0x4E475A0", VA = "0x184E489A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x5B0EA50", Offset = "0x5B0D650", VA = "0x185B0EA50")]
		internal void UpdateScreenDPI()
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x5B0DF50", Offset = "0x5B0CB50", VA = "0x185B0DF50")]
		private void ApplyThemeStyleSheet([Optional] VisualElement root)
		{
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6C")]
		[Address(RVA = "0x5B0E590", Offset = "0x5B0D190", VA = "0x185B0E590")]
		private void InitializeShaders()
		{
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6D")]
		[Address(RVA = "0x5B0D7B0", Offset = "0x5B0C3B0", VA = "0x185B0D7B0")]
		internal void ApplyPanelSettings()
		{
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6E")]
		[Address(RVA = "0x5B0E9F0", Offset = "0x5B0D5F0", VA = "0x185B0E9F0")]
		public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction)
		{
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000D6F")]
		[Address(RVA = "0x5B0E860", Offset = "0x5B0D460", VA = "0x185B0E860")]
		internal float ResolveScale(Rect targetRect, float screenDpi)
		{
			return 0f;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x5B0E360", Offset = "0x5B0CF60", VA = "0x185B0E360")]
		internal Rect GetDisplayRect()
		{
			return default(Rect);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x5B0E0E0", Offset = "0x5B0CCE0", VA = "0x185B0E0E0")]
		internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument)
		{
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D72")]
		[Address(RVA = "0x5B0E230", Offset = "0x5B0CE30", VA = "0x185B0E230")]
		internal void DetachUIDocument(UIDocument uiDocument)
		{
		}

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		private const int k_DefaultSortingOrder = 0;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		private const float k_DefaultScaleValue = 1f;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ThemeStyleSheet themeUss;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RenderTexture m_TargetTexture;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PanelScaleMode m_ScaleMode;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_Scale;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		private const float DefaultDpi = 96f;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_ReferenceDpi;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_FallbackDpi;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2Int m_ReferenceResolution;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PanelScreenMatchMode m_ScreenMatchMode;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_Match;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_SortingOrder;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int m_TargetDisplay;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_ClearDepthStencil;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool m_ClearColor;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color m_ColorClearValue;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PanelSettings.RuntimePanelAccess m_PanelAccess;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal UIDocumentList m_AttachedUIDocumentsList;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		[SerializeField]
		private DynamicAtlasSettings m_DynamicAtlasSettings;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private Shader m_AtlasBlitShader;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private Shader m_RuntimeShader;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private Shader m_RuntimeWorldShader;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public PanelTextSettings textSettings;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rect m_TargetRect;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float m_ResolvedScale;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private StyleSheet m_OldThemeUss;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal int m_EmptyPanelCounter;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Func<Vector2, Vector2> m_AssignedScreenToPanel;

		// Token: 0x020001FE RID: 510
		[Token(Token = "0x20001FE")]
		private class RuntimePanelAccess
		{
			// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal RuntimePanelAccess(PanelSettings settings)
			{
			}

			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00006B70 File Offset: 0x00004D70
			[Token(Token = "0x17000317")]
			internal bool isInitialized
			{
				[Token(Token = "0x6000D74")]
				[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000318")]
			internal BaseRuntimePanel panel
			{
				[Token(Token = "0x6000D75")]
				[Address(RVA = "0x5B12620", Offset = "0x5B11220", VA = "0x185B12620")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x5B12450", Offset = "0x5B11050", VA = "0x185B12450")]
			internal void DisposePanel()
			{
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x5B125E0", Offset = "0x5B111E0", VA = "0x185B125E0")]
			internal void SetTargetTexture()
			{
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x5B12570", Offset = "0x5B11170", VA = "0x185B12570")]
			internal void SetSortingPriority()
			{
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x5B125B0", Offset = "0x5B111B0", VA = "0x185B125B0")]
			internal void SetTargetDisplay()
			{
			}

			// Token: 0x06000D7A RID: 3450 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x5B12320", Offset = "0x5B10F20", VA = "0x185B12320")]
			private BaseRuntimePanel CreateRelatedRuntimePanel()
			{
				return null;
			}

			// Token: 0x06000D7B RID: 3451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x5B124D0", Offset = "0x5B110D0", VA = "0x185B124D0")]
			private void DisposeRelatedPanel()
			{
			}

			// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x5B12520", Offset = "0x5B11120", VA = "0x185B12520")]
			internal void MarkPotentiallyEmpty()
			{
			}

			// Token: 0x040006F6 RID: 1782
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly PanelSettings m_Settings;

			// Token: 0x040006F7 RID: 1783
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private BaseRuntimePanel m_RuntimePanel;
		}
	}
}
