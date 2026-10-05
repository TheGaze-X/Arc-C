using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public sealed class UploadStream : Stream
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000008")]
	public string Name
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000016 RID: 22 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x17000009")]
	private bool IsReadBufferEmpty
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x51C8490", Offset = "0x51C7090", VA = "0x1851C8490")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x51C8190", Offset = "0x51C6D90", VA = "0x1851C8190")]
	public UploadStream(string name)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x51C81C0", Offset = "0x51C6DC0", VA = "0x1851C81C0")]
	public UploadStream()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x51C79D0", Offset = "0x51C65D0", VA = "0x1851C79D0", Slot = "32")]
	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x51C8010", Offset = "0x51C6C10", VA = "0x1851C8010", Slot = "35")]
	public override void Write(byte[] buffer, int offset, int count)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x51C78A0", Offset = "0x51C64A0", VA = "0x1851C78A0", Slot = "20")]
	public override void Flush()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x51C7720", Offset = "0x51C6320", VA = "0x1851C7720", Slot = "19")]
	protected override void Dispose(bool disposing)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x51C78A0", Offset = "0x51C64A0", VA = "0x1851C78A0")]
	public void Finish()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x51C7E40", Offset = "0x51C6A40", VA = "0x1851C7E40")]
	private bool SwitchBuffers()
	{
		return default(bool);
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x1700000A")]
	public override bool CanRead
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x51C83A0", Offset = "0x51C6FA0", VA = "0x1851C83A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000020 RID: 32 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x1700000B")]
	public override bool CanSeek
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x51C83F0", Offset = "0x51C6FF0", VA = "0x1851C83F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x1700000C")]
	public override bool CanWrite
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x51C8440", Offset = "0x51C7040", VA = "0x1851C8440", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000022 RID: 34 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x1700000D")]
	public override long Length
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x51C85A0", Offset = "0x51C71A0", VA = "0x1851C85A0", Slot = "11")]
		get
		{
			return 0L;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000023 RID: 35 RVA: 0x00002190 File Offset: 0x00000390
	// (set) Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000E")]
	public override long Position
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x51C85F0", Offset = "0x51C71F0", VA = "0x1851C85F0", Slot = "12")]
		get
		{
			return 0L;
		}
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x51C8640", Offset = "0x51C7240", VA = "0x1851C8640", Slot = "13")]
		set
		{
		}
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x51C7DA0", Offset = "0x51C69A0", VA = "0x1851C7DA0", Slot = "30")]
	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x51C7DF0", Offset = "0x51C69F0", VA = "0x1851C7DF0", Slot = "31")]
	public override void SetLength(long value)
	{
	}

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	private MemoryStream ReadBuffer;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x30")]
	private MemoryStream WriteBuffer;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x38")]
	private bool noMoreData;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x40")]
	private AutoResetEvent ARE;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	private object locker;
}
