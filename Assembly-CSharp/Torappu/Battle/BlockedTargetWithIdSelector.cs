using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002507 RID: 9479
	[Token(Token = "0x2002507")]
	public class BlockedTargetWithIdSelector : BlockedSelector
	{
		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600F427 RID: 62503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001FCD")]
		public List<string> allowedId
		{
			[Token(Token = "0x600F427")]
			[Address(RVA = "0x6B9AC0", Offset = "0x6B86C0", VA = "0x1806B9AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F428 RID: 62504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F428")]
		[Address(RVA = "0x6B9790", Offset = "0x6B8390", VA = "0x1806B9790", Slot = "12")]
		public override void Reset(Entity owner, Ability ability, [Optional] Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F429 RID: 62505 RVA: 0x0005A198 File Offset: 0x00058398
		[Token(Token = "0x600F429")]
		[Address(RVA = "0x6B98F0", Offset = "0x6B84F0", VA = "0x1806B98F0", Slot = "16")]
		protected override bool ValidateTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600F42A RID: 62506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F42A")]
		[Address(RVA = "0x6B99C0", Offset = "0x6B85C0", VA = "0x1806B99C0")]
		public BlockedTargetWithIdSelector()
		{
		}

		// Token: 0x0600F42B RID: 62507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F42B")]
		[Address(RVA = "0x6B98D0", Offset = "0x6B84D0", VA = "0x1806B98D0")]
		private void <>xLuaBaseProxy_Reset(Entity P0, Ability P1, Func<Entity, bool> P2)
		{
		}

		// Token: 0x0600F42C RID: 62508 RVA: 0x0005A1B0 File Offset: 0x000583B0
		[Token(Token = "0x600F42C")]
		[Address(RVA = "0x6B98E0", Offset = "0x6B84E0", VA = "0x1806B98E0")]
		private bool <>xLuaBaseProxy_ValidateTarget(Entity P0)
		{
			return default(bool);
		}

		// Token: 0x04010E54 RID: 69204
		[Token(Token = "0x4010E54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private List<string> _allowedId;

		// Token: 0x04010E55 RID: 69205
		[Token(Token = "0x4010E55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private HashSet<string> m_allowedIdHashSet;

		// Token: 0x04010E56 RID: 69206
		[Token(Token = "0x4010E56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allowedId;

		// Token: 0x04010E57 RID: 69207
		[Token(Token = "0x4010E57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04010E58 RID: 69208
		[Token(Token = "0x4010E58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ValidateTarget;

		// Token: 0x04010E59 RID: 69209
		[Token(Token = "0x4010E59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
