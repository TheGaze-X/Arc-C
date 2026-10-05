using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004501 RID: 17665
	[Token(Token = "0x2004501")]
	public abstract class RoguelikeCommonOuterBuffLinePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF4D RID: 110413
		[Token(Token = "0x601AF4D")]
		public abstract void Render(bool isActive, RoguelikeCommonOuterBuffLine.Direction direction);

		// Token: 0x0601AF4E RID: 110414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF4E")]
		[Address(RVA = "0x141D6B0", Offset = "0x141C2B0", VA = "0x18141D6B0")]
		protected RoguelikeCommonOuterBuffLinePlugin()
		{
		}

		// Token: 0x04022979 RID: 141689
		[Token(Token = "0x4022979")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
