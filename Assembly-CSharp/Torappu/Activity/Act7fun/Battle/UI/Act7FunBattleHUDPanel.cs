using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act7Fun.Battle.UI
{
	// Token: 0x020071A1 RID: 29089
	[Token(Token = "0x20071A1")]
	public class Act7FunBattleHUDPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602945C RID: 169052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602945C")]
		[Address(RVA = "0x24B9130", Offset = "0x24B7D30", VA = "0x1824B9130")]
		public void OnPanelInit()
		{
		}

		// Token: 0x0602945D RID: 169053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602945D")]
		[Address(RVA = "0x24B9700", Offset = "0x24B8300", VA = "0x1824B9700")]
		private void _OnTrapKilled(object obj)
		{
		}

		// Token: 0x0602945E RID: 169054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602945E")]
		[Address(RVA = "0x24B9540", Offset = "0x24B8140", VA = "0x1824B9540")]
		private void _OnBattleStartStateExit(object obj)
		{
		}

		// Token: 0x0602945F RID: 169055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602945F")]
		[Address(RVA = "0x24B9BD0", Offset = "0x24B87D0", VA = "0x1824B9BD0")]
		public Act7FunBattleHUDPanel()
		{
		}

		// Token: 0x0403AF1B RID: 241435
		[Token(Token = "0x403AF1B")]
		private const string TRAP_ICON_SHOW_ANIM = "act7fun_battle_hud_trap_entry";

		// Token: 0x0403AF1C RID: 241436
		[Token(Token = "0x403AF1C")]
		private const string TRAP_ICON_BOOM_ANIM = "act7fun_battle_hud_trap_kuso_explode";

		// Token: 0x0403AF1D RID: 241437
		[Token(Token = "0x403AF1D")]
		private const string AVATAR_BOOM_ANIM = "act7fun_battle_hud_avatar_explode";

		// Token: 0x0403AF1E RID: 241438
		[Token(Token = "0x403AF1E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Trap")]
		private AnimationWrapper _trapIcon;

		// Token: 0x0403AF1F RID: 241439
		[Token(Token = "0x403AF1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Trap")]
		private RectTransform _trapContainer;

		// Token: 0x0403AF20 RID: 241440
		[Token(Token = "0x403AF20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Score")]
		private RectTransform _scoreNormal;

		// Token: 0x0403AF21 RID: 241441
		[Token(Token = "0x403AF21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Score")]
		private RectTransform _scoreTarget;

		// Token: 0x0403AF22 RID: 241442
		[Token(Token = "0x403AF22")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Score")]
		private RectTransform _scoreAdvance;

		// Token: 0x0403AF23 RID: 241443
		[Token(Token = "0x403AF23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Score")]
		private Text _scoreValue;

		// Token: 0x0403AF24 RID: 241444
		[Token(Token = "0x403AF24")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Avatar")]
		private RectTransform _normalMode;

		// Token: 0x0403AF25 RID: 241445
		[Token(Token = "0x403AF25")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Avatar")]
		private RectTransform _hurtMode;

		// Token: 0x0403AF26 RID: 241446
		[Token(Token = "0x403AF26")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Avatar")]
		private RectTransform _superHurtMode;

		// Token: 0x0403AF27 RID: 241447
		[Token(Token = "0x403AF27")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Avatar")]
		private RectTransform _dieMode;

		// Token: 0x0403AF28 RID: 241448
		[Token(Token = "0x403AF28")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Avatar")]
		private AnimationWrapper _dieAnim;

		// Token: 0x0403AF29 RID: 241449
		[Token(Token = "0x403AF29")]
		[FieldOffset(Offset = "0x70")]
		private GameModeFactory.Act7FunGameMode m_gameMode;

		// Token: 0x0403AF2A RID: 241450
		[Token(Token = "0x403AF2A")]
		[FieldOffset(Offset = "0x78")]
		private List<AnimationWrapper> m_trapIcons;

		// Token: 0x0403AF2B RID: 241451
		[Token(Token = "0x403AF2B")]
		[FieldOffset(Offset = "0x80")]
		private int m_curTrap;

		// Token: 0x0403AF2C RID: 241452
		[Token(Token = "0x403AF2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPanelInit;

		// Token: 0x0403AF2D RID: 241453
		[Token(Token = "0x403AF2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnTrapKilled;

		// Token: 0x0403AF2E RID: 241454
		[Token(Token = "0x403AF2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBattleStartStateExit;

		// Token: 0x0403AF2F RID: 241455
		[Token(Token = "0x403AF2F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
