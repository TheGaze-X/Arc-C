using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D6F RID: 28015
	[Token(Token = "0x2006D6F")]
	public abstract class ActivityBattleFinishView : ActivityAssetHolder, IBattleFinishDynView
	{
		// Token: 0x06027EBE RID: 163518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EBE")]
		[Address(RVA = "0x23349C0", Offset = "0x23335C0", VA = "0x1823349C0", Slot = "4")]
		public sealed override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027EBF RID: 163519 RVA: 0x000D0188 File Offset: 0x000CE388
		[Token(Token = "0x6027EBF")]
		[Address(RVA = "0x2334AE0", Offset = "0x23336E0", VA = "0x182334AE0", Slot = "7")]
		protected sealed override bool LockAspect(string curAspect, Action<string> setAspect)
		{
			return default(bool);
		}

		// Token: 0x06027EC0 RID: 163520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EC0")]
		[Address(RVA = "0x2334C50", Offset = "0x2333850", VA = "0x182334C50", Slot = "8")]
		public void TriggerInit(State state)
		{
		}

		// Token: 0x06027EC1 RID: 163521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EC1")]
		[Address(RVA = "0x2334BC0", Offset = "0x23337C0", VA = "0x182334BC0", Slot = "10")]
		public virtual IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06027EC2 RID: 163522
		[Token(Token = "0x6027EC2")]
		protected abstract void OnInit();

		// Token: 0x06027EC3 RID: 163523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EC3")]
		[Address(RVA = "0x2334CF0", Offset = "0x23338F0", VA = "0x182334CF0")]
		protected ActivityBattleFinishView()
		{
		}

		// Token: 0x06027EC4 RID: 163524 RVA: 0x000D01A0 File Offset: 0x000CE3A0
		[Token(Token = "0x6027EC4")]
		[Address(RVA = "0x1140F60", Offset = "0x113FB60", VA = "0x181140F60")]
		private bool <>xLuaBaseProxy_LockAspect(string P0, Action<string> P1)
		{
			return default(bool);
		}

		// Token: 0x04038957 RID: 231767
		[Token(Token = "0x4038957")]
		[FieldOffset(Offset = "0x28")]
		protected State m_state;

		// Token: 0x04038958 RID: 231768
		[Token(Token = "0x4038958")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038959 RID: 231769
		[Token(Token = "0x4038959")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LockAspect;

		// Token: 0x0403895A RID: 231770
		[Token(Token = "0x403895A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerInit;

		// Token: 0x0403895B RID: 231771
		[Token(Token = "0x403895B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403895C RID: 231772
		[Token(Token = "0x403895C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
