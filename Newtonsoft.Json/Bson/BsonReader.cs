using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	[Preserve]
	public class BsonReader : JsonReader
	{
		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000060F0 File Offset: 0x000042F0
		// (set) Token: 0x06000B41 RID: 2881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022D")]
		[Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
		public bool JsonNet35BinaryCompatibility
		{
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x4211D50", Offset = "0x4210950", VA = "0x184211D50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x4211D60", Offset = "0x4210960", VA = "0x184211D60")]
			set
			{
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00006108 File Offset: 0x00004308
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022E")]
		public bool ReadRootValueAsArray
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x32F7210", Offset = "0x32F5E10", VA = "0x1832F7210")]
			set
			{
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00006120 File Offset: 0x00004320
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700022F")]
		public DateTimeKind DateTimeKindHandling
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x32F7200", Offset = "0x32F5E00", VA = "0x1832F7200")]
			get
			{
				return DateTimeKind.Unspecified;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x32F7230", Offset = "0x32F5E30", VA = "0x1832F7230")]
			set
			{
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B46")]
		[Address(RVA = "0x4E00BA0", Offset = "0x4DFF7A0", VA = "0x184E00BA0")]
		public BsonReader(Stream stream)
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B47")]
		[Address(RVA = "0x4E00AD0", Offset = "0x4DFF6D0", VA = "0x184E00AD0")]
		public BsonReader(BinaryReader reader)
		{
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x4E00CA0", Offset = "0x4DFF8A0", VA = "0x184E00CA0")]
		public BsonReader(Stream stream, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x4E009F0", Offset = "0x4DFF5F0", VA = "0x184E009F0")]
		public BsonReader(BinaryReader reader, bool readRootValueAsArray, DateTimeKind dateTimeKindHandling)
		{
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x4DFF4F0", Offset = "0x4DFE0F0", VA = "0x184DFF4F0")]
		private string ReadElement()
		{
			return null;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x4E00700", Offset = "0x4DFF300", VA = "0x184E00700", Slot = "12")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x4DFE9B0", Offset = "0x4DFD5B0", VA = "0x184DFE9B0", Slot = "22")]
		public override void Close()
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x4DFF280", Offset = "0x4DFDE80", VA = "0x184DFF280")]
		private bool ReadCodeWScope()
		{
			return default(bool);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x4DFF9F0", Offset = "0x4DFE5F0", VA = "0x184DFF9F0")]
		private bool ReadReference()
		{
			return default(bool);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x4DFF6E0", Offset = "0x4DFE2E0", VA = "0x184DFF6E0")]
		private bool ReadNormal()
		{
			return default(bool);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x4DFEF20", Offset = "0x4DFDB20", VA = "0x184DFEF20")]
		private void PopContext()
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x4DFEFE0", Offset = "0x4DFDBE0", VA = "0x184DFEFE0")]
		private void PushContext(BsonReader.ContainerContext newContext)
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x4DFF1C0", Offset = "0x4DFDDC0", VA = "0x184DFF1C0")]
		private byte ReadByte()
		{
			return 0;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x4DFFFC0", Offset = "0x4DFEBC0", VA = "0x184DFFFC0")]
		private void ReadType(BsonType type)
		{
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x4DFF050", Offset = "0x4DFDC50", VA = "0x184DFF050")]
		private byte[] ReadBinary(out BsonBinaryType binaryType)
		{
			return null;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x4DFFC60", Offset = "0x4DFE860", VA = "0x184DFFC60")]
		private string ReadString()
		{
			return null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x4DFF620", Offset = "0x4DFE220", VA = "0x184DFF620")]
		private string ReadLengthString()
		{
			return null;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x4DFEB80", Offset = "0x4DFD780", VA = "0x184DFEB80")]
		private string GetString(int length)
		{
			return null;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x4DFEAF0", Offset = "0x4DFD6F0", VA = "0x184DFEAF0")]
		private int GetLastFullCharStop(int start)
		{
			return 0;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x4DFE7C0", Offset = "0x4DFD3C0", VA = "0x184DFE7C0")]
		private int BytesInSequence(byte b)
		{
			return 0;
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x4DFEA00", Offset = "0x4DFD600", VA = "0x184DFEA00")]
		private void EnsureBuffers()
		{
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x4DFF490", Offset = "0x4DFE090", VA = "0x184DFF490")]
		private double ReadDouble()
		{
			return 0.0;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x4DFF560", Offset = "0x4DFE160", VA = "0x184DFF560")]
		private int ReadInt32()
		{
			return 0;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x4DFF5C0", Offset = "0x4DFE1C0", VA = "0x184DFF5C0")]
		private long ReadInt64()
		{
			return 0L;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x4E006A0", Offset = "0x4DFF2A0", VA = "0x184E006A0")]
		private BsonType ReadType()
		{
			return (BsonType)0;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x4DFEF00", Offset = "0x4DFDB00", VA = "0x184DFEF00")]
		private void MovePosition(int count)
		{
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x4DFF220", Offset = "0x4DFDE20", VA = "0x184DFF220")]
		private byte[] ReadBytes(int count)
		{
			return null;
		}

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		private const int MaxCharBytesSize = 128;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] SeqRange1;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] SeqRange2;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] SeqRange3;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] SeqRange4;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x78")]
		private readonly BinaryReader _reader;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<BsonReader.ContainerContext> _stack;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x88")]
		private byte[] _byteBuffer;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x90")]
		private char[] _charBuffer;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x98")]
		private BsonType _currentElementType;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x9C")]
		private BsonReader.BsonReaderState _bsonReaderState;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0xA0")]
		private BsonReader.ContainerContext _currentContext;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0xA8")]
		private bool _readRootValueAsArray;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0xA9")]
		private bool _jsonNet35BinaryCompatibility;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0xAC")]
		private DateTimeKind _dateTimeKindHandling;

		// Token: 0x02000121 RID: 289
		[Token(Token = "0x2000121")]
		private enum BsonReaderState
		{
			// Token: 0x04000440 RID: 1088
			[Token(Token = "0x4000440")]
			Normal,
			// Token: 0x04000441 RID: 1089
			[Token(Token = "0x4000441")]
			ReferenceStart,
			// Token: 0x04000442 RID: 1090
			[Token(Token = "0x4000442")]
			ReferenceRef,
			// Token: 0x04000443 RID: 1091
			[Token(Token = "0x4000443")]
			ReferenceId,
			// Token: 0x04000444 RID: 1092
			[Token(Token = "0x4000444")]
			CodeWScopeStart,
			// Token: 0x04000445 RID: 1093
			[Token(Token = "0x4000445")]
			CodeWScopeCode,
			// Token: 0x04000446 RID: 1094
			[Token(Token = "0x4000446")]
			CodeWScopeScope,
			// Token: 0x04000447 RID: 1095
			[Token(Token = "0x4000447")]
			CodeWScopeScopeObject,
			// Token: 0x04000448 RID: 1096
			[Token(Token = "0x4000448")]
			CodeWScopeScopeEnd
		}

		// Token: 0x02000122 RID: 290
		[Token(Token = "0x2000122")]
		private class ContainerContext
		{
			// Token: 0x06000B62 RID: 2914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x485B310", Offset = "0x4859F10", VA = "0x18485B310")]
			public ContainerContext(BsonType type)
			{
			}

			// Token: 0x04000449 RID: 1097
			[Token(Token = "0x4000449")]
			[FieldOffset(Offset = "0x10")]
			public readonly BsonType Type;

			// Token: 0x0400044A RID: 1098
			[Token(Token = "0x400044A")]
			[FieldOffset(Offset = "0x14")]
			public int Length;

			// Token: 0x0400044B RID: 1099
			[Token(Token = "0x400044B")]
			[FieldOffset(Offset = "0x18")]
			public int Position;
		}
	}
}
