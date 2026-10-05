using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACC RID: 27340
	[Token(Token = "0x2006ACC")]
	public class NewsProxy : ActArchiveCompProxy<ArchiveNewsController>
	{
		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x060271BA RID: 160186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C6F")]
		protected override string compType
		{
			[Token(Token = "0x60271BA")]
			[Address(RVA = "0x225EBA0", Offset = "0x225D7A0", VA = "0x18225EBA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271BB RID: 160187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271BB")]
		[Address(RVA = "0x225E710", Offset = "0x225D310", VA = "0x18225E710", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271BC RID: 160188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271BC")]
		[Address(RVA = "0x225EA10", Offset = "0x225D610", VA = "0x18225EA10")]
		private void _OnNewsItemClicked(ActArchiveType type, string newsId)
		{
		}

		// Token: 0x060271BD RID: 160189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271BD")]
		[Address(RVA = "0x225EB30", Offset = "0x225D730", VA = "0x18225EB30")]
		public NewsProxy()
		{
		}

		// Token: 0x04037529 RID: 226601
		[Token(Token = "0x4037529")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403752A RID: 226602
		[Token(Token = "0x403752A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403752B RID: 226603
		[Token(Token = "0x403752B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnNewsItemClicked;

		// Token: 0x0403752C RID: 226604
		[Token(Token = "0x403752C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
