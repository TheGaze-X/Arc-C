using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D7 RID: 28887
	[Token(Token = "0x20070D7")]
	public class BossRushHintPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060290FC RID: 168188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290FC")]
		[Address(RVA = "0x24763D0", Offset = "0x2474FD0", VA = "0x1824763D0")]
		public void OnGameInit()
		{
		}

		// Token: 0x060290FD RID: 168189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290FD")]
		[Address(RVA = "0x24762B0", Offset = "0x2474EB0", VA = "0x1824762B0")]
		public void HintDangerArea([Optional] object args)
		{
		}

		// Token: 0x060290FE RID: 168190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290FE")]
		[Address(RVA = "0x2476340", Offset = "0x2474F40", VA = "0x182476340")]
		public void OnBonusWaveFinished([Optional] object args)
		{
		}

		// Token: 0x060290FF RID: 168191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290FF")]
		[Address(RVA = "0x24765D0", Offset = "0x24751D0", VA = "0x1824765D0")]
		public BossRushHintPanel()
		{
		}

		// Token: 0x0403A9AC RID: 240044
		[Token(Token = "0x403A9AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _panelDangerArea;

		// Token: 0x0403A9AD RID: 240045
		[Token(Token = "0x403A9AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRushCountdownDisplay _bossRushCountdownDisplay;

		// Token: 0x0403A9AE RID: 240046
		[Token(Token = "0x403A9AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403A9AF RID: 240047
		[Token(Token = "0x403A9AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HintDangerArea;

		// Token: 0x0403A9B0 RID: 240048
		[Token(Token = "0x403A9B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBonusWaveFinished;

		// Token: 0x0403A9B1 RID: 240049
		[Token(Token = "0x403A9B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
