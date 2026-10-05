using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B12 RID: 27410
	[Token(Token = "0x2006B12")]
	public class ArchiveBuffController : ActArchiveController
	{
		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x06027310 RID: 160528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027311 RID: 160529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C9E")]
		public Action<ActArchiveType, string> onItemClicked
		{
			[Token(Token = "0x6027310")]
			[Address(RVA = "0x2256740", Offset = "0x2255340", VA = "0x182256740")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027311")]
			[Address(RVA = "0x22567A0", Offset = "0x22553A0", VA = "0x1822567A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027312 RID: 160530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027312")]
		[Address(RVA = "0x2256580", Offset = "0x2255180", VA = "0x182256580", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x06027313 RID: 160531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027313")]
		[Address(RVA = "0x2256450", Offset = "0x2255050", VA = "0x182256450")]
		public List<DataBinder<BuffProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x06027314 RID: 160532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027314")]
		[Address(RVA = "0x22566A0", Offset = "0x22552A0", VA = "0x1822566A0")]
		public ArchiveBuffController()
		{
		}

		// Token: 0x06027315 RID: 160533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027315")]
		[Address(RVA = "0x224B370", Offset = "0x2249F70", VA = "0x18224B370")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x0403770A RID: 227082
		[Token(Token = "0x403770A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveBuffListDataBinder _buffDataBinder;

		// Token: 0x0403770C RID: 227084
		[Token(Token = "0x403770C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onItemClicked;

		// Token: 0x0403770D RID: 227085
		[Token(Token = "0x403770D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onItemClicked;

		// Token: 0x0403770E RID: 227086
		[Token(Token = "0x403770E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x0403770F RID: 227087
		[Token(Token = "0x403770F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037710 RID: 227088
		[Token(Token = "0x4037710")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
