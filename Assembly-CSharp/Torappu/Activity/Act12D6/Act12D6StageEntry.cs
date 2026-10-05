using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AD1 RID: 31441
	[Token(Token = "0x2007AD1")]
	public class Act12D6StageEntry : ActivityStageSingleComponent, IHotfixable
	{
		// Token: 0x0602C07E RID: 180350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C07E")]
		[Address(RVA = "0x27FCA30", Offset = "0x27FB630", VA = "0x1827FCA30", Slot = "4")]
		protected override void OnLoaded()
		{
		}

		// Token: 0x0602C07F RID: 180351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C07F")]
		[Address(RVA = "0x27FC980", Offset = "0x27FB580", VA = "0x1827FC980")]
		public void NotifyStageTimeout()
		{
		}

		// Token: 0x0602C080 RID: 180352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C080")]
		[Address(RVA = "0x27FC8D0", Offset = "0x27FB4D0", VA = "0x1827FC8D0")]
		public void NotifyRewardTimeout()
		{
		}

		// Token: 0x0602C081 RID: 180353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C081")]
		[Address(RVA = "0x27FC150", Offset = "0x27FAD50", VA = "0x1827FC150")]
		public void EventOnRetireClicked()
		{
		}

		// Token: 0x0602C082 RID: 180354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C082")]
		[Address(RVA = "0x27FC5B0", Offset = "0x27FB1B0", VA = "0x1827FC5B0")]
		public void EventOnStartGameClicked()
		{
		}

		// Token: 0x0602C083 RID: 180355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C083")]
		[Address(RVA = "0x27FC370", Offset = "0x27FAF70", VA = "0x1827FC370")]
		public void EventOnRetireConfirmClicked()
		{
		}

		// Token: 0x0602C084 RID: 180356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C084")]
		[Address(RVA = "0x27FBF70", Offset = "0x27FAB70", VA = "0x1827FBF70")]
		public void EventOnOuterBuffClicked()
		{
		}

		// Token: 0x0602C085 RID: 180357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C085")]
		[Address(RVA = "0x27FBE80", Offset = "0x27FAA80", VA = "0x1827FBE80")]
		public void EventOnMileStoneClicked()
		{
		}

		// Token: 0x0602C086 RID: 180358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C086")]
		[Address(RVA = "0x27FBBB0", Offset = "0x27FA7B0", VA = "0x1827FBBB0")]
		public void EventOnDifficultyToggleClicked(Toggle difficultyTg)
		{
		}

		// Token: 0x0602C087 RID: 180359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C087")]
		[Address(RVA = "0x27FBB00", Offset = "0x27FA700", VA = "0x1827FBB00")]
		public void EventOnDifficultyLockedClicked(string modeName)
		{
		}

		// Token: 0x0602C088 RID: 180360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C088")]
		[Address(RVA = "0x27FC060", Offset = "0x27FAC60", VA = "0x1827FC060")]
		public void EventOnRelicBookHandClicked()
		{
		}

		// Token: 0x0602C089 RID: 180361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C089")]
		[Address(RVA = "0x27FD330", Offset = "0x27FBF30", VA = "0x1827FD330")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602C08A RID: 180362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C08A")]
		[Address(RVA = "0x27FD280", Offset = "0x27FBE80", VA = "0x1827FD280")]
		private void _EventOnRogueLikeEnd()
		{
		}

		// Token: 0x0602C08B RID: 180363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C08B")]
		[Address(RVA = "0x27FD4F0", Offset = "0x27FC0F0", VA = "0x1827FD4F0")]
		public Act12D6StageEntry()
		{
		}

		// Token: 0x0602C08E RID: 180366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C08E")]
		[Address(RVA = "0x22DDCE0", Offset = "0x22DC8E0", VA = "0x1822DDCE0")]
		private void <>xLuaBaseProxy_OnLoaded()
		{
		}

		// Token: 0x0403FCB9 RID: 261305
		[Token(Token = "0x403FCB9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FCBA RID: 261306
		[Token(Token = "0x403FCBA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act12D6StageEntryView _view;

		// Token: 0x0403FCBB RID: 261307
		[Token(Token = "0x403FCBB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act12D6RetireConfirmView _unlockPanel;

		// Token: 0x0403FCBC RID: 261308
		[Token(Token = "0x403FCBC")]
		[FieldOffset(Offset = "0x38")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403FCBD RID: 261309
		[Token(Token = "0x403FCBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLoaded;

		// Token: 0x0403FCBE RID: 261310
		[Token(Token = "0x403FCBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyStageTimeout;

		// Token: 0x0403FCBF RID: 261311
		[Token(Token = "0x403FCBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_NotifyRewardTimeout;

		// Token: 0x0403FCC0 RID: 261312
		[Token(Token = "0x403FCC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRetireClicked;

		// Token: 0x0403FCC1 RID: 261313
		[Token(Token = "0x403FCC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnStartGameClicked;

		// Token: 0x0403FCC2 RID: 261314
		[Token(Token = "0x403FCC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnRetireConfirmClicked;

		// Token: 0x0403FCC3 RID: 261315
		[Token(Token = "0x403FCC3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnOuterBuffClicked;

		// Token: 0x0403FCC4 RID: 261316
		[Token(Token = "0x403FCC4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnMileStoneClicked;

		// Token: 0x0403FCC5 RID: 261317
		[Token(Token = "0x403FCC5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnDifficultyToggleClicked;

		// Token: 0x0403FCC6 RID: 261318
		[Token(Token = "0x403FCC6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnDifficultyLockedClicked;

		// Token: 0x0403FCC7 RID: 261319
		[Token(Token = "0x403FCC7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnRelicBookHandClicked;

		// Token: 0x0403FCC8 RID: 261320
		[Token(Token = "0x403FCC8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403FCC9 RID: 261321
		[Token(Token = "0x403FCC9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnRogueLikeEnd;

		// Token: 0x0403FCCA RID: 261322
		[Token(Token = "0x403FCCA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
