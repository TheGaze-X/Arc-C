using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	internal class AndroidJNISafe
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x59054A0", Offset = "0x59040A0", VA = "0x1859054A0")]
		public static void CheckException()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5905720", Offset = "0x5904320", VA = "0x185905720")]
		public static void DeleteGlobalRef(IntPtr globalref)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5905820", Offset = "0x5904420", VA = "0x185905820")]
		public static void DeleteWeakGlobalRef(IntPtr globalref)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x59057A0", Offset = "0x59043A0", VA = "0x1859057A0")]
		public static void DeleteLocalRef(IntPtr localref)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x5906C50", Offset = "0x5905850", VA = "0x185906C50")]
		public static IntPtr NewString(string chars)
		{
			return 0;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x5906AD0", Offset = "0x59056D0", VA = "0x185906AD0")]
		public static string GetStringChars(IntPtr str)
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x59062A0", Offset = "0x5904EA0", VA = "0x1859062A0")]
		public static IntPtr GetObjectClass(IntPtr ptr)
		{
			return 0;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x5906840", Offset = "0x5905440", VA = "0x185906840")]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			return 0;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x5906190", Offset = "0x5904D90", VA = "0x185906190")]
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			return 0;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5905F70", Offset = "0x5904B70", VA = "0x185905F70")]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			return 0;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5906620", Offset = "0x5905220", VA = "0x185906620")]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			return 0;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5905C20", Offset = "0x5904820", VA = "0x185905C20")]
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			return 0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x59058A0", Offset = "0x59044A0", VA = "0x1859058A0")]
		public static IntPtr FindClass(string name)
		{
			return 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5906BC0", Offset = "0x59057C0", VA = "0x185906BC0")]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x59068D0", Offset = "0x59054D0", VA = "0x1859068D0")]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x5906A50", Offset = "0x5905650", VA = "0x185906A50")]
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x5906510", Offset = "0x5905110", VA = "0x185906510")]
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			return '\0';
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x5906590", Offset = "0x5905190", VA = "0x185906590")]
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			return 0.0;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x59066B0", Offset = "0x59052B0", VA = "0x1859066B0")]
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			return 0f;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x59067C0", Offset = "0x59053C0", VA = "0x1859067C0")]
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			return 0L;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x59069D0", Offset = "0x59055D0", VA = "0x1859069D0")]
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x5906950", Offset = "0x5905550", VA = "0x185906950")]
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x5906490", Offset = "0x5905090", VA = "0x185906490")]
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			return default(bool);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x5906740", Offset = "0x5905340", VA = "0x185906740")]
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x5905390", Offset = "0x5903F90", VA = "0x185905390")]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x5905150", Offset = "0x5903D50", VA = "0x185905150")]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x5905300", Offset = "0x5903F00", VA = "0x185905300")]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x5904E60", Offset = "0x5903A60", VA = "0x185904E60")]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return '\0';
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x5904EF0", Offset = "0x5903AF0", VA = "0x185904EF0")]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0.0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x5904F90", Offset = "0x5903B90", VA = "0x185904F90")]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0f;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x59050C0", Offset = "0x5903CC0", VA = "0x1859050C0")]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0L;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x5905270", Offset = "0x5903E70", VA = "0x185905270")]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x59051E0", Offset = "0x5903DE0", VA = "0x1859051E0")]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x5904DD0", Offset = "0x59039D0", VA = "0x185904DD0")]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return default(bool);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5905030", Offset = "0x5903C30", VA = "0x185905030")]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x5906310", Offset = "0x5904F10", VA = "0x185906310")]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x5906B40", Offset = "0x5905740", VA = "0x185906B40")]
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x5905E60", Offset = "0x5904A60", VA = "0x185905E60")]
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			return '\0';
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5905EE0", Offset = "0x5904AE0", VA = "0x185905EE0")]
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			return 0.0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x5906000", Offset = "0x5904C00", VA = "0x185906000")]
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			return 0f;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x5906110", Offset = "0x5904D10", VA = "0x185906110")]
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			return 0L;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x5906410", Offset = "0x5905010", VA = "0x185906410")]
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x5906390", Offset = "0x5904F90", VA = "0x185906390")]
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x5905DE0", Offset = "0x59049E0", VA = "0x185905DE0")]
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			return default(bool);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x5906090", Offset = "0x5904C90", VA = "0x185906090")]
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			return 0;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5904C20", Offset = "0x5903820", VA = "0x185904C20")]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x5905410", Offset = "0x5904010", VA = "0x185905410")]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return null;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x5904930", Offset = "0x5903530", VA = "0x185904930")]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return '\0';
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x59049C0", Offset = "0x59035C0", VA = "0x1859049C0")]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0.0;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x5904A60", Offset = "0x5903660", VA = "0x185904A60")]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0f;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x5904B90", Offset = "0x5903790", VA = "0x185904B90")]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0L;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x5904D40", Offset = "0x5903940", VA = "0x185904D40")]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x5904CB0", Offset = "0x59038B0", VA = "0x185904CB0")]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x59048A0", Offset = "0x59034A0", VA = "0x1859048A0")]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x5904B00", Offset = "0x5903700", VA = "0x185904B00")]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			return 0;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x59059F0", Offset = "0x59045F0", VA = "0x1859059F0")]
		public static char[] FromCharArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5905A60", Offset = "0x5904660", VA = "0x185905A60")]
		public static double[] FromDoubleArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x5905AD0", Offset = "0x59046D0", VA = "0x185905AD0")]
		public static float[] FromFloatArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x5905BB0", Offset = "0x59047B0", VA = "0x185905BB0")]
		public static long[] FromLongArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5905D00", Offset = "0x5904900", VA = "0x185905D00")]
		public static short[] FromShortArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x5905980", Offset = "0x5904580", VA = "0x185905980")]
		public static byte[] FromByteArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x5905C90", Offset = "0x5904890", VA = "0x185905C90")]
		public static sbyte[] FromSByteArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x5905910", Offset = "0x5904510", VA = "0x185905910")]
		public static bool[] FromBooleanArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x5905B40", Offset = "0x5904740", VA = "0x185905B40")]
		public static int[] FromIntArray(IntPtr array)
		{
			return null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x5906FD0", Offset = "0x5905BD0", VA = "0x185906FD0")]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
		{
			return 0;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5906DA0", Offset = "0x59059A0", VA = "0x185906DA0")]
		public static IntPtr ToCharArray(char[] array)
		{
			return 0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x5906E10", Offset = "0x5905A10", VA = "0x185906E10")]
		public static IntPtr ToDoubleArray(double[] array)
		{
			return 0;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x5906E80", Offset = "0x5905A80", VA = "0x185906E80")]
		public static IntPtr ToFloatArray(float[] array)
		{
			return 0;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5906F60", Offset = "0x5905B60", VA = "0x185906F60")]
		public static IntPtr ToLongArray(long[] array)
		{
			return 0;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x59070C0", Offset = "0x5905CC0", VA = "0x1859070C0")]
		public static IntPtr ToShortArray(short[] array)
		{
			return 0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x5906D30", Offset = "0x5905930", VA = "0x185906D30")]
		public static IntPtr ToByteArray(byte[] array)
		{
			return 0;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x5907050", Offset = "0x5905C50", VA = "0x185907050")]
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			return 0;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x5906CC0", Offset = "0x59058C0", VA = "0x185906CC0")]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			return 0;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x5906EF0", Offset = "0x5905AF0", VA = "0x185906EF0")]
		public static IntPtr ToIntArray(int[] array)
		{
			return 0;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x5906220", Offset = "0x5904E20", VA = "0x185906220")]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			return 0;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x5905D70", Offset = "0x5904970", VA = "0x185905D70")]
		public static int GetArrayLength(IntPtr array)
		{
			return 0;
		}
	}
}
