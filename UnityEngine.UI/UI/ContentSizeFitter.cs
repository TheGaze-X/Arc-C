using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[AddComponentMenu("Layout/Content Size Fitter", 141)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B4")]
		public ContentSizeFitter.FitMode horizontalFit
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return ContentSizeFitter.FitMode.Unconstrained;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x5B56730", Offset = "0x5B55330", VA = "0x185B56730")]
			set
			{
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B5")]
		public ContentSizeFitter.FitMode verticalFit
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return ContentSizeFitter.FitMode.Unconstrained;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x5B56790", Offset = "0x5B55390", VA = "0x185B56790")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B6")]
		private RectTransform rectTransform
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x5B56690", Offset = "0x5B55290", VA = "0x185B56690")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		protected ContentSizeFitter()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x5B56410", Offset = "0x5B55010", VA = "0x185B56410", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x5B56390", Offset = "0x5B54F90", VA = "0x185B56390", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x5B56430", Offset = "0x5B55030", VA = "0x185B56430", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x5B562B0", Offset = "0x5B54EB0", VA = "0x185B562B0")]
		private void HandleSelfFittingAlongAxis(int axis)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x5B564D0", Offset = "0x5B550D0", VA = "0x185B564D0", Slot = "19")]
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x5B565B0", Offset = "0x5B551B0", VA = "0x185B565B0", Slot = "20")]
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x5B56440", Offset = "0x5B55040", VA = "0x185B56440")]
		protected void SetDirty()
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected ContentSizeFitter.FitMode m_HorizontalFit;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected ContentSizeFitter.FitMode m_VerticalFit;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0200003F RID: 63
		[Token(Token = "0x200003F")]
		public enum FitMode
		{
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			Unconstrained,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			MinSize,
			// Token: 0x04000162 RID: 354
			[Token(Token = "0x4000162")]
			PreferredSize
		}
	}
}
