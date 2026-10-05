using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace SoftMasking
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	public static class MaterialReplacer
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600496B RID: 18795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public static IEnumerable<IMaterialReplacer> globalReplacers
		{
			[Token(Token = "0x600496B")]
			[Address(RVA = "0x1579390", Offset = "0x1577F90", VA = "0x181579390")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600496C RID: 18796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x1578B30", Offset = "0x1577730", VA = "0x181578B30")]
		private static IEnumerable<IMaterialReplacer> CollectGlobalReplacers()
		{
			return null;
		}

		// Token: 0x0600496D RID: 18797 RVA: 0x0002C100 File Offset: 0x0002A300
		[Token(Token = "0x600496D")]
		[Address(RVA = "0x15790A0", Offset = "0x1577CA0", VA = "0x1815790A0")]
		private static bool IsMaterialReplacerType(Type t)
		{
			return default(bool);
		}

		// Token: 0x0600496E RID: 18798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496E")]
		[Address(RVA = "0x1579200", Offset = "0x1577E00", VA = "0x181579200")]
		private static IMaterialReplacer TryCreateInstance(Type t)
		{
			return null;
		}

		// Token: 0x0600496F RID: 18799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600496F")]
		[Address(RVA = "0x1578F20", Offset = "0x1577B20", VA = "0x181578F20")]
		private static IEnumerable<Type> GetTypesSafe(this Assembly asm)
		{
			return null;
		}

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x0")]
		private static List<IMaterialReplacer> _globalReplacers;
	}
}
