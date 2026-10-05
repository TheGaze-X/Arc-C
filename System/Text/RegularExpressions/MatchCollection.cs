using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
	[Serializable]
	public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x50EB9D0", Offset = "0x50EA5D0", VA = "0x1850EB9D0")]
		internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x170000E7")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60004EC")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x170000E8")]
		public int Count
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x50EBB40", Offset = "0x50EA740", VA = "0x1850EBB40", Slot = "32")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E9 RID: 233
		[Token(Token = "0x170000E9")]
		public virtual Match this[int i]
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x50EBBA0", Offset = "0x50EA7A0", VA = "0x1850EBBA0", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x50EAE60", Offset = "0x50E9A60", VA = "0x1850EAE60", Slot = "17")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x50EB190", Offset = "0x50E9D90", VA = "0x1850EB190", Slot = "16")]
		private IEnumerator<Match> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x50EAEE0", Offset = "0x50E9AE0", VA = "0x1850EAEE0")]
		private Match GetMatch(int i)
		{
			return null;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x50EAE40", Offset = "0x50E9A40", VA = "0x1850EAE40")]
		private void EnsureInitialized()
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x170000EA")]
		public bool IsSynchronized
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public object SyncRoot
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x50EAD30", Offset = "0x50E9930", VA = "0x1850EAD30", Slot = "31")]
		public void CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x50EACB0", Offset = "0x50E98B0", VA = "0x1850EACB0", Slot = "14")]
		public void CopyTo(Match[] array, int arrayIndex)
		{
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x50EB210", Offset = "0x50E9E10", VA = "0x1850EB210", Slot = "6")]
		private int IndexOf(Match item)
		{
			return 0;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x50EB280", Offset = "0x50E9E80", VA = "0x1850EB280", Slot = "7")]
		private void Insert(int index, Match item)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x50EB2E0", Offset = "0x50E9EE0", VA = "0x1850EB2E0", Slot = "8")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EC")]
		private Match Item
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x50EB340", Offset = "0x50E9F40", VA = "0x1850EB340", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0x50EB390", Offset = "0x50E9F90", VA = "0x1850EB390", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x50EB000", Offset = "0x50E9C00", VA = "0x1850EB000", Slot = "11")]
		private void Add(Match item)
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x50EB060", Offset = "0x50E9C60", VA = "0x1850EB060", Slot = "12")]
		private void Clear()
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x50EB0C0", Offset = "0x50E9CC0", VA = "0x1850EB0C0", Slot = "13")]
		private bool Contains(Match item)
		{
			return default(bool);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x50EB130", Offset = "0x50E9D30", VA = "0x1850EB130", Slot = "15")]
		private bool Remove(Match item)
		{
			return default(bool);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x50EB3F0", Offset = "0x50E9FF0", VA = "0x1850EB3F0", Slot = "22")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x50EB450", Offset = "0x50EA050", VA = "0x1850EB450", Slot = "24")]
		private void Clear()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x50EB4B0", Offset = "0x50EA0B0", VA = "0x1850EB4B0", Slot = "23")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x50EB660", Offset = "0x50EA260", VA = "0x1850EB660", Slot = "27")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x50EB820", Offset = "0x50EA420", VA = "0x1850EB820", Slot = "28")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x170000ED")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x50EB8E0", Offset = "0x50EA4E0", VA = "0x1850EB8E0", Slot = "29")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x50EB880", Offset = "0x50EA480", VA = "0x1850EB880", Slot = "30")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EE")]
		private object Item
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x50EB340", Offset = "0x50E9F40", VA = "0x1850EB340", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x50EB940", Offset = "0x50EA540", VA = "0x1850EB940", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x50EB9A0", Offset = "0x50EA5A0", VA = "0x1850EB9A0")]
		internal MatchCollection()
		{
		}

		// Token: 0x04000362 RID: 866
		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x10")]
		private readonly Regex _regex;

		// Token: 0x04000363 RID: 867
		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<Match> _matches;

		// Token: 0x04000364 RID: 868
		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x20")]
		private bool _done;

		// Token: 0x04000365 RID: 869
		[Token(Token = "0x4000365")]
		[FieldOffset(Offset = "0x28")]
		private readonly string _input;

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x30")]
		private readonly int _beginning;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x34")]
		private readonly int _length;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x38")]
		private int _startat;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x3C")]
		private int _prevlen;

		// Token: 0x020000E5 RID: 229
		[Token(Token = "0x20000E5")]
		[Serializable]
		private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
		{
			// Token: 0x0600050B RID: 1291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x4CA8B10", Offset = "0x4CA7710", VA = "0x184CA8B10")]
			internal Enumerator(MatchCollection collection)
			{
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00003DE0 File Offset: 0x00001FE0
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x50E8C50", Offset = "0x50E7850", VA = "0x1850E8C50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000EF")]
			public Match Current
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0x50E8DD0", Offset = "0x50E79D0", VA = "0x1850E8DD0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170000F0")]
			private object Current
			{
				[Token(Token = "0x600050E")]
				[Address(RVA = "0x50E8DD0", Offset = "0x50E79D0", VA = "0x1850E8DD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "8")]
			private void Reset()
			{
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			private void Dispose()
			{
			}

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x10")]
			private readonly MatchCollection _collection;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
