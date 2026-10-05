using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CE5 RID: 15589
	[Token(Token = "0x2003CE5")]
	public class TuningProductView : DataBinder<TuningProductProperty>
	{
		// Token: 0x060184E5 RID: 99557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184E5")]
		[Address(RVA = "0x10CF7A0", Offset = "0x10CE3A0", VA = "0x1810CF7A0", Slot = "7")]
		public override void OnValueChanged(TuningProductProperty property)
		{
		}

		// Token: 0x060184E6 RID: 99558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184E6")]
		[Address(RVA = "0x10D02D0", Offset = "0x10CEED0", VA = "0x1810D02D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060184E7 RID: 99559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184E7")]
		[Address(RVA = "0x10D0520", Offset = "0x10CF120", VA = "0x1810D0520")]
		private void _PlaySwitchTween(TuningProductViewModel.ProductStatus transInStatus)
		{
		}

		// Token: 0x060184E8 RID: 99560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184E8")]
		[Address(RVA = "0x10D0610", Offset = "0x10CF210", VA = "0x1810D0610")]
		private void _RenderSelectedFrag(TuningProductViewModel model)
		{
		}

		// Token: 0x060184E9 RID: 99561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184E9")]
		[Address(RVA = "0x10D0880", Offset = "0x10CF480", VA = "0x1810D0880")]
		private void _UpdateProductEyeStatus(Act29SideData.Act29SideProductType transToProductType)
		{
		}

		// Token: 0x060184EA RID: 99562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184EA")]
		[Address(RVA = "0x10D0760", Offset = "0x10CF360", VA = "0x1810D0760")]
		private void _ResetEyeStatus()
		{
		}

		// Token: 0x060184EB RID: 99563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184EB")]
		[Address(RVA = "0x10D0210", Offset = "0x10CEE10", VA = "0x1810D0210")]
		public void TransToPlayState()
		{
		}

		// Token: 0x060184EC RID: 99564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184EC")]
		[Address(RVA = "0x10D0180", Offset = "0x10CED80", VA = "0x1810D0180")]
		public void TransToBagState()
		{
		}

		// Token: 0x060184ED RID: 99565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184ED")]
		[Address(RVA = "0x10D09E0", Offset = "0x10CF5E0", VA = "0x1810D09E0")]
		public TuningProductView()
		{
		}

		// Token: 0x0401DAF7 RID: 121591
		[Token(Token = "0x401DAF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TuningProductFragSelectView _fragSelectView;

		// Token: 0x0401DAF8 RID: 121592
		[Token(Token = "0x401DAF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TuningProductOrcheSelectView _orcheSelectView;

		// Token: 0x0401DAF9 RID: 121593
		[Token(Token = "0x401DAF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TuningProductCircleView _circleView;

		// Token: 0x0401DAFA RID: 121594
		[Token(Token = "0x401DAFA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<TuningProductSlotImageItemView> _fragSelectedSlotItemViewList;

		// Token: 0x0401DAFB RID: 121595
		[Token(Token = "0x401DAFB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _switchAnimLocation;

		// Token: 0x0401DAFC RID: 121596
		[Token(Token = "0x401DAFC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<TuningProductView.ProductEyeTypeToView> _tuningProductEyeViewList;

		// Token: 0x0401DAFD RID: 121597
		[Token(Token = "0x401DAFD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TuningProductSlotGroupItemView _tuningProductClosedEyeView;

		// Token: 0x0401DAFE RID: 121598
		[Token(Token = "0x401DAFE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _playBtnObj;

		// Token: 0x0401DAFF RID: 121599
		[Token(Token = "0x401DAFF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _playLock;

		// Token: 0x0401DB00 RID: 121600
		[Token(Token = "0x401DB00")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _playBtn;

		// Token: 0x0401DB01 RID: 121601
		[Token(Token = "0x401DB01")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _haveNewForm;

		// Token: 0x0401DB02 RID: 121602
		[Token(Token = "0x401DB02")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _circleColor;

		// Token: 0x0401DB03 RID: 121603
		[Token(Token = "0x401DB03")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<string> onSelectOrche;

		// Token: 0x0401DB04 RID: 121604
		[Token(Token = "0x401DB04")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0401DB05 RID: 121605
		[Token(Token = "0x401DB05")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401DB06 RID: 121606
		[Token(Token = "0x401DB06")]
		[FieldOffset(Offset = "0xB0")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0401DB07 RID: 121607
		[Token(Token = "0x401DB07")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x0401DB08 RID: 121608
		[Token(Token = "0x401DB08")]
		[FieldOffset(Offset = "0xC0")]
		private string m_cachedSelectFormSegmentId;

		// Token: 0x0401DB09 RID: 121609
		[Token(Token = "0x401DB09")]
		[FieldOffset(Offset = "0xC8")]
		private int m_cachedSegmentNum;

		// Token: 0x0401DB0A RID: 121610
		[Token(Token = "0x401DB0A")]
		[FieldOffset(Offset = "0xCC")]
		private float m_cachedSegmentRotateSecond;

		// Token: 0x0401DB0B RID: 121611
		[Token(Token = "0x401DB0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401DB0C RID: 121612
		[Token(Token = "0x401DB0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DB0D RID: 121613
		[Token(Token = "0x401DB0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlaySwitchTween;

		// Token: 0x0401DB0E RID: 121614
		[Token(Token = "0x401DB0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderSelectedFrag;

		// Token: 0x0401DB0F RID: 121615
		[Token(Token = "0x401DB0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateProductEyeStatus;

		// Token: 0x0401DB10 RID: 121616
		[Token(Token = "0x401DB10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ResetEyeStatus;

		// Token: 0x0401DB11 RID: 121617
		[Token(Token = "0x401DB11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TransToPlayState;

		// Token: 0x0401DB12 RID: 121618
		[Token(Token = "0x401DB12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TransToBagState;

		// Token: 0x0401DB13 RID: 121619
		[Token(Token = "0x401DB13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CE6 RID: 15590
		[Token(Token = "0x2003CE6")]
		[Serializable]
		public struct ProductEyeTypeToView : IHotfixable
		{
			// Token: 0x0401DB14 RID: 121620
			[Token(Token = "0x401DB14")]
			[FieldOffset(Offset = "0x0")]
			public Act29SideData.Act29SideProductType productType;

			// Token: 0x0401DB15 RID: 121621
			[Token(Token = "0x401DB15")]
			[FieldOffset(Offset = "0x8")]
			public TuningProductSlotEyeView eyeView;
		}
	}
}
