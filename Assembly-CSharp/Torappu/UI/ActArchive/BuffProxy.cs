using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ACE RID: 27342
	[Token(Token = "0x2006ACE")]
	public class BuffProxy : ActArchiveCompProxy<ArchiveBuffController>
	{
		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x060271C7 RID: 160199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C71")]
		protected override string compType
		{
			[Token(Token = "0x60271C7")]
			[Address(RVA = "0x225A9D0", Offset = "0x22595D0", VA = "0x18225A9D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271C8 RID: 160200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271C8")]
		[Address(RVA = "0x225A310", Offset = "0x2258F10", VA = "0x18225A310", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271C9 RID: 160201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271C9")]
		[Address(RVA = "0x225A3E0", Offset = "0x2258FE0", VA = "0x18225A3E0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271CA RID: 160202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271CA")]
		[Address(RVA = "0x225A840", Offset = "0x2259440", VA = "0x18225A840")]
		private void _OnItemClicked(ActArchiveType type, string buffID)
		{
		}

		// Token: 0x060271CB RID: 160203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271CB")]
		[Address(RVA = "0x225A960", Offset = "0x2259560", VA = "0x18225A960")]
		public BuffProxy()
		{
		}

		// Token: 0x04037536 RID: 226614
		[Token(Token = "0x4037536")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037537 RID: 226615
		[Token(Token = "0x4037537")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037538 RID: 226616
		[Token(Token = "0x4037538")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037539 RID: 226617
		[Token(Token = "0x4037539")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403753A RID: 226618
		[Token(Token = "0x403753A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
