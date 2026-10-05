using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F50 RID: 24400
	[Token(Token = "0x2005F50")]
	public class CharacterInfoHomeEvolveView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023549 RID: 144713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023549")]
		[Address(RVA = "0x1DD7950", Offset = "0x1DD6550", VA = "0x181DD7950")]
		public void Render(CharacterInfoHolderBean.CharViewModel charViewModel)
		{
		}

		// Token: 0x0602354A RID: 144714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602354A")]
		[Address(RVA = "0x1DD7A50", Offset = "0x1DD6650", VA = "0x181DD7A50")]
		public CharacterInfoHomeEvolveView()
		{
		}

		// Token: 0x04030BFF RID: 199679
		[Token(Token = "0x4030BFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageEvolved;

		// Token: 0x04030C00 RID: 199680
		[Token(Token = "0x4030C00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imageMaxEvoled;

		// Token: 0x04030C01 RID: 199681
		[Token(Token = "0x4030C01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imagePlus;

		// Token: 0x04030C02 RID: 199682
		[Token(Token = "0x4030C02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030C03 RID: 199683
		[Token(Token = "0x4030C03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
