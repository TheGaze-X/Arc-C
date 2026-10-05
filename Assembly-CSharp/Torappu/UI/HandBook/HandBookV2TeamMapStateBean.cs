using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672E RID: 26414
	[Token(Token = "0x200672E")]
	public class HandBookV2TeamMapStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x170059BD RID: 22973
		// (get) Token: 0x06025E20 RID: 155168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059BD")]
		public HandBookV2MapZoomProperty zoomProperty
		{
			[Token(Token = "0x6025E20")]
			[Address(RVA = "0x20E8DE0", Offset = "0x20E79E0", VA = "0x1820E8DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E21 RID: 155169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E21")]
		[Address(RVA = "0x20E79A0", Offset = "0x20E65A0", VA = "0x1820E79A0")]
		public void RefreshFocusPos(string forceId)
		{
		}

		// Token: 0x06025E22 RID: 155170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E22")]
		[Address(RVA = "0x20E7330", Offset = "0x20E5F30", VA = "0x1820E7330")]
		public void InitData(UIPage page)
		{
		}

		// Token: 0x06025E23 RID: 155171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E23")]
		[Address(RVA = "0x20E7AF0", Offset = "0x20E66F0", VA = "0x1820E7AF0")]
		public void Refresh()
		{
		}

		// Token: 0x06025E24 RID: 155172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E24")]
		[Address(RVA = "0x20E81D0", Offset = "0x20E6DD0", VA = "0x1820E81D0")]
		private void _RefreshForceViewModel(HandBookV2MapRenderViewModel viewModel)
		{
		}

		// Token: 0x06025E25 RID: 155173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E25")]
		[Address(RVA = "0x20E7D30", Offset = "0x20E6930", VA = "0x1820E7D30")]
		private void _InitForceLineViewModel(HandBookV2MapRenderViewModel viewModel)
		{
		}

		// Token: 0x06025E26 RID: 155174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E26")]
		[Address(RVA = "0x20E7F30", Offset = "0x20E6B30", VA = "0x1820E7F30")]
		private void _InitPointLineViewModel(HandBookV2MapRenderViewModel viewModel)
		{
		}

		// Token: 0x06025E27 RID: 155175 RVA: 0x000C9528 File Offset: 0x000C7728
		[Token(Token = "0x6025E27")]
		[Address(RVA = "0x20E7B70", Offset = "0x20E6770", VA = "0x1820E7B70")]
		private Vector2 _GetPointPos(HandBookV2MapRenderViewModel viewModel, int pointIndex)
		{
			return default(Vector2);
		}

		// Token: 0x06025E28 RID: 155176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E28")]
		[Address(RVA = "0x20E8C20", Offset = "0x20E7820", VA = "0x1820E8C20")]
		public HandBookV2TeamMapStateBean()
		{
		}

		// Token: 0x0403549D RID: 218269
		[Token(Token = "0x403549D")]
		private const float DEFAULT_ZOOM_VAL = 1.5f;

		// Token: 0x0403549E RID: 218270
		[Token(Token = "0x403549E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2MapRenderProperty _mapProperty;

		// Token: 0x0403549F RID: 218271
		[Token(Token = "0x403549F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2MapZoomProperty _zoomProperty;

		// Token: 0x040354A0 RID: 218272
		[Token(Token = "0x40354A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TrackPointViewProperty _missionTrackPointProperty;

		// Token: 0x040354A1 RID: 218273
		[Token(Token = "0x40354A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandBookV2MapFocusProperty _focusProperty;

		// Token: 0x040354A2 RID: 218274
		[Token(Token = "0x40354A2")]
		[FieldOffset(Offset = "0x38")]
		private HandBookV2ForceMapData m_forceMapData;

		// Token: 0x040354A3 RID: 218275
		[Token(Token = "0x40354A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoomProperty;

		// Token: 0x040354A4 RID: 218276
		[Token(Token = "0x40354A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshFocusPos;

		// Token: 0x040354A5 RID: 218277
		[Token(Token = "0x40354A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040354A6 RID: 218278
		[Token(Token = "0x40354A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x040354A7 RID: 218279
		[Token(Token = "0x40354A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshForceViewModel;

		// Token: 0x040354A8 RID: 218280
		[Token(Token = "0x40354A8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitForceLineViewModel;

		// Token: 0x040354A9 RID: 218281
		[Token(Token = "0x40354A9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitPointLineViewModel;

		// Token: 0x040354AA RID: 218282
		[Token(Token = "0x40354AA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPointPos;

		// Token: 0x040354AB RID: 218283
		[Token(Token = "0x40354AB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
