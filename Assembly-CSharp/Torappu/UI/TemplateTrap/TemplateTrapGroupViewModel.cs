using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D3B RID: 15675
	[Token(Token = "0x2003D3B")]
	public class TemplateTrapGroupViewModel : IHotfixable
	{
		// Token: 0x060186B7 RID: 100023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60186B7")]
		[Address(RVA = "0x10FBAF0", Offset = "0x10FA6F0", VA = "0x1810FBAF0")]
		public ListDict<int, TemplateTrapViewModel> GetSelectedTrapViewModel()
		{
			return null;
		}

		// Token: 0x060186B8 RID: 100024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B8")]
		[Address(RVA = "0x10FBCC0", Offset = "0x10FA8C0", VA = "0x1810FBCC0")]
		public void InitViewModelByDomainId(string domainId)
		{
		}

		// Token: 0x060186B9 RID: 100025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186B9")]
		[Address(RVA = "0x10FB790", Offset = "0x10FA390", VA = "0x1810FB790")]
		public void ApplySelect(int index, string id)
		{
		}

		// Token: 0x060186BA RID: 100026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60186BA")]
		[Address(RVA = "0x10FC3B0", Offset = "0x10FAFB0", VA = "0x1810FC3B0")]
		public TemplateTrapGroupViewModel()
		{
		}

		// Token: 0x0401DE04 RID: 122372
		[Token(Token = "0x401DE04")]
		[FieldOffset(Offset = "0x10")]
		public string domainId;

		// Token: 0x0401DE05 RID: 122373
		[Token(Token = "0x401DE05")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, TemplateTrapViewModel> trapDict;

		// Token: 0x0401DE06 RID: 122374
		[Token(Token = "0x401DE06")]
		[FieldOffset(Offset = "0x20")]
		public int maxSelectCount;

		// Token: 0x0401DE07 RID: 122375
		[Token(Token = "0x401DE07")]
		[FieldOffset(Offset = "0x28")]
		public string saveSuccessToast;

		// Token: 0x0401DE08 RID: 122376
		[Token(Token = "0x401DE08")]
		[FieldOffset(Offset = "0x30")]
		private string m_domainId;

		// Token: 0x0401DE09 RID: 122377
		[Token(Token = "0x401DE09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSelectedTrapViewModel;

		// Token: 0x0401DE0A RID: 122378
		[Token(Token = "0x401DE0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitViewModelByDomainId;

		// Token: 0x0401DE0B RID: 122379
		[Token(Token = "0x401DE0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplySelect;

		// Token: 0x0401DE0C RID: 122380
		[Token(Token = "0x401DE0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
