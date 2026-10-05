using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000F3 RID: 243
	[Token(Token = "0x20000F3")]
	internal sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x06000594 RID: 1428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x50FEA70", Offset = "0x50FD670", VA = "0x1850FEA70")]
		public RegexInterpreter(RegexCode code, CultureInfo culture)
		{
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x50FE0E0", Offset = "0x50FCCE0", VA = "0x1850FE0E0", Slot = "6")]
		protected override void InitTrackCount()
		{
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x50FB710", Offset = "0x50FA310", VA = "0x1850FB710")]
		private void Advance(int i)
		{
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x50FE050", Offset = "0x50FCC50", VA = "0x1850FE050")]
		private void Goto(int newpos)
		{
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
		private void Textto(int newpos)
		{
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x50FEA50", Offset = "0x50FD650", VA = "0x1850FEA50")]
		private void Trackto(int newpos)
		{
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
		private int Textstart()
		{
			return 0;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
		private int Textpos()
		{
			return 0;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x50FEA30", Offset = "0x50FD630", VA = "0x1850FEA30")]
		private int Trackpos()
		{
			return 0;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x50FE9F0", Offset = "0x50FD5F0", VA = "0x1850FE9F0")]
		private void TrackPush()
		{
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x50FE980", Offset = "0x50FD580", VA = "0x1850FE980")]
		private void TrackPush(int I1)
		{
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x50FE8F0", Offset = "0x50FD4F0", VA = "0x1850FE8F0")]
		private void TrackPush(int I1, int I2)
		{
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x50FE840", Offset = "0x50FD440", VA = "0x1850FE840")]
		private void TrackPush(int I1, int I2, int I3)
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x50FE7D0", Offset = "0x50FD3D0", VA = "0x1850FE7D0")]
		private void TrackPush2(int I1)
		{
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x50FE740", Offset = "0x50FD340", VA = "0x1850FE740")]
		private void TrackPush2(int I1, int I2)
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x50FB790", Offset = "0x50FA390", VA = "0x1850FB790")]
		private void Backtrack()
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x50FE3B0", Offset = "0x50FCFB0", VA = "0x1850FE3B0")]
		private void SetOperator(int op)
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x50FE720", Offset = "0x50FD320", VA = "0x1850FE720")]
		private void TrackPop()
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x50FE730", Offset = "0x50FD330", VA = "0x1850FE730")]
		private void TrackPop(int framesize)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x50FE6F0", Offset = "0x50FD2F0", VA = "0x1850FE6F0")]
		private int TrackPeek()
		{
			return 0;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x50FE6B0", Offset = "0x50FD2B0", VA = "0x1850FE6B0")]
		private int TrackPeek(int i)
		{
			return 0;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x50FE4D0", Offset = "0x50FD0D0", VA = "0x1850FE4D0")]
		private void StackPush(int I1)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x50FE470", Offset = "0x50FD070", VA = "0x1850FE470")]
		private void StackPush(int I1, int I2)
		{
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x50FE450", Offset = "0x50FD050", VA = "0x1850FE450")]
		private void StackPop()
		{
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x50FE460", Offset = "0x50FD060", VA = "0x1850FE460")]
		private void StackPop(int framesize)
		{
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x50FE3E0", Offset = "0x50FCFE0", VA = "0x1850FE3E0")]
		private int StackPeek()
		{
			return 0;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x50FE410", Offset = "0x50FD010", VA = "0x1850FE410")]
		private int StackPeek(int i)
		{
			return 0;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
		private int Operator()
		{
			return 0;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x50FE120", Offset = "0x50FCD20", VA = "0x1850FE120")]
		private int Operand(int i)
		{
			return 0;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x50FE110", Offset = "0x50FCD10", VA = "0x1850FE110")]
		private int Leftchars()
		{
			return 0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x50FE3A0", Offset = "0x50FCFA0", VA = "0x1850FE3A0")]
		private int Rightchars()
		{
			return 0;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x50FB890", Offset = "0x50FA490", VA = "0x1850FB890")]
		private int Bump()
		{
			return 0;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x50FBEC0", Offset = "0x50FAAC0", VA = "0x1850FBEC0")]
		private int Forwardchars()
		{
			return 0;
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x50FBE00", Offset = "0x50FAA00", VA = "0x1850FBE00")]
		private char Forwardcharnext()
		{
			return '\0';
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x50FE510", Offset = "0x50FD110", VA = "0x1850FE510")]
		private bool Stringmatch(string str)
		{
			return default(bool);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x50FE170", Offset = "0x50FCD70", VA = "0x1850FE170")]
		private bool Refmatch(int index, int len)
		{
			return default(bool);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x50FB870", Offset = "0x50FA470", VA = "0x1850FB870")]
		private void Backwardnext()
		{
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x50FB8B0", Offset = "0x50FA4B0", VA = "0x1850FB8B0")]
		private char CharAt(int j)
		{
			return '\0';
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x50FB8D0", Offset = "0x50FA4D0", VA = "0x1850FB8D0", Slot = "5")]
		protected override bool FindFirstChar()
		{
			return default(bool);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x50FBEE0", Offset = "0x50FAAE0", VA = "0x1850FBEE0", Slot = "4")]
		protected override void Go()
		{
		}

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x80")]
		private readonly RegexCode _code;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x88")]
		private readonly CultureInfo _culture;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x90")]
		private int _operator;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x94")]
		private int _codepos;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x98")]
		private bool _rightToLeft;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x99")]
		private bool _caseInsensitive;
	}
}
