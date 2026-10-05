using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200769A RID: 30362
	[Token(Token = "0x200769A")]
	public class Act20sideCollectionItemViewModel : IHotfixable
	{
		// Token: 0x0602AB30 RID: 174896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB30")]
		[Address(RVA = "0x26704B0", Offset = "0x266F0B0", VA = "0x1826704B0")]
		public Act20sideCollectionItemViewModel()
		{
		}

		// Token: 0x0403D858 RID: 251992
		[Token(Token = "0x403D858")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0403D859 RID: 251993
		[Token(Token = "0x403D859")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0403D85A RID: 251994
		[Token(Token = "0x403D85A")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0403D85B RID: 251995
		[Token(Token = "0x403D85B")]
		[FieldOffset(Offset = "0x28")]
		public int rarity;

		// Token: 0x0403D85C RID: 251996
		[Token(Token = "0x403D85C")]
		[FieldOffset(Offset = "0x2C")]
		public int sortId;

		// Token: 0x0403D85D RID: 251997
		[Token(Token = "0x403D85D")]
		[FieldOffset(Offset = "0x30")]
		public int count;

		// Token: 0x0403D85E RID: 251998
		[Token(Token = "0x403D85E")]
		[FieldOffset(Offset = "0x38")]
		public string usage;

		// Token: 0x0403D85F RID: 251999
		[Token(Token = "0x403D85F")]
		[FieldOffset(Offset = "0x40")]
		public string obtain;

		// Token: 0x0403D860 RID: 252000
		[Token(Token = "0x403D860")]
		[FieldOffset(Offset = "0x48")]
		public string bgImageId;

		// Token: 0x0403D861 RID: 252001
		[Token(Token = "0x403D861")]
		[FieldOffset(Offset = "0x50")]
		public Sprite itemIcon;

		// Token: 0x0403D862 RID: 252002
		[Token(Token = "0x403D862")]
		[FieldOffset(Offset = "0x58")]
		public CartComponents.CartAccessoryType type;

		// Token: 0x0403D863 RID: 252003
		[Token(Token = "0x403D863")]
		[FieldOffset(Offset = "0x5C")]
		public CartComponents.CartAccessoryPos pos;

		// Token: 0x0403D864 RID: 252004
		[Token(Token = "0x403D864")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
