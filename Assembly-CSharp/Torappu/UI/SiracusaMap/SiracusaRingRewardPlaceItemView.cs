using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F1D RID: 16157
	[Token(Token = "0x2003F1D")]
	public class SiracusaRingRewardPlaceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019165 RID: 102757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019165")]
		[Address(RVA = "0x11DEAC0", Offset = "0x11DD6C0", VA = "0x1811DEAC0")]
		public void Render(SiracusaCharTaskModel taskModel)
		{
		}

		// Token: 0x06019166 RID: 102758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019166")]
		[Address(RVA = "0x11DEB70", Offset = "0x11DD770", VA = "0x1811DEB70")]
		public SiracusaRingRewardPlaceItemView()
		{
		}

		// Token: 0x0401F0AA RID: 127146
		[Token(Token = "0x401F0AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPlaceName;

		// Token: 0x0401F0AB RID: 127147
		[Token(Token = "0x401F0AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F0AC RID: 127148
		[Token(Token = "0x401F0AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
