using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066F7 RID: 26359
	[Token(Token = "0x20066F7")]
	public class HandBookV2MapCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025D50 RID: 154960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025D50")]
		[Address(RVA = "0x20C4280", Offset = "0x20C2E80", VA = "0x1820C4280")]
		public HandBookV2GroupCharViewModel GetViewModel()
		{
			return null;
		}

		// Token: 0x06025D51 RID: 154961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D51")]
		[Address(RVA = "0x20C4A50", Offset = "0x20C3650", VA = "0x1820C4A50")]
		public void UpdateTrackPoint()
		{
		}

		// Token: 0x06025D52 RID: 154962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D52")]
		[Address(RVA = "0x20C46A0", Offset = "0x20C32A0", VA = "0x1820C46A0")]
		public void RenderView(HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025D53 RID: 154963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D53")]
		[Address(RVA = "0x20C4410", Offset = "0x20C3010", VA = "0x1820C4410")]
		public void RefreshView(HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025D54 RID: 154964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D54")]
		[Address(RVA = "0x20C4210", Offset = "0x20C2E10", VA = "0x1820C4210")]
		public void ClearMoreLine()
		{
		}

		// Token: 0x06025D55 RID: 154965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D55")]
		[Address(RVA = "0x20C4100", Offset = "0x20C2D00", VA = "0x1820C4100")]
		public void ApplyMoreLine()
		{
		}

		// Token: 0x06025D56 RID: 154966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D56")]
		[Address(RVA = "0x20C42E0", Offset = "0x20C2EE0", VA = "0x1820C42E0")]
		public void OnClick()
		{
		}

		// Token: 0x06025D57 RID: 154967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D57")]
		[Address(RVA = "0x20C4840", Offset = "0x20C3440", VA = "0x1820C4840")]
		public void SetSelect(bool isSelect)
		{
		}

		// Token: 0x06025D58 RID: 154968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D58")]
		[Address(RVA = "0x20C4370", Offset = "0x20C2F70", VA = "0x1820C4370")]
		public void OnHide()
		{
		}

		// Token: 0x06025D59 RID: 154969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025D59")]
		[Address(RVA = "0x20C4B00", Offset = "0x20C3700", VA = "0x1820C4B00")]
		public HandBookV2MapCardView()
		{
		}

		// Token: 0x040352E7 RID: 217831
		[Token(Token = "0x40352E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _havePart;

		// Token: 0x040352E8 RID: 217832
		[Token(Token = "0x40352E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _dontHavePart;

		// Token: 0x040352E9 RID: 217833
		[Token(Token = "0x40352E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _charHeadIcon;

		// Token: 0x040352EA RID: 217834
		[Token(Token = "0x40352EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x040352EB RID: 217835
		[Token(Token = "0x40352EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _numberShow;

		// Token: 0x040352EC RID: 217836
		[Token(Token = "0x40352EC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _selected;

		// Token: 0x040352ED RID: 217837
		[Token(Token = "0x40352ED")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _haveMoreLineLeft;

		// Token: 0x040352EE RID: 217838
		[Token(Token = "0x40352EE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _haveMoreLineRight;

		// Token: 0x040352EF RID: 217839
		[Token(Token = "0x40352EF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _updatedTrackPoint;

		// Token: 0x040352F0 RID: 217840
		[Token(Token = "0x40352F0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _initPos;

		// Token: 0x040352F1 RID: 217841
		[Token(Token = "0x40352F1")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _selectedPos;

		// Token: 0x040352F2 RID: 217842
		[Token(Token = "0x40352F2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _updateFlagCanvasGroup;

		// Token: 0x040352F3 RID: 217843
		[Token(Token = "0x40352F3")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public UIHandBookCardEvent clickEvent;

		// Token: 0x040352F4 RID: 217844
		[Token(Token = "0x40352F4")]
		private const float DURATION_PARAM = 1f;

		// Token: 0x040352F5 RID: 217845
		[Token(Token = "0x40352F5")]
		[FieldOffset(Offset = "0x78")]
		private TrackPointViewProperty m_updatedTrackPointProperty;

		// Token: 0x040352F6 RID: 217846
		[Token(Token = "0x40352F6")]
		[FieldOffset(Offset = "0x80")]
		private HandBookV2GroupCharViewModel m_viewModel;

		// Token: 0x040352F7 RID: 217847
		[Token(Token = "0x40352F7")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_cacheTween;

		// Token: 0x040352F8 RID: 217848
		[Token(Token = "0x40352F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x040352F9 RID: 217849
		[Token(Token = "0x40352F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateTrackPoint;

		// Token: 0x040352FA RID: 217850
		[Token(Token = "0x40352FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040352FB RID: 217851
		[Token(Token = "0x40352FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x040352FC RID: 217852
		[Token(Token = "0x40352FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearMoreLine;

		// Token: 0x040352FD RID: 217853
		[Token(Token = "0x40352FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyMoreLine;

		// Token: 0x040352FE RID: 217854
		[Token(Token = "0x40352FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040352FF RID: 217855
		[Token(Token = "0x40352FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelect;

		// Token: 0x04035300 RID: 217856
		[Token(Token = "0x4035300")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x04035301 RID: 217857
		[Token(Token = "0x4035301")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
