using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200671F RID: 26399
	[Token(Token = "0x200671F")]
	public class HandBookV2ForceViewModel
	{
		// Token: 0x170059AE RID: 22958
		// (get) Token: 0x06025DF6 RID: 155126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059AE")]
		public string forceId
		{
			[Token(Token = "0x6025DF6")]
			[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059AF RID: 22959
		// (get) Token: 0x06025DF7 RID: 155127 RVA: 0x000C9420 File Offset: 0x000C7620
		[Token(Token = "0x170059AF")]
		public int forceIndex
		{
			[Token(Token = "0x6025DF7")]
			[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170059B0 RID: 22960
		// (get) Token: 0x06025DF8 RID: 155128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059B0")]
		public string color
		{
			[Token(Token = "0x6025DF8")]
			[Address(RVA = "0x1CA1D80", Offset = "0x1CA0980", VA = "0x181CA1D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059B1 RID: 22961
		// (get) Token: 0x06025DF9 RID: 155129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059B1")]
		public string cardColor
		{
			[Token(Token = "0x6025DF9")]
			[Address(RVA = "0xFEE8C0", Offset = "0xFED4C0", VA = "0x180FEE8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059B2 RID: 22962
		// (get) Token: 0x06025DFA RID: 155130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059B2")]
		public List<HandBookV2PointData> pointList
		{
			[Token(Token = "0x6025DFA")]
			[Address(RVA = "0x111CB60", Offset = "0x111B760", VA = "0x18111CB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170059B3 RID: 22963
		// (get) Token: 0x06025DFB RID: 155131 RVA: 0x000C9438 File Offset: 0x000C7638
		[Token(Token = "0x170059B3")]
		public bool isAvail
		{
			[Token(Token = "0x6025DFB")]
			[Address(RVA = "0x20DE290", Offset = "0x20DCE90", VA = "0x1820DE290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170059B4 RID: 22964
		// (get) Token: 0x06025DFC RID: 155132 RVA: 0x000C9450 File Offset: 0x000C7650
		[Token(Token = "0x170059B4")]
		public bool isComplete
		{
			[Token(Token = "0x6025DFC")]
			[Address(RVA = "0x20DE2A0", Offset = "0x20DCEA0", VA = "0x1820DE2A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170059B5 RID: 22965
		// (get) Token: 0x06025DFD RID: 155133 RVA: 0x000C9468 File Offset: 0x000C7668
		[Token(Token = "0x170059B5")]
		public bool isEmpty
		{
			[Token(Token = "0x6025DFD")]
			[Address(RVA = "0x20DE2B0", Offset = "0x20DCEB0", VA = "0x1820DE2B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170059B6 RID: 22966
		// (get) Token: 0x06025DFE RID: 155134 RVA: 0x000C9480 File Offset: 0x000C7680
		[Token(Token = "0x170059B6")]
		public int favorAvg
		{
			[Token(Token = "0x6025DFE")]
			[Address(RVA = "0x20DE240", Offset = "0x20DCE40", VA = "0x1820DE240")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025DFF RID: 155135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DFF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2ForceViewModel()
		{
		}

		// Token: 0x04035453 RID: 218195
		[Token(Token = "0x4035453")]
		[FieldOffset(Offset = "0x10")]
		public HandBookV2ForceData forceData;

		// Token: 0x04035454 RID: 218196
		[Token(Token = "0x4035454")]
		[FieldOffset(Offset = "0x18")]
		public List<string> ownCharIdList;

		// Token: 0x04035455 RID: 218197
		[Token(Token = "0x4035455")]
		[FieldOffset(Offset = "0x20")]
		public List<string> ownNPCIdList;

		// Token: 0x04035456 RID: 218198
		[Token(Token = "0x4035456")]
		[FieldOffset(Offset = "0x28")]
		public List<string> allCharIdList;

		// Token: 0x04035457 RID: 218199
		[Token(Token = "0x4035457")]
		[FieldOffset(Offset = "0x30")]
		public List<string> allNPCIdList;

		// Token: 0x04035458 RID: 218200
		[Token(Token = "0x4035458")]
		[FieldOffset(Offset = "0x38")]
		public int favorSum;

		// Token: 0x04035459 RID: 218201
		[Token(Token = "0x4035459")]
		[FieldOffset(Offset = "0x3C")]
		public int charOwn;

		// Token: 0x0403545A RID: 218202
		[Token(Token = "0x403545A")]
		[FieldOffset(Offset = "0x40")]
		public int charSum;
	}
}
