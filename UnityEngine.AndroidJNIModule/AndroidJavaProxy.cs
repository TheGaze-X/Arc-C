using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class AndroidJavaProxy
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x590A7D0", Offset = "0x59093D0", VA = "0x18590A7D0")]
		public AndroidJavaProxy(string javaInterface)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x590A890", Offset = "0x5909490", VA = "0x18590A890")]
		public AndroidJavaProxy(AndroidJavaClass javaInterface)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5909790", Offset = "0x5908390", VA = "0x185909790", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59099C0", Offset = "0x59085C0", VA = "0x1859099C0", Slot = "4")]
		public virtual AndroidJavaObject Invoke(string methodName, object[] args)
		{
			return null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x590A500", Offset = "0x5909100", VA = "0x18590A500", Slot = "5")]
		public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs)
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002070 File Offset: 0x00000270
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x590A900", Offset = "0x5909500", VA = "0x18590A900", Slot = "6")]
		public virtual bool equals(AndroidJavaObject obj)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x590A9B0", Offset = "0x59095B0", VA = "0x18590A9B0", Slot = "7")]
		public virtual int hashCode()
		{
			return 0;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x590AA70", Offset = "0x5909670", VA = "0x18590AA70", Slot = "8")]
		public virtual string toString()
		{
			return null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5909850", Offset = "0x5908450", VA = "0x185909850")]
		internal AndroidJavaObject GetProxyObject()
		{
			return null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x5909870", Offset = "0x5908470", VA = "0x185909870")]
		internal IntPtr GetRawProxy()
		{
			return 0;
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x10")]
		public readonly AndroidJavaClass javaInterface;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x18")]
		internal IntPtr proxyObject;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GlobalJavaObjectRef s_JavaLangSystemClass;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IntPtr s_HashCodeMethodID;
	}
}
