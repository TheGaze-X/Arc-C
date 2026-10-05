using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E39 RID: 20025
	[Token(Token = "0x2004E39")]
	public class FireworkPlatePieceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DE94 RID: 122516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE94")]
		[Address(RVA = "0x176FCC0", Offset = "0x176E8C0", VA = "0x18176FCC0")]
		public void Render(FireworkData.PlateSlotData plateSlotData)
		{
		}

		// Token: 0x0601DE95 RID: 122517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DE95")]
		[Address(RVA = "0x176FE20", Offset = "0x176EA20", VA = "0x18176FE20")]
		public FireworkPlatePieceView()
		{
		}

		// Token: 0x04027B01 RID: 162561
		[Token(Token = "0x4027B01")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgPlatePiece;

		// Token: 0x04027B02 RID: 162562
		[Token(Token = "0x4027B02")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x04027B03 RID: 162563
		[Token(Token = "0x4027B03")]
		[FieldOffset(Offset = "0x28")]
		private FireworkData.PlateSlotData m_cachedSlotData;

		// Token: 0x04027B04 RID: 162564
		[Token(Token = "0x4027B04")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027B05 RID: 162565
		[Token(Token = "0x4027B05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027B06 RID: 162566
		[Token(Token = "0x4027B06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
