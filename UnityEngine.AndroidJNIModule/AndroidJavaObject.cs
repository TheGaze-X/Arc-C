using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AndroidJavaObject : IDisposable
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5909750", Offset = "0x5908350", VA = "0x185909750")]
		public AndroidJavaObject(string className, params object[] args)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x5909140", Offset = "0x5907D40", VA = "0x185909140", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59090C0", Offset = "0x5907CC0", VA = "0x1859090C0")]
		public void CallStatic(string methodName, params object[] args)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000018")]
		public FieldType Get<FieldType>(string fieldName)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000019")]
		public FieldType GetStatic<FieldType>(string fieldName)
		{
			return null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x5909210", Offset = "0x5907E10", VA = "0x185909210")]
		public IntPtr GetRawObject()
		{
			return 0;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4DF2DC0", Offset = "0x4DF19C0", VA = "0x184DF2DC0")]
		public IntPtr GetRawClass()
		{
			return 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001C")]
		public ReturnType Call<ReturnType>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600001D")]
		public ReturnType CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x59090D0", Offset = "0x5907CD0", VA = "0x1859090D0")]
		protected void DebugPrint(string msg)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x5909260", Offset = "0x5907E60", VA = "0x185909260")]
		private void _AndroidJavaObject(string className, params object[] args)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x59095F0", Offset = "0x59081F0", VA = "0x1859095F0")]
		internal AndroidJavaObject(IntPtr jobject)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal AndroidJavaObject()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59091B0", Offset = "0x5907DB0", VA = "0x1859091B0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000024")]
		protected ReturnType _Call<ReturnType>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000025")]
		protected FieldType _Get<FieldType>(string fieldName)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x59094C0", Offset = "0x59080C0", VA = "0x1859094C0")]
		protected void _CallStatic(string methodName, params object[] args)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000027")]
		protected ReturnType _CallStatic<ReturnType>(string methodName, params object[] args)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000028")]
		protected FieldType _GetStatic<FieldType>(string fieldName)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5909010", Offset = "0x5907C10", VA = "0x185909010")]
		internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5908F60", Offset = "0x5907B60", VA = "0x185908F60")]
		internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002B")]
		internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5909210", Offset = "0x5907E10", VA = "0x185909210")]
		protected IntPtr _GetRawObject()
		{
			return 0;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4DF2DC0", Offset = "0x4DF19C0", VA = "0x184DF2DC0")]
		protected IntPtr _GetRawClass()
		{
			return 0;
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static bool enableDebugPrints;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		internal GlobalJavaObjectRef m_jobject;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		internal GlobalJavaObjectRef m_jclass;
	}
}
