using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F87 RID: 24455
	[Token(Token = "0x2005F87")]
	public class CharacterInfoPotentialIconHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005399 RID: 21401
		// (get) Token: 0x06023621 RID: 144929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005399")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x6023621")]
			[Address(RVA = "0x1E00D80", Offset = "0x1DFF980", VA = "0x181E00D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023622 RID: 144930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023622")]
		[Address(RVA = "0x1E00C60", Offset = "0x1DFF860", VA = "0x181E00C60")]
		public void Render(int rank)
		{
		}

		// Token: 0x06023623 RID: 144931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023623")]
		[Address(RVA = "0x1E00D20", Offset = "0x1DFF920", VA = "0x181E00D20")]
		public CharacterInfoPotentialIconHolder()
		{
		}

		// Token: 0x04030E05 RID: 200197
		[Token(Token = "0x4030E05")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgPotentialIcon;

		// Token: 0x04030E06 RID: 200198
		[Token(Token = "0x4030E06")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04030E07 RID: 200199
		[Token(Token = "0x4030E07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x04030E08 RID: 200200
		[Token(Token = "0x4030E08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030E09 RID: 200201
		[Token(Token = "0x4030E09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
