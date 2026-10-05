using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038F8 RID: 14584
	[Token(Token = "0x20038F8")]
	public abstract class UIRecycleLayoutGroup : MonoBehaviour, ILayoutElement, IHotfixable
	{
		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x060170D1 RID: 94417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003702")]
		protected Dictionary<int, UIRecycleLayoutGroup.LayoutMeta> layoutMetaMap
		{
			[Token(Token = "0x60170D1")]
			[Address(RVA = "0xF7C040", Offset = "0xF7AC40", VA = "0x180F7C040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x060170D2 RID: 94418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003703")]
		protected UIRecycleLayoutAdapter adapter
		{
			[Token(Token = "0x60170D2")]
			[Address(RVA = "0xF7BDF0", Offset = "0xF7A9F0", VA = "0x180F7BDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x060170D3 RID: 94419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003704")]
		protected UIRecycleLayoutGroup.ViewMgr viewMgr
		{
			[Token(Token = "0x60170D3")]
			[Address(RVA = "0xF7C3F0", Offset = "0xF7AFF0", VA = "0x180F7C3F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x060170D4 RID: 94420 RVA: 0x00094938 File Offset: 0x00092B38
		// (set) Token: 0x060170D5 RID: 94421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003705")]
		protected float sizeOnAxis
		{
			[Token(Token = "0x60170D4")]
			[Address(RVA = "0xF7C330", Offset = "0xF7AF30", VA = "0x180F7C330")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60170D5")]
			[Address(RVA = "0xF7C770", Offset = "0xF7B370", VA = "0x180F7C770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x060170D6 RID: 94422 RVA: 0x00094950 File Offset: 0x00092B50
		[Token(Token = "0x17003706")]
		protected float spacing
		{
			[Token(Token = "0x60170D6")]
			[Address(RVA = "0xF7C390", Offset = "0xF7AF90", VA = "0x180F7C390")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x060170D7 RID: 94423 RVA: 0x00094968 File Offset: 0x00092B68
		[Token(Token = "0x17003707")]
		protected UIRecycleLayoutGroup.Padding padding
		{
			[Token(Token = "0x60170D7")]
			[Address(RVA = "0xF7C270", Offset = "0xF7AE70", VA = "0x180F7C270")]
			get
			{
				return default(UIRecycleLayoutGroup.Padding);
			}
		}

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x060170D8 RID: 94424 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060170D9 RID: 94425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003708")]
		public Action onLayoutUpdated
		{
			[Token(Token = "0x60170D8")]
			[Address(RVA = "0xF7C210", Offset = "0xF7AE10", VA = "0x180F7C210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60170D9")]
			[Address(RVA = "0xF7C6F0", Offset = "0xF7B2F0", VA = "0x180F7C6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x060170DA RID: 94426 RVA: 0x00094980 File Offset: 0x00092B80
		[Token(Token = "0x17003709")]
		public float minWidth
		{
			[Token(Token = "0x60170DA")]
			[Address(RVA = "0xF7C1B0", Offset = "0xF7ADB0", VA = "0x180F7C1B0", Slot = "6")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x060170DB RID: 94427 RVA: 0x00094998 File Offset: 0x00092B98
		[Token(Token = "0x1700370A")]
		public float minHeight
		{
			[Token(Token = "0x60170DB")]
			[Address(RVA = "0xF7C150", Offset = "0xF7AD50", VA = "0x180F7C150", Slot = "9")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x060170DC RID: 94428 RVA: 0x000949B0 File Offset: 0x00092BB0
		[Token(Token = "0x1700370B")]
		public float flexibleWidth
		{
			[Token(Token = "0x60170DC")]
			[Address(RVA = "0xF7BFE0", Offset = "0xF7ABE0", VA = "0x180F7BFE0", Slot = "8")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x060170DD RID: 94429 RVA: 0x000949C8 File Offset: 0x00092BC8
		[Token(Token = "0x1700370C")]
		public float flexibleHeight
		{
			[Token(Token = "0x60170DD")]
			[Address(RVA = "0xF7BF80", Offset = "0xF7AB80", VA = "0x180F7BF80", Slot = "11")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x060170DE RID: 94430 RVA: 0x000949E0 File Offset: 0x00092BE0
		[Token(Token = "0x1700370D")]
		public int layoutPriority
		{
			[Token(Token = "0x60170DE")]
			[Address(RVA = "0xF7C0F0", Offset = "0xF7ACF0", VA = "0x180F7C0F0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060170DF RID: 94431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170DF")]
		[Address(RVA = "0xF7A420", Offset = "0xF79020", VA = "0x180F7A420", Slot = "4")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060170E0 RID: 94432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170E0")]
		[Address(RVA = "0xF7A480", Offset = "0xF79080", VA = "0x180F7A480", Slot = "5")]
		public void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x060170E1 RID: 94433
		[Token(Token = "0x1700370E")]
		public abstract float preferredWidth { [Token(Token = "0x60170E1")] get; }

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x060170E2 RID: 94434
		[Token(Token = "0x1700370F")]
		public abstract float preferredHeight { [Token(Token = "0x60170E2")] get; }

		// Token: 0x060170E3 RID: 94435
		[Token(Token = "0x60170E3")]
		protected abstract void ApplyLayoutMeta(UIRecycleLayoutAdapter.IVirtualView view, UIRecycleLayoutGroup.LayoutMeta meta);

		// Token: 0x060170E4 RID: 94436
		[Token(Token = "0x60170E4")]
		protected abstract Vector2 GetVisibleRange(Bounds viewBound);

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x060170E5 RID: 94437
		[Token(Token = "0x17003710")]
		protected abstract float paddingFront { [Token(Token = "0x60170E5")] get; }

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x060170E6 RID: 94438
		[Token(Token = "0x17003711")]
		protected abstract float paddingBack { [Token(Token = "0x60170E6")] get; }

		// Token: 0x060170E7 RID: 94439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60170E7")]
		[Address(RVA = "0xF7AAC0", Offset = "0xF796C0", VA = "0x180F7AAC0")]
		public UIRecycleLayoutAdapter SetAdapter(UIRecycleLayoutAdapter adapter)
		{
			return null;
		}

		// Token: 0x060170E8 RID: 94440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170E8")]
		[Address(RVA = "0xF7A4E0", Offset = "0xF790E0", VA = "0x180F7A4E0", Slot = "19")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x060170E9 RID: 94441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170E9")]
		[Address(RVA = "0xF7B770", Offset = "0xF7A370", VA = "0x180F7B770")]
		private void _RebuildAllViews()
		{
		}

		// Token: 0x060170EA RID: 94442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170EA")]
		[Address(RVA = "0xF7AC20", Offset = "0xF79820", VA = "0x180F7AC20", Slot = "20")]
		protected virtual void UpdateViews(int fromIndex)
		{
		}

		// Token: 0x060170EB RID: 94443 RVA: 0x000949F8 File Offset: 0x00092BF8
		[Token(Token = "0x60170EB")]
		[Address(RVA = "0xF7B500", Offset = "0xF7A100", VA = "0x180F7B500")]
		private bool _InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view)
		{
			return default(bool);
		}

		// Token: 0x060170EC RID: 94444 RVA: 0x00094A10 File Offset: 0x00092C10
		[Token(Token = "0x60170EC")]
		[Address(RVA = "0xF7B9E0", Offset = "0xF7A5E0", VA = "0x180F7B9E0")]
		private bool _RemoveView(UIRecycleLayoutAdapter.IVirtualView view)
		{
			return default(bool);
		}

		// Token: 0x060170ED RID: 94445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170ED")]
		[Address(RVA = "0xF7BC20", Offset = "0xF7A820", VA = "0x180F7BC20")]
		private void _UpdateViewsFrom(UIRecycleLayoutAdapter.IVirtualView view)
		{
		}

		// Token: 0x060170EE RID: 94446 RVA: 0x00094A28 File Offset: 0x00092C28
		[Token(Token = "0x60170EE")]
		[Address(RVA = "0xF7B3F0", Offset = "0xF79FF0", VA = "0x180F7B3F0")]
		private float _GetElementPosByIndex(int index)
		{
			return 0f;
		}

		// Token: 0x060170EF RID: 94447 RVA: 0x00094A40 File Offset: 0x00092C40
		[Token(Token = "0x60170EF")]
		[Address(RVA = "0xF7B240", Offset = "0xF79E40", VA = "0x180F7B240")]
		private Bounds _GetElementBoundsByIndex(int index)
		{
			return default(Bounds);
		}

		// Token: 0x060170F0 RID: 94448
		[Token(Token = "0x60170F0")]
		protected abstract Bounds GetElementBoundsFromMeta(UIRecycleLayoutGroup.LayoutMeta meta);

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x060170F1 RID: 94449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003712")]
		protected RectTransform content
		{
			[Token(Token = "0x60170F1")]
			[Address(RVA = "0xF7BF20", Offset = "0xF7AB20", VA = "0x180F7BF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x060170F2 RID: 94450 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060170F3 RID: 94451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003713")]
		protected RectTransform viewport
		{
			[Token(Token = "0x60170F2")]
			[Address(RVA = "0xF7C5F0", Offset = "0xF7B1F0", VA = "0x180F7C5F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60170F3")]
			[Address(RVA = "0xF7C7E0", Offset = "0xF7B3E0", VA = "0x180F7C7E0")]
			set
			{
			}
		}

		// Token: 0x060170F4 RID: 94452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170F4")]
		[Address(RVA = "0xF7B960", Offset = "0xF7A560", VA = "0x180F7B960")]
		[Inspect]
		private void _RefreshLayout()
		{
		}

		// Token: 0x060170F5 RID: 94453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60170F5")]
		[Address(RVA = "0xF7BD30", Offset = "0xF7A930", VA = "0x180F7BD30")]
		protected UIRecycleLayoutGroup()
		{
		}

		// Token: 0x0401BD22 RID: 113954
		[Token(Token = "0x401BD22")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0401BD23 RID: 113955
		[Token(Token = "0x401BD23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0401BD24 RID: 113956
		[Token(Token = "0x401BD24")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Layout")]
		private int _layoutPriority;

		// Token: 0x0401BD25 RID: 113957
		[Token(Token = "0x401BD25")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Layout")]
		private UIRecycleLayoutGroup.Padding _padding;

		// Token: 0x0401BD26 RID: 113958
		[Token(Token = "0x401BD26")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("Layout")]
		private float _spacing;

		// Token: 0x0401BD27 RID: 113959
		[Token(Token = "0x401BD27")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform m_viewport;

		// Token: 0x0401BD28 RID: 113960
		[Token(Token = "0x401BD28")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, UIRecycleLayoutGroup.LayoutMeta> m_layoutMetaMap;

		// Token: 0x0401BD29 RID: 113961
		[Token(Token = "0x401BD29")]
		[FieldOffset(Offset = "0x50")]
		private UIRecycleLayoutAdapter m_adapter;

		// Token: 0x0401BD2A RID: 113962
		[Token(Token = "0x401BD2A")]
		[FieldOffset(Offset = "0x58")]
		private UIRecycleLayoutGroup.ViewMgr m_viewMgr;

		// Token: 0x0401BD2D RID: 113965
		[Token(Token = "0x401BD2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layoutMetaMap;

		// Token: 0x0401BD2E RID: 113966
		[Token(Token = "0x401BD2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0401BD2F RID: 113967
		[Token(Token = "0x401BD2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_viewMgr;

		// Token: 0x0401BD30 RID: 113968
		[Token(Token = "0x401BD30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_sizeOnAxis;

		// Token: 0x0401BD31 RID: 113969
		[Token(Token = "0x401BD31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_sizeOnAxis;

		// Token: 0x0401BD32 RID: 113970
		[Token(Token = "0x401BD32")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_spacing;

		// Token: 0x0401BD33 RID: 113971
		[Token(Token = "0x401BD33")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_padding;

		// Token: 0x0401BD34 RID: 113972
		[Token(Token = "0x401BD34")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_onLayoutUpdated;

		// Token: 0x0401BD35 RID: 113973
		[Token(Token = "0x401BD35")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_onLayoutUpdated;

		// Token: 0x0401BD36 RID: 113974
		[Token(Token = "0x401BD36")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_minWidth;

		// Token: 0x0401BD37 RID: 113975
		[Token(Token = "0x401BD37")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_minHeight;

		// Token: 0x0401BD38 RID: 113976
		[Token(Token = "0x401BD38")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_flexibleWidth;

		// Token: 0x0401BD39 RID: 113977
		[Token(Token = "0x401BD39")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_flexibleHeight;

		// Token: 0x0401BD3A RID: 113978
		[Token(Token = "0x401BD3A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_layoutPriority;

		// Token: 0x0401BD3B RID: 113979
		[Token(Token = "0x401BD3B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputHorizontal;

		// Token: 0x0401BD3C RID: 113980
		[Token(Token = "0x401BD3C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CalculateLayoutInputVertical;

		// Token: 0x0401BD3D RID: 113981
		[Token(Token = "0x401BD3D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetAdapter;

		// Token: 0x0401BD3E RID: 113982
		[Token(Token = "0x401BD3E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0401BD3F RID: 113983
		[Token(Token = "0x401BD3F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RebuildAllViews;

		// Token: 0x0401BD40 RID: 113984
		[Token(Token = "0x401BD40")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateViews;

		// Token: 0x0401BD41 RID: 113985
		[Token(Token = "0x401BD41")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InsertView;

		// Token: 0x0401BD42 RID: 113986
		[Token(Token = "0x401BD42")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RemoveView;

		// Token: 0x0401BD43 RID: 113987
		[Token(Token = "0x401BD43")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateViewsFrom;

		// Token: 0x0401BD44 RID: 113988
		[Token(Token = "0x401BD44")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetElementPosByIndex;

		// Token: 0x0401BD45 RID: 113989
		[Token(Token = "0x401BD45")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetElementBoundsByIndex;

		// Token: 0x0401BD46 RID: 113990
		[Token(Token = "0x401BD46")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_content;

		// Token: 0x0401BD47 RID: 113991
		[Token(Token = "0x401BD47")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_viewport;

		// Token: 0x0401BD48 RID: 113992
		[Token(Token = "0x401BD48")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_viewport;

		// Token: 0x0401BD49 RID: 113993
		[Token(Token = "0x401BD49")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RefreshLayout;

		// Token: 0x0401BD4A RID: 113994
		[Token(Token = "0x401BD4A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038F9 RID: 14585
		[Token(Token = "0x20038F9")]
		public interface IViewHandler
		{
			// Token: 0x060170F6 RID: 94454
			[Token(Token = "0x60170F6")]
			UIRecycleLayoutAdapter.IVirtualView GetView(int index);

			// Token: 0x060170F7 RID: 94455
			[Token(Token = "0x60170F7")]
			int GetViewCount();

			// Token: 0x060170F8 RID: 94456
			[Token(Token = "0x60170F8")]
			bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view);

			// Token: 0x060170F9 RID: 94457
			[Token(Token = "0x60170F9")]
			bool AddView(UIRecycleLayoutAdapter.IVirtualView view);

			// Token: 0x060170FA RID: 94458
			[Token(Token = "0x60170FA")]
			void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view);

			// Token: 0x060170FB RID: 94459
			[Token(Token = "0x60170FB")]
			void NotifyAllViewSizeChanged();

			// Token: 0x060170FC RID: 94460
			[Token(Token = "0x60170FC")]
			void NotifyRebuild();

			// Token: 0x060170FD RID: 94461
			[Token(Token = "0x60170FD")]
			bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view);

			// Token: 0x060170FE RID: 94462
			[Token(Token = "0x60170FE")]
			float GetElementPosByIndex(int index);

			// Token: 0x060170FF RID: 94463
			[Token(Token = "0x60170FF")]
			Bounds GetElementBoundsByIndex(int index);
		}

		// Token: 0x020038FA RID: 14586
		[Token(Token = "0x20038FA")]
		protected interface ICustomLayoutMeta : IHotfixable
		{
		}

		// Token: 0x020038FB RID: 14587
		[Token(Token = "0x20038FB")]
		protected struct LayoutMeta
		{
			// Token: 0x0401BD4B RID: 113995
			[Token(Token = "0x401BD4B")]
			[FieldOffset(Offset = "0x0")]
			public float pos;

			// Token: 0x0401BD4C RID: 113996
			[Token(Token = "0x401BD4C")]
			[FieldOffset(Offset = "0x4")]
			public float size;

			// Token: 0x0401BD4D RID: 113997
			[Token(Token = "0x401BD4D")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x0401BD4E RID: 113998
			[Token(Token = "0x401BD4E")]
			[FieldOffset(Offset = "0xC")]
			public float curTotalSize;

			// Token: 0x0401BD4F RID: 113999
			[Token(Token = "0x401BD4F")]
			[FieldOffset(Offset = "0x10")]
			public UIRecycleLayoutGroup.ICustomLayoutMeta customLayoutMeta;
		}

		// Token: 0x020038FC RID: 14588
		[Token(Token = "0x20038FC")]
		private class ViewPool
		{
			// Token: 0x17003714 RID: 14100
			// (get) Token: 0x06017100 RID: 94464 RVA: 0x00094A58 File Offset: 0x00092C58
			// (set) Token: 0x06017101 RID: 94465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003714")]
			public int viewType
			{
				[Token(Token = "0x6017100")]
				[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6017101")]
				[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06017102 RID: 94466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017102")]
			[Address(RVA = "0xF82DD0", Offset = "0xF819D0", VA = "0x180F82DD0")]
			public ViewPool(int viewType, GameObject prefab, Transform container)
			{
			}

			// Token: 0x06017103 RID: 94467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017103")]
			[Address(RVA = "0xF829C0", Offset = "0xF815C0", VA = "0x180F829C0")]
			public GameObject Alloc(out bool isNewlyCreated)
			{
				return null;
			}

			// Token: 0x06017104 RID: 94468 RVA: 0x00094A70 File Offset: 0x00092C70
			[Token(Token = "0x6017104")]
			[Address(RVA = "0xF82C40", Offset = "0xF81840", VA = "0x180F82C40")]
			public bool Recycle(GameObject obj)
			{
				return default(bool);
			}

			// Token: 0x06017105 RID: 94469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017105")]
			[Address(RVA = "0xF82B10", Offset = "0xF81710", VA = "0x180F82B10")]
			public void RecycleAll()
			{
			}

			// Token: 0x0401BD50 RID: 114000
			[Token(Token = "0x401BD50")]
			[FieldOffset(Offset = "0x10")]
			private GameObject m_prefab;

			// Token: 0x0401BD51 RID: 114001
			[Token(Token = "0x401BD51")]
			[FieldOffset(Offset = "0x18")]
			private Transform m_container;

			// Token: 0x0401BD52 RID: 114002
			[Token(Token = "0x401BD52")]
			[FieldOffset(Offset = "0x20")]
			private List<GameObject> m_activeObjs;

			// Token: 0x0401BD53 RID: 114003
			[Token(Token = "0x401BD53")]
			[FieldOffset(Offset = "0x28")]
			private List<GameObject> m_pooledObjs;
		}

		// Token: 0x020038FD RID: 14589
		[Token(Token = "0x20038FD")]
		private class EmptyAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x06017106 RID: 94470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017106")]
			[Address(RVA = "0xF72730", Offset = "0xF71330", VA = "0x180F72730", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x06017107 RID: 94471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017107")]
			[Address(RVA = "0xF72790", Offset = "0xF71390", VA = "0x180F72790")]
			public EmptyAdapter()
			{
			}

			// Token: 0x0401BD55 RID: 114005
			[Token(Token = "0x401BD55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0401BD56 RID: 114006
			[Token(Token = "0x401BD56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020038FE RID: 14590
		[Token(Token = "0x20038FE")]
		protected class ViewMgr : IHotfixable, UIRecycleLayoutGroup.IViewHandler
		{
			// Token: 0x06017108 RID: 94472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017108")]
			[Address(RVA = "0xF828A0", Offset = "0xF814A0", VA = "0x180F828A0")]
			public ViewMgr(UIRecycleLayoutGroup closure)
			{
			}

			// Token: 0x06017109 RID: 94473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017109")]
			[Address(RVA = "0xF81F10", Offset = "0xF80B10", VA = "0x180F81F10")]
			public void RebuildAll(UIRecycleLayoutAdapter adapter)
			{
			}

			// Token: 0x0601710A RID: 94474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601710A")]
			[Address(RVA = "0xF81B80", Offset = "0xF80780", VA = "0x180F81B80")]
			public IList<UIRecycleLayoutAdapter.IVirtualView> GetViews()
			{
				return null;
			}

			// Token: 0x0601710B RID: 94475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601710B")]
			[Address(RVA = "0xF81500", Offset = "0xF80100", VA = "0x180F81500")]
			public void DetachView(UIRecycleLayoutAdapter.IVirtualView view, GameObject curView)
			{
			}

			// Token: 0x0601710C RID: 94476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601710C")]
			[Address(RVA = "0xF812B0", Offset = "0xF7FEB0", VA = "0x180F812B0")]
			public void AttachView(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0601710D RID: 94477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601710D")]
			[Address(RVA = "0xF81AF0", Offset = "0xF806F0", VA = "0x180F81AF0", Slot = "4")]
			public UIRecycleLayoutAdapter.IVirtualView GetView(int index)
			{
				return null;
			}

			// Token: 0x0601710E RID: 94478 RVA: 0x00094A88 File Offset: 0x00092C88
			[Token(Token = "0x601710E")]
			[Address(RVA = "0xF81A80", Offset = "0xF80680", VA = "0x180F81A80", Slot = "5")]
			public int GetViewCount()
			{
				return 0;
			}

			// Token: 0x0601710F RID: 94479 RVA: 0x00094AA0 File Offset: 0x00092CA0
			[Token(Token = "0x601710F")]
			[Address(RVA = "0xF81BE0", Offset = "0xF807E0", VA = "0x180F81BE0", Slot = "6")]
			public bool InsertView(int index, UIRecycleLayoutAdapter.IVirtualView view)
			{
				return default(bool);
			}

			// Token: 0x06017110 RID: 94480 RVA: 0x00094AB8 File Offset: 0x00092CB8
			[Token(Token = "0x6017110")]
			[Address(RVA = "0xF81200", Offset = "0xF7FE00", VA = "0x180F81200", Slot = "7")]
			public bool AddView(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return default(bool);
			}

			// Token: 0x06017111 RID: 94481 RVA: 0x00094AD0 File Offset: 0x00092CD0
			[Token(Token = "0x6017111")]
			[Address(RVA = "0xF82430", Offset = "0xF81030", VA = "0x180F82430", Slot = "11")]
			public bool RemoveView(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return default(bool);
			}

			// Token: 0x06017112 RID: 94482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017112")]
			[Address(RVA = "0xF81DA0", Offset = "0xF809A0", VA = "0x180F81DA0", Slot = "8")]
			public void NotifyViewSizeChanged(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x06017113 RID: 94483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017113")]
			[Address(RVA = "0xF81CA0", Offset = "0xF808A0", VA = "0x180F81CA0", Slot = "9")]
			public void NotifyAllViewSizeChanged()
			{
			}

			// Token: 0x06017114 RID: 94484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017114")]
			[Address(RVA = "0xF81D30", Offset = "0xF80930", VA = "0x180F81D30", Slot = "10")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x06017115 RID: 94485 RVA: 0x00094AE8 File Offset: 0x00092CE8
			[Token(Token = "0x6017115")]
			[Address(RVA = "0xF81930", Offset = "0xF80530", VA = "0x180F81930", Slot = "12")]
			public float GetElementPosByIndex(int index)
			{
				return 0f;
			}

			// Token: 0x06017116 RID: 94486 RVA: 0x00094B00 File Offset: 0x00092D00
			[Token(Token = "0x6017116")]
			[Address(RVA = "0xF81740", Offset = "0xF80340", VA = "0x180F81740", Slot = "13")]
			public Bounds GetElementBoundsByIndex(int index)
			{
				return default(Bounds);
			}

			// Token: 0x06017117 RID: 94487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017117")]
			[Address(RVA = "0xF824D0", Offset = "0xF810D0", VA = "0x180F824D0")]
			private UIRecycleLayoutGroup.ViewPool _EnsureViewPool(UIRecycleLayoutAdapter.IVirtualView view)
			{
				return null;
			}

			// Token: 0x06017118 RID: 94488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017118")]
			[Address(RVA = "0xF827E0", Offset = "0xF813E0", VA = "0x180F827E0")]
			private void _NotifyLayoutChanged(int fromIndex)
			{
			}

			// Token: 0x0401BD57 RID: 114007
			[Token(Token = "0x401BD57")]
			[FieldOffset(Offset = "0x10")]
			private UIRecycleLayoutGroup m_closure;

			// Token: 0x0401BD58 RID: 114008
			[Token(Token = "0x401BD58")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<int, UIRecycleLayoutGroup.ViewPool> m_viewPools;

			// Token: 0x0401BD59 RID: 114009
			[Token(Token = "0x401BD59")]
			[FieldOffset(Offset = "0x20")]
			private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

			// Token: 0x0401BD5A RID: 114010
			[Token(Token = "0x401BD5A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401BD5B RID: 114011
			[Token(Token = "0x401BD5B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildAll;

			// Token: 0x0401BD5C RID: 114012
			[Token(Token = "0x401BD5C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetViews;

			// Token: 0x0401BD5D RID: 114013
			[Token(Token = "0x401BD5D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_DetachView;

			// Token: 0x0401BD5E RID: 114014
			[Token(Token = "0x401BD5E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AttachView;

			// Token: 0x0401BD5F RID: 114015
			[Token(Token = "0x401BD5F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetView;

			// Token: 0x0401BD60 RID: 114016
			[Token(Token = "0x401BD60")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetViewCount;

			// Token: 0x0401BD61 RID: 114017
			[Token(Token = "0x401BD61")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_InsertView;

			// Token: 0x0401BD62 RID: 114018
			[Token(Token = "0x401BD62")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_AddView;

			// Token: 0x0401BD63 RID: 114019
			[Token(Token = "0x401BD63")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_RemoveView;

			// Token: 0x0401BD64 RID: 114020
			[Token(Token = "0x401BD64")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_NotifyViewSizeChanged;

			// Token: 0x0401BD65 RID: 114021
			[Token(Token = "0x401BD65")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_NotifyAllViewSizeChanged;

			// Token: 0x0401BD66 RID: 114022
			[Token(Token = "0x401BD66")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x0401BD67 RID: 114023
			[Token(Token = "0x401BD67")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_GetElementPosByIndex;

			// Token: 0x0401BD68 RID: 114024
			[Token(Token = "0x401BD68")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GetElementBoundsByIndex;

			// Token: 0x0401BD69 RID: 114025
			[Token(Token = "0x401BD69")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0__EnsureViewPool;

			// Token: 0x0401BD6A RID: 114026
			[Token(Token = "0x401BD6A")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0__NotifyLayoutChanged;
		}

		// Token: 0x020038FF RID: 14591
		[Token(Token = "0x20038FF")]
		[Serializable]
		protected struct Padding
		{
			// Token: 0x0401BD6B RID: 114027
			[Token(Token = "0x401BD6B")]
			[FieldOffset(Offset = "0x0")]
			public int top;

			// Token: 0x0401BD6C RID: 114028
			[Token(Token = "0x401BD6C")]
			[FieldOffset(Offset = "0x4")]
			public int left;

			// Token: 0x0401BD6D RID: 114029
			[Token(Token = "0x401BD6D")]
			[FieldOffset(Offset = "0x8")]
			public int bottom;

			// Token: 0x0401BD6E RID: 114030
			[Token(Token = "0x401BD6E")]
			[FieldOffset(Offset = "0xC")]
			public int right;
		}
	}
}
