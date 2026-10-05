using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002124 RID: 8484
	[Token(Token = "0x2002124")]
	public class SimpleUnitAnimatorHooker : UnitAnimatorHooker
	{
		// Token: 0x0600D050 RID: 53328 RVA: 0x0004B240 File Offset: 0x00049440
		[Token(Token = "0x600D050")]
		[Address(RVA = "0x35190F0", Offset = "0x3517CF0", VA = "0x1835190F0", Slot = "4")]
		public override bool TryHookAnimation(string animKey, out string newAnimKey)
		{
			return default(bool);
		}

		// Token: 0x0600D051 RID: 53329 RVA: 0x0004B258 File Offset: 0x00049458
		[Token(Token = "0x600D051")]
		[Address(RVA = "0x3519210", Offset = "0x3517E10", VA = "0x183519210", Slot = "5")]
		public override bool ValidateAnimSwitchable(string sourceAnimName, string targetAnimName)
		{
			return default(bool);
		}

		// Token: 0x0600D052 RID: 53330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D052")]
		[Address(RVA = "0x3518F10", Offset = "0x3517B10", VA = "0x183518F10")]
		public void ChangeReplaceAnimPairs(SimpleUnitAnimatorHooker.ReplacePair[] changeAnimPairs, bool isOverwrite = false)
		{
		}

		// Token: 0x0600D053 RID: 53331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D053")]
		[Address(RVA = "0x3518DB0", Offset = "0x35179B0", VA = "0x183518DB0")]
		public void ChangeExcludeAnimKeys(string[] changeAnimKeys, bool isOverwrite = false)
		{
		}

		// Token: 0x0600D054 RID: 53332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D054")]
		[Address(RVA = "0x3518CD0", Offset = "0x35178D0", VA = "0x183518CD0")]
		private void Awake()
		{
		}

		// Token: 0x0600D055 RID: 53333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D055")]
		[Address(RVA = "0x3519320", Offset = "0x3517F20", VA = "0x183519320")]
		public SimpleUnitAnimatorHooker()
		{
		}

		// Token: 0x0400DEA4 RID: 56996
		[Token(Token = "0x400DEA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _excludeAnimKeys;

		// Token: 0x0400DEA5 RID: 56997
		[Token(Token = "0x400DEA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleUnitAnimatorHooker.ReplacePair[] _replaceAnimPairs;

		// Token: 0x0400DEA6 RID: 56998
		[Token(Token = "0x400DEA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleUnitAnimatorHooker.DisableAnimSwitchSetting[] _disableSwitchSettings;

		// Token: 0x0400DEA7 RID: 56999
		[Token(Token = "0x400DEA7")]
		[FieldOffset(Offset = "0x30")]
		private List<SimpleUnitAnimatorHooker.ReplacePair> m_replaceAnimPairs;

		// Token: 0x0400DEA8 RID: 57000
		[Token(Token = "0x400DEA8")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_excludeAnimKeys;

		// Token: 0x02002125 RID: 8485
		[Token(Token = "0x2002125")]
		[Serializable]
		public struct ReplacePair
		{
			// Token: 0x0400DEA9 RID: 57001
			[Token(Token = "0x400DEA9")]
			[FieldOffset(Offset = "0x0")]
			public string fromAnimKey;

			// Token: 0x0400DEAA RID: 57002
			[Token(Token = "0x400DEAA")]
			[FieldOffset(Offset = "0x8")]
			public string toAnimKey;
		}

		// Token: 0x02002126 RID: 8486
		[Token(Token = "0x2002126")]
		[Serializable]
		public struct DisableAnimSwitchSetting
		{
			// Token: 0x0400DEAB RID: 57003
			[Token(Token = "0x400DEAB")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string sourceAnimName;

			// Token: 0x0400DEAC RID: 57004
			[Token(Token = "0x400DEAC")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Must specify raw animName rather than animKey.")]
			public string targetAnimName;
		}
	}
}
