using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Battle.Roguelike;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002404 RID: 9220
	[Token(Token = "0x2002404")]
	[CreateAssetMenu(menuName = "Torappu/Roguelike/Battle/RoguelikeBattleTopicHolder")]
	public class RoguelikeBattleTopicHolder : ScriptableObject, IHotfixable
	{
		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600EBBF RID: 60351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E1D")]
		public string rogue3HideUILifePoint
		{
			[Token(Token = "0x600EBBF")]
			[Address(RVA = "0x617000", Offset = "0x615C00", VA = "0x180617000")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EBC0")]
		[Address(RVA = "0x616D40", Offset = "0x615940", VA = "0x180616D40")]
		public Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor(RoguelikeInput input, GameModeFactory.RoguelikeGameMode gameMode)
		{
			return null;
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBC1")]
		[Address(RVA = "0x616EC0", Offset = "0x615AC0", VA = "0x180616EC0")]
		public RoguelikeBattleTopicHolder()
		{
		}

		// Token: 0x04010475 RID: 66677
		[Token(Token = "0x4010475")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("rogue topic id")]
		private string m_rogue1;

		// Token: 0x04010476 RID: 66678
		[Token(Token = "0x4010476")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("rogue topic id")]
		private string m_rogue2;

		// Token: 0x04010477 RID: 66679
		[Token(Token = "0x4010477")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("rogue topic id")]
		private string m_rogue3;

		// Token: 0x04010478 RID: 66680
		[Token(Token = "0x4010478")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("rogue topic id")]
		private string m_rogue4;

		// Token: 0x04010479 RID: 66681
		[Token(Token = "0x4010479")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("rogue topic id")]
		private string m_rogue5;

		// Token: 0x0401047A RID: 66682
		[Token(Token = "0x401047A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("rogue extra messages")]
		private string m_rogue3HideUILifePoint;

		// Token: 0x0401047B RID: 66683
		[Token(Token = "0x401047B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_rogue3HideUILifePoint;

		// Token: 0x0401047C RID: 66684
		[Token(Token = "0x401047C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSchedulerPreprocessor;

		// Token: 0x0401047D RID: 66685
		[Token(Token = "0x401047D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
