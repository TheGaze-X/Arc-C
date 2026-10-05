using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045D6 RID: 17878
	[Token(Token = "0x20045D6")]
	public class Rl03OuterBuffSummaryDifficultyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B318 RID: 111384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B318")]
		[Address(RVA = "0x14687F0", Offset = "0x14673F0", VA = "0x1814687F0")]
		public void Render(string desc)
		{
		}

		// Token: 0x0601B319 RID: 111385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B319")]
		[Address(RVA = "0x14688D0", Offset = "0x14674D0", VA = "0x1814688D0")]
		public Rl03OuterBuffSummaryDifficultyItemView()
		{
		}

		// Token: 0x040230AD RID: 143533
		[Token(Token = "0x40230AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040230AE RID: 143534
		[Token(Token = "0x40230AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040230AF RID: 143535
		[Token(Token = "0x40230AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
