using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200533C RID: 21308
	[Token(Token = "0x200533C")]
	public class RoguelikeMenuEffect : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F6D8 RID: 128728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6D8")]
		[Address(RVA = "0x19280D0", Offset = "0x1926CD0", VA = "0x1819280D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F6D9 RID: 128729 RVA: 0x000B1E58 File Offset: 0x000B0058
		[Token(Token = "0x601F6D9")]
		[Address(RVA = "0x1928040", Offset = "0x1926C40", VA = "0x181928040")]
		private bool _GetShowStatus()
		{
			return default(bool);
		}

		// Token: 0x0601F6DA RID: 128730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6DA")]
		[Address(RVA = "0x1927E30", Offset = "0x1926A30", VA = "0x181927E30")]
		public void SetShow(RoguelikeMenuEffect.RoguelikeMenuEffectControlSource src, bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F6DB RID: 128731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6DB")]
		[Address(RVA = "0x1927D90", Offset = "0x1926990", VA = "0x181927D90", Slot = "4")]
		protected virtual void SetShowInner(bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601F6DC RID: 128732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F6DC")]
		[Address(RVA = "0x1928190", Offset = "0x1926D90", VA = "0x181928190")]
		public RoguelikeMenuEffect()
		{
		}

		// Token: 0x0402A45D RID: 173149
		[Token(Token = "0x402A45D")]
		[FieldOffset(Offset = "0x18")]
		private bool[] m_showStatus;

		// Token: 0x0402A45E RID: 173150
		[Token(Token = "0x402A45E")]
		[FieldOffset(Offset = "0x20")]
		private bool m_inited;

		// Token: 0x0402A45F RID: 173151
		[Token(Token = "0x402A45F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A460 RID: 173152
		[Token(Token = "0x402A460")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetShowStatus;

		// Token: 0x0402A461 RID: 173153
		[Token(Token = "0x402A461")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetShow;

		// Token: 0x0402A462 RID: 173154
		[Token(Token = "0x402A462")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetShowInner;

		// Token: 0x0402A463 RID: 173155
		[Token(Token = "0x402A463")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200533D RID: 21309
		[Token(Token = "0x200533D")]
		public enum RoguelikeMenuEffectControlSource
		{
			// Token: 0x0402A465 RID: 173157
			[Token(Token = "0x402A465")]
			SOURCE_MENU_BAR,
			// Token: 0x0402A466 RID: 173158
			[Token(Token = "0x402A466")]
			SOURCE_MENU_OBJECT_1,
			// Token: 0x0402A467 RID: 173159
			[Token(Token = "0x402A467")]
			SOURCE_MENU_OBJECT_2,
			// Token: 0x0402A468 RID: 173160
			[Token(Token = "0x402A468")]
			SOURCE_MENU_OBJECT_3,
			// Token: 0x0402A469 RID: 173161
			[Token(Token = "0x402A469")]
			SOURCE_COUNT
		}
	}
}
