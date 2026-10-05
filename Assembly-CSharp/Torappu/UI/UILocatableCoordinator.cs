using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003958 RID: 14680
	[Token(Token = "0x2003958")]
	public abstract class UILocatableCoordinator : IHotfixable
	{
		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x06017322 RID: 95010 RVA: 0x00095418 File Offset: 0x00093618
		// (set) Token: 0x06017323 RID: 95011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700376C")]
		public bool isLocating
		{
			[Token(Token = "0x6017322")]
			[Address(RVA = "0xF95950", Offset = "0xF94550", VA = "0x180F95950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017323")]
			[Address(RVA = "0xF959B0", Offset = "0xF945B0", VA = "0x180F959B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06017324 RID: 95012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017324")]
		[Address(RVA = "0xF958F0", Offset = "0xF944F0", VA = "0x180F958F0")]
		protected UILocatableCoordinator()
		{
		}

		// Token: 0x0401BFEB RID: 114667
		[Token(Token = "0x401BFEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocating;

		// Token: 0x0401BFEC RID: 114668
		[Token(Token = "0x401BFEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isLocating;

		// Token: 0x0401BFED RID: 114669
		[Token(Token = "0x401BFED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
