using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024D9 RID: 9433
	[Token(Token = "0x20024D9")]
	public abstract class Range : MonoBehaviour, IDrawableRange, IHotfixable
	{
		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x0600F2F2 RID: 62194
		// (set) Token: 0x0600F2F3 RID: 62195
		[Token(Token = "0x17001F9B")]
		public abstract bool extendable { [Token(Token = "0x600F2F2")] get; [Token(Token = "0x600F2F3")] set; }

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600F2F4 RID: 62196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F9C")]
		public Ability ability
		{
			[Token(Token = "0x600F2F4")]
			[Address(RVA = "0x6B03D0", Offset = "0x6AEFD0", VA = "0x1806B03D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2F5")]
		[Address(RVA = "0x6B0170", Offset = "0x6AED70", VA = "0x1806B0170")]
		public void Reset(Range.Options options)
		{
		}

		// Token: 0x0600F2F6 RID: 62198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2F6")]
		[Address(RVA = "0x6B02B0", Offset = "0x6AEEB0", VA = "0x1806B02B0")]
		public void UpdateExtend(FP extend)
		{
		}

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2F7")]
		[Address(RVA = "0x6AFFC0", Offset = "0x6AEBC0", VA = "0x1806AFFC0")]
		public ReusableList<Entity> FindTargets_DISPOSE(Vector2 mapPos, TargetOptions options)
		{
			return null;
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2F8")]
		[Address(RVA = "0x6B0090", Offset = "0x6AEC90", VA = "0x1806B0090")]
		public ReusableList<Entity> FindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2F9 RID: 62201
		[Token(Token = "0x600F2F9")]
		protected abstract ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator);

		// Token: 0x0600F2FA RID: 62202
		[Token(Token = "0x600F2FA")]
		public abstract List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator);

		// Token: 0x0600F2FB RID: 62203
		[Token(Token = "0x600F2FB")]
		public abstract bool CheckTargetIn(ILocatable target);

		// Token: 0x0600F2FC RID: 62204 RVA: 0x00059880 File Offset: 0x00057A80
		[Token(Token = "0x600F2FC")]
		[Address(RVA = "0x6AD6B0", Offset = "0x6AC2B0", VA = "0x1806AD6B0", Slot = "13")]
		public virtual bool CheckTargetInOriginRange(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F2FD RID: 62205
		[Token(Token = "0x600F2FD")]
		protected abstract void OnInit(Range.Options options);

		// Token: 0x0600F2FE RID: 62206
		[Token(Token = "0x600F2FE")]
		protected abstract void UpdateExtend(FP extend, bool force);

		// Token: 0x0600F2FF RID: 62207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2FF")]
		[Address(RVA = "0x6A4DD0", Offset = "0x6A39D0", VA = "0x1806A4DD0", Slot = "16")]
		public virtual void UpdateRangeByOptions(Range.Options options)
		{
		}

		// Token: 0x0600F300 RID: 62208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F300")]
		[Address(RVA = "0x6B0340", Offset = "0x6AEF40", VA = "0x1806B0340")]
		protected Range()
		{
		}

		// Token: 0x04010CD2 RID: 68818
		[Token(Token = "0x4010CD2")]
		[FieldOffset(Offset = "0x18")]
		protected FP m_currentExtend;

		// Token: 0x04010CD3 RID: 68819
		[Token(Token = "0x4010CD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ability;

		// Token: 0x04010CD4 RID: 68820
		[Token(Token = "0x4010CD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010CD5 RID: 68821
		[Token(Token = "0x4010CD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010CD6 RID: 68822
		[Token(Token = "0x4010CD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindTargets_DISPOSE;

		// Token: 0x04010CD7 RID: 68823
		[Token(Token = "0x4010CD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_FindTargets_DISPOSE;

		// Token: 0x04010CD8 RID: 68824
		[Token(Token = "0x4010CD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckTargetInOriginRange;

		// Token: 0x04010CD9 RID: 68825
		[Token(Token = "0x4010CD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateRangeByOptions;

		// Token: 0x04010CDA RID: 68826
		[Token(Token = "0x4010CDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024DA RID: 9434
		[Token(Token = "0x20024DA")]
		public struct Options
		{
			// Token: 0x0600F301 RID: 62209 RVA: 0x00059898 File Offset: 0x00057A98
			[Token(Token = "0x600F301")]
			[Address(RVA = "0x6AC3E0", Offset = "0x6AAFE0", VA = "0x1806AC3E0")]
			public bool Equals(Range.Options obj)
			{
				return default(bool);
			}

			// Token: 0x04010CDB RID: 68827
			[Token(Token = "0x4010CDB")]
			[FieldOffset(Offset = "0x0")]
			public string rangeId;

			// Token: 0x04010CDC RID: 68828
			[Token(Token = "0x4010CDC")]
			[FieldOffset(Offset = "0x8")]
			public ObscuredFloat rangeRadius;

			// Token: 0x04010CDD RID: 68829
			[Token(Token = "0x4010CDD")]
			[FieldOffset(Offset = "0x20")]
			public FP initialExtend;
		}
	}
}
