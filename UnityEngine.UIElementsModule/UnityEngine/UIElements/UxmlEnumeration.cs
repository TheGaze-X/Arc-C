using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	public class UxmlEnumeration : UxmlTypeRestriction
	{
		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000478")]
		public IEnumerable<string> values
		{
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011C4")]
			[Address(RVA = "0x5B2D830", Offset = "0x5B2C430", VA = "0x185B2D830")]
			set
			{
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x5B2D640", Offset = "0x5B2C240", VA = "0x185B2D640", Slot = "5")]
		public override bool Equals(UxmlTypeRestriction other)
		{
			return default(bool);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x5B2D7A0", Offset = "0x5B2C3A0", VA = "0x185B2D7A0")]
		public UxmlEnumeration()
		{
		}

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_Values;
	}
}
