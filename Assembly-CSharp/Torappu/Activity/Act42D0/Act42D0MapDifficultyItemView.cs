using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200739D RID: 29597
	[Token(Token = "0x200739D")]
	public class Act42D0MapDifficultyItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D69 RID: 171369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D69")]
		[Address(RVA = "0x2571DC0", Offset = "0x25709C0", VA = "0x182571DC0")]
		public void Render(string content)
		{
		}

		// Token: 0x06029D6A RID: 171370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D6A")]
		[Address(RVA = "0x2571E60", Offset = "0x2570A60", VA = "0x182571E60")]
		public Act42D0MapDifficultyItemView()
		{
		}

		// Token: 0x0403BEF9 RID: 245497
		[Token(Token = "0x403BEF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDetail;

		// Token: 0x0403BEFA RID: 245498
		[Token(Token = "0x403BEFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BEFB RID: 245499
		[Token(Token = "0x403BEFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
