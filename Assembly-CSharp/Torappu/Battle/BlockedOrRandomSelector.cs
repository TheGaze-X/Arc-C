using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002503 RID: 9475
	[Token(Token = "0x2002503")]
	[Obsolete]
	public class BlockedOrRandomSelector : RandomSelector
	{
		// Token: 0x0600F402 RID: 62466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F402")]
		[Address(RVA = "0x6B6FD0", Offset = "0x6B5BD0", VA = "0x1806B6FD0", Slot = "22")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0600F403 RID: 62467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F403")]
		[Address(RVA = "0x6B6B70", Offset = "0x6B5770", VA = "0x1806B6B70", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F404 RID: 62468 RVA: 0x0005A000 File Offset: 0x00058200
		[Token(Token = "0x600F404")]
		[Address(RVA = "0x6B7100", Offset = "0x6B5D00", VA = "0x1806B7100", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F405 RID: 62469 RVA: 0x0005A018 File Offset: 0x00058218
		[Token(Token = "0x600F405")]
		[Address(RVA = "0x6B7220", Offset = "0x6B5E20", VA = "0x1806B7220")]
		private bool _ValidateWithTargetFree(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F406 RID: 62470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F406")]
		[Address(RVA = "0x6B7320", Offset = "0x6B5F20", VA = "0x1806B7320")]
		public BlockedOrRandomSelector()
		{
		}

		// Token: 0x04010E32 RID: 69170
		[Token(Token = "0x4010E32")]
		[FieldOffset(Offset = "0xC0")]
		private Character m_character;
	}
}
