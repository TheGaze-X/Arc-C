using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x0200573E RID: 22334
	[Token(Token = "0x200573E")]
	public class RL02DiceResultVirtueViewModel : RoguelikeDiceResultViewModel
	{
		// Token: 0x17004CBE RID: 19646
		// (get) Token: 0x06020BA9 RID: 134057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BAA RID: 134058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CBE")]
		public Sprite virtueIcon
		{
			[Token(Token = "0x6020BA9")]
			[Address(RVA = "0x1B087B0", Offset = "0x1B073B0", VA = "0x181B087B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020BAA")]
			[Address(RVA = "0x1B08910", Offset = "0x1B07510", VA = "0x181B08910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004CBF RID: 19647
		// (get) Token: 0x06020BAB RID: 134059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BAC RID: 134060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CBF")]
		public string desc
		{
			[Token(Token = "0x6020BAB")]
			[Address(RVA = "0x1B08660", Offset = "0x1B07260", VA = "0x181B08660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020BAC")]
			[Address(RVA = "0x1B08810", Offset = "0x1B07410", VA = "0x181B08810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004CC0 RID: 19648
		// (get) Token: 0x06020BAD RID: 134061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020BAE RID: 134062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CC0")]
		public string tips
		{
			[Token(Token = "0x6020BAD")]
			[Address(RVA = "0x1B086C0", Offset = "0x1B072C0", VA = "0x181B086C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020BAE")]
			[Address(RVA = "0x1B08890", Offset = "0x1B07490", VA = "0x181B08890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06020BAF RID: 134063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BAF")]
		[Address(RVA = "0x1B08330", Offset = "0x1B06F30", VA = "0x181B08330", Slot = "5")]
		public override void LoadFromPlayerData(string topicId, PlayerRoguelikePendingEvent.Dice.Result result, RoguelikeDiceRuleData data)
		{
		}

		// Token: 0x17004CC1 RID: 19649
		// (get) Token: 0x06020BB0 RID: 134064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CC1")]
		public override Type viewType
		{
			[Token(Token = "0x6020BB0")]
			[Address(RVA = "0x1B08720", Offset = "0x1B07320", VA = "0x181B08720", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020BB1 RID: 134065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020BB1")]
		[Address(RVA = "0x1B08600", Offset = "0x1B07200", VA = "0x181B08600")]
		public RL02DiceResultVirtueViewModel()
		{
		}

		// Token: 0x0402C6E7 RID: 181991
		[Token(Token = "0x402C6E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_virtueIcon;

		// Token: 0x0402C6E8 RID: 181992
		[Token(Token = "0x402C6E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_virtueIcon;

		// Token: 0x0402C6E9 RID: 181993
		[Token(Token = "0x402C6E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402C6EA RID: 181994
		[Token(Token = "0x402C6EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402C6EB RID: 181995
		[Token(Token = "0x402C6EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_tips;

		// Token: 0x0402C6EC RID: 181996
		[Token(Token = "0x402C6EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_tips;

		// Token: 0x0402C6ED RID: 181997
		[Token(Token = "0x402C6ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadFromPlayerData;

		// Token: 0x0402C6EE RID: 181998
		[Token(Token = "0x402C6EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402C6EF RID: 181999
		[Token(Token = "0x402C6EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
