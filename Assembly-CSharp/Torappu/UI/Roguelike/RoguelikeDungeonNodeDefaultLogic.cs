using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200525D RID: 21085
	[Token(Token = "0x200525D")]
	public class RoguelikeDungeonNodeDefaultLogic : RoguelikeDungeonNodeView.RogueLogic
	{
		// Token: 0x0601F187 RID: 127367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F187")]
		[Address(RVA = "0x18CC270", Offset = "0x18CAE70", VA = "0x1818CC270", Slot = "6")]
		public override void RenderCurves()
		{
		}

		// Token: 0x0601F188 RID: 127368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F188")]
		[Address(RVA = "0x18CB790", Offset = "0x18CA390", VA = "0x1818CB790", Slot = "4")]
		public override void RenderBossWidgets()
		{
		}

		// Token: 0x0601F189 RID: 127369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F189")]
		[Address(RVA = "0x18D0090", Offset = "0x18CEC90", VA = "0x1818D0090")]
		protected Sprite TryGetBossIcon()
		{
			return null;
		}

		// Token: 0x0601F18A RID: 127370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F18A")]
		[Address(RVA = "0x18CF3A0", Offset = "0x18CDFA0", VA = "0x1818CF3A0", Slot = "7")]
		public override void RenderOtherWidgets()
		{
		}

		// Token: 0x0601F18B RID: 127371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F18B")]
		[Address(RVA = "0x18CDD30", Offset = "0x18CC930", VA = "0x1818CDD30", Slot = "5")]
		public override void RenderNonBossWidigets()
		{
		}

		// Token: 0x0601F18C RID: 127372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F18C")]
		[Address(RVA = "0x18D0360", Offset = "0x18CEF60", VA = "0x1818D0360")]
		public RoguelikeDungeonNodeDefaultLogic()
		{
		}

		// Token: 0x04029B76 RID: 170870
		[Token(Token = "0x4029B76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderCurves;

		// Token: 0x04029B77 RID: 170871
		[Token(Token = "0x4029B77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderBossWidgets;

		// Token: 0x04029B78 RID: 170872
		[Token(Token = "0x4029B78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryGetBossIcon;

		// Token: 0x04029B79 RID: 170873
		[Token(Token = "0x4029B79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderOtherWidgets;

		// Token: 0x04029B7A RID: 170874
		[Token(Token = "0x4029B7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderNonBossWidigets;

		// Token: 0x04029B7B RID: 170875
		[Token(Token = "0x4029B7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
