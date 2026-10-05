using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000221 RID: 545
	[Token(Token = "0x2000221")]
	public struct EasingFunction : IEquatable<EasingFunction>
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x17000390")]
		public EasingMode mode
		{
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			get
			{
				return EasingMode.Ease;
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EF9")]
		[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
		public EasingFunction(EasingMode mode)
		{
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x6000EFA")]
		[Address(RVA = "0x595F820", Offset = "0x595E420", VA = "0x18595F820")]
		public static implicit operator EasingFunction(EasingMode easingMode)
		{
			return default(EasingFunction);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6000EFB")]
		[Address(RVA = "0x59505A0", Offset = "0x594F1A0", VA = "0x1859505A0")]
		public static bool operator ==(EasingFunction lhs, EasingFunction rhs)
		{
			return default(bool);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x6000EFC")]
		[Address(RVA = "0x5B06C10", Offset = "0x5B05810", VA = "0x185B06C10", Slot = "4")]
		public bool Equals(EasingFunction other)
		{
			return default(bool);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x5B06B80", Offset = "0x5B05780", VA = "0x185B06B80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x5B06C20", Offset = "0x5B05820", VA = "0x185B06C20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x0")]
		private EasingMode m_Mode;
	}
}
