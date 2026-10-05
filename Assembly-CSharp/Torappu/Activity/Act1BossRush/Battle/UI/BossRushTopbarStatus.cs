using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle.UI
{
	// Token: 0x020070D9 RID: 28889
	[Token(Token = "0x20070D9")]
	[Serializable]
	public class BossRushTopbarStatus : IHotfixable
	{
		// Token: 0x06029105 RID: 168197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029105")]
		[Address(RVA = "0x2478360", Offset = "0x2476F60", VA = "0x182478360")]
		public void InitData(BattleController controller)
		{
		}

		// Token: 0x06029106 RID: 168198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029106")]
		[Address(RVA = "0x2478570", Offset = "0x2477170", VA = "0x182478570")]
		public void UpdateData(BattleController controller, bool force)
		{
		}

		// Token: 0x06029107 RID: 168199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029107")]
		[Address(RVA = "0x2478910", Offset = "0x2477510", VA = "0x182478910")]
		private void _UpdateMonsterInfo(bool force)
		{
		}

		// Token: 0x06029108 RID: 168200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029108")]
		[Address(RVA = "0x24783E0", Offset = "0x2476FE0", VA = "0x1824783E0")]
		public void OnShowWaveMessage()
		{
		}

		// Token: 0x06029109 RID: 168201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029109")]
		[Address(RVA = "0x2478AB0", Offset = "0x24776B0", VA = "0x182478AB0")]
		public BossRushTopbarStatus()
		{
		}

		// Token: 0x0403A9BB RID: 240059
		[Token(Token = "0x403A9BB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UILifePoint _lifePoint;

		// Token: 0x0403A9BC RID: 240060
		[Token(Token = "0x403A9BC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _monsterInfoText;

		// Token: 0x0403A9BD RID: 240061
		[Token(Token = "0x403A9BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _waveMessageText;

		// Token: 0x0403A9BE RID: 240062
		[Token(Token = "0x403A9BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UILifeLostGroup _lifeLostContainer;

		// Token: 0x0403A9BF RID: 240063
		[Token(Token = "0x403A9BF")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedFinishedEnemiesCnt;

		// Token: 0x0403A9C0 RID: 240064
		[Token(Token = "0x403A9C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0403A9C1 RID: 240065
		[Token(Token = "0x403A9C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0403A9C2 RID: 240066
		[Token(Token = "0x403A9C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateMonsterInfo;

		// Token: 0x0403A9C3 RID: 240067
		[Token(Token = "0x403A9C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShowWaveMessage;

		// Token: 0x0403A9C4 RID: 240068
		[Token(Token = "0x403A9C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
