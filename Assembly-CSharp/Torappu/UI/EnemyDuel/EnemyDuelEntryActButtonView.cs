using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F8E RID: 20366
	[Token(Token = "0x2004F8E")]
	public class EnemyDuelEntryActButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E48D RID: 124045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E48D")]
		[Address(RVA = "0x17FB8D0", Offset = "0x17FA4D0", VA = "0x1817FB8D0")]
		public void Render(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E48E RID: 124046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E48E")]
		[Address(RVA = "0x17FB850", Offset = "0x17FA450", VA = "0x1817FB850")]
		public void OnClick()
		{
		}

		// Token: 0x0601E48F RID: 124047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E48F")]
		[Address(RVA = "0x17FB9C0", Offset = "0x17FA5C0", VA = "0x1817FB9C0")]
		public EnemyDuelEntryActButtonView()
		{
		}

		// Token: 0x040286A6 RID: 165542
		[Token(Token = "0x40286A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x040286A7 RID: 165543
		[Token(Token = "0x40286A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelOnEnd;

		// Token: 0x040286A8 RID: 165544
		[Token(Token = "0x40286A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x040286A9 RID: 165545
		[Token(Token = "0x40286A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _clickEvent;

		// Token: 0x040286AA RID: 165546
		[Token(Token = "0x40286AA")]
		[FieldOffset(Offset = "0x38")]
		private EnemyDuelEntryViewModel m_cachedModel;

		// Token: 0x040286AB RID: 165547
		[Token(Token = "0x40286AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040286AC RID: 165548
		[Token(Token = "0x40286AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040286AD RID: 165549
		[Token(Token = "0x40286AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
