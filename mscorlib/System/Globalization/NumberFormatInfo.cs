using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000586 RID: 1414
	[Token(Token = "0x2000586")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public sealed class NumberFormatInfo : System.ICloneable, System.IFormatProvider
	{
		// Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x4C36A50", Offset = "0x4C35650", VA = "0x184C36A50")]
		public NumberFormatInfo()
		{
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x4C36670", Offset = "0x4C35270", VA = "0x184C36670")]
		[System.Runtime.Serialization.OnSerializing]
		private void OnSerializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.Serialization.OnDeserializing]
		private void OnDeserializing(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.Serialization.OnDeserialized]
		private void OnDeserialized(System.Runtime.Serialization.StreamingContext ctx)
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x4C36A60", Offset = "0x4C35660", VA = "0x184C36A60")]
		internal NumberFormatInfo(CultureData cultureData)
		{
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x4C369C0", Offset = "0x4C355C0", VA = "0x184C369C0")]
		private void VerifyWritable()
		{
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700063B")]
		public static NumberFormatInfo InvariantInfo
		{
			[Token(Token = "0x60029ED")]
			[Address(RVA = "0x4C373D0", Offset = "0x4C35FD0", VA = "0x184C373D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x4C36330", Offset = "0x4C34F30", VA = "0x184C36330")]
		public static NumberFormatInfo GetInstance(System.IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x4C36230", Offset = "0x4C34E30", VA = "0x184C36230", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060029F0 RID: 10736 RVA: 0x00017508 File Offset: 0x00015708
		[Token(Token = "0x1700063C")]
		public int CurrencyDecimalDigits
		{
			[Token(Token = "0x60029F0")]
			[Address(RVA = "0x7893A0", Offset = "0x787FA0", VA = "0x1807893A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060029F1 RID: 10737 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700063D")]
		public string CurrencyDecimalSeparator
		{
			[Token(Token = "0x60029F1")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x00017520 File Offset: 0x00015720
		[Token(Token = "0x1700063E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60029F2")]
			[Address(RVA = "0x4C374F0", Offset = "0x4C360F0", VA = "0x184C374F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700063F")]
		public int[] CurrencyGroupSizes
		{
			[Token(Token = "0x60029F3")]
			[Address(RVA = "0x4C37220", Offset = "0x4C35E20", VA = "0x184C37220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000640")]
		public int[] NumberGroupSizes
		{
			[Token(Token = "0x60029F4")]
			[Address(RVA = "0x4C37500", Offset = "0x4C36100", VA = "0x184C37500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000641")]
		public int[] PercentGroupSizes
		{
			[Token(Token = "0x60029F5")]
			[Address(RVA = "0x4C37580", Offset = "0x4C36180", VA = "0x184C37580")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000642")]
		public string CurrencyGroupSeparator
		{
			[Token(Token = "0x60029F6")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000643")]
		public string CurrencySymbol
		{
			[Token(Token = "0x60029F7")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000644")]
		public static NumberFormatInfo CurrentInfo
		{
			[Token(Token = "0x60029F8")]
			[Address(RVA = "0x4C372A0", Offset = "0x4C35EA0", VA = "0x184C372A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060029F9 RID: 10745 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060029FA RID: 10746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000645")]
		public string NaNSymbol
		{
			[Token(Token = "0x60029F9")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60029FA")]
			[Address(RVA = "0x4C37600", Offset = "0x4C36200", VA = "0x184C37600")]
			set
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x00017538 File Offset: 0x00015738
		[Token(Token = "0x17000646")]
		public int CurrencyNegativePattern
		{
			[Token(Token = "0x60029FB")]
			[Address(RVA = "0x32FC460", Offset = "0x32FB060", VA = "0x1832FC460")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x00017550 File Offset: 0x00015750
		[Token(Token = "0x17000647")]
		public int NumberNegativePattern
		{
			[Token(Token = "0x60029FC")]
			[Address(RVA = "0x32FC4A0", Offset = "0x32FB0A0", VA = "0x1832FC4A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x00017568 File Offset: 0x00015768
		[Token(Token = "0x17000648")]
		public int PercentPositivePattern
		{
			[Token(Token = "0x60029FD")]
			[Address(RVA = "0x789280", Offset = "0x787E80", VA = "0x180789280")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060029FE RID: 10750 RVA: 0x00017580 File Offset: 0x00015780
		[Token(Token = "0x17000649")]
		public int PercentNegativePattern
		{
			[Token(Token = "0x60029FE")]
			[Address(RVA = "0x32FC490", Offset = "0x32FB090", VA = "0x1832FC490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700064A")]
		public string NegativeInfinitySymbol
		{
			[Token(Token = "0x60029FF")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700064B")]
		public string NegativeSign
		{
			[Token(Token = "0x6002A00")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x00017598 File Offset: 0x00015798
		[Token(Token = "0x1700064C")]
		public int NumberDecimalDigits
		{
			[Token(Token = "0x6002A01")]
			[Address(RVA = "0x32F7200", Offset = "0x32F5E00", VA = "0x1832F7200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700064D")]
		public string NumberDecimalSeparator
		{
			[Token(Token = "0x6002A02")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002A03 RID: 10755 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700064E")]
		public string NumberGroupSeparator
		{
			[Token(Token = "0x6002A03")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x000175B0 File Offset: 0x000157B0
		[Token(Token = "0x1700064F")]
		public int CurrencyPositivePattern
		{
			[Token(Token = "0x6002A04")]
			[Address(RVA = "0x32FC470", Offset = "0x32FB070", VA = "0x1832FC470")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000650")]
		public string PositiveInfinitySymbol
		{
			[Token(Token = "0x6002A05")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002A06 RID: 10758 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000651")]
		public string PositiveSign
		{
			[Token(Token = "0x6002A06")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000175C8 File Offset: 0x000157C8
		[Token(Token = "0x17000652")]
		public int PercentDecimalDigits
		{
			[Token(Token = "0x6002A07")]
			[Address(RVA = "0xED1D70", Offset = "0xED0970", VA = "0x180ED1D70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000653")]
		public string PercentDecimalSeparator
		{
			[Token(Token = "0x6002A08")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000654")]
		public string PercentGroupSeparator
		{
			[Token(Token = "0x6002A09")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000655")]
		public string PercentSymbol
		{
			[Token(Token = "0x6002A0A")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000656")]
		public string PerMilleSymbol
		{
			[Token(Token = "0x6002A0B")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002A0C RID: 10764 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A0C")]
		[Address(RVA = "0x4C362A0", Offset = "0x4C34EA0", VA = "0x184C362A0", Slot = "5")]
		public object GetFormat(System.Type formatType)
		{
			return null;
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002A0D")]
		[Address(RVA = "0x4C36700", Offset = "0x4C35300", VA = "0x184C36700")]
		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			return null;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x4C368C0", Offset = "0x4C354C0", VA = "0x184C368C0")]
		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x4C367D0", Offset = "0x4C353D0", VA = "0x184C367D0")]
		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
		}

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo invariantInfo;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int[] numberGroupSizes;

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int[] currencyGroupSizes;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int[] percentGroupSizes;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal string positiveSign;

		// Token: 0x04001857 RID: 6231
		[Token(Token = "0x4001857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string negativeSign;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string numberDecimalSeparator;

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal string numberGroupSeparator;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal string currencyGroupSeparator;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		internal string currencyDecimalSeparator;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal string currencySymbol;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string ansiCurrencySymbol;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal string nanSymbol;

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal string positiveInfinitySymbol;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal string negativeInfinitySymbol;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal string percentDecimalSeparator;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal string percentGroupSeparator;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal string percentSymbol;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal string perMilleSymbol;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		internal string[] nativeDigits;

		// Token: 0x04001866 RID: 6246
		[Token(Token = "0x4001866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal int m_dataItem;

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		internal int numberDecimalDigits;

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		internal int currencyDecimalDigits;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		internal int currencyPositivePattern;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		internal int currencyNegativePattern;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		internal int numberNegativePattern;

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal int percentPositivePattern;

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		internal int percentNegativePattern;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		internal int percentDecimalDigits;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		internal int digitSubstitution;

		// Token: 0x04001870 RID: 6256
		[Token(Token = "0x4001870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		internal bool isReadOnly;

		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4001871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x4001872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 2)]
		internal bool m_isInvariant;

		// Token: 0x04001873 RID: 6259
		[Token(Token = "0x4001873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD3")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal bool validForParseAsNumber;

		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[System.Runtime.Serialization.OptionalField(VersionAdded = 1)]
		internal bool validForParseAsCurrency;

		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.AllowHexSpecifier);
	}
}
