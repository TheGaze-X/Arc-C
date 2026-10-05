using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005693 RID: 22163
	[Token(Token = "0x2005693")]
	public class RL04ClassicEndingStatsFragmentItemView : MonoBehaviour
	{
		// Token: 0x06020834 RID: 133172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020834")]
		[Address(RVA = "0x1AA4D70", Offset = "0x1AA3970", VA = "0x181AA4D70")]
		public void Render(ILoadAsset iLoadAsset, RL04ClassicEndingStatsFragmentItemModel itemModel)
		{
		}

		// Token: 0x06020835 RID: 133173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020835")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RL04ClassicEndingStatsFragmentItemView()
		{
		}

		// Token: 0x0402C0F1 RID: 180465
		[Token(Token = "0x402C0F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _fragmentIconImg;

		// Token: 0x0402C0F2 RID: 180466
		[Token(Token = "0x402C0F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _fragmentCntText;
	}
}
