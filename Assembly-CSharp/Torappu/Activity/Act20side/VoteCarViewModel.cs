using System;
using Il2CppDummyDll;
using Torappu.UI.Atlas;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007693 RID: 30355
	[Token(Token = "0x2007693")]
	public class VoteCarViewModel : IHotfixable
	{
		// Token: 0x0602AB17 RID: 174871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB17")]
		[Address(RVA = "0x267E810", Offset = "0x267D410", VA = "0x18267E810")]
		public void LoadData(string actId, ExhibitionShowItem showItem)
		{
		}

		// Token: 0x0602AB18 RID: 174872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB18")]
		[Address(RVA = "0x267E980", Offset = "0x267D580", VA = "0x18267E980")]
		public VoteCarViewModel()
		{
		}

		// Token: 0x0403D82F RID: 251951
		[Token(Token = "0x403D82F")]
		[FieldOffset(Offset = "0x10")]
		public bool hasNewEquipment;

		// Token: 0x0403D830 RID: 251952
		[Token(Token = "0x403D830")]
		[FieldOffset(Offset = "0x11")]
		public bool isNpc;

		// Token: 0x0403D831 RID: 251953
		[Token(Token = "0x403D831")]
		[FieldOffset(Offset = "0x18")]
		public string npcId;

		// Token: 0x0403D832 RID: 251954
		[Token(Token = "0x403D832")]
		[FieldOffset(Offset = "0x20")]
		public string npcName;

		// Token: 0x0403D833 RID: 251955
		[Token(Token = "0x403D833")]
		[FieldOffset(Offset = "0x28")]
		public string npcPicId;

		// Token: 0x0403D834 RID: 251956
		[Token(Token = "0x403D834")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderData npcPic;

		// Token: 0x0403D835 RID: 251957
		[Token(Token = "0x403D835")]
		[FieldOffset(Offset = "0x70")]
		public bool canRequest;

		// Token: 0x0403D836 RID: 251958
		[Token(Token = "0x403D836")]
		[FieldOffset(Offset = "0x78")]
		public ExhibitionFriendCard friendCard;

		// Token: 0x0403D837 RID: 251959
		[Token(Token = "0x403D837")]
		[FieldOffset(Offset = "0x80")]
		public PlayerCartInfo.Cart car;

		// Token: 0x0403D838 RID: 251960
		[Token(Token = "0x403D838")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D839 RID: 251961
		[Token(Token = "0x403D839")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
