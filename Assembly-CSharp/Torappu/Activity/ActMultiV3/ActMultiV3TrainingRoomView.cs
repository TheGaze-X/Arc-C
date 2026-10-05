using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02007019 RID: 28697
	[Token(Token = "0x2007019")]
	public class ActMultiV3TrainingRoomView : DataBinder<ActMultiV3TrainingRoomProperty>
	{
		// Token: 0x06028BB1 RID: 166833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BB1")]
		[Address(RVA = "0x2417C80", Offset = "0x2416880", VA = "0x182417C80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028BB2 RID: 166834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BB2")]
		[Address(RVA = "0x2417A40", Offset = "0x2416640", VA = "0x182417A40")]
		private void _EnsureBillboardView(string actId, ILoadAsset assetLoader)
		{
		}

		// Token: 0x06028BB3 RID: 166835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BB3")]
		[Address(RVA = "0x24176B0", Offset = "0x24162B0", VA = "0x1824176B0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3TrainingRoomProperty property)
		{
		}

		// Token: 0x06028BB4 RID: 166836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BB4")]
		[Address(RVA = "0x2417ED0", Offset = "0x2416AD0", VA = "0x182417ED0")]
		public ActMultiV3TrainingRoomView()
		{
		}

		// Token: 0x0403A12B RID: 237867
		[Token(Token = "0x403A12B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _bottomBarHolder;

		// Token: 0x0403A12C RID: 237868
		[Token(Token = "0x403A12C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _layoutMode;

		// Token: 0x0403A12D RID: 237869
		[Token(Token = "0x403A12D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Billboard")]
		private PageCameraRenderTextureHolder _renderTextureHolder;

		// Token: 0x0403A12E RID: 237870
		[Token(Token = "0x403A12E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Billboard")]
		private UIMeshImage[] _billboardMeshImageList;

		// Token: 0x0403A12F RID: 237871
		[Token(Token = "0x403A12F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Billboard")]
		private RectTransform _billboardPrefabHolder;

		// Token: 0x0403A130 RID: 237872
		[Token(Token = "0x403A130")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x0403A131 RID: 237873
		[Token(Token = "0x403A131")]
		[FieldOffset(Offset = "0x50")]
		private ActMultiV3CommonBottomBar m_bottomBar;

		// Token: 0x0403A132 RID: 237874
		[Token(Token = "0x403A132")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A133 RID: 237875
		[Token(Token = "0x403A133")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3TrainingRoomViewModel m_cachedViewModel;

		// Token: 0x0403A134 RID: 237876
		[Token(Token = "0x403A134")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3TrainingRoomView.Adapter m_adapter;

		// Token: 0x0403A135 RID: 237877
		[Token(Token = "0x403A135")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<int, ActMultiV3TrainingRoomBillboardView> m_billboardViews;

		// Token: 0x0403A136 RID: 237878
		[Token(Token = "0x403A136")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_modeShowTween;

		// Token: 0x0403A137 RID: 237879
		[Token(Token = "0x403A137")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3MapModeType m_cachedSelectedModeType;

		// Token: 0x0403A138 RID: 237880
		[Token(Token = "0x403A138")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A139 RID: 237881
		[Token(Token = "0x403A139")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EnsureBillboardView;

		// Token: 0x0403A13A RID: 237882
		[Token(Token = "0x403A13A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A13B RID: 237883
		[Token(Token = "0x403A13B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200701A RID: 28698
		[Token(Token = "0x200701A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06028BB5 RID: 166837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028BB5")]
			[Address(RVA = "0x2418BC0", Offset = "0x24177C0", VA = "0x182418BC0")]
			public Adapter(ActMultiV3TrainingRoomView closure)
			{
			}

			// Token: 0x17006026 RID: 24614
			// (get) Token: 0x06028BB6 RID: 166838 RVA: 0x000D2C90 File Offset: 0x000D0E90
			[Token(Token = "0x17006026")]
			public override int count
			{
				[Token(Token = "0x6028BB6")]
				[Address(RVA = "0x2418EF0", Offset = "0x2417AF0", VA = "0x182418EF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028BB7 RID: 166839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028BB7")]
			[Address(RVA = "0x24181A0", Offset = "0x2416DA0", VA = "0x1824181A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403A13C RID: 237884
			[Token(Token = "0x403A13C")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3TrainingRoomView m_closure;

			// Token: 0x0403A13D RID: 237885
			[Token(Token = "0x403A13D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403A13E RID: 237886
			[Token(Token = "0x403A13E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A13F RID: 237887
			[Token(Token = "0x403A13F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
