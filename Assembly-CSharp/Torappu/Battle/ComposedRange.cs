using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C6 RID: 9414
	[Token(Token = "0x20024C6")]
	public class ComposedRange : AutoLoadBoxRange
	{
		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600F23D RID: 62013 RVA: 0x00059340 File Offset: 0x00057540
		// (set) Token: 0x0600F23E RID: 62014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F87")]
		public override bool extendable
		{
			[Token(Token = "0x600F23D")]
			[Address(RVA = "0x6887E0", Offset = "0x6873E0", VA = "0x1806887E0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F23E")]
			[Address(RVA = "0x688840", Offset = "0x687440", VA = "0x180688840", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600F23F RID: 62015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F23F")]
		[Address(RVA = "0x688510", Offset = "0x687110", VA = "0x180688510", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F240 RID: 62016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F240")]
		[Address(RVA = "0x687F60", Offset = "0x686B60", VA = "0x180687F60", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F241 RID: 62017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F241")]
		[Address(RVA = "0x688280", Offset = "0x686E80", VA = "0x180688280", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F242 RID: 62018 RVA: 0x00059358 File Offset: 0x00057558
		[Token(Token = "0x600F242")]
		[Address(RVA = "0x687D50", Offset = "0x686950", VA = "0x180687D50", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F243 RID: 62019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F243")]
		[Address(RVA = "0x6885E0", Offset = "0x6871E0", VA = "0x1806885E0")]
		public void ResetByRanges(List<Range> ranges)
		{
		}

		// Token: 0x0600F244 RID: 62020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F244")]
		[Address(RVA = "0x688480", Offset = "0x687080", VA = "0x180688480")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600F245 RID: 62021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F245")]
		[Address(RVA = "0x6886E0", Offset = "0x6872E0", VA = "0x1806886E0")]
		public ComposedRange()
		{
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00059370 File Offset: 0x00057570
		[Token(Token = "0x600F246")]
		[Address(RVA = "0x6886C0", Offset = "0x6872C0", VA = "0x1806886C0")]
		private bool <>xLuaBaseProxy_get_extendable()
		{
			return default(bool);
		}

		// Token: 0x0600F247 RID: 62023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F247")]
		[Address(RVA = "0x6886D0", Offset = "0x6872D0", VA = "0x1806886D0")]
		private void <>xLuaBaseProxy_set_extendable(bool P0)
		{
		}

		// Token: 0x0600F248 RID: 62024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F248")]
		[Address(RVA = "0x681A60", Offset = "0x680660", VA = "0x180681A60")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F249 RID: 62025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F249")]
		[Address(RVA = "0x682A40", Offset = "0x681640", VA = "0x180682A40")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0, TargetOptions P1, Func<Entity, bool> P2)
		{
			return null;
		}

		// Token: 0x0600F24A RID: 62026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F24A")]
		[Address(RVA = "0x682AE0", Offset = "0x6816E0", VA = "0x180682AE0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0, Func<Tile, bool> P1)
		{
			return null;
		}

		// Token: 0x0600F24B RID: 62027 RVA: 0x00059388 File Offset: 0x00057588
		[Token(Token = "0x600F24B")]
		[Address(RVA = "0x6886B0", Offset = "0x6872B0", VA = "0x1806886B0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x04010C23 RID: 68643
		[Token(Token = "0x4010C23")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _isOr;

		// Token: 0x04010C24 RID: 68644
		[Token(Token = "0x4010C24")]
		[FieldOffset(Offset = "0x60")]
		private List<Range> m_ranges;

		// Token: 0x04010C25 RID: 68645
		[Token(Token = "0x4010C25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C26 RID: 68646
		[Token(Token = "0x4010C26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C27 RID: 68647
		[Token(Token = "0x4010C27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C28 RID: 68648
		[Token(Token = "0x4010C28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C29 RID: 68649
		[Token(Token = "0x4010C29")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C2A RID: 68650
		[Token(Token = "0x4010C2A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C2B RID: 68651
		[Token(Token = "0x4010C2B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetByRanges;

		// Token: 0x04010C2C RID: 68652
		[Token(Token = "0x4010C2C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04010C2D RID: 68653
		[Token(Token = "0x4010C2D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
