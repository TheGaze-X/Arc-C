using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D5")]
		public RectOffset padding
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x5B64FA0", Offset = "0x5B63BA0", VA = "0x185B64FA0")]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D6")]
		public TextAnchor childAlignment
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return TextAnchor.UpperLeft;
			}
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x5B64F50", Offset = "0x5B63B50", VA = "0x185B64F50")]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x5B64EB0", Offset = "0x5B63AB0", VA = "0x185B64EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		protected List<RectTransform> rectChildren
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x5B63B20", Offset = "0x5B62720", VA = "0x185B63B20", Slot = "28")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060002FC RID: 764
		[Token(Token = "0x60002FC")]
		public abstract void CalculateLayoutInputVertical();

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x170000D9")]
		public virtual float minWidth
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x59BA3E0", Offset = "0x59B8FE0", VA = "0x1859BA3E0", Slot = "30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x170000DA")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x59BA380", Offset = "0x59B8F80", VA = "0x1859BA380", Slot = "31")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060002FF RID: 767 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x170000DB")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x59CF660", Offset = "0x59CE260", VA = "0x1859CF660", Slot = "32")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x170000DC")]
		public virtual float minHeight
		{
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x59BA3D0", Offset = "0x59B8FD0", VA = "0x1859BA3D0", Slot = "33")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x170000DD")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x59BA390", Offset = "0x59B8F90", VA = "0x1859BA390", Slot = "34")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x170000DE")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x59CF670", Offset = "0x59CE270", VA = "0x1859CF670", Slot = "35")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x170000DF")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "36")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000304 RID: 772
		[Token(Token = "0x6000304")]
		public abstract void SetLayoutHorizontal();

		// Token: 0x06000305 RID: 773
		[Token(Token = "0x6000305")]
		public abstract void SetLayoutVertical();

		// Token: 0x06000306 RID: 774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x5B64BC0", Offset = "0x5B637C0", VA = "0x185B64BC0")]
		protected LayoutGroup()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x5B64220", Offset = "0x5B62E20", VA = "0x185B64220", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x5B641A0", Offset = "0x5B62DA0", VA = "0x185B641A0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x5B64190", Offset = "0x5B62D90", VA = "0x185B64190", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x5B64170", Offset = "0x5B62D70", VA = "0x185B64170")]
		protected float GetTotalMinSize(int axis)
		{
			return 0f;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x5B64180", Offset = "0x5B62D80", VA = "0x185B64180")]
		protected float GetTotalPreferredSize(int axis)
		{
			return 0f;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x5B64160", Offset = "0x5B62D60", VA = "0x185B64160")]
		protected float GetTotalFlexibleSize(int axis)
		{
			return 0f;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x5B63FD0", Offset = "0x5B62BD0", VA = "0x185B63FD0")]
		protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding)
		{
			return 0f;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x5B63F80", Offset = "0x5B62B80", VA = "0x185B63F80")]
		protected float GetAlignmentOnAxis(int axis)
		{
			return 0f;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x5B64B50", Offset = "0x5B63750", VA = "0x185B64B50")]
		protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x5B648C0", Offset = "0x5B634C0", VA = "0x185B648C0")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5B64670", Offset = "0x5B63270", VA = "0x185B64670")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor)
		{
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x5B64960", Offset = "0x5B63560", VA = "0x185B64960")]
		protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x5B64380", Offset = "0x5B62F80", VA = "0x185B64380")]
		protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x170000E0")]
		private bool isRootLayoutGroup
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0x5B64D80", Offset = "0x5B63980", VA = "0x185B64D80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x5B64240", Offset = "0x5B62E40", VA = "0x185B64240", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5B64190", Offset = "0x5B62D90", VA = "0x185B64190", Slot = "39")]
		protected virtual void OnTransformChildrenChanged()
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000317")]
		protected void SetProperty<T>(ref T currentValue, T newValue)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5B64A10", Offset = "0x5B63610", VA = "0x185B64A10")]
		protected void SetDirty()
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x5B63F00", Offset = "0x5B62B00", VA = "0x185B63F00")]
		private IEnumerator DelayedSetDirty(RectTransform rectTransform)
		{
			return null;
		}

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected RectOffset m_Padding;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextAnchor m_ChildAlignment;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x30")]
		protected DrivenRectTransformTracker m_Tracker;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 m_TotalMinSize;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 m_TotalPreferredSize;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 m_TotalFlexibleSize;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private List<RectTransform> m_RectChildren;
	}
}
