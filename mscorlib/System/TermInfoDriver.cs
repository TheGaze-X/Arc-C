using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	internal class TermInfoDriver : IConsoleDriver
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x4D440B0", Offset = "0x4D42CB0", VA = "0x184D440B0")]
		private static string TryTermInfoDir(string dir, string term)
		{
			return null;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x4D43CA0", Offset = "0x4D428A0", VA = "0x184D43CA0")]
		private static string SearchTerminfo(string term)
		{
			return null;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x4D441D0", Offset = "0x4D42DD0", VA = "0x184D441D0")]
		private void WriteConsole(string str)
		{
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x4D446C0", Offset = "0x4D432C0", VA = "0x184D446C0")]
		public TermInfoDriver(string term)
		{
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0000D710 File Offset: 0x0000B910
		[Token(Token = "0x17000178")]
		public bool Initialized
		{
			[Token(Token = "0x600106C")]
			[Address(RVA = "0x4D44D80", Offset = "0x4D43980", VA = "0x184D44D80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x4D42670", Offset = "0x4D41270", VA = "0x184D42670", Slot = "6")]
		public void Init()
		{
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106E")]
		[Address(RVA = "0x4D423A0", Offset = "0x4D40FA0", VA = "0x184D423A0")]
		private void IncrementX()
		{
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x4D44250", Offset = "0x4D42E50", VA = "0x184D44250")]
		public void WriteSpecialKey(System.ConsoleKeyInfo key)
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x4D44200", Offset = "0x4D42E00", VA = "0x184D44200")]
		public void WriteSpecialKey(char c)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0000D728 File Offset: 0x0000B928
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x4D43220", Offset = "0x4D41E20", VA = "0x184D43220")]
		public bool IsSpecialKey(System.ConsoleKeyInfo key)
		{
			return default(bool);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0000D740 File Offset: 0x0000B940
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x4D431D0", Offset = "0x4D41DD0", VA = "0x184D431D0")]
		public bool IsSpecialKey(char c)
		{
			return default(bool);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x4D41C00", Offset = "0x4D40800", VA = "0x184D41C00")]
		private void GetCursorPosition()
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x4D3ECA0", Offset = "0x4D3D8A0", VA = "0x184D3ECA0")]
		private void CheckWindowDimensions()
		{
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0000D758 File Offset: 0x0000B958
		[Token(Token = "0x17000179")]
		public int WindowHeight
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x4D44D90", Offset = "0x4D43990", VA = "0x184D44D90", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0000D770 File Offset: 0x0000B970
		[Token(Token = "0x1700017A")]
		public int WindowWidth
		{
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x4D44DC0", Offset = "0x4D439C0", VA = "0x184D44DC0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x4D3EB80", Offset = "0x4D3D780", VA = "0x184D3EB80")]
		private void AddToBuffer(int b)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x4D3EC80", Offset = "0x4D3D880", VA = "0x184D3EC80")]
		private void AdjustBuffer()
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0000D788 File Offset: 0x0000B988
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x4D3EDF0", Offset = "0x4D3D9F0", VA = "0x184D3EDF0")]
		private System.ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x4D41FB0", Offset = "0x4D40BB0", VA = "0x184D41FB0")]
		private object GetKeyFromBuffer(bool cooked)
		{
			return null;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x4D43420", Offset = "0x4D42020", VA = "0x184D43420")]
		private System.ConsoleKeyInfo ReadKeyInternal(out bool fresh)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x4D43190", Offset = "0x4D41D90", VA = "0x184D43190")]
		private bool InputPending()
		{
			return default(bool);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x4D43320", Offset = "0x4D41F20", VA = "0x184D43320")]
		private void QueueEcho(char c)
		{
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x4D41A70", Offset = "0x4D40670", VA = "0x184D41A70")]
		private void Echo(System.ConsoleKeyInfo key)
		{
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x4D41A20", Offset = "0x4D40620", VA = "0x184D41A20")]
		private void EchoFlush()
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x4D43990", Offset = "0x4D42590", VA = "0x184D43990")]
		public int Read([System.Runtime.InteropServices.In] [System.Runtime.InteropServices.Out] char[] dest, int index, int count)
		{
			return 0;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x4D43670", Offset = "0x4D42270", VA = "0x184D43670", Slot = "4")]
		public System.ConsoleKeyInfo ReadKey(bool intercept)
		{
			return default(System.ConsoleKeyInfo);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x4D43720", Offset = "0x4D42320", VA = "0x184D43720", Slot = "9")]
		public string ReadLine()
		{
			return null;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x4D43730", Offset = "0x4D42330", VA = "0x184D43730")]
		public string ReadToEnd()
		{
			return null;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x4D43740", Offset = "0x4D42340", VA = "0x184D43740")]
		private string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			return null;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x4D43E20", Offset = "0x4D42A20", VA = "0x184D43E20", Slot = "10")]
		public void SetCursorPosition(int left, int top)
		{
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x4D3EF30", Offset = "0x4D3DB30", VA = "0x184D3EF30")]
		private void CreateKeyMap()
		{
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x4D42430", Offset = "0x4D41030", VA = "0x184D42430")]
		private void InitKeys()
		{
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x4D3EB30", Offset = "0x4D3D730", VA = "0x184D3EB30")]
		private void AddStringMapping(TermInfoStrings s)
		{
		}

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private unsafe static int* native_terminal_size;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int terminal_size;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly string[] locations;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TermInfoReader reader;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int cursorLeft;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int cursorTop;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string title;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string titleFormat;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool cursorVisible;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string csrVisible;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string csrInvisible;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string clear;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string bell;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string term;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.IO.StreamReader stdin;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CStreamWriter stdout;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int windowWidth;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int windowHeight;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int bufferHeight;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int bufferWidth;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private char[] buffer;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int readpos;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int writepos;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string keypadXmit;

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private string keypadLocal;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool inited;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private object initLock;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool initKeys;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string origPair;

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private string origColors;

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string cursorAddress;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private System.ConsoleColor fgcolor;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private string setfgcolor;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string setbgcolor;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int maxColors;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool noGetPosition;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private System.Collections.Hashtable keymap;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private ByteMatcher rootmap;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int rl_startx;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int rl_starty;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] control_characters;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int[] _consoleColorToAnsiCode;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private char[] echobuf;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int echon;
	}
}
