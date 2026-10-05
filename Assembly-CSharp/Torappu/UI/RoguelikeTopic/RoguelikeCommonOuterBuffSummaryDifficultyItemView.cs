using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200450A RID: 17674
	[Token(Token = "0x200450A")]
	public class RoguelikeCommonOuterBuffSummaryDifficultyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601AF79 RID: 110457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF79")]
		[Address(RVA = "0x1421370", Offset = "0x141FF70", VA = "0x181421370")]
		public void Render(string desc)
		{
		}

		// Token: 0x0601AF7A RID: 110458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AF7A")]
		[Address(RVA = "0x1421450", Offset = "0x1420050", VA = "0x181421450")]
		public RoguelikeCommonOuterBuffSummaryDifficultyItemView()
		{
		}

		// Token: 0x040229D0 RID: 141776
		[Token(Token = "0x40229D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040229D1 RID: 141777
		[Token(Token = "0x40229D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040229D2 RID: 141778
		[Token(Token = "0x40229D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
