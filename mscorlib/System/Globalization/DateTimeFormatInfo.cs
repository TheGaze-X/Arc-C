using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	[System.Serializable]
	public sealed class DateTimeFormatInfo : System.IFormatProvider, System.ICloneable
	{
		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DE")]
		private string CultureName
		{
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x4C19C80", Offset = "0x4C18880", VA = "0x184C19C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005DF")]
		private CultureInfo Culture
		{
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x4C19CC0", Offset = "0x4C188C0", VA = "0x184C19CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x060028A0 RID: 10400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E0")]
		private string LanguageName
		{
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0x4C1A9E0", Offset = "0x4C195E0", VA = "0x184C1A9E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x4C1B230", Offset = "0x4C19E30", VA = "0x184C1B230")]
		private string[] internalGetAbbreviatedDayOfWeekNames()
		{
			return null;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x4C1B1A0", Offset = "0x4C19DA0", VA = "0x184C1B1A0")]
		[MethodImpl(8)]
		private string[] internalGetAbbreviatedDayOfWeekNamesCore()
		{
			return null;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x4C1B390", Offset = "0x4C19F90", VA = "0x184C1B390")]
		private string[] internalGetDayOfWeekNames()
		{
			return null;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x4C1B300", Offset = "0x4C19F00", VA = "0x184C1B300")]
		[MethodImpl(8)]
		private string[] internalGetDayOfWeekNamesCore()
		{
			return null;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x4C1B2E0", Offset = "0x4C19EE0", VA = "0x184C1B2E0")]
		private string[] internalGetAbbreviatedMonthNames()
		{
			return null;
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x4C1B250", Offset = "0x4C19E50", VA = "0x184C1B250")]
		[MethodImpl(8)]
		private string[] internalGetAbbreviatedMonthNamesCore()
		{
			return null;
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x4C1B7C0", Offset = "0x4C1A3C0", VA = "0x184C1B7C0")]
		private string[] internalGetMonthNames()
		{
			return null;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x4C1B730", Offset = "0x4C1A330", VA = "0x184C1B730")]
		[MethodImpl(8)]
		private string[] internalGetMonthNamesCore()
		{
			return null;
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x4C19230", Offset = "0x4C17E30", VA = "0x184C19230")]
		public DateTimeFormatInfo()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x4C194D0", Offset = "0x4C180D0", VA = "0x184C194D0")]
		internal DateTimeFormatInfo(CultureData cultureData, Calendar cal)
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x4C169A0", Offset = "0x4C155A0", VA = "0x184C169A0")]
		private void InitializeOverridableProperties(CultureData cultureData, int calendarId)
		{
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060028AC RID: 10412 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E1")]
		public static DateTimeFormatInfo InvariantInfo
		{
			[Token(Token = "0x60028AC")]
			[Address(RVA = "0x4C1A840", Offset = "0x4C19440", VA = "0x184C1A840")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E2")]
		public static DateTimeFormatInfo CurrentInfo
		{
			[Token(Token = "0x60028AD")]
			[Address(RVA = "0x4C19D70", Offset = "0x4C18970", VA = "0x184C19D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x4C15B70", Offset = "0x4C14770", VA = "0x184C15B70")]
		public static DateTimeFormatInfo GetInstance(System.IFormatProvider provider)
		{
			return null;
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x4C15AE0", Offset = "0x4C146E0", VA = "0x184C15AE0", Slot = "4")]
		public object GetFormat(System.Type formatType)
		{
			return null;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x4C13F20", Offset = "0x4C12B20", VA = "0x184C13F20", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E3")]
		public string AMDesignator
		{
			[Token(Token = "0x60028B1")]
			[Address(RVA = "0x4C19530", Offset = "0x4C18130", VA = "0x184C19530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060028B2 RID: 10418 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060028B3 RID: 10419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E4")]
		public Calendar Calendar
		{
			[Token(Token = "0x60028B2")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B3")]
			[Address(RVA = "0x4C1B7E0", Offset = "0x4C1A3E0", VA = "0x184C1B7E0")]
			set
			{
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E5")]
		private CalendarId[] OptionalCalendars
		{
			[Token(Token = "0x60028B4")]
			[Address(RVA = "0x4C1AD00", Offset = "0x4C19900", VA = "0x184C1AD00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E6")]
		internal string[] EraNames
		{
			[Token(Token = "0x60028B5")]
			[Address(RVA = "0x4C1A220", Offset = "0x4C18E20", VA = "0x184C1A220")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028B6")]
		[Address(RVA = "0x4C15970", Offset = "0x4C14570", VA = "0x184C15970")]
		public string GetEraName(int era)
		{
			return null;
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E7")]
		internal string[] AbbreviatedEraNames
		{
			[Token(Token = "0x60028B7")]
			[Address(RVA = "0x4C19690", Offset = "0x4C18290", VA = "0x184C19690")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028B8")]
		[Address(RVA = "0x4C14E50", Offset = "0x4C13A50", VA = "0x184C14E50")]
		public string GetAbbreviatedEraName(int era)
		{
			return null;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E8")]
		internal string[] AbbreviatedEnglishEraNames
		{
			[Token(Token = "0x60028B9")]
			[Address(RVA = "0x4C19600", Offset = "0x4C18200", VA = "0x184C19600")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005E9")]
		public string DateSeparator
		{
			[Token(Token = "0x60028BA")]
			[Address(RVA = "0x4C19EA0", Offset = "0x4C18AA0", VA = "0x184C19EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x00016680 File Offset: 0x00014880
		[Token(Token = "0x170005EA")]
		public System.DayOfWeek FirstDayOfWeek
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x4C1A2B0", Offset = "0x4C18EB0", VA = "0x184C1A2B0")]
			get
			{
				return System.DayOfWeek.Sunday;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005EB")]
		public string FullDateTimePattern
		{
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x4C1A300", Offset = "0x4C18F00", VA = "0x184C1A300")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060028BD RID: 10429 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005EC")]
		public string LongDatePattern
		{
			[Token(Token = "0x60028BD")]
			[Address(RVA = "0x4C1AA20", Offset = "0x4C19620", VA = "0x184C1AA20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005ED")]
		public string LongTimePattern
		{
			[Token(Token = "0x60028BE")]
			[Address(RVA = "0x4C1AA70", Offset = "0x4C19670", VA = "0x184C1AA70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060028BF RID: 10431 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005EE")]
		public string MonthDayPattern
		{
			[Token(Token = "0x60028BF")]
			[Address(RVA = "0x4C1AAF0", Offset = "0x4C196F0", VA = "0x184C1AAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005EF")]
		public string PMDesignator
		{
			[Token(Token = "0x60028C0")]
			[Address(RVA = "0x4C1AD40", Offset = "0x4C19940", VA = "0x184C1AD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F0")]
		public string RFC1123Pattern
		{
			[Token(Token = "0x60028C1")]
			[Address(RVA = "0x4C1AD80", Offset = "0x4C19980", VA = "0x184C1AD80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060028C2 RID: 10434 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F1")]
		public string ShortDatePattern
		{
			[Token(Token = "0x60028C2")]
			[Address(RVA = "0x4C1ADB0", Offset = "0x4C199B0", VA = "0x184C1ADB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060028C3 RID: 10435 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F2")]
		public string ShortTimePattern
		{
			[Token(Token = "0x60028C3")]
			[Address(RVA = "0x4C1AE00", Offset = "0x4C19A00", VA = "0x184C1AE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F3")]
		public string SortableDateTimePattern
		{
			[Token(Token = "0x60028C4")]
			[Address(RVA = "0x4C1AE80", Offset = "0x4C19A80", VA = "0x184C1AE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F4")]
		internal string GeneralShortTimePattern
		{
			[Token(Token = "0x60028C5")]
			[Address(RVA = "0x4C1A6C0", Offset = "0x4C192C0", VA = "0x184C1A6C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F5")]
		internal string GeneralLongTimePattern
		{
			[Token(Token = "0x60028C6")]
			[Address(RVA = "0x4C1A5F0", Offset = "0x4C191F0", VA = "0x184C1A5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F6")]
		internal string DateTimeOffsetPattern
		{
			[Token(Token = "0x60028C7")]
			[Address(RVA = "0x4C19F30", Offset = "0x4C18B30", VA = "0x184C19F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060028C8 RID: 10440 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F7")]
		public string TimeSeparator
		{
			[Token(Token = "0x60028C8")]
			[Address(RVA = "0x4C1AEB0", Offset = "0x4C19AB0", VA = "0x184C1AEB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F8")]
		public string UniversalSortableDateTimePattern
		{
			[Token(Token = "0x60028C9")]
			[Address(RVA = "0x4C1B120", Offset = "0x4C19D20", VA = "0x184C1B120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005F9")]
		public string YearMonthPattern
		{
			[Token(Token = "0x60028CA")]
			[Address(RVA = "0x4C1B150", Offset = "0x4C19D50", VA = "0x184C1B150")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005FA")]
		public string[] AbbreviatedDayNames
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x4C19570", Offset = "0x4C18170", VA = "0x184C19570")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060028CC RID: 10444 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005FB")]
		public string[] DayNames
		{
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x4C1A190", Offset = "0x4C18D90", VA = "0x184C1A190")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005FC")]
		public string[] AbbreviatedMonthNames
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x4C19720", Offset = "0x4C18320", VA = "0x184C19720")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170005FD")]
		public string[] MonthNames
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x4C1AC70", Offset = "0x4C19870", VA = "0x184C1AC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060028CF RID: 10447 RVA: 0x00016698 File Offset: 0x00014898
		[Token(Token = "0x170005FE")]
		internal bool HasSpacesInMonthNames
		{
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x4C1A800", Offset = "0x4C19400", VA = "0x184C1A800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060028D0 RID: 10448 RVA: 0x000166B0 File Offset: 0x000148B0
		[Token(Token = "0x170005FF")]
		internal bool HasSpacesInDayNames
		{
			[Token(Token = "0x60028D0")]
			[Address(RVA = "0x4C1A7E0", Offset = "0x4C193E0", VA = "0x184C1A7E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x4C1B550", Offset = "0x4C1A150", VA = "0x184C1B550")]
		internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated)
		{
			return null;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x4C1B3B0", Offset = "0x4C19FB0", VA = "0x184C1B3B0")]
		private string[] internalGetGenitiveMonthNames(bool abbreviated)
		{
			return null;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x4C1B4C0", Offset = "0x4C1A0C0", VA = "0x184C1B4C0")]
		internal string[] internalGetLeapYearMonthNames()
		{
			return null;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x4C14D30", Offset = "0x4C13930", VA = "0x184C14D30")]
		public string GetAbbreviatedDayName(System.DayOfWeek dayofweek)
		{
			return null;
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x4C156E0", Offset = "0x4C142E0", VA = "0x184C156E0")]
		private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString)
		{
			return null;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D6")]
		[Address(RVA = "0x4C15100", Offset = "0x4C13D00", VA = "0x184C15100")]
		public string[] GetAllDateTimePatterns(char format)
		{
			return null;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D7")]
		[Address(RVA = "0x4C15850", Offset = "0x4C14450", VA = "0x184C15850")]
		public string GetDayName(System.DayOfWeek dayofweek)
		{
			return null;
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D8")]
		[Address(RVA = "0x4C14FE0", Offset = "0x4C13BE0", VA = "0x184C14FE0")]
		public string GetAbbreviatedMonthName(int month)
		{
			return null;
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028D9")]
		[Address(RVA = "0x4C16190", Offset = "0x4C14D90", VA = "0x184C16190")]
		public string GetMonthName(int month)
		{
			return null;
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028DA")]
		[Address(RVA = "0x4C15F60", Offset = "0x4C14B60", VA = "0x184C15F60")]
		private static string[] GetMergedPatterns(string[] patterns, string defaultPattern)
		{
			return null;
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060028DB RID: 10459 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000600")]
		private string[] AllYearMonthPatterns
		{
			[Token(Token = "0x60028DB")]
			[Address(RVA = "0x4C19A70", Offset = "0x4C18670", VA = "0x184C19A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x060028DC RID: 10460 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000601")]
		private string[] AllShortDatePatterns
		{
			[Token(Token = "0x60028DC")]
			[Address(RVA = "0x4C19910", Offset = "0x4C18510", VA = "0x184C19910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x060028DD RID: 10461 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000602")]
		private string[] AllShortTimePatterns
		{
			[Token(Token = "0x60028DD")]
			[Address(RVA = "0x4C199D0", Offset = "0x4C185D0", VA = "0x184C199D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x060028DE RID: 10462 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000603")]
		private string[] AllLongDatePatterns
		{
			[Token(Token = "0x60028DE")]
			[Address(RVA = "0x4C197B0", Offset = "0x4C183B0", VA = "0x184C197B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x060028DF RID: 10463 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000604")]
		private string[] AllLongTimePatterns
		{
			[Token(Token = "0x60028DF")]
			[Address(RVA = "0x4C19870", Offset = "0x4C18470", VA = "0x184C19870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060028E0 RID: 10464 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000605")]
		private string[] UnclonedYearMonthPatterns
		{
			[Token(Token = "0x60028E0")]
			[Address(RVA = "0x4C1B090", Offset = "0x4C19C90", VA = "0x184C1B090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000606")]
		private string[] UnclonedShortDatePatterns
		{
			[Token(Token = "0x60028E1")]
			[Address(RVA = "0x4C1AFC0", Offset = "0x4C19BC0", VA = "0x184C1AFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060028E2 RID: 10466 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000607")]
		private string[] UnclonedLongDatePatterns
		{
			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x4C1AEF0", Offset = "0x4C19AF0", VA = "0x184C1AEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000608")]
		private string[] UnclonedShortTimePatterns
		{
			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x4C1B050", Offset = "0x4C19C50", VA = "0x184C1B050")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060028E4 RID: 10468 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000609")]
		private string[] UnclonedLongTimePatterns
		{
			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x4C1AF80", Offset = "0x4C19B80", VA = "0x184C1AF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x4C183E0", Offset = "0x4C16FE0", VA = "0x184C183E0")]
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			return null;
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000166C8 File Offset: 0x000148C8
		[Token(Token = "0x1700060A")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x4C1A950", Offset = "0x4C19550", VA = "0x184C1A950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700060B")]
		public string[] MonthGenitiveNames
		{
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x4C1AB80", Offset = "0x4C19780", VA = "0x184C1AB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700060C")]
		internal string FullTimeSpanPositivePattern
		{
			[Token(Token = "0x60028E8")]
			[Address(RVA = "0x4C1A510", Offset = "0x4C19110", VA = "0x184C1A510")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700060D")]
		internal string FullTimeSpanNegativePattern
		{
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x4C1A3D0", Offset = "0x4C18FD0", VA = "0x184C1A3D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700060E")]
		internal CompareInfo CompareInfo
		{
			[Token(Token = "0x60028EA")]
			[Address(RVA = "0x4C19B30", Offset = "0x4C18730", VA = "0x184C19B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x4C18EA0", Offset = "0x4C17AA0", VA = "0x184C18EA0")]
		internal static void ValidateStyles(DateTimeStyles style, string parameterName)
		{
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x000166E0 File Offset: 0x000148E0
		[Token(Token = "0x1700060F")]
		internal DateTimeFormatFlags FormatFlags
		{
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x4C1A2E0", Offset = "0x4C18EE0", VA = "0x184C1A2E0")]
			get
			{
				return DateTimeFormatFlags.None;
			}
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x000166F8 File Offset: 0x000148F8
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x4C16480", Offset = "0x4C15080", VA = "0x184C16480")]
		[MethodImpl(8)]
		private DateTimeFormatFlags InitializeFormatFlags()
		{
			return DateTimeFormatFlags.None;
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060028EE RID: 10478 RVA: 0x00016710 File Offset: 0x00014910
		[Token(Token = "0x17000610")]
		internal bool HasForceTwoDigitYears
		{
			[Token(Token = "0x60028EE")]
			[Address(RVA = "0x4C1A790", Offset = "0x4C19390", VA = "0x184C1A790")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00016728 File Offset: 0x00014928
		[Token(Token = "0x17000611")]
		internal bool HasYearMonthAdjustment
		{
			[Token(Token = "0x60028EF")]
			[Address(RVA = "0x4C1A820", Offset = "0x4C19420", VA = "0x184C1A820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00016740 File Offset: 0x00014940
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x4C18FE0", Offset = "0x4C17BE0", VA = "0x184C18FE0")]
		internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName)
		{
			return default(bool);
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x4C15D90", Offset = "0x4C14990", VA = "0x184C15D90")]
		internal static DateTimeFormatInfo GetJapaneseCalendarDTFI()
		{
			return null;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x4C162B0", Offset = "0x4C14EB0", VA = "0x184C162B0")]
		internal static DateTimeFormatInfo GetTaiwanCalendarDTFI()
		{
			return null;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x4C13EF0", Offset = "0x4C12AF0", VA = "0x184C13EF0")]
		private void ClearTokenHashTable()
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x4C14210", Offset = "0x4C12E10", VA = "0x184C14210")]
		internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable()
		{
			return null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x4C17410", Offset = "0x4C16010", VA = "0x184C17410")]
		private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol)
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00016758 File Offset: 0x00014958
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x4C172D0", Offset = "0x4C15ED0", VA = "0x184C172D0")]
		private static bool IsJapaneseCalendar(Calendar calendar)
		{
			return default(bool);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x4C13E20", Offset = "0x4C12A20", VA = "0x184C13E20")]
		private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix)
		{
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00016770 File Offset: 0x00014970
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x4C18D40", Offset = "0x4C17940", VA = "0x184C18D40")]
		private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number)
		{
			return default(bool);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00016788 File Offset: 0x00014988
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x4C172B0", Offset = "0x4C15EB0", VA = "0x184C172B0")]
		private static bool IsHebrewChar(char ch)
		{
			return default(bool);
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000167A0 File Offset: 0x000149A0
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x4C17190", Offset = "0x4C15D90", VA = "0x184C17190")]
		[MethodImpl(256)]
		private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh)
		{
			return default(bool);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000167B8 File Offset: 0x000149B8
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x4C18510", Offset = "0x4C17110", VA = "0x184C18510")]
		internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str)
		{
			return default(bool);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x4C16B50", Offset = "0x4C15750", VA = "0x184C16B50")]
		private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe)
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x4C16D70", Offset = "0x4C15970", VA = "0x184C16D70")]
		private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue)
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000167D0 File Offset: 0x000149D0
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x4C140F0", Offset = "0x4C12CF0", VA = "0x184C140F0")]
		private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2)
		{
			return default(bool);
		}

		// Token: 0x040016C0 RID: 5824
		[Token(Token = "0x40016C0")]
		[FieldOffset(Offset = "0x0")]
		private static DateTimeFormatInfo s_invariantInfo;

		// Token: 0x040016C1 RID: 5825
		[Token(Token = "0x40016C1")]
		[FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		private CultureData _cultureData;

		// Token: 0x040016C2 RID: 5826
		[Token(Token = "0x40016C2")]
		[FieldOffset(Offset = "0x18")]
		private string _name;

		// Token: 0x040016C3 RID: 5827
		[Token(Token = "0x40016C3")]
		[FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private string _langName;

		// Token: 0x040016C4 RID: 5828
		[Token(Token = "0x40016C4")]
		[FieldOffset(Offset = "0x28")]
		[System.NonSerialized]
		private CompareInfo _compareInfo;

		// Token: 0x040016C5 RID: 5829
		[Token(Token = "0x40016C5")]
		[FieldOffset(Offset = "0x30")]
		[System.NonSerialized]
		private CultureInfo _cultureInfo;

		// Token: 0x040016C6 RID: 5830
		[Token(Token = "0x40016C6")]
		[FieldOffset(Offset = "0x38")]
		private string amDesignator;

		// Token: 0x040016C7 RID: 5831
		[Token(Token = "0x40016C7")]
		[FieldOffset(Offset = "0x40")]
		private string pmDesignator;

		// Token: 0x040016C8 RID: 5832
		[Token(Token = "0x40016C8")]
		[FieldOffset(Offset = "0x48")]
		private string dateSeparator;

		// Token: 0x040016C9 RID: 5833
		[Token(Token = "0x40016C9")]
		[FieldOffset(Offset = "0x50")]
		private string generalShortTimePattern;

		// Token: 0x040016CA RID: 5834
		[Token(Token = "0x40016CA")]
		[FieldOffset(Offset = "0x58")]
		private string generalLongTimePattern;

		// Token: 0x040016CB RID: 5835
		[Token(Token = "0x40016CB")]
		[FieldOffset(Offset = "0x60")]
		private string timeSeparator;

		// Token: 0x040016CC RID: 5836
		[Token(Token = "0x40016CC")]
		[FieldOffset(Offset = "0x68")]
		private string monthDayPattern;

		// Token: 0x040016CD RID: 5837
		[Token(Token = "0x40016CD")]
		[FieldOffset(Offset = "0x70")]
		private string dateTimeOffsetPattern;

		// Token: 0x040016CE RID: 5838
		[Token(Token = "0x40016CE")]
		private const string rfc1123Pattern = "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'";

		// Token: 0x040016CF RID: 5839
		[Token(Token = "0x40016CF")]
		private const string sortableDateTimePattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss";

		// Token: 0x040016D0 RID: 5840
		[Token(Token = "0x40016D0")]
		private const string universalSortableDateTimePattern = "yyyy'-'MM'-'dd HH':'mm':'ss'Z'";

		// Token: 0x040016D1 RID: 5841
		[Token(Token = "0x40016D1")]
		[FieldOffset(Offset = "0x78")]
		private Calendar calendar;

		// Token: 0x040016D2 RID: 5842
		[Token(Token = "0x40016D2")]
		[FieldOffset(Offset = "0x80")]
		private int firstDayOfWeek;

		// Token: 0x040016D3 RID: 5843
		[Token(Token = "0x40016D3")]
		[FieldOffset(Offset = "0x84")]
		private int calendarWeekRule;

		// Token: 0x040016D4 RID: 5844
		[Token(Token = "0x40016D4")]
		[FieldOffset(Offset = "0x88")]
		private string fullDateTimePattern;

		// Token: 0x040016D5 RID: 5845
		[Token(Token = "0x40016D5")]
		[FieldOffset(Offset = "0x90")]
		private string[] abbreviatedDayNames;

		// Token: 0x040016D6 RID: 5846
		[Token(Token = "0x40016D6")]
		[FieldOffset(Offset = "0x98")]
		private string[] m_superShortDayNames;

		// Token: 0x040016D7 RID: 5847
		[Token(Token = "0x40016D7")]
		[FieldOffset(Offset = "0xA0")]
		private string[] dayNames;

		// Token: 0x040016D8 RID: 5848
		[Token(Token = "0x40016D8")]
		[FieldOffset(Offset = "0xA8")]
		private string[] abbreviatedMonthNames;

		// Token: 0x040016D9 RID: 5849
		[Token(Token = "0x40016D9")]
		[FieldOffset(Offset = "0xB0")]
		private string[] monthNames;

		// Token: 0x040016DA RID: 5850
		[Token(Token = "0x40016DA")]
		[FieldOffset(Offset = "0xB8")]
		private string[] genitiveMonthNames;

		// Token: 0x040016DB RID: 5851
		[Token(Token = "0x40016DB")]
		[FieldOffset(Offset = "0xC0")]
		private string[] m_genitiveAbbreviatedMonthNames;

		// Token: 0x040016DC RID: 5852
		[Token(Token = "0x40016DC")]
		[FieldOffset(Offset = "0xC8")]
		private string[] leapYearMonthNames;

		// Token: 0x040016DD RID: 5853
		[Token(Token = "0x40016DD")]
		[FieldOffset(Offset = "0xD0")]
		private string longDatePattern;

		// Token: 0x040016DE RID: 5854
		[Token(Token = "0x40016DE")]
		[FieldOffset(Offset = "0xD8")]
		private string shortDatePattern;

		// Token: 0x040016DF RID: 5855
		[Token(Token = "0x40016DF")]
		[FieldOffset(Offset = "0xE0")]
		private string yearMonthPattern;

		// Token: 0x040016E0 RID: 5856
		[Token(Token = "0x40016E0")]
		[FieldOffset(Offset = "0xE8")]
		private string longTimePattern;

		// Token: 0x040016E1 RID: 5857
		[Token(Token = "0x40016E1")]
		[FieldOffset(Offset = "0xF0")]
		private string shortTimePattern;

		// Token: 0x040016E2 RID: 5858
		[Token(Token = "0x40016E2")]
		[FieldOffset(Offset = "0xF8")]
		private string[] allYearMonthPatterns;

		// Token: 0x040016E3 RID: 5859
		[Token(Token = "0x40016E3")]
		[FieldOffset(Offset = "0x100")]
		private string[] allShortDatePatterns;

		// Token: 0x040016E4 RID: 5860
		[Token(Token = "0x40016E4")]
		[FieldOffset(Offset = "0x108")]
		private string[] allLongDatePatterns;

		// Token: 0x040016E5 RID: 5861
		[Token(Token = "0x40016E5")]
		[FieldOffset(Offset = "0x110")]
		private string[] allShortTimePatterns;

		// Token: 0x040016E6 RID: 5862
		[Token(Token = "0x40016E6")]
		[FieldOffset(Offset = "0x118")]
		private string[] allLongTimePatterns;

		// Token: 0x040016E7 RID: 5863
		[Token(Token = "0x40016E7")]
		[FieldOffset(Offset = "0x120")]
		private string[] m_eraNames;

		// Token: 0x040016E8 RID: 5864
		[Token(Token = "0x40016E8")]
		[FieldOffset(Offset = "0x128")]
		private string[] m_abbrevEraNames;

		// Token: 0x040016E9 RID: 5865
		[Token(Token = "0x40016E9")]
		[FieldOffset(Offset = "0x130")]
		private string[] m_abbrevEnglishEraNames;

		// Token: 0x040016EA RID: 5866
		[Token(Token = "0x40016EA")]
		[FieldOffset(Offset = "0x138")]
		private CalendarId[] optionalCalendars;

		// Token: 0x040016EB RID: 5867
		[Token(Token = "0x40016EB")]
		private const int DEFAULT_ALL_DATETIMES_SIZE = 132;

		// Token: 0x040016EC RID: 5868
		[Token(Token = "0x40016EC")]
		[FieldOffset(Offset = "0x140")]
		internal bool _isReadOnly;

		// Token: 0x040016ED RID: 5869
		[Token(Token = "0x40016ED")]
		[FieldOffset(Offset = "0x144")]
		private DateTimeFormatFlags formatFlags;

		// Token: 0x040016EE RID: 5870
		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] s_monthSpaces;

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		internal const string RoundtripFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		internal const string RoundtripDateTimeUnfixed = "yyyy'-'MM'-'ddTHH':'mm':'ss zzz";

		// Token: 0x040016F1 RID: 5873
		[Token(Token = "0x40016F1")]
		[FieldOffset(Offset = "0x148")]
		private string _fullTimeSpanPositivePattern;

		// Token: 0x040016F2 RID: 5874
		[Token(Token = "0x40016F2")]
		[FieldOffset(Offset = "0x150")]
		private string _fullTimeSpanNegativePattern;

		// Token: 0x040016F3 RID: 5875
		[Token(Token = "0x40016F3")]
		internal const DateTimeStyles InvalidDateTimeStyles = ~(DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.NoCurrentDateDefault | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal | DateTimeStyles.AssumeUniversal | DateTimeStyles.RoundtripKind);

		// Token: 0x040016F4 RID: 5876
		[Token(Token = "0x40016F4")]
		[FieldOffset(Offset = "0x158")]
		[System.NonSerialized]
		private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash;

		// Token: 0x040016F5 RID: 5877
		[Token(Token = "0x40016F5")]
		private const int TOKEN_HASH_SIZE = 199;

		// Token: 0x040016F6 RID: 5878
		[Token(Token = "0x40016F6")]
		private const int SECOND_PRIME = 197;

		// Token: 0x040016F7 RID: 5879
		[Token(Token = "0x40016F7")]
		private const string dateSeparatorOrTimeZoneOffset = "-";

		// Token: 0x040016F8 RID: 5880
		[Token(Token = "0x40016F8")]
		private const string invariantDateSeparator = "/";

		// Token: 0x040016F9 RID: 5881
		[Token(Token = "0x40016F9")]
		private const string invariantTimeSeparator = ":";

		// Token: 0x040016FA RID: 5882
		[Token(Token = "0x40016FA")]
		internal const string IgnorablePeriod = ".";

		// Token: 0x040016FB RID: 5883
		[Token(Token = "0x40016FB")]
		internal const string IgnorableComma = ",";

		// Token: 0x040016FC RID: 5884
		[Token(Token = "0x40016FC")]
		internal const string CJKYearSuff = "年";

		// Token: 0x040016FD RID: 5885
		[Token(Token = "0x40016FD")]
		internal const string CJKMonthSuff = "月";

		// Token: 0x040016FE RID: 5886
		[Token(Token = "0x40016FE")]
		internal const string CJKDaySuff = "日";

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		internal const string KoreanYearSuff = "년";

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		internal const string KoreanMonthSuff = "월";

		// Token: 0x04001701 RID: 5889
		[Token(Token = "0x4001701")]
		internal const string KoreanDaySuff = "일";

		// Token: 0x04001702 RID: 5890
		[Token(Token = "0x4001702")]
		internal const string KoreanHourSuff = "시";

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		internal const string KoreanMinuteSuff = "분";

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		internal const string KoreanSecondSuff = "초";

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		internal const string CJKHourSuff = "時";

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		internal const string ChineseHourSuff = "时";

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		internal const string CJKMinuteSuff = "分";

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		internal const string CJKSecondSuff = "秒";

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		internal const string JapaneseEraStart = "元";

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		internal const string LocalTimeMark = "T";

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		internal const string GMTName = "GMT";

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		internal const string ZuluName = "Z";

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		internal const string KoreanLangName = "ko";

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		internal const string JapaneseLangName = "ja";

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		internal const string EnglishLangName = "en";

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0x10")]
		private static DateTimeFormatInfo s_jajpDTFI;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x18")]
		private static DateTimeFormatInfo s_zhtwDTFI;

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		internal class TokenHashValue
		{
			// Token: 0x06002900 RID: 10496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002900")]
			[Address(RVA = "0x16EA240", Offset = "0x16E8E40", VA = "0x1816EA240")]
			internal TokenHashValue(string tokenString, TokenType tokenType, int tokenValue)
			{
			}

			// Token: 0x04001712 RID: 5906
			[Token(Token = "0x4001712")]
			[FieldOffset(Offset = "0x10")]
			internal string tokenString;

			// Token: 0x04001713 RID: 5907
			[Token(Token = "0x4001713")]
			[FieldOffset(Offset = "0x18")]
			internal TokenType tokenType;

			// Token: 0x04001714 RID: 5908
			[Token(Token = "0x4001714")]
			[FieldOffset(Offset = "0x1C")]
			internal int tokenValue;
		}
	}
}
