using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003F0 RID: 1008
	[Token(Token = "0x20003F0")]
	public sealed class SerializationInfoEnumerator : System.Collections.IEnumerator
	{
		// Token: 0x06001F7C RID: 8060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x4BABD20", Offset = "0x4BAA920", VA = "0x184BABD20")]
		internal SerializationInfoEnumerator(string[] members, object[] info, System.Type[] types, int numItems)
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x4BABC90", Offset = "0x4BAA890", VA = "0x184BABC90", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700041E")]
		private object Current
		{
			[Token(Token = "0x6001F7E")]
			[Address(RVA = "0x4BABCC0", Offset = "0x4BAA8C0", VA = "0x184BABCC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x1700041F")]
		public SerializationEntry Current
		{
			[Token(Token = "0x6001F7F")]
			[Address(RVA = "0x4BABDA0", Offset = "0x4BAA9A0", VA = "0x184BABDA0")]
			get
			{
				return default(SerializationEntry);
			}
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x4BABCB0", Offset = "0x4BAA8B0", VA = "0x184BABCB0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000420")]
		public string Name
		{
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x4BABEC0", Offset = "0x4BAAAC0", VA = "0x184BABEC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000421")]
		public object Value
		{
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x4BABFE0", Offset = "0x4BAABE0", VA = "0x184BABFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000422")]
		public System.Type ObjectType
		{
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x4BABF50", Offset = "0x4BAAB50", VA = "0x184BABF50")]
			get
			{
				return null;
			}
		}

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x10")]
		private readonly string[] _members;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x18")]
		private readonly object[] _data;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x20")]
		private readonly System.Type[] _types;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x28")]
		private readonly int _numItems;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x2C")]
		private int _currItem;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x30")]
		private bool _current;
	}
}
