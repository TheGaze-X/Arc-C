using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058D7 RID: 22743
	[Token(Token = "0x20058D7")]
	public abstract class CrossAppShareElementModelCollector : ICrossAppShareModelCollector, IHotfixable
	{
		// Token: 0x060212A9 RID: 135849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60212A9")]
		[Address(RVA = "0x1B73BA0", Offset = "0x1B727A0", VA = "0x181B73BA0")]
		public string GetElementKey()
		{
			return null;
		}

		// Token: 0x060212AA RID: 135850
		[Token(Token = "0x60212AA")]
		public abstract void CollectModel();

		// Token: 0x060212AB RID: 135851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60212AB")]
		[Address(RVA = "0x1B73C00", Offset = "0x1B72800", VA = "0x181B73C00")]
		protected CrossAppShareElementModelCollector()
		{
		}

		// Token: 0x0402D2D6 RID: 185046
		[Token(Token = "0x402D2D6")]
		[FieldOffset(Offset = "0x10")]
		protected string m_elementKey;

		// Token: 0x0402D2D7 RID: 185047
		[Token(Token = "0x402D2D7")]
		[FieldOffset(Offset = "0x18")]
		public CrossAppShareElementScaleStruct scaleStruct;

		// Token: 0x0402D2D8 RID: 185048
		[Token(Token = "0x402D2D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetElementKey;

		// Token: 0x0402D2D9 RID: 185049
		[Token(Token = "0x402D2D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
