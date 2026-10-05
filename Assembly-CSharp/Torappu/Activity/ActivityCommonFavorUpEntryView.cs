using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D81 RID: 28033
	[Token(Token = "0x2006D81")]
	public class ActivityCommonFavorUpEntryView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x06027EF7 RID: 163575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005E67")]
		public UICommonTrackPoint favorUpTrackPoint
		{
			[Token(Token = "0x6027EF7")]
			[Address(RVA = "0x233AF30", Offset = "0x2339B30", VA = "0x18233AF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027EF8 RID: 163576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF8")]
		[Address(RVA = "0x233AE20", Offset = "0x2339A20", VA = "0x18233AE20")]
		public void UpdateView(List<string> favorUpList)
		{
		}

		// Token: 0x06027EF9 RID: 163577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EF9")]
		[Address(RVA = "0x233AED0", Offset = "0x2339AD0", VA = "0x18233AED0")]
		public ActivityCommonFavorUpEntryView()
		{
		}

		// Token: 0x040389A8 RID: 231848
		[Token(Token = "0x40389A8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _favorUpPanelGo;

		// Token: 0x040389A9 RID: 231849
		[Token(Token = "0x40389A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPanelGo;

		// Token: 0x040389AA RID: 231850
		[Token(Token = "0x40389AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _favorUpTrackPoint;

		// Token: 0x040389AB RID: 231851
		[Token(Token = "0x40389AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_favorUpTrackPoint;

		// Token: 0x040389AC RID: 231852
		[Token(Token = "0x40389AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040389AD RID: 231853
		[Token(Token = "0x40389AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
