using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002D5 RID: 725
	[Token(Token = "0x20002D5")]
	public class ObjectCheckers
	{
		// Token: 0x06003748 RID: 14152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x344AA70", Offset = "0x3449670", VA = "0x18344AA70")]
		public ObjectCheckers(ObjectTranslator translator)
		{
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private static bool objectCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x344BB20", Offset = "0x344A720", VA = "0x18344BB20")]
		private bool luaTableCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x000166C8 File Offset: 0x000148C8
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x344BBF0", Offset = "0x344A7F0", VA = "0x18344BBF0")]
		private bool numberCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x000166E0 File Offset: 0x000148E0
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x344B4E0", Offset = "0x344A0E0", VA = "0x18344B4E0")]
		private bool decimalCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x344BC10", Offset = "0x344A810", VA = "0x18344BC10")]
		private bool strCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00016710 File Offset: 0x00014910
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x344B410", Offset = "0x344A010", VA = "0x18344B410")]
		private bool bytesCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x344B3F0", Offset = "0x3449FF0", VA = "0x18344B3F0")]
		private bool boolCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x344B9E0", Offset = "0x344A5E0", VA = "0x18344B9E0")]
		private bool int64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00016758 File Offset: 0x00014958
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x344BC60", Offset = "0x344A860", VA = "0x18344BC60")]
		private bool uint64Check(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00016770 File Offset: 0x00014970
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x344BA50", Offset = "0x344A650", VA = "0x18344BA50")]
		private bool luaFunctionCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00016788 File Offset: 0x00014988
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x344BA30", Offset = "0x344A630", VA = "0x18344BA30")]
		private bool intptrCheck(IntPtr L, int idx)
		{
			return default(bool);
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x344B550", Offset = "0x344A150", VA = "0x18344B550")]
		private ObjectCheck genChecker(Type type)
		{
			return null;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x344B930", Offset = "0x344A530", VA = "0x18344B930")]
		public ObjectCheck genNullableChecker(ObjectCheck oc)
		{
			return null;
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x344A880", Offset = "0x3449480", VA = "0x18344A880")]
		public ObjectCheck GetChecker(Type type)
		{
			return null;
		}

		// Token: 0x04000D52 RID: 3410
		[Token(Token = "0x4000D52")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, ObjectCheck> checkersMap;

		// Token: 0x04000D53 RID: 3411
		[Token(Token = "0x4000D53")]
		[FieldOffset(Offset = "0x18")]
		private ObjectTranslator translator;
	}
}
