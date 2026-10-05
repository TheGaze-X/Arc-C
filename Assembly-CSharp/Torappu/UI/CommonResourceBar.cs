using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003919 RID: 14617
	[Token(Token = "0x2003919")]
	public class CommonResourceBar : MonoBehaviour
	{
		// Token: 0x060171A9 RID: 94633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171A9")]
		[Address(RVA = "0xF70B90", Offset = "0xF6F790", VA = "0x180F70B90")]
		public void Render(ResourceBarViewModel viewModel)
		{
		}

		// Token: 0x060171AA RID: 94634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60171AA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CommonResourceBar()
		{
		}

		// Token: 0x0401BE29 RID: 114217
		[Token(Token = "0x401BE29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CommonResourceBarItem _itemGold;

		// Token: 0x0401BE2A RID: 114218
		[Token(Token = "0x401BE2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CommonResourceBarItem _itemCrystal;

		// Token: 0x0401BE2B RID: 114219
		[Token(Token = "0x401BE2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CommonResourceBarItem _itemDiamondShard;

		// Token: 0x0401BE2C RID: 114220
		[Token(Token = "0x401BE2C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CommonResourceBarItem _itemRecruitLicense;

		// Token: 0x0401BE2D RID: 114221
		[Token(Token = "0x401BE2D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CommonResourceBarItem _itemActionPoint;

		// Token: 0x0401BE2E RID: 114222
		[Token(Token = "0x401BE2E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CommonResourceBarItem _itemPractiseTicket;

		// Token: 0x0401BE2F RID: 114223
		[Token(Token = "0x401BE2F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CommonResourceBarItem _itemLGG;

		// Token: 0x0401BE30 RID: 114224
		[Token(Token = "0x401BE30")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CommonResourceBarItem _itemHGG;

		// Token: 0x0401BE31 RID: 114225
		[Token(Token = "0x401BE31")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CommonResourceBarItem _itemEGG;

		// Token: 0x0401BE32 RID: 114226
		[Token(Token = "0x401BE32")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CommonResourceBarItem _itemSocialPoint;

		// Token: 0x0401BE33 RID: 114227
		[Token(Token = "0x401BE33")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CommonResourceBarItem _itemFurnCoin;

		// Token: 0x0401BE34 RID: 114228
		[Token(Token = "0x401BE34")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CommonResourceBarItem _itemConvertDiamondShard;

		// Token: 0x0401BE35 RID: 114229
		[Token(Token = "0x401BE35")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CommonResourceBarItem _itemEPGShard;

		// Token: 0x0401BE36 RID: 114230
		[Token(Token = "0x401BE36")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CommonResourceBarItem _itemREPShard;

		// Token: 0x0401BE37 RID: 114231
		[Token(Token = "0x401BE37")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CommonResourceBarItem _itemClassicShard;

		// Token: 0x0401BE38 RID: 114232
		[Token(Token = "0x401BE38")]
		private const string SOCIAL_STRING_FORMAT = "{0}<size=26><color=#565656>/{1}</color></size>";
	}
}
