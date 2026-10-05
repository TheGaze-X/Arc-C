using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717E RID: 29054
	[Token(Token = "0x200717E")]
	public class Act9D0SubMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293E9 RID: 168937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E9")]
		[Address(RVA = "0x24A5850", Offset = "0x24A4450", VA = "0x1824A5850")]
		public void Render(List<SubMissionViewModel> viewModelList)
		{
		}

		// Token: 0x060293EA RID: 168938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293EA")]
		[Address(RVA = "0x24A5AC0", Offset = "0x24A46C0", VA = "0x1824A5AC0")]
		public Act9D0SubMissionView()
		{
		}

		// Token: 0x0403AE7E RID: 241278
		[Token(Token = "0x403AE7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Act9D0SubMissionItem> _missionItemList;

		// Token: 0x0403AE7F RID: 241279
		[Token(Token = "0x403AE7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _keyItemId;

		// Token: 0x0403AE80 RID: 241280
		[Token(Token = "0x403AE80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _keyItemCount;

		// Token: 0x0403AE81 RID: 241281
		[Token(Token = "0x403AE81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE82 RID: 241282
		[Token(Token = "0x403AE82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
