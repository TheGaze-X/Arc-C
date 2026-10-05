using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002558 RID: 9560
	[Token(Token = "0x2002558")]
	public class TokenOrAdvancedSelector : AdvancedSelector
	{
		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600F6BD RID: 63165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6BE RID: 63166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002053")]
		private protected Character character
		{
			[Token(Token = "0x600F6BD")]
			[Address(RVA = "0x717450", Offset = "0x716050", VA = "0x180717450")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F6BE")]
			[Address(RVA = "0x7174B0", Offset = "0x7160B0", VA = "0x1807174B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600F6BF RID: 63167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6BF")]
		[Address(RVA = "0x717230", Offset = "0x715E30", VA = "0x180717230", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F6C0 RID: 63168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6C0")]
		[Address(RVA = "0x716D50", Offset = "0x715950", VA = "0x180716D50", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F6C1 RID: 63169 RVA: 0x0005BF68 File Offset: 0x0005A168
		[Token(Token = "0x600F6C1")]
		[Address(RVA = "0x716C00", Offset = "0x715800", VA = "0x180716C00", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6C2 RID: 63170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6C2")]
		[Address(RVA = "0x7173F0", Offset = "0x715FF0", VA = "0x1807173F0")]
		public TokenOrAdvancedSelector()
		{
		}

		// Token: 0x0600F6C4 RID: 63172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6C4")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F6C5 RID: 63173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6C5")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F6C6 RID: 63174 RVA: 0x0005BF98 File Offset: 0x0005A198
		[Token(Token = "0x600F6C6")]
		[Address(RVA = "0x69B0A0", Offset = "0x699CA0", VA = "0x18069B0A0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x04011212 RID: 70162
		[Token(Token = "0x4011212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Inspect("dontExcludeOwner")]
		private bool _includeOwner;

		// Token: 0x04011214 RID: 70164
		[Token(Token = "0x4011214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04011215 RID: 70165
		[Token(Token = "0x4011215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04011216 RID: 70166
		[Token(Token = "0x4011216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011217 RID: 70167
		[Token(Token = "0x4011217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04011218 RID: 70168
		[Token(Token = "0x4011218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04011219 RID: 70169
		[Token(Token = "0x4011219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
