using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B1F RID: 27423
	[Token(Token = "0x2006B1F")]
	public class ArchiveCapsuleController : ActArchiveController
	{
		// Token: 0x17005CA3 RID: 23715
		// (get) Token: 0x0602733D RID: 160573 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602733E RID: 160574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CA3")]
		public Action<ActArchiveType, string> onCapsuleItemClicked
		{
			[Token(Token = "0x602733D")]
			[Address(RVA = "0x2263EA0", Offset = "0x2262AA0", VA = "0x182263EA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602733E")]
			[Address(RVA = "0x2263F00", Offset = "0x2262B00", VA = "0x182263F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005CA4 RID: 23716
		// (get) Token: 0x0602733F RID: 160575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CA4")]
		public string archiveId
		{
			[Token(Token = "0x602733F")]
			[Address(RVA = "0x2263E30", Offset = "0x2262A30", VA = "0x182263E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027340 RID: 160576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027340")]
		[Address(RVA = "0x2263CA0", Offset = "0x22628A0", VA = "0x182263CA0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027341 RID: 160577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027341")]
		[Address(RVA = "0x2263AC0", Offset = "0x22626C0", VA = "0x182263AC0")]
		public List<DataBinder<CapsuleProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027342 RID: 160578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027342")]
		[Address(RVA = "0x2263BF0", Offset = "0x22627F0", VA = "0x182263BF0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x06027343 RID: 160579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027343")]
		[Address(RVA = "0x2263DD0", Offset = "0x22629D0", VA = "0x182263DD0")]
		public ArchiveCapsuleController()
		{
		}

		// Token: 0x06027344 RID: 160580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027344")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x06027345 RID: 160581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027345")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x0403776B RID: 227179
		[Token(Token = "0x403776B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveCapsuleListDataBinder _capsuleDataBinder;

		// Token: 0x0403776C RID: 227180
		[Token(Token = "0x403776C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0403776E RID: 227182
		[Token(Token = "0x403776E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onCapsuleItemClicked;

		// Token: 0x0403776F RID: 227183
		[Token(Token = "0x403776F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onCapsuleItemClicked;

		// Token: 0x04037770 RID: 227184
		[Token(Token = "0x4037770")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x04037771 RID: 227185
		[Token(Token = "0x4037771")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037772 RID: 227186
		[Token(Token = "0x4037772")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037773 RID: 227187
		[Token(Token = "0x4037773")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037774 RID: 227188
		[Token(Token = "0x4037774")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
