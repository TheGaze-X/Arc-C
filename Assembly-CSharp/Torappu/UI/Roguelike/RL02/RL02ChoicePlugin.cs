using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005732 RID: 22322
	[Token(Token = "0x2005732")]
	public class RL02ChoicePlugin : RoguelikeChoicePlugin
	{
		// Token: 0x06020B7A RID: 134010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B7A")]
		[Address(RVA = "0x1B051F0", Offset = "0x1B03DF0", VA = "0x181B051F0", Slot = "5")]
		public override RoguelikeChoiceLeftDecoView GetChoiceLeftDecoPrefab(RoguelikeChoiceLeftDecoType leftDecoType)
		{
			return null;
		}

		// Token: 0x06020B7B RID: 134011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B7B")]
		[Address(RVA = "0x1B052B0", Offset = "0x1B03EB0", VA = "0x181B052B0")]
		public RL02ChoicePlugin()
		{
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B7C")]
		[Address(RVA = "0x1B052A0", Offset = "0x1B03EA0", VA = "0x181B052A0")]
		private RoguelikeChoiceLeftDecoView <>xLuaBaseProxy_GetChoiceLeftDecoPrefab(RoguelikeChoiceLeftDecoType P0)
		{
			return null;
		}

		// Token: 0x0402C68A RID: 181898
		[Token(Token = "0x402C68A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeChoiceLeftDecoView _prefabLeftDecoDice;

		// Token: 0x0402C68B RID: 181899
		[Token(Token = "0x402C68B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeChoiceLeftDecoView _prefabLeftDecoTask;

		// Token: 0x0402C68C RID: 181900
		[Token(Token = "0x402C68C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeChoiceLeftDecoView _prefabLeftDecoTaskReward;

		// Token: 0x0402C68D RID: 181901
		[Token(Token = "0x402C68D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceLeftDecoPrefab;

		// Token: 0x0402C68E RID: 181902
		[Token(Token = "0x402C68E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
