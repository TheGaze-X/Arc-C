using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003940 RID: 14656
	[Token(Token = "0x2003940")]
	[RequireComponent(typeof(UIWrappedScrollRect))]
	public class InertiaScrollViewPager : MonoBehaviour, ITimeWatcher, IHotfixable, IWheelListener
	{
		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x060172A3 RID: 94883 RVA: 0x00095118 File Offset: 0x00093318
		[Token(Token = "0x1700375B")]
		[Inspect]
		private bool _enableDrag
		{
			[Token(Token = "0x60172A3")]
			[Address(RVA = "0xF87DB0", Offset = "0xF869B0", VA = "0x180F87DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060172A4 RID: 94884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172A4")]
		[Address(RVA = "0xF87380", Offset = "0xF85F80", VA = "0x180F87380")]
		private void _InitIfNot()
		{
		}

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x060172A5 RID: 94885 RVA: 0x00095130 File Offset: 0x00093330
		[Token(Token = "0x1700375C")]
		public bool isUpdating
		{
			[Token(Token = "0x60172A5")]
			[Address(RVA = "0xF87F00", Offset = "0xF86B00", VA = "0x180F87F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x060172A6 RID: 94886 RVA: 0x00095148 File Offset: 0x00093348
		// (set) Token: 0x060172A7 RID: 94887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700375D")]
		public int pageCount
		{
			[Token(Token = "0x60172A6")]
			[Address(RVA = "0xF87F60", Offset = "0xF86B60", VA = "0x180F87F60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60172A7")]
			[Address(RVA = "0xF88040", Offset = "0xF86C40", VA = "0x180F88040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060172A8 RID: 94888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172A8")]
		[Address(RVA = "0xF86930", Offset = "0xF85530", VA = "0x180F86930")]
		public void SetPageCount(int pageCount, [Optional] IList<int> segmentFrames)
		{
		}

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x060172A9 RID: 94889 RVA: 0x00095160 File Offset: 0x00093360
		// (set) Token: 0x060172AA RID: 94890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700375E")]
		public int currentPage
		{
			[Token(Token = "0x60172A9")]
			[Address(RVA = "0xF87E10", Offset = "0xF86A10", VA = "0x180F87E10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60172AA")]
			[Address(RVA = "0xF87FC0", Offset = "0xF86BC0", VA = "0x180F87FC0")]
			set
			{
			}
		}

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x060172AB RID: 94891 RVA: 0x00095178 File Offset: 0x00093378
		[Token(Token = "0x1700375F")]
		public float currentScrollIndex
		{
			[Token(Token = "0x60172AB")]
			[Address(RVA = "0xF87E70", Offset = "0xF86A70", VA = "0x180F87E70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060172AC RID: 94892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172AC")]
		[Address(RVA = "0xF86B60", Offset = "0xF85760", VA = "0x180F86B60")]
		public void SetScrollOptions(InertiaScrollViewPager.ScrollOptions options)
		{
		}

		// Token: 0x060172AD RID: 94893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172AD")]
		[Address(RVA = "0xF86A20", Offset = "0xF85620", VA = "0x180F86A20")]
		public void SetScrollEffect(ViewPagerUtils.ScrollEffectConfig config)
		{
		}

		// Token: 0x060172AE RID: 94894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172AE")]
		[Address(RVA = "0xF86C80", Offset = "0xF85880", VA = "0x180F86C80", Slot = "4")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x060172AF RID: 94895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172AF")]
		[Address(RVA = "0xF86740", Offset = "0xF85340", VA = "0x180F86740")]
		public void MoveToPage(int pageIndex)
		{
		}

		// Token: 0x060172B0 RID: 94896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B0")]
		[Address(RVA = "0xF86590", Offset = "0xF85190", VA = "0x180F86590")]
		private void Awake()
		{
		}

		// Token: 0x060172B1 RID: 94897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B1")]
		[Address(RVA = "0xF86840", Offset = "0xF85440", VA = "0x180F86840")]
		private void OnEnable()
		{
		}

		// Token: 0x060172B2 RID: 94898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B2")]
		[Address(RVA = "0xF867E0", Offset = "0xF853E0", VA = "0x180F867E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060172B3 RID: 94899 RVA: 0x00095190 File Offset: 0x00093390
		[Token(Token = "0x60172B3")]
		[Address(RVA = "0xF866E0", Offset = "0xF852E0", VA = "0x180F866E0")]
		public static bool IsScrollStableState(InertiaScrollViewPager.State state)
		{
			return default(bool);
		}

		// Token: 0x060172B4 RID: 94900 RVA: 0x000951A8 File Offset: 0x000933A8
		[Token(Token = "0x60172B4")]
		[Address(RVA = "0xF87720", Offset = "0xF86320", VA = "0x180F87720")]
		private float _ScrollValue2PageIndex(float value)
		{
			return 0f;
		}

		// Token: 0x060172B5 RID: 94901 RVA: 0x000951C0 File Offset: 0x000933C0
		[Token(Token = "0x60172B5")]
		[Address(RVA = "0xF875F0", Offset = "0xF861F0", VA = "0x180F875F0")]
		private float _PageIndex2ScrollValue(float index)
		{
			return 0f;
		}

		// Token: 0x060172B6 RID: 94902 RVA: 0x000951D8 File Offset: 0x000933D8
		[Token(Token = "0x60172B6")]
		[Address(RVA = "0xF87860", Offset = "0xF86460", VA = "0x180F87860")]
		private int _ScrollValueAlignToPage(float value)
		{
			return 0;
		}

		// Token: 0x060172B7 RID: 94903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B7")]
		[Address(RVA = "0xF87990", Offset = "0xF86590", VA = "0x180F87990")]
		private void _SwitchToPage(int targetIndex, bool useTween)
		{
		}

		// Token: 0x060172B8 RID: 94904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B8")]
		[Address(RVA = "0xF872E0", Offset = "0xF85EE0", VA = "0x180F872E0")]
		[Inspect(InspectorLevel.Debug)]
		private void _AutoAlign()
		{
		}

		// Token: 0x060172B9 RID: 94905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172B9")]
		[Address(RVA = "0xF874D0", Offset = "0xF860D0", VA = "0x180F874D0")]
		private void _OnStateChanged(InertiaScrollViewPager.State from, InertiaScrollViewPager.State to)
		{
		}

		// Token: 0x060172BA RID: 94906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172BA")]
		[Address(RVA = "0xF868C0", Offset = "0xF854C0", VA = "0x180F868C0")]
		private void OnScroll(Vector2 delta)
		{
		}

		// Token: 0x060172BB RID: 94907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172BB")]
		[Address(RVA = "0xF865F0", Offset = "0xF851F0", VA = "0x180F865F0")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x060172BC RID: 94908 RVA: 0x000951F0 File Offset: 0x000933F0
		[Token(Token = "0x60172BC")]
		[Address(RVA = "0xF86680", Offset = "0xF85280", VA = "0x180F86680", Slot = "5")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x060172BD RID: 94909 RVA: 0x00095208 File Offset: 0x00093408
		[Token(Token = "0x60172BD")]
		[Address(RVA = "0xF86BF0", Offset = "0xF857F0", VA = "0x180F86BF0", Slot = "6")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x060172BE RID: 94910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60172BE")]
		[Address(RVA = "0xF87B90", Offset = "0xF86790", VA = "0x180F87B90")]
		public InertiaScrollViewPager()
		{
		}

		// Token: 0x0401BF4E RID: 114510
		[Token(Token = "0x401BF4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x0401BF4F RID: 114511
		[Token(Token = "0x401BF4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(0f, 2f)]
		[Toolbar("Animation duration for page switch and rollback")]
		private float _animationDuration;

		// Token: 0x0401BF50 RID: 114512
		[Token(Token = "0x401BF50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Tooltip("When the scrolling speed is slower than this value, treat it as stopped")]
		private float _endScrollSpd;

		// Token: 0x0401BF51 RID: 114513
		[Token(Token = "0x401BF51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private bool m_enableDrag;

		// Token: 0x0401BF52 RID: 114514
		[Token(Token = "0x401BF52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_currentPage;

		// Token: 0x0401BF53 RID: 114515
		[Token(Token = "0x401BF53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private InertiaScrollViewPager.State m_state;

		// Token: 0x0401BF54 RID: 114516
		[Token(Token = "0x401BF54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InertiaScrollViewPager.IScrollHandler m_scrollHandler;

		// Token: 0x0401BF55 RID: 114517
		[Token(Token = "0x401BF55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ViewPagerUtils.ScrollEffectTrigger m_effectTrigger;

		// Token: 0x0401BF56 RID: 114518
		[Token(Token = "0x401BF56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InertiaScrollViewPager.BlockerManager m_blockers;

		// Token: 0x0401BF57 RID: 114519
		[Token(Token = "0x401BF57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InertiaScrollViewPager.DragContext m_dragContext;

		// Token: 0x0401BF58 RID: 114520
		[Token(Token = "0x401BF58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InertiaScrollViewPager.ScrollOptions m_scrollOptions;

		// Token: 0x0401BF59 RID: 114521
		[Token(Token = "0x401BF59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ScrollWheelHandler m_wheelHandler;

		// Token: 0x0401BF5A RID: 114522
		[Token(Token = "0x401BF5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_fromPage;

		// Token: 0x0401BF5B RID: 114523
		[Token(Token = "0x401BF5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_toPage;

		// Token: 0x0401BF5C RID: 114524
		[Token(Token = "0x401BF5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_tweenStartTime;

		// Token: 0x0401BF5D RID: 114525
		[Token(Token = "0x401BF5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_tweenStartValue;

		// Token: 0x0401BF5E RID: 114526
		[Token(Token = "0x401BF5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_tweenTargetValue;

		// Token: 0x0401BF5F RID: 114527
		[Token(Token = "0x401BF5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool m_isInited;

		// Token: 0x0401BF61 RID: 114529
		[Token(Token = "0x401BF61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get__enableDrag;

		// Token: 0x0401BF62 RID: 114530
		[Token(Token = "0x401BF62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401BF63 RID: 114531
		[Token(Token = "0x401BF63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isUpdating;

		// Token: 0x0401BF64 RID: 114532
		[Token(Token = "0x401BF64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_pageCount;

		// Token: 0x0401BF65 RID: 114533
		[Token(Token = "0x401BF65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_pageCount;

		// Token: 0x0401BF66 RID: 114534
		[Token(Token = "0x401BF66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetPageCount;

		// Token: 0x0401BF67 RID: 114535
		[Token(Token = "0x401BF67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_currentPage;

		// Token: 0x0401BF68 RID: 114536
		[Token(Token = "0x401BF68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_currentPage;

		// Token: 0x0401BF69 RID: 114537
		[Token(Token = "0x401BF69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_currentScrollIndex;

		// Token: 0x0401BF6A RID: 114538
		[Token(Token = "0x401BF6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetScrollOptions;

		// Token: 0x0401BF6B RID: 114539
		[Token(Token = "0x401BF6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetScrollEffect;

		// Token: 0x0401BF6C RID: 114540
		[Token(Token = "0x401BF6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401BF6D RID: 114541
		[Token(Token = "0x401BF6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_MoveToPage;

		// Token: 0x0401BF6E RID: 114542
		[Token(Token = "0x401BF6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401BF6F RID: 114543
		[Token(Token = "0x401BF6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401BF70 RID: 114544
		[Token(Token = "0x401BF70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401BF71 RID: 114545
		[Token(Token = "0x401BF71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsScrollStableState;

		// Token: 0x0401BF72 RID: 114546
		[Token(Token = "0x401BF72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ScrollValue2PageIndex;

		// Token: 0x0401BF73 RID: 114547
		[Token(Token = "0x401BF73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PageIndex2ScrollValue;

		// Token: 0x0401BF74 RID: 114548
		[Token(Token = "0x401BF74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ScrollValueAlignToPage;

		// Token: 0x0401BF75 RID: 114549
		[Token(Token = "0x401BF75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SwitchToPage;

		// Token: 0x0401BF76 RID: 114550
		[Token(Token = "0x401BF76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AutoAlign;

		// Token: 0x0401BF77 RID: 114551
		[Token(Token = "0x401BF77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x0401BF78 RID: 114552
		[Token(Token = "0x401BF78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnScroll;

		// Token: 0x0401BF79 RID: 114553
		[Token(Token = "0x401BF79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0401BF7A RID: 114554
		[Token(Token = "0x401BF7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0401BF7B RID: 114555
		[Token(Token = "0x401BF7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0401BF7C RID: 114556
		[Token(Token = "0x401BF7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003941 RID: 14657
		[Token(Token = "0x2003941")]
		public enum State
		{
			// Token: 0x0401BF7E RID: 114558
			[Token(Token = "0x401BF7E")]
			IDLE,
			// Token: 0x0401BF7F RID: 114559
			[Token(Token = "0x401BF7F")]
			DRAGING,
			// Token: 0x0401BF80 RID: 114560
			[Token(Token = "0x401BF80")]
			INERTIA,
			// Token: 0x0401BF81 RID: 114561
			[Token(Token = "0x401BF81")]
			ALIGNING
		}

		// Token: 0x02003942 RID: 14658
		[Token(Token = "0x2003942")]
		private interface IScrollHandler : IHotfixable
		{
			// Token: 0x17003760 RID: 14176
			// (get) Token: 0x060172BF RID: 94911
			[Token(Token = "0x17003760")]
			float velocity { [Token(Token = "0x60172BF")] get; }

			// Token: 0x17003761 RID: 14177
			// (get) Token: 0x060172C0 RID: 94912
			[Token(Token = "0x17003761")]
			bool isDragging { [Token(Token = "0x60172C0")] get; }

			// Token: 0x17003762 RID: 14178
			// (get) Token: 0x060172C1 RID: 94913
			// (set) Token: 0x060172C2 RID: 94914
			[Token(Token = "0x17003762")]
			float scrollProgress { [Token(Token = "0x60172C1")] get; [Token(Token = "0x60172C2")] set; }

			// Token: 0x060172C3 RID: 94915
			[Token(Token = "0x60172C3")]
			void StopMoving();
		}

		// Token: 0x02003943 RID: 14659
		[Token(Token = "0x2003943")]
		private struct CustomScrollHandler : InertiaScrollViewPager.IScrollHandler, IHotfixable
		{
			// Token: 0x060172C4 RID: 94916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172C4")]
			[Address(RVA = "0xF84AD0", Offset = "0xF836D0", VA = "0x180F84AD0")]
			public CustomScrollHandler(UIWrappedScrollRect scrollRect)
			{
			}

			// Token: 0x17003763 RID: 14179
			// (get) Token: 0x060172C5 RID: 94917 RVA: 0x00095220 File Offset: 0x00093420
			[Token(Token = "0x17003763")]
			public float velocity
			{
				[Token(Token = "0x60172C5")]
				[Address(RVA = "0xF84D90", Offset = "0xF83990", VA = "0x180F84D90", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17003764 RID: 14180
			// (get) Token: 0x060172C6 RID: 94918 RVA: 0x00095238 File Offset: 0x00093438
			// (set) Token: 0x060172C7 RID: 94919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003764")]
			public float scrollProgress
			{
				[Token(Token = "0x60172C6")]
				[Address(RVA = "0xF84C80", Offset = "0xF83880", VA = "0x180F84C80", Slot = "6")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60172C7")]
				[Address(RVA = "0xF84EC0", Offset = "0xF83AC0", VA = "0x180F84EC0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x17003765 RID: 14181
			// (get) Token: 0x060172C8 RID: 94920 RVA: 0x00095250 File Offset: 0x00093450
			[Token(Token = "0x17003765")]
			public bool isDragging
			{
				[Token(Token = "0x60172C8")]
				[Address(RVA = "0xF84BA0", Offset = "0xF837A0", VA = "0x180F84BA0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060172C9 RID: 94921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172C9")]
			[Address(RVA = "0xF84900", Offset = "0xF83500", VA = "0x180F84900")]
			public void AddVelocity(Vector2 velocity)
			{
			}

			// Token: 0x060172CA RID: 94922 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172CA")]
			[Address(RVA = "0xF84A20", Offset = "0xF83620", VA = "0x180F84A20", Slot = "8")]
			public void StopMoving()
			{
			}

			// Token: 0x0401BF82 RID: 114562
			[Token(Token = "0x401BF82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UIWrappedScrollRect m_scrollRect;

			// Token: 0x0401BF83 RID: 114563
			[Token(Token = "0x401BF83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BF84 RID: 114564
			[Token(Token = "0x401BF84")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_velocity;

			// Token: 0x0401BF85 RID: 114565
			[Token(Token = "0x401BF85")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_scrollProgress;

			// Token: 0x0401BF86 RID: 114566
			[Token(Token = "0x401BF86")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_scrollProgress;

			// Token: 0x0401BF87 RID: 114567
			[Token(Token = "0x401BF87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_isDragging;

			// Token: 0x0401BF88 RID: 114568
			[Token(Token = "0x401BF88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AddVelocity;

			// Token: 0x0401BF89 RID: 114569
			[Token(Token = "0x401BF89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_StopMoving;
		}

		// Token: 0x02003944 RID: 14660
		[Token(Token = "0x2003944")]
		private struct EmptyScrollHandler : InertiaScrollViewPager.IScrollHandler, IHotfixable
		{
			// Token: 0x17003766 RID: 14182
			// (get) Token: 0x060172CB RID: 94923 RVA: 0x00095268 File Offset: 0x00093468
			[Token(Token = "0x17003766")]
			public float velocity
			{
				[Token(Token = "0x60172CB")]
				[Address(RVA = "0xF85610", Offset = "0xF84210", VA = "0x180F85610", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17003767 RID: 14183
			// (get) Token: 0x060172CC RID: 94924 RVA: 0x00095280 File Offset: 0x00093480
			[Token(Token = "0x17003767")]
			public bool isDragging
			{
				[Token(Token = "0x60172CC")]
				[Address(RVA = "0xF854B0", Offset = "0xF840B0", VA = "0x180F854B0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17003768 RID: 14184
			// (get) Token: 0x060172CD RID: 94925 RVA: 0x00095298 File Offset: 0x00093498
			// (set) Token: 0x060172CE RID: 94926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003768")]
			public float scrollProgress
			{
				[Token(Token = "0x60172CD")]
				[Address(RVA = "0xF85560", Offset = "0xF84160", VA = "0x180F85560", Slot = "6")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60172CE")]
				[Address(RVA = "0xF856C0", Offset = "0xF842C0", VA = "0x180F856C0", Slot = "7")]
				set
				{
				}
			}

			// Token: 0x060172CF RID: 94927 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172CF")]
			[Address(RVA = "0xF85360", Offset = "0xF83F60", VA = "0x180F85360")]
			public void AddVelocity(Vector2 velocity)
			{
			}

			// Token: 0x060172D0 RID: 94928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172D0")]
			[Address(RVA = "0xF85420", Offset = "0xF84020", VA = "0x180F85420", Slot = "8")]
			public void StopMoving()
			{
			}

			// Token: 0x0401BF8A RID: 114570
			[Token(Token = "0x401BF8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_velocity;

			// Token: 0x0401BF8B RID: 114571
			[Token(Token = "0x401BF8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isDragging;

			// Token: 0x0401BF8C RID: 114572
			[Token(Token = "0x401BF8C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_scrollProgress;

			// Token: 0x0401BF8D RID: 114573
			[Token(Token = "0x401BF8D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_scrollProgress;

			// Token: 0x0401BF8E RID: 114574
			[Token(Token = "0x401BF8E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddVelocity;

			// Token: 0x0401BF8F RID: 114575
			[Token(Token = "0x401BF8F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_StopMoving;
		}

		// Token: 0x02003945 RID: 14661
		[Token(Token = "0x2003945")]
		public struct FlingToNext
		{
			// Token: 0x0401BF90 RID: 114576
			[Token(Token = "0x401BF90")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enable;

			// Token: 0x0401BF91 RID: 114577
			[Token(Token = "0x401BF91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float minSpd;

			// Token: 0x0401BF92 RID: 114578
			[Token(Token = "0x401BF92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float maxSpd;
		}

		// Token: 0x02003946 RID: 14662
		[Token(Token = "0x2003946")]
		public struct ScrollOptions
		{
			// Token: 0x0401BF93 RID: 114579
			[Token(Token = "0x401BF93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<InertiaScrollViewPager.State> onStateChanged;

			// Token: 0x0401BF94 RID: 114580
			[Token(Token = "0x401BF94")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public InertiaScrollViewPager.FlingToNext flingToNext;
		}

		// Token: 0x02003947 RID: 14663
		[Token(Token = "0x2003947")]
		private class DragContext
		{
			// Token: 0x060172D1 RID: 94929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172D1")]
			[Address(RVA = "0xF85000", Offset = "0xF83C00", VA = "0x180F85000")]
			public void BeginDrag(InertiaScrollViewPager pager)
			{
			}

			// Token: 0x060172D2 RID: 94930 RVA: 0x000952B0 File Offset: 0x000934B0
			[Token(Token = "0x60172D2")]
			[Address(RVA = "0xF85070", Offset = "0xF83C70", VA = "0x180F85070")]
			public InertiaScrollViewPager.State EndDrag(InertiaScrollViewPager pager)
			{
				return InertiaScrollViewPager.State.IDLE;
			}

			// Token: 0x060172D3 RID: 94931 RVA: 0x000952C8 File Offset: 0x000934C8
			[Token(Token = "0x60172D3")]
			[Address(RVA = "0xF851F0", Offset = "0xF83DF0", VA = "0x180F851F0")]
			private bool _TryFlingToNext(InertiaScrollViewPager pager)
			{
				return default(bool);
			}

			// Token: 0x060172D4 RID: 94932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172D4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DragContext()
			{
			}

			// Token: 0x0401BF95 RID: 114581
			[Token(Token = "0x401BF95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float startPos;
		}

		// Token: 0x02003948 RID: 14664
		[Token(Token = "0x2003948")]
		private enum BlockerDir
		{
			// Token: 0x0401BF97 RID: 114583
			[Token(Token = "0x401BF97")]
			UPWARD,
			// Token: 0x0401BF98 RID: 114584
			[Token(Token = "0x401BF98")]
			DOWNNWARD,
			// Token: 0x0401BF99 RID: 114585
			[Token(Token = "0x401BF99")]
			BOTH
		}

		// Token: 0x02003949 RID: 14665
		[Token(Token = "0x2003949")]
		private struct InertiaBlocker : IHotfixable
		{
			// Token: 0x060172D5 RID: 94933 RVA: 0x000952E0 File Offset: 0x000934E0
			[Token(Token = "0x60172D5")]
			[Address(RVA = "0xF86450", Offset = "0xF85050", VA = "0x180F86450")]
			public bool IsDirMatch(float vec)
			{
				return default(bool);
			}

			// Token: 0x0401BF9A RID: 114586
			[Token(Token = "0x401BF9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public InertiaScrollViewPager.BlockerDir dir;

			// Token: 0x0401BF9B RID: 114587
			[Token(Token = "0x401BF9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int index;

			// Token: 0x0401BF9C RID: 114588
			[Token(Token = "0x401BF9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsDirMatch;
		}

		// Token: 0x0200394A RID: 14666
		[Token(Token = "0x200394A")]
		private class BlockerManager : IHotfixable
		{
			// Token: 0x17003769 RID: 14185
			// (get) Token: 0x060172D6 RID: 94934 RVA: 0x000952F8 File Offset: 0x000934F8
			// (set) Token: 0x060172D7 RID: 94935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003769")]
			public bool isInertiaing
			{
				[Token(Token = "0x60172D6")]
				[Address(RVA = "0xF83DE0", Offset = "0xF829E0", VA = "0x180F83DE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60172D7")]
				[Address(RVA = "0xF83E40", Offset = "0xF82A40", VA = "0x180F83E40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060172D8 RID: 94936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172D8")]
			[Address(RVA = "0xF83990", Offset = "0xF82590", VA = "0x180F83990")]
			public void Init(int pageCount, IList<int> blockFrames)
			{
			}

			// Token: 0x060172D9 RID: 94937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172D9")]
			[Address(RVA = "0xF83C70", Offset = "0xF82870", VA = "0x180F83C70")]
			public void StartInertia(float fromIndex)
			{
			}

			// Token: 0x060172DA RID: 94938 RVA: 0x00095310 File Offset: 0x00093510
			[Token(Token = "0x60172DA")]
			[Address(RVA = "0xF83710", Offset = "0xF82310", VA = "0x180F83710")]
			public bool HitInertiaBlock(float curIndex, out float preferTo)
			{
				return default(bool);
			}

			// Token: 0x060172DB RID: 94939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60172DB")]
			[Address(RVA = "0xF83D30", Offset = "0xF82930", VA = "0x180F83D30")]
			public BlockerManager()
			{
			}

			// Token: 0x0401BF9D RID: 114589
			[Token(Token = "0x401BF9D")]
			private const float INERTIA_BIAS = 0.49f;

			// Token: 0x0401BF9E RID: 114590
			[Token(Token = "0x401BF9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<InertiaScrollViewPager.InertiaBlocker> m_inertiaBlockers;

			// Token: 0x0401BF9F RID: 114591
			[Token(Token = "0x401BF9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_lastIndex;

			// Token: 0x0401BFA1 RID: 114593
			[Token(Token = "0x401BFA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isInertiaing;

			// Token: 0x0401BFA2 RID: 114594
			[Token(Token = "0x401BFA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isInertiaing;

			// Token: 0x0401BFA3 RID: 114595
			[Token(Token = "0x401BFA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0401BFA4 RID: 114596
			[Token(Token = "0x401BFA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_StartInertia;

			// Token: 0x0401BFA5 RID: 114597
			[Token(Token = "0x401BFA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HitInertiaBlock;

			// Token: 0x0401BFA6 RID: 114598
			[Token(Token = "0x401BFA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
