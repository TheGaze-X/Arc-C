using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007222 RID: 29218
	[Token(Token = "0x2007222")]
	public class Act5D1BattleFinishView : ActivityBattleFinishView
	{
		// Token: 0x060296A1 RID: 169633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296A1")]
		[Address(RVA = "0x24C4810", Offset = "0x24C3410", VA = "0x1824C4810", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x060296A2 RID: 169634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60296A2")]
		[Address(RVA = "0x24C4D40", Offset = "0x24C3940", VA = "0x1824C4D40")]
		private IEnumerator _PlayAnim()
		{
			return null;
		}

		// Token: 0x060296A3 RID: 169635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296A3")]
		[Address(RVA = "0x24C4720", Offset = "0x24C3320", VA = "0x1824C4720")]
		public void EventOnPageClicked()
		{
		}

		// Token: 0x060296A4 RID: 169636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296A4")]
		[Address(RVA = "0x24C4DF0", Offset = "0x24C39F0", VA = "0x1824C4DF0")]
		public Act5D1BattleFinishView()
		{
		}

		// Token: 0x0403B251 RID: 242257
		[Token(Token = "0x403B251")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RuneBattleFinishHolder _holder;

		// Token: 0x0403B252 RID: 242258
		[Token(Token = "0x403B252")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RuneBattleFinishEffView _effView;

		// Token: 0x0403B253 RID: 242259
		[Token(Token = "0x403B253")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RuneBattleFinishStateBean _stateBean;

		// Token: 0x0403B254 RID: 242260
		[Token(Token = "0x403B254")]
		private const float CLOSE_VIEW_DELAY = 2f;

		// Token: 0x0403B255 RID: 242261
		[Token(Token = "0x403B255")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isLoadingAnimEnd;

		// Token: 0x0403B256 RID: 242262
		[Token(Token = "0x403B256")]
		[FieldOffset(Offset = "0x4C")]
		private float m_animEndTime;

		// Token: 0x0403B257 RID: 242263
		[Token(Token = "0x403B257")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403B258 RID: 242264
		[Token(Token = "0x403B258")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403B259 RID: 242265
		[Token(Token = "0x403B259")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnPageClicked;

		// Token: 0x0403B25A RID: 242266
		[Token(Token = "0x403B25A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
