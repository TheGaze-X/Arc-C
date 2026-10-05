using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002294 RID: 8852
	[Token(Token = "0x2002294")]
	public class EnvRegisterViewHitRange : GlobalEnvSystem.EnvEventExecutor
	{
		// Token: 0x0600DEB5 RID: 57013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB5")]
		[Address(RVA = "0x3654870", Offset = "0x3653470", VA = "0x183654870", Slot = "8")]
		public override void OnPostInit()
		{
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB6")]
		[Address(RVA = "0x3654720", Offset = "0x3653320", VA = "0x183654720", Slot = "16")]
		public override void OnEnvChanged(string status, Entity target, [Optional] Entity sourceNullable)
		{
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB7")]
		[Address(RVA = "0x3654680", Offset = "0x3653280", VA = "0x183654680", Slot = "17")]
		public override void OnEnvChangedOnDummy(Unit unit, string status)
		{
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB8")]
		[Address(RVA = "0x3654B00", Offset = "0x3653700", VA = "0x183654B00")]
		private void _DoRegisterUnit(Unit unit, string status)
		{
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEB9")]
		[Address(RVA = "0x3654C70", Offset = "0x3653870", VA = "0x183654C70")]
		private void _InitProvider()
		{
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEBA")]
		[Address(RVA = "0x3654580", Offset = "0x3653180", VA = "0x183654580")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEBB")]
		[Address(RVA = "0x3654DB0", Offset = "0x36539B0", VA = "0x183654DB0")]
		public EnvRegisterViewHitRange()
		{
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEBC")]
		[Address(RVA = "0x364FC90", Offset = "0x364E890", VA = "0x18364FC90")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEBD")]
		[Address(RVA = "0x3634430", Offset = "0x3633030", VA = "0x183634430")]
		private void <>xLuaBaseProxy_OnEnvChanged(string P0, Entity P1, Entity P2)
		{
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DEBE")]
		[Address(RVA = "0x3651EC0", Offset = "0x3650AC0", VA = "0x183651EC0")]
		private void <>xLuaBaseProxy_OnEnvChangedOnDummy(Unit P0, string P1)
		{
		}

		// Token: 0x0400F1B5 RID: 61877
		[Token(Token = "0x400F1B5")]
		[NonSerialized]
		public const string BLOCK_VIEW_TAG = "HIT_RANGE_BLOCK_CHARACTER_VIEW";

		// Token: 0x0400F1B6 RID: 61878
		[Token(Token = "0x400F1B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _statusView;

		// Token: 0x0400F1B7 RID: 61879
		[Token(Token = "0x400F1B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _statusNotView;

		// Token: 0x0400F1B8 RID: 61880
		[Token(Token = "0x400F1B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _tileViewRadius;

		// Token: 0x0400F1B9 RID: 61881
		[Token(Token = "0x400F1B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TargetOptions _selectedSourceOptions;

		// Token: 0x0400F1BA RID: 61882
		[Token(Token = "0x400F1BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<string> _specialAllowedTag;

		// Token: 0x0400F1BB RID: 61883
		[Token(Token = "0x400F1BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<string> _specialUnviewedBuffKey;

		// Token: 0x0400F1BC RID: 61884
		[Token(Token = "0x400F1BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private EnvRegisterViewHitRange.ViewHitRangeProvider m_hitRangeProvider;

		// Token: 0x0400F1BD RID: 61885
		[Token(Token = "0x400F1BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400F1BE RID: 61886
		[Token(Token = "0x400F1BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnvChanged;

		// Token: 0x0400F1BF RID: 61887
		[Token(Token = "0x400F1BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvChangedOnDummy;

		// Token: 0x0400F1C0 RID: 61888
		[Token(Token = "0x400F1C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoRegisterUnit;

		// Token: 0x0400F1C1 RID: 61889
		[Token(Token = "0x400F1C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitProvider;

		// Token: 0x0400F1C2 RID: 61890
		[Token(Token = "0x400F1C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F1C3 RID: 61891
		[Token(Token = "0x400F1C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002295 RID: 8853
		[Token(Token = "0x2002295")]
		private class ViewHitRangeProvider : Entity.IHitRangeProvider, IHotfixable, IDisposable
		{
			// Token: 0x0600DEBF RID: 57023 RVA: 0x000510A8 File Offset: 0x0004F2A8
			[Token(Token = "0x600DEBF")]
			[Address(RVA = "0x365D2A0", Offset = "0x365BEA0", VA = "0x18365D2A0", Slot = "4")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600DEC0 RID: 57024 RVA: 0x000510C0 File Offset: 0x0004F2C0
			[Token(Token = "0x600DEC0")]
			[Address(RVA = "0x365D360", Offset = "0x365BF60", VA = "0x18365D360", Slot = "5")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x17001BF4 RID: 7156
			// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001BF4")]
			public string providerId
			{
				[Token(Token = "0x600DEC1")]
				[Address(RVA = "0x365E500", Offset = "0x365D100", VA = "0x18365E500", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600DEC2 RID: 57026 RVA: 0x000510D8 File Offset: 0x0004F2D8
			[Token(Token = "0x600DEC2")]
			[Address(RVA = "0x365D490", Offset = "0x365C090", VA = "0x18365D490")]
			private bool _CheckHitRangeWithView2Block(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x0600DEC3 RID: 57027 RVA: 0x000510F0 File Offset: 0x0004F2F0
			[Token(Token = "0x600DEC3")]
			[Address(RVA = "0x365DAF0", Offset = "0x365C6F0", VA = "0x18365DAF0")]
			private bool _IsGridBlockedByView2Block(TSVector2 center, FP radius, TSVector2 gridCenter)
			{
				return default(bool);
			}

			// Token: 0x0600DEC4 RID: 57028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEC4")]
			[Address(RVA = "0x365D810", Offset = "0x365C410", VA = "0x18365D810")]
			private void _GetGridsOnLine(TSVector2 start, TSVector2 end, ref List<GridPosition> grids)
			{
			}

			// Token: 0x0600DEC5 RID: 57029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEC5")]
			[Address(RVA = "0x365D1F0", Offset = "0x365BDF0", VA = "0x18365D1F0", Slot = "7")]
			public void Dispose()
			{
			}

			// Token: 0x0600DEC6 RID: 57030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DEC6")]
			[Address(RVA = "0x365E480", Offset = "0x365D080", VA = "0x18365E480")]
			public ViewHitRangeProvider()
			{
			}

			// Token: 0x0400F1C4 RID: 61892
			[Token(Token = "0x400F1C4")]
			private const string VIEW_HIT_RANGE_PROVIDER = "VIEW_HIT_RANGE_PROVIDER";

			// Token: 0x0400F1C5 RID: 61893
			[Token(Token = "0x400F1C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static List<GridPosition> s_sharedPos;

			// Token: 0x0400F1C6 RID: 61894
			[Token(Token = "0x400F1C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FP tileRadius;

			// Token: 0x0400F1C7 RID: 61895
			[Token(Token = "0x400F1C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TargetOptions selectedTargetOption;

			// Token: 0x0400F1C8 RID: 61896
			[Token(Token = "0x400F1C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public List<string> specialAllowedTag;

			// Token: 0x0400F1C9 RID: 61897
			[Token(Token = "0x400F1C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public List<string> specialUnviewedBuffKey;

			// Token: 0x0400F1CA RID: 61898
			[Token(Token = "0x400F1CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x0400F1CB RID: 61899
			[Token(Token = "0x400F1CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsTargetIn;

			// Token: 0x0400F1CC RID: 61900
			[Token(Token = "0x400F1CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_providerId;

			// Token: 0x0400F1CD RID: 61901
			[Token(Token = "0x400F1CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CheckHitRangeWithView2Block;

			// Token: 0x0400F1CE RID: 61902
			[Token(Token = "0x400F1CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__IsGridBlockedByView2Block;

			// Token: 0x0400F1CF RID: 61903
			[Token(Token = "0x400F1CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetGridsOnLine;

			// Token: 0x0400F1D0 RID: 61904
			[Token(Token = "0x400F1D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0400F1D1 RID: 61905
			[Token(Token = "0x400F1D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
