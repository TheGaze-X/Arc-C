using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D36 RID: 19766
	[Token(Token = "0x2004D36")]
	public class MagneticDotSliderView : DataBinder<MagneticDotSliderViewModelProperty>
	{
		// Token: 0x0601D973 RID: 121203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D973")]
		[Address(RVA = "0x1734090", Offset = "0x1732C90", VA = "0x181734090")]
		public void InitView(GrocerySellSliderController controller)
		{
		}

		// Token: 0x0601D974 RID: 121204 RVA: 0x000AC0B0 File Offset: 0x000AA2B0
		[Token(Token = "0x601D974")]
		[Address(RVA = "0x1734030", Offset = "0x1732C30", VA = "0x181734030")]
		public float GetReachDotBias()
		{
			return 0f;
		}

		// Token: 0x0601D975 RID: 121205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D975")]
		[Address(RVA = "0x1734110", Offset = "0x1732D10", VA = "0x181734110", Slot = "7")]
		public override void OnValueChanged(MagneticDotSliderViewModelProperty property)
		{
		}

		// Token: 0x0601D976 RID: 121206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D976")]
		[Address(RVA = "0x1734570", Offset = "0x1733170", VA = "0x181734570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D977 RID: 121207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D977")]
		[Address(RVA = "0x17346B0", Offset = "0x17332B0", VA = "0x1817346B0")]
		public MagneticDotSliderView()
		{
		}

		// Token: 0x0402713F RID: 160063
		[Token(Token = "0x402713F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HorizontalLayoutGroup _dotLayoutGroup;

		// Token: 0x04027140 RID: 160064
		[Token(Token = "0x4027140")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _dotItemList;

		// Token: 0x04027141 RID: 160065
		[Token(Token = "0x4027141")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _dotWidth;

		// Token: 0x04027142 RID: 160066
		[Token(Token = "0x4027142")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCurValue;

		// Token: 0x04027143 RID: 160067
		[Token(Token = "0x4027143")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04027144 RID: 160068
		[Token(Token = "0x4027144")]
		[FieldOffset(Offset = "0x48")]
		private MagneticDotSliderView.Adapter m_dotItemListAdapter;

		// Token: 0x04027145 RID: 160069
		[Token(Token = "0x4027145")]
		[FieldOffset(Offset = "0x50")]
		private MagneticDotSliderViewModel m_model;

		// Token: 0x04027146 RID: 160070
		[Token(Token = "0x4027146")]
		[FieldOffset(Offset = "0x58")]
		private GrocerySellSliderController m_sliderController;

		// Token: 0x04027147 RID: 160071
		[Token(Token = "0x4027147")]
		[FieldOffset(Offset = "0x60")]
		private RectTransform m_layoutTransform;

		// Token: 0x04027148 RID: 160072
		[Token(Token = "0x4027148")]
		[FieldOffset(Offset = "0x68")]
		private float m_cachedReachDotBias;

		// Token: 0x04027149 RID: 160073
		[Token(Token = "0x4027149")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0402714A RID: 160074
		[Token(Token = "0x402714A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetReachDotBias;

		// Token: 0x0402714B RID: 160075
		[Token(Token = "0x402714B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402714C RID: 160076
		[Token(Token = "0x402714C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402714D RID: 160077
		[Token(Token = "0x402714D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D37 RID: 19767
		[Token(Token = "0x2004D37")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D978 RID: 121208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D978")]
			[Address(RVA = "0x17240E0", Offset = "0x1722CE0", VA = "0x1817240E0")]
			public Adapter(MagneticDotSliderView closure)
			{
			}

			// Token: 0x1700457C RID: 17788
			// (get) Token: 0x0601D979 RID: 121209 RVA: 0x000AC0C8 File Offset: 0x000AA2C8
			[Token(Token = "0x1700457C")]
			public override int count
			{
				[Token(Token = "0x601D979")]
				[Address(RVA = "0x17241E0", Offset = "0x1722DE0", VA = "0x1817241E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D97A RID: 121210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D97A")]
			[Address(RVA = "0x1723C80", Offset = "0x1722880", VA = "0x181723C80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402714E RID: 160078
			[Token(Token = "0x402714E")]
			[FieldOffset(Offset = "0x20")]
			private MagneticDotSliderView m_closure;

			// Token: 0x0402714F RID: 160079
			[Token(Token = "0x402714F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04027150 RID: 160080
			[Token(Token = "0x4027150")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04027151 RID: 160081
			[Token(Token = "0x4027151")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
