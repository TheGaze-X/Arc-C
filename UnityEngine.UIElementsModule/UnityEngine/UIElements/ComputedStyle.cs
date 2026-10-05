using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	internal struct ComputedStyle
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x17000340")]
		public int customPropertiesCount
		{
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x5B00FF0", Offset = "0x5AFFBF0", VA = "0x185B00FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000E4B RID: 3659 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x17000341")]
		public bool hasTransition
		{
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x5B01200", Offset = "0x5AFFE00", VA = "0x185B01200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x5AF6D80", Offset = "0x5AF5980", VA = "0x185AF6D80")]
		public void FinalizeApply(ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x5B000F0", Offset = "0x5AFECF0", VA = "0x185B000F0")]
		public void SyncWithLayout(YogaNode targetNode)
		{
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x5AEF2A0", Offset = "0x5AEDEA0", VA = "0x185AEF2A0")]
		private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
			return default(bool);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x5AEF360", Offset = "0x5AEDF60", VA = "0x185AEF360")]
		private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle)
		{
			return default(bool);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x5AF6FE0", Offset = "0x5AF5BE0", VA = "0x185AF6FE0")]
		private void RemoveCustomStyleProperty(StylePropertyReader reader)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x5AEDC30", Offset = "0x5AEC830", VA = "0x185AEDC30")]
		private void ApplyCustomStyleProperty(StylePropertyReader reader)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x5AEDBD0", Offset = "0x5AEC7D0", VA = "0x185AEDBD0")]
		private void ApplyAllPropertyInitial()
		{
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x3698D60", Offset = "0x3697960", VA = "0x183698D60")]
		private void ResetComputedTransitions()
		{
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x5AF6130", Offset = "0x5AF4D30", VA = "0x185AF6130")]
		public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y)
		{
			return (VersionChangeType)0;
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x6000E55")]
		[Address(RVA = "0x5AF9770", Offset = "0x5AF8370", VA = "0x185AF9770")]
		public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x17000342")]
		public Align alignContent
		{
			[Token(Token = "0x6000E56")]
			[Address(RVA = "0x5B009F0", Offset = "0x5AFF5F0", VA = "0x185B009F0")]
			get
			{
				return Align.Auto;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x17000343")]
		public Align alignItems
		{
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x5B00A30", Offset = "0x5AFF630", VA = "0x185B00A30")]
			get
			{
				return Align.Auto;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x17000344")]
		public Align alignSelf
		{
			[Token(Token = "0x6000E58")]
			[Address(RVA = "0x5B00A70", Offset = "0x5AFF670", VA = "0x185B00A70")]
			get
			{
				return Align.Auto;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x17000345")]
		public Color backgroundColor
		{
			[Token(Token = "0x6000E59")]
			[Address(RVA = "0x5B00AB0", Offset = "0x5AFF6B0", VA = "0x185B00AB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x17000346")]
		public Background backgroundImage
		{
			[Token(Token = "0x6000E5A")]
			[Address(RVA = "0x5B00B00", Offset = "0x5AFF700", VA = "0x185B00B00")]
			get
			{
				return default(Background);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x17000347")]
		public Color borderBottomColor
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x5B00B60", Offset = "0x5AFF760", VA = "0x185B00B60")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x17000348")]
		public Length borderBottomLeftRadius
		{
			[Token(Token = "0x6000E5C")]
			[Address(RVA = "0x5B00BC0", Offset = "0x5AFF7C0", VA = "0x185B00BC0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x17000349")]
		public Length borderBottomRightRadius
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x5B00C00", Offset = "0x5AFF800", VA = "0x185B00C00")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x1700034A")]
		public float borderBottomWidth
		{
			[Token(Token = "0x6000E5E")]
			[Address(RVA = "0x5B00C40", Offset = "0x5AFF840", VA = "0x185B00C40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x1700034B")]
		public Color borderLeftColor
		{
			[Token(Token = "0x6000E5F")]
			[Address(RVA = "0x5B00C80", Offset = "0x5AFF880", VA = "0x185B00C80")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x1700034C")]
		public float borderLeftWidth
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x5B00CE0", Offset = "0x5AFF8E0", VA = "0x185B00CE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x1700034D")]
		public Color borderRightColor
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x5B00D20", Offset = "0x5AFF920", VA = "0x185B00D20")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x1700034E")]
		public float borderRightWidth
		{
			[Token(Token = "0x6000E62")]
			[Address(RVA = "0x5B00D80", Offset = "0x5AFF980", VA = "0x185B00D80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x1700034F")]
		public Color borderTopColor
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x5B00DC0", Offset = "0x5AFF9C0", VA = "0x185B00DC0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x17000350")]
		public Length borderTopLeftRadius
		{
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x5B00E20", Offset = "0x5AFFA20", VA = "0x185B00E20")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x17000351")]
		public Length borderTopRightRadius
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x5B00E70", Offset = "0x5AFFA70", VA = "0x185B00E70")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x17000352")]
		public float borderTopWidth
		{
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x5B00EC0", Offset = "0x5AFFAC0", VA = "0x185B00EC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x17000353")]
		public Length bottom
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x5B00F00", Offset = "0x5AFFB00", VA = "0x185B00F00")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x17000354")]
		public Color color
		{
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x5B00F40", Offset = "0x5AFFB40", VA = "0x185B00F40")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x17000355")]
		public Cursor cursor
		{
			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x5B00F90", Offset = "0x5AFFB90", VA = "0x185B00F90")]
			get
			{
				return default(Cursor);
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x17000356")]
		public DisplayStyle display
		{
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x5B01040", Offset = "0x5AFFC40", VA = "0x185B01040")]
			get
			{
				return DisplayStyle.Flex;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x17000357")]
		public Length flexBasis
		{
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x5B01080", Offset = "0x5AFFC80", VA = "0x185B01080")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E6C RID: 3692 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x17000358")]
		public FlexDirection flexDirection
		{
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x5B010C0", Offset = "0x5AFFCC0", VA = "0x185B010C0")]
			get
			{
				return FlexDirection.Column;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x17000359")]
		public float flexGrow
		{
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x5B01100", Offset = "0x5AFFD00", VA = "0x185B01100")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x1700035A")]
		public float flexShrink
		{
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x5B01140", Offset = "0x5AFFD40", VA = "0x185B01140")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x1700035B")]
		public Wrap flexWrap
		{
			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x5B01180", Offset = "0x5AFFD80", VA = "0x185B01180")]
			get
			{
				return Wrap.NoWrap;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x1700035C")]
		public Length fontSize
		{
			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x5B011C0", Offset = "0x5AFFDC0", VA = "0x185B011C0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x1700035D")]
		public Length height
		{
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x5B01220", Offset = "0x5AFFE20", VA = "0x185B01220")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x1700035E")]
		public Justify justifyContent
		{
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x5B01260", Offset = "0x5AFFE60", VA = "0x185B01260")]
			get
			{
				return Justify.FlexStart;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x1700035F")]
		public Length left
		{
			[Token(Token = "0x6000E73")]
			[Address(RVA = "0x5B012A0", Offset = "0x5AFFEA0", VA = "0x185B012A0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x17000360")]
		public Length letterSpacing
		{
			[Token(Token = "0x6000E74")]
			[Address(RVA = "0x5B012E0", Offset = "0x5AFFEE0", VA = "0x185B012E0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x17000361")]
		public Length marginBottom
		{
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x5B01320", Offset = "0x5AFFF20", VA = "0x185B01320")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x17000362")]
		public Length marginLeft
		{
			[Token(Token = "0x6000E76")]
			[Address(RVA = "0x5B01360", Offset = "0x5AFFF60", VA = "0x185B01360")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x17000363")]
		public Length marginRight
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x5B013A0", Offset = "0x5AFFFA0", VA = "0x185B013A0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x17000364")]
		public Length marginTop
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x5B013E0", Offset = "0x5AFFFE0", VA = "0x185B013E0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x17000365")]
		public Length maxHeight
		{
			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x5B01420", Offset = "0x5B00020", VA = "0x185B01420")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x17000366")]
		public Length maxWidth
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x5B01460", Offset = "0x5B00060", VA = "0x185B01460")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x17000367")]
		public Length minHeight
		{
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x5B014A0", Offset = "0x5B000A0", VA = "0x185B014A0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x17000368")]
		public Length minWidth
		{
			[Token(Token = "0x6000E7C")]
			[Address(RVA = "0x5B014F0", Offset = "0x5B000F0", VA = "0x185B014F0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x17000369")]
		public float opacity
		{
			[Token(Token = "0x6000E7D")]
			[Address(RVA = "0x5B01540", Offset = "0x5B00140", VA = "0x185B01540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x1700036A")]
		public OverflowInternal overflow
		{
			[Token(Token = "0x6000E7E")]
			[Address(RVA = "0x5B01590", Offset = "0x5B00190", VA = "0x185B01590")]
			get
			{
				return OverflowInternal.Visible;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x1700036B")]
		public Length paddingBottom
		{
			[Token(Token = "0x6000E7F")]
			[Address(RVA = "0x5B015E0", Offset = "0x5B001E0", VA = "0x185B015E0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x1700036C")]
		public Length paddingLeft
		{
			[Token(Token = "0x6000E80")]
			[Address(RVA = "0x5B01630", Offset = "0x5B00230", VA = "0x185B01630")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x1700036D")]
		public Length paddingRight
		{
			[Token(Token = "0x6000E81")]
			[Address(RVA = "0x5B01680", Offset = "0x5B00280", VA = "0x185B01680")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x1700036E")]
		public Length paddingTop
		{
			[Token(Token = "0x6000E82")]
			[Address(RVA = "0x5B016D0", Offset = "0x5B002D0", VA = "0x185B016D0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x1700036F")]
		public Position position
		{
			[Token(Token = "0x6000E83")]
			[Address(RVA = "0x5B01720", Offset = "0x5B00320", VA = "0x185B01720")]
			get
			{
				return Position.Relative;
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x17000370")]
		public Length right
		{
			[Token(Token = "0x6000E84")]
			[Address(RVA = "0x5B01770", Offset = "0x5B00370", VA = "0x185B01770")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000371")]
		public Rotate rotate
		{
			[Token(Token = "0x6000E85")]
			[Address(RVA = "0x5B017C0", Offset = "0x5B003C0", VA = "0x185B017C0")]
			get
			{
				return default(Rotate);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000372")]
		public Scale scale
		{
			[Token(Token = "0x6000E86")]
			[Address(RVA = "0x5B01820", Offset = "0x5B00420", VA = "0x185B01820")]
			get
			{
				return default(Scale);
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x17000373")]
		public TextOverflow textOverflow
		{
			[Token(Token = "0x6000E87")]
			[Address(RVA = "0x5B01880", Offset = "0x5B00480", VA = "0x185B01880")]
			get
			{
				return TextOverflow.Clip;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x17000374")]
		public TextShadow textShadow
		{
			[Token(Token = "0x6000E88")]
			[Address(RVA = "0x5B018C0", Offset = "0x5B004C0", VA = "0x185B018C0")]
			get
			{
				return default(TextShadow);
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x17000375")]
		public Length top
		{
			[Token(Token = "0x6000E89")]
			[Address(RVA = "0x5B01920", Offset = "0x5B00520", VA = "0x185B01920")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x17000376")]
		public TransformOrigin transformOrigin
		{
			[Token(Token = "0x6000E8A")]
			[Address(RVA = "0x5B01970", Offset = "0x5B00570", VA = "0x185B01970")]
			get
			{
				return default(TransformOrigin);
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000377")]
		public List<TimeValue> transitionDelay
		{
			[Token(Token = "0x6000E8B")]
			[Address(RVA = "0x5B019D0", Offset = "0x5B005D0", VA = "0x185B019D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000378")]
		public List<TimeValue> transitionDuration
		{
			[Token(Token = "0x6000E8C")]
			[Address(RVA = "0x5B01A10", Offset = "0x5B00610", VA = "0x185B01A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000379")]
		public List<StylePropertyName> transitionProperty
		{
			[Token(Token = "0x6000E8D")]
			[Address(RVA = "0x5B01A50", Offset = "0x5B00650", VA = "0x185B01A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000E8E RID: 3726 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700037A")]
		public List<EasingFunction> transitionTimingFunction
		{
			[Token(Token = "0x6000E8E")]
			[Address(RVA = "0x5B01A90", Offset = "0x5B00690", VA = "0x185B01A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x1700037B")]
		public Translate translate
		{
			[Token(Token = "0x6000E8F")]
			[Address(RVA = "0x5B01AD0", Offset = "0x5B006D0", VA = "0x185B01AD0")]
			get
			{
				return default(Translate);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000E90 RID: 3728 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x1700037C")]
		public Color unityBackgroundImageTintColor
		{
			[Token(Token = "0x6000E90")]
			[Address(RVA = "0x5B01B30", Offset = "0x5B00730", VA = "0x185B01B30")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x1700037D")]
		public ScaleMode unityBackgroundScaleMode
		{
			[Token(Token = "0x6000E91")]
			[Address(RVA = "0x5B01B90", Offset = "0x5B00790", VA = "0x185B01B90")]
			get
			{
				return ScaleMode.StretchToFill;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700037E")]
		public Font unityFont
		{
			[Token(Token = "0x6000E92")]
			[Address(RVA = "0x5B01C60", Offset = "0x5B00860", VA = "0x185B01C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x1700037F")]
		public FontDefinition unityFontDefinition
		{
			[Token(Token = "0x6000E93")]
			[Address(RVA = "0x5B01BD0", Offset = "0x5B007D0", VA = "0x185B01BD0")]
			get
			{
				return default(FontDefinition);
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000E94 RID: 3732 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x17000380")]
		public FontStyle unityFontStyleAndWeight
		{
			[Token(Token = "0x6000E94")]
			[Address(RVA = "0x5B01C20", Offset = "0x5B00820", VA = "0x185B01C20")]
			get
			{
				return FontStyle.Normal;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x17000381")]
		public OverflowClipBox unityOverflowClipBox
		{
			[Token(Token = "0x6000E95")]
			[Address(RVA = "0x5B01CA0", Offset = "0x5B008A0", VA = "0x185B01CA0")]
			get
			{
				return OverflowClipBox.PaddingBox;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x17000382")]
		public Length unityParagraphSpacing
		{
			[Token(Token = "0x6000E96")]
			[Address(RVA = "0x5B01CE0", Offset = "0x5B008E0", VA = "0x185B01CE0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x17000383")]
		public int unitySliceBottom
		{
			[Token(Token = "0x6000E97")]
			[Address(RVA = "0x5B01D20", Offset = "0x5B00920", VA = "0x185B01D20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x17000384")]
		public int unitySliceLeft
		{
			[Token(Token = "0x6000E98")]
			[Address(RVA = "0x5B01D60", Offset = "0x5B00960", VA = "0x185B01D60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x17000385")]
		public int unitySliceRight
		{
			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x5B01DA0", Offset = "0x5B009A0", VA = "0x185B01DA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x17000386")]
		public int unitySliceTop
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x5B01DE0", Offset = "0x5B009E0", VA = "0x185B01DE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x17000387")]
		public TextAnchor unityTextAlign
		{
			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x5B01E20", Offset = "0x5B00A20", VA = "0x185B01E20")]
			get
			{
				return TextAnchor.UpperLeft;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x17000388")]
		public Color unityTextOutlineColor
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x5B01E60", Offset = "0x5B00A60", VA = "0x185B01E60")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x17000389")]
		public float unityTextOutlineWidth
		{
			[Token(Token = "0x6000E9D")]
			[Address(RVA = "0x5B01EB0", Offset = "0x5B00AB0", VA = "0x185B01EB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x1700038A")]
		public TextOverflowPosition unityTextOverflowPosition
		{
			[Token(Token = "0x6000E9E")]
			[Address(RVA = "0x5B01EF0", Offset = "0x5B00AF0", VA = "0x185B01EF0")]
			get
			{
				return TextOverflowPosition.End;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x1700038B")]
		public Visibility visibility
		{
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x5B01F30", Offset = "0x5B00B30", VA = "0x185B01F30")]
			get
			{
				return Visibility.Visible;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x1700038C")]
		public WhiteSpace whiteSpace
		{
			[Token(Token = "0x6000EA0")]
			[Address(RVA = "0x5B01F70", Offset = "0x5B00B70", VA = "0x185B01F70")]
			get
			{
				return WhiteSpace.Normal;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x1700038D")]
		public Length width
		{
			[Token(Token = "0x6000EA1")]
			[Address(RVA = "0x5B01FB0", Offset = "0x5B00BB0", VA = "0x185B01FB0")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x1700038E")]
		public Length wordSpacing
		{
			[Token(Token = "0x6000EA2")]
			[Address(RVA = "0x5B02000", Offset = "0x5B00C00", VA = "0x185B02000")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000EA3")]
		[Address(RVA = "0x5AF6B70", Offset = "0x5AF5770", VA = "0x185AF6B70")]
		public static ComputedStyle Create(ref ComputedStyle parentStyle)
		{
			return default(ComputedStyle);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x5AF69C0", Offset = "0x5AF55C0", VA = "0x185AF69C0")]
		public static ComputedStyle CreateInitial()
		{
			return default(ComputedStyle);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x5AEDAA0", Offset = "0x5AEC6A0", VA = "0x185AEDAA0")]
		public ComputedStyle Acquire()
		{
			return default(ComputedStyle);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x5AF6F10", Offset = "0x5AF5B10", VA = "0x185AF6F10")]
		public void Release()
		{
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x5AF6890", Offset = "0x5AF5490", VA = "0x185AF6890")]
		public void CopyFrom(ref ComputedStyle other)
		{
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x5AF10A0", Offset = "0x5AEFCA0", VA = "0x185AF10A0")]
		public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x5AF4C50", Offset = "0x5AF3850", VA = "0x185AF4C50")]
		public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x5AF4940", Offset = "0x5AF3540", VA = "0x185AF4940")]
		public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x5AF4710", Offset = "0x5AF3310", VA = "0x185AF4710")]
		public void ApplyStyleCursor(Cursor cursor)
		{
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x5AF4820", Offset = "0x5AF3420", VA = "0x185AF4820")]
		public void ApplyStyleTextShadow(TextShadow st)
		{
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x5AEDD40", Offset = "0x5AEC940", VA = "0x185AEDD40")]
		public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other)
		{
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x5AF2CE0", Offset = "0x5AF18E0", VA = "0x185AF2CE0")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x5AF2980", Offset = "0x5AF1580", VA = "0x185AF2980")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue)
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x5AF36E0", Offset = "0x5AF22E0", VA = "0x185AF36E0")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue)
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x5AF4490", Offset = "0x5AF3090", VA = "0x185AF4490")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue)
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x5AF4080", Offset = "0x5AF2C80", VA = "0x185AF4080")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x5AF3590", Offset = "0x5AF2190", VA = "0x185AF3590")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue)
		{
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x5AF41E0", Offset = "0x5AF2DE0", VA = "0x185AF41E0")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue)
		{
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x5AF4330", Offset = "0x5AF2F30", VA = "0x185AF4330")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x5AF3C90", Offset = "0x5AF2890", VA = "0x185AF3C90")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue)
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x5AF3F30", Offset = "0x5AF2B30", VA = "0x185AF3F30")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue)
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x5AF2830", Offset = "0x5AF1430", VA = "0x185AF2830")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue)
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x5AF3DE0", Offset = "0x5AF29E0", VA = "0x185AF3DE0")]
		public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue)
		{
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000EBA")]
		[Address(RVA = "0x5AFCA20", Offset = "0x5AFB620", VA = "0x185AFCA20")]
		public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x6000EBB")]
		[Address(RVA = "0x5AF7080", Offset = "0x5AF5C80", VA = "0x185AF7080")]
		public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x6000EBC")]
		[Address(RVA = "0x5AF98F0", Offset = "0x5AF84F0", VA = "0x185AF98F0")]
		public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x5AF4880", Offset = "0x5AF3480", VA = "0x185AF4880")]
		public void ApplyStyleTransformOrigin(TransformOrigin st)
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x5AF48E0", Offset = "0x5AF34E0", VA = "0x185AF48E0")]
		public void ApplyStyleTranslate(Translate translateValue)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x5AF4770", Offset = "0x5AF3370", VA = "0x185AF4770")]
		public void ApplyStyleRotate(Rotate rotateValue)
		{
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x5AF47D0", Offset = "0x5AF33D0", VA = "0x185AF47D0")]
		public void ApplyStyleScale(Scale scaleValue)
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x5AEF380", Offset = "0x5AEDF80", VA = "0x185AEF380")]
		public void ApplyInitialValue(StylePropertyReader reader)
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x5AEF4A0", Offset = "0x5AEE0A0", VA = "0x185AEF4A0")]
		public void ApplyInitialValue(StylePropertyId id)
		{
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x5AF5C60", Offset = "0x5AF4860", VA = "0x185AF5C60")]
		public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x5AF5D20", Offset = "0x5AF4920", VA = "0x185AF5D20")]
		public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle)
		{
		}

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x0")]
		public StyleDataRef<InheritedData> inheritedData;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x8")]
		public StyleDataRef<LayoutData> layoutData;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x10")]
		public StyleDataRef<RareData> rareData;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x18")]
		public StyleDataRef<TransformData> transformData;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x20")]
		public StyleDataRef<TransitionData> transitionData;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x28")]
		public StyleDataRef<VisualData> visualData;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x30")]
		public YogaNode yogaNode;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, StylePropertyValue> customProperties;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x40")]
		public long matchingRulesHash;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x48")]
		public float dpiScaling;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x50")]
		public ComputedTransitionProperty[] computedTransitions;
	}
}
