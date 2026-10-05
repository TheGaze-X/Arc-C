using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006947 RID: 26951
	[Token(Token = "0x2006947")]
	public class StageAdditionalBtnPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602695F RID: 158047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602695F")]
		[Address(RVA = "0x21A7BF0", Offset = "0x21A67F0", VA = "0x1821A7BF0")]
		public void OnUpdate(ZoneViewModel model)
		{
		}

		// Token: 0x06026960 RID: 158048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026960")]
		[Address(RVA = "0x21A7D50", Offset = "0x21A6950", VA = "0x1821A7D50")]
		public StageAdditionalBtnPanel()
		{
		}

		// Token: 0x04036704 RID: 222980
		[Token(Token = "0x4036704")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<StageAdditionalBtnView> _views;

		// Token: 0x04036705 RID: 222981
		[Token(Token = "0x4036705")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x04036706 RID: 222982
		[Token(Token = "0x4036706")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
