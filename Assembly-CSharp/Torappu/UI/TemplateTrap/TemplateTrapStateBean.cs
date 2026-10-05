using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D38 RID: 15672
	[Token(Token = "0x2003D38")]
	public class TemplateTrapStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060186B2 RID: 100018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B2")]
		[Address(RVA = "0x10FCA50", Offset = "0x10FB650", VA = "0x1810FCA50")]
		public void InitViewModel(string domainId)
		{
		}

		// Token: 0x060186B3 RID: 100019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B3")]
		[Address(RVA = "0x10FC940", Offset = "0x10FB540", VA = "0x1810FC940")]
		public void ApplySelect(int index, string selectId)
		{
		}

		// Token: 0x060186B4 RID: 100020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B4")]
		[Address(RVA = "0x10FCC70", Offset = "0x10FB870", VA = "0x1810FCC70")]
		public TemplateTrapStateBean()
		{
		}

		// Token: 0x0401DDF3 RID: 122355
		[Token(Token = "0x401DDF3")]
		[FieldOffset(Offset = "0x10")]
		public TemplateTrapProperty groupProperty;

		// Token: 0x0401DDF4 RID: 122356
		[Token(Token = "0x401DDF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x0401DDF5 RID: 122357
		[Token(Token = "0x401DDF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplySelect;

		// Token: 0x0401DDF6 RID: 122358
		[Token(Token = "0x401DDF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
