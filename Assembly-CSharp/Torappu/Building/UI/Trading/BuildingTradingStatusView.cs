using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C49 RID: 7241
	[Token(Token = "0x2001C49")]
	public class BuildingTradingStatusView : DataBinder<TRoomViewProperty>
	{
		// Token: 0x0600B446 RID: 46150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B446")]
		[Address(RVA = "0x32F7E90", Offset = "0x32F6A90", VA = "0x1832F7E90")]
		private void OnEnable()
		{
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B447")]
		[Address(RVA = "0x32F7F90", Offset = "0x32F6B90", VA = "0x1832F7F90", Slot = "7")]
		public override void OnValueChanged(TRoomViewProperty property)
		{
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B448")]
		[Address(RVA = "0x32F84C0", Offset = "0x32F70C0", VA = "0x1832F84C0")]
		private void _RenderBuff(TRoomViewModel viewModel)
		{
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B449")]
		[Address(RVA = "0x32F87E0", Offset = "0x32F73E0", VA = "0x1832F87E0")]
		private void _RenderNegotiation(TRoomViewModel viewModel)
		{
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B44A")]
		[Address(RVA = "0x32F8360", Offset = "0x32F6F60", VA = "0x1832F8360")]
		private string _PickColorCode(int sign = 1)
		{
			return null;
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B44B")]
		[Address(RVA = "0x32F8B70", Offset = "0x32F7770", VA = "0x1832F8B70")]
		private static void _UpdateToggleByBuff(ThreeStateToggle toggle, float buffVal, int sign = 1)
		{
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B44C")]
		[Address(RVA = "0x32F8AC0", Offset = "0x32F76C0", VA = "0x1832F8AC0")]
		private IEnumerator _UpdateAutoLayouts()
		{
			return null;
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B44D")]
		[Address(RVA = "0x32F8080", Offset = "0x32F6C80", VA = "0x1832F8080")]
		private void _FormatBuffedValues(float baseBuff, float spcBuff, SimpleLayoutContent layout, ref BuildingBuffedValueView.ListAdapter refAdatper, bool usePercentFormat)
		{
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B44E")]
		[Address(RVA = "0x32F8C80", Offset = "0x32F7880", VA = "0x1832F8C80")]
		public BuildingTradingStatusView()
		{
		}

		// Token: 0x0400AFDD RID: 45021
		[Token(Token = "0x400AFDD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textManpowerCost;

		// Token: 0x0400AFDE RID: 45022
		[Token(Token = "0x400AFDE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _mpBuffLayout;

		// Token: 0x0400AFDF RID: 45023
		[Token(Token = "0x400AFDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ThreeStateToggle _toggleManpowerCost;

		// Token: 0x0400AFE0 RID: 45024
		[Token(Token = "0x400AFE0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textSpeedEmpty;

		// Token: 0x0400AFE1 RID: 45025
		[Token(Token = "0x400AFE1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _speedBuffLayout;

		// Token: 0x0400AFE2 RID: 45026
		[Token(Token = "0x400AFE2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ThreeStateToggle _toggleOrderSpeed;

		// Token: 0x0400AFE3 RID: 45027
		[Token(Token = "0x400AFE3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _imageOrderType;

		// Token: 0x0400AFE4 RID: 45028
		[Token(Token = "0x400AFE4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelStrategyDisable;

		// Token: 0x0400AFE5 RID: 45029
		[Token(Token = "0x400AFE5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _stgButton;

		// Token: 0x0400AFE6 RID: 45030
		[Token(Token = "0x400AFE6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textStrategyUnlock;

		// Token: 0x0400AFE7 RID: 45031
		[Token(Token = "0x400AFE7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400AFE8 RID: 45032
		[Token(Token = "0x400AFE8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Styles")]
		private Color _colorBuff;

		// Token: 0x0400AFE9 RID: 45033
		[Token(Token = "0x400AFE9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Styles")]
		private Color _colorDebuff;

		// Token: 0x0400AFEA RID: 45034
		[Token(Token = "0x400AFEA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Styles")]
		private BuildingTradingStatusView.OrderTypeImage[] _orderTypeImages;

		// Token: 0x0400AFEB RID: 45035
		[Token(Token = "0x400AFEB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Buff Styles")]
		private Color _bkgColorBuff;

		// Token: 0x0400AFEC RID: 45036
		[Token(Token = "0x400AFEC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Buff Styles")]
		private Color _textColorBuff;

		// Token: 0x0400AFED RID: 45037
		[Token(Token = "0x400AFED")]
		[FieldOffset(Offset = "0xC0")]
		private BuffStruct m_buffCache;

		// Token: 0x0400AFEE RID: 45038
		[Token(Token = "0x400AFEE")]
		[FieldOffset(Offset = "0xD4")]
		private bool m_isInited;

		// Token: 0x0400AFEF RID: 45039
		[Token(Token = "0x400AFEF")]
		[FieldOffset(Offset = "0xD8")]
		private string m_buffColorCode;

		// Token: 0x0400AFF0 RID: 45040
		[Token(Token = "0x400AFF0")]
		[FieldOffset(Offset = "0xE0")]
		private string m_debuffColorCode;

		// Token: 0x0400AFF1 RID: 45041
		[Token(Token = "0x400AFF1")]
		[FieldOffset(Offset = "0xE8")]
		private BuildingData.OrderType m_orderTypeCache;

		// Token: 0x0400AFF2 RID: 45042
		[Token(Token = "0x400AFF2")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_isStrategryUnlockedCache;

		// Token: 0x0400AFF3 RID: 45043
		[Token(Token = "0x400AFF3")]
		[FieldOffset(Offset = "0xF0")]
		private BuildingBuffedValueView.ListAdapter m_mpBuffAdapter;

		// Token: 0x0400AFF4 RID: 45044
		[Token(Token = "0x400AFF4")]
		[FieldOffset(Offset = "0xF8")]
		private BuildingBuffedValueView.ListAdapter m_speedBuffAdapter;

		// Token: 0x0400AFF5 RID: 45045
		[Token(Token = "0x400AFF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0400AFF6 RID: 45046
		[Token(Token = "0x400AFF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400AFF7 RID: 45047
		[Token(Token = "0x400AFF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderBuff;

		// Token: 0x0400AFF8 RID: 45048
		[Token(Token = "0x400AFF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderNegotiation;

		// Token: 0x0400AFF9 RID: 45049
		[Token(Token = "0x400AFF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PickColorCode;

		// Token: 0x0400AFFA RID: 45050
		[Token(Token = "0x400AFFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateToggleByBuff;

		// Token: 0x0400AFFB RID: 45051
		[Token(Token = "0x400AFFB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayouts;

		// Token: 0x0400AFFC RID: 45052
		[Token(Token = "0x400AFFC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FormatBuffedValues;

		// Token: 0x0400AFFD RID: 45053
		[Token(Token = "0x400AFFD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C4A RID: 7242
		[Token(Token = "0x2001C4A")]
		[Serializable]
		private struct OrderTypeImage
		{
			// Token: 0x0400AFFE RID: 45054
			[Token(Token = "0x400AFFE")]
			[FieldOffset(Offset = "0x0")]
			public TradingOrderViewType viewType;

			// Token: 0x0400AFFF RID: 45055
			[Token(Token = "0x400AFFF")]
			[FieldOffset(Offset = "0x8")]
			public Sprite image;
		}
	}
}
