using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200406B RID: 16491
	[Token(Token = "0x200406B")]
	public abstract class SandboxV2AdminMainViewBase : DataBinder<SandboxV2AdminMainModelProperty>, IHotfixable
	{
		// Token: 0x17003CC3 RID: 15555
		// (get) Token: 0x0601981E RID: 104478 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601981F RID: 104479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003CC3")]
		private protected SandboxV2AdminMainState mainState
		{
			[Token(Token = "0x601981E")]
			[Address(RVA = "0x1232650", Offset = "0x1231250", VA = "0x181232650")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601981F")]
			[Address(RVA = "0x12326B0", Offset = "0x12312B0", VA = "0x1812326B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019820 RID: 104480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019820")]
		[Address(RVA = "0x1232530", Offset = "0x1231130", VA = "0x181232530")]
		public void Bind(SandboxV2AdminMainState state)
		{
		}

		// Token: 0x06019821 RID: 104481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019821")]
		[Address(RVA = "0x12325E0", Offset = "0x12311E0", VA = "0x1812325E0")]
		protected SandboxV2AdminMainViewBase()
		{
		}

		// Token: 0x0401FCB3 RID: 130227
		[Token(Token = "0x401FCB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mainState;

		// Token: 0x0401FCB4 RID: 130228
		[Token(Token = "0x401FCB4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mainState;

		// Token: 0x0401FCB5 RID: 130229
		[Token(Token = "0x401FCB5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Bind;

		// Token: 0x0401FCB6 RID: 130230
		[Token(Token = "0x401FCB6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
