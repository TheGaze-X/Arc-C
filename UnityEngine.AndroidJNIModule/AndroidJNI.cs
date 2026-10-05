using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[NativeConditional("PLATFORM_ANDROID")]
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	public static class AndroidJNI
	{
		// Token: 0x0600005E RID: 94
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5907A30", Offset = "0x5906630", VA = "0x185907A30")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr FindClass(string name);

		// Token: 0x0600005F RID: 95
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5907C30", Offset = "0x5906830", VA = "0x185907C30")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr FromReflectedMethod(IntPtr refMethod);

		// Token: 0x06000060 RID: 96
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5907A00", Offset = "0x5906600", VA = "0x185907A00")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ExceptionOccurred();

		// Token: 0x06000061 RID: 97
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59079D0", Offset = "0x59065D0", VA = "0x1859079D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void ExceptionClear();

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59087F0", Offset = "0x59073F0", VA = "0x1859087F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int PushLocalFrame(int capacity);

		// Token: 0x06000063 RID: 99
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59087B0", Offset = "0x59073B0", VA = "0x1859087B0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr PopLocalFrame(IntPtr ptr);

		// Token: 0x06000064 RID: 100
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5908600", Offset = "0x5907200", VA = "0x185908600")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr NewGlobalRef(IntPtr obj);

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5907910", Offset = "0x5906510", VA = "0x185907910")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void DeleteGlobalRef(IntPtr obj);

		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5908770", Offset = "0x5907370", VA = "0x185908770")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr NewWeakGlobalRef(IntPtr obj);

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5907990", Offset = "0x5906590", VA = "0x185907990")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void DeleteWeakGlobalRef(IntPtr obj);

		// Token: 0x06000068 RID: 104
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x5908640", Offset = "0x5907240", VA = "0x185908640")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr NewLocalRef(IntPtr obj);

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5907950", Offset = "0x5906550", VA = "0x185907950")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void DeleteLocalRef(IntPtr obj);

		// Token: 0x0600006A RID: 106
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59085B0", Offset = "0x59071B0", VA = "0x1859085B0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool IsSameObject(IntPtr obj1, IntPtr obj2);

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59086D0", Offset = "0x59072D0", VA = "0x1859086D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600006C RID: 108
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5908010", Offset = "0x5906C10", VA = "0x185908010")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectClass(IntPtr obj);

		// Token: 0x0600006D RID: 109
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5907F70", Offset = "0x5906B70", VA = "0x185907F70")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetMethodID(IntPtr clazz, string name, string sig);

		// Token: 0x0600006E RID: 110
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x5907E20", Offset = "0x5906A20", VA = "0x185907E20")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetFieldID(IntPtr clazz, string name, string sig);

		// Token: 0x0600006F RID: 111
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5908380", Offset = "0x5906F80", VA = "0x185908380")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig);

		// Token: 0x06000070 RID: 112
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5908230", Offset = "0x5906E30", VA = "0x185908230")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig);

		// Token: 0x06000071 RID: 113 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5908730", Offset = "0x5907330", VA = "0x185908730")]
		public static IntPtr NewString(string chars)
		{
			return 0;
		}

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5908730", Offset = "0x5907330", VA = "0x185908730")]
		[ThreadSafe]
		[MethodImpl(4096)]
		private static extern IntPtr NewStringFromStr(string chars);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x5908520", Offset = "0x5907120", VA = "0x185908520")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern string GetStringChars(IntPtr str);

		// Token: 0x06000074 RID: 116
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x59078B0", Offset = "0x59064B0", VA = "0x1859078B0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000075 RID: 117
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x5907370", Offset = "0x5905F70", VA = "0x185907370")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000076 RID: 118
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x59072B0", Offset = "0x5905EB0", VA = "0x1859072B0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000077 RID: 119
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5907130", Offset = "0x5905D30", VA = "0x185907130")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000078 RID: 120
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5907430", Offset = "0x5906030", VA = "0x185907430")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x06000079 RID: 121
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x59073D0", Offset = "0x5905FD0", VA = "0x1859073D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007A RID: 122
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5907190", Offset = "0x5905D90", VA = "0x185907190")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007B RID: 123
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5907250", Offset = "0x5905E50", VA = "0x185907250")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007C RID: 124
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x59071F0", Offset = "0x5905DF0", VA = "0x1859071F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5907310", Offset = "0x5905F10", VA = "0x185907310")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args);

		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x5908560", Offset = "0x5907160", VA = "0x185908560")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern string GetStringField(IntPtr obj, IntPtr fieldID);

		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x5908050", Offset = "0x5906C50", VA = "0x185908050")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x5907D30", Offset = "0x5906930", VA = "0x185907D30")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool GetBooleanField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x59080A0", Offset = "0x5906CA0", VA = "0x1859080A0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern sbyte GetSByteField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x5907D80", Offset = "0x5906980", VA = "0x185907D80")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern char GetCharField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x59080F0", Offset = "0x5906CF0", VA = "0x1859080F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern short GetShortField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x5907ED0", Offset = "0x5906AD0", VA = "0x185907ED0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int GetIntField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x5907F20", Offset = "0x5906B20", VA = "0x185907F20")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern long GetLongField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5907E80", Offset = "0x5906A80", VA = "0x185907E80")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern float GetFloatField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000087 RID: 135
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5907DD0", Offset = "0x59069D0", VA = "0x185907DD0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern double GetDoubleField(IntPtr obj, IntPtr fieldID);

		// Token: 0x06000088 RID: 136
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x59077F0", Offset = "0x59063F0", VA = "0x1859077F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x59076D0", Offset = "0x59062D0", VA = "0x1859076D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008A RID: 138
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x5907610", Offset = "0x5906210", VA = "0x185907610")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008B RID: 139
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5907490", Offset = "0x5906090", VA = "0x185907490")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008C RID: 140
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5907790", Offset = "0x5906390", VA = "0x185907790")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008D RID: 141
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x5907730", Offset = "0x5906330", VA = "0x185907730")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008E RID: 142
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x59074F0", Offset = "0x59060F0", VA = "0x1859074F0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x0600008F RID: 143
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x59075B0", Offset = "0x59061B0", VA = "0x1859075B0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000090 RID: 144
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5907550", Offset = "0x5906150", VA = "0x185907550")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000091 RID: 145
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5907670", Offset = "0x5906270", VA = "0x185907670")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000092 RID: 146
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x5907850", Offset = "0x5906450", VA = "0x185907850")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args);

		// Token: 0x06000093 RID: 147
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x59084D0", Offset = "0x59070D0", VA = "0x1859084D0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern string GetStaticStringField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000094 RID: 148
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x59083E0", Offset = "0x5906FE0", VA = "0x1859083E0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000095 RID: 149
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x5908140", Offset = "0x5906D40", VA = "0x185908140")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000096 RID: 150
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x5908430", Offset = "0x5907030", VA = "0x185908430")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000097 RID: 151
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x5908190", Offset = "0x5906D90", VA = "0x185908190")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern char GetStaticCharField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000098 RID: 152
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x5908480", Offset = "0x5907080", VA = "0x185908480")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern short GetStaticShortField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x06000099 RID: 153
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x59082E0", Offset = "0x5906EE0", VA = "0x1859082E0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int GetStaticIntField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600009A RID: 154
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5908330", Offset = "0x5906F30", VA = "0x185908330")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern long GetStaticLongField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600009B RID: 155
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x5908290", Offset = "0x5906E90", VA = "0x185908290")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern float GetStaticFloatField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600009C RID: 156
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x59081E0", Offset = "0x5906DE0", VA = "0x1859081E0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0600009D RID: 157
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5908880", Offset = "0x5907480", VA = "0x185908880")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToBooleanArray(bool[] array);

		// Token: 0x0600009E RID: 158
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x59088C0", Offset = "0x59074C0", VA = "0x1859088C0")]
		[ThreadSafe]
		[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
		[MethodImpl(4096)]
		public static extern IntPtr ToByteArray(byte[] array);

		// Token: 0x0600009F RID: 159
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x5908A90", Offset = "0x5907690", VA = "0x185908A90")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToSByteArray([Unmarshalled] sbyte[] array);

		// Token: 0x060000A0 RID: 160
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x5908900", Offset = "0x5907500", VA = "0x185908900")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToCharArray([Unmarshalled] char[] array);

		// Token: 0x060000A1 RID: 161
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x5908AD0", Offset = "0x59076D0", VA = "0x185908AD0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToShortArray([Unmarshalled] short[] array);

		// Token: 0x060000A2 RID: 162
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x59089C0", Offset = "0x59075C0", VA = "0x1859089C0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToIntArray([Unmarshalled] int[] array);

		// Token: 0x060000A3 RID: 163
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x5908A00", Offset = "0x5907600", VA = "0x185908A00")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToLongArray([Unmarshalled] long[] array);

		// Token: 0x060000A4 RID: 164
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x5908980", Offset = "0x5907580", VA = "0x185908980")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToFloatArray([Unmarshalled] float[] array);

		// Token: 0x060000A5 RID: 165
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5908940", Offset = "0x5907540", VA = "0x185908940")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToDoubleArray([Unmarshalled] double[] array);

		// Token: 0x060000A6 RID: 166
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x5908A40", Offset = "0x5907640", VA = "0x185908A40")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass);

		// Token: 0x060000A7 RID: 167
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x5907A70", Offset = "0x5906670", VA = "0x185907A70")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern bool[] FromBooleanArray(IntPtr array);

		// Token: 0x060000A8 RID: 168
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x5907AB0", Offset = "0x59066B0", VA = "0x185907AB0")]
		[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern byte[] FromByteArray(IntPtr array);

		// Token: 0x060000A9 RID: 169
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x5907C70", Offset = "0x5906870", VA = "0x185907C70")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern sbyte[] FromSByteArray(IntPtr array);

		// Token: 0x060000AA RID: 170
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x5907AF0", Offset = "0x59066F0", VA = "0x185907AF0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern char[] FromCharArray(IntPtr array);

		// Token: 0x060000AB RID: 171
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x5907CB0", Offset = "0x59068B0", VA = "0x185907CB0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern short[] FromShortArray(IntPtr array);

		// Token: 0x060000AC RID: 172
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x5907BB0", Offset = "0x59067B0", VA = "0x185907BB0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int[] FromIntArray(IntPtr array);

		// Token: 0x060000AD RID: 173
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x5907BF0", Offset = "0x59067F0", VA = "0x185907BF0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern long[] FromLongArray(IntPtr array);

		// Token: 0x060000AE RID: 174
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x5907B70", Offset = "0x5906770", VA = "0x185907B70")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern float[] FromFloatArray(IntPtr array);

		// Token: 0x060000AF RID: 175
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x5907B30", Offset = "0x5906730", VA = "0x185907B30")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern double[] FromDoubleArray(IntPtr array);

		// Token: 0x060000B0 RID: 176
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x5907CF0", Offset = "0x59068F0", VA = "0x185907CF0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern int GetArrayLength(IntPtr array);

		// Token: 0x060000B1 RID: 177
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x5908680", Offset = "0x5907280", VA = "0x185908680")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj);

		// Token: 0x060000B2 RID: 178
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x5907FD0", Offset = "0x5906BD0", VA = "0x185907FD0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern IntPtr GetObjectArrayElement(IntPtr array, int index);

		// Token: 0x060000B3 RID: 179
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x5908830", Offset = "0x5907430", VA = "0x185908830")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public static extern void SetObjectArrayElement(IntPtr array, int index, IntPtr obj);
	}
}
