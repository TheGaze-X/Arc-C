using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ABE RID: 27326
	[Token(Token = "0x2006ABE")]
	public class LandmarkProxy : ActArchiveCompProxy<ArchiveLandmarkController>
	{
		// Token: 0x17005C61 RID: 23649
		// (get) Token: 0x0602716C RID: 160108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C61")]
		protected override string compType
		{
			[Token(Token = "0x602716C")]
			[Address(RVA = "0x223A2D0", Offset = "0x2238ED0", VA = "0x18223A2D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602716D RID: 160109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602716D")]
		[Address(RVA = "0x2239CC0", Offset = "0x22388C0", VA = "0x182239CC0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x0602716E RID: 160110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602716E")]
		[Address(RVA = "0x2239D90", Offset = "0x2238990", VA = "0x182239D90", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x0602716F RID: 160111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602716F")]
		[Address(RVA = "0x223A100", Offset = "0x2238D00", VA = "0x18223A100")]
		private void _OnLandmarkItemClicked(ActArchiveType type, string landmarkID)
		{
		}

		// Token: 0x06027170 RID: 160112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027170")]
		[Address(RVA = "0x223A260", Offset = "0x2238E60", VA = "0x18223A260")]
		public LandmarkProxy()
		{
		}

		// Token: 0x040374DA RID: 226522
		[Token(Token = "0x40374DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374DB RID: 226523
		[Token(Token = "0x40374DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374DC RID: 226524
		[Token(Token = "0x40374DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374DD RID: 226525
		[Token(Token = "0x40374DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnLandmarkItemClicked;

		// Token: 0x040374DE RID: 226526
		[Token(Token = "0x40374DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
