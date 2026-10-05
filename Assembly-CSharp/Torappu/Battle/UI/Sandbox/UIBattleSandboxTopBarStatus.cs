using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C7 RID: 13255
	[Token(Token = "0x20033C7")]
	public class UIBattleSandboxTopBarStatus : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015261 RID: 86625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015261")]
		[Address(RVA = "0xD9E1D0", Offset = "0xD9CDD0", VA = "0x180D9E1D0")]
		public void OnInit(SandboxBattleStyle battleStyle)
		{
		}

		// Token: 0x06015262 RID: 86626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015262")]
		[Address(RVA = "0xD9E4D0", Offset = "0xD9D0D0", VA = "0x180D9E4D0")]
		public void UpdateData(BattleController controller, bool force)
		{
		}

		// Token: 0x06015263 RID: 86627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015263")]
		[Address(RVA = "0xD9EB00", Offset = "0xD9D700", VA = "0x180D9EB00")]
		private void _UpdateMonsterInfo(BattleController controller, bool force)
		{
		}

		// Token: 0x06015264 RID: 86628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015264")]
		[Address(RVA = "0xD9E8B0", Offset = "0xD9D4B0", VA = "0x180D9E8B0")]
		private void _SetRemainTimeInfo()
		{
		}

		// Token: 0x06015265 RID: 86629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015265")]
		[Address(RVA = "0xD9E7B0", Offset = "0xD9D3B0", VA = "0x180D9E7B0")]
		private void _SetCoreHpSlider()
		{
		}

		// Token: 0x06015266 RID: 86630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015266")]
		[Address(RVA = "0xD9EC70", Offset = "0xD9D870", VA = "0x180D9EC70")]
		public UIBattleSandboxTopBarStatus()
		{
		}

		// Token: 0x04019398 RID: 103320
		[Token(Token = "0x4019398")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Time")]
		private UITextSlider _remainTimeSlider;

		// Token: 0x04019399 RID: 103321
		[Token(Token = "0x4019399")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Time")]
		private Text _remainTimeText;

		// Token: 0x0401939A RID: 103322
		[Token(Token = "0x401939A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Time")]
		private Image _remainTimeSliderBg;

		// Token: 0x0401939B RID: 103323
		[Token(Token = "0x401939B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Time")]
		private Color _normalTimeColor;

		// Token: 0x0401939C RID: 103324
		[Token(Token = "0x401939C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Time")]
		private int _emergencyTimeThreshold;

		// Token: 0x0401939D RID: 103325
		[Token(Token = "0x401939D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Time")]
		private Animation _emergencyAnim;

		// Token: 0x0401939E RID: 103326
		[Token(Token = "0x401939E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("CoreHP")]
		private UITextSlider _coreHpSlider;

		// Token: 0x0401939F RID: 103327
		[Token(Token = "0x401939F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("CoreHP")]
		private Text _monsterInfoText;

		// Token: 0x040193A0 RID: 103328
		[Token(Token = "0x40193A0")]
		[FieldOffset(Offset = "0x60")]
		private SandboxBattleStyle m_battleStyle;

		// Token: 0x040193A1 RID: 103329
		[Token(Token = "0x40193A1")]
		[FieldOffset(Offset = "0x64")]
		private int m_cachedFinishedEnemiesCnt;

		// Token: 0x040193A2 RID: 103330
		[Token(Token = "0x40193A2")]
		[FieldOffset(Offset = "0x68")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x040193A3 RID: 103331
		[Token(Token = "0x40193A3")]
		[FieldOffset(Offset = "0x70")]
		private int m_remainTime;

		// Token: 0x040193A4 RID: 103332
		[Token(Token = "0x40193A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040193A5 RID: 103333
		[Token(Token = "0x40193A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040193A6 RID: 103334
		[Token(Token = "0x40193A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMonsterInfo;

		// Token: 0x040193A7 RID: 103335
		[Token(Token = "0x40193A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetRemainTimeInfo;

		// Token: 0x040193A8 RID: 103336
		[Token(Token = "0x40193A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetCoreHpSlider;

		// Token: 0x040193A9 RID: 103337
		[Token(Token = "0x40193A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
