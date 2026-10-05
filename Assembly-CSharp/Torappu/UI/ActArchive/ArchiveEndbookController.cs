using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B6E RID: 27502
	[Token(Token = "0x2006B6E")]
	public class ArchiveEndbookController : ActArchiveController
	{
		// Token: 0x060274BB RID: 160955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274BB")]
		[Address(RVA = "0x227CFA0", Offset = "0x227BBA0", VA = "0x18227CFA0", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060274BC RID: 160956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60274BC")]
		[Address(RVA = "0x227CDF0", Offset = "0x227B9F0", VA = "0x18227CDF0")]
		public List<DataBinder<EndbookProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060274BD RID: 160957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274BD")]
		[Address(RVA = "0x227D120", Offset = "0x227BD20", VA = "0x18227D120", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060274BE RID: 160958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274BE")]
		[Address(RVA = "0x227D020", Offset = "0x227BC20", VA = "0x18227D020")]
		public void OnEndItemClick(int index)
		{
		}

		// Token: 0x060274BF RID: 160959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274BF")]
		[Address(RVA = "0x227D0A0", Offset = "0x227BCA0", VA = "0x18227D0A0")]
		public void OnIndexConfirm(int index)
		{
		}

		// Token: 0x060274C0 RID: 160960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C0")]
		[Address(RVA = "0x227D1B0", Offset = "0x227BDB0", VA = "0x18227D1B0")]
		public ArchiveEndbookController()
		{
		}

		// Token: 0x060274C1 RID: 160961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C1")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060274C2 RID: 160962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60274C2")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x04037A39 RID: 227897
		[Token(Token = "0x4037A39")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveEndbookListDataBinder _dataBinder;

		// Token: 0x04037A3A RID: 227898
		[Token(Token = "0x4037A3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveEndbookDetailDataBinder _detailBinder;

		// Token: 0x04037A3B RID: 227899
		[Token(Token = "0x4037A3B")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<ActArchiveType, string> onItemClicked;

		// Token: 0x04037A3C RID: 227900
		[Token(Token = "0x4037A3C")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<ActArchiveType, int> onIndexConfirm;

		// Token: 0x04037A3D RID: 227901
		[Token(Token = "0x4037A3D")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<ActArchiveType, int> onEndItemClicked;

		// Token: 0x04037A3E RID: 227902
		[Token(Token = "0x4037A3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037A3F RID: 227903
		[Token(Token = "0x4037A3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037A40 RID: 227904
		[Token(Token = "0x4037A40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037A41 RID: 227905
		[Token(Token = "0x4037A41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEndItemClick;

		// Token: 0x04037A42 RID: 227906
		[Token(Token = "0x4037A42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnIndexConfirm;

		// Token: 0x04037A43 RID: 227907
		[Token(Token = "0x4037A43")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
