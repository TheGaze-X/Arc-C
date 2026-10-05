using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002538 RID: 9528
	[Token(Token = "0x2002538")]
	public class EddSkillSelector : AdvancedSelector
	{
		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600F5CB RID: 62923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002028")]
		public Tile endTile
		{
			[Token(Token = "0x600F5CB")]
			[Address(RVA = "0x6D2AC0", Offset = "0x6D16C0", VA = "0x1806D2AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F5CC RID: 62924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5CC")]
		[Address(RVA = "0x6D2490", Offset = "0x6D1090", VA = "0x1806D2490", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F5CD RID: 62925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5CD")]
		[Address(RVA = "0x6D2320", Offset = "0x6D0F20", VA = "0x1806D2320", Slot = "37")]
		protected override void OnPostFilter(List<Entity> candidates)
		{
		}

		// Token: 0x0600F5CE RID: 62926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5CE")]
		[Address(RVA = "0x6D2570", Offset = "0x6D1170", VA = "0x1806D2570")]
		private void _FetchEndTile()
		{
		}

		// Token: 0x0600F5CF RID: 62927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5CF")]
		[Address(RVA = "0x6D2A00", Offset = "0x6D1600", VA = "0x1806D2A00")]
		public EddSkillSelector()
		{
		}

		// Token: 0x0600F5D0 RID: 62928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5D0")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F5D1 RID: 62929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F5D1")]
		[Address(RVA = "0x69A940", Offset = "0x699540", VA = "0x18069A940")]
		private void <>xLuaBaseProxy_OnPostFilter(List<Entity> P0)
		{
		}

		// Token: 0x04011091 RID: 69777
		[Token(Token = "0x4011091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Tile m_endTile;

		// Token: 0x04011092 RID: 69778
		[Token(Token = "0x4011092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<GridPosition> m_grids;

		// Token: 0x04011093 RID: 69779
		[Token(Token = "0x4011093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_endTile;

		// Token: 0x04011094 RID: 69780
		[Token(Token = "0x4011094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011095 RID: 69781
		[Token(Token = "0x4011095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPostFilter;

		// Token: 0x04011096 RID: 69782
		[Token(Token = "0x4011096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FetchEndTile;

		// Token: 0x04011097 RID: 69783
		[Token(Token = "0x4011097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
