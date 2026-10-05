using System;
using System.Text;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public class StringBuilderPool : IHotfixable
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x55010C0", Offset = "0x54FFCC0", VA = "0x1855010C0")]
		private static void _ResetStringBuilder(StringBuilder inst)
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5500F50", Offset = "0x54FFB50", VA = "0x185500F50")]
		public static GenericPool<StringBuilder>.Ref Get()
		{
			return default(GenericPool<StringBuilder>.Ref);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x5501130", Offset = "0x54FFD30", VA = "0x185501130")]
		public StringBuilderPool()
		{
		}

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x0")]
		private static Action<StringBuilder> s_resetDelegate;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ResetStringBuilder;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate52 __Hotfix0_Get;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
