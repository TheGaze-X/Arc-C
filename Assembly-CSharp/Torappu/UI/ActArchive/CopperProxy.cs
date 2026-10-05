using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD7 RID: 27351
	[Token(Token = "0x2006AD7")]
	public class CopperProxy : ActArchiveCompProxy<ArchiveCopperController>
	{
		// Token: 0x17005C7A RID: 23674
		// (get) Token: 0x060271FA RID: 160250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C7A")]
		protected override string compType
		{
			[Token(Token = "0x60271FA")]
			[Address(RVA = "0x225B8A0", Offset = "0x225A4A0", VA = "0x18225B8A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271FB RID: 160251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271FB")]
		[Address(RVA = "0x225B420", Offset = "0x225A020", VA = "0x18225B420", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271FC RID: 160252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271FC")]
		[Address(RVA = "0x225B4F0", Offset = "0x225A0F0", VA = "0x18225B4F0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271FD RID: 160253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271FD")]
		[Address(RVA = "0x225B730", Offset = "0x225A330", VA = "0x18225B730")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271FE RID: 160254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271FE")]
		[Address(RVA = "0x225B830", Offset = "0x225A430", VA = "0x18225B830")]
		public CopperProxy()
		{
		}

		// Token: 0x04037569 RID: 226665
		[Token(Token = "0x4037569")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x0403756A RID: 226666
		[Token(Token = "0x403756A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x0403756B RID: 226667
		[Token(Token = "0x403756B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x0403756C RID: 226668
		[Token(Token = "0x403756C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403756D RID: 226669
		[Token(Token = "0x403756D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
