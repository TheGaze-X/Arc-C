using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public class VisualElement : Focusable, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler, IResolvedStyle
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x1700008E")]
		internal bool hasRunningAnimations
		{
			[Token(Token = "0x6000277")]
			[Address(RVA = "0x5A4FE50", Offset = "0x5A4EA50", VA = "0x185A4FE50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700008F")]
		internal bool hasCompletedAnimations
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x5A4FDF0", Offset = "0x5A4E9F0", VA = "0x185A4FDF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002E50 File Offset: 0x00001050
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000090")]
		private int runningAnimationCount
		{
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630", Slot = "37")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		private int completedAnimationCount
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0", Slot = "39")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x5A464C0", Offset = "0x5A450C0", VA = "0x185A464C0")]
		private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
		{
			return null;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000092")]
		internal IStylePropertyAnimations styleAnimation
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5A4C7B0", Offset = "0x5A4B3B0", VA = "0x185A4C7B0", Slot = "19")]
		private bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x5A4CCA0", Offset = "0x5A4B8A0", VA = "0x185A4CCA0", Slot = "20")]
		private bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5A4C470", Offset = "0x5A4B070", VA = "0x185A4C470", Slot = "21")]
		private bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x5A4CD90", Offset = "0x5A4B990", VA = "0x185A4CD90", Slot = "22")]
		private bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x5A4C200", Offset = "0x5A4AE00", VA = "0x185A4C200", Slot = "23")]
		private bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x5A4D480", Offset = "0x5A4C080", VA = "0x185A4D480", Slot = "24")]
		private bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x5A4D100", Offset = "0x5A4BD00", VA = "0x185A4D100", Slot = "25")]
		private bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x5A4C2F0", Offset = "0x5A4AEF0", VA = "0x185A4C2F0", Slot = "26")]
		private bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x5A4D2A0", Offset = "0x5A4BEA0", VA = "0x185A4D2A0", Slot = "27")]
		private bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x5A4C940", Offset = "0x5A4B540", VA = "0x185A4C940", Slot = "28")]
		private bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x5A4CF30", Offset = "0x5A4BB30", VA = "0x185A4CF30", Slot = "29")]
		private bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x5A4C5E0", Offset = "0x5A4B1E0", VA = "0x185A4C5E0", Slot = "30")]
		private bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5A4CAE0", Offset = "0x5A4B6E0", VA = "0x185A4CAE0", Slot = "31")]
		private bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve)
		{
			return default(bool);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5A4BFC0", Offset = "0x5A4ABC0", VA = "0x185A4BFC0", Slot = "34")]
		private void CancelAnimation(StylePropertyId id)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5A4BE30", Offset = "0x5A4AA30", VA = "0x185A4BE30", Slot = "35")]
		private void CancelAllAnimations()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5A4D640", Offset = "0x5A4C240", VA = "0x185A4D640", Slot = "32")]
		private void UpdateAnimation(StylePropertyId id)
		{
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5A4C060", Offset = "0x5A4AC60", VA = "0x185A4C060", Slot = "33")]
		private void GetAllAnimations(List<StylePropertyId> outPropertyIds)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x5A4AFF0", Offset = "0x5A49BF0", VA = "0x185A4AFF0")]
		internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0)
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x5A4B280", Offset = "0x5A49E80", VA = "0x185A4B280")]
		internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to)
		{
			return default(bool);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5A4B330", Offset = "0x5A49F30", VA = "0x185A4B330")]
		internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to)
		{
			return default(bool);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5A45AB0", Offset = "0x5A446B0", VA = "0x185A45AB0")]
		private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0)
		{
			return null;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		internal bool isCompositeRoot
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x5A4FEC0", Offset = "0x5A4EAC0", VA = "0x185A4FEC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x5A50F80", Offset = "0x5A4FB80", VA = "0x185A50F80")]
			set
			{
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00003030 File Offset: 0x00001230
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		internal bool isHierarchyDisplayed
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x5A4FED0", Offset = "0x5A4EAD0", VA = "0x185A4FED0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x5A50FA0", Offset = "0x5A4FBA0", VA = "0x185A50FA0")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public string viewDataKey
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x5997770", Offset = "0x5996370", VA = "0x185997770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x5A51AC0", Offset = "0x5A506C0", VA = "0x185A51AC0")]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00003048 File Offset: 0x00001248
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000096")]
		internal bool enableViewDataPersistence
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x5A4FC50", Offset = "0x5A4E850", VA = "0x185A4FC50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x5A50F00", Offset = "0x5A4FB00", VA = "0x185A50F00")]
			private set
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public object userData
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x5A509C0", Offset = "0x5A4F5C0", VA = "0x185A509C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x5A51A50", Offset = "0x5A50650", VA = "0x185A51A50")]
			set
			{
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x17000098")]
		public override bool canGrabFocus
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x5A4F740", Offset = "0x5A4E340", VA = "0x185A4F740", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000099")]
		public override FocusController focusController
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x5A4FC80", Offset = "0x5A4E880", VA = "0x185A4FC80", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009A")]
		public UsageHints usageHints
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x5A509A0", Offset = "0x5A4F5A0", VA = "0x185A509A0")]
			get
			{
				return UsageHints.None;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x5A519C0", Offset = "0x5A505C0", VA = "0x185A519C0")]
			set
			{
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009B")]
		internal RenderHints renderHints
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x5A504A0", Offset = "0x5A4F0A0", VA = "0x185A504A0")]
			get
			{
				return RenderHints.None;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x5A516F0", Offset = "0x5A502F0", VA = "0x185A516F0")]
			set
			{
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x5A46CE0", Offset = "0x5A458E0", VA = "0x185A46CE0")]
		internal void MarkRenderHintsClean()
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700009C")]
		public ITransform transform
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		private Vector3 position
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x5A4D6E0", Offset = "0x5A4C2E0", VA = "0x185A4D6E0", Slot = "40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x5A4D900", Offset = "0x5A4C500", VA = "0x185A4D900", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x1700009E")]
		private Vector3 scale
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x5A4D7F0", Offset = "0x5A4C3F0", VA = "0x185A4D7F0", Slot = "42")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		internal bool isLayoutManual
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x5A4FEE0", Offset = "0x5A4EAE0", VA = "0x185A4FEE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x5A50FC0", Offset = "0x5A4FBC0", VA = "0x185A50FC0")]
			private set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x170000A0")]
		internal float scaledPixelsPerPoint
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x5A504C0", Offset = "0x5A4F0C0", VA = "0x185A504C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public Rect layout
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x5A4FF80", Offset = "0x5A4EB80", VA = "0x185A4FF80")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x5A51070", Offset = "0x5A4FC70", VA = "0x185A51070")]
			internal set
			{
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5A44070", Offset = "0x5A42C70", VA = "0x185A44070")]
		internal void ClearManualLayout()
		{
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000A2")]
		public Rect contentRect
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x5A4F9D0", Offset = "0x5A4E5D0", VA = "0x185A4F9D0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x170000A3")]
		protected Rect paddingRect
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x5A50110", Offset = "0x5A4ED10", VA = "0x185A50110")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		internal bool isBoundingBoxDirty
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x5A4FEB0", Offset = "0x5A4EAB0", VA = "0x185A4FEB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x5A50F60", Offset = "0x5A4FB60", VA = "0x185A50F60")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		internal bool isWorldBoundingBoxDirty
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x5A4FF40", Offset = "0x5A4EB40", VA = "0x185A4FF40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x5A50FF0", Offset = "0x5A4FBF0", VA = "0x185A50FF0")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x170000A6")]
		internal Rect boundingBox
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x5A4F6F0", Offset = "0x5A4E2F0", VA = "0x185A4F6F0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000A7")]
		internal Rect worldBoundingBox
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x5A50BC0", Offset = "0x5A4F7C0", VA = "0x185A50BC0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x170000A8")]
		private Rect boundingBoxInParentSpace
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x5A4F690", Offset = "0x5A4E290", VA = "0x185A4F690")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x5A4DD80", Offset = "0x5A4C980", VA = "0x185A4DD80")]
		internal void UpdateBoundingBox()
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x5A4E540", Offset = "0x5A4D140", VA = "0x185A4E540")]
		internal void UpdateWorldBoundingBox()
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002BA RID: 698 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x170000A9")]
		public Rect worldBound
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x5A50A90", Offset = "0x5A4F690", VA = "0x185A50A90")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x170000AA")]
		public Rect localBound
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x5A50060", Offset = "0x5A4EC60", VA = "0x185A50060")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x170000AB")]
		internal Rect rect
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x5A50410", Offset = "0x5A4F010", VA = "0x185A50410")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00003210 File Offset: 0x00001410
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		internal bool isWorldTransformDirty
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x5A4FF60", Offset = "0x5A4EB60", VA = "0x185A4FF60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x5A51030", Offset = "0x5A4FC30", VA = "0x185A51030")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		internal bool isWorldTransformInverseDirty
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x5A4FF70", Offset = "0x5A4EB70", VA = "0x185A4FF70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x5A51050", Offset = "0x5A4FC50", VA = "0x185A51050")]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x170000AE")]
		public Matrix4x4 worldTransform
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x5A50E40", Offset = "0x5A4FA40", VA = "0x185A50E40")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000AF")]
		internal ref Matrix4x4 worldTransformRef
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x5A50E10", Offset = "0x5A4FA10", VA = "0x185A50E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000B0")]
		internal ref Matrix4x4 worldTransformInverse
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x5A50D80", Offset = "0x5A4F980", VA = "0x185A50D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x5A4EB00", Offset = "0x5A4D700", VA = "0x185A4EB00")]
		internal void UpdateWorldTransform()
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x5A4EA90", Offset = "0x5A4D690", VA = "0x185A4EA90")]
		internal void UpdateWorldTransformInverse()
		{
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00003258 File Offset: 0x00001458
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B1")]
		internal bool isWorldClipDirty
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x5A4FF50", Offset = "0x5A4EB50", VA = "0x185A4FF50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x5A51010", Offset = "0x5A4FC10", VA = "0x185A51010")]
			set
			{
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x170000B2")]
		internal Rect worldClip
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x5A50D30", Offset = "0x5A4F930", VA = "0x185A50D30")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x170000B3")]
		internal Rect worldClipMinusGroup
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x5A50CE0", Offset = "0x5A4F8E0", VA = "0x185A50CE0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x170000B4")]
		internal bool worldClipIsInfinite
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x5A50CA0", Offset = "0x5A4F8A0", VA = "0x185A50CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x5A44B10", Offset = "0x5A43710", VA = "0x185A44B10")]
		internal void EnsureWorldTransformAndClipUpToDate()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x5A4E5E0", Offset = "0x5A4D1E0", VA = "0x185A4E5E0")]
		private void UpdateWorldClip()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x5A443C0", Offset = "0x5A42FC0", VA = "0x185A443C0")]
		private Rect CombineClipRects(Rect rect, Rect parentRect)
		{
			return default(Rect);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x5A4A650", Offset = "0x5A49250", VA = "0x185A4A650")]
		private Rect SubstractBorderPadding(Rect worldRect)
		{
			return default(Rect);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x5A444E0", Offset = "0x5A430E0", VA = "0x185A444E0")]
		internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
		{
			return default(Rect);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00003300 File Offset: 0x00001500
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		internal PseudoStates pseudoStates
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x5A50400", Offset = "0x5A4F000", VA = "0x185A50400")]
			get
			{
				return (PseudoStates)0;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x5A51680", Offset = "0x5A50280", VA = "0x185A51680")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00003318 File Offset: 0x00001518
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		internal int containedPointerIds
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x5A4F9C0", Offset = "0x5A4E5C0", VA = "0x185A4F9C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x5A50EC0", Offset = "0x5A4FAC0", VA = "0x185A50EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x5A4E470", Offset = "0x5A4D070", VA = "0x185A4E470")]
		private void UpdateHoverPseudoState()
		{
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00003330 File Offset: 0x00001530
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B7")]
		public PickingMode pickingMode
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x5A50340", Offset = "0x5A4EF40", VA = "0x185A50340")]
			get
			{
				return PickingMode.Position;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x5A51620", Offset = "0x5A50220", VA = "0x185A51620")]
			set
			{
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B8")]
		public string name
		{
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x5964990", Offset = "0x5963590", VA = "0x185964990")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x5A515A0", Offset = "0x5A501A0", VA = "0x185A515A0")]
			set
			{
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000B9")]
		internal List<string> classList
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x5A4F8F0", Offset = "0x5A4E4F0", VA = "0x185A4F8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000BA")]
		internal string fullTypeName
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x5A4FD60", Offset = "0x5A4E960", VA = "0x185A4FD60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000BB")]
		internal string typeName
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x5A50880", Offset = "0x5A4F480", VA = "0x185A50880")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		internal YogaNode yogaNode
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x5A50EB0", Offset = "0x5A4FAB0", VA = "0x185A50EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x5A51C70", Offset = "0x5A50870", VA = "0x185A51C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000BD")]
		internal ref ComputedStyle computedStyle
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x5A4F9B0", Offset = "0x5A4E5B0", VA = "0x185A4F9B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x170000BE")]
		internal bool hasInlineStyle
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x5A4FE40", Offset = "0x5A4EA40", VA = "0x185A4FE40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00003360 File Offset: 0x00001560
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BF")]
		internal bool styleInitialized
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x5A504F0", Offset = "0x5A4F0F0", VA = "0x185A504F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x5A51800", Offset = "0x5A50400", VA = "0x185A51800")]
			set
			{
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x5A43DF0", Offset = "0x5A429F0", VA = "0x185A43DF0")]
		private void ChangeIMGUIContainerCount(int delta)
		{
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x5A4F230", Offset = "0x5A4DE30", VA = "0x185A4F230")]
		public VisualElement()
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x5A44B50", Offset = "0x5A43750", VA = "0x185A44B50", Slot = "12")]
		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x5A46510", Offset = "0x5A45110", VA = "0x185A46510", Slot = "92")]
		internal virtual Rect GetTooltipRect()
		{
			return default(Rect);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x5A4A350", Offset = "0x5A48F50", VA = "0x185A4A350")]
		private void SetTooltip(TooltipEvent e)
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x5A455F0", Offset = "0x5A441F0", VA = "0x185A455F0", Slot = "17")]
		public sealed override void Focus()
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x5A497B0", Offset = "0x5A483B0", VA = "0x185A497B0")]
		internal void SetPanel(BaseVisualElementPanel p)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x5A4EDA0", Offset = "0x5A4D9A0", VA = "0x185A4EDA0")]
		private void WillChangePanel(BaseVisualElementPanel destinationPanel)
		{
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5A46540", Offset = "0x5A45140", VA = "0x185A46540")]
		private void HasChangedPanel(BaseVisualElementPanel prevPanel)
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x5A48FE0", Offset = "0x5A47BE0", VA = "0x185A48FE0", Slot = "6")]
		public sealed override void SendEvent(EventBase e)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x5A49000", Offset = "0x5A47C00", VA = "0x185A49000", Slot = "7")]
		internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5A46850", Offset = "0x5A45450", VA = "0x185A46850")]
		internal void IncrementVersion(VersionChangeType changeType)
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5A46B90", Offset = "0x5A45790", VA = "0x185A46B90")]
		internal void InvokeHierarchyChanged(HierarchyChangeType changeType)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5A49300", Offset = "0x5A47F00", VA = "0x185A49300")]
		private bool SetEnabledFromHierarchyPrivate(bool state)
		{
			return default(bool);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x170000C0")]
		private bool isParentEnabledInHierarchy
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x5A4FEF0", Offset = "0x5A4EAF0", VA = "0x185A4FEF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000C1")]
		public bool enabledInHierarchy
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x5A4FC60", Offset = "0x5A4E860", VA = "0x185A4FC60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x000033D8 File Offset: 0x000015D8
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C2")]
		public bool enabledSelf
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x5A4FC70", Offset = "0x5A4E870", VA = "0x185A4FC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x5A50F20", Offset = "0x5A4FB20", VA = "0x185A50F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x5A496D0", Offset = "0x5A482D0", VA = "0x185A496D0")]
		public void SetEnabled(bool value)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x5A47750", Offset = "0x5A46350", VA = "0x185A47750")]
		private void PropagateEnabledToChildren(bool value)
		{
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		public bool visible
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x5A50A40", Offset = "0x5A4F640", VA = "0x185A50A40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x5A51B50", Offset = "0x5A50750", VA = "0x185A51B50")]
			set
			{
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x5A46C80", Offset = "0x5A45880", VA = "0x185A46C80")]
		public void MarkDirtyRepaint()
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C4")]
		public Action<MeshGenerationContext> generateVisualContent
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x5A4FDE0", Offset = "0x5A4E9E0", VA = "0x185A4FDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x5A50F30", Offset = "0x5A4FB30", VA = "0x185A50F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x5A46A70", Offset = "0x5A45670", VA = "0x185A46A70")]
		internal void InvokeGenerateVisualContent(MeshGenerationContext mgc)
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x5A45920", Offset = "0x5A44520", VA = "0x185A45920")]
		internal void GetFullHierarchicalViewDataKey(StringBuilder key)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x5A45830", Offset = "0x5A44430", VA = "0x185A45830")]
		internal string GetFullHierarchicalViewDataKey()
		{
			return null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x5A47260", Offset = "0x5A45E60", VA = "0x185A47260")]
		internal void OverwriteFromViewData(object obj, string key)
		{
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x5A48F20", Offset = "0x5A47B20", VA = "0x185A48F20")]
		internal void SaveViewData()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x5A46BB0", Offset = "0x5A457B0", VA = "0x185A46BB0")]
		internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState)
		{
			return default(bool);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x5A47130", Offset = "0x5A45D30", VA = "0x185A47130")]
		internal void OnViewDataReady(bool enablePersistence)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "93")]
		internal virtual void OnViewDataReady()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x5A44790", Offset = "0x5A43390", VA = "0x185A44790", Slot = "94")]
		public virtual bool ContainsPoint(Vector2 localPoint)
		{
			return default(bool);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		internal bool requireMeasureFunction
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x5A504B0", Offset = "0x5A4F0B0", VA = "0x185A504B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x5A51770", Offset = "0x5A50370", VA = "0x185A51770")]
			set
			{
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x5A42A10", Offset = "0x5A41610", VA = "0x185A42A10")]
		private void AssignMeasureFunction()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x5A48350", Offset = "0x5A46F50", VA = "0x185A48350")]
		private void RemoveMeasureFunction()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5A44890", Offset = "0x5A43490", VA = "0x185A44890", Slot = "95")]
		protected internal virtual Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode)
		{
			return default(Vector2);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x5A46D00", Offset = "0x5A45900", VA = "0x185A46D00")]
		internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
		{
			return default(YogaSize);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5A45270", Offset = "0x5A43E70", VA = "0x185A45270")]
		private void FinalizeLayout()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5A496F0", Offset = "0x5A482F0", VA = "0x185A496F0")]
		internal void SetInlineRule(StyleSheet sheet, StyleRule rule)
		{
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x5A490F0", Offset = "0x5A47CF0", VA = "0x185A490F0")]
		internal void SetComputedStyle(ref ComputedStyle newStyle)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5A4A960", Offset = "0x5A49560", VA = "0x185A4A960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x59976A0", Offset = "0x59962A0", VA = "0x1859976A0")]
		internal List<string> GetClassesForIteration()
		{
			return null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5A42710", Offset = "0x5A41310", VA = "0x185A42710")]
		public void AddToClassList(string className)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5A48100", Offset = "0x5A46D00", VA = "0x185A48100")]
		public void RemoveFromClassList(string className)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5A44AE0", Offset = "0x5A436E0", VA = "0x185A44AE0")]
		public void EnableInClassList(string className, bool enable)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x5A43FB0", Offset = "0x5A42BB0", VA = "0x185A43FB0")]
		public bool ClassListContains(string cls)
		{
			return default(bool);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x5A46380", Offset = "0x5A44F80", VA = "0x185A46380")]
		internal object GetProperty(PropertyName key)
		{
			return null;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5A4A2E0", Offset = "0x5A48EE0", VA = "0x185A4A2E0")]
		internal void SetProperty(PropertyName key, object value)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x5A467E0", Offset = "0x5A453E0", VA = "0x185A467E0")]
		internal bool HasProperty(PropertyName key)
		{
			return default(bool);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5A4B3E0", Offset = "0x5A49FE0", VA = "0x185A4B3E0")]
		private bool TryGetPropertyInternal(PropertyName key, out object value)
		{
			return default(bool);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x5A43E30", Offset = "0x5A42A30", VA = "0x185A43E30")]
		private static void CheckUserKeyArgument(PropertyName key)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5A4A010", Offset = "0x5A48C10", VA = "0x185A4A010")]
		private void SetPropertyInternal(PropertyName key, object value)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5A4E280", Offset = "0x5A4CE80", VA = "0x185A4E280")]
		private void UpdateCursorStyle(long eventType)
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000C6")]
		internal VisualElement.RenderTargetMode subRenderTargetMode
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x5A505C0", Offset = "0x5A4F1C0", VA = "0x185A505C0")]
			get
			{
				return VisualElement.RenderTargetMode.None;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000C7")]
		internal Material defaultMaterial
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x5A4FC20", Offset = "0x5A4E820", VA = "0x185A4FC20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5A45750", Offset = "0x5A44350", VA = "0x185A45750")]
		private VisualElementAnimationSystem GetAnimationSystem()
		{
			return null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x5A47FB0", Offset = "0x5A46BB0", VA = "0x185A47FB0")]
		internal void RegisterAnimation(IValueAnimationUpdate anim)
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5A4DC90", Offset = "0x5A4C890", VA = "0x185A4DC90")]
		internal void UnregisterAnimation(IValueAnimationUpdate anim)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x5A4DD00", Offset = "0x5A4C900", VA = "0x185A4DD00")]
		private void UnregisterRunningAnimations()
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5A480A0", Offset = "0x5A46CA0", VA = "0x185A480A0")]
		private void RegisterRunningAnimations()
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000321")]
		private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged)
		{
			return null;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x5A42AB0", Offset = "0x5A416B0", VA = "0x185A42AB0")]
		private static void AssignStyleValues(VisualElement ve, StyleValues src)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5A47810", Offset = "0x5A46410", VA = "0x185A47810")]
		private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead)
		{
			return default(StyleValues);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5A4B4F0", Offset = "0x5A4A0F0", VA = "0x185A4B4F0", Slot = "43")]
		private ValueAnimation<StyleValues> Start(StyleValues to, int durationMs)
		{
			return null;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x5A4A4E0", Offset = "0x5A490E0", VA = "0x185A4A4E0")]
		private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs)
		{
			return null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000C8")]
		public IExperimentalFeatures experimental
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000C9")]
		private ITransitionAnimations animation
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000034F8 File Offset: 0x000016F8
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		public VisualElement.Hierarchy hierarchy
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x5A4FEA0", Offset = "0x5A4EAA0", VA = "0x185A4FEA0")]
			[CompilerGenerated]
			get
			{
				return default(VisualElement.Hierarchy);
			}
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x5A50F40", Offset = "0x5A4FB40", VA = "0x185A50F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00003510 File Offset: 0x00001710
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CB")]
		internal bool isRootVisualContainer
		{
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x5A4FF30", Offset = "0x5A4EB30", VA = "0x185A4FF30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x5A50FE0", Offset = "0x5A4FBE0", VA = "0x185A50FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		internal bool disableClipping
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x5A4FC30", Offset = "0x5A4E830", VA = "0x185A4FC30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x5A50ED0", Offset = "0x5A4FAD0", VA = "0x185A50ED0")]
			set
			{
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x5A4A4A0", Offset = "0x5A490A0", VA = "0x185A4A4A0")]
		internal bool ShouldClip()
		{
			return default(bool);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000CD")]
		public VisualElement parent
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x5A50330", Offset = "0x5A4EF30", VA = "0x185A50330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		internal BaseVisualElementPanel elementPanel
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x5A4FC40", Offset = "0x5A4E840", VA = "0x185A4FC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x5A50EF0", Offset = "0x5A4FAF0", VA = "0x185A50EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000CF")]
		public IPanel panel
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x5A50320", Offset = "0x5A4EF20", VA = "0x185A50320")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000D0")]
		public virtual VisualElement contentContainer
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (set) Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		internal VisualTreeAsset visualTreeAssetSource
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x5A51C60", Offset = "0x5A50860", VA = "0x185A51C60")]
			set
			{
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x5A428E0", Offset = "0x5A414E0", VA = "0x185A428E0")]
		public void Add(VisualElement child)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x5A469A0", Offset = "0x5A455A0", VA = "0x185A469A0")]
		public void Insert(int index, VisualElement element)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x5A44330", Offset = "0x5A42F30", VA = "0x185A44330")]
		public void Clear()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x5A44AD0", Offset = "0x5A436D0", VA = "0x185A44AD0")]
		public VisualElement ElementAt(int index)
		{
			return null;
		}

		// Token: 0x170000D2 RID: 210
		[Token(Token = "0x170000D2")]
		public VisualElement this[int key]
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x5A4F5B0", Offset = "0x5A4E1B0", VA = "0x185A4F5B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x170000D3")]
		public int childCount
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x5A4F830", Offset = "0x5A4E430", VA = "0x185A4F830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x5A468B0", Offset = "0x5A454B0", VA = "0x185A468B0")]
		public int IndexOf(VisualElement element)
		{
			return 0;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x5A448B0", Offset = "0x5A434B0", VA = "0x185A448B0")]
		internal VisualElement ElementAtTreePath(List<int> childIndexes)
		{
			return null;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x5A454A0", Offset = "0x5A440A0", VA = "0x185A454A0")]
		internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
		{
			return default(bool);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x5A437B0", Offset = "0x5A423B0", VA = "0x185A437B0")]
		public void BringToFront()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x5A49020", Offset = "0x5A47C20", VA = "0x185A49020")]
		public void SendToBack()
		{
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5A47630", Offset = "0x5A46230", VA = "0x185A47630")]
		public void PlaceBehind(VisualElement sibling)
		{
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x5A48250", Offset = "0x5A46E50", VA = "0x185A48250")]
		public void RemoveFromHierarchy()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000342")]
		public T GetFirstOfType<T>() where T : class
		{
			return null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000343")]
		public T GetFirstAncestorOfType<T>() where T : class
		{
			return null;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x5A44840", Offset = "0x5A43440", VA = "0x185A44840")]
		public bool Contains(VisualElement child)
		{
			return default(bool);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x5A45690", Offset = "0x5A44290", VA = "0x185A45690")]
		private void GatherAllChildren(List<VisualElement> elements)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x5A45300", Offset = "0x5A43F00", VA = "0x185A45300")]
		public VisualElement FindCommonAncestor(VisualElement other)
		{
			return null;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x5A46440", Offset = "0x5A45040", VA = "0x185A46440")]
		internal VisualElement GetRoot()
		{
			return null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x5A46400", Offset = "0x5A45000", VA = "0x185A46400")]
		internal VisualElement GetRootVisualContainer()
		{
			return null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x5A459B0", Offset = "0x5A445B0", VA = "0x185A459B0")]
		internal VisualElement GetNextElementDepthFirst()
		{
			return null;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x5A46260", Offset = "0x5A44E60", VA = "0x185A46260")]
		internal VisualElement GetPreviousElementDepthFirst()
		{
			return null;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x5A48E80", Offset = "0x5A47A80", VA = "0x185A48E80")]
		internal VisualElement RetargetElement(VisualElement retargetAgainst)
		{
			return null;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600034C RID: 844 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x170000D4")]
		private Vector3 positionWithLayout
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x5A50350", Offset = "0x5A4EF50", VA = "0x185A50350")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x5A45CE0", Offset = "0x5A448E0", VA = "0x185A45CE0")]
		internal void GetPivotedMatrixWithLayout(out Matrix4x4 result)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600034E RID: 846 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x170000D5")]
		internal bool hasDefaultRotationAndScale
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x5A3C7D0", Offset = "0x5A3B3D0", VA = "0x185A3C7D0")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x5A46E60", Offset = "0x5A45A60", VA = "0x185A46E60")]
		[MethodImpl(256)]
		internal static float Min(float a, float b, float c, float d)
		{
			return 0f;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x5A46CF0", Offset = "0x5A458F0", VA = "0x185A46CF0")]
		[MethodImpl(256)]
		internal static float Max(float a, float b, float c, float d)
		{
			return 0f;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x5A4AC90", Offset = "0x5A49890", VA = "0x185A4AC90")]
		[MethodImpl(256)]
		private void TransformAlignedRectToParentSpace(ref Rect rect)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x5A43800", Offset = "0x5A42400", VA = "0x185A43800")]
		internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect)
		{
			return default(Rect);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x5A4ADC0", Offset = "0x5A499C0", VA = "0x185A4ADC0")]
		[MethodImpl(256)]
		internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x5A47180", Offset = "0x5A45D80", VA = "0x185A47180")]
		internal static void OrderMinMaxRect(ref Rect rect)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0")]
		[MethodImpl(256)]
		internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point)
		{
			return default(Vector2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x5A470F0", Offset = "0x5A45CF0", VA = "0x185A470F0")]
		[MethodImpl(256)]
		internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector)
		{
			return default(Vector2);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x5A46E70", Offset = "0x5A45A70", VA = "0x185A46E70")]
		internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res)
		{
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x5A4AEE0", Offset = "0x5A49AE0", VA = "0x185A4AEE0")]
		[MethodImpl(256)]
		private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res)
		{
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x5A4AE40", Offset = "0x5A49A40", VA = "0x185A4AE40")]
		[MethodImpl(256)]
		private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs)
		{
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000D6")]
		public IVisualElementScheduler schedule
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4D365B0", Offset = "0x4D351B0", VA = "0x184D365B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x5A4DAB0", Offset = "0x5A4C6B0", VA = "0x185A4DAB0", Slot = "45")]
		private IVisualElementScheduledItem Execute(Action<TimerState> timerUpdateEvent)
		{
			return null;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x5A4DBA0", Offset = "0x5A4C7A0", VA = "0x185A4DBA0", Slot = "46")]
		private IVisualElementScheduledItem Execute(Action updateEvent)
		{
			return null;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000D7")]
		public IStyle style
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x5A50530", Offset = "0x5A4F130", VA = "0x185A50530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000D8")]
		public ICustomStyle customStyle
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x5A4FB70", Offset = "0x5A4E770", VA = "0x185A4FB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x170000D9")]
		public VisualElementStyleSheetSet styleSheets
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x5A50500", Offset = "0x5A4F100", VA = "0x185A50500")]
			get
			{
				return default(VisualElementStyleSheetSet);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x5A424E0", Offset = "0x5A410E0", VA = "0x185A424E0")]
		internal void AddStyleSheetPath(string sheetPath)
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x5A48380", Offset = "0x5A46F80", VA = "0x185A48380")]
		private StyleFloat ResolveLengthValue(Length length, bool isRow)
		{
			return default(StyleFloat);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x5A48B60", Offset = "0x5A47760", VA = "0x185A48B60")]
		private Vector3 ResolveTranslate()
		{
			return default(Vector3);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x5A488B0", Offset = "0x5A474B0", VA = "0x185A488B0")]
		private Vector3 ResolveTransformOrigin()
		{
			return default(Vector3);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x5A484C0", Offset = "0x5A470C0", VA = "0x185A484C0")]
		private Quaternion ResolveRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x5A486D0", Offset = "0x5A472D0", VA = "0x185A486D0")]
		private Vector3 ResolveScale()
		{
			return default(Vector3);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		public string tooltip
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x5A505D0", Offset = "0x5A4F1D0", VA = "0x185A505D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x5A51820", Offset = "0x5A50420", VA = "0x185A51820")]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000DB")]
		private VisualElement.TypeData typeData
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x5A506D0", Offset = "0x5A4F2D0", VA = "0x185A506D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170000DC")]
		public IResolvedStyle resolvedStyle
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x170000DD")]
		private Color backgroundColor
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x5A4B700", Offset = "0x5A4A300", VA = "0x185A4B700", Slot = "47")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x170000DE")]
		private Color borderBottomColor
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x5A4B730", Offset = "0x5A4A330", VA = "0x185A4B730", Slot = "48")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x170000DF")]
		private float borderBottomLeftRadius
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x5A4B760", Offset = "0x5A4A360", VA = "0x185A4B760", Slot = "49")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x170000E0")]
		private float borderBottomRightRadius
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x5A4B790", Offset = "0x5A4A390", VA = "0x185A4B790", Slot = "50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x170000E1")]
		private float borderBottomWidth
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x5A4B7C0", Offset = "0x5A4A3C0", VA = "0x185A4B7C0", Slot = "51")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x170000E2")]
		private Color borderLeftColor
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x5A4B7F0", Offset = "0x5A4A3F0", VA = "0x185A4B7F0", Slot = "52")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x170000E3")]
		private float borderLeftWidth
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x5A4B820", Offset = "0x5A4A420", VA = "0x185A4B820", Slot = "53")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x170000E4")]
		private Color borderRightColor
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x5A4B850", Offset = "0x5A4A450", VA = "0x185A4B850", Slot = "54")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x170000E5")]
		private float borderRightWidth
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x5A4B880", Offset = "0x5A4A480", VA = "0x185A4B880", Slot = "55")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000373 RID: 883 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x170000E6")]
		private Color borderTopColor
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x5A4B8B0", Offset = "0x5A4A4B0", VA = "0x185A4B8B0", Slot = "56")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x170000E7")]
		private float borderTopLeftRadius
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x5A4B8E0", Offset = "0x5A4A4E0", VA = "0x185A4B8E0", Slot = "57")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x170000E8")]
		private float borderTopRightRadius
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x5A4B910", Offset = "0x5A4A510", VA = "0x185A4B910", Slot = "58")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x170000E9")]
		private float borderTopWidth
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x5A4B940", Offset = "0x5A4A540", VA = "0x185A4B940", Slot = "59")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x170000EA")]
		private float bottom
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x5A4B970", Offset = "0x5A4A570", VA = "0x185A4B970", Slot = "60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x170000EB")]
		private Color color
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x5A4B9A0", Offset = "0x5A4A5A0", VA = "0x185A4B9A0", Slot = "61")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x170000EC")]
		private DisplayStyle display
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x5A4B9D0", Offset = "0x5A4A5D0", VA = "0x185A4B9D0", Slot = "62")]
			get
			{
				return DisplayStyle.Flex;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x170000ED")]
		private FlexDirection flexDirection
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x5A4B9E0", Offset = "0x5A4A5E0", VA = "0x185A4B9E0", Slot = "63")]
			get
			{
				return FlexDirection.Column;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037B RID: 891 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x170000EE")]
		private float flexGrow
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x5A4B9F0", Offset = "0x5A4A5F0", VA = "0x185A4B9F0", Slot = "64")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x170000EF")]
		private float flexShrink
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x5A4BA00", Offset = "0x5A4A600", VA = "0x185A4BA00", Slot = "65")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x170000F0")]
		private float height
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x5A4BA10", Offset = "0x5A4A610", VA = "0x185A4BA10", Slot = "66")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x170000F1")]
		private float left
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x5A4BA40", Offset = "0x5A4A640", VA = "0x185A4BA40", Slot = "67")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x170000F2")]
		private float marginBottom
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x5A4BA70", Offset = "0x5A4A670", VA = "0x185A4BA70", Slot = "68")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x170000F3")]
		private float marginLeft
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x5A4BAA0", Offset = "0x5A4A6A0", VA = "0x185A4BAA0", Slot = "69")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x170000F4")]
		private float marginRight
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x5A4BAD0", Offset = "0x5A4A6D0", VA = "0x185A4BAD0", Slot = "70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x170000F5")]
		private float marginTop
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x5A4BB00", Offset = "0x5A4A700", VA = "0x185A4BB00", Slot = "71")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x170000F6")]
		private StyleFloat minHeight
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x5A4BB30", Offset = "0x5A4A730", VA = "0x185A4BB30", Slot = "72")]
			get
			{
				return default(StyleFloat);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x170000F7")]
		private StyleFloat minWidth
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x5A4BB60", Offset = "0x5A4A760", VA = "0x185A4BB60", Slot = "73")]
			get
			{
				return default(StyleFloat);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x170000F8")]
		private float opacity
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x5A4BB90", Offset = "0x5A4A790", VA = "0x185A4BB90", Slot = "74")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x170000F9")]
		private float paddingBottom
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x5A4BBA0", Offset = "0x5A4A7A0", VA = "0x185A4BBA0", Slot = "75")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000387 RID: 903 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x170000FA")]
		private float paddingLeft
		{
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x5A4BBD0", Offset = "0x5A4A7D0", VA = "0x185A4BBD0", Slot = "76")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x170000FB")]
		private float paddingRight
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x5A4BC00", Offset = "0x5A4A800", VA = "0x185A4BC00", Slot = "77")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x170000FC")]
		private float paddingTop
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x5A4BC30", Offset = "0x5A4A830", VA = "0x185A4BC30", Slot = "78")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x170000FD")]
		private float right
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x5A4BC60", Offset = "0x5A4A860", VA = "0x185A4BC60", Slot = "79")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x170000FE")]
		private Scale scale
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x5A4BC90", Offset = "0x5A4A890", VA = "0x185A4BC90", Slot = "80")]
			get
			{
				return default(Scale);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x170000FF")]
		private float top
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x5A4BCC0", Offset = "0x5A4A8C0", VA = "0x185A4BCC0", Slot = "81")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x17000100")]
		private Vector3 transformOrigin
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x5A4BCF0", Offset = "0x5A4A8F0", VA = "0x185A4BCF0", Slot = "82")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x17000101")]
		private Vector3 translate
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x5A4BD20", Offset = "0x5A4A920", VA = "0x185A4BD20", Slot = "83")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x17000102")]
		private Color unityBackgroundImageTintColor
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x5A4BD50", Offset = "0x5A4A950", VA = "0x185A4BD50", Slot = "84")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x17000103")]
		private int unitySliceLeft
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x5A4BD80", Offset = "0x5A4A980", VA = "0x185A4BD80", Slot = "85")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x17000104")]
		private int unitySliceRight
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x5A4BD90", Offset = "0x5A4A990", VA = "0x185A4BD90", Slot = "86")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000105")]
		private Color unityTextOutlineColor
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x5A4BDA0", Offset = "0x5A4A9A0", VA = "0x185A4BDA0", Slot = "87")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x17000106")]
		private float unityTextOutlineWidth
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x5A4BDD0", Offset = "0x5A4A9D0", VA = "0x185A4BDD0", Slot = "88")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x17000107")]
		private Visibility visibility
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x5A4BDE0", Offset = "0x5A4A9E0", VA = "0x185A4BDE0", Slot = "89")]
			get
			{
				return Visibility.Visible;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x17000108")]
		private WhiteSpace whiteSpace
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x5A4BDF0", Offset = "0x5A4A9F0", VA = "0x185A4BDF0", Slot = "90")]
			get
			{
				return WhiteSpace.Normal;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x17000109")]
		private float width
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x5A4BE00", Offset = "0x5A4AA00", VA = "0x185A4BE00", Slot = "91")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_NextId;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x8")]
		private static List<string> s_EmptyClassList;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly PropertyName userDataPropertyKey;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string disabledUssClassName;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x30")]
		private string m_Name;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_ClassList;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x40")]
		private List<KeyValuePair<PropertyName, object>> m_PropertyBag;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x48")]
		private VisualElementFlags m_Flags;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x50")]
		private string m_ViewDataKey;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x58")]
		private RenderHints m_RenderHints;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x5C")]
		internal Rect lastLayout;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x6C")]
		internal Rect lastPseudoPadding;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x80")]
		internal RenderChainVEData renderChainData;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x1D8")]
		private Rect m_Layout;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x1E8")]
		private Rect m_BoundingBox;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x1F8")]
		private Rect m_WorldBoundingBox;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x208")]
		private Matrix4x4 m_WorldTransformCache;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x248")]
		private Matrix4x4 m_WorldTransformInverseCache;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x288")]
		private Rect m_WorldClip;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x298")]
		private Rect m_WorldClipMinusGroup;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x2A8")]
		private bool m_WorldClipIsInfinite;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x20")]
		internal static readonly Rect s_InfiniteRect;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x2AC")]
		internal PseudoStates triggerPseudoMask;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x2B0")]
		internal PseudoStates dependencyPseudoMask;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x2B4")]
		private PseudoStates m_PseudoStates;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x2BC")]
		private PickingMode m_PickingMode;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x2C8")]
		internal ComputedStyle m_Style;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x320")]
		internal StyleVariableContext variableContext;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x328")]
		internal int inheritedStylesHash;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x32C")]
		internal readonly uint controlid;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x330")]
		internal int imguiContainerDescendantCount;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x340")]
		private ProfilerMarker k_GenerateVisualContentMarker;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x348")]
		private VisualElement.RenderTargetMode m_SubRenderTargetMode;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x30")]
		private static Material s_runtimeMaterial;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x350")]
		private Material m_defaultMaterial;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x358")]
		private List<IValueAnimationUpdate> m_RunningAnimations;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		internal const string k_RootVisualContainerName = "rootVisualContainer";

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x370")]
		private VisualElement m_PhysicalParent;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x378")]
		private VisualElement m_LogicalParent;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x38")]
		private static readonly List<VisualElement> s_EmptyList;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x380")]
		private List<VisualElement> m_Children;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x390")]
		private VisualTreeAsset m_VisualTreeAssetSource;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x40")]
		internal static VisualElement.CustomStyleAccess s_CustomStyleAccess;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x398")]
		internal InlineStyleAccess inlineStyleAccess;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x3A0")]
		internal List<StyleSheet> styleSheetList;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Regex s_InternalStyleSheetPath;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x50")]
		internal static readonly PropertyName tooltipPropertyKey;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x58")]
		private static readonly Dictionary<Type, VisualElement.TypeData> s_TypeData;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x3A8")]
		private VisualElement.TypeData m_TypeData;

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		public class UxmlFactory : UxmlFactory<VisualElement, VisualElement.UxmlTraits>
		{
			// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x5A41650", Offset = "0x5A40250", VA = "0x185A41650")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
		{
			// Token: 0x1700010A RID: 266
			// (get) Token: 0x0600039A RID: 922 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700010A")]
			protected UxmlIntAttributeDescription focusIndex
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600039B RID: 923 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700010B")]
			protected UxmlBoolAttributeDescription focusable
			{
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x5A41690", Offset = "0x5A40290", VA = "0x185A41690", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x5A41C40", Offset = "0x5A40840", VA = "0x185A41C40")]
			public UxmlTraits()
			{
			}

			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x18")]
			protected UxmlStringAttributeDescription m_Name;

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x20")]
			private UxmlStringAttributeDescription m_ViewDataKey;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x28")]
			protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode;

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x30")]
			private UxmlStringAttributeDescription m_Tooltip;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x38")]
			private UxmlEnumAttributeDescription<UsageHints> m_UsageHints;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x48")]
			private UxmlIntAttributeDescription m_TabIndex;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x58")]
			private UxmlStringAttributeDescription m_Class;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x60")]
			private UxmlStringAttributeDescription m_ContentContainer;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x68")]
			private UxmlStringAttributeDescription m_Style;
		}

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		public enum MeasureMode
		{
			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			Undefined,
			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			Exactly,
			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			AtMost
		}

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		internal enum RenderTargetMode
		{
			// Token: 0x040001DC RID: 476
			[Token(Token = "0x40001DC")]
			None,
			// Token: 0x040001DD RID: 477
			[Token(Token = "0x40001DD")]
			NoColorConversion,
			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			LinearToGamma,
			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			GammaToLinear
		}

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		public struct Hierarchy
		{
			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600039E RID: 926 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x1700010C")]
			public VisualElement parent
			{
				[Token(Token = "0x600039E")]
				[Address(RVA = "0x5A3F140", Offset = "0x5A3DD40", VA = "0x185A3F140")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal Hierarchy(VisualElement element)
			{
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x5A3DA20", Offset = "0x5A3C620", VA = "0x185A3DA20")]
			public void Add(VisualElement child)
			{
			}

			// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x5A3E150", Offset = "0x5A3CD50", VA = "0x185A3E150")]
			public void Insert(int index, VisualElement child)
			{
			}

			// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x5A3EE60", Offset = "0x5A3DA60", VA = "0x185A3EE60")]
			public void Remove(VisualElement child)
			{
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x5A3EAC0", Offset = "0x5A3D6C0", VA = "0x185A3EAC0")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x5A3DC10", Offset = "0x5A3C810", VA = "0x185A3DC10")]
			public void Clear()
			{
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x5A3DAE0", Offset = "0x5A3C6E0", VA = "0x185A3DAE0")]
			internal void BringToFront(VisualElement child)
			{
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x5A3EFA0", Offset = "0x5A3DBA0", VA = "0x185A3EFA0")]
			internal void SendToBack(VisualElement child)
			{
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x5A3E7C0", Offset = "0x5A3D3C0", VA = "0x185A3E7C0")]
			internal void PlaceBehind(VisualElement child, VisualElement over)
			{
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x5A3E670", Offset = "0x5A3D270", VA = "0x185A3E670")]
			private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex)
			{
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x060003A9 RID: 937 RVA: 0x00003B40 File Offset: 0x00001D40
			[Token(Token = "0x1700010D")]
			public int childCount
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x5A3F0F0", Offset = "0x5A3DCF0", VA = "0x185A3F0F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700010E RID: 270
			[Token(Token = "0x1700010E")]
			public VisualElement this[int key]
			{
				[Token(Token = "0x60003AA")]
				[Address(RVA = "0x5A3DFE0", Offset = "0x5A3CBE0", VA = "0x185A3DFE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00003B58 File Offset: 0x00001D58
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x5A3E0F0", Offset = "0x5A3CCF0", VA = "0x185A3E0F0")]
			public int IndexOf(VisualElement element)
			{
				return 0;
			}

			// Token: 0x060003AC RID: 940 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x5A3DFE0", Offset = "0x5A3CBE0", VA = "0x185A3DFE0")]
			public VisualElement ElementAt(int index)
			{
				return null;
			}

			// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x5A3F050", Offset = "0x5A3DC50", VA = "0x185A3F050")]
			private void SetParent(VisualElement value)
			{
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x5A3E8B0", Offset = "0x5A3D4B0", VA = "0x185A3E8B0")]
			private void PutChildAtIndex(VisualElement child, int index)
			{
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x5A3EDE0", Offset = "0x5A3D9E0", VA = "0x185A3EDE0")]
			private void RemoveChildAtIndex(int index)
			{
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x5A3E9D0", Offset = "0x5A3D5D0", VA = "0x185A3E9D0")]
			private void ReleaseChildList()
			{
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x00003B70 File Offset: 0x00001D70
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x5A3E0E0", Offset = "0x5A3CCE0", VA = "0x185A3E0E0")]
			public bool Equals(VisualElement.Hierarchy other)
			{
				return default(bool);
			}

			// Token: 0x060003B2 RID: 946 RVA: 0x00003B88 File Offset: 0x00001D88
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x5A3E040", Offset = "0x5A3CC40", VA = "0x185A3E040", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060003B3 RID: 947 RVA: 0x00003BA0 File Offset: 0x00001DA0
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x5A2D6F0", Offset = "0x5A2C2F0", VA = "0x185A2D6F0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060003B4 RID: 948 RVA: 0x00003BB8 File Offset: 0x00001DB8
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x5A3F160", Offset = "0x5A3DD60", VA = "0x185A3F160")]
			public static bool operator ==(VisualElement.Hierarchy x, VisualElement.Hierarchy y)
			{
				return default(bool);
			}

			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";

			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x0")]
			private readonly VisualElement m_Owner;
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable
		{
			// Token: 0x1700010F RID: 271
			// (get) Token: 0x060003B5 RID: 949 RVA: 0x0000212A File Offset: 0x0000032A
			// (set) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700010F")]
			public VisualElement element
			{
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "12")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x5A3CC50", Offset = "0x5A3B850", VA = "0x185A3CC50")]
			protected BaseVisualElementScheduledItem(VisualElement handler)
			{
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x5A3CC40", Offset = "0x5A3B840", VA = "0x185A3CC40", Slot = "10")]
			public IVisualElementScheduledItem StartingIn(long delayMs)
			{
				return null;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x5A3C940", Offset = "0x5A3B540", VA = "0x185A3C940", Slot = "11")]
			public IVisualElementScheduledItem Every(long intervalMs)
			{
				return null;
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x5A3CA50", Offset = "0x5A3B650", VA = "0x185A3CA50", Slot = "5")]
			internal override void OnItemUnscheduled()
			{
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x5A3CC10", Offset = "0x5A3B810", VA = "0x185A3CC10", Slot = "7")]
			public void Resume()
			{
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x5A3CBE0", Offset = "0x5A3B7E0", VA = "0x185A3CBE0", Slot = "8")]
			public void Pause()
			{
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x5A3CA00", Offset = "0x5A3B600", VA = "0x185A3CA00", Slot = "9")]
			public void ExecuteLater(long delayMs)
			{
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x5A3CA90", Offset = "0x5A3B690", VA = "0x185A3CA90", Slot = "14")]
			public void OnPanelActivate()
			{
			}

			// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x5A3CB40", Offset = "0x5A3B740", VA = "0x185A3CB40", Slot = "15")]
			public void OnPanelDeactivate()
			{
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x00003BD0 File Offset: 0x00001DD0
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x5A3C8D0", Offset = "0x5A3B4D0", VA = "0x185A3C8D0", Slot = "13")]
			public bool CanBeActivated()
			{
				return default(bool);
			}

			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x40001E3")]
			[FieldOffset(Offset = "0x40")]
			public bool isScheduled;

			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x48")]
			private VisualElementPanelActivator m_Activator;
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		private abstract class VisualElementScheduledItem<ActionType> : VisualElement.BaseVisualElementScheduledItem
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C1")]
			public VisualElementScheduledItem(VisualElement handler, ActionType upEvent)
			{
			}

			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			[FieldOffset(Offset = "0x0")]
			public ActionType updateEvent;
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		private class TimerStateScheduledItem : VisualElement.VisualElementScheduledItem<Action<TimerState>>
		{
			// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x5A41320", Offset = "0x5A3FF20", VA = "0x185A41320")]
			public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent)
			{
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x5A412E0", Offset = "0x5A3FEE0", VA = "0x185A412E0", Slot = "4")]
			public override void PerformTimerUpdate(TimerState state)
			{
			}
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		private class SimpleScheduledItem : VisualElement.VisualElementScheduledItem<Action>
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x5A3F1A0", Offset = "0x5A3DDA0", VA = "0x185A3F1A0")]
			public SimpleScheduledItem(VisualElement handler, Action updateEvent)
			{
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x5A3F170", Offset = "0x5A3DD70", VA = "0x185A3F170", Slot = "4")]
			public override void PerformTimerUpdate(TimerState state)
			{
			}
		}

		// Token: 0x0200007C RID: 124
		[Token(Token = "0x200007C")]
		internal class CustomStyleAccess : ICustomStyle
		{
			// Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x5A3D090", Offset = "0x5A3BC90", VA = "0x185A3D090")]
			public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling)
			{
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00003BE8 File Offset: 0x00001DE8
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x5A3D520", Offset = "0x5A3C120", VA = "0x185A3D520", Slot = "4")]
			public bool TryGetValue(CustomStyleProperty<float> property, out float value)
			{
				return default(bool);
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00003C00 File Offset: 0x00001E00
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x5A3D230", Offset = "0x5A3BE30", VA = "0x185A3D230", Slot = "5")]
			public bool TryGetValue(CustomStyleProperty<int> property, out int value)
			{
				return default(bool);
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00003C18 File Offset: 0x00001E18
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x5A3D0C0", Offset = "0x5A3BCC0", VA = "0x185A3D0C0", Slot = "6")]
			public bool TryGetValue(CustomStyleProperty<Color> property, out Color value)
			{
				return default(bool);
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00003C30 File Offset: 0x00001E30
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x5A3D350", Offset = "0x5A3BF50", VA = "0x185A3D350", Slot = "7")]
			public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value)
			{
				return default(bool);
			}

			// Token: 0x060003CB RID: 971 RVA: 0x00003C48 File Offset: 0x00001E48
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x5A3D740", Offset = "0x5A3C340", VA = "0x185A3D740", Slot = "8")]
			public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value)
			{
				return default(bool);
			}

			// Token: 0x060003CC RID: 972 RVA: 0x00003C60 File Offset: 0x00001E60
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x5A3D630", Offset = "0x5A3C230", VA = "0x185A3D630", Slot = "9")]
			public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value)
			{
				return default(bool);
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00003C78 File Offset: 0x00001E78
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x5A3D850", Offset = "0x5A3C450", VA = "0x185A3D850", Slot = "10")]
			public bool TryGetValue(CustomStyleProperty<string> property, out string value)
			{
				return default(bool);
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00003C90 File Offset: 0x00001E90
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x5A3D460", Offset = "0x5A3C060", VA = "0x185A3D460")]
			private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp)
			{
				return default(bool);
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x5A3CFB0", Offset = "0x5A3BBB0", VA = "0x185A3CFB0")]
			private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp)
			{
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CustomStyleAccess()
			{
			}

			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, StylePropertyValue> m_CustomProperties;

			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			[FieldOffset(Offset = "0x18")]
			private float m_DpiScaling;
		}

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		private class TypeData
		{
			// Token: 0x17000110 RID: 272
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000110")]
			public Type type
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x5A41380", Offset = "0x5A3FF80", VA = "0x185A41380")]
			public TypeData(Type type)
			{
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000111")]
			public string fullTypeName
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x5A41410", Offset = "0x5A40010", VA = "0x185A41410")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000112")]
			public string typeName
			{
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x5A41490", Offset = "0x5A40090", VA = "0x185A41490")]
				get
				{
					return null;
				}
			}

			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			[FieldOffset(Offset = "0x18")]
			private string m_FullTypeName;

			// Token: 0x040001EA RID: 490
			[Token(Token = "0x40001EA")]
			[FieldOffset(Offset = "0x20")]
			private string m_TypeName;
		}
	}
}
