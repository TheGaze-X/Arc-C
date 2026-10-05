using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AFA RID: 27386
	[Token(Token = "0x2006AFA")]
	public class ArchiveActivityEntryButtonDataBinder : DataBinder<ArchiveActivityEntryProperty>, IHotfixable
	{
		// Token: 0x17005C90 RID: 23696
		// (set) Token: 0x06027293 RID: 160403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C90")]
		public ArchiveActivityEntryController controller
		{
			[Token(Token = "0x6027293")]
			[Address(RVA = "0x2251CB0", Offset = "0x22508B0", VA = "0x182251CB0")]
			set
			{
			}
		}

		// Token: 0x06027294 RID: 160404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027294")]
		[Address(RVA = "0x2251AF0", Offset = "0x22506F0", VA = "0x182251AF0", Slot = "7")]
		public override void OnValueChanged(ArchiveActivityEntryProperty property)
		{
		}

		// Token: 0x06027295 RID: 160405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027295")]
		[Address(RVA = "0x2251C40", Offset = "0x2250840", VA = "0x182251C40")]
		public ArchiveActivityEntryButtonDataBinder()
		{
		}

		// Token: 0x04037657 RID: 226903
		[Token(Token = "0x4037657")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveActivityEntryButtonView[] _entryButtons;

		// Token: 0x04037658 RID: 226904
		[Token(Token = "0x4037658")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037659 RID: 226905
		[Token(Token = "0x4037659")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403765A RID: 226906
		[Token(Token = "0x403765A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
