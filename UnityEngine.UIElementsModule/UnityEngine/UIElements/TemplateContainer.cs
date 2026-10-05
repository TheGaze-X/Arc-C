using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public class TemplateContainer : BindableElement
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000122")]
		public string templateId
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x5A8FDB0", Offset = "0x5A8E9B0", VA = "0x185A8FDB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x5A8FDC0", Offset = "0x5A8E9C0", VA = "0x185A8FDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		internal VisualTreeAsset templateSource
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x5A8FDD0", Offset = "0x5A8E9D0", VA = "0x185A8FDD0")]
			set
			{
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x5A8FD60", Offset = "0x5A8E960", VA = "0x185A8FD60")]
		public TemplateContainer()
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x5A8FD10", Offset = "0x5A8E910", VA = "0x185A8FD10")]
		public TemplateContainer(string templateId)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000124")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x5A8FDA0", Offset = "0x5A8E9A0", VA = "0x185A8FDA0", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x5A8FD00", Offset = "0x5A8E900", VA = "0x185A8FD00")]
		internal void SetContentContainer(VisualElement content)
		{
		}

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x3C8")]
		private VisualElement m_ContentContainer;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x3D0")]
		private VisualTreeAsset m_TemplateSource;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		public new class UxmlFactory : UxmlFactory<TemplateContainer, TemplateContainer.UxmlTraits>
		{
			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000125")]
			public override string uxmlName
			{
				[Token(Token = "0x60004A1")]
				[Address(RVA = "0x5A9A720", Offset = "0x5A99320", VA = "0x185A9A720", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x17000126")]
			public override string uxmlQualifiedName
			{
				[Token(Token = "0x60004A2")]
				[Address(RVA = "0x5A9A750", Offset = "0x5A99350", VA = "0x185A9A750", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x5A9A6E0", Offset = "0x5A992E0", VA = "0x185A9A6E0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x5A9A7F0", Offset = "0x5A993F0", VA = "0x185A9A7F0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x5A9B020", Offset = "0x5A99C20", VA = "0x185A9B020")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x78")]
			private UxmlStringAttributeDescription m_Template;
		}
	}
}
