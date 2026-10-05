using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003510 RID: 13584
	[Token(Token = "0x2003510")]
	public class UICharacterSortFilterStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06015AA3 RID: 88739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015AA3")]
		[Address(RVA = "0xE43060", Offset = "0xE41C60", VA = "0x180E43060")]
		public UICharacterSortFilterStateBean()
		{
		}

		// Token: 0x04019FDB RID: 106459
		[Token(Token = "0x4019FDB")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public CharacterSortType sortType;

		// Token: 0x04019FDC RID: 106460
		[Token(Token = "0x4019FDC")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public CharacterFilterViewModel filter;

		// Token: 0x04019FDD RID: 106461
		[Token(Token = "0x4019FDD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
