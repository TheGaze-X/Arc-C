using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA9 RID: 31401
	[Token(Token = "0x2007AA9")]
	public class Act12sideMapZoneCharmBtnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BFD4 RID: 180180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD4")]
		[Address(RVA = "0x27DB3B0", Offset = "0x27D9FB0", VA = "0x1827DB3B0")]
		public void Init(Action onBtnClick)
		{
		}

		// Token: 0x0602BFD5 RID: 180181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD5")]
		[Address(RVA = "0x27DB340", Offset = "0x27D9F40", VA = "0x1827DB340")]
		public void EventOnCharmBtnClick()
		{
		}

		// Token: 0x0602BFD6 RID: 180182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD6")]
		[Address(RVA = "0x27DB430", Offset = "0x27DA030", VA = "0x1827DB430")]
		public Act12sideMapZoneCharmBtnView()
		{
		}

		// Token: 0x0403FB87 RID: 260999
		[Token(Token = "0x403FB87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objBtnCharmRoom;

		// Token: 0x0403FB88 RID: 261000
		[Token(Token = "0x403FB88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objLockCharmRoom;

		// Token: 0x0403FB89 RID: 261001
		[Token(Token = "0x403FB89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objNew;

		// Token: 0x0403FB8A RID: 261002
		[Token(Token = "0x403FB8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objReuse;

		// Token: 0x0403FB8B RID: 261003
		[Token(Token = "0x403FB8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtCharmRoomLock;

		// Token: 0x0403FB8C RID: 261004
		[Token(Token = "0x403FB8C")]
		[FieldOffset(Offset = "0x40")]
		private Action m_onCharmBtnClick;

		// Token: 0x0403FB8D RID: 261005
		[Token(Token = "0x403FB8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FB8E RID: 261006
		[Token(Token = "0x403FB8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCharmBtnClick;

		// Token: 0x0403FB8F RID: 261007
		[Token(Token = "0x403FB8F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
