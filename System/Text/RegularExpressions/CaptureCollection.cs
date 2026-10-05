using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000DC RID: 220
	[Token(Token = "0x20000DC")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x50E7A50", Offset = "0x50E6650", VA = "0x1850E7A50")]
		internal CaptureCollection(Group group)
		{
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x170000CD")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x170000CE")]
		public int Count
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "32")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000CF RID: 207
		[Token(Token = "0x170000CF")]
		public Capture this[int i]
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x50E74C0", Offset = "0x50E60C0", VA = "0x1850E74C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x50E70B0", Offset = "0x50E5CB0", VA = "0x1850E70B0", Slot = "17")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x50E72B0", Offset = "0x50E5EB0", VA = "0x1850E72B0", Slot = "16")]
		private IEnumerator<Capture> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x50E6E60", Offset = "0x50E5A60", VA = "0x1850E6E60")]
		private Capture GetCapture(int i)
		{
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x50E6CC0", Offset = "0x50E58C0", VA = "0x1850E6CC0")]
		internal void ForceInitialized()
		{
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x170000D0")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public object SyncRoot
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x50E6C00", Offset = "0x50E5800", VA = "0x1850E6C00", Slot = "31")]
		public void CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x50E6A20", Offset = "0x50E5620", VA = "0x1850E6A20", Slot = "14")]
		public void CopyTo(Capture[] array, int arrayIndex)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x50E7330", Offset = "0x50E5F30", VA = "0x1850E7330", Slot = "6")]
		private int IndexOf(Capture item)
		{
			return 0;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x50E7400", Offset = "0x50E6000", VA = "0x1850E7400", Slot = "7")]
		private void Insert(int index, Capture item)
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x50E7460", Offset = "0x50E6060", VA = "0x1850E7460", Slot = "8")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D2")]
		private Capture Item
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x50E74C0", Offset = "0x50E60C0", VA = "0x1850E74C0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x50E74D0", Offset = "0x50E60D0", VA = "0x1850E74D0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x50E7130", Offset = "0x50E5D30", VA = "0x1850E7130", Slot = "11")]
		private void Add(Capture item)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x50E7190", Offset = "0x50E5D90", VA = "0x1850E7190", Slot = "12")]
		private void Clear()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x50E71F0", Offset = "0x50E5DF0", VA = "0x1850E71F0", Slot = "13")]
		private bool Contains(Capture item)
		{
			return default(bool);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x50E7250", Offset = "0x50E5E50", VA = "0x1850E7250", Slot = "15")]
		private bool Remove(Capture item)
		{
			return default(bool);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x50E7530", Offset = "0x50E6130", VA = "0x1850E7530", Slot = "22")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x50E7590", Offset = "0x50E6190", VA = "0x1850E7590", Slot = "24")]
		private void Clear()
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x50E75F0", Offset = "0x50E61F0", VA = "0x1850E75F0", Slot = "23")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x50E77A0", Offset = "0x50E63A0", VA = "0x1850E77A0", Slot = "27")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x50E78D0", Offset = "0x50E64D0", VA = "0x1850E78D0", Slot = "28")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x170000D3")]
		private bool IsFixedSize
		{
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x50E7990", Offset = "0x50E6590", VA = "0x1850E7990", Slot = "29")]
		private void Remove(object value)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x50E7930", Offset = "0x50E6530", VA = "0x1850E7930", Slot = "30")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D4")]
		private object Item
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x50E74C0", Offset = "0x50E60C0", VA = "0x1850E74C0", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x50E79F0", Offset = "0x50E65F0", VA = "0x1850E79F0", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x10")]
		private readonly Group _group;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _capcount;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x20")]
		private Capture[] _captures;

		// Token: 0x020000DD RID: 221
		[Token(Token = "0x20000DD")]
		[Serializable]
		private sealed class Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator
		{
			// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x4CA8B10", Offset = "0x4CA7710", VA = "0x184CA8B10")]
			internal Enumerator(CaptureCollection collection)
			{
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x00003B40 File Offset: 0x00001D40
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x50E8C10", Offset = "0x50E7810", VA = "0x1850E8C10", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D5")]
			public Capture Current
			{
				[Token(Token = "0x60004A9")]
				[Address(RVA = "0x50E8D40", Offset = "0x50E7940", VA = "0x1850E8D40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000D6")]
			private object Current
			{
				[Token(Token = "0x60004AA")]
				[Address(RVA = "0x50E8D40", Offset = "0x50E7940", VA = "0x1850E8D40", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0x10")]
			private readonly CaptureCollection _collection;

			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
