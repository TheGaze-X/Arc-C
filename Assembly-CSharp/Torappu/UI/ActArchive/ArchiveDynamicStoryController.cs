using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C16 RID: 27670
	[Token(Token = "0x2006C16")]
	public class ArchiveDynamicStoryController : ActArchiveController
	{
		// Token: 0x0602781C RID: 161820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602781C")]
		[Address(RVA = "0x22A7D00", Offset = "0x22A6900", VA = "0x1822A7D00", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x0602781D RID: 161821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602781D")]
		[Address(RVA = "0x22A7BD0", Offset = "0x22A67D0", VA = "0x1822A7BD0")]
		public List<DataBinder<StoryProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x0602781E RID: 161822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602781E")]
		[Address(RVA = "0x22A7D80", Offset = "0x22A6980", VA = "0x1822A7D80", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x0602781F RID: 161823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602781F")]
		[Address(RVA = "0x22A7E40", Offset = "0x22A6A40", VA = "0x1822A7E40")]
		public ArchiveDynamicStoryController()
		{
		}

		// Token: 0x06027820 RID: 161824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027820")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x06027821 RID: 161825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027821")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04038034 RID: 229428
		[Token(Token = "0x4038034")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveDynamicStoryListDataBinder _storyListBinder;

		// Token: 0x04038035 RID: 229429
		[Token(Token = "0x4038035")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<ActArchiveType, string> onStoryItemClicked;

		// Token: 0x04038036 RID: 229430
		[Token(Token = "0x4038036")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04038037 RID: 229431
		[Token(Token = "0x4038037")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04038038 RID: 229432
		[Token(Token = "0x4038038")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04038039 RID: 229433
		[Token(Token = "0x4038039")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
