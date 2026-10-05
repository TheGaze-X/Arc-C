using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002444 RID: 9284
	[Token(Token = "0x2002444")]
	public class AdvancedToggleSkill : ToggleSkillWithEndAnimation
	{
		// Token: 0x0600ED5D RID: 60765 RVA: 0x00056B80 File Offset: 0x00054D80
		[Token(Token = "0x600ED5D")]
		[Address(RVA = "0x634420", Offset = "0x633020", VA = "0x180634420", Slot = "24")]
		public override bool IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600ED5E RID: 60766 RVA: 0x00056B98 File Offset: 0x00054D98
		[Token(Token = "0x17001E88")]
		protected override bool canSkipReduceSp
		{
			[Token(Token = "0x600ED5E")]
			[Address(RVA = "0x634740", Offset = "0x633340", VA = "0x180634740", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x0600ED5F RID: 60767 RVA: 0x00056BB0 File Offset: 0x00054DB0
		[Token(Token = "0x17001E89")]
		public override bool isAffecting
		{
			[Token(Token = "0x600ED5F")]
			[Address(RVA = "0x6347B0", Offset = "0x6333B0", VA = "0x1806347B0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x0600ED60 RID: 60768 RVA: 0x00056BC8 File Offset: 0x00054DC8
		[Token(Token = "0x17001E8A")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600ED60")]
			[Address(RVA = "0x634810", Offset = "0x633410", VA = "0x180634810", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600ED61 RID: 60769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED61")]
		[Address(RVA = "0x6344B0", Offset = "0x6330B0", VA = "0x1806344B0", Slot = "68")]
		public override void PlayBeginAudio()
		{
		}

		// Token: 0x0600ED62 RID: 60770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED62")]
		[Address(RVA = "0x6346E0", Offset = "0x6332E0", VA = "0x1806346E0")]
		public AdvancedToggleSkill()
		{
		}

		// Token: 0x0600ED63 RID: 60771 RVA: 0x00056BE0 File Offset: 0x00054DE0
		[Token(Token = "0x600ED63")]
		[Address(RVA = "0x6345F0", Offset = "0x6331F0", VA = "0x1806345F0")]
		private bool <>xLuaBaseProxy_IsDiscardable()
		{
			return default(bool);
		}

		// Token: 0x0600ED64 RID: 60772 RVA: 0x00056BF8 File Offset: 0x00054DF8
		[Token(Token = "0x600ED64")]
		[Address(RVA = "0x634660", Offset = "0x633260", VA = "0x180634660")]
		private bool <>xLuaBaseProxy_get_canSkipReduceSp()
		{
			return default(bool);
		}

		// Token: 0x0600ED65 RID: 60773 RVA: 0x00056C10 File Offset: 0x00054E10
		[Token(Token = "0x600ED65")]
		[Address(RVA = "0x6346C0", Offset = "0x6332C0", VA = "0x1806346C0")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600ED66 RID: 60774 RVA: 0x00056C28 File Offset: 0x00054E28
		[Token(Token = "0x600ED66")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600ED67 RID: 60775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ED67")]
		[Address(RVA = "0x634650", Offset = "0x633250", VA = "0x180634650")]
		private void <>xLuaBaseProxy_PlayBeginAudio()
		{
		}

		// Token: 0x04010682 RID: 67202
		[Token(Token = "0x4010682")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private bool _useOnSkillFinishSignal;

		// Token: 0x04010683 RID: 67203
		[Token(Token = "0x4010683")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDiscardable;

		// Token: 0x04010684 RID: 67204
		[Token(Token = "0x4010684")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canSkipReduceSp;

		// Token: 0x04010685 RID: 67205
		[Token(Token = "0x4010685")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04010686 RID: 67206
		[Token(Token = "0x4010686")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x04010687 RID: 67207
		[Token(Token = "0x4010687")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayBeginAudio;

		// Token: 0x04010688 RID: 67208
		[Token(Token = "0x4010688")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
