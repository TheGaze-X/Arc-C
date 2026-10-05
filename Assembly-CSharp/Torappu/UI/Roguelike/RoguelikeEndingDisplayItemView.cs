using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052AD RID: 21165
	[Token(Token = "0x20052AD")]
	public class RoguelikeEndingDisplayItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F390 RID: 127888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F390")]
		[Address(RVA = "0x18EA700", Offset = "0x18E9300", VA = "0x1818EA700")]
		public void Render(Sprite sprite)
		{
		}

		// Token: 0x0601F391 RID: 127889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F391")]
		[Address(RVA = "0x18EA7C0", Offset = "0x18E93C0", VA = "0x1818EA7C0")]
		public RoguelikeEndingDisplayItemView()
		{
		}

		// Token: 0x04029ED0 RID: 171728
		[Token(Token = "0x4029ED0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04029ED1 RID: 171729
		[Token(Token = "0x4029ED1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029ED2 RID: 171730
		[Token(Token = "0x4029ED2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
