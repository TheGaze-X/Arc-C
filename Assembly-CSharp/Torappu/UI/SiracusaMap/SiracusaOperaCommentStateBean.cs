using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F37 RID: 16183
	[Token(Token = "0x2003F37")]
	public class SiracusaOperaCommentStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601922B RID: 102955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601922B")]
		[Address(RVA = "0x11D91A0", Offset = "0x11D7DA0", VA = "0x1811D91A0")]
		public SiracusaOperaCommentStateBean()
		{
		}

		// Token: 0x0401F222 RID: 127522
		[Token(Token = "0x401F222")]
		[FieldOffset(Offset = "0x10")]
		public string operaId;

		// Token: 0x0401F223 RID: 127523
		[Token(Token = "0x401F223")]
		[FieldOffset(Offset = "0x18")]
		public SiracusaOperaCommentProperty commentProp;

		// Token: 0x0401F224 RID: 127524
		[Token(Token = "0x401F224")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
