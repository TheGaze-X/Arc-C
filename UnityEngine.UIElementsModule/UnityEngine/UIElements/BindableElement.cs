using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class BindableElement : VisualElement, IBindable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000008")]
		public IBinding binding
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x58773C0", Offset = "0x5875FC0", VA = "0x1858773C0", Slot = "97")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public string bindingPath
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x5A26460", Offset = "0x5A25060", VA = "0x185A26460", Slot = "98")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5A26410", Offset = "0x5A25010", VA = "0x185A26410")]
		public BindableElement()
		{
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		public new class UxmlFactory : UxmlFactory<BindableElement, BindableElement.UxmlTraits>
		{
			// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x5A3BEE0", Offset = "0x5A3AAE0", VA = "0x185A3BEE0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x5A3C0E0", Offset = "0x5A3ACE0", VA = "0x185A3C0E0")]
			public UxmlTraits()
			{
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x5A3BF60", Offset = "0x5A3AB60", VA = "0x185A3BF60", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[FieldOffset(Offset = "0x70")]
			private UxmlStringAttributeDescription m_PropertyPath;
		}
	}
}
