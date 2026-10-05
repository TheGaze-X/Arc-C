using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200670E RID: 26382
	[Token(Token = "0x200670E")]
	public class HandBookV2MapZoomView : DataBinder<HandBookV2MapZoomProperty>
	{
		// Token: 0x06025DC6 RID: 155078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC6")]
		[Address(RVA = "0x20E43C0", Offset = "0x20E2FC0", VA = "0x1820E43C0", Slot = "7")]
		public override void OnValueChanged(HandBookV2MapZoomProperty property)
		{
		}

		// Token: 0x06025DC7 RID: 155079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC7")]
		[Address(RVA = "0x20E4660", Offset = "0x20E3260", VA = "0x1820E4660")]
		private void _Init(HandBookV2MapZoomModel zoomModel)
		{
		}

		// Token: 0x06025DC8 RID: 155080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC8")]
		[Address(RVA = "0x20E47C0", Offset = "0x20E33C0", VA = "0x1820E47C0")]
		private void _OnScaleChanged(float scale)
		{
		}

		// Token: 0x06025DC9 RID: 155081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DC9")]
		[Address(RVA = "0x20E4930", Offset = "0x20E3530", VA = "0x1820E4930")]
		private void _OnScaleEnd(float scale)
		{
		}

		// Token: 0x06025DCA RID: 155082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DCA")]
		[Address(RVA = "0x20E4AA0", Offset = "0x20E36A0", VA = "0x1820E4AA0")]
		private void _OnScaleStart(float scale)
		{
		}

		// Token: 0x06025DCB RID: 155083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DCB")]
		[Address(RVA = "0x20E4C10", Offset = "0x20E3810", VA = "0x1820E4C10")]
		public HandBookV2MapZoomView()
		{
		}

		// Token: 0x040353E0 RID: 218080
		[Token(Token = "0x40353E0")]
		private const string ANIM_MAP_ENTER = "force_map_enter";

		// Token: 0x040353E1 RID: 218081
		[Token(Token = "0x40353E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2TeamMapStateBean _stateBean;

		// Token: 0x040353E2 RID: 218082
		[Token(Token = "0x40353E2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITouchZoom _touchZoom;

		// Token: 0x040353E3 RID: 218083
		[Token(Token = "0x40353E3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIWrappedScrollRect _scrollRect;

		// Token: 0x040353E4 RID: 218084
		[Token(Token = "0x40353E4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HandBookV2MapView _mapView;

		// Token: 0x040353E5 RID: 218085
		[Token(Token = "0x40353E5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _fadeInScale;

		// Token: 0x040353E6 RID: 218086
		[Token(Token = "0x40353E6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x040353E7 RID: 218087
		[Token(Token = "0x40353E7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x040353E8 RID: 218088
		[Token(Token = "0x40353E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040353E9 RID: 218089
		[Token(Token = "0x40353E9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x040353EA RID: 218090
		[Token(Token = "0x40353EA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnScaleChanged;

		// Token: 0x040353EB RID: 218091
		[Token(Token = "0x40353EB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnScaleEnd;

		// Token: 0x040353EC RID: 218092
		[Token(Token = "0x40353EC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScaleStart;

		// Token: 0x040353ED RID: 218093
		[Token(Token = "0x40353ED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
