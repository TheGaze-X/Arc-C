using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[AddComponentMenu("Layout/Layout Element", 140)]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteAlways]
	public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CD")]
		public virtual bool ignoreLayout
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "27")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x5B638E0", Offset = "0x5B624E0", VA = "0x185B638E0", Slot = "28")]
			set
			{
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00003120 File Offset: 0x00001320
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CE")]
		public virtual float minWidth
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660", Slot = "31")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x5B63A00", Offset = "0x5B62600", VA = "0x185B63A00", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00003138 File Offset: 0x00001338
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CF")]
		public virtual float minHeight
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40", Slot = "33")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x5B639A0", Offset = "0x5B625A0", VA = "0x185B639A0", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D0")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0", Slot = "35")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x5B63AC0", Offset = "0x5B626C0", VA = "0x185B63AC0", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D1")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500", Slot = "37")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x5B63A60", Offset = "0x5B62660", VA = "0x185B63A60", Slot = "38")]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D2")]
		public virtual float flexibleWidth
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70", Slot = "39")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x5B63880", Offset = "0x5B62480", VA = "0x185B63880", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D3")]
		public virtual float flexibleHeight
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70", Slot = "41")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x5B63820", Offset = "0x5B62420", VA = "0x185B63820", Slot = "42")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000031B0 File Offset: 0x000013B0
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D4")]
		public virtual int layoutPriority
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x5B63940", Offset = "0x5B62540", VA = "0x185B63940", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x5B637E0", Offset = "0x5B623E0", VA = "0x185B637E0")]
		protected LayoutElement()
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x5B63710", Offset = "0x5B62310", VA = "0x185B63710", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x5B636E0", Offset = "0x5B622E0", VA = "0x185B636E0", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x5B636F0", Offset = "0x5B622F0", VA = "0x185B636F0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x5B636E0", Offset = "0x5B622E0", VA = "0x185B636E0", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x5B636E0", Offset = "0x5B622E0", VA = "0x185B636E0", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x5B63730", Offset = "0x5B62330", VA = "0x185B63730")]
		protected void SetDirty()
		{
		}

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IgnoreLayout;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_MinWidth;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MinHeight;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_PreferredWidth;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_PreferredHeight;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_FlexibleWidth;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FlexibleHeight;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int m_LayoutPriority;
	}
}
