using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002559 RID: 9561
	[Token(Token = "0x2002559")]
	public class TokenOrHostSelector : TargetSelector
	{
		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600F6C7 RID: 63175 RVA: 0x0005BFB0 File Offset: 0x0005A1B0
		[Token(Token = "0x17002054")]
		private bool checkBuff
		{
			[Token(Token = "0x600F6C7")]
			[Address(RVA = "0x717B90", Offset = "0x716790", VA = "0x180717B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600F6C8 RID: 63176 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F6C9 RID: 63177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002055")]
		private protected Character character
		{
			[Token(Token = "0x600F6C8")]
			[Address(RVA = "0x717B30", Offset = "0x716730", VA = "0x180717B30")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F6C9")]
			[Address(RVA = "0x717C50", Offset = "0x716850", VA = "0x180717C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600F6CA RID: 63178 RVA: 0x0005BFC8 File Offset: 0x0005A1C8
		[Token(Token = "0x17002056")]
		protected int maxTargetNum
		{
			[Token(Token = "0x600F6CA")]
			[Address(RVA = "0x717BF0", Offset = "0x7167F0", VA = "0x180717BF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6CB")]
		[Address(RVA = "0x717960", Offset = "0x716560", VA = "0x180717960", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6CC")]
		[Address(RVA = "0x717660", Offset = "0x716260", VA = "0x180717660", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F6CD")]
		[Address(RVA = "0x7178F0", Offset = "0x7164F0", VA = "0x1807178F0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x0005BFE0 File Offset: 0x0005A1E0
		[Token(Token = "0x600F6CE")]
		[Address(RVA = "0x717530", Offset = "0x716130", VA = "0x180717530", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6CF")]
		[Address(RVA = "0x717AC0", Offset = "0x7166C0", VA = "0x180717AC0")]
		public TokenOrHostSelector()
		{
		}

		// Token: 0x0600F6D0 RID: 63184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F6D0")]
		[Address(RVA = "0x6B8B20", Offset = "0x6B7720", VA = "0x1806B8B20")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0401121A RID: 70170
		[Token(Token = "0x401121A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _maxTargetNum;

		// Token: 0x0401121B RID: 70171
		[Token(Token = "0x401121B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _checkBuff;

		// Token: 0x0401121C RID: 70172
		[Token(Token = "0x401121C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Inspect("checkBuff")]
		private string _buffKey;

		// Token: 0x0401121D RID: 70173
		[Token(Token = "0x401121D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Inspect("checkBuff")]
		private bool _isExcluded;

		// Token: 0x0401121F RID: 70175
		[Token(Token = "0x401121F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkBuff;

		// Token: 0x04011220 RID: 70176
		[Token(Token = "0x4011220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04011221 RID: 70177
		[Token(Token = "0x4011221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04011222 RID: 70178
		[Token(Token = "0x4011222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_maxTargetNum;

		// Token: 0x04011223 RID: 70179
		[Token(Token = "0x4011223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04011224 RID: 70180
		[Token(Token = "0x4011224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04011225 RID: 70181
		[Token(Token = "0x4011225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04011226 RID: 70182
		[Token(Token = "0x4011226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04011227 RID: 70183
		[Token(Token = "0x4011227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
