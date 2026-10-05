using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive.RL03
{
	// Token: 0x02006C72 RID: 27762
	[Token(Token = "0x2006C72")]
	public class RL03ArchiveTotemController : ArchiveTotemController
	{
		// Token: 0x06027A00 RID: 162304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A00")]
		[Address(RVA = "0x22CB250", Offset = "0x22C9E50", VA = "0x1822CB250", Slot = "10")]
		public override Sprite LoadItemIcon(TotemItemModel item)
		{
			return null;
		}

		// Token: 0x06027A01 RID: 162305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A01")]
		[Address(RVA = "0x22CB350", Offset = "0x22C9F50", VA = "0x1822CB350")]
		public RL03ArchiveTotemController()
		{
		}

		// Token: 0x04038326 RID: 230182
		[Token(Token = "0x4038326")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_finder;

		// Token: 0x04038327 RID: 230183
		[Token(Token = "0x4038327")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x04038328 RID: 230184
		[Token(Token = "0x4038328")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
