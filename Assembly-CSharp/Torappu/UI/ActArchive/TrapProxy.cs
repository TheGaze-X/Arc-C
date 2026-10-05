using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC3 RID: 27331
	[Token(Token = "0x2006AC3")]
	public class TrapProxy : ActArchiveCompProxy<ArchiveTrapController>
	{
		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x0602718A RID: 160138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C66")]
		protected override string compType
		{
			[Token(Token = "0x602718A")]
			[Address(RVA = "0x2248040", Offset = "0x2246C40", VA = "0x182248040", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602718B RID: 160139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602718B")]
		[Address(RVA = "0x2247A30", Offset = "0x2246630", VA = "0x182247A30", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x0602718C RID: 160140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602718C")]
		[Address(RVA = "0x2247B00", Offset = "0x2246700", VA = "0x182247B00", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x0602718D RID: 160141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602718D")]
		[Address(RVA = "0x2247E80", Offset = "0x2246A80", VA = "0x182247E80")]
		private void _OnTrapItemClicked(ActArchiveType type, string capsuleId)
		{
		}

		// Token: 0x0602718E RID: 160142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602718E")]
		[Address(RVA = "0x2247FD0", Offset = "0x2246BD0", VA = "0x182247FD0")]
		public TrapProxy()
		{
		}

		// Token: 0x040374F8 RID: 226552
		[Token(Token = "0x40374F8")]
		public const string TRAP_TRIGGER_TYPE = "trap";

		// Token: 0x040374F9 RID: 226553
		[Token(Token = "0x40374F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374FA RID: 226554
		[Token(Token = "0x40374FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374FB RID: 226555
		[Token(Token = "0x40374FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374FC RID: 226556
		[Token(Token = "0x40374FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTrapItemClicked;

		// Token: 0x040374FD RID: 226557
		[Token(Token = "0x40374FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
