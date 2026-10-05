using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD0 RID: 27344
	[Token(Token = "0x2006AD0")]
	public class ChaosProxy : ActArchiveCompProxy<ArchiveChaosController>
	{
		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x060271D1 RID: 160209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C73")]
		protected override string compType
		{
			[Token(Token = "0x60271D1")]
			[Address(RVA = "0x225B3B0", Offset = "0x2259FB0", VA = "0x18225B3B0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271D2 RID: 160210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271D2")]
		[Address(RVA = "0x225AF30", Offset = "0x2259B30", VA = "0x18225AF30", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271D3 RID: 160211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D3")]
		[Address(RVA = "0x225B000", Offset = "0x2259C00", VA = "0x18225B000", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271D4 RID: 160212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D4")]
		[Address(RVA = "0x225B240", Offset = "0x2259E40", VA = "0x18225B240")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271D5 RID: 160213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D5")]
		[Address(RVA = "0x225B340", Offset = "0x2259F40", VA = "0x18225B340")]
		public ChaosProxy()
		{
		}

		// Token: 0x04037540 RID: 226624
		[Token(Token = "0x4037540")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037541 RID: 226625
		[Token(Token = "0x4037541")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037542 RID: 226626
		[Token(Token = "0x4037542")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037543 RID: 226627
		[Token(Token = "0x4037543")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04037544 RID: 226628
		[Token(Token = "0x4037544")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
