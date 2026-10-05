using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024CD RID: 9421
	[Token(Token = "0x20024CD")]
	public class EntityLocateRange : Range
	{
		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x0600F28F RID: 62095 RVA: 0x00059568 File Offset: 0x00057768
		// (set) Token: 0x0600F290 RID: 62096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F92")]
		public override bool extendable
		{
			[Token(Token = "0x600F28F")]
			[Address(RVA = "0x6A6E20", Offset = "0x6A5A20", VA = "0x1806A6E20", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F290")]
			[Address(RVA = "0x6A6E80", Offset = "0x6A5A80", VA = "0x1806A6E80", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x0600F291 RID: 62097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F93")]
		protected Collider2D[] colliders
		{
			[Token(Token = "0x600F291")]
			[Address(RVA = "0x6A6D80", Offset = "0x6A5980", VA = "0x1806A6D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F292 RID: 62098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F292")]
		[Address(RVA = "0x6A6C20", Offset = "0x6A5820", VA = "0x1806A6C20", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F293 RID: 62099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F293")]
		[Address(RVA = "0x6A6CA0", Offset = "0x6A58A0", VA = "0x1806A6CA0", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F294 RID: 62100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F294")]
		[Address(RVA = "0x6A6A00", Offset = "0x6A5600", VA = "0x1806A6A00", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F295 RID: 62101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F295")]
		[Address(RVA = "0x6A6B50", Offset = "0x6A5750", VA = "0x1806A6B50", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F296 RID: 62102 RVA: 0x00059580 File Offset: 0x00057780
		[Token(Token = "0x600F296")]
		[Address(RVA = "0x6A66A0", Offset = "0x6A52A0", VA = "0x1806A66A0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F297 RID: 62103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F297")]
		[Address(RVA = "0x6A6AE0", Offset = "0x6A56E0", VA = "0x1806A6AE0", Slot = "17")]
		protected virtual Collider2D[] FetchColliders()
		{
			return null;
		}

		// Token: 0x0600F298 RID: 62104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F298")]
		[Address(RVA = "0x6A6D20", Offset = "0x6A5920", VA = "0x1806A6D20")]
		public EntityLocateRange()
		{
		}

		// Token: 0x04010C7D RID: 68733
		[Token(Token = "0x4010C7D")]
		[FieldOffset(Offset = "0x20")]
		private Collider2D[] m_colliders;

		// Token: 0x04010C7E RID: 68734
		[Token(Token = "0x4010C7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C7F RID: 68735
		[Token(Token = "0x4010C7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C80 RID: 68736
		[Token(Token = "0x4010C80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_colliders;

		// Token: 0x04010C81 RID: 68737
		[Token(Token = "0x4010C81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C82 RID: 68738
		[Token(Token = "0x4010C82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C83 RID: 68739
		[Token(Token = "0x4010C83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C84 RID: 68740
		[Token(Token = "0x4010C84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C85 RID: 68741
		[Token(Token = "0x4010C85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C86 RID: 68742
		[Token(Token = "0x4010C86")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010C87 RID: 68743
		[Token(Token = "0x4010C87")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
