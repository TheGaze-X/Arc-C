using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		internal GroupCollection(Match match, Hashtable caps)
		{
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x170000D9")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x170000DA")]
		public int Count
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x50EA530", Offset = "0x50E9130", VA = "0x1850EA530", Slot = "32")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DB RID: 219
		[Token(Token = "0x170000DB")]
		public Group this[int groupnum]
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x50E9F70", Offset = "0x50E8B70", VA = "0x1850E9F70", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000DC RID: 220
		[Token(Token = "0x170000DC")]
		public Group this[string groupname]
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x50EA560", Offset = "0x50E9160", VA = "0x1850EA560")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x50E92B0", Offset = "0x50E7EB0", VA = "0x1850E92B0", Slot = "17")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x50E9D40", Offset = "0x50E8940", VA = "0x1850E9D40", Slot = "16")]
		private IEnumerator<Group> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x50E9710", Offset = "0x50E8310", VA = "0x1850E9710")]
		private Group GetGroup(int groupnum)
		{
			return null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x50E9330", Offset = "0x50E7F30", VA = "0x1850E9330")]
		private Group GetGroupImpl(int groupnum)
		{
			return null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x170000DD")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DE")]
		public object SyncRoot
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x50E8FD0", Offset = "0x50E7BD0", VA = "0x1850E8FD0", Slot = "31")]
		public void CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x50E90B0", Offset = "0x50E7CB0", VA = "0x1850E90B0", Slot = "14")]
		public void CopyTo(Group[] array, int arrayIndex)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x50E9DC0", Offset = "0x50E89C0", VA = "0x1850E9DC0", Slot = "6")]
		private int IndexOf(Group item)
		{
			return 0;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x50E9EB0", Offset = "0x50E8AB0", VA = "0x1850E9EB0", Slot = "7")]
		private void Insert(int index, Group item)
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x50E9F10", Offset = "0x50E8B10", VA = "0x1850E9F10", Slot = "8")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000DF")]
		private Group Item
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x50E9F70", Offset = "0x50E8B70", VA = "0x1850E9F70", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x50E9F80", Offset = "0x50E8B80", VA = "0x1850E9F80", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x50E9BC0", Offset = "0x50E87C0", VA = "0x1850E9BC0", Slot = "11")]
		private void Add(Group item)
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x50E9C20", Offset = "0x50E8820", VA = "0x1850E9C20", Slot = "12")]
		private void Clear()
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x50E9C80", Offset = "0x50E8880", VA = "0x1850E9C80", Slot = "13")]
		private bool Contains(Group item)
		{
			return default(bool);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x50E9CE0", Offset = "0x50E88E0", VA = "0x1850E9CE0", Slot = "15")]
		private bool Remove(Group item)
		{
			return default(bool);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x50E9FE0", Offset = "0x50E8BE0", VA = "0x1850E9FE0", Slot = "22")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x50EA040", Offset = "0x50E8C40", VA = "0x1850EA040", Slot = "24")]
		private void Clear()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x50EA0A0", Offset = "0x50E8CA0", VA = "0x1850EA0A0", Slot = "23")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x50EA250", Offset = "0x50E8E50", VA = "0x1850EA250", Slot = "27")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x50EA380", Offset = "0x50E8F80", VA = "0x1850EA380", Slot = "28")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x170000E0")]
		private bool IsFixedSize
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x50EA440", Offset = "0x50E9040", VA = "0x1850EA440", Slot = "29")]
		private void Remove(object value)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x50EA3E0", Offset = "0x50E8FE0", VA = "0x1850EA3E0", Slot = "30")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000E1")]
		private object Item
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x50E9F70", Offset = "0x50E8B70", VA = "0x1850E9F70", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x50EA4A0", Offset = "0x50E90A0", VA = "0x1850EA4A0", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x50EA500", Offset = "0x50E9100", VA = "0x1850EA500")]
		internal GroupCollection()
		{
		}

		// Token: 0x04000352 RID: 850
		[Token(Token = "0x4000352")]
		[FieldOffset(Offset = "0x10")]
		private readonly Match _match;

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x18")]
		private readonly Hashtable _captureMap;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x20")]
		private Group[] _groups;

		// Token: 0x020000E1 RID: 225
		[Token(Token = "0x20000E1")]
		private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
		{
			// Token: 0x060004D3 RID: 1235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x4CA8B10", Offset = "0x4CA7710", VA = "0x184CA8B10")]
			internal Enumerator(GroupCollection collection)
			{
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00003C60 File Offset: 0x00001E60
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x50E8BC0", Offset = "0x50E77C0", VA = "0x1850E8BC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000E2")]
			public Group Current
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x50E8CA0", Offset = "0x50E78A0", VA = "0x1850E8CA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000E3")]
			private object Current
			{
				[Token(Token = "0x60004D6")]
				[Address(RVA = "0x50E8CA0", Offset = "0x50E78A0", VA = "0x1850E8CA0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			[FieldOffset(Offset = "0x10")]
			private readonly GroupCollection _collection;

			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			[FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
