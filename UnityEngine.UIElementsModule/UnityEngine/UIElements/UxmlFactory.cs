using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	public class UxmlFactory<TCreatedType, TTraits> : IUxmlFactory where TCreatedType : VisualElement, new() where TTraits : UxmlTraits, new()
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BA")]
		protected UxmlFactory()
		{
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000475")]
		public virtual string uxmlName
		{
			[Token(Token = "0x60011BB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000476")]
		public virtual string uxmlNamespace
		{
			[Token(Token = "0x60011BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000477")]
		public virtual string uxmlQualifiedName
		{
			[Token(Token = "0x60011BD")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x60011BE")]
		public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
		{
			return default(bool);
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60011BF")]
		public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc)
		{
			return null;
		}

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x0")]
		internal TTraits m_Traits;
	}
}
