using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005814 RID: 22548
	[Token(Token = "0x2005814")]
	public class RL03ChoicePlugin : RoguelikeChoicePlugin
	{
		// Token: 0x06020F3A RID: 134970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F3A")]
		[Address(RVA = "0x1B45900", Offset = "0x1B44500", VA = "0x181B45900", Slot = "4")]
		public override RoguelikeChoiceHintFactory GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x06020F3B RID: 134971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F3B")]
		[Address(RVA = "0x1B459D0", Offset = "0x1B445D0", VA = "0x181B459D0", Slot = "5")]
		public override RoguelikeChoiceLeftDecoView GetChoiceLeftDecoPrefab(RoguelikeChoiceLeftDecoType leftDecoType)
		{
			return null;
		}

		// Token: 0x06020F3C RID: 134972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F3C")]
		[Address(RVA = "0x1B45A50", Offset = "0x1B44650", VA = "0x181B45A50")]
		public RL03ChoicePlugin()
		{
		}

		// Token: 0x06020F3D RID: 134973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F3D")]
		[Address(RVA = "0x1A31E00", Offset = "0x1A30A00", VA = "0x181A31E00")]
		private RoguelikeChoiceHintFactory <>xLuaBaseProxy_GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x06020F3E RID: 134974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F3E")]
		[Address(RVA = "0x1B052A0", Offset = "0x1B03EA0", VA = "0x181B052A0")]
		private RoguelikeChoiceLeftDecoView <>xLuaBaseProxy_GetChoiceLeftDecoPrefab(RoguelikeChoiceLeftDecoType P0)
		{
			return null;
		}

		// Token: 0x0402CCD8 RID: 183512
		[Token(Token = "0x402CCD8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeChoiceLeftDecoView _prefabLeftDecoVision;

		// Token: 0x0402CCD9 RID: 183513
		[Token(Token = "0x402CCD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHintModelFactory;

		// Token: 0x0402CCDA RID: 183514
		[Token(Token = "0x402CCDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetChoiceLeftDecoPrefab;

		// Token: 0x0402CCDB RID: 183515
		[Token(Token = "0x402CCDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
