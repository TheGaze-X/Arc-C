using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CE RID: 9422
	[Token(Token = "0x20024CE")]
	public class GlobalRange : Range
	{
		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x0600F299 RID: 62105 RVA: 0x00059598 File Offset: 0x00057798
		// (set) Token: 0x0600F29A RID: 62106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F94")]
		public override bool extendable
		{
			[Token(Token = "0x600F299")]
			[Address(RVA = "0x6A7510", Offset = "0x6A6110", VA = "0x1806A7510", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F29A")]
			[Address(RVA = "0x6A7570", Offset = "0x6A6170", VA = "0x1806A7570", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600F29B RID: 62107 RVA: 0x000595B0 File Offset: 0x000577B0
		[Token(Token = "0x600F29B")]
		[Address(RVA = "0x6A6EE0", Offset = "0x6A5AE0", VA = "0x1806A6EE0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F29C RID: 62108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F29C")]
		[Address(RVA = "0x6A6F50", Offset = "0x6A5B50", VA = "0x1806A6F50", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F29D RID: 62109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F29D")]
		[Address(RVA = "0x6A7220", Offset = "0x6A5E20", VA = "0x1806A7220", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F29E RID: 62110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F29E")]
		[Address(RVA = "0x6A73B0", Offset = "0x6A5FB0", VA = "0x1806A73B0", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F29F RID: 62111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F29F")]
		[Address(RVA = "0x6A7430", Offset = "0x6A6030", VA = "0x1806A7430", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F2A0 RID: 62112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2A0")]
		[Address(RVA = "0x6A74B0", Offset = "0x6A60B0", VA = "0x1806A74B0")]
		public GlobalRange()
		{
		}

		// Token: 0x04010C88 RID: 68744
		[Token(Token = "0x4010C88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C89 RID: 68745
		[Token(Token = "0x4010C89")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C8A RID: 68746
		[Token(Token = "0x4010C8A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C8B RID: 68747
		[Token(Token = "0x4010C8B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C8C RID: 68748
		[Token(Token = "0x4010C8C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C8D RID: 68749
		[Token(Token = "0x4010C8D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C8E RID: 68750
		[Token(Token = "0x4010C8E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C8F RID: 68751
		[Token(Token = "0x4010C8F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
