using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006320 RID: 25376
	[Token(Token = "0x2006320")]
	public class AutoChessShopQuickAssistStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005635 RID: 22069
		// (get) Token: 0x0602496A RID: 149866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005635")]
		public AutoChessShopQuickAssistViewProperty quickAssistViewProp
		{
			[Token(Token = "0x602496A")]
			[Address(RVA = "0x1F799D0", Offset = "0x1F785D0", VA = "0x181F799D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602496B RID: 149867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602496B")]
		[Address(RVA = "0x1F798E0", Offset = "0x1F784E0", VA = "0x181F798E0")]
		public AutoChessShopQuickAssistStateBean()
		{
		}

		// Token: 0x040330CA RID: 209098
		[Token(Token = "0x40330CA")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessShopQuickAssistViewProperty m_quickAssistViewProp;

		// Token: 0x040330CB RID: 209099
		[Token(Token = "0x40330CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_quickAssistViewProp;

		// Token: 0x040330CC RID: 209100
		[Token(Token = "0x40330CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
