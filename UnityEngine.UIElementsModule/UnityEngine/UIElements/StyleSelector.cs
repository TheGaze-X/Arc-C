using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	[Serializable]
	internal class StyleSelector
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060010D0 RID: 4304 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000449")]
		public StyleSelectorPart[] parts
		{
			[Token(Token = "0x60010D0")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60010D1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			internal set
			{
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x00009288 File Offset: 0x00007488
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044A")]
		public StyleSelectorRelationship previousRelationship
		{
			[Token(Token = "0x60010D2")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return StyleSelectorRelationship.None;
			}
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			internal set
			{
			}
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x5B220A0", Offset = "0x5B20CA0", VA = "0x185B220A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x5B22210", Offset = "0x5B20E10", VA = "0x185B22210")]
		public StyleSelector()
		{
		}

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StyleSelectorPart[] m_Parts;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StyleSelectorRelationship m_PreviousRelationship;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x1C")]
		internal int pseudoStateMask;

		// Token: 0x0400089D RID: 2205
		[Token(Token = "0x400089D")]
		[FieldOffset(Offset = "0x20")]
		internal int negatedPseudoStateMask;
	}
}
