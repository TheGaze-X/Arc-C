using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	[Serializable]
	internal class StyleRule
	{
		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000448")]
		public StyleProperty[] properties
		{
			[Token(Token = "0x60010CE")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StyleRule()
		{
		}

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private StyleProperty[] m_Properties;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal int line;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		internal int customPropertiesCount;
	}
}
