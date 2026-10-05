using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	internal sealed class RegexParser
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x51101E0", Offset = "0x510EDE0", VA = "0x1851101E0")]
		public static RegexTree Parse(string re, RegexOptions op)
		{
			return null;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x5110040", Offset = "0x510EC40", VA = "0x185110040")]
		public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op)
		{
			return null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x5114730", Offset = "0x5113330", VA = "0x185114730")]
		private RegexParser(CultureInfo culture)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x5114480", Offset = "0x5113080", VA = "0x185114480")]
		private void SetPattern(string Re)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x5110790", Offset = "0x510F390", VA = "0x185110790")]
		private void Reset(RegexOptions topopts)
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x5113A90", Offset = "0x5112690", VA = "0x185113A90")]
		private RegexNode ScanRegex()
		{
			return null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x5114300", Offset = "0x5112F00", VA = "0x185114300")]
		private RegexNode ScanReplacement()
		{
			return null;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x5111960", Offset = "0x5110560", VA = "0x185111960")]
		private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			return null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x5112B80", Offset = "0x5111780", VA = "0x185112B80")]
		private RegexNode ScanGroupOpen()
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x5111510", Offset = "0x5110110", VA = "0x185111510")]
		private void ScanBlank()
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x51108C0", Offset = "0x510F4C0", VA = "0x1851108C0")]
		private RegexNode ScanBackslash(bool scanOnly)
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5110EC0", Offset = "0x510FAC0", VA = "0x185110EC0")]
		private RegexNode ScanBasicBackslash(bool scanOnly)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x5112780", Offset = "0x5111380", VA = "0x185112780")]
		private RegexNode ScanDollar()
		{
			return null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x51118B0", Offset = "0x51104B0", VA = "0x1851118B0")]
		private string ScanCapname()
		{
			return null;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x51138F0", Offset = "0x51124F0", VA = "0x1851138F0")]
		private char ScanOctal()
		{
			return '\0';
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x51126C0", Offset = "0x51112C0", VA = "0x1851126C0")]
		private int ScanDecimal()
		{
			return 0;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x51137D0", Offset = "0x51123D0", VA = "0x1851137D0")]
		private char ScanHex(int c)
		{
			return '\0';
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x510F510", Offset = "0x510E110", VA = "0x18510F510")]
		private static int HexDigit(char ch)
		{
			return 0;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x51125F0", Offset = "0x51111F0", VA = "0x1851125F0")]
		private char ScanControl()
		{
			return '\0';
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x510F660", Offset = "0x510E260", VA = "0x18510F660")]
		private bool IsOnlyTopOption(RegexOptions option)
		{
			return default(bool);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x5113990", Offset = "0x5112590", VA = "0x185113990")]
		private void ScanOptions()
		{
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x5112240", Offset = "0x5110E40", VA = "0x185112240")]
		private char ScanCharEscape()
		{
			return '\0';
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x510FE70", Offset = "0x510EA70", VA = "0x18510FE70")]
		private string ParseProperty()
		{
			return null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x51145C0", Offset = "0x51131C0", VA = "0x1851145C0")]
		private int TypeFromCode(char ch)
		{
			return 0;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x510FDD0", Offset = "0x510E9D0", VA = "0x18510FDD0")]
		private static RegexOptions OptionFromCode(char ch)
		{
			return RegexOptions.None;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x510EFD0", Offset = "0x510DBD0", VA = "0x18510EFD0")]
		private void CountCaptures()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x510FC50", Offset = "0x510E850", VA = "0x18510FC50")]
		private void NoteCaptureSlot(int i, int pos)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x510FAB0", Offset = "0x510E6B0", VA = "0x18510FAB0")]
		private void NoteCaptureName(string name, int pos)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x510FD80", Offset = "0x510E980", VA = "0x18510FD80")]
		private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames)
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x510E7D0", Offset = "0x510D3D0", VA = "0x18510E7D0")]
		private void AssignNameSlots()
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x510EEF0", Offset = "0x510DAF0", VA = "0x18510EEF0")]
		private int CaptureSlotFromName(string capname)
		{
			return 0;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x510F5A0", Offset = "0x510E1A0", VA = "0x18510F5A0")]
		private bool IsCaptureSlot(int i)
		{
			return default(bool);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x510F540", Offset = "0x510E140", VA = "0x18510F540")]
		private bool IsCaptureName(string capname)
		{
			return default(bool);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x5114670", Offset = "0x5113270", VA = "0x185114670")]
		private bool UseOptionN()
		{
			return default(bool);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x5114650", Offset = "0x5113250", VA = "0x185114650")]
		private bool UseOptionI()
		{
			return default(bool);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x5114660", Offset = "0x5113260", VA = "0x185114660")]
		private bool UseOptionM()
		{
			return default(bool);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x5114680", Offset = "0x5113280", VA = "0x185114680")]
		private bool UseOptionS()
		{
			return default(bool);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x5114690", Offset = "0x5113290", VA = "0x185114690")]
		private bool UseOptionX()
		{
			return default(bool);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5114640", Offset = "0x5113240", VA = "0x185114640")]
		private bool UseOptionE()
		{
			return default(bool);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x510F780", Offset = "0x510E380", VA = "0x18510F780")]
		private static bool IsSpecial(char ch)
		{
			return default(bool);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x510F800", Offset = "0x510E400", VA = "0x18510F800")]
		private static bool IsStopperX(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x510F680", Offset = "0x510E280", VA = "0x18510F680")]
		private static bool IsQuantifier(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x510F880", Offset = "0x510E480", VA = "0x18510F880")]
		private bool IsTrueQuantifier()
		{
			return default(bool);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x510F700", Offset = "0x510E300", VA = "0x18510F700")]
		private static bool IsSpace(char ch)
		{
			return default(bool);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x510E080", Offset = "0x510CC80", VA = "0x18510E080")]
		private void AddConcatenate(int pos, int cch, bool isReplacement)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x5110670", Offset = "0x510F270", VA = "0x185110670")]
		private void PushGroup()
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x5110450", Offset = "0x510F050", VA = "0x185110450")]
		private void PopGroup()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x2824A30", Offset = "0x2823630", VA = "0x182824A30")]
		private bool EmptyStack()
		{
			return default(bool);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x51144F0", Offset = "0x51130F0", VA = "0x1851144F0")]
		private void StartGroup(RegexNode openGroup)
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x510DD90", Offset = "0x510C990", VA = "0x18510DD90")]
		private void AddAlternate()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x510E030", Offset = "0x510CC30", VA = "0x18510E030")]
		private void AddConcatenate()
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x510DED0", Offset = "0x510CAD0", VA = "0x18510DED0")]
		private void AddConcatenate(bool lazy, int min, int max)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
		private RegexNode Unit()
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x510E590", Offset = "0x510D190", VA = "0x18510E590")]
		private void AddUnitOne(char ch)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x510E480", Offset = "0x510D080", VA = "0x18510E480")]
		private void AddUnitNotone(char ch)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x510E6A0", Offset = "0x510D2A0", VA = "0x18510E6A0")]
		private void AddUnitSet(string cc)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
		private void AddUnitNode(RegexNode node)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x510E740", Offset = "0x510D340", VA = "0x18510E740")]
		private void AddUnitType(int type)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x510E2D0", Offset = "0x510CED0", VA = "0x18510E2D0")]
		private void AddGroup()
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x51106F0", Offset = "0x510F2F0", VA = "0x1851106F0")]
		private void PushOptions()
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x51105E0", Offset = "0x510F1E0", VA = "0x1851105E0")]
		private void PopOptions()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x510F4C0", Offset = "0x510E0C0", VA = "0x18510F4C0")]
		private bool EmptyOptionsStack()
		{
			return default(bool);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5110580", Offset = "0x510F180", VA = "0x185110580")]
		private void PopKeepOptions()
		{
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x510FA00", Offset = "0x510E600", VA = "0x18510FA00")]
		private ArgumentException MakeException(string message)
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
		private int Textpos()
		{
			return 0;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
		private void Textto(int pos)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5110830", Offset = "0x510F430", VA = "0x185110830")]
		private char RightCharMoveRight()
		{
			return '\0';
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE30710", Offset = "0xE2F310", VA = "0x180E30710")]
		private void MoveRight()
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x510FAA0", Offset = "0x510E6A0", VA = "0x18510FAA0")]
		private void MoveRight(int i)
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x510FA90", Offset = "0x510E690", VA = "0x18510FA90")]
		private void MoveLeft()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x510EF90", Offset = "0x510DB90", VA = "0x18510EF90")]
		private char CharAt(int i)
		{
			return '\0';
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x5110860", Offset = "0x510F460", VA = "0x185110860")]
		internal char RightChar()
		{
			return '\0';
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x5110890", Offset = "0x510F490", VA = "0x185110890")]
		private char RightChar(int i)
		{
			return '\0';
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x510EFB0", Offset = "0x510DBB0", VA = "0x18510EFB0")]
		private int CharsRight()
		{
			return 0;
		}

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x10")]
		private RegexNode _stack;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x18")]
		private RegexNode _group;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x20")]
		private RegexNode _alternation;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x28")]
		private RegexNode _concatenation;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x30")]
		private RegexNode _unit;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x38")]
		private string _pattern;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x40")]
		private int _currentPos;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x48")]
		private CultureInfo _culture;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x50")]
		private int _autocap;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x54")]
		private int _capcount;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x58")]
		private int _captop;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x5C")]
		private int _capsize;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x60")]
		private Hashtable _caps;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x68")]
		private Hashtable _capnames;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x70")]
		private int[] _capnumlist;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x78")]
		private List<string> _capnamelist;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x80")]
		private RegexOptions _options;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x88")]
		private List<RegexOptions> _optionsStack;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x90")]
		private bool _ignoreNextParen;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] s_category;
	}
}
