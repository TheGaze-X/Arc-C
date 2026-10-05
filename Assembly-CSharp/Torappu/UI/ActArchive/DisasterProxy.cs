using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD5 RID: 27349
	[Token(Token = "0x2006AD5")]
	public class DisasterProxy : ActArchiveCompProxy<ArchiveDisasterController>
	{
		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x060271F0 RID: 160240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C78")]
		protected override string compType
		{
			[Token(Token = "0x60271F0")]
			[Address(RVA = "0x225BDB0", Offset = "0x225A9B0", VA = "0x18225BDB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271F1 RID: 160241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271F1")]
		[Address(RVA = "0x225B910", Offset = "0x225A510", VA = "0x18225B910", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271F2 RID: 160242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F2")]
		[Address(RVA = "0x225B9E0", Offset = "0x225A5E0", VA = "0x18225B9E0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271F3 RID: 160243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F3")]
		[Address(RVA = "0x225BC20", Offset = "0x225A820", VA = "0x18225BC20")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271F4 RID: 160244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271F4")]
		[Address(RVA = "0x225BD40", Offset = "0x225A940", VA = "0x18225BD40")]
		public DisasterProxy()
		{
		}

		// Token: 0x0403755F RID: 226655
		[Token(Token = "0x403755F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037560 RID: 226656
		[Token(Token = "0x4037560")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037561 RID: 226657
		[Token(Token = "0x4037561")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037562 RID: 226658
		[Token(Token = "0x4037562")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04037563 RID: 226659
		[Token(Token = "0x4037563")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
