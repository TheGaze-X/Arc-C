using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x02004615 RID: 17941
	[Token(Token = "0x2004615")]
	public class RL02OuterBuffMapView : DataBinder<RL02OuterBuffProperty>, IHotfixable
	{
		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x0601B447 RID: 111687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B448 RID: 111688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040FD")]
		public Action<string> onNodeClicked
		{
			[Token(Token = "0x601B447")]
			[Address(RVA = "0x149F610", Offset = "0x149E210", VA = "0x18149F610")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B448")]
			[Address(RVA = "0x149F6F0", Offset = "0x149E2F0", VA = "0x18149F6F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x0601B449 RID: 111689 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B44A RID: 111690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040FE")]
		public Action onBackgroundClicked
		{
			[Token(Token = "0x601B449")]
			[Address(RVA = "0x149F5B0", Offset = "0x149E1B0", VA = "0x18149F5B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B44A")]
			[Address(RVA = "0x149F670", Offset = "0x149E270", VA = "0x18149F670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B44B RID: 111691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B44B")]
		[Address(RVA = "0x149E710", Offset = "0x149D310", VA = "0x18149E710")]
		public void OnInit(UIPage page, RL02OuterBuffMapView.IBindings bindings)
		{
		}

		// Token: 0x0601B44C RID: 111692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B44C")]
		[Address(RVA = "0x149EC50", Offset = "0x149D850", VA = "0x18149EC50", Slot = "7")]
		public override void OnValueChanged(RL02OuterBuffProperty property)
		{
		}

		// Token: 0x0601B44D RID: 111693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B44D")]
		[Address(RVA = "0x149E600", Offset = "0x149D200", VA = "0x18149E600")]
		public void OnBackgroundClicked()
		{
		}

		// Token: 0x0601B44E RID: 111694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B44E")]
		[Address(RVA = "0x149F420", Offset = "0x149E020", VA = "0x18149F420")]
		private void _OnSetMapScale(float targetScale)
		{
		}

		// Token: 0x0601B44F RID: 111695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B44F")]
		[Address(RVA = "0x149F380", Offset = "0x149DF80", VA = "0x18149F380")]
		private void _OnSetMapRangeScale(float min, float max)
		{
		}

		// Token: 0x0601B450 RID: 111696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B450")]
		[Address(RVA = "0x149F4A0", Offset = "0x149E0A0", VA = "0x18149F4A0")]
		private void _OnSetTouchEnabled(bool enabled)
		{
		}

		// Token: 0x0601B451 RID: 111697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B451")]
		[Address(RVA = "0x149F090", Offset = "0x149DC90", VA = "0x18149F090")]
		private void _OnMapScaleChanged(float scale)
		{
		}

		// Token: 0x0601B452 RID: 111698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B452")]
		[Address(RVA = "0x149F240", Offset = "0x149DE40", VA = "0x18149F240")]
		private void _OnMapScaleStateChanged(bool isZooming)
		{
		}

		// Token: 0x0601B453 RID: 111699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B453")]
		[Address(RVA = "0x149EE40", Offset = "0x149DA40", VA = "0x18149EE40")]
		private void _OnMapLayoutChanged()
		{
		}

		// Token: 0x0601B454 RID: 111700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B454")]
		[Address(RVA = "0x149F540", Offset = "0x149E140", VA = "0x18149F540")]
		public RL02OuterBuffMapView()
		{
		}

		// Token: 0x04023300 RID: 144128
		[Token(Token = "0x4023300")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL02OuterBuffLineGroupView _lineGroupView;

		// Token: 0x04023301 RID: 144129
		[Token(Token = "0x4023301")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL02OuterBuffNodeGroupView _nodeGroupView;

		// Token: 0x04023302 RID: 144130
		[Token(Token = "0x4023302")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("MapScaling")]
		private UITouchZoom _mapTouchZoom;

		// Token: 0x04023303 RID: 144131
		[Token(Token = "0x4023303")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("MapScaling")]
		private UIWrappedScrollRect _mapScroll;

		// Token: 0x04023304 RID: 144132
		[Token(Token = "0x4023304")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("MapScaling")]
		private UILayoutDimensionListener _layoutListener;

		// Token: 0x04023307 RID: 144135
		[Token(Token = "0x4023307")]
		[FieldOffset(Offset = "0x58")]
		private RL02OuterBuffMapView.IBindings m_bindings;

		// Token: 0x04023308 RID: 144136
		[Token(Token = "0x4023308")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeClicked;

		// Token: 0x04023309 RID: 144137
		[Token(Token = "0x4023309")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeClicked;

		// Token: 0x0402330A RID: 144138
		[Token(Token = "0x402330A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onBackgroundClicked;

		// Token: 0x0402330B RID: 144139
		[Token(Token = "0x402330B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onBackgroundClicked;

		// Token: 0x0402330C RID: 144140
		[Token(Token = "0x402330C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402330D RID: 144141
		[Token(Token = "0x402330D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402330E RID: 144142
		[Token(Token = "0x402330E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackgroundClicked;

		// Token: 0x0402330F RID: 144143
		[Token(Token = "0x402330F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSetMapScale;

		// Token: 0x04023310 RID: 144144
		[Token(Token = "0x4023310")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnSetMapRangeScale;

		// Token: 0x04023311 RID: 144145
		[Token(Token = "0x4023311")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSetTouchEnabled;

		// Token: 0x04023312 RID: 144146
		[Token(Token = "0x4023312")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMapScaleChanged;

		// Token: 0x04023313 RID: 144147
		[Token(Token = "0x4023313")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnMapScaleStateChanged;

		// Token: 0x04023314 RID: 144148
		[Token(Token = "0x4023314")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnMapLayoutChanged;

		// Token: 0x04023315 RID: 144149
		[Token(Token = "0x4023315")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004616 RID: 17942
		[Token(Token = "0x2004616")]
		public interface IBindings
		{
			// Token: 0x0601B457 RID: 111703
			[Token(Token = "0x601B457")]
			void OnMapScaleChanged(float scale);

			// Token: 0x0601B458 RID: 111704
			[Token(Token = "0x601B458")]
			void OnMapLayoutChanged(Vector2 viewport, Vector2 content);

			// Token: 0x0601B459 RID: 111705
			[Token(Token = "0x601B459")]
			void OnMapTouchZoomStateChanged(bool isZooming);

			// Token: 0x0601B45A RID: 111706
			[Token(Token = "0x601B45A")]
			void BindScroll(Action<Vector2> normalizedPosMethod);

			// Token: 0x0601B45B RID: 111707
			[Token(Token = "0x601B45B")]
			void BindTouchZoom(Action<float> scaleMethod, Action<float, float> scaleRangeMethod, Action<bool> enableTouchMethod);
		}
	}
}
