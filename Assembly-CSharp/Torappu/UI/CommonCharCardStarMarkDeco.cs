using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003587 RID: 13703
	[Token(Token = "0x2003587")]
	public class CommonCharCardStarMarkDeco : CommonCharCardDecoBase
	{
		// Token: 0x06015CDB RID: 89307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015CDB")]
		[Address(RVA = "0xE5CBF0", Offset = "0xE5B7F0", VA = "0x180E5CBF0", Slot = "4")]
		public override void RenderDeco(ICharacterCardViewModel characterCardViewModel)
		{
		}

		// Token: 0x06015CDC RID: 89308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015CDC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CommonCharCardStarMarkDeco()
		{
		}

		// Token: 0x0401A3C9 RID: 107465
		[Token(Token = "0x401A3C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageStarMark;
	}
}
