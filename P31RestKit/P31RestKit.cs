using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Prime31
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class P31RestKit
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		protected virtual GameObject surrogateGameObject
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4E0E440", Offset = "0x4E0D040", VA = "0x184E0E440", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		protected MonoBehaviour surrogateMonobehaviour
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x4E0E580", Offset = "0x4E0D180", VA = "0x184E0E580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4E0F6F0", Offset = "0x4E0E2F0", VA = "0x184E0F6F0", Slot = "6")]
		protected virtual IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4E0EBE0", Offset = "0x4E0D7E0", VA = "0x184E0EBE0", Slot = "7")]
		protected virtual WWW processRequest(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4E0E650", Offset = "0x4E0D250", VA = "0x184E0E650", Slot = "8")]
		protected virtual Dictionary<string, string> headersForRequest(HTTPVerb httpVerb, [Optional] Dictionary<string, string> headers)
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4E0F4C0", Offset = "0x4E0E0C0", VA = "0x184E0F4C0", Slot = "9")]
		protected virtual void processResponse(WWW www, Action<string, object> onComplete)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002058 File Offset: 0x00000258
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4E0E7C0", Offset = "0x4E0D3C0", VA = "0x184E0E7C0")]
		protected bool isResponseJson(WWW www)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4E0E1B0", Offset = "0x4E0CDB0", VA = "0x184E0E1B0", Slot = "10")]
		protected virtual IDictionary getHeadersFromForm(WWWForm form)
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void setBaseUrl(string baseUrl)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4E0E3B0", Offset = "0x4E0CFB0", VA = "0x184E0E3B0")]
		public void get(string path, Action<string, object> completionHandler)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4E0E310", Offset = "0x4E0CF10", VA = "0x184E0E310")]
		public void get(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4E0EAA0", Offset = "0x4E0D6A0", VA = "0x184E0EAA0")]
		public void post(string path, Action<string, object> completionHandler)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4E0EB30", Offset = "0x4E0D730", VA = "0x184E0EB30")]
		public void post(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4E0F660", Offset = "0x4E0E260", VA = "0x184E0F660")]
		public void put(string path, Action<string, object> completionHandler)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4E0F5B0", Offset = "0x4E0E1B0", VA = "0x184E0F5B0")]
		public void put(string path, Dictionary<string, object> parameters, Action<string, object> completionHandler)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x4E0E1A0", Offset = "0x4E0CDA0", VA = "0x184E0E1A0")]
		public P31RestKit()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string _baseUrl;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool debugRequests;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool forceJsonResponse;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _surrogateGameObject;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private MonoBehaviour _surrogateMonobehaviour;
	}
}
