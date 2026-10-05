using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	internal class Normalization
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x4B13810", Offset = "0x4B12410", VA = "0x184B13810")]
		private static uint PropValue(int cp)
		{
			return 0U;
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x4B11D80", Offset = "0x4B10980", VA = "0x184B11D80")]
		private static int CharMapIdx(int cp)
		{
			return 0;
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x4B13490", Offset = "0x4B12090", VA = "0x184B13490")]
		private static byte GetCombiningClass(int c)
		{
			return 0;
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x4B13540", Offset = "0x4B12140", VA = "0x184B13540")]
		private static int GetPrimaryCompositeFromMapIndex(int src)
		{
			return 0;
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x4B135F0", Offset = "0x4B121F0", VA = "0x184B135F0")]
		private static int GetPrimaryCompositeHelperIndex(int cp)
		{
			return 0;
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x4B12360", Offset = "0x4B10F60", VA = "0x184B12360")]
		private static string Compose(string source, int checkType)
		{
			return null;
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x4B12000", Offset = "0x4B10C00", VA = "0x184B12000")]
		private static StringBuilder Combine(string source, int start, int checkType)
		{
			return null;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x4B12130", Offset = "0x4B10D30", VA = "0x184B12130")]
		private static void Combine(StringBuilder sb, int i, int checkType)
		{
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x4B11E10", Offset = "0x4B10A10", VA = "0x184B11E10")]
		private static int CombineHangul(StringBuilder sb, string s, int current)
		{
			return 0;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x6001765")]
		[Address(RVA = "0x4B13000", Offset = "0x4B11C00", VA = "0x184B13000")]
		private static int Fetch(StringBuilder sb, string s, int i)
		{
			return 0;
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6001766")]
		[Address(RVA = "0x4B13C70", Offset = "0x4B12870", VA = "0x184B13C70")]
		private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
		{
			return 0;
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6001767")]
		[Address(RVA = "0x4B13FF0", Offset = "0x4B12BF0", VA = "0x184B13FF0")]
		private static int TryCompose(int i, int starter, int candidate)
		{
			return 0;
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001768")]
		[Address(RVA = "0x4B12770", Offset = "0x4B11370", VA = "0x184B12770")]
		private static string Decompose(string source, int checkType)
		{
			return null;
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001769")]
		[Address(RVA = "0x4B12D10", Offset = "0x4B11910", VA = "0x184B12D10")]
		private static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176A")]
		[Address(RVA = "0x4B139D0", Offset = "0x4B125D0", VA = "0x184B139D0")]
		private static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600176B")]
		[Address(RVA = "0x4B12550", Offset = "0x4B11150", VA = "0x184B12550")]
		private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start)
		{
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x600176C")]
		[Address(RVA = "0x4B138A0", Offset = "0x4B124A0", VA = "0x184B138A0")]
		public static NormalizationCheck QuickCheck(char c, int type)
		{
			return NormalizationCheck.Yes;
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x600176D")]
		[Address(RVA = "0x4B13050", Offset = "0x4B11C50", VA = "0x184B13050")]
		private static int GetCanonicalHangul(int s, int[] buf, int bufIdx)
		{
			return 0;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00011070 File Offset: 0x0000F270
		[Token(Token = "0x600176E")]
		[Address(RVA = "0x4B13160", Offset = "0x4B11D60", VA = "0x184B13160")]
		private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType)
		{
			return 0;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600176F")]
		[Address(RVA = "0x4B136A0", Offset = "0x4B122A0", VA = "0x184B136A0")]
		public static string Normalize(string source, NormalizationForm normalizationForm)
		{
			return null;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x4B13770", Offset = "0x4B12370", VA = "0x184B13770")]
		public static string Normalize(string source, int type)
		{
			return null;
		}

		// Token: 0x06001771 RID: 6001
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x4B143B0", Offset = "0x4B12FB0", VA = "0x184B143B0")]
		[MethodImpl(4096)]
		private static extern void load_normalization_resource(out System.IntPtr props, out System.IntPtr mappedChars, out System.IntPtr charMapIndex, out System.IntPtr helperIndex, out System.IntPtr mapIdxToComposite, out System.IntPtr combiningClass);

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x0")]
		private unsafe static byte* props;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x8")]
		private unsafe static int* mappedChars;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x10")]
		private unsafe static short* charMapIndex;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x18")]
		private unsafe static short* helperIndex;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x20")]
		private unsafe static ushort* mapIdxToComposite;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x28")]
		private unsafe static byte* combiningClass;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x30")]
		private static object forLock;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x38")]
		public static readonly bool isReady;
	}
}
