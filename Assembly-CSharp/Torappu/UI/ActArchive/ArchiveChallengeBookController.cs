using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B2A RID: 27434
	[Token(Token = "0x2006B2A")]
	public class ArchiveChallengeBookController : ActArchiveController
	{
		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x06027373 RID: 160627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027374 RID: 160628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA9")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x6027373")]
			[Address(RVA = "0x2266460", Offset = "0x2265060", VA = "0x182266460")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027374")]
			[Address(RVA = "0x22664C0", Offset = "0x22650C0", VA = "0x1822664C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x06027375 RID: 160629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CAA")]
		public ArchiveChallengeBookListDataBinder dataBinder
		{
			[Token(Token = "0x6027375")]
			[Address(RVA = "0x2266400", Offset = "0x2265000", VA = "0x182266400")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027376 RID: 160630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027376")]
		[Address(RVA = "0x2266280", Offset = "0x2264E80", VA = "0x182266280", Slot = "9")]
		public override void OnItemClick(string storyId)
		{
		}

		// Token: 0x06027377 RID: 160631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027377")]
		[Address(RVA = "0x22663A0", Offset = "0x2264FA0", VA = "0x1822663A0")]
		public ArchiveChallengeBookController()
		{
		}

		// Token: 0x06027378 RID: 160632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027378")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x040377C1 RID: 227265
		[Token(Token = "0x40377C1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveChallengeBookListDataBinder _chaosDataBinder;

		// Token: 0x040377C3 RID: 227267
		[Token(Token = "0x40377C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x040377C4 RID: 227268
		[Token(Token = "0x40377C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x040377C5 RID: 227269
		[Token(Token = "0x40377C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x040377C6 RID: 227270
		[Token(Token = "0x40377C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x040377C7 RID: 227271
		[Token(Token = "0x40377C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
