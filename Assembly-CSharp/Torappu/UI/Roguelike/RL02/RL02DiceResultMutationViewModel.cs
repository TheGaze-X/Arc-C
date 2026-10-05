using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200573C RID: 22332
	[Token(Token = "0x200573C")]
	public class RL02DiceResultMutationViewModel : RoguelikeDiceResultViewModel
	{
		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x06020B9D RID: 134045 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020B9E RID: 134046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CB9")]
		public Sprite mutationIcon
		{
			[Token(Token = "0x6020B9D")]
			[Address(RVA = "0x1B07CA0", Offset = "0x1B068A0", VA = "0x181B07CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020B9E")]
			[Address(RVA = "0x1B07E70", Offset = "0x1B06A70", VA = "0x181B07E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x06020B9F RID: 134047 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BA0 RID: 134048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CBA")]
		public string desc
		{
			[Token(Token = "0x6020B9F")]
			[Address(RVA = "0x1B07C40", Offset = "0x1B06840", VA = "0x181B07C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020BA0")]
			[Address(RVA = "0x1B07DF0", Offset = "0x1B069F0", VA = "0x181B07DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x06020BA1 RID: 134049 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BA2 RID: 134050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CBB")]
		public string tips
		{
			[Token(Token = "0x6020BA1")]
			[Address(RVA = "0x1B07D00", Offset = "0x1B06900", VA = "0x181B07D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020BA2")]
			[Address(RVA = "0x1B07EF0", Offset = "0x1B06AF0", VA = "0x181B07EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004CBC RID: 19644
		// (get) Token: 0x06020BA3 RID: 134051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CBC")]
		public override Type viewType
		{
			[Token(Token = "0x6020BA3")]
			[Address(RVA = "0x1B07D60", Offset = "0x1B06960", VA = "0x181B07D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020BA4 RID: 134052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BA4")]
		[Address(RVA = "0x1B07680", Offset = "0x1B06280", VA = "0x181B07680", Slot = "5")]
		public override void LoadFromPlayerData(string topicId, PlayerRoguelikePendingEvent.Dice.Result result, RoguelikeDiceRuleData data)
		{
		}

		// Token: 0x06020BA5 RID: 134053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BA5")]
		[Address(RVA = "0x1B07BE0", Offset = "0x1B067E0", VA = "0x181B07BE0")]
		public RL02DiceResultMutationViewModel()
		{
		}

		// Token: 0x0402C6D3 RID: 181971
		[Token(Token = "0x402C6D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mutationIcon;

		// Token: 0x0402C6D4 RID: 181972
		[Token(Token = "0x402C6D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_mutationIcon;

		// Token: 0x0402C6D5 RID: 181973
		[Token(Token = "0x402C6D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402C6D6 RID: 181974
		[Token(Token = "0x402C6D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402C6D7 RID: 181975
		[Token(Token = "0x402C6D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x0402C6D8 RID: 181976
		[Token(Token = "0x402C6D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tips;

		// Token: 0x0402C6D9 RID: 181977
		[Token(Token = "0x402C6D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C6DA RID: 181978
		[Token(Token = "0x402C6DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadFromPlayerData;

		// Token: 0x0402C6DB RID: 181979
		[Token(Token = "0x402C6DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
