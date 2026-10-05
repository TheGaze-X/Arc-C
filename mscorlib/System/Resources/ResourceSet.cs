using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class ResourceSet : System.IDisposable, System.Collections.IEnumerable
	{
		// Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x4BE4C00", Offset = "0x4BE3800", VA = "0x184BE4C00")]
		protected ResourceSet()
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal ResourceSet(bool junk)
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x4BE4180", Offset = "0x4BE2D80", VA = "0x184BE4180")]
		private void CommonInit()
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x4BE41F0", Offset = "0x4BE2DF0", VA = "0x184BE41F0", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x4BE4730", Offset = "0x4BE3330", VA = "0x184BE4730", Slot = "7")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x4BE4730", Offset = "0x4BE3330", VA = "0x184BE4730", Slot = "5")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x4BE4680", Offset = "0x4BE3280", VA = "0x184BE4680")]
		private System.Collections.IDictionaryEnumerator GetEnumeratorHelper()
		{
			return null;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x4BE48B0", Offset = "0x4BE34B0", VA = "0x184BE48B0", Slot = "8")]
		public virtual string GetString(string name)
		{
			return null;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x4BE49E0", Offset = "0x4BE35E0", VA = "0x184BE49E0", Slot = "9")]
		public virtual string GetString(string name, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x4BE48A0", Offset = "0x4BE34A0", VA = "0x184BE48A0", Slot = "10")]
		public virtual object GetObject(string name)
		{
			return null;
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x4BE4850", Offset = "0x4BE3450", VA = "0x184BE4850", Slot = "11")]
		public virtual object GetObject(string name, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x4BE4740", Offset = "0x4BE3340", VA = "0x184BE4740")]
		private object GetObjectInternal(string name)
		{
			return null;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x4BE4290", Offset = "0x4BE2E90", VA = "0x184BE4290")]
		private object GetCaseInsensitiveObjectInternal(string name)
		{
			return null;
		}

		// Token: 0x04001480 RID: 5248
		[Token(Token = "0x4001480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[System.NonSerialized]
		protected IResourceReader Reader;

		// Token: 0x04001481 RID: 5249
		[Token(Token = "0x4001481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected System.Collections.Hashtable Table;

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Collections.Hashtable _caseInsensitiveTable;
	}
}
