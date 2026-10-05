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
	// Token: 0x02006BC1 RID: 27585
	[Token(Token = "0x2006BC1")]
	public class ArchiveNewsController : ActArchiveController
	{
		// Token: 0x06027657 RID: 161367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027657")]
		[Address(RVA = "0x2294E90", Offset = "0x2293A90", VA = "0x182294E90", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027658 RID: 161368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027658")]
		[Address(RVA = "0x2294B90", Offset = "0x2293790", VA = "0x182294B90")]
		public List<DataBinder<NewsProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027659 RID: 161369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027659")]
		[Address(RVA = "0x2294CC0", Offset = "0x22938C0", VA = "0x182294CC0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x0602765A RID: 161370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602765A")]
		[Address(RVA = "0x2294F10", Offset = "0x2293B10", VA = "0x182294F10", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x0602765B RID: 161371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602765B")]
		[Address(RVA = "0x2294FD0", Offset = "0x2293BD0", VA = "0x182294FD0")]
		public ArchiveNewsController()
		{
		}

		// Token: 0x0602765C RID: 161372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602765C")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0602765D RID: 161373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602765D")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x0602765E RID: 161374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602765E")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04037D01 RID: 228609
		[Token(Token = "0x4037D01")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveNewsListDataBinder _newsListBinder;

		// Token: 0x04037D02 RID: 228610
		[Token(Token = "0x4037D02")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037D03 RID: 228611
		[Token(Token = "0x4037D03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x04037D04 RID: 228612
		[Token(Token = "0x4037D04")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<ActArchiveType, string> onNewsItemClicked;

		// Token: 0x04037D05 RID: 228613
		[Token(Token = "0x4037D05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037D06 RID: 228614
		[Token(Token = "0x4037D06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037D07 RID: 228615
		[Token(Token = "0x4037D07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037D08 RID: 228616
		[Token(Token = "0x4037D08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037D09 RID: 228617
		[Token(Token = "0x4037D09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
