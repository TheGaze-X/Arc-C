using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002607 RID: 9735
	[Token(Token = "0x2002607")]
	public class PropLikeStaticBlockToken : Token
	{
		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0600FD96 RID: 64918 RVA: 0x0005FF88 File Offset: 0x0005E188
		[Token(Token = "0x17002221")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public override int blockCnt
		{
			[Token(Token = "0x600FD96")]
			[Address(RVA = "0x75DCA0", Offset = "0x75C8A0", VA = "0x18075DCA0", Slot = "81")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600FD97 RID: 64919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD97")]
		[Address(RVA = "0x75D190", Offset = "0x75BD90", VA = "0x18075D190", Slot = "30")]
		protected override void OnInit(float initHeight)
		{
		}

		// Token: 0x0600FD98 RID: 64920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD98")]
		[Address(RVA = "0x75D3C0", Offset = "0x75BFC0", VA = "0x18075D3C0", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FD99 RID: 64921 RVA: 0x0005FFA0 File Offset: 0x0005E1A0
		[Token(Token = "0x600FD99")]
		[Address(RVA = "0x75CEF0", Offset = "0x75BAF0", VA = "0x18075CEF0", Slot = "120")]
		protected override bool DoApplyModifier(ref Modifier modifier, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600FD9A RID: 64922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD9A")]
		[Address(RVA = "0x75D890", Offset = "0x75C490", VA = "0x18075D890", Slot = "214")]
		protected override void _SearchBlockee(bool force = false)
		{
		}

		// Token: 0x0600FD9B RID: 64923 RVA: 0x0005FFB8 File Offset: 0x0005E1B8
		[Token(Token = "0x600FD9B")]
		[Address(RVA = "0x75CBF0", Offset = "0x75B7F0", VA = "0x18075CBF0", Slot = "217")]
		protected override Vector2 BlockeeOffsetPosSet(Vector2 offset, Enemy enemy)
		{
			return default(Vector2);
		}

		// Token: 0x0600FD9C RID: 64924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD9C")]
		[Address(RVA = "0x75D460", Offset = "0x75C060", VA = "0x18075D460", Slot = "27")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600FD9D RID: 64925 RVA: 0x0005FFD0 File Offset: 0x0005E1D0
		[Token(Token = "0x600FD9D")]
		[Address(RVA = "0x75D6C0", Offset = "0x75C2C0", VA = "0x18075D6C0")]
		private bool _CheckBlockable(Entity entity, Entity source, out FP weight, out int volume)
		{
			return default(bool);
		}

		// Token: 0x0600FD9E RID: 64926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD9E")]
		[Address(RVA = "0x75DC20", Offset = "0x75C820", VA = "0x18075DC20")]
		public PropLikeStaticBlockToken()
		{
		}

		// Token: 0x0600FDA0 RID: 64928 RVA: 0x0005FFE8 File Offset: 0x0005E1E8
		[Token(Token = "0x600FDA0")]
		[Address(RVA = "0x75D6B0", Offset = "0x75C2B0", VA = "0x18075D6B0")]
		private int <>xLuaBaseProxy_get_blockCnt()
		{
			return 0;
		}

		// Token: 0x0600FDA1 RID: 64929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDA1")]
		[Address(RVA = "0x75D610", Offset = "0x75C210", VA = "0x18075D610")]
		private void <>xLuaBaseProxy_OnInit(float P0)
		{
		}

		// Token: 0x0600FDA2 RID: 64930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDA2")]
		[Address(RVA = "0x75D620", Offset = "0x75C220", VA = "0x18075D620")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FDA3 RID: 64931 RVA: 0x00060000 File Offset: 0x0005E200
		[Token(Token = "0x600FDA3")]
		[Address(RVA = "0x75CAA0", Offset = "0x75B6A0", VA = "0x18075CAA0")]
		private bool <>xLuaBaseProxy_DoApplyModifier(ref Modifier P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600FDA4 RID: 64932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDA4")]
		[Address(RVA = "0x75D6A0", Offset = "0x75C2A0", VA = "0x18075D6A0")]
		private void <>xLuaBaseProxy__SearchBlockee(bool P0)
		{
		}

		// Token: 0x0600FDA5 RID: 64933 RVA: 0x00060018 File Offset: 0x0005E218
		[Token(Token = "0x600FDA5")]
		[Address(RVA = "0x75D600", Offset = "0x75C200", VA = "0x18075D600")]
		private Vector2 <>xLuaBaseProxy_BlockeeOffsetPosSet(Vector2 P0, Enemy P1)
		{
			return default(Vector2);
		}

		// Token: 0x0600FDA6 RID: 64934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDA6")]
		[Address(RVA = "0x75D690", Offset = "0x75C290", VA = "0x18075D690")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040119E9 RID: 72169
		[Token(Token = "0x40119E9")]
		[FieldOffset(Offset = "0x0")]
		private static FP DIST_MAX;

		// Token: 0x040119EA RID: 72170
		[Token(Token = "0x40119EA")]
		[FieldOffset(Offset = "0x530")]
		private bool m_checkedBlock;

		// Token: 0x040119EB RID: 72171
		[Token(Token = "0x40119EB")]
		[FieldOffset(Offset = "0x534")]
		private int m_blockCnt;

		// Token: 0x040119EC RID: 72172
		[Token(Token = "0x40119EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_blockCnt;

		// Token: 0x040119ED RID: 72173
		[Token(Token = "0x40119ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040119EE RID: 72174
		[Token(Token = "0x40119EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x040119EF RID: 72175
		[Token(Token = "0x40119EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoApplyModifier;

		// Token: 0x040119F0 RID: 72176
		[Token(Token = "0x40119F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SearchBlockee;

		// Token: 0x040119F1 RID: 72177
		[Token(Token = "0x40119F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BlockeeOffsetPosSet;

		// Token: 0x040119F2 RID: 72178
		[Token(Token = "0x40119F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040119F3 RID: 72179
		[Token(Token = "0x40119F3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckBlockable;

		// Token: 0x040119F4 RID: 72180
		[Token(Token = "0x40119F4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002608 RID: 9736
		[Token(Token = "0x2002608")]
		private class Phatm2TokenHitRangeProvider : Entity.IHitRangeProvider, IHotfixable
		{
			// Token: 0x0600FDA7 RID: 64935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FDA7")]
			[Address(RVA = "0x75C230", Offset = "0x75AE30", VA = "0x18075C230")]
			public Phatm2TokenHitRangeProvider(ObjectPtr<Unit> owner)
			{
			}

			// Token: 0x17002222 RID: 8738
			// (get) Token: 0x0600FDA8 RID: 64936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17002222")]
			public string providerId
			{
				[Token(Token = "0x600FDA8")]
				[Address(RVA = "0x75C370", Offset = "0x75AF70", VA = "0x18075C370", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600FDA9 RID: 64937 RVA: 0x00060030 File Offset: 0x0005E230
			[Token(Token = "0x600FDA9")]
			[Address(RVA = "0x75BFE0", Offset = "0x75ABE0", VA = "0x18075BFE0", Slot = "4")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600FDAA RID: 64938 RVA: 0x00060048 File Offset: 0x0005E248
			[Token(Token = "0x600FDAA")]
			[Address(RVA = "0x75C1A0", Offset = "0x75ADA0", VA = "0x18075C1A0", Slot = "5")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x040119F5 RID: 72181
			[Token(Token = "0x40119F5")]
			public const string PHATM2_TOKEN_HIT_RANGE_CHECKER_PROVIDER = "PHATM2_TOKEN_HIT_RANGE_CHECKER_PROVIDER";

			// Token: 0x040119F6 RID: 72182
			[Token(Token = "0x40119F6")]
			[FieldOffset(Offset = "0x10")]
			private RangeData m_data;

			// Token: 0x040119F7 RID: 72183
			[Token(Token = "0x40119F7")]
			[FieldOffset(Offset = "0x18")]
			private ObjectPtr<PropLikeStaticBlockToken> m_owner;

			// Token: 0x040119F8 RID: 72184
			[Token(Token = "0x40119F8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040119F9 RID: 72185
			[Token(Token = "0x40119F9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_providerId;

			// Token: 0x040119FA RID: 72186
			[Token(Token = "0x40119FA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x040119FB RID: 72187
			[Token(Token = "0x40119FB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsTargetIn;
		}
	}
}
