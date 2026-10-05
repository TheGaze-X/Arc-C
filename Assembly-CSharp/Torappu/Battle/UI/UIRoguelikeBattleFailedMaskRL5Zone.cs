using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003343 RID: 13123
	[Token(Token = "0x2003343")]
	public class UIRoguelikeBattleFailedMaskRL5Zone : UIRoguelikeBattleFailedMask
	{
		// Token: 0x06014EF3 RID: 85747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF3")]
		[Address(RVA = "0xD60170", Offset = "0xD5ED70", VA = "0x180D60170")]
		public void BattleFailedPanelDataSender(UIRoguelikeBattleFailedMaskRL5Zone.RL5ZoneFailedPanelData data)
		{
		}

		// Token: 0x06014EF4 RID: 85748 RVA: 0x000897F0 File Offset: 0x000879F0
		[Token(Token = "0x6014EF4")]
		[Address(RVA = "0xD60240", Offset = "0xD5EE40", VA = "0x180D60240", Slot = "7")]
		public override bool BattleFailedPanelShow(string topicId, RoguelikeTopicMode mode)
		{
			return default(bool);
		}

		// Token: 0x06014EF5 RID: 85749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EF5")]
		[Address(RVA = "0xD60460", Offset = "0xD5F060", VA = "0x180D60460")]
		public UIRoguelikeBattleFailedMaskRL5Zone()
		{
		}

		// Token: 0x06014EF6 RID: 85750 RVA: 0x00089808 File Offset: 0x00087A08
		[Token(Token = "0x6014EF6")]
		[Address(RVA = "0xD60450", Offset = "0xD5F050", VA = "0x180D60450")]
		private bool <>xLuaBaseProxy_BattleFailedPanelShow(string P0, RoguelikeTopicMode P1)
		{
			return default(bool);
		}

		// Token: 0x04018E4D RID: 101965
		[Token(Token = "0x4018E4D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textEnemyTotalNum;

		// Token: 0x04018E4E RID: 101966
		[Token(Token = "0x4018E4E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textEnemyRemainNum;

		// Token: 0x04018E4F RID: 101967
		[Token(Token = "0x4018E4F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Slider _enemyRemainSlider;

		// Token: 0x04018E50 RID: 101968
		[Token(Token = "0x4018E50")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04018E51 RID: 101969
		[Token(Token = "0x4018E51")]
		[FieldOffset(Offset = "0x70")]
		private UIRoguelikeBattleFailedMaskRL5Zone.RL5ZoneFailedPanelData m_rl5ZoneFailedPanelData;

		// Token: 0x04018E52 RID: 101970
		[Token(Token = "0x4018E52")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelDataSender;

		// Token: 0x04018E53 RID: 101971
		[Token(Token = "0x4018E53")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BattleFailedPanelShow;

		// Token: 0x04018E54 RID: 101972
		[Token(Token = "0x4018E54")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003344 RID: 13124
		[Token(Token = "0x2003344")]
		public class RL5ZoneFailedPanelData
		{
			// Token: 0x06014EF7 RID: 85751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6014EF7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RL5ZoneFailedPanelData()
			{
			}

			// Token: 0x04018E55 RID: 101973
			[Token(Token = "0x4018E55")]
			[FieldOffset(Offset = "0x10")]
			public int enemyTotalNum;

			// Token: 0x04018E56 RID: 101974
			[Token(Token = "0x4018E56")]
			[FieldOffset(Offset = "0x14")]
			public int enemyRemainNum;
		}
	}
}
