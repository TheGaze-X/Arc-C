using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	public static class Marshal
	{
		// Token: 0x0600225E RID: 8798
		[Token(Token = "0x600225E")]
		[Address(RVA = "0x4BB5C80", Offset = "0x4BB4880", VA = "0x184BB5C80")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[MethodImpl(4096)]
		public static extern System.IntPtr AllocHGlobal(System.IntPtr cb);

		// Token: 0x0600225F RID: 8799 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x600225F")]
		[Address(RVA = "0x4BB5C90", Offset = "0x4BB4890", VA = "0x184BB5C90")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static System.IntPtr AllocHGlobal(int cb)
		{
			return 0;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x4BB8390", Offset = "0x4BB6F90", VA = "0x184BB8390")]
		internal static void copy_to_unmanaged(System.Array source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002261 RID: 8801
		[Token(Token = "0x6002261")]
		[Address(RVA = "0x4BB8380", Offset = "0x4BB6F80", VA = "0x184BB8380")]
		[MethodImpl(4096)]
		private unsafe static extern void copy_to_unmanaged_fixed(System.Array source, int startIndex, System.IntPtr destination, int length, void* fixed_source_element);

		// Token: 0x06002262 RID: 8802 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x4BB8520", Offset = "0x4BB7120", VA = "0x184BB8520")]
		private static bool skip_fixed(System.Array array, int startIndex)
		{
			return default(bool);
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x4BB8410", Offset = "0x4BB7010", VA = "0x184BB8410")]
		internal static void copy_to_unmanaged(byte[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x4BB5EE0", Offset = "0x4BB4AE0", VA = "0x184BB5EE0")]
		public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x4BB6370", Offset = "0x4BB4F70", VA = "0x184BB6370")]
		public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002266")]
		[Address(RVA = "0x4BB6040", Offset = "0x4BB4C40", VA = "0x184BB6040")]
		public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002267")]
		[Address(RVA = "0x4BB66A0", Offset = "0x4BB52A0", VA = "0x184BB66A0")]
		public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002268")]
		[Address(RVA = "0x4BB6150", Offset = "0x4BB4D50", VA = "0x184BB6150")]
		public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length)
		{
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x4BB8300", Offset = "0x4BB6F00", VA = "0x184BB8300")]
		internal static void copy_from_unmanaged(System.IntPtr source, int startIndex, System.Array destination, int length)
		{
		}

		// Token: 0x0600226A RID: 8810
		[Token(Token = "0x600226A")]
		[Address(RVA = "0x4BB82F0", Offset = "0x4BB6EF0", VA = "0x184BB82F0")]
		[MethodImpl(4096)]
		private unsafe static extern void copy_from_unmanaged_fixed(System.IntPtr source, int startIndex, System.Array destination, int length, void* fixed_destination_element);

		// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226B")]
		[Address(RVA = "0x4BB68C0", Offset = "0x4BB54C0", VA = "0x184BB68C0")]
		public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length)
		{
		}

		// Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226C")]
		[Address(RVA = "0x4BB6480", Offset = "0x4BB5080", VA = "0x184BB6480")]
		public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length)
		{
		}

		// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226D")]
		[Address(RVA = "0x4BB6590", Offset = "0x4BB5190", VA = "0x184BB6590")]
		public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length)
		{
		}

		// Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226E")]
		[Address(RVA = "0x4BB6260", Offset = "0x4BB4E60", VA = "0x184BB6260")]
		public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length)
		{
		}

		// Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600226F")]
		[Address(RVA = "0x4BB67B0", Offset = "0x4BB53B0", VA = "0x184BB67B0")]
		public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length)
		{
		}

		// Token: 0x06002270 RID: 8816
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x4BB69D0", Offset = "0x4BB55D0", VA = "0x184BB69D0")]
		[MethodImpl(4096)]
		public static extern void FreeBSTR(System.IntPtr ptr);

		// Token: 0x06002271 RID: 8817
		[Token(Token = "0x6002271")]
		[Address(RVA = "0x4BB69E0", Offset = "0x4BB55E0", VA = "0x184BB69E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern void FreeHGlobal(System.IntPtr hglobal);

		// Token: 0x06002272 RID: 8818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002272")]
		[Address(RVA = "0x4BB5D00", Offset = "0x4BB4900", VA = "0x184BB5D00")]
		private static void ClearBSTR(System.IntPtr ptr)
		{
		}

		// Token: 0x06002273 RID: 8819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002273")]
		[Address(RVA = "0x4BB7FE0", Offset = "0x4BB6BE0", VA = "0x184BB7FE0")]
		public static void ZeroFreeBSTR(System.IntPtr s)
		{
		}

		// Token: 0x06002274 RID: 8820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002274")]
		[Address(RVA = "0x4BB5DD0", Offset = "0x4BB49D0", VA = "0x184BB5DD0")]
		private static void ClearUnicode(System.IntPtr ptr)
		{
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002275")]
		[Address(RVA = "0x4BB80F0", Offset = "0x4BB6CF0", VA = "0x184BB80F0")]
		public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s)
		{
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x4BB72E0", Offset = "0x4BB5EE0", VA = "0x184BB72E0")]
		public static int GetHRForException(System.Exception e)
		{
			return 0;
		}

		// Token: 0x06002277 RID: 8823
		[Token(Token = "0x6002277")]
		[Address(RVA = "0x4BB7300", Offset = "0x4BB5F00", VA = "0x184BB7300")]
		[MethodImpl(4096)]
		public static extern bool IsComObject(object o);

		// Token: 0x06002278 RID: 8824
		[Token(Token = "0x6002278")]
		[Address(RVA = "0x4BB72F0", Offset = "0x4BB5EF0", VA = "0x184BB72F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int GetLastWin32Error();

		// Token: 0x06002279 RID: 8825
		[Token(Token = "0x6002279")]
		[Address(RVA = "0x4BB7310", Offset = "0x4BB5F10", VA = "0x184BB7310")]
		[MethodImpl(4096)]
		public static extern System.IntPtr OffsetOf(System.Type t, string fieldName);

		// Token: 0x0600227A RID: 8826
		[Token(Token = "0x600227A")]
		[Address(RVA = "0x4BB7320", Offset = "0x4BB5F20", VA = "0x184BB7320")]
		[MethodImpl(4096)]
		public static extern string PtrToStringAnsi(System.IntPtr ptr);

		// Token: 0x0600227B RID: 8827
		[Token(Token = "0x600227B")]
		[Address(RVA = "0x4BB7330", Offset = "0x4BB5F30", VA = "0x184BB7330")]
		[MethodImpl(4096)]
		public static extern string PtrToStringAnsi(System.IntPtr ptr, int len);

		// Token: 0x0600227C RID: 8828
		[Token(Token = "0x600227C")]
		[Address(RVA = "0x4BB7340", Offset = "0x4BB5F40", VA = "0x184BB7340")]
		[MethodImpl(4096)]
		public static extern string PtrToStringUni(System.IntPtr ptr);

		// Token: 0x0600227D RID: 8829
		[Token(Token = "0x600227D")]
		[Address(RVA = "0x4BB7350", Offset = "0x4BB5F50", VA = "0x184BB7350")]
		[MethodImpl(4096)]
		public static extern string PtrToStringUni(System.IntPtr ptr, int len);

		// Token: 0x0600227E RID: 8830
		[Token(Token = "0x600227E")]
		[Address(RVA = "0x4BB7360", Offset = "0x4BB5F60", VA = "0x184BB7360")]
		[ComVisible(true)]
		[MethodImpl(4096)]
		public static extern object PtrToStructure(System.IntPtr ptr, System.Type structureType);

		// Token: 0x0600227F RID: 8831 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600227F")]
		public static T PtrToStructure<T>(System.IntPtr ptr)
		{
			return null;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x4BB7370", Offset = "0x4BB5F70", VA = "0x184BB7370")]
		public static byte ReadByte(System.IntPtr ptr, int ofs)
		{
			return 0;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00013D88 File Offset: 0x00011F88
		[Token(Token = "0x6002281")]
		[Address(RVA = "0x4BB7390", Offset = "0x4BB5F90", VA = "0x184BB7390")]
		public static short ReadInt16(System.IntPtr ptr, int ofs)
		{
			return 0;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00013DA0 File Offset: 0x00011FA0
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x4BB73F0", Offset = "0x4BB5FF0", VA = "0x184BB73F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static int ReadInt32(System.IntPtr ptr, int ofs)
		{
			return 0;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x6002283")]
		[Address(RVA = "0x4BB7450", Offset = "0x4BB6050", VA = "0x184BB7450")]
		public static long ReadInt64(System.IntPtr ptr, int ofs)
		{
			return 0L;
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x6002284")]
		[Address(RVA = "0x4BB74B0", Offset = "0x4BB60B0", VA = "0x184BB74B0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs)
		{
			return 0;
		}

		// Token: 0x06002285 RID: 8837
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x4BB75E0", Offset = "0x4BB61E0", VA = "0x184BB75E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		private static extern int ReleaseInternal(System.IntPtr pUnk);

		// Token: 0x06002286 RID: 8838 RVA: 0x00013DE8 File Offset: 0x00011FE8
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x4BB75F0", Offset = "0x4BB61F0", VA = "0x184BB75F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static int Release(System.IntPtr pUnk)
		{
			return 0;
		}

		// Token: 0x06002287 RID: 8839
		[Token(Token = "0x6002287")]
		[Address(RVA = "0x4BB7C70", Offset = "0x4BB6870", VA = "0x184BB7C70")]
		[MethodImpl(4096)]
		public static extern int SizeOf(System.Type t);

		// Token: 0x06002288 RID: 8840 RVA: 0x00013E00 File Offset: 0x00012000
		[Token(Token = "0x6002288")]
		public static int SizeOf<T>()
		{
			return 0;
		}

		// Token: 0x06002289 RID: 8841
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x4BB7C80", Offset = "0x4BB6880", VA = "0x184BB7C80")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr StringToHGlobalAnsi(char* s, int length);

		// Token: 0x0600228A RID: 8842 RVA: 0x00013E18 File Offset: 0x00012018
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x4BB7C90", Offset = "0x4BB6890", VA = "0x184BB7C90")]
		public static System.IntPtr StringToHGlobalAnsi(string s)
		{
			return 0;
		}

		// Token: 0x0600228B RID: 8843
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x4BB7D70", Offset = "0x4BB6970", VA = "0x184BB7D70")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr StringToHGlobalUni(char* s, int length);

		// Token: 0x0600228C RID: 8844 RVA: 0x00013E30 File Offset: 0x00012030
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x4BB7D00", Offset = "0x4BB6900", VA = "0x184BB7D00")]
		public static System.IntPtr StringToHGlobalUni(string s)
		{
			return 0;
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00013E48 File Offset: 0x00012048
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x4BB7750", Offset = "0x4BB6350", VA = "0x184BB7750")]
		public static System.IntPtr SecureStringToBSTR(System.Security.SecureString s)
		{
			return 0;
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x00013E60 File Offset: 0x00012060
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x4BB76C0", Offset = "0x4BB62C0", VA = "0x184BB76C0")]
		internal static System.IntPtr SecureStringGlobalAllocator(int len)
		{
			return 0;
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x00013E78 File Offset: 0x00012078
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x4BB79D0", Offset = "0x4BB65D0", VA = "0x184BB79D0")]
		internal static System.IntPtr SecureStringToUnicode(System.Security.SecureString s, Marshal.SecureStringAllocator allocator)
		{
			return 0;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x00013E90 File Offset: 0x00012090
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x4BB78D0", Offset = "0x4BB64D0", VA = "0x184BB78D0")]
		public static System.IntPtr SecureStringToGlobalAllocUnicode(System.Security.SecureString s)
		{
			return 0;
		}

		// Token: 0x06002291 RID: 8849
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x4BB7D80", Offset = "0x4BB6980", VA = "0x184BB7D80")]
		[ComVisible(true)]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[MethodImpl(4096)]
		public static extern void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld);

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		public static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld)
		{
		}

		// Token: 0x06002293 RID: 8851
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x4BB5CF0", Offset = "0x4BB48F0", VA = "0x184BB5CF0")]
		[MethodImpl(4096)]
		private unsafe static extern System.IntPtr BufferToBSTR(char* ptr, int slen);

		// Token: 0x06002294 RID: 8852
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x4BB7D90", Offset = "0x4BB6990", VA = "0x184BB7D90")]
		[MethodImpl(4096)]
		public static extern System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index);

		// Token: 0x06002295 RID: 8853 RVA: 0x00013EA8 File Offset: 0x000120A8
		[Token(Token = "0x6002295")]
		public static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index)
		{
			return 0;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x4BB7DA0", Offset = "0x4BB69A0", VA = "0x184BB7DA0")]
		public static void WriteByte(System.IntPtr ptr, int ofs, byte val)
		{
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x4BB7DD0", Offset = "0x4BB69D0", VA = "0x184BB7DD0")]
		public static void WriteInt16(System.IntPtr ptr, int ofs, short val)
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x4BB7E20", Offset = "0x4BB6A20", VA = "0x184BB7E20")]
		public static void WriteInt32(System.IntPtr ptr, int val)
		{
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x4BB7E70", Offset = "0x4BB6A70", VA = "0x184BB7E70")]
		public static void WriteInt64(System.IntPtr ptr, long val)
		{
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229A")]
		[Address(RVA = "0x4BB7EC0", Offset = "0x4BB6AC0", VA = "0x184BB7EC0")]
		public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val)
		{
		}

		// Token: 0x0600229B RID: 8859
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x4BB72D0", Offset = "0x4BB5ED0", VA = "0x184BB72D0")]
		[MethodImpl(4096)]
		private static extern System.IntPtr GetFunctionPointerForDelegateInternal(System.Delegate d);

		// Token: 0x0600229C RID: 8860 RVA: 0x00013EC0 File Offset: 0x000120C0
		[Token(Token = "0x600229C")]
		public static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
		{
			return 0;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x4BB69F0", Offset = "0x4BB55F0", VA = "0x184BB69F0")]
		internal static ICustomMarshaler GetCustomMarshalerInstance(System.Type type, string cookie)
		{
			return null;
		}

		// Token: 0x040013B4 RID: 5044
		[Token(Token = "0x40013B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int SystemMaxDBCSCharSize;

		// Token: 0x040013B5 RID: 5045
		[Token(Token = "0x40013B5")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int SystemDefaultCharSize;

		// Token: 0x040013B6 RID: 5046
		[Token(Token = "0x40013B6")]
		[FieldOffset(Offset = "0x8")]
		internal static System.Collections.Generic.Dictionary<System.ValueTuple<System.Type, string>, ICustomMarshaler> MarshalerInstanceCache;

		// Token: 0x040013B7 RID: 5047
		[Token(Token = "0x40013B7")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly object MarshalerInstanceCacheLock;

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x060022A0 RID: 8864
		[Token(Token = "0x2000478")]
		internal delegate System.IntPtr SecureStringAllocator(int len);

		// Token: 0x02000479 RID: 1145
		[Token(Token = "0x2000479")]
		internal class MarshalerInstanceKeyComparer : System.Collections.Generic.IEqualityComparer<System.ValueTuple<System.Type, string>>
		{
			// Token: 0x060022A1 RID: 8865 RVA: 0x00013ED8 File Offset: 0x000120D8
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x4BD80D0", Offset = "0x4BD6CD0", VA = "0x184BD80D0", Slot = "4")]
			public bool Equals(System.ValueTuple<System.Type, string> lhs, System.ValueTuple<System.Type, string> rhs)
			{
				return default(bool);
			}

			// Token: 0x060022A2 RID: 8866 RVA: 0x00013EF0 File Offset: 0x000120F0
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x4BD8130", Offset = "0x4BD6D30", VA = "0x184BD8130", Slot = "5")]
			public int GetHashCode(System.ValueTuple<System.Type, string> key)
			{
				return 0;
			}

			// Token: 0x060022A3 RID: 8867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MarshalerInstanceKeyComparer()
			{
			}
		}
	}
}
