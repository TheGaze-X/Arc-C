using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B51 RID: 27473
	[Token(Token = "0x2006B51")]
	public class ArchiveCopperController : ActArchiveController, IHotfixable
	{
		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x0602742F RID: 160815 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027430 RID: 160816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CC5")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x602742F")]
			[Address(RVA = "0x226FB80", Offset = "0x226E780", VA = "0x18226FB80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027430")]
			[Address(RVA = "0x226FBE0", Offset = "0x226E7E0", VA = "0x18226FBE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x06027431 RID: 160817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CC6")]
		public ArchiveCopperDataBinder dataBinder
		{
			[Token(Token = "0x6027431")]
			[Address(RVA = "0x226FB20", Offset = "0x226E720", VA = "0x18226FB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027432 RID: 160818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027432")]
		[Address(RVA = "0x226F9A0", Offset = "0x226E5A0", VA = "0x18226F9A0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027433 RID: 160819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027433")]
		[Address(RVA = "0x226F900", Offset = "0x226E500", VA = "0x18226F900")]
		public Sprite LoadGroupTitleIcon(string archiveId, string iconId)
		{
			return null;
		}

		// Token: 0x06027434 RID: 160820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027434")]
		[Address(RVA = "0x226FAC0", Offset = "0x226E6C0", VA = "0x18226FAC0")]
		public ArchiveCopperController()
		{
		}

		// Token: 0x06027435 RID: 160821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027435")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0403792A RID: 227626
		[Token(Token = "0x403792A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveCopperDataBinder _copperDataBinder;

		// Token: 0x0403792C RID: 227628
		[Token(Token = "0x403792C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403792D RID: 227629
		[Token(Token = "0x403792D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403792E RID: 227630
		[Token(Token = "0x403792E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataBinder;

		// Token: 0x0403792F RID: 227631
		[Token(Token = "0x403792F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037930 RID: 227632
		[Token(Token = "0x4037930")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadGroupTitleIcon;

		// Token: 0x04037931 RID: 227633
		[Token(Token = "0x4037931")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
