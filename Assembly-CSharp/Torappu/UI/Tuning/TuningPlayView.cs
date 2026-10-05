using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CCC RID: 15564
	[Token(Token = "0x2003CCC")]
	public class TuningPlayView : DataBinder<TuningPlayProperty>
	{
		// Token: 0x06018440 RID: 99392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018440")]
		[Address(RVA = "0x10C7D90", Offset = "0x10C6990", VA = "0x1810C7D90", Slot = "7")]
		public override void OnValueChanged(TuningPlayProperty property)
		{
		}

		// Token: 0x06018441 RID: 99393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018441")]
		[Address(RVA = "0x10C8500", Offset = "0x10C7100", VA = "0x1810C8500")]
		private void _RenderCircle(TuningPlayViewModel model)
		{
		}

		// Token: 0x06018442 RID: 99394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018442")]
		[Address(RVA = "0x10C89D0", Offset = "0x10C75D0", VA = "0x1810C89D0")]
		private void _RenderEye(TuningPlayViewModel model)
		{
		}

		// Token: 0x06018443 RID: 99395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018443")]
		[Address(RVA = "0x10C8B70", Offset = "0x10C7770", VA = "0x1810C8B70")]
		private void _ResetEye()
		{
		}

		// Token: 0x06018444 RID: 99396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018444")]
		[Address(RVA = "0x10C8C90", Offset = "0x10C7890", VA = "0x1810C8C90")]
		private void _SetOrcheListDisplayType(TuningPlayViewModel.SelectOrcheStatus status)
		{
		}

		// Token: 0x06018445 RID: 99397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018445")]
		[Address(RVA = "0x10C8450", Offset = "0x10C7050", VA = "0x1810C8450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018446 RID: 99398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018446")]
		[Address(RVA = "0x10C7D00", Offset = "0x10C6900", VA = "0x1810C7D00")]
		public void OnClickBackToProductState()
		{
		}

		// Token: 0x06018447 RID: 99399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018447")]
		[Address(RVA = "0x10C8DC0", Offset = "0x10C79C0", VA = "0x1810C8DC0")]
		public TuningPlayView()
		{
		}

		// Token: 0x0401D9A8 RID: 121256
		[Token(Token = "0x401D9A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("OrcheList")]
		private TuningProductPagerView _orchePagerView;

		// Token: 0x0401D9A9 RID: 121257
		[Token(Token = "0x401D9A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("OrcheList")]
		private CanvasGroup _orcheListGroup;

		// Token: 0x0401D9AA RID: 121258
		[Token(Token = "0x401D9AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("OrcheList")]
		private float _canSelectAlpha;

		// Token: 0x0401D9AB RID: 121259
		[Token(Token = "0x401D9AB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("OrcheList")]
		private float _cannotSelectAlpha;

		// Token: 0x0401D9AC RID: 121260
		[Token(Token = "0x401D9AC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("OrcheList")]
		private float _hiddenAlpha;

		// Token: 0x0401D9AD RID: 121261
		[Token(Token = "0x401D9AD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("OrcheList")]
		private float _orcheListFadeDuration;

		// Token: 0x0401D9AE RID: 121262
		[Token(Token = "0x401D9AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Circle")]
		private List<TuningProductOrcheSelectView.OrcheTypeToFormEffectView> _orcheIdToFormEffectViewList;

		// Token: 0x0401D9AF RID: 121263
		[Token(Token = "0x401D9AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Circle")]
		private TuningProductCircleView _circleView;

		// Token: 0x0401D9B0 RID: 121264
		[Token(Token = "0x401D9B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Circle")]
		private Color _circleColor;

		// Token: 0x0401D9B1 RID: 121265
		[Token(Token = "0x401D9B1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<TuningProductView.ProductEyeTypeToView> _tuningProductEyeViewList;

		// Token: 0x0401D9B2 RID: 121266
		[Token(Token = "0x401D9B2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _tintImg;

		// Token: 0x0401D9B3 RID: 121267
		[Token(Token = "0x401D9B3")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onSelectOrche;

		// Token: 0x0401D9B4 RID: 121268
		[Token(Token = "0x401D9B4")]
		[FieldOffset(Offset = "0x78")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401D9B5 RID: 121269
		[Token(Token = "0x401D9B5")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401D9B6 RID: 121270
		[Token(Token = "0x401D9B6")]
		[FieldOffset(Offset = "0x8C")]
		private int m_cachedEyeShowSequenceNum;

		// Token: 0x0401D9B7 RID: 121271
		[Token(Token = "0x401D9B7")]
		[FieldOffset(Offset = "0x90")]
		private int m_cachedEnterSequenceNum;

		// Token: 0x0401D9B8 RID: 121272
		[Token(Token = "0x401D9B8")]
		[FieldOffset(Offset = "0x98")]
		private string m_cachedSelectFormSegmentId;

		// Token: 0x0401D9B9 RID: 121273
		[Token(Token = "0x401D9B9")]
		[FieldOffset(Offset = "0xA0")]
		private int m_cachedSegmentNum;

		// Token: 0x0401D9BA RID: 121274
		[Token(Token = "0x401D9BA")]
		[FieldOffset(Offset = "0xA4")]
		private float m_cachedSegmentRotateSecond;

		// Token: 0x0401D9BB RID: 121275
		[Token(Token = "0x401D9BB")]
		[FieldOffset(Offset = "0xA8")]
		private TuningPlayViewModel.SelectOrcheStatus m_cachedStatus;

		// Token: 0x0401D9BC RID: 121276
		[Token(Token = "0x401D9BC")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_orcheListFadeTween;

		// Token: 0x0401D9BD RID: 121277
		[Token(Token = "0x401D9BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D9BE RID: 121278
		[Token(Token = "0x401D9BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCircle;

		// Token: 0x0401D9BF RID: 121279
		[Token(Token = "0x401D9BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEye;

		// Token: 0x0401D9C0 RID: 121280
		[Token(Token = "0x401D9C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ResetEye;

		// Token: 0x0401D9C1 RID: 121281
		[Token(Token = "0x401D9C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetOrcheListDisplayType;

		// Token: 0x0401D9C2 RID: 121282
		[Token(Token = "0x401D9C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401D9C3 RID: 121283
		[Token(Token = "0x401D9C3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickBackToProductState;

		// Token: 0x0401D9C4 RID: 121284
		[Token(Token = "0x401D9C4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
