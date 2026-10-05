using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B5F RID: 27487
	[Token(Token = "0x2006B5F")]
	public class ArchiveDisasterController : ActArchiveController, IHotfixable
	{
		// Token: 0x17005CCF RID: 23759
		// (get) Token: 0x06027470 RID: 160880 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027471 RID: 160881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CCF")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x6027470")]
			[Address(RVA = "0x22795B0", Offset = "0x22781B0", VA = "0x1822795B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027471")]
			[Address(RVA = "0x2279610", Offset = "0x2278210", VA = "0x182279610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CD0 RID: 23760
		// (get) Token: 0x06027472 RID: 160882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CD0")]
		public ArchiveDisasterListDataBinder dataBinder
		{
			[Token(Token = "0x6027472")]
			[Address(RVA = "0x2279550", Offset = "0x2278150", VA = "0x182279550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027473 RID: 160883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027473")]
		[Address(RVA = "0x22793D0", Offset = "0x2277FD0", VA = "0x1822793D0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027474 RID: 160884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027474")]
		[Address(RVA = "0x2279330", Offset = "0x2277F30", VA = "0x182279330")]
		public Sprite LoadDisasterIcon(string archiveId, string iconId)
		{
			return null;
		}

		// Token: 0x06027475 RID: 160885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027475")]
		[Address(RVA = "0x22794F0", Offset = "0x22780F0", VA = "0x1822794F0")]
		public ArchiveDisasterController()
		{
		}

		// Token: 0x06027476 RID: 160886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027476")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x040379B7 RID: 227767
		[Token(Token = "0x40379B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveDisasterListDataBinder _disasterDataBinder;

		// Token: 0x040379B9 RID: 227769
		[Token(Token = "0x40379B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x040379BA RID: 227770
		[Token(Token = "0x40379BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x040379BB RID: 227771
		[Token(Token = "0x40379BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x040379BC RID: 227772
		[Token(Token = "0x40379BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x040379BD RID: 227773
		[Token(Token = "0x40379BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadDisasterIcon;

		// Token: 0x040379BE RID: 227774
		[Token(Token = "0x40379BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
