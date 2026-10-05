using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	public class SceneFontPlugin : SingletonMonoBehaviour<SceneFontPlugin>, ISingletonNotAutoCreate
	{
		// Token: 0x06005BAE RID: 23470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAE")]
		[Address(RVA = "0x1AFAFC0", Offset = "0x1AF9BC0", VA = "0x181AFAFC0")]
		public void TryAddToSceneFontHolder()
		{
		}

		// Token: 0x06005BAF RID: 23471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BAF")]
		[Address(RVA = "0x1AFB0E0", Offset = "0x1AF9CE0", VA = "0x181AFB0E0")]
		public void UnRegisterFontHolder()
		{
		}

		// Token: 0x06005BB0 RID: 23472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB0")]
		[Address(RVA = "0x1AFAE70", Offset = "0x1AF9A70", VA = "0x181AFAE70", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06005BB1 RID: 23473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB1")]
		[Address(RVA = "0x1AFB1E0", Offset = "0x1AF9DE0", VA = "0x181AFB1E0")]
		public SceneFontPlugin()
		{
		}

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FontSelect _fontSel;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryAddToSceneFontHolder;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UnRegisterFontHolder;

		// Token: 0x0400213A RID: 8506
		[Token(Token = "0x400213A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400213B RID: 8507
		[Token(Token = "0x400213B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
