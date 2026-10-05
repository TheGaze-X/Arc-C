using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AC0 RID: 27328
	[Token(Token = "0x2006AC0")]
	public class DynamicPicProxy : ActArchiveCompProxy<ArchiveDynamicPicController>
	{
		// Token: 0x17005C63 RID: 23651
		// (get) Token: 0x06027177 RID: 160119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C63")]
		protected override string compType
		{
			[Token(Token = "0x6027177")]
			[Address(RVA = "0x2239BB0", Offset = "0x22387B0", VA = "0x182239BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027178 RID: 160120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027178")]
		[Address(RVA = "0x22390E0", Offset = "0x2237CE0", VA = "0x1822390E0", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027179 RID: 160121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027179")]
		[Address(RVA = "0x22391B0", Offset = "0x2237DB0", VA = "0x1822391B0", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602717A")]
		[Address(RVA = "0x22397F0", Offset = "0x22383F0", VA = "0x1822397F0")]
		private void _OnPicItemClicked(ActArchiveType type, string picID)
		{
		}

		// Token: 0x0602717B RID: 160123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602717B")]
		[Address(RVA = "0x22395F0", Offset = "0x22381F0", VA = "0x1822395F0")]
		private void _OnFullscreenToggled(bool on)
		{
		}

		// Token: 0x0602717C RID: 160124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602717C")]
		[Address(RVA = "0x2239950", Offset = "0x2238550", VA = "0x182239950")]
		private void _OnSetHomeKV()
		{
		}

		// Token: 0x0602717D RID: 160125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602717D")]
		[Address(RVA = "0x2239B40", Offset = "0x2238740", VA = "0x182239B40")]
		public DynamicPicProxy()
		{
		}

		// Token: 0x040374E5 RID: 226533
		[Token(Token = "0x40374E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374E6 RID: 226534
		[Token(Token = "0x40374E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374E7 RID: 226535
		[Token(Token = "0x40374E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374E8 RID: 226536
		[Token(Token = "0x40374E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPicItemClicked;

		// Token: 0x040374E9 RID: 226537
		[Token(Token = "0x40374E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnFullscreenToggled;

		// Token: 0x040374EA RID: 226538
		[Token(Token = "0x40374EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSetHomeKV;

		// Token: 0x040374EB RID: 226539
		[Token(Token = "0x40374EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
