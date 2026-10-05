using System;
using Il2CppDummyDll;
using Torappu.UI.Friend;
using XLua;

namespace Torappu.UI.SocialCardAlbum
{
	// Token: 0x02003EC2 RID: 16066
	[Token(Token = "0x2003EC2")]
	public class NameCardViewModel : CardViewModel
	{
		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x06018EEF RID: 102127 RVA: 0x0009C6F0 File Offset: 0x0009A8F0
		[Token(Token = "0x17003B7B")]
		public override CardType cardType
		{
			[Token(Token = "0x6018EEF")]
			[Address(RVA = "0x11965F0", Offset = "0x11951F0", VA = "0x1811965F0", Slot = "4")]
			get
			{
				return CardType.NAME_CARD;
			}
		}

		// Token: 0x06018EF0 RID: 102128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018EF0")]
		[Address(RVA = "0x1196550", Offset = "0x1195150", VA = "0x181196550")]
		public NameCardViewModel()
		{
		}

		// Token: 0x0401EC50 RID: 126032
		[Token(Token = "0x401EC50")]
		[FieldOffset(Offset = "0x10")]
		public NameCardV2ViewModel nameCard;

		// Token: 0x0401EC51 RID: 126033
		[Token(Token = "0x401EC51")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0401EC52 RID: 126034
		[Token(Token = "0x401EC52")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
