using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006817 RID: 26647
	[Token(Token = "0x2006817")]
	public class StageSideStoryMapDecroView : StageSideStoryMapDecroViewBase, IHotfixable
	{
		// Token: 0x060262DC RID: 156380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262DC")]
		[Address(RVA = "0x213D310", Offset = "0x213BF10", VA = "0x18213D310")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262DD RID: 156381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262DD")]
		[Address(RVA = "0x213CFB0", Offset = "0x213BBB0", VA = "0x18213CFB0", Slot = "4")]
		public override void OnRefresh(List<ZoneViewModel> viewModelList, ZoneViewModel selectViewModel)
		{
		}

		// Token: 0x060262DE RID: 156382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262DE")]
		[Address(RVA = "0x213D450", Offset = "0x213C050", VA = "0x18213D450")]
		private void _OnZoneClicked(string zoneId)
		{
		}

		// Token: 0x060262DF RID: 156383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262DF")]
		[Address(RVA = "0x213D5F0", Offset = "0x213C1F0", VA = "0x18213D5F0")]
		public StageSideStoryMapDecroView()
		{
		}

		// Token: 0x04035C90 RID: 220304
		[Token(Token = "0x4035C90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<StageSideStoryZoneTabView> _zoneViews;

		// Token: 0x04035C91 RID: 220305
		[Token(Token = "0x4035C91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<StageSideStoryMapDecroViewPlugin> _plugins;

		// Token: 0x04035C92 RID: 220306
		[Token(Token = "0x4035C92")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04035C93 RID: 220307
		[Token(Token = "0x4035C93")]
		[FieldOffset(Offset = "0x38")]
		private string m_selectZoneId;

		// Token: 0x04035C94 RID: 220308
		[Token(Token = "0x4035C94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035C95 RID: 220309
		[Token(Token = "0x4035C95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x04035C96 RID: 220310
		[Token(Token = "0x4035C96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnZoneClicked;

		// Token: 0x04035C97 RID: 220311
		[Token(Token = "0x4035C97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
