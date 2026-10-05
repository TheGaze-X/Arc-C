using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200065A RID: 1626
	[Token(Token = "0x200065A")]
	[System.Serializable]
	public abstract class TextReader : System.MarshalByRefObject, System.IDisposable
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TextReader()
		{
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E3")]
		[Address(RVA = "0x4C897E0", Offset = "0x4C883E0", VA = "0x184C897E0", Slot = "7")]
		public virtual void Close()
		{
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E4")]
		[Address(RVA = "0x4C89850", Offset = "0x4C88450", VA = "0x184C89850", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0001A6E8 File Offset: 0x000188E8
		[Token(Token = "0x60030E6")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "9")]
		public virtual int Peek()
		{
			return 0;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0001A700 File Offset: 0x00018900
		[Token(Token = "0x60030E7")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "10")]
		public virtual int Read()
		{
			return 0;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0001A718 File Offset: 0x00018918
		[Token(Token = "0x60030E8")]
		[Address(RVA = "0x4C8A110", Offset = "0x4C88D10", VA = "0x184C8A110", Slot = "11")]
		public virtual int Read(char[] buffer, int index, int count)
		{
			return 0;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0001A730 File Offset: 0x00018930
		[Token(Token = "0x60030E9")]
		[Address(RVA = "0x4C89EB0", Offset = "0x4C88AB0", VA = "0x184C89EB0", Slot = "12")]
		public virtual int Read(System.Span<char> buffer)
		{
			return 0;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030EA")]
		[Address(RVA = "0x4C89D80", Offset = "0x4C88980", VA = "0x184C89D80", Slot = "13")]
		public virtual string ReadToEnd()
		{
			return null;
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030EB")]
		[Address(RVA = "0x4C89B30", Offset = "0x4C88730", VA = "0x184C89B30", Slot = "14")]
		public virtual string ReadLine()
		{
			return null;
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030EC")]
		[Address(RVA = "0x4C89C70", Offset = "0x4C88870", VA = "0x184C89C70", Slot = "15")]
		public virtual System.Threading.Tasks.Task<string> ReadToEndAsync()
		{
			return null;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0001A748 File Offset: 0x00018948
		[Token(Token = "0x60030ED")]
		[Address(RVA = "0x4C898C0", Offset = "0x4C884C0", VA = "0x184C898C0", Slot = "16")]
		internal virtual System.Threading.Tasks.ValueTask<int> ReadAsyncInternal(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
			return default(System.Threading.Tasks.ValueTask<int>);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60030EE")]
		[Address(RVA = "0x4C8A350", Offset = "0x4C88F50", VA = "0x184C8A350")]
		public static TextReader Synchronized(TextReader reader)
		{
			return null;
		}

		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TextReader Null;

		// Token: 0x0200065B RID: 1627
		[Token(Token = "0x200065B")]
		[System.Serializable]
		private sealed class NullTextReader : TextReader
		{
			// Token: 0x060030F0 RID: 12528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030F0")]
			[Address(RVA = "0x4C7FCB0", Offset = "0x4C7E8B0", VA = "0x184C7FCB0")]
			public NullTextReader()
			{
			}

			// Token: 0x060030F1 RID: 12529 RVA: 0x0001A760 File Offset: 0x00018960
			[Token(Token = "0x60030F1")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060030F2 RID: 12530 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030F2")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "14")]
			public override string ReadLine()
			{
				return null;
			}
		}

		// Token: 0x0200065C RID: 1628
		[Token(Token = "0x200065C")]
		[System.Serializable]
		internal sealed class SyncTextReader : TextReader
		{
			// Token: 0x060030F3 RID: 12531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030F3")]
			[Address(RVA = "0x4C890F0", Offset = "0x4C87CF0", VA = "0x184C890F0")]
			internal SyncTextReader(TextReader t)
			{
			}

			// Token: 0x060030F4 RID: 12532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030F4")]
			[Address(RVA = "0x4C88E50", Offset = "0x4C87A50", VA = "0x184C88E50", Slot = "7")]
			[MethodImpl(32)]
			public override void Close()
			{
			}

			// Token: 0x060030F5 RID: 12533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030F5")]
			[Address(RVA = "0x4C88E90", Offset = "0x4C87A90", VA = "0x184C88E90", Slot = "8")]
			[MethodImpl(32)]
			protected override void Dispose(bool disposing)
			{
			}

			// Token: 0x060030F6 RID: 12534 RVA: 0x0001A778 File Offset: 0x00018978
			[Token(Token = "0x60030F6")]
			[Address(RVA = "0x4AB8610", Offset = "0x4AB7210", VA = "0x184AB8610", Slot = "9")]
			[MethodImpl(32)]
			public override int Peek()
			{
				return 0;
			}

			// Token: 0x060030F7 RID: 12535 RVA: 0x0001A790 File Offset: 0x00018990
			[Token(Token = "0x60030F7")]
			[Address(RVA = "0x4C890A0", Offset = "0x4C87CA0", VA = "0x184C890A0", Slot = "10")]
			[MethodImpl(32)]
			public override int Read()
			{
				return 0;
			}

			// Token: 0x060030F8 RID: 12536 RVA: 0x0001A7A8 File Offset: 0x000189A8
			[Token(Token = "0x60030F8")]
			[Address(RVA = "0x4C89020", Offset = "0x4C87C20", VA = "0x184C89020", Slot = "11")]
			[MethodImpl(32)]
			public override int Read(char[] buffer, int index, int count)
			{
				return 0;
			}

			// Token: 0x060030F9 RID: 12537 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030F9")]
			[Address(RVA = "0x4C88EF0", Offset = "0x4C87AF0", VA = "0x184C88EF0", Slot = "14")]
			[MethodImpl(32)]
			public override string ReadLine()
			{
				return null;
			}

			// Token: 0x060030FA RID: 12538 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030FA")]
			[Address(RVA = "0x4C88FD0", Offset = "0x4C87BD0", VA = "0x184C88FD0", Slot = "13")]
			[MethodImpl(32)]
			public override string ReadToEnd()
			{
				return null;
			}

			// Token: 0x060030FB RID: 12539 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60030FB")]
			[Address(RVA = "0x4C88F40", Offset = "0x4C87B40", VA = "0x184C88F40", Slot = "15")]
			[MethodImpl(32)]
			public override System.Threading.Tasks.Task<string> ReadToEndAsync()
			{
				return null;
			}

			// Token: 0x04001B0A RID: 6922
			[Token(Token = "0x4001B0A")]
			[FieldOffset(Offset = "0x18")]
			internal readonly TextReader _in;
		}
	}
}
