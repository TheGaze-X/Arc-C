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
	// Token: 0x020024E1 RID: 9441
	[Token(Token = "0x20024E1")]
	public class AdvancedSelectorTokenOrHost : AdvancedSelector
	{
		// Token: 0x17001FB5 RID: 8117
		// (get) Token: 0x0600F350 RID: 62288 RVA: 0x00059C88 File Offset: 0x00057E88
		[Token(Token = "0x17001FB5")]
		private bool checkBuff
		{
			[Token(Token = "0x600F350")]
			[Address(RVA = "0x69B190", Offset = "0x699D90", VA = "0x18069B190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x0600F351 RID: 62289 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F352 RID: 62290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FB6")]
		private protected Character character
		{
			[Token(Token = "0x600F351")]
			[Address(RVA = "0x69B130", Offset = "0x699D30", VA = "0x18069B130")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F352")]
			[Address(RVA = "0x69B1F0", Offset = "0x699DF0", VA = "0x18069B1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600F353 RID: 62291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F353")]
		[Address(RVA = "0x69AF40", Offset = "0x699B40", VA = "0x18069AF40", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F354 RID: 62292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F354")]
		[Address(RVA = "0x69AC40", Offset = "0x699840", VA = "0x18069AC40", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F355 RID: 62293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F355")]
		[Address(RVA = "0x69AED0", Offset = "0x699AD0", VA = "0x18069AED0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F356 RID: 62294 RVA: 0x00059CA0 File Offset: 0x00057EA0
		[Token(Token = "0x600F356")]
		[Address(RVA = "0x69AB10", Offset = "0x699710", VA = "0x18069AB10", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F357")]
		[Address(RVA = "0x69B0D0", Offset = "0x699CD0", VA = "0x18069B0D0")]
		public AdvancedSelectorTokenOrHost()
		{
		}

		// Token: 0x0600F358 RID: 62296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F358")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F359")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F35A")]
		[Address(RVA = "0x69B0B0", Offset = "0x699CB0", VA = "0x18069B0B0")]
		private List<Tile> <>xLuaBaseProxy_FindTiles(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x00059CB8 File Offset: 0x00057EB8
		[Token(Token = "0x600F35B")]
		[Address(RVA = "0x69B0A0", Offset = "0x699CA0", VA = "0x18069B0A0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x04010D3B RID: 68923
		[Token(Token = "0x4010D3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _checkBuff;

		// Token: 0x04010D3C RID: 68924
		[Token(Token = "0x4010D3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Inspect("checkBuff")]
		private string _buffKey;

		// Token: 0x04010D3D RID: 68925
		[Token(Token = "0x4010D3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Inspect("checkBuff")]
		private bool _isExcluded;

		// Token: 0x04010D3F RID: 68927
		[Token(Token = "0x4010D3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_checkBuff;

		// Token: 0x04010D40 RID: 68928
		[Token(Token = "0x4010D40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010D41 RID: 68929
		[Token(Token = "0x4010D41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010D42 RID: 68930
		[Token(Token = "0x4010D42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010D43 RID: 68931
		[Token(Token = "0x4010D43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010D44 RID: 68932
		[Token(Token = "0x4010D44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010D45 RID: 68933
		[Token(Token = "0x4010D45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010D46 RID: 68934
		[Token(Token = "0x4010D46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
