using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EFA RID: 16122
	[Token(Token = "0x2003EFA")]
	public class SiracusaMapPointInfoHolder : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x06019081 RID: 102529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019081")]
		[Address(RVA = "0x11BCEF0", Offset = "0x11BBAF0", VA = "0x1811BCEF0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x06019082 RID: 102530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019082")]
		[Address(RVA = "0x11BD160", Offset = "0x11BBD60", VA = "0x1811BD160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019083 RID: 102531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019083")]
		[Address(RVA = "0x11BD2C0", Offset = "0x11BBEC0", VA = "0x1811BD2C0")]
		public SiracusaMapPointInfoHolder()
		{
		}

		// Token: 0x0401EF19 RID: 126745
		[Token(Token = "0x401EF19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SiracusaMapPointInfoView _pointInfoViewPrefab;

		// Token: 0x0401EF1A RID: 126746
		[Token(Token = "0x401EF1A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _pointInfoContainer;

		// Token: 0x0401EF1B RID: 126747
		[Token(Token = "0x401EF1B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401EF1C RID: 126748
		[Token(Token = "0x401EF1C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401EF1D RID: 126749
		[Token(Token = "0x401EF1D")]
		[FieldOffset(Offset = "0x40")]
		private SiracusaMapPointInfoView m_pointInfoView;

		// Token: 0x0401EF1E RID: 126750
		[Token(Token = "0x401EF1E")]
		[FieldOffset(Offset = "0x48")]
		private UISwitchTween m_fadeTween;

		// Token: 0x0401EF1F RID: 126751
		[Token(Token = "0x401EF1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EF20 RID: 126752
		[Token(Token = "0x401EF20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EF21 RID: 126753
		[Token(Token = "0x401EF21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
