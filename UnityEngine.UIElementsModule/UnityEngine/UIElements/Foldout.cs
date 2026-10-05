using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	public class Foldout : BindableElement, INotifyValueChanged<bool>
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x170001A4")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x5AAFE90", Offset = "0x5AAEA90", VA = "0x185AAFE90", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		public string text
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x5AAFEB0", Offset = "0x5AAEAB0", VA = "0x185AAFEB0")]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00005040 File Offset: 0x00003240
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A6")]
		public bool value
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x5AAFEA0", Offset = "0x5AAEAA0", VA = "0x185AAFEA0", Slot = "99")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x5AAFFE0", Offset = "0x5AAEBE0", VA = "0x185AAFFE0", Slot = "100")]
			set
			{
			}
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x5AAF6E0", Offset = "0x5AAE2E0", VA = "0x185AAF6E0", Slot = "101")]
		public void SetValueWithoutNotify(bool newValue)
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x5AAF690", Offset = "0x5AAE290", VA = "0x185AAF690", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x5AAFAF0", Offset = "0x5AAE6F0", VA = "0x185AAFAF0")]
		public Foldout()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x5AAF4C0", Offset = "0x5AAE0C0", VA = "0x185AAF4C0")]
		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x3C0")]
		private Toggle m_Toggle;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x3C8")]
		private VisualElement m_Container;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x3D0")]
		[SerializeField]
		private bool m_Value;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ussClassName;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string toggleUssClassName;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string contentUssClassName;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string inputUssClassName;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string checkmarkUssClassName;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string textUssClassName;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly string ussFoldoutDepthClassName;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x38")]
		internal static readonly int ussFoldoutMaxDepth;

		// Token: 0x0200010B RID: 267
		[Token(Token = "0x200010B")]
		public new class UxmlFactory : UxmlFactory<Foldout, Foldout.UxmlTraits>
		{
			// Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x5ABD420", Offset = "0x5ABC020", VA = "0x185ABD420")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200010C RID: 268
		[Token(Token = "0x200010C")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x5ABDD70", Offset = "0x5ABC970", VA = "0x185ABDD70", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x5ABEBA0", Offset = "0x5ABD7A0", VA = "0x185ABEBA0")]
			public UxmlTraits()
			{
			}

			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x40003FA")]
			[FieldOffset(Offset = "0x78")]
			private UxmlStringAttributeDescription m_Text;

			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x40003FB")]
			[FieldOffset(Offset = "0x80")]
			private UxmlBoolAttributeDescription m_Value;
		}
	}
}
