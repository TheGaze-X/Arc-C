using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004DE RID: 1246
	[Token(Token = "0x20004DE")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class ResourceReader : IResourceReader, System.Collections.IEnumerable, System.IDisposable
	{
		// Token: 0x060023EF RID: 9199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x4BE3FF0", Offset = "0x4BE2BF0", VA = "0x184BE3FF0")]
		internal ResourceReader(System.IO.Stream stream, System.Collections.Generic.Dictionary<string, ResourceLocator> resCache)
		{
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x4BDFFD0", Offset = "0x4BDEBD0", VA = "0x184BDFFD0", Slot = "4")]
		public void Close()
		{
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x4BE07B0", Offset = "0x4BDF3B0", VA = "0x184BE07B0", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x4BE06E0", Offset = "0x4BDF2E0", VA = "0x184BE06E0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x4BE1E20", Offset = "0x4BE0A20", VA = "0x184BE1E20")]
		internal unsafe static int ReadUnalignedI4(int* p)
		{
			return 0;
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x4BE1E40", Offset = "0x4BE0A40", VA = "0x184BE1E40")]
		private void SkipString()
		{
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x4BE1160", Offset = "0x4BDFD60", VA = "0x184BE1160")]
		private int GetNameHash(int index)
		{
			return 0;
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00014478 File Offset: 0x00012678
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x4BE11D0", Offset = "0x4BDFDD0", VA = "0x184BE11D0")]
		private int GetNamePosition(int index)
		{
			return 0;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x4BE1070", Offset = "0x4BDFC70", VA = "0x184BE1070", Slot = "6")]
		private System.Collections.IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x4BE1070", Offset = "0x4BDFC70", VA = "0x184BE1070", Slot = "5")]
		public System.Collections.IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x4BE0FF0", Offset = "0x4BDFBF0", VA = "0x184BE0FF0")]
		internal ResourceReader.ResourceEnumerator GetEnumeratorInternal()
		{
			return null;
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x4BE07C0", Offset = "0x4BDF3C0", VA = "0x184BE07C0")]
		internal int FindPosForResource(string name)
		{
			return 0;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x4BE00A0", Offset = "0x4BDECA0", VA = "0x184BE00A0")]
		private bool CompareStringEqualsName(string name)
		{
			return default(bool);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x4BDF6B0", Offset = "0x4BDE2B0", VA = "0x184BDF6B0")]
		private string AllocateStringForNameIndex(int index, out int dataOffset)
		{
			return null;
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x4BE1310", Offset = "0x4BDFF10", VA = "0x184BE1310")]
		private object GetValueForNameIndex(int index)
		{
			return null;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x4BE1910", Offset = "0x4BE0510", VA = "0x184BE1910")]
		internal string LoadString(int pos)
		{
			return null;
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x4BE1840", Offset = "0x4BE0440", VA = "0x184BE1840")]
		internal object LoadObject(int pos)
		{
			return null;
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x4BE1870", Offset = "0x4BE0470", VA = "0x184BE1870")]
		internal object LoadObject(int pos, out ResourceTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x4BE1620", Offset = "0x4BE0220", VA = "0x184BE1620")]
		internal object LoadObjectV1(int pos)
		{
			return null;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x4BE1F40", Offset = "0x4BE0B40", VA = "0x184BE1F40")]
		private object _LoadObjectV1(int pos)
		{
			return null;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x4BE1730", Offset = "0x4BE0330", VA = "0x184BE1730")]
		internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x4BE2820", Offset = "0x4BE1420", VA = "0x184BE2820")]
		private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x4BE04F0", Offset = "0x4BDF0F0", VA = "0x184BE04F0")]
		private object DeserializeObject(int typeIndex)
		{
			return null;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x4BE1C80", Offset = "0x4BE0880", VA = "0x184BE1C80")]
		private void ReadResources()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x4BE33D0", Offset = "0x4BE1FD0", VA = "0x184BE33D0")]
		private void _ReadResources()
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x4BE0CC0", Offset = "0x4BDF8C0", VA = "0x184BE0CC0")]
		private RuntimeType FindType(int typeIndex)
		{
			return null;
		}

		// Token: 0x0400146E RID: 5230
		[Token(Token = "0x400146E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private System.IO.BinaryReader _store;

		// Token: 0x0400146F RID: 5231
		[Token(Token = "0x400146F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal System.Collections.Generic.Dictionary<string, ResourceLocator> _resCache;

		// Token: 0x04001470 RID: 5232
		[Token(Token = "0x4001470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _nameSectionOffset;

		// Token: 0x04001471 RID: 5233
		[Token(Token = "0x4001471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long _dataSectionOffset;

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int[] _nameHashes;

		// Token: 0x04001473 RID: 5235
		[Token(Token = "0x4001473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private unsafe int* _nameHashesPtr;

		// Token: 0x04001474 RID: 5236
		[Token(Token = "0x4001474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int[] _namePositions;

		// Token: 0x04001475 RID: 5237
		[Token(Token = "0x4001475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private unsafe int* _namePositionsPtr;

		// Token: 0x04001476 RID: 5238
		[Token(Token = "0x4001476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RuntimeType[] _typeTable;

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int[] _typeNamePositions;

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x4001478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _objFormatter;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _numResources;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private System.IO.UnmanagedMemoryStream _ums;

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _version;

		// Token: 0x020004DF RID: 1247
		[Token(Token = "0x20004DF")]
		internal sealed class ResourceEnumerator : System.Collections.IDictionaryEnumerator, System.Collections.IEnumerator
		{
			// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002409")]
			[Address(RVA = "0x4BDC600", Offset = "0x4BDB200", VA = "0x184BDC600")]
			internal ResourceEnumerator(ResourceReader reader)
			{
			}

			// Token: 0x0600240A RID: 9226 RVA: 0x000144C0 File Offset: 0x000126C0
			[Token(Token = "0x600240A")]
			[Address(RVA = "0x4BDC510", Offset = "0x4BDB110", VA = "0x184BDC510", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170004A5 RID: 1189
			// (get) Token: 0x0600240B RID: 9227 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A5")]
			public object Key
			{
				[Token(Token = "0x600240B")]
				[Address(RVA = "0x4BDCAB0", Offset = "0x4BDB6B0", VA = "0x184BDCAB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004A6 RID: 1190
			// (get) Token: 0x0600240C RID: 9228 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A6")]
			public object Current
			{
				[Token(Token = "0x600240C")]
				[Address(RVA = "0x4BDC640", Offset = "0x4BDB240", VA = "0x184BDC640", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x170004A7 RID: 1191
			// (get) Token: 0x0600240D RID: 9229 RVA: 0x000144D8 File Offset: 0x000126D8
			[Token(Token = "0x170004A7")]
			internal int DataPosition
			{
				[Token(Token = "0x600240D")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170004A8 RID: 1192
			// (get) Token: 0x0600240E RID: 9230 RVA: 0x000144F0 File Offset: 0x000126F0
			[Token(Token = "0x170004A8")]
			public System.Collections.DictionaryEntry Entry
			{
				[Token(Token = "0x600240E")]
				[Address(RVA = "0x4BDC6A0", Offset = "0x4BDB2A0", VA = "0x184BDC6A0", Slot = "6")]
				get
				{
					return default(System.Collections.DictionaryEntry);
				}
			}

			// Token: 0x170004A9 RID: 1193
			// (get) Token: 0x0600240F RID: 9231 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x170004A9")]
			public object Value
			{
				[Token(Token = "0x600240F")]
				[Address(RVA = "0x4BDCC20", Offset = "0x4BDB820", VA = "0x184BDCC20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002410")]
			[Address(RVA = "0x4BDC560", Offset = "0x4BDB160", VA = "0x184BDC560", Slot = "9")]
			public void Reset()
			{
			}

			// Token: 0x0400147C RID: 5244
			[Token(Token = "0x400147C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ResourceReader _reader;

			// Token: 0x0400147D RID: 5245
			[Token(Token = "0x400147D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private bool _currentIsValid;

			// Token: 0x0400147E RID: 5246
			[Token(Token = "0x400147E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int _currentName;

			// Token: 0x0400147F RID: 5247
			[Token(Token = "0x400147F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _dataPosition;
		}
	}
}
