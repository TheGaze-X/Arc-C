using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AD1 RID: 27345
	[Token(Token = "0x2006AD1")]
	public class ChallengeBookProxy : ActArchiveCompProxy<ArchiveChallengeBookController>
	{
		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x060271D6 RID: 160214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C74")]
		protected override string compType
		{
			[Token(Token = "0x60271D6")]
			[Address(RVA = "0x225AEC0", Offset = "0x2259AC0", VA = "0x18225AEC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060271D7 RID: 160215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60271D7")]
		[Address(RVA = "0x225AA40", Offset = "0x2259640", VA = "0x18225AA40", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x060271D8 RID: 160216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D8")]
		[Address(RVA = "0x225AB10", Offset = "0x2259710", VA = "0x18225AB10", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x060271D9 RID: 160217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271D9")]
		[Address(RVA = "0x225AD50", Offset = "0x2259950", VA = "0x18225AD50")]
		private void _OnItemClicked(ActArchiveType type, string id)
		{
		}

		// Token: 0x060271DA RID: 160218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60271DA")]
		[Address(RVA = "0x225AE50", Offset = "0x2259A50", VA = "0x18225AE50")]
		public ChallengeBookProxy()
		{
		}

		// Token: 0x04037545 RID: 226629
		[Token(Token = "0x4037545")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x04037546 RID: 226630
		[Token(Token = "0x4037546")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037547 RID: 226631
		[Token(Token = "0x4037547")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037548 RID: 226632
		[Token(Token = "0x4037548")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04037549 RID: 226633
		[Token(Token = "0x4037549")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
