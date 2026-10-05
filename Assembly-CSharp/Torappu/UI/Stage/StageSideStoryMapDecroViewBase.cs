using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006816 RID: 26646
	[Token(Token = "0x2006816")]
	public abstract class StageSideStoryMapDecroViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A46 RID: 23110
		// (get) Token: 0x060262D8 RID: 156376 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060262D9 RID: 156377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005A46")]
		public Func<string, bool> focusZoneDelegate
		{
			[Token(Token = "0x60262D8")]
			[Address(RVA = "0x213CE70", Offset = "0x213BA70", VA = "0x18213CE70")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60262D9")]
			[Address(RVA = "0x213CED0", Offset = "0x213BAD0", VA = "0x18213CED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060262DA RID: 156378
		[Token(Token = "0x60262DA")]
		public abstract void OnRefresh(List<ZoneViewModel> viewModelList, ZoneViewModel selectViewModel);

		// Token: 0x060262DB RID: 156379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262DB")]
		[Address(RVA = "0x213CE10", Offset = "0x213BA10", VA = "0x18213CE10")]
		protected StageSideStoryMapDecroViewBase()
		{
		}

		// Token: 0x04035C8D RID: 220301
		[Token(Token = "0x4035C8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_focusZoneDelegate;

		// Token: 0x04035C8E RID: 220302
		[Token(Token = "0x4035C8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_focusZoneDelegate;

		// Token: 0x04035C8F RID: 220303
		[Token(Token = "0x4035C8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
