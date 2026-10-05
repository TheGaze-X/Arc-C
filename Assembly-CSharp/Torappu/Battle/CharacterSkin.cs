using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002465 RID: 9317
	[Token(Token = "0x2002465")]
	public class CharacterSkin : CharacterAnimator
	{
		// Token: 0x0600EFCC RID: 61388 RVA: 0x00058500 File Offset: 0x00056700
		[Token(Token = "0x600EFCC")]
		[Address(RVA = "0x66DC80", Offset = "0x66C880", VA = "0x18066DC80", Slot = "31")]
		public override bool TryLoadEffectOverrideMap(ref ListDict<string, string> effectMap)
		{
			return default(bool);
		}

		// Token: 0x0600EFCD RID: 61389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EFCD")]
		[Address(RVA = "0x66DE30", Offset = "0x66CA30", VA = "0x18066DE30")]
		public CharacterSkin()
		{
		}

		// Token: 0x0600EFCE RID: 61390 RVA: 0x00058518 File Offset: 0x00056718
		[Token(Token = "0x600EFCE")]
		[Address(RVA = "0x66DE20", Offset = "0x66CA20", VA = "0x18066DE20")]
		private bool <>xLuaBaseProxy_TryLoadEffectOverrideMap(ref ListDict<string, string> P0)
		{
			return default(bool);
		}

		// Token: 0x0401092D RID: 67885
		[Token(Token = "0x401092D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private KeyValuePair<string, string>[] _overrideEffects;

		// Token: 0x0401092E RID: 67886
		[Token(Token = "0x401092E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryLoadEffectOverrideMap;

		// Token: 0x0401092F RID: 67887
		[Token(Token = "0x401092F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
