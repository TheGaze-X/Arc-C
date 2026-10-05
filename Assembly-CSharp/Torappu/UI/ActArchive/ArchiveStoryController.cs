using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C1C RID: 27676
	[Token(Token = "0x2006C1C")]
	public class ArchiveStoryController : ActArchiveController
	{
		// Token: 0x0602783E RID: 161854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602783E")]
		[Address(RVA = "0x22B3FC0", Offset = "0x22B2BC0", VA = "0x1822B3FC0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x0602783F RID: 161855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602783F")]
		[Address(RVA = "0x22B3CC0", Offset = "0x22B28C0", VA = "0x1822B3CC0")]
		public List<DataBinder<StoryProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027840 RID: 161856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027840")]
		[Address(RVA = "0x22B3DF0", Offset = "0x22B29F0", VA = "0x1822B3DF0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x06027841 RID: 161857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027841")]
		[Address(RVA = "0x22B4040", Offset = "0x22B2C40", VA = "0x1822B4040", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x06027842 RID: 161858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027842")]
		[Address(RVA = "0x22B4100", Offset = "0x22B2D00", VA = "0x1822B4100")]
		public ArchiveStoryController()
		{
		}

		// Token: 0x06027843 RID: 161859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027843")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x06027844 RID: 161860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027844")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x06027845 RID: 161861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027845")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04038067 RID: 229479
		[Token(Token = "0x4038067")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveStoryListDataBinder _storyListBinder;

		// Token: 0x04038068 RID: 229480
		[Token(Token = "0x4038068")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04038069 RID: 229481
		[Token(Token = "0x4038069")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0403806A RID: 229482
		[Token(Token = "0x403806A")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<ActArchiveType, string> onStoryItemClicked;

		// Token: 0x0403806B RID: 229483
		[Token(Token = "0x403806B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403806C RID: 229484
		[Token(Token = "0x403806C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x0403806D RID: 229485
		[Token(Token = "0x403806D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403806E RID: 229486
		[Token(Token = "0x403806E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403806F RID: 229487
		[Token(Token = "0x403806F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
