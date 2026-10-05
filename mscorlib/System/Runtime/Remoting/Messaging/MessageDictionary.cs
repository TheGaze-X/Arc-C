using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Remoting.Messaging
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	[System.Serializable]
	internal class MessageDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
	{
		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		public MessageDictionary(IMethodMessage message)
		{
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x4B81E40", Offset = "0x4B80A40", VA = "0x184B81E40")]
		internal bool HasUserData()
		{
			return default(bool);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003E1")]
		internal System.Collections.IDictionary InternalDictionary
		{
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x4B824E0", Offset = "0x4B810E0", VA = "0x184B824E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (set) Token: 0x06001EEA RID: 7914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003E2")]
		public string[] MethodKeys
		{
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x4B81700", Offset = "0x4B80300", VA = "0x184B81700", Slot = "20")]
		protected virtual System.Collections.IDictionary AllocInternalProperties()
		{
			return null;
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x4B81A10", Offset = "0x4B80610", VA = "0x184B81A10")]
		public System.Collections.IDictionary GetInternalProperties()
		{
			return null;
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00012F60 File Offset: 0x00011160
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x4B82000", Offset = "0x4B80C00", VA = "0x184B82000")]
		private bool IsOverridenKey(string key)
		{
			return default(bool);
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x170003E3")]
		public bool IsFixedSize
		{
			[Token(Token = "0x6001EEE")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x170003E4")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003E5 RID: 997
		[Token(Token = "0x170003E5")]
		public object this[object key]
		{
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x4B82680", Offset = "0x4B81280", VA = "0x184B82680", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x4B81590", Offset = "0x4B80190", VA = "0x184B81590", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x4B81A80", Offset = "0x4B80680", VA = "0x184B81A80", Slot = "21")]
		protected virtual object GetMethodProperty(string key)
		{
			return null;
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x4B821D0", Offset = "0x4B80DD0", VA = "0x184B821D0", Slot = "22")]
		protected virtual void SetMethodProperty(string key, object value)
		{
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003E6")]
		public System.Collections.ICollection Keys
		{
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x4B82790", Offset = "0x4B81390", VA = "0x184B82790", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003E7")]
		public System.Collections.ICollection Values
		{
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x4B82BB0", Offset = "0x4B817B0", VA = "0x184B82BB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF6")]
		[Address(RVA = "0x4B81590", Offset = "0x4B80190", VA = "0x184B81590", Slot = "9")]
		public void Add(object key, object value)
		{
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF7")]
		[Address(RVA = "0x4B81760", Offset = "0x4B80360", VA = "0x184B81760", Slot = "10")]
		public void Clear()
		{
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x6001EF8")]
		[Address(RVA = "0x4B817B0", Offset = "0x4B803B0", VA = "0x184B817B0", Slot = "8")]
		public bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EF9")]
		[Address(RVA = "0x4B82080", Offset = "0x4B80C80", VA = "0x184B82080", Slot = "14")]
		public void Remove(object key)
		{
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x170003E8")]
		public int Count
		{
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x4B82470", Offset = "0x4B81070", VA = "0x184B82470", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001EFB RID: 7931 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x170003E9")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001EFC RID: 7932 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170003EA")]
		public object SyncRoot
		{
			[Token(Token = "0x6001EFC")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x4B818B0", Offset = "0x4B804B0", VA = "0x184B818B0", Slot = "15")]
		public void CopyTo(System.Array array, int index)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x4B82410", Offset = "0x4B81010", VA = "0x184B82410", Slot = "19")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x4B819B0", Offset = "0x4B805B0", VA = "0x184B819B0", Slot = "13")]
		public System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04001058 RID: 4184
		[Token(Token = "0x4001058")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.IDictionary _internalProperties;

		// Token: 0x04001059 RID: 4185
		[Token(Token = "0x4001059")]
		[FieldOffset(Offset = "0x18")]
		protected IMethodMessage _message;

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x20")]
		private string[] _methodKeys;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x28")]
		private bool _ownProperties;

		// Token: 0x020003D9 RID: 985
		[Token(Token = "0x20003D9")]
		private class DictionaryEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
		{
			// Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F00")]
			[Address(RVA = "0x4B99F10", Offset = "0x4B98B10", VA = "0x184B99F10")]
			public DictionaryEnumerator(MessageDictionary methodDictionary)
			{
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06001F01 RID: 7937 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170003EB")]
			public object Current
			{
				[Token(Token = "0x6001F01")]
				[Address(RVA = "0x4B99FB0", Offset = "0x4B98BB0", VA = "0x184B99FB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x00012FF0 File Offset: 0x000111F0
			[Token(Token = "0x6001F02")]
			[Address(RVA = "0x4B99D90", Offset = "0x4B98990", VA = "0x184B99D90", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F03")]
			[Address(RVA = "0x4B99EB0", Offset = "0x4B98AB0", VA = "0x184B99EB0", Slot = "9")]
			public void Reset()
			{
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00013008 File Offset: 0x00011208
			[Token(Token = "0x170003EC")]
			public System.Collections.DictionaryEntry Entry
			{
				[Token(Token = "0x6001F04")]
				[Address(RVA = "0x4B9A010", Offset = "0x4B98C10", VA = "0x184B9A010", Slot = "6")]
				get
				{
					return default(System.Collections.DictionaryEntry);
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06001F05 RID: 7941 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170003ED")]
			public object Key
			{
				[Token(Token = "0x6001F05")]
				[Address(RVA = "0x4B9A1E0", Offset = "0x4B98DE0", VA = "0x184B9A1E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06001F06 RID: 7942 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170003EE")]
			public object Value
			{
				[Token(Token = "0x6001F06")]
				[Address(RVA = "0x4B9A200", Offset = "0x4B98E00", VA = "0x184B9A200", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400105C RID: 4188
			[Token(Token = "0x400105C")]
			[FieldOffset(Offset = "0x10")]
			private MessageDictionary _methodDictionary;

			// Token: 0x0400105D RID: 4189
			[Token(Token = "0x400105D")]
			[FieldOffset(Offset = "0x18")]
			private System.Collections.IDictionaryEnumerator _hashtableEnum;

			// Token: 0x0400105E RID: 4190
			[Token(Token = "0x400105E")]
			[FieldOffset(Offset = "0x20")]
			private int _posMethod;
		}
	}
}
