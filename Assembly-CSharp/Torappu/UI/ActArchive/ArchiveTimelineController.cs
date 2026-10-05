using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C2D RID: 27693
	[Token(Token = "0x2006C2D")]
	public class ArchiveTimelineController : ActArchiveController
	{
		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0602788A RID: 161930 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602788B RID: 161931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D4F")]
		public ArchiveTimelineResHolder subResHolder
		{
			[Token(Token = "0x602788A")]
			[Address(RVA = "0x22B72C0", Offset = "0x22B5EC0", VA = "0x1822B72C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602788B")]
			[Address(RVA = "0x22B7320", Offset = "0x22B5F20", VA = "0x1822B7320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602788C RID: 161932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602788C")]
		[Address(RVA = "0x22B6DB0", Offset = "0x22B59B0", VA = "0x1822B6DB0")]
		public List<DataBinder<TimelineProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x0602788D RID: 161933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602788D")]
		[Address(RVA = "0x22B6F40", Offset = "0x22B5B40", VA = "0x1822B6F40", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x0602788E RID: 161934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602788E")]
		[Address(RVA = "0x22B7100", Offset = "0x22B5D00", VA = "0x1822B7100", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x0602788F RID: 161935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602788F")]
		[Address(RVA = "0x22B71A0", Offset = "0x22B5DA0", VA = "0x1822B71A0", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x06027890 RID: 161936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027890")]
		[Address(RVA = "0x22B7260", Offset = "0x22B5E60", VA = "0x1822B7260")]
		public ArchiveTimelineController()
		{
		}

		// Token: 0x06027891 RID: 161937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027891")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x06027892 RID: 161938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027892")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027893 RID: 161939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027893")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x040380D8 RID: 229592
		[Token(Token = "0x40380D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveTimelineDataBinder _timelineListBinder;

		// Token: 0x040380D9 RID: 229593
		[Token(Token = "0x40380D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveTimelineLeftButtonDataBinder _timelineLeftButtonBinder;

		// Token: 0x040380DA RID: 229594
		[Token(Token = "0x40380DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x040380DB RID: 229595
		[Token(Token = "0x40380DB")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<ActArchiveType> onTimelineCategoryClicked;

		// Token: 0x040380DC RID: 229596
		[Token(Token = "0x40380DC")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<ActArchiveType, string> onTimelineItemClicked;

		// Token: 0x040380DE RID: 229598
		[Token(Token = "0x40380DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subResHolder;

		// Token: 0x040380DF RID: 229599
		[Token(Token = "0x40380DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_subResHolder;

		// Token: 0x040380E0 RID: 229600
		[Token(Token = "0x40380E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x040380E1 RID: 229601
		[Token(Token = "0x40380E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040380E2 RID: 229602
		[Token(Token = "0x40380E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040380E3 RID: 229603
		[Token(Token = "0x40380E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040380E4 RID: 229604
		[Token(Token = "0x40380E4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
