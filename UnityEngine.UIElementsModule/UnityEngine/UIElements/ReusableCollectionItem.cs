using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	internal class ReusableCollectionItem
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000160")]
		public virtual VisualElement rootElement
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public VisualElement bindableElement
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000162")]
		public ValueAnimation<StyleValues> animator
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00004D28 File Offset: 0x00002F28
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000163")]
		public int index
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00004D40 File Offset: 0x00002F40
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public int id
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00004D58 File Offset: 0x00002F58
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000165")]
		internal bool isDragGhost
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060006B5 RID: 1717 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060006B6 RID: 1718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		public event Action<ReusableCollectionItem> onGeometryChanged
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x5ABC6C0", Offset = "0x5ABB2C0", VA = "0x185ABC6C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x5ABC770", Offset = "0x5ABB370", VA = "0x185ABC770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x5ABC630", Offset = "0x5ABB230", VA = "0x185ABC630")]
		public ReusableCollectionItem()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "5")]
		public virtual void Init(VisualElement item)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5ABC270", Offset = "0x5ABAE70", VA = "0x185ABC270", Slot = "6")]
		public virtual void PreAttachElement()
		{
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5ABC0F0", Offset = "0x5ABACF0", VA = "0x185ABC0F0", Slot = "7")]
		public virtual void DetachElement()
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5ABC490", Offset = "0x5ABB090", VA = "0x185ABC490", Slot = "8")]
		public virtual void SetSelected(bool selected)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x5ABC360", Offset = "0x5ABAF60", VA = "0x185ABC360", Slot = "9")]
		public virtual void SetDragGhost(bool dragGhost)
		{
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x31E2D10", Offset = "0x31E1910", VA = "0x1831E2D10")]
		protected void OnGeometryChanged(GeometryChangedEvent evt)
		{
		}

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x38")]
		protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback;
	}
}
