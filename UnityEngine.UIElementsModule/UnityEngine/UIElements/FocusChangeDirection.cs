using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public class FocusChangeDirection : IDisposable
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700002C")]
		public static FocusChangeDirection unspecified
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x5A2EE40", Offset = "0x5A2DA40", VA = "0x185A2EE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700002D")]
		public static FocusChangeDirection none
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x5A2EDF0", Offset = "0x5A2D9F0", VA = "0x185A2EDF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700002E")]
		protected static FocusChangeDirection lastValue
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x5A2EDA0", Offset = "0x5A2D9A0", VA = "0x185A2EDA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x50EDE0", Offset = "0x50D9E0", VA = "0x18050EDE0")]
		protected FocusChangeDirection(int value)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5A2EE90", Offset = "0x5A2DA90", VA = "0x185A2EE90")]
		public static implicit operator int(FocusChangeDirection fcd)
		{
			return 0;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x505F4F0", Offset = "0x505E0F0", VA = "0x18505F4F0", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Dispose()
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x5A2EC20", Offset = "0x5A2D820", VA = "0x185A2EC20", Slot = "6")]
		internal virtual void ApplyTo(FocusController focusController, Focusable f)
		{
		}

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x10")]
		private readonly int m_Value;
	}
}
