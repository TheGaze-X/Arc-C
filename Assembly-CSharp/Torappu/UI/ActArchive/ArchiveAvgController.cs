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
	// Token: 0x02006B06 RID: 27398
	[Token(Token = "0x2006B06")]
	public class ArchiveAvgController : ActArchiveController
	{
		// Token: 0x060272CE RID: 160462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272CE")]
		[Address(RVA = "0x2253CF0", Offset = "0x22528F0", VA = "0x182253CF0", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060272CF RID: 160463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272CF")]
		[Address(RVA = "0x22539C0", Offset = "0x22525C0", VA = "0x1822539C0")]
		public List<DataBinder<AvgProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060272D0 RID: 160464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272D0")]
		[Address(RVA = "0x2253AF0", Offset = "0x22526F0", VA = "0x182253AF0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060272D1 RID: 160465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272D1")]
		[Address(RVA = "0x2253D70", Offset = "0x2252970", VA = "0x182253D70", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060272D2 RID: 160466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272D2")]
		[Address(RVA = "0x2253EE0", Offset = "0x2252AE0", VA = "0x182253EE0")]
		public ArchiveAvgController()
		{
		}

		// Token: 0x060272D3 RID: 160467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272D3")]
		[Address(RVA = "0x224B370", Offset = "0x2249F70", VA = "0x18224B370")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060272D4 RID: 160468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272D4")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060272D5 RID: 160469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272D5")]
		[Address(RVA = "0x2253E30", Offset = "0x2252A30", VA = "0x182253E30")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x040376AE RID: 226990
		[Token(Token = "0x40376AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveAvgListDataBinder _avgListBinder;

		// Token: 0x040376AF RID: 226991
		[Token(Token = "0x40376AF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x040376B0 RID: 226992
		[Token(Token = "0x40376B0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x040376B1 RID: 226993
		[Token(Token = "0x40376B1")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<ActArchiveType, string> onAvgItemClicked;

		// Token: 0x040376B2 RID: 226994
		[Token(Token = "0x40376B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x040376B3 RID: 226995
		[Token(Token = "0x40376B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x040376B4 RID: 226996
		[Token(Token = "0x40376B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040376B5 RID: 226997
		[Token(Token = "0x40376B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x040376B6 RID: 226998
		[Token(Token = "0x40376B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
