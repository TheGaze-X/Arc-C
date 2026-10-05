using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D5 RID: 28885
	[Token(Token = "0x20070D5")]
	public class BossRushCountdownDisplay : MonoBehaviour, IHotfixable
	{
		// Token: 0x060290F4 RID: 168180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290F4")]
		[Address(RVA = "0x2475E00", Offset = "0x2474A00", VA = "0x182475E00")]
		public void OnGameInit()
		{
		}

		// Token: 0x060290F5 RID: 168181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290F5")]
		[Address(RVA = "0x2475FE0", Offset = "0x2474BE0", VA = "0x182475FE0")]
		public void ShowSwitchWaveSlider(object args)
		{
		}

		// Token: 0x060290F6 RID: 168182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290F6")]
		[Address(RVA = "0x2475D40", Offset = "0x2474940", VA = "0x182475D40")]
		public void HideSwitchWaveSlider(object args)
		{
		}

		// Token: 0x060290F7 RID: 168183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290F7")]
		[Address(RVA = "0x2476250", Offset = "0x2474E50", VA = "0x182476250")]
		public BossRushCountdownDisplay()
		{
		}

		// Token: 0x0403A9A5 RID: 240037
		[Token(Token = "0x403A9A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider _sliderCountDown;

		// Token: 0x0403A9A6 RID: 240038
		[Token(Token = "0x403A9A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x0403A9A7 RID: 240039
		[Token(Token = "0x403A9A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowSwitchWaveSlider;

		// Token: 0x0403A9A8 RID: 240040
		[Token(Token = "0x403A9A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideSwitchWaveSlider;

		// Token: 0x0403A9A9 RID: 240041
		[Token(Token = "0x403A9A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
