using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	[Serializable]
	internal struct StyleValueHandle
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x000094E0 File Offset: 0x000076E0
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		public StyleValueType valueType
		{
			[Token(Token = "0x600110C")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
			get
			{
				return StyleValueType.Invalid;
			}
			[Token(Token = "0x600110D")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			internal set
			{
			}
		}

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private StyleValueType m_ValueType;

		// Token: 0x040008CA RID: 2250
		[Token(Token = "0x40008CA")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		internal int valueIndex;
	}
}
