using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	internal static class ParameterizedStrings
	{
		// Token: 0x0600108A RID: 4234 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x4D3C770", Offset = "0x4D3B370", VA = "0x184D3C770")]
		public static string Evaluate(string format, params ParameterizedStrings.FormatParam[] args)
		{
			return null;
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x4D3BA70", Offset = "0x4D3A670", VA = "0x184D3BA70")]
		private static string EvaluateInternal(string format, ref int pos, ParameterizedStrings.FormatParam[] args, ParameterizedStrings.LowLevelStack stack, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars)
		{
			return null;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x4CAE690", Offset = "0x4CAD290", VA = "0x184CAE690")]
		private static bool AsBool(int i)
		{
			return default(bool);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x4CB08D0", Offset = "0x4CAF4D0", VA = "0x184CB08D0")]
		private static int AsInt(bool b)
		{
			return 0;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x4D3CD60", Offset = "0x4D3B960", VA = "0x184D3CD60")]
		private static string StringFromAsciiBytes(byte[] buffer, int offset, int length)
		{
			return null;
		}

		// Token: 0x0600108F RID: 4239
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x4D3CE40", Offset = "0x4D3BA40", VA = "0x184D3CE40")]
		[System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int snprintf(byte* str, System.IntPtr size, string format, string arg1);

		// Token: 0x06001090 RID: 4240
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x4D3CF20", Offset = "0x4D3BB20", VA = "0x184D3CF20")]
		[System.Runtime.InteropServices.PreserveSig]
		private unsafe static extern int snprintf(byte* str, System.IntPtr size, string format, int arg1);

		// Token: 0x06001091 RID: 4241 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x4D3C970", Offset = "0x4D3B570", VA = "0x184D3C970")]
		private static string FormatPrintF(string format, object arg)
		{
			return null;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x4D3CC50", Offset = "0x4D3B850", VA = "0x184D3CC50")]
		private static ParameterizedStrings.FormatParam[] GetDynamicOrStaticVariables(char c, ref ParameterizedStrings.FormatParam[] dynamicVars, ref ParameterizedStrings.FormatParam[] staticVars, out int index)
		{
			return null;
		}

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[System.ThreadStatic]
		private static ParameterizedStrings.LowLevelStack _cachedStack;

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x20001C2")]
		public struct FormatParam
		{
			// Token: 0x06001093 RID: 4243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x4D362C0", Offset = "0x4D34EC0", VA = "0x184D362C0")]
			public FormatParam(int value)
			{
			}

			// Token: 0x06001094 RID: 4244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001094")]
			[Address(RVA = "0x5159D0", Offset = "0x5145D0", VA = "0x1805159D0")]
			private FormatParam(int intValue, string stringValue)
			{
			}

			// Token: 0x06001095 RID: 4245 RVA: 0x0000D830 File Offset: 0x0000BA30
			[Token(Token = "0x6001095")]
			[Address(RVA = "0x4D36380", Offset = "0x4D34F80", VA = "0x184D36380")]
			public static implicit operator ParameterizedStrings.FormatParam(int value)
			{
				return default(ParameterizedStrings.FormatParam);
			}

			// Token: 0x1700017B RID: 379
			// (get) Token: 0x06001096 RID: 4246 RVA: 0x0000D848 File Offset: 0x0000BA48
			[Token(Token = "0x1700017B")]
			public int Int32
			{
				[Token(Token = "0x6001096")]
				[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700017C RID: 380
			// (get) Token: 0x06001097 RID: 4247 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700017C")]
			public string String
			{
				[Token(Token = "0x6001097")]
				[Address(RVA = "0x4D36330", Offset = "0x4D34F30", VA = "0x184D36330")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06001098 RID: 4248 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700017D")]
			public object Object
			{
				[Token(Token = "0x6001098")]
				[Address(RVA = "0x4D362E0", Offset = "0x4D34EE0", VA = "0x184D362E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x040007B3 RID: 1971
			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly int _int32;

			// Token: 0x040007B4 RID: 1972
			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly string _string;
		}

		// Token: 0x020001C3 RID: 451
		[Token(Token = "0x20001C3")]
		private sealed class LowLevelStack
		{
			// Token: 0x06001099 RID: 4249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001099")]
			[Address(RVA = "0x4D368F0", Offset = "0x4D354F0", VA = "0x184D368F0")]
			public LowLevelStack()
			{
			}

			// Token: 0x0600109A RID: 4250 RVA: 0x0000D860 File Offset: 0x0000BA60
			[Token(Token = "0x600109A")]
			[Address(RVA = "0x4D36720", Offset = "0x4D35320", VA = "0x184D36720")]
			public ParameterizedStrings.FormatParam Pop()
			{
				return default(ParameterizedStrings.FormatParam);
			}

			// Token: 0x0600109B RID: 4251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x4D367F0", Offset = "0x4D353F0", VA = "0x184D367F0")]
			public void Push(ParameterizedStrings.FormatParam item)
			{
			}

			// Token: 0x0600109C RID: 4252 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600109C")]
			[Address(RVA = "0x4D366F0", Offset = "0x4D352F0", VA = "0x184D366F0")]
			public void Clear()
			{
			}

			// Token: 0x040007B5 RID: 1973
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ParameterizedStrings.FormatParam[] _arr;

			// Token: 0x040007B6 RID: 1974
			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int _count;
		}
	}
}
