using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CC RID: 9420
	[Token(Token = "0x20024CC")]
	public class EmptyRange : Range
	{
		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x0600F287 RID: 62087 RVA: 0x00059538 File Offset: 0x00057738
		// (set) Token: 0x0600F288 RID: 62088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F91")]
		public override bool extendable
		{
			[Token(Token = "0x600F287")]
			[Address(RVA = "0x6A65E0", Offset = "0x6A51E0", VA = "0x1806A65E0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F288")]
			[Address(RVA = "0x6A6640", Offset = "0x6A5240", VA = "0x1806A6640", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600F289 RID: 62089 RVA: 0x00059550 File Offset: 0x00057750
		[Token(Token = "0x600F289")]
		[Address(RVA = "0x6A62A0", Offset = "0x6A4EA0", VA = "0x1806A62A0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F28A RID: 62090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F28A")]
		[Address(RVA = "0x6A6310", Offset = "0x6A4F10", VA = "0x1806A6310", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F28B RID: 62091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F28B")]
		[Address(RVA = "0x6A63F0", Offset = "0x6A4FF0", VA = "0x1806A63F0", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F28C RID: 62092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F28C")]
		[Address(RVA = "0x6A6480", Offset = "0x6A5080", VA = "0x1806A6480", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F28D RID: 62093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F28D")]
		[Address(RVA = "0x6A6500", Offset = "0x6A5100", VA = "0x1806A6500", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F28E RID: 62094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F28E")]
		[Address(RVA = "0x6A6580", Offset = "0x6A5180", VA = "0x1806A6580")]
		public EmptyRange()
		{
		}

		// Token: 0x04010C75 RID: 68725
		[Token(Token = "0x4010C75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C76 RID: 68726
		[Token(Token = "0x4010C76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C77 RID: 68727
		[Token(Token = "0x4010C77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C78 RID: 68728
		[Token(Token = "0x4010C78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C79 RID: 68729
		[Token(Token = "0x4010C79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C7A RID: 68730
		[Token(Token = "0x4010C7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C7B RID: 68731
		[Token(Token = "0x4010C7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C7C RID: 68732
		[Token(Token = "0x4010C7C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
