using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive.RL03
{
	// Token: 0x02006C71 RID: 27761
	[Token(Token = "0x2006C71")]
	public class RL03ArchiveChaosController : ArchiveChaosController
	{
		// Token: 0x060279FE RID: 162302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60279FE")]
		[Address(RVA = "0x22CB120", Offset = "0x22C9D20", VA = "0x1822CB120", Slot = "10")]
		public override Sprite LoadChaosIcon(string archiveId, string chaosIconId)
		{
			return null;
		}

		// Token: 0x060279FF RID: 162303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60279FF")]
		[Address(RVA = "0x22CB1F0", Offset = "0x22C9DF0", VA = "0x1822CB1F0")]
		public RL03ArchiveChaosController()
		{
		}

		// Token: 0x04038323 RID: 230179
		[Token(Token = "0x4038323")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_finder;

		// Token: 0x04038324 RID: 230180
		[Token(Token = "0x4038324")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadChaosIcon;

		// Token: 0x04038325 RID: 230181
		[Token(Token = "0x4038325")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
