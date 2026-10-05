using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D37 RID: 15671
	[Token(Token = "0x2003D37")]
	public class TemplateTrapAllTrackViewModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x060186AF RID: 100015 RVA: 0x0009A5D8 File Offset: 0x000987D8
		[Token(Token = "0x17003A66")]
		public bool isShow
		{
			[Token(Token = "0x60186AF")]
			[Address(RVA = "0x10FB730", Offset = "0x10FA330", VA = "0x1810FB730", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060186B0 RID: 100016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B0")]
		[Address(RVA = "0x10FB350", Offset = "0x10F9F50", VA = "0x1810FB350", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x060186B1 RID: 100017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B1")]
		[Address(RVA = "0x10FB6D0", Offset = "0x10FA2D0", VA = "0x1810FB6D0")]
		public TemplateTrapAllTrackViewModel()
		{
		}

		// Token: 0x0401DDEE RID: 122350
		[Token(Token = "0x401DDEE")]
		[FieldOffset(Offset = "0x10")]
		public string domainId;

		// Token: 0x0401DDEF RID: 122351
		[Token(Token = "0x401DDEF")]
		[FieldOffset(Offset = "0x18")]
		public bool isShowFlag;

		// Token: 0x0401DDF0 RID: 122352
		[Token(Token = "0x401DDF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0401DDF1 RID: 122353
		[Token(Token = "0x401DDF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0401DDF2 RID: 122354
		[Token(Token = "0x401DDF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
