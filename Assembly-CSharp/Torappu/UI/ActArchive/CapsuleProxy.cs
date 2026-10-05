using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC4 RID: 27332
	[Token(Token = "0x2006AC4")]
	public class CapsuleProxy : ActArchiveCompProxy<ArchiveCapsuleController>
	{
		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x0602718F RID: 160143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C67")]
		protected override string compType
		{
			[Token(Token = "0x602718F")]
			[Address(RVA = "0x2237D80", Offset = "0x2236980", VA = "0x182237D80", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027190 RID: 160144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027190")]
		[Address(RVA = "0x2237770", Offset = "0x2236370", VA = "0x182237770", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027191 RID: 160145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027191")]
		[Address(RVA = "0x2237840", Offset = "0x2236440", VA = "0x182237840", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x06027192 RID: 160146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027192")]
		[Address(RVA = "0x2237BC0", Offset = "0x22367C0", VA = "0x182237BC0")]
		private void _OnCapsuleItemClicked(ActArchiveType type, string capsuleId)
		{
		}

		// Token: 0x06027193 RID: 160147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027193")]
		[Address(RVA = "0x2237D10", Offset = "0x2236910", VA = "0x182237D10")]
		public CapsuleProxy()
		{
		}

		// Token: 0x040374FE RID: 226558
		[Token(Token = "0x40374FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374FF RID: 226559
		[Token(Token = "0x40374FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x04037500 RID: 226560
		[Token(Token = "0x4037500")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x04037501 RID: 226561
		[Token(Token = "0x4037501")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCapsuleItemClicked;

		// Token: 0x04037502 RID: 226562
		[Token(Token = "0x4037502")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
