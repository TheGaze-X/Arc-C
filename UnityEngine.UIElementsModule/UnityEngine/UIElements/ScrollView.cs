using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public class ScrollView : VisualElement
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x000053A0 File Offset: 0x000035A0
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		public ScrollerVisibility horizontalScrollerVisibility
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x5AC7B60", Offset = "0x5AC6760", VA = "0x185AC7B60")]
			get
			{
				return ScrollerVisibility.Auto;
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x5AC8080", Offset = "0x5AC6C80", VA = "0x185AC8080")]
			set
			{
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x000053B8 File Offset: 0x000035B8
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D2")]
		public ScrollerVisibility verticalScrollerVisibility
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x5AC7F30", Offset = "0x5AC6B30", VA = "0x185AC7F30")]
			get
			{
				return ScrollerVisibility.Auto;
			}
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x5AC8410", Offset = "0x5AC7010", VA = "0x185AC8410")]
			set
			{
			}
		}

		// Token: 0x170001D3 RID: 467
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D3")]
		[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
		public bool showHorizontal
		{
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x5AC82F0", Offset = "0x5AC6EF0", VA = "0x185AC82F0")]
			set
			{
			}
		}

		// Token: 0x170001D4 RID: 468
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D4")]
		[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
		public bool showVertical
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x5AC8310", Offset = "0x5AC6F10", VA = "0x185AC8310")]
			set
			{
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x170001D5")]
		internal bool needsHorizontal
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x5AC7C60", Offset = "0x5AC6860", VA = "0x185AC7C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x170001D6")]
		internal bool needsVertical
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x5AC7CA0", Offset = "0x5AC68A0", VA = "0x185AC7CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x170001D7")]
		internal bool isVerticalScrollDisplayed
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x5AC7BE0", Offset = "0x5AC67E0", VA = "0x185AC7BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x170001D8")]
		internal bool isHorizontalScrollDisplayed
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x5AC7B70", Offset = "0x5AC6770", VA = "0x185AC7B70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00005430 File Offset: 0x00003630
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		public Vector2 scrollOffset
		{
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x5AC7D00", Offset = "0x5AC6900", VA = "0x185AC7D00")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x5AC81F0", Offset = "0x5AC6DF0", VA = "0x185AC81F0")]
			set
			{
			}
		}

		// Token: 0x170001DA RID: 474
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DA")]
		public float horizontalPageSize
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x5AC8070", Offset = "0x5AC6C70", VA = "0x185AC8070")]
			set
			{
			}
		}

		// Token: 0x170001DB RID: 475
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DB")]
		public float verticalPageSize
		{
			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x5AC8400", Offset = "0x5AC7000", VA = "0x185AC8400")]
			set
			{
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00005448 File Offset: 0x00003648
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DC")]
		public float mouseWheelScrollSize
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x459E1D0", Offset = "0x459CDD0", VA = "0x18459E1D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x5AC8130", Offset = "0x5AC6D30", VA = "0x185AC8130")]
			set
			{
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x170001DD")]
		internal float scrollableWidth
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x5AC7E70", Offset = "0x5AC6A70", VA = "0x185AC7E70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x170001DE")]
		internal float scrollableHeight
		{
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x5AC7DC0", Offset = "0x5AC69C0", VA = "0x185AC7DC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x170001DF")]
		private bool hasInertia
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x5AC7B40", Offset = "0x5AC6740", VA = "0x185AC7B40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E0")]
		public float scrollDecelerationRate
		{
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x5AC7CF0", Offset = "0x5AC68F0", VA = "0x185AC7CF0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x5AC81D0", Offset = "0x5AC6DD0", VA = "0x185AC81D0")]
			set
			{
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000054C0 File Offset: 0x000036C0
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E1")]
		public float elasticity
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x5AC7B30", Offset = "0x5AC6730", VA = "0x185AC7B30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x5AC8050", Offset = "0x5AC6C50", VA = "0x185AC8050")]
			set
			{
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x000054D8 File Offset: 0x000036D8
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E2")]
		public ScrollView.TouchScrollBehavior touchScrollBehavior
		{
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x5AC7F20", Offset = "0x5AC6B20", VA = "0x185AC7F20")]
			get
			{
				return ScrollView.TouchScrollBehavior.Unrestricted;
			}
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x5AC8330", Offset = "0x5AC6F30", VA = "0x185AC8330")]
			set
			{
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000054F0 File Offset: 0x000036F0
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E3")]
		public ScrollView.NestedInteractionKind nestedInteractionKind
		{
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x5AC7CE0", Offset = "0x5AC68E0", VA = "0x185AC7CE0")]
			get
			{
				return ScrollView.NestedInteractionKind.Default;
			}
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x5AC81C0", Offset = "0x5AC6DC0", VA = "0x185AC81C0")]
			set
			{
			}
		}

		// Token: 0x170001E4 RID: 484
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E4")]
		public long elasticAnimationIntervalMs
		{
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x5AC7F40", Offset = "0x5AC6B40", VA = "0x185AC7F40")]
			set
			{
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x5AC3F30", Offset = "0x5AC2B30", VA = "0x185AC3F30")]
		private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5AC5030", Offset = "0x5AC3C30", VA = "0x185AC5030")]
		private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x5AC6200", Offset = "0x5AC4E00", VA = "0x185AC6200")]
		private void UpdateHorizontalSliderPageSize()
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x5AC6800", Offset = "0x5AC5400", VA = "0x185AC6800")]
		private void UpdateVerticalSliderPageSize()
		{
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x5AC5CA0", Offset = "0x5AC48A0", VA = "0x185AC5CA0")]
		internal void UpdateContentViewTransform()
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x5AC5610", Offset = "0x5AC4210", VA = "0x185AC5610")]
		public void ScrollTo(VisualElement child)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x5AC2820", Offset = "0x5AC1420", VA = "0x185AC2820")]
		private float GetXDeltaOffset(VisualElement child)
		{
			return 0f;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x5AC2B30", Offset = "0x5AC1730", VA = "0x185AC2B30")]
		private float GetYDeltaOffset(VisualElement child)
		{
			return 0f;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x5AC27B0", Offset = "0x5AC13B0", VA = "0x185AC27B0")]
		private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax)
		{
			return 0f;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E5")]
		public VisualElement contentViewport
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x5AACF70", Offset = "0x5AABB70", VA = "0x185AACF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x5AAD570", Offset = "0x5AAC170", VA = "0x185AAD570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E6")]
		public Scroller horizontalScroller
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x45A7900", Offset = "0x45A6500", VA = "0x1845A7900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x45A7CF0", Offset = "0x45A68F0", VA = "0x1845A7CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E7")]
		public Scroller verticalScroller
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x4432F60", Offset = "0x4431B60", VA = "0x184432F60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x45A7D00", Offset = "0x45A6900", VA = "0x1845A7D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001E8")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x5AC7B20", Offset = "0x5AC6720", VA = "0x185AC7B20", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x5AC7B10", Offset = "0x5AC6710", VA = "0x185AC7B10")]
		public ScrollView()
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x5AC6D20", Offset = "0x5AC5920", VA = "0x185AC6D20")]
		public ScrollView(ScrollViewMode scrollViewMode)
		{
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00005550 File Offset: 0x00003750
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E9")]
		public ScrollViewMode mode
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x5AC7C50", Offset = "0x5AC6850", VA = "0x185AC7C50")]
			get
			{
				return ScrollViewMode.Vertical;
			}
			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x5AC8110", Offset = "0x5AC6D10", VA = "0x185AC8110")]
			set
			{
			}
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x5AC5860", Offset = "0x5AC4460", VA = "0x185AC5860")]
		private void SetScrollViewMode(ScrollViewMode mode)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x5AC31A0", Offset = "0x5AC1DA0", VA = "0x185AC31A0")]
		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x5AC36D0", Offset = "0x5AC22D0", VA = "0x185AC36D0")]
		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x5AC4130", Offset = "0x5AC2D30", VA = "0x185AC4130")]
		private void OnPointerCapture(PointerCaptureEvent evt)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x5AC4040", Offset = "0x5AC2C40", VA = "0x185AC4040")]
		private void OnPointerCaptureOut(PointerCaptureOutEvent evt)
		{
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5AC3C30", Offset = "0x5AC2830", VA = "0x185AC3C30")]
		private void OnGeometryChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x5AC54F0", Offset = "0x5AC40F0", VA = "0x185AC54F0")]
		private void ScheduleResetLayoutPass()
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x5AC54E0", Offset = "0x5AC40E0", VA = "0x185AC54E0")]
		private void ResetLayoutPass()
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x5AC1F00", Offset = "0x5AC0B00", VA = "0x185AC1F00")]
		private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit)
		{
			return 0f;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x5AC2070", Offset = "0x5AC0C70", VA = "0x185AC2070")]
		private void ComputeInitialSpringBackVelocity()
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x5AC5A10", Offset = "0x5AC4610", VA = "0x185AC5A10")]
		private void SpringBack()
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x5AC1800", Offset = "0x5AC0400", VA = "0x185AC1800")]
		internal void ApplyScrollInertia()
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x5AC50D0", Offset = "0x5AC3CD0", VA = "0x185AC50D0")]
		private void PostPointerUpAnimation()
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x5AC42D0", Offset = "0x5AC2ED0", VA = "0x185AC42D0")]
		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x5AC4520", Offset = "0x5AC3120", VA = "0x185AC4520")]
		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x5AC3FD0", Offset = "0x5AC2BD0", VA = "0x185AC3FD0")]
		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5AC4780", Offset = "0x5AC3380", VA = "0x185AC4780")]
		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5AC2E40", Offset = "0x5AC1A40", VA = "0x185AC2E40")]
		internal void InitTouchScrolling(Vector2 position)
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5AC21B0", Offset = "0x5AC0DB0", VA = "0x185AC21B0")]
		internal ScrollView.TouchScrollingResult ComputeTouchScrolling(Vector2 position)
		{
			return ScrollView.TouchScrollingResult.Apply;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5AC1BD0", Offset = "0x5AC07D0", VA = "0x185AC1BD0")]
		private bool ApplyTouchScrolling(Vector2 newScrollOffset)
		{
			return default(bool);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x5AC53A0", Offset = "0x5AC3FA0", VA = "0x185AC53A0")]
		private bool ReleaseScrolling(int pointerId, IEventHandler target)
		{
			return default(bool);
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x5AC2560", Offset = "0x5AC1160", VA = "0x185AC2560")]
		private void ExecuteElasticSpringAnimation()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x5AC15C0", Offset = "0x5AC01C0", VA = "0x185AC15C0")]
		private void AdjustScrollers()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x5AC6350", Offset = "0x5AC4F50", VA = "0x185AC6350")]
		internal void UpdateScrollers(bool displayHorizontal, bool displayVertical)
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x5AC4EA0", Offset = "0x5AC3AA0", VA = "0x185AC4EA0")]
		private void OnScrollersGeometryChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x5AC4870", Offset = "0x5AC3470", VA = "0x185AC4870")]
		private void OnScrollWheel(WheelEvent evt)
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x5AC4850", Offset = "0x5AC3450", VA = "0x185AC4850")]
		private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt)
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x5AC4860", Offset = "0x5AC3460", VA = "0x185AC4860")]
		private void OnRootPointerUp(PointerUpEvent evt)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x5AC5280", Offset = "0x5AC3E80", VA = "0x185AC5280")]
		private void ReadSingleLineHeight()
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x5AC5F40", Offset = "0x5AC4B40", VA = "0x185AC5F40")]
		private void UpdateElasticBehaviour()
		{
		}

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x3B0")]
		private int m_FirstLayoutPass;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x3B4")]
		private ScrollerVisibility m_HorizontalScrollerVisibility;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x3B8")]
		private ScrollerVisibility m_VerticalScrollerVisibility;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x3C0")]
		private VisualElement m_AttachedRootVisualContainer;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x3C8")]
		private float m_SingleLineHeight;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x3CC")]
		internal bool m_MouseWheelScrollSizeIsInline;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x3D0")]
		private float m_HorizontalPageSize;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x3D4")]
		private float m_VerticalPageSize;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x3D8")]
		private float m_MouseWheelScrollSize;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly float k_DefaultScrollDecelerationRate;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x3DC")]
		private float m_ScrollDecelerationRate;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x3E0")]
		private float k_ScaledPixelsPerPointMultiplier;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x3E4")]
		private float k_TouchScrollInertiaBaseTimeInterval;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x4")]
		private static readonly float k_DefaultElasticity;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x3E8")]
		private float m_Elasticity;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x3EC")]
		private ScrollView.TouchScrollBehavior m_TouchScrollBehavior;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x3F0")]
		private ScrollView.NestedInteractionKind m_NestedInteractionKind;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly long k_DefaultElasticAnimationInterval;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x3F8")]
		private long m_ElasticAnimationIntervalMs;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x418")]
		private VisualElement m_ContentContainer;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x420")]
		private VisualElement m_ContentAndVerticalScrollContainer;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x428")]
		private float previousVerticalTouchScrollTimeStamp;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x42C")]
		private float previousHorizontalTouchScrollTimeStamp;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x430")]
		private float elapsedTimeSinceLastVerticalTouchScroll;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x434")]
		private float elapsedTimeSinceLastHorizontalTouchScroll;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ussClassName;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string viewportUssClassName;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string contentAndVerticalScrollUssClassName;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string contentUssClassName;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string hScrollerUssClassName;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string vScrollerUssClassName;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string horizontalVariantUssClassName;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string verticalVariantUssClassName;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string verticalHorizontalVariantUssClassName;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string scrollVariantUssClassName;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x438")]
		private ScrollViewMode m_Mode;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x440")]
		private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x448")]
		private Vector2 m_StartPosition;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x450")]
		private Vector2 m_PointerStartPosition;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x458")]
		private Vector2 m_Velocity;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x460")]
		private Vector2 m_SpringBackVelocity;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x468")]
		private Vector2 m_LowBounds;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x470")]
		private Vector2 m_HighBounds;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x478")]
		private float m_LastVelocityLerpTime;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x47C")]
		private bool m_StartedMoving;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x47D")]
		private bool m_TouchPointerMoveAllowed;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x47E")]
		private bool m_TouchStoppedVelocity;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x480")]
		private VisualElement m_CapturedTarget;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x488")]
		private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x490")]
		private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x498")]
		internal IVisualElementScheduledItem m_PostPointerUpAnimation;

		// Token: 0x0200013F RID: 319
		[Token(Token = "0x200013F")]
		public new class UxmlFactory : UxmlFactory<ScrollView, ScrollView.UxmlTraits>
		{
			// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600091E")]
			[Address(RVA = "0x5AD2D70", Offset = "0x5AD1970", VA = "0x185AD2D70")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x2000140")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x5AD4600", Offset = "0x5AD3200", VA = "0x185AD4600", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x5AD5780", Offset = "0x5AD4380", VA = "0x185AD5780")]
			public UxmlTraits()
			{
			}

			// Token: 0x040004FC RID: 1276
			[Token(Token = "0x40004FC")]
			[FieldOffset(Offset = "0x70")]
			private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode;

			// Token: 0x040004FD RID: 1277
			[Token(Token = "0x40004FD")]
			[FieldOffset(Offset = "0x78")]
			private UxmlEnumAttributeDescription<ScrollView.NestedInteractionKind> m_NestedInteractionKind;

			// Token: 0x040004FE RID: 1278
			[Token(Token = "0x40004FE")]
			[FieldOffset(Offset = "0x80")]
			private UxmlBoolAttributeDescription m_ShowHorizontal;

			// Token: 0x040004FF RID: 1279
			[Token(Token = "0x40004FF")]
			[FieldOffset(Offset = "0x88")]
			private UxmlBoolAttributeDescription m_ShowVertical;

			// Token: 0x04000500 RID: 1280
			[Token(Token = "0x4000500")]
			[FieldOffset(Offset = "0x90")]
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility;

			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x4000501")]
			[FieldOffset(Offset = "0x98")]
			private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility;

			// Token: 0x04000502 RID: 1282
			[Token(Token = "0x4000502")]
			[FieldOffset(Offset = "0xA0")]
			private UxmlFloatAttributeDescription m_HorizontalPageSize;

			// Token: 0x04000503 RID: 1283
			[Token(Token = "0x4000503")]
			[FieldOffset(Offset = "0xA8")]
			private UxmlFloatAttributeDescription m_VerticalPageSize;

			// Token: 0x04000504 RID: 1284
			[Token(Token = "0x4000504")]
			[FieldOffset(Offset = "0xB0")]
			private UxmlFloatAttributeDescription m_MouseWheelScrollSize;

			// Token: 0x04000505 RID: 1285
			[Token(Token = "0x4000505")]
			[FieldOffset(Offset = "0xB8")]
			private UxmlEnumAttributeDescription<ScrollView.TouchScrollBehavior> m_TouchScrollBehavior;

			// Token: 0x04000506 RID: 1286
			[Token(Token = "0x4000506")]
			[FieldOffset(Offset = "0xC0")]
			private UxmlFloatAttributeDescription m_ScrollDecelerationRate;

			// Token: 0x04000507 RID: 1287
			[Token(Token = "0x4000507")]
			[FieldOffset(Offset = "0xC8")]
			private UxmlFloatAttributeDescription m_Elasticity;

			// Token: 0x04000508 RID: 1288
			[Token(Token = "0x4000508")]
			[FieldOffset(Offset = "0xD0")]
			private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs;
		}

		// Token: 0x02000141 RID: 321
		[Token(Token = "0x2000141")]
		public enum TouchScrollBehavior
		{
			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x400050A")]
			Unrestricted,
			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			Elastic,
			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			Clamped
		}

		// Token: 0x02000142 RID: 322
		[Token(Token = "0x2000142")]
		public enum NestedInteractionKind
		{
			// Token: 0x0400050E RID: 1294
			[Token(Token = "0x400050E")]
			Default,
			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x400050F")]
			StopScrolling,
			// Token: 0x04000510 RID: 1296
			[Token(Token = "0x4000510")]
			ForwardScrolling
		}

		// Token: 0x02000143 RID: 323
		[Token(Token = "0x2000143")]
		internal enum TouchScrollingResult
		{
			// Token: 0x04000512 RID: 1298
			[Token(Token = "0x4000512")]
			Apply,
			// Token: 0x04000513 RID: 1299
			[Token(Token = "0x4000513")]
			Forward,
			// Token: 0x04000514 RID: 1300
			[Token(Token = "0x4000514")]
			Block
		}
	}
}
