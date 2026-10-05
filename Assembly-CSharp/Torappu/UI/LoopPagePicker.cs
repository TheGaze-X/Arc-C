using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200395C RID: 14684
	[Token(Token = "0x200395C")]
	public class LoopPagePicker : UIBehaviour, ITimeWatcher, IHotfixable
	{
		// Token: 0x06017344 RID: 95044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017344")]
		[Address(RVA = "0xF8C750", Offset = "0xF8B350", VA = "0x180F8C750", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x06017345 RID: 95045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017345")]
		[Address(RVA = "0xF8BE60", Offset = "0xF8AA60", VA = "0x180F8BE60")]
		public void Reset(LoopPagePicker.IDataSource source, int select = 0)
		{
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x06017346 RID: 95046 RVA: 0x000954A8 File Offset: 0x000936A8
		// (set) Token: 0x06017347 RID: 95047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700376D")]
		public int select
		{
			[Token(Token = "0x6017346")]
			[Address(RVA = "0xF8DFF0", Offset = "0xF8CBF0", VA = "0x180F8DFF0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017347")]
			[Address(RVA = "0xF8E300", Offset = "0xF8CF00", VA = "0x180F8E300")]
			set
			{
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x06017348 RID: 95048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017349 RID: 95049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700376E")]
		public LoopPagePicker.PickerSelectEvent onSelectBegin
		{
			[Token(Token = "0x6017348")]
			[Address(RVA = "0xF8DEA0", Offset = "0xF8CAA0", VA = "0x180F8DEA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6017349")]
			[Address(RVA = "0xF8E150", Offset = "0xF8CD50", VA = "0x180F8E150")]
			set
			{
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0601734A RID: 95050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601734B RID: 95051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700376F")]
		public LoopPagePicker.PickerSelectEvent onSelectChanged
		{
			[Token(Token = "0x601734A")]
			[Address(RVA = "0xF8DF10", Offset = "0xF8CB10", VA = "0x180F8DF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x601734B")]
			[Address(RVA = "0xF8E1E0", Offset = "0xF8CDE0", VA = "0x180F8E1E0")]
			set
			{
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0601734C RID: 95052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601734D RID: 95053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003770")]
		public LoopPagePicker.PickerTweenEvent onSelectTweening
		{
			[Token(Token = "0x601734C")]
			[Address(RVA = "0xF8DF80", Offset = "0xF8CB80", VA = "0x180F8DF80")]
			get
			{
				return null;
			}
			[Token(Token = "0x601734D")]
			[Address(RVA = "0xF8E270", Offset = "0xF8CE70", VA = "0x180F8E270")]
			set
			{
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0601734E RID: 95054 RVA: 0x000954C0 File Offset: 0x000936C0
		[Token(Token = "0x17003771")]
		public bool tweening
		{
			[Token(Token = "0x601734E")]
			[Address(RVA = "0xF8E0D0", Offset = "0xF8CCD0", VA = "0x180F8E0D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0601734F RID: 95055 RVA: 0x000954D8 File Offset: 0x000936D8
		// (set) Token: 0x06017350 RID: 95056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003772")]
		public int tweenFrom
		{
			[Token(Token = "0x601734F")]
			[Address(RVA = "0xF8E060", Offset = "0xF8CC60", VA = "0x180F8E060")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6017350")]
			[Address(RVA = "0xF8E400", Offset = "0xF8D000", VA = "0x180F8E400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06017351 RID: 95057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017351")]
		[Address(RVA = "0xF8BAD0", Offset = "0xF8A6D0", VA = "0x180F8BAD0")]
		public void MoveToPrePage()
		{
		}

		// Token: 0x06017352 RID: 95058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017352")]
		[Address(RVA = "0xF8BA50", Offset = "0xF8A650", VA = "0x180F8BA50")]
		public void MoveToNextPage()
		{
		}

		// Token: 0x06017353 RID: 95059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017353")]
		[Address(RVA = "0xF8D070", Offset = "0xF8BC70", VA = "0x180F8D070")]
		private void _MovePage(int move)
		{
		}

		// Token: 0x06017354 RID: 95060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017354")]
		[Address(RVA = "0xF8C7E0", Offset = "0xF8B3E0", VA = "0x180F8C7E0", Slot = "17")]
		public void UpdateTime(float deltaTime)
		{
		}

		// Token: 0x06017355 RID: 95061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017355")]
		[Address(RVA = "0xF8BBD0", Offset = "0xF8A7D0", VA = "0x180F8BBD0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06017356 RID: 95062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017356")]
		[Address(RVA = "0xF8BB50", Offset = "0xF8A750", VA = "0x180F8BB50", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06017357 RID: 95063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017357")]
		[Address(RVA = "0xF8D600", Offset = "0xF8C200", VA = "0x180F8D600")]
		private void _SetSelect(int select)
		{
		}

		// Token: 0x06017358 RID: 95064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017358")]
		[Address(RVA = "0xF8BC50", Offset = "0xF8A850", VA = "0x180F8BC50")]
		public void ReflushAll()
		{
		}

		// Token: 0x06017359 RID: 95065 RVA: 0x000954F0 File Offset: 0x000936F0
		[Token(Token = "0x6017359")]
		[Address(RVA = "0xF8CC50", Offset = "0xF8B850", VA = "0x180F8CC50")]
		private int _CalcRealDataIndex(int offset)
		{
			return 0;
		}

		// Token: 0x0601735A RID: 95066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601735A")]
		[Address(RVA = "0xF8DA00", Offset = "0xF8C600", VA = "0x180F8DA00")]
		private void _UpdateSort()
		{
		}

		// Token: 0x0601735B RID: 95067 RVA: 0x00095508 File Offset: 0x00093708
		[Token(Token = "0x601735B")]
		[Address(RVA = "0xF8CD90", Offset = "0xF8B990", VA = "0x180F8CD90")]
		private Vector2 _CalcVector2(Vector2 start, Vector2 end, float v)
		{
			return default(Vector2);
		}

		// Token: 0x0601735C RID: 95068 RVA: 0x00095520 File Offset: 0x00093720
		[Token(Token = "0x601735C")]
		[Address(RVA = "0xF8CEC0", Offset = "0xF8BAC0", VA = "0x180F8CEC0")]
		private Vector3 _CalcVector3(Vector3 start, Vector3 end, float v)
		{
			return default(Vector3);
		}

		// Token: 0x0601735D RID: 95069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601735D")]
		[Address(RVA = "0xF8DCE0", Offset = "0xF8C8E0", VA = "0x180F8DCE0")]
		public LoopPagePicker()
		{
		}

		// Token: 0x0601735F RID: 95071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601735F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_Start()
		{
		}

		// Token: 0x06017360 RID: 95072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017360")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnEnable()
		{
		}

		// Token: 0x06017361 RID: 95073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017361")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_OnDisable()
		{
		}

		// Token: 0x0401C014 RID: 114708
		[Token(Token = "0x401C014")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _baseLine;

		// Token: 0x0401C015 RID: 114709
		[Token(Token = "0x401C015")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _pageWidth;

		// Token: 0x0401C016 RID: 114710
		[Token(Token = "0x401C016")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _unselectScale;

		// Token: 0x0401C017 RID: 114711
		[Token(Token = "0x401C017")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _unselectOffset;

		// Token: 0x0401C018 RID: 114712
		[Token(Token = "0x401C018")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _tweenDur;

		// Token: 0x0401C019 RID: 114713
		[Token(Token = "0x401C019")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _loop;

		// Token: 0x0401C01A RID: 114714
		[Token(Token = "0x401C01A")]
		[HideInInspector]
		public const int BEGIN_PAGE = -2147483648;

		// Token: 0x0401C01B RID: 114715
		[Token(Token = "0x401C01B")]
		[HideInInspector]
		public const int END_PAGE = 2147483647;

		// Token: 0x0401C01C RID: 114716
		[Token(Token = "0x401C01C")]
		private const int VIEW_COUNT = 4;

		// Token: 0x0401C01D RID: 114717
		[Token(Token = "0x401C01D")]
		private const int SEAT_FRONT = 0;

		// Token: 0x0401C01E RID: 114718
		[Token(Token = "0x401C01E")]
		private const int SEAT_RIGHT = 1;

		// Token: 0x0401C01F RID: 114719
		[Token(Token = "0x401C01F")]
		private const int SEAT_BEHIND = 2;

		// Token: 0x0401C020 RID: 114720
		[Token(Token = "0x401C020")]
		private const int SEAT_LEFT = 3;

		// Token: 0x0401C021 RID: 114721
		[Token(Token = "0x401C021")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] FORWARD_MATCH;

		// Token: 0x0401C022 RID: 114722
		[Token(Token = "0x401C022")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] BACKWARD_MATCH;

		// Token: 0x0401C023 RID: 114723
		[Token(Token = "0x401C023")]
		private const float TWEEN_OFF = -1f;

		// Token: 0x0401C024 RID: 114724
		[Token(Token = "0x401C024")]
		[FieldOffset(Offset = "0x30")]
		private LoopPagePicker.PickerSelectEvent m_onSelectBegin;

		// Token: 0x0401C025 RID: 114725
		[Token(Token = "0x401C025")]
		[FieldOffset(Offset = "0x38")]
		private LoopPagePicker.PickerSelectEvent m_onSelectChanged;

		// Token: 0x0401C026 RID: 114726
		[Token(Token = "0x401C026")]
		[FieldOffset(Offset = "0x40")]
		private LoopPagePicker.PickerTweenEvent m_onSelectTweening;

		// Token: 0x0401C027 RID: 114727
		[Token(Token = "0x401C027")]
		[FieldOffset(Offset = "0x48")]
		private LoopPagePicker.IDataSource m_data;

		// Token: 0x0401C028 RID: 114728
		[Token(Token = "0x401C028")]
		[FieldOffset(Offset = "0x50")]
		private int m_select;

		// Token: 0x0401C029 RID: 114729
		[Token(Token = "0x401C029")]
		[FieldOffset(Offset = "0x58")]
		private LoopPagePicker.SeatProperty[] m_seats;

		// Token: 0x0401C02A RID: 114730
		[Token(Token = "0x401C02A")]
		[FieldOffset(Offset = "0x60")]
		private List<RectTransform> m_sorting;

		// Token: 0x0401C02B RID: 114731
		[Token(Token = "0x401C02B")]
		[FieldOffset(Offset = "0x68")]
		private float m_tweenCost;

		// Token: 0x0401C02C RID: 114732
		[Token(Token = "0x401C02C")]
		[FieldOffset(Offset = "0x6C")]
		private float m_pageWidth;

		// Token: 0x0401C02D RID: 114733
		[Token(Token = "0x401C02D")]
		[FieldOffset(Offset = "0x70")]
		private Interpolator.EasingFunction m_easeFunc;

		// Token: 0x0401C02F RID: 114735
		[Token(Token = "0x401C02F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401C030 RID: 114736
		[Token(Token = "0x401C030")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0401C031 RID: 114737
		[Token(Token = "0x401C031")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_select;

		// Token: 0x0401C032 RID: 114738
		[Token(Token = "0x401C032")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_select;

		// Token: 0x0401C033 RID: 114739
		[Token(Token = "0x401C033")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onSelectBegin;

		// Token: 0x0401C034 RID: 114740
		[Token(Token = "0x401C034")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onSelectBegin;

		// Token: 0x0401C035 RID: 114741
		[Token(Token = "0x401C035")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onSelectChanged;

		// Token: 0x0401C036 RID: 114742
		[Token(Token = "0x401C036")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onSelectChanged;

		// Token: 0x0401C037 RID: 114743
		[Token(Token = "0x401C037")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_onSelectTweening;

		// Token: 0x0401C038 RID: 114744
		[Token(Token = "0x401C038")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_onSelectTweening;

		// Token: 0x0401C039 RID: 114745
		[Token(Token = "0x401C039")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_tweening;

		// Token: 0x0401C03A RID: 114746
		[Token(Token = "0x401C03A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_tweenFrom;

		// Token: 0x0401C03B RID: 114747
		[Token(Token = "0x401C03B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_tweenFrom;

		// Token: 0x0401C03C RID: 114748
		[Token(Token = "0x401C03C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_MoveToPrePage;

		// Token: 0x0401C03D RID: 114749
		[Token(Token = "0x401C03D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_MoveToNextPage;

		// Token: 0x0401C03E RID: 114750
		[Token(Token = "0x401C03E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__MovePage;

		// Token: 0x0401C03F RID: 114751
		[Token(Token = "0x401C03F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateTime;

		// Token: 0x0401C040 RID: 114752
		[Token(Token = "0x401C040")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401C041 RID: 114753
		[Token(Token = "0x401C041")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401C042 RID: 114754
		[Token(Token = "0x401C042")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SetSelect;

		// Token: 0x0401C043 RID: 114755
		[Token(Token = "0x401C043")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ReflushAll;

		// Token: 0x0401C044 RID: 114756
		[Token(Token = "0x401C044")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CalcRealDataIndex;

		// Token: 0x0401C045 RID: 114757
		[Token(Token = "0x401C045")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateSort;

		// Token: 0x0401C046 RID: 114758
		[Token(Token = "0x401C046")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CalcVector2;

		// Token: 0x0401C047 RID: 114759
		[Token(Token = "0x401C047")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__CalcVector3;

		// Token: 0x0401C048 RID: 114760
		[Token(Token = "0x401C048")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200395D RID: 14685
		[Token(Token = "0x200395D")]
		public interface IPageView
		{
			// Token: 0x17003773 RID: 14195
			// (get) Token: 0x06017362 RID: 95074
			// (set) Token: 0x06017363 RID: 95075
			[Token(Token = "0x17003773")]
			float fade { [Token(Token = "0x6017362")] get; [Token(Token = "0x6017363")] set; }

			// Token: 0x17003774 RID: 14196
			// (get) Token: 0x06017364 RID: 95076
			[Token(Token = "0x17003774")]
			RectTransform rectTransform { [Token(Token = "0x6017364")] get; }

			// Token: 0x17003775 RID: 14197
			// (get) Token: 0x06017365 RID: 95077
			[Token(Token = "0x17003775")]
			GameObject gameObject { [Token(Token = "0x6017365")] get; }
		}

		// Token: 0x0200395E RID: 14686
		[Token(Token = "0x200395E")]
		public interface IDataSource
		{
			// Token: 0x17003776 RID: 14198
			// (get) Token: 0x06017366 RID: 95078
			[Token(Token = "0x17003776")]
			int pageCount { [Token(Token = "0x6017366")] get; }

			// Token: 0x06017367 RID: 95079
			[Token(Token = "0x6017367")]
			void FlushData(LoopPagePicker.IPageView page, int pageIdx);

			// Token: 0x06017368 RID: 95080
			[Token(Token = "0x6017368")]
			LoopPagePicker.IPageView CreatePage(Transform root);
		}

		// Token: 0x0200395F RID: 14687
		[Token(Token = "0x200395F")]
		private struct ViewProperty
		{
			// Token: 0x0401C049 RID: 114761
			[Token(Token = "0x401C049")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401C04A RID: 114762
			[Token(Token = "0x401C04A")]
			[FieldOffset(Offset = "0x8")]
			public float fade;

			// Token: 0x0401C04B RID: 114763
			[Token(Token = "0x401C04B")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 scale;
		}

		// Token: 0x02003960 RID: 14688
		[Token(Token = "0x2003960")]
		private class SeatProperty
		{
			// Token: 0x06017369 RID: 95081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017369")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SeatProperty()
			{
			}

			// Token: 0x0401C04C RID: 114764
			[Token(Token = "0x401C04C")]
			[FieldOffset(Offset = "0x10")]
			public LoopPagePicker.ViewProperty target;

			// Token: 0x0401C04D RID: 114765
			[Token(Token = "0x401C04D")]
			[FieldOffset(Offset = "0x28")]
			public LoopPagePicker.IPageView view;

			// Token: 0x0401C04E RID: 114766
			[Token(Token = "0x401C04E")]
			[FieldOffset(Offset = "0x30")]
			public LoopPagePicker.ViewProperty tweenFrom;

			// Token: 0x0401C04F RID: 114767
			[Token(Token = "0x401C04F")]
			[FieldOffset(Offset = "0x48")]
			public float dur;
		}

		// Token: 0x02003961 RID: 14689
		[Token(Token = "0x2003961")]
		public class PickerSelectEvent : UnityEvent<int>
		{
			// Token: 0x0601736A RID: 95082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601736A")]
			[Address(RVA = "0xF8F600", Offset = "0xF8E200", VA = "0x180F8F600")]
			public PickerSelectEvent()
			{
			}
		}

		// Token: 0x02003962 RID: 14690
		[Token(Token = "0x2003962")]
		public class PickerTweenEvent : UnityEvent<float>
		{
			// Token: 0x0601736B RID: 95083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601736B")]
			[Address(RVA = "0xF8F640", Offset = "0xF8E240", VA = "0x180F8F640")]
			public PickerTweenEvent()
			{
			}
		}
	}
}
