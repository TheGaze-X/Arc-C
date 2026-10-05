using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007675 RID: 30325
	[Token(Token = "0x2007675")]
	public class Act20sideCartCompSelectViewModel
	{
		// Token: 0x0602AA84 RID: 174724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA84")]
		[Address(RVA = "0x266EFE0", Offset = "0x266DBE0", VA = "0x18266EFE0")]
		public string GetSelectCompId()
		{
			return null;
		}

		// Token: 0x0602AA85 RID: 174725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA85")]
		[Address(RVA = "0x266F070", Offset = "0x266DC70", VA = "0x18266F070")]
		public CartCompViewModel GetSelectComp()
		{
			return null;
		}

		// Token: 0x0602AA86 RID: 174726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AA86")]
		[Address(RVA = "0x266F0E0", Offset = "0x266DCE0", VA = "0x18266F0E0")]
		public List<CartCompViewModel> InstSelectCartComp()
		{
			return null;
		}

		// Token: 0x0602AA87 RID: 174727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA87")]
		[Address(RVA = "0x266F3E0", Offset = "0x266DFE0", VA = "0x18266F3E0")]
		public void MarkChangeSave()
		{
		}

		// Token: 0x0602AA88 RID: 174728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA88")]
		[Address(RVA = "0x266FAC0", Offset = "0x266E6C0", VA = "0x18266FAC0")]
		private void _MarkCurrentSelect()
		{
		}

		// Token: 0x0602AA89 RID: 174729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA89")]
		[Address(RVA = "0x266F3F0", Offset = "0x266DFF0", VA = "0x18266F3F0")]
		public void SelectAccess(string compId)
		{
		}

		// Token: 0x0602AA8A RID: 174730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA8A")]
		[Address(RVA = "0x266F860", Offset = "0x266E460", VA = "0x18266F860")]
		public void SelectPos(CartComponents.CartAccessoryPos pos)
		{
		}

		// Token: 0x0602AA8B RID: 174731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AA8B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act20sideCartCompSelectViewModel()
		{
		}

		// Token: 0x0403D6F2 RID: 251634
		[Token(Token = "0x403D6F2")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D6F3 RID: 251635
		[Token(Token = "0x403D6F3")]
		[FieldOffset(Offset = "0x18")]
		public bool isExhibt;

		// Token: 0x0403D6F4 RID: 251636
		[Token(Token = "0x403D6F4")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<CartComponents.CartAccessoryPos, CartCompViewModel> compsOnCar;

		// Token: 0x0403D6F5 RID: 251637
		[Token(Token = "0x403D6F5")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CartCompViewModel> cartCompList;

		// Token: 0x0403D6F6 RID: 251638
		[Token(Token = "0x403D6F6")]
		[FieldOffset(Offset = "0x30")]
		public CartComponents.CartAccessoryPos selectPos;

		// Token: 0x0403D6F7 RID: 251639
		[Token(Token = "0x403D6F7")]
		[FieldOffset(Offset = "0x34")]
		public bool isChanged;
	}
}
