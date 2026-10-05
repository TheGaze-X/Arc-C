using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200746E RID: 29806
	[Token(Token = "0x200746E")]
	public class Act36sideZoneMapContainerArrowView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A0B8 RID: 172216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0B8")]
		[Address(RVA = "0x25A22E0", Offset = "0x25A0EE0", VA = "0x1825A22E0")]
		public void Render(bool active)
		{
		}

		// Token: 0x0602A0B9 RID: 172217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0B9")]
		[Address(RVA = "0x25A2270", Offset = "0x25A0E70", VA = "0x1825A2270")]
		public void OnClick()
		{
		}

		// Token: 0x0602A0BA RID: 172218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BA")]
		[Address(RVA = "0x25A2380", Offset = "0x25A0F80", VA = "0x1825A2380")]
		public Act36sideZoneMapContainerArrowView()
		{
		}

		// Token: 0x0403C53E RID: 247102
		[Token(Token = "0x403C53E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _iconActive;

		// Token: 0x0403C53F RID: 247103
		[Token(Token = "0x403C53F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _iconInactive;

		// Token: 0x0403C540 RID: 247104
		[Token(Token = "0x403C540")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0403C541 RID: 247105
		[Token(Token = "0x403C541")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action onArrowClick;

		// Token: 0x0403C542 RID: 247106
		[Token(Token = "0x403C542")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C543 RID: 247107
		[Token(Token = "0x403C543")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403C544 RID: 247108
		[Token(Token = "0x403C544")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
