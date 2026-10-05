using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200621C RID: 25116
	[Token(Token = "0x200621C")]
	public abstract class DynBattleFinishView : MonoBehaviour, IBattleFinishDynView, IHotfixable
	{
		// Token: 0x060243C8 RID: 148424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243C8")]
		[Address(RVA = "0x1F1BB40", Offset = "0x1F1A740", VA = "0x181F1BB40", Slot = "4")]
		public void TriggerInit(State state)
		{
		}

		// Token: 0x060243C9 RID: 148425
		[Token(Token = "0x60243C9")]
		protected abstract void OnInit();

		// Token: 0x060243CA RID: 148426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60243CA")]
		[Address(RVA = "0x1F1BAB0", Offset = "0x1F1A6B0", VA = "0x181F1BAB0", Slot = "7")]
		public virtual IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x060243CB RID: 148427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243CB")]
		[Address(RVA = "0x1F1BBE0", Offset = "0x1F1A7E0", VA = "0x181F1BBE0")]
		protected DynBattleFinishView()
		{
		}

		// Token: 0x04032629 RID: 206377
		[Token(Token = "0x4032629")]
		[FieldOffset(Offset = "0x18")]
		protected State m_state;

		// Token: 0x0403262A RID: 206378
		[Token(Token = "0x403262A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerInit;

		// Token: 0x0403262B RID: 206379
		[Token(Token = "0x403262B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403262C RID: 206380
		[Token(Token = "0x403262C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
