using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023A0 RID: 9120
	[Token(Token = "0x20023A0")]
	public class HoleTile : Tile
	{
		// Token: 0x17001D0B RID: 7435
		// (get) Token: 0x0600E757 RID: 59223 RVA: 0x00054450 File Offset: 0x00052650
		[Token(Token = "0x17001D0B")]
		public override int moveCost
		{
			[Token(Token = "0x600E757")]
			[Address(RVA = "0x5D2C90", Offset = "0x5D1890", VA = "0x1805D2C90", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D0C RID: 7436
		// (get) Token: 0x0600E758 RID: 59224 RVA: 0x00054468 File Offset: 0x00052668
		[Token(Token = "0x17001D0C")]
		public override bool isObstacleLike
		{
			[Token(Token = "0x600E758")]
			[Address(RVA = "0x5D2C30", Offset = "0x5D1830", VA = "0x1805D2C30", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E759 RID: 59225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E759")]
		[Address(RVA = "0x5D2890", Offset = "0x5D1490", VA = "0x1805D2890", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E75A RID: 59226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E75A")]
		[Address(RVA = "0x5D2970", Offset = "0x5D1570", VA = "0x1805D2970", Slot = "33")]
		public override void OnEnemyMotionModeChanged(Enemy enemy, MotionMode oldMode, MotionMode newMode)
		{
		}

		// Token: 0x0600E75B RID: 59227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E75B")]
		[Address(RVA = "0x5D2BD0", Offset = "0x5D17D0", VA = "0x1805D2BD0")]
		public HoleTile()
		{
		}

		// Token: 0x0600E75C RID: 59228 RVA: 0x00054480 File Offset: 0x00052680
		[Token(Token = "0x600E75C")]
		[Address(RVA = "0x5D2B60", Offset = "0x5D1760", VA = "0x1805D2B60")]
		private int <>xLuaBaseProxy_get_moveCost()
		{
			return 0;
		}

		// Token: 0x0600E75D RID: 59229 RVA: 0x00054498 File Offset: 0x00052698
		[Token(Token = "0x600E75D")]
		[Address(RVA = "0x5D2AD0", Offset = "0x5D16D0", VA = "0x1805D2AD0")]
		private bool <>xLuaBaseProxy_get_isObstacleLike()
		{
			return default(bool);
		}

		// Token: 0x0600E75E RID: 59230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E75E")]
		[Address(RVA = "0x5B8960", Offset = "0x5B7560", VA = "0x1805B8960")]
		private void <>xLuaBaseProxy_OnEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E75F")]
		[Address(RVA = "0x5D2AC0", Offset = "0x5D16C0", VA = "0x1805D2AC0")]
		private void <>xLuaBaseProxy_OnEnemyMotionModeChanged(Enemy P0, MotionMode P1, MotionMode P2)
		{
		}

		// Token: 0x0400FED0 RID: 65232
		[Token(Token = "0x400FED0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveCost;

		// Token: 0x0400FED1 RID: 65233
		[Token(Token = "0x400FED1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isObstacleLike;

		// Token: 0x0400FED2 RID: 65234
		[Token(Token = "0x400FED2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FED3 RID: 65235
		[Token(Token = "0x400FED3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnemyMotionModeChanged;

		// Token: 0x0400FED4 RID: 65236
		[Token(Token = "0x400FED4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
