using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024C9 RID: 9417
	[Token(Token = "0x20024C9")]
	public class CrossTileRange : Range
	{
		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x0600F261 RID: 62049 RVA: 0x000593E8 File Offset: 0x000575E8
		// (set) Token: 0x0600F262 RID: 62050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F8B")]
		public override bool extendable
		{
			[Token(Token = "0x600F261")]
			[Address(RVA = "0x68C150", Offset = "0x68AD50", VA = "0x18068C150", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F262")]
			[Address(RVA = "0x68C210", Offset = "0x68AE10", VA = "0x18068C210", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x0600F263 RID: 62051 RVA: 0x00059400 File Offset: 0x00057600
		[Token(Token = "0x17001F8C")]
		public bool skipAdvancedValidateWithCondition
		{
			[Token(Token = "0x600F263")]
			[Address(RVA = "0x68C1B0", Offset = "0x68ADB0", VA = "0x18068C1B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F264 RID: 62052 RVA: 0x00059418 File Offset: 0x00057618
		[Token(Token = "0x600F264")]
		[Address(RVA = "0x68B1E0", Offset = "0x689DE0", VA = "0x18068B1E0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F265 RID: 62053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F265")]
		[Address(RVA = "0x68BA50", Offset = "0x68A650", VA = "0x18068BA50", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F266 RID: 62054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F266")]
		[Address(RVA = "0x68B380", Offset = "0x689F80", VA = "0x18068B380", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F267")]
		[Address(RVA = "0x68A9D0", Offset = "0x6895D0", VA = "0x18068A9D0", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F268")]
		[Address(RVA = "0x68BE50", Offset = "0x68AA50", VA = "0x18068BE50", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F269 RID: 62057 RVA: 0x00059430 File Offset: 0x00057630
		[Token(Token = "0x600F269")]
		[Address(RVA = "0x68BED0", Offset = "0x68AAD0", VA = "0x18068BED0", Slot = "17")]
		protected virtual bool VerifyTargetInternal(Entity unit, ReusableList<Entity> candidates, TargetOptions options, Func<Entity, bool> validator)
		{
			return default(bool);
		}

		// Token: 0x0600F26A RID: 62058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F26A")]
		[Address(RVA = "0x68C0C0", Offset = "0x68ACC0", VA = "0x18068C0C0")]
		public CrossTileRange()
		{
		}

		// Token: 0x04010C48 RID: 68680
		[Token(Token = "0x4010C48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _skipAdvancedValidateWithCondition;

		// Token: 0x04010C49 RID: 68681
		[Token(Token = "0x4010C49")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inspect("skipAdvancedValidateWithCondition")]
		private string _conditionBuffKey;

		// Token: 0x04010C4A RID: 68682
		[Token(Token = "0x4010C4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010C4B RID: 68683
		[Token(Token = "0x4010C4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010C4C RID: 68684
		[Token(Token = "0x4010C4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_skipAdvancedValidateWithCondition;

		// Token: 0x04010C4D RID: 68685
		[Token(Token = "0x4010C4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010C4E RID: 68686
		[Token(Token = "0x4010C4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010C4F RID: 68687
		[Token(Token = "0x4010C4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010C50 RID: 68688
		[Token(Token = "0x4010C50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010C51 RID: 68689
		[Token(Token = "0x4010C51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010C52 RID: 68690
		[Token(Token = "0x4010C52")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_VerifyTargetInternal;

		// Token: 0x04010C53 RID: 68691
		[Token(Token = "0x4010C53")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
