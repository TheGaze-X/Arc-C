using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046DA RID: 18138
	[Token(Token = "0x20046DA")]
	public class RL04TopicEndingFragmentItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B802 RID: 112642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B802")]
		[Address(RVA = "0x14CE670", Offset = "0x14CD270", VA = "0x1814CE670")]
		public void Render(RL04TopicEndingFragmentItemViewModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601B803 RID: 112643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B803")]
		[Address(RVA = "0x14CE7B0", Offset = "0x14CD3B0", VA = "0x1814CE7B0")]
		public RL04TopicEndingFragmentItemView()
		{
		}

		// Token: 0x040239F0 RID: 145904
		[Token(Token = "0x40239F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _name;

		// Token: 0x040239F1 RID: 145905
		[Token(Token = "0x40239F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _desc;

		// Token: 0x040239F2 RID: 145906
		[Token(Token = "0x40239F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _fragmentIconImg;

		// Token: 0x040239F3 RID: 145907
		[Token(Token = "0x40239F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040239F4 RID: 145908
		[Token(Token = "0x40239F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
