using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	[Serializable]
	internal class StyleProperty
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000446")]
		public string name
		{
			[Token(Token = "0x60010CB")]
			[Address(RVA = "0x3E76330", Offset = "0x3E74F30", VA = "0x183E76330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000447")]
		public StyleValueHandle[] values
		{
			[Token(Token = "0x60010CC")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StyleProperty()
		{
		}

		// Token: 0x04000892 RID: 2194
		[Token(Token = "0x4000892")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		// Token: 0x04000893 RID: 2195
		[Token(Token = "0x4000893")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_Line;

		// Token: 0x04000894 RID: 2196
		[Token(Token = "0x4000894")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StyleValueHandle[] m_Values;

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		internal bool isCustomProperty;

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x29")]
		[NonSerialized]
		internal bool requireVariableResolve;
	}
}
