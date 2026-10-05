using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B9E RID: 27550
	[Token(Token = "0x2006B9E")]
	public class ArchiveLogController : ActArchiveController
	{
		// Token: 0x06027592 RID: 161170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027592")]
		[Address(RVA = "0x2285700", Offset = "0x2284300", VA = "0x182285700", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027593 RID: 161171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027593")]
		[Address(RVA = "0x22855D0", Offset = "0x22841D0", VA = "0x1822855D0")]
		public List<DataBinder<LogProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027594 RID: 161172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027594")]
		[Address(RVA = "0x2285780", Offset = "0x2284380", VA = "0x182285780")]
		public ArchiveLogController()
		{
		}

		// Token: 0x06027595 RID: 161173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027595")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x04037BE8 RID: 228328
		[Token(Token = "0x4037BE8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveLogDataBinder _logBinder;

		// Token: 0x04037BE9 RID: 228329
		[Token(Token = "0x4037BE9")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<ActArchiveType, string> onLogItemClicked;

		// Token: 0x04037BEA RID: 228330
		[Token(Token = "0x4037BEA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037BEB RID: 228331
		[Token(Token = "0x4037BEB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037BEC RID: 228332
		[Token(Token = "0x4037BEC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
