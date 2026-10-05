using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024FC RID: 9468
	[Token(Token = "0x20024FC")]
	public class BlockedAndAdvancedSelector : BlockedBaseSelector
	{
		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x0600F3D9 RID: 62425 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F3DA RID: 62426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001FBF")]
		private protected Character character
		{
			[Token(Token = "0x600F3D9")]
			[Address(RVA = "0x6B5340", Offset = "0x6B3F40", VA = "0x1806B5340")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600F3DA")]
			[Address(RVA = "0x6B53A0", Offset = "0x6B3FA0", VA = "0x1806B53A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600F3DB RID: 62427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3DB")]
		[Address(RVA = "0x6B5080", Offset = "0x6B3C80", VA = "0x1806B5080", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F3DC RID: 62428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3DC")]
		[Address(RVA = "0x6B4B60", Offset = "0x6B3760", VA = "0x1806B4B60", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F3DD RID: 62429 RVA: 0x00059EC8 File Offset: 0x000580C8
		[Token(Token = "0x600F3DD")]
		[Address(RVA = "0x6B51F0", Offset = "0x6B3DF0", VA = "0x1806B51F0", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F3DE RID: 62430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3DE")]
		[Address(RVA = "0x6B52A0", Offset = "0x6B3EA0", VA = "0x1806B52A0")]
		public BlockedAndAdvancedSelector()
		{
		}

		// Token: 0x0600F3DF RID: 62431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F3DF")]
		[Address(RVA = "0x69B0C0", Offset = "0x699CC0", VA = "0x18069B0C0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F3E0")]
		[Address(RVA = "0x69AAA0", Offset = "0x6996A0", VA = "0x18069AAA0")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0)
		{
			return null;
		}

		// Token: 0x0600F3E1 RID: 62433 RVA: 0x00059EE0 File Offset: 0x000580E0
		[Token(Token = "0x600F3E1")]
		[Address(RVA = "0x6B51E0", Offset = "0x6B3DE0", VA = "0x1806B51E0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E09 RID: 69129
		[Token(Token = "0x4010E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected List<Entity> m_tmpList;

		// Token: 0x04010E0B RID: 69131
		[Token(Token = "0x4010E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_character;

		// Token: 0x04010E0C RID: 69132
		[Token(Token = "0x4010E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_character;

		// Token: 0x04010E0D RID: 69133
		[Token(Token = "0x4010E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E0E RID: 69134
		[Token(Token = "0x4010E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010E0F RID: 69135
		[Token(Token = "0x4010E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E10 RID: 69136
		[Token(Token = "0x4010E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
