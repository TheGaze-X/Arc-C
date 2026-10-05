using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007698 RID: 30360
	[Token(Token = "0x2007698")]
	public class Act20sideCollectionViewModel : IHotfixable
	{
		// Token: 0x17006455 RID: 25685
		// (get) Token: 0x0602AB26 RID: 174886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602AB27 RID: 174887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006455")]
		public string curSelectCompId
		{
			[Token(Token = "0x602AB26")]
			[Address(RVA = "0x2671800", Offset = "0x2670400", VA = "0x182671800")]
			get
			{
				return null;
			}
			[Token(Token = "0x602AB27")]
			[Address(RVA = "0x2671870", Offset = "0x2670470", VA = "0x182671870")]
			set
			{
			}
		}

		// Token: 0x0602AB28 RID: 174888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AB28")]
		[Address(RVA = "0x26714B0", Offset = "0x26700B0", VA = "0x1826714B0")]
		private Dictionary<string, CartComponents> _GetCarTable()
		{
			return null;
		}

		// Token: 0x0602AB29 RID: 174889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB29")]
		[Address(RVA = "0x2670E40", Offset = "0x266FA40", VA = "0x182670E40")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x0602AB2A RID: 174890 RVA: 0x000D9758 File Offset: 0x000D7958
		[Token(Token = "0x602AB2A")]
		[Address(RVA = "0x2671560", Offset = "0x2670160", VA = "0x182671560")]
		private CartComponents.CartAccessoryPos _TypeToCollectionDisplayPos(CartComponents.CartAccessoryType type)
		{
			return CartComponents.CartAccessoryPos.NONE;
		}

		// Token: 0x0602AB2B RID: 174891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB2B")]
		[Address(RVA = "0x2671780", Offset = "0x2670380", VA = "0x182671780")]
		public Act20sideCollectionViewModel()
		{
		}

		// Token: 0x0403D84A RID: 251978
		[Token(Token = "0x403D84A")]
		[FieldOffset(Offset = "0x10")]
		private string m_curSelectCompId;

		// Token: 0x0403D84B RID: 251979
		[Token(Token = "0x403D84B")]
		[FieldOffset(Offset = "0x18")]
		public List<Act20sideCollectionItemViewModel> collectItemList;

		// Token: 0x0403D84C RID: 251980
		[Token(Token = "0x403D84C")]
		[FieldOffset(Offset = "0x20")]
		public int collectProgressNum;

		// Token: 0x0403D84D RID: 251981
		[Token(Token = "0x403D84D")]
		[FieldOffset(Offset = "0x24")]
		public int collectProgressTotalNum;

		// Token: 0x0403D84E RID: 251982
		[Token(Token = "0x403D84E")]
		[FieldOffset(Offset = "0x28")]
		public int totalCollectedNum;

		// Token: 0x0403D84F RID: 251983
		[Token(Token = "0x403D84F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<CartComponents.CartAccessoryType, string> DISPLAY_BG_RES_MAP;

		// Token: 0x0403D850 RID: 251984
		[Token(Token = "0x403D850")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curSelectCompId;

		// Token: 0x0403D851 RID: 251985
		[Token(Token = "0x403D851")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_curSelectCompId;

		// Token: 0x0403D852 RID: 251986
		[Token(Token = "0x403D852")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetCarTable;

		// Token: 0x0403D853 RID: 251987
		[Token(Token = "0x403D853")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D854 RID: 251988
		[Token(Token = "0x403D854")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TypeToCollectionDisplayPos;

		// Token: 0x0403D855 RID: 251989
		[Token(Token = "0x403D855")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
