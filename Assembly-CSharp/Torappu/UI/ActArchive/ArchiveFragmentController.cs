using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B84 RID: 27524
	[Token(Token = "0x2006B84")]
	public class ArchiveFragmentController : ActArchiveController, IHotfixable
	{
		// Token: 0x17005CE0 RID: 23776
		// (get) Token: 0x06027529 RID: 161065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602752A RID: 161066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CE0")]
		public Action<string> onItemClicked
		{
			[Token(Token = "0x6027529")]
			[Address(RVA = "0x22811E0", Offset = "0x227FDE0", VA = "0x1822811E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602752A")]
			[Address(RVA = "0x2281240", Offset = "0x227FE40", VA = "0x182281240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602752B RID: 161067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602752B")]
		[Address(RVA = "0x2281060", Offset = "0x227FC60", VA = "0x182281060", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x0602752C RID: 161068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602752C")]
		[Address(RVA = "0x2280F80", Offset = "0x227FB80", VA = "0x182280F80")]
		public List<DataBinder<FragmentProperty>> InitAndAchieveDataBinder()
		{
			return null;
		}

		// Token: 0x0602752D RID: 161069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602752D")]
		[Address(RVA = "0x2281180", Offset = "0x227FD80", VA = "0x182281180")]
		public ArchiveFragmentController()
		{
		}

		// Token: 0x0602752E RID: 161070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602752E")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04037B28 RID: 228136
		[Token(Token = "0x4037B28")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveFragmentListView _fragmentList;

		// Token: 0x04037B29 RID: 228137
		[Token(Token = "0x4037B29")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveFragmentInfoView _fragmentInfo;

		// Token: 0x04037B2B RID: 228139
		[Token(Token = "0x4037B2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x04037B2C RID: 228140
		[Token(Token = "0x4037B2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x04037B2D RID: 228141
		[Token(Token = "0x4037B2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037B2E RID: 228142
		[Token(Token = "0x4037B2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinder;

		// Token: 0x04037B2F RID: 228143
		[Token(Token = "0x4037B2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
