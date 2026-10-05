using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051BB RID: 20923
	[Token(Token = "0x20051BB")]
	public abstract class RoguelikeChoicePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EE69 RID: 126569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE69")]
		[Address(RVA = "0x18A36C0", Offset = "0x18A22C0", VA = "0x1818A36C0", Slot = "4")]
		public virtual RoguelikeChoiceHintFactory GetChoiceHintModelFactory()
		{
			return null;
		}

		// Token: 0x0601EE6A RID: 126570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE6A")]
		[Address(RVA = "0x18A3790", Offset = "0x18A2390", VA = "0x1818A3790", Slot = "5")]
		public virtual RoguelikeChoiceLeftDecoView GetChoiceLeftDecoPrefab(RoguelikeChoiceLeftDecoType leftDecoType)
		{
			return null;
		}

		// Token: 0x0601EE6B RID: 126571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE6B")]
		[Address(RVA = "0x18A3800", Offset = "0x18A2400", VA = "0x1818A3800")]
		protected RoguelikeChoicePlugin()
		{
		}

		// Token: 0x04029753 RID: 169811
		[Token(Token = "0x4029753")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHintModelFactory;

		// Token: 0x04029754 RID: 169812
		[Token(Token = "0x4029754")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetChoiceLeftDecoPrefab;

		// Token: 0x04029755 RID: 169813
		[Token(Token = "0x4029755")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
