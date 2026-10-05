using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[System.Serializable]
	public sealed class CharEnumerator : System.Collections.IEnumerator, System.Collections.Generic.IEnumerator<char>, System.IDisposable, System.ICloneable
	{
		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x4CA8B10", Offset = "0x4CA7710", VA = "0x184CA8B10")]
		internal CharEnumerator(string str)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x3204BC0", Offset = "0x32037C0", VA = "0x183204BC0", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x4CA89A0", Offset = "0x4CA75A0", VA = "0x184CA89A0", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x4CA8970", Offset = "0x4CA7570", VA = "0x184CA8970", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700006C")]
		private object Current
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x4CA8A00", Offset = "0x4CA7600", VA = "0x184CA8A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x1700006D")]
		public char Current
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x4CA8B80", Offset = "0x4CA7780", VA = "0x184CA8B80", Slot = "7")]
			get
			{
				return '\0';
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x4CA89F0", Offset = "0x4CA75F0", VA = "0x184CA89F0", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x4CA8B50", Offset = "0x4CA7750", VA = "0x184CA8B50")]
		internal CharEnumerator()
		{
		}

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x10")]
		private string _str;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x1C")]
		private char _currentElement;
	}
}
