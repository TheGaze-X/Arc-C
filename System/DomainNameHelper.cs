using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	internal class DomainNameHelper
	{
		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x50E8500", Offset = "0x50E7100", VA = "0x1850E8500")]
		internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback)
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x50E8380", Offset = "0x50E6F80", VA = "0x1850E8380")]
		internal unsafe static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			return default(bool);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x50E8160", Offset = "0x50E6D60", VA = "0x1850E8160")]
		internal unsafe static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile)
		{
			return default(bool);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x50E7CA0", Offset = "0x50E68A0", VA = "0x1850E7CA0")]
		internal unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			return null;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x50E7EF0", Offset = "0x50E6AF0", VA = "0x1850E7EF0")]
		internal unsafe static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost)
		{
			return null;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x50E80B0", Offset = "0x50E6CB0", VA = "0x1850E80B0")]
		private static bool IsIdnAce(string input, int index)
		{
			return default(bool);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x50E8130", Offset = "0x50E6D30", VA = "0x1850E8130")]
		private unsafe static bool IsIdnAce(char* input, int index)
		{
			return default(bool);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x50E8680", Offset = "0x50E7280", VA = "0x1850E8680")]
		internal unsafe static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end)
		{
			return null;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x50E8740", Offset = "0x50E7340", VA = "0x1850E8740")]
		internal unsafe static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn)
		{
			return null;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x50E8080", Offset = "0x50E6C80", VA = "0x1850E8080")]
		private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical)
		{
			return default(bool);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x50E8340", Offset = "0x50E6F40", VA = "0x1850E8340")]
		private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical)
		{
			return default(bool);
		}
	}
}
