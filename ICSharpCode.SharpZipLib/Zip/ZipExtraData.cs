using System;
using System.IO;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public sealed class ZipExtraData : IDisposable
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x4A60E40", Offset = "0x4A5FA40", VA = "0x184A60E40")]
		public ZipExtraData()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x4A60DD0", Offset = "0x4A5F9D0", VA = "0x184A60DD0")]
		public ZipExtraData(byte[] data)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x4A607B0", Offset = "0x4A5F3B0", VA = "0x184A607B0")]
		public byte[] GetEntryData()
		{
			return null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4A60160", Offset = "0x4A5ED60", VA = "0x184A60160")]
		public void Clear()
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x170000D4")]
		public int Length
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x4A60EB0", Offset = "0x4A5FAB0", VA = "0x184A60EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4A60890", Offset = "0x4A5F490", VA = "0x184A60890")]
		public Stream GetStreamForTag(int tag)
		{
			return null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4A60750", Offset = "0x4A5F350", VA = "0x184A60750")]
		private ITaggedData GetData(short tag)
		{
			return null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4A601C0", Offset = "0x4A5EDC0", VA = "0x184A601C0")]
		private static ITaggedData Create(short tag, byte[] data, int offset, int count)
		{
			return null;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x170000D5")]
		public int ValueLength
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x170000D6")]
		public int CurrentReadIndex
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x170000D7")]
		public int UnreadCount
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x4A60ED0", Offset = "0x4A5FAD0", VA = "0x184A60ED0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4A60590", Offset = "0x4A5F190", VA = "0x184A60590")]
		public bool Find(int headerID)
		{
			return default(bool);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4A5FDD0", Offset = "0x4A5E9D0", VA = "0x184A5FDD0")]
		public void AddEntry(ITaggedData taggedData)
		{
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x4A5FB10", Offset = "0x4A5E710", VA = "0x184A5FB10")]
		public void AddEntry(int headerID, byte[] fieldData)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4A60D60", Offset = "0x4A5F960", VA = "0x184A60D60")]
		public void StartNewEntry()
		{
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4A600D0", Offset = "0x4A5ECD0", VA = "0x184A600D0")]
		public void AddNewEntry(int headerID)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4A5FAC0", Offset = "0x4A5E6C0", VA = "0x184A5FAC0")]
		public void AddData(byte data)
		{
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4A5F9F0", Offset = "0x4A5E5F0", VA = "0x184A5F9F0")]
		public void AddData(byte[] data)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4A60040", Offset = "0x4A5EC40", VA = "0x184A60040")]
		public void AddLeShort(int toAdd)
		{
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4A5FFA0", Offset = "0x4A5EBA0", VA = "0x184A5FFA0")]
		public void AddLeInt(int toAdd)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4A5FFE0", Offset = "0x4A5EBE0", VA = "0x184A5FFE0")]
		public void AddLeLong(long toAdd)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4A60450", Offset = "0x4A5F050", VA = "0x184A60450")]
		public bool Delete(int headerID)
		{
			return default(bool);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4A60B70", Offset = "0x4A5F770", VA = "0x184A60B70")]
		public long ReadLong()
		{
			return 0L;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4A60AE0", Offset = "0x4A5F6E0", VA = "0x184A60AE0")]
		public int ReadInt()
		{
			return 0;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4A60C80", Offset = "0x4A5F880", VA = "0x184A60C80")]
		public int ReadShort()
		{
			return 0;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4A60940", Offset = "0x4A5F540", VA = "0x184A60940")]
		public int ReadByte()
		{
			return 0;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4A60D30", Offset = "0x4A5F930", VA = "0x184A60D30")]
		public void Skip(int amount)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4A60990", Offset = "0x4A5F590", VA = "0x184A60990")]
		private void ReadCheck(int length)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4A60BC0", Offset = "0x4A5F7C0", VA = "0x184A60BC0")]
		private int ReadShortInternal()
		{
			return 0;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4A60CE0", Offset = "0x4A5F8E0", VA = "0x184A60CE0")]
		private void SetShort(ref int index, int source)
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4A60550", Offset = "0x4A5F150", VA = "0x184A60550", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x10")]
		private int _index;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x14")]
		private int _readValueStart;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x18")]
		private int _readValueLength;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x20")]
		private MemoryStream _newEntry;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _data;
	}
}
