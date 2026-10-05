using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F56 RID: 24406
	[Token(Token = "0x2005F56")]
	public class CharacterInfoIllustSpreadPanel : DataBinder<CharacterIllustViewProperty>
	{
		// Token: 0x1700538A RID: 21386
		// (get) Token: 0x06023563 RID: 144739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700538A")]
		protected RectTransform wrapperRectTrans
		{
			[Token(Token = "0x6023563")]
			[Address(RVA = "0x1DDA0A0", Offset = "0x1DD8CA0", VA = "0x181DDA0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023564 RID: 144740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023564")]
		[Address(RVA = "0x1DD9B10", Offset = "0x1DD8710", VA = "0x181DD9B10")]
		[Inspect]
		private void _RecordWrapperStandardStatus()
		{
		}

		// Token: 0x06023565 RID: 144741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023565")]
		[Address(RVA = "0x1DD8FF0", Offset = "0x1DD7BF0", VA = "0x181DD8FF0")]
		public void NotifySpreadIllust()
		{
		}

		// Token: 0x06023566 RID: 144742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023566")]
		[Address(RVA = "0x1DD9120", Offset = "0x1DD7D20", VA = "0x181DD9120")]
		public void NotifyUnspreadIllust(bool withTween)
		{
		}

		// Token: 0x06023567 RID: 144743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023567")]
		[Address(RVA = "0x1DD9300", Offset = "0x1DD7F00", VA = "0x181DD9300", Slot = "7")]
		public override void OnValueChanged(CharacterIllustViewProperty property)
		{
		}

		// Token: 0x06023568 RID: 144744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023568")]
		[Address(RVA = "0x1DD9480", Offset = "0x1DD8080", VA = "0x181DD9480")]
		private void Start()
		{
		}

		// Token: 0x06023569 RID: 144745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023569")]
		[Address(RVA = "0x1DD98F0", Offset = "0x1DD84F0", VA = "0x181DD98F0")]
		private void _OnScaleChanged(float scale)
		{
		}

		// Token: 0x0602356A RID: 144746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356A")]
		[Address(RVA = "0x1DD9A70", Offset = "0x1DD8670", VA = "0x181DD9A70")]
		private void _OnScaleStart(float scale)
		{
		}

		// Token: 0x0602356B RID: 144747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356B")]
		[Address(RVA = "0x1DD99D0", Offset = "0x1DD85D0", VA = "0x181DD99D0")]
		private void _OnScaleEnd(float scale)
		{
		}

		// Token: 0x0602356C RID: 144748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356C")]
		[Address(RVA = "0x1DD96A0", Offset = "0x1DD82A0", VA = "0x181DD96A0")]
		private void _CalcInitWrapperSize()
		{
		}

		// Token: 0x0602356D RID: 144749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356D")]
		[Address(RVA = "0x1DD9BC0", Offset = "0x1DD87C0", VA = "0x181DD9BC0")]
		private void _ResetIllustPosTween()
		{
		}

		// Token: 0x0602356E RID: 144750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356E")]
		[Address(RVA = "0x1DD9E00", Offset = "0x1DD8A00", VA = "0x181DD9E00")]
		private void _ResetIllustPos()
		{
		}

		// Token: 0x0602356F RID: 144751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602356F")]
		[Address(RVA = "0x1DD9FD0", Offset = "0x1DD8BD0", VA = "0x181DD9FD0")]
		public CharacterInfoIllustSpreadPanel()
		{
		}

		// Token: 0x04030C3C RID: 199740
		[Token(Token = "0x4030C3C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 DEFAULT_NORMALIZE_POS;

		// Token: 0x04030C3D RID: 199741
		[Token(Token = "0x4030C3D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 STANDARD_ILLUST_SIZE;

		// Token: 0x04030C3E RID: 199742
		[Token(Token = "0x4030C3E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2 ILLUST_PADDING;

		// Token: 0x04030C3F RID: 199743
		[Token(Token = "0x4030C3F")]
		private const float DEFAULT_SCALE = 1f;

		// Token: 0x04030C40 RID: 199744
		[Token(Token = "0x4030C40")]
		private const float TWEEN_DURATION = 0.23f;

		// Token: 0x04030C41 RID: 199745
		[Token(Token = "0x4030C41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIWrappedScrollRect _scrollContainer;

		// Token: 0x04030C42 RID: 199746
		[Token(Token = "0x4030C42")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UITouchZoom _panelTouchZoom;

		// Token: 0x04030C43 RID: 199747
		[Token(Token = "0x4030C43")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x04030C44 RID: 199748
		[Token(Token = "0x4030C44")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Wrapper")]
		private Vector2 _wrapperStandardPos;

		// Token: 0x04030C45 RID: 199749
		[Token(Token = "0x4030C45")]
		[FieldOffset(Offset = "0x40")]
		private Vector2 m_initWrapperSize;

		// Token: 0x04030C46 RID: 199750
		[Token(Token = "0x4030C46")]
		[FieldOffset(Offset = "0x48")]
		private RectTransform m_wrapperRectTrans;

		// Token: 0x04030C47 RID: 199751
		[Token(Token = "0x4030C47")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04030C48 RID: 199752
		[Token(Token = "0x4030C48")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_finalScrollPos;

		// Token: 0x04030C49 RID: 199753
		[Token(Token = "0x4030C49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_wrapperRectTrans;

		// Token: 0x04030C4A RID: 199754
		[Token(Token = "0x4030C4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RecordWrapperStandardStatus;

		// Token: 0x04030C4B RID: 199755
		[Token(Token = "0x4030C4B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifySpreadIllust;

		// Token: 0x04030C4C RID: 199756
		[Token(Token = "0x4030C4C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUnspreadIllust;

		// Token: 0x04030C4D RID: 199757
		[Token(Token = "0x4030C4D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030C4E RID: 199758
		[Token(Token = "0x4030C4E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04030C4F RID: 199759
		[Token(Token = "0x4030C4F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnScaleChanged;

		// Token: 0x04030C50 RID: 199760
		[Token(Token = "0x4030C50")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnScaleStart;

		// Token: 0x04030C51 RID: 199761
		[Token(Token = "0x4030C51")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnScaleEnd;

		// Token: 0x04030C52 RID: 199762
		[Token(Token = "0x4030C52")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CalcInitWrapperSize;

		// Token: 0x04030C53 RID: 199763
		[Token(Token = "0x4030C53")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetIllustPosTween;

		// Token: 0x04030C54 RID: 199764
		[Token(Token = "0x4030C54")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetIllustPos;

		// Token: 0x04030C55 RID: 199765
		[Token(Token = "0x4030C55")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
