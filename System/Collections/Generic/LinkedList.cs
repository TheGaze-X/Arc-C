using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[Serializable]
	public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x0600104A RID: 4170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104A")]
		public LinkedList()
		{
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104B")]
		protected LinkedList(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x1700034F")]
		public int Count
		{
			[Token(Token = "0x600104C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public LinkedListNode<T> First
		{
			[Token(Token = "0x600104D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x17000351")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600104E")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104F")]
		private void Add(T value)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001050")]
		public LinkedListNode<T> AddFirst(T value)
		{
			return null;
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001051")]
		public LinkedListNode<T> AddLast(T value)
		{
			return null;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001052")]
		public void AddLast(LinkedListNode<T> node)
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001053")]
		public void Clear()
		{
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x6001054")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001055")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001056")]
		public LinkedListNode<T> Find(T value)
		{
			return null;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x6001057")]
		public LinkedList<T>.Enumerator GetEnumerator()
		{
			return default(LinkedList<T>.Enumerator);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001058")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6001059")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105A")]
		public void Remove(LinkedListNode<T> node)
		{
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105B")]
		public void RemoveFirst()
		{
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105C")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105D")]
		public virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105E")]
		private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600105F")]
		private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
		{
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001060")]
		internal void InternalRemoveNode(LinkedListNode<T> node)
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001061")]
		internal void ValidateNewNode(LinkedListNode<T> node)
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001062")]
		internal void ValidateNode(LinkedListNode<T> node)
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x17000352")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6001063")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		private object SyncRoot
		{
			[Token(Token = "0x6001064")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001065")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001066")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[FieldOffset(Offset = "0x0")]
		internal LinkedListNode<T> head;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[FieldOffset(Offset = "0x0")]
		internal int count;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x0")]
		internal int version;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x0")]
		private SerializationInfo _siInfo;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		private const string VersionName = "Version";

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		private const string CountName = "Count";

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		private const string ValuesName = "Data";

		// Token: 0x02000256 RID: 598
		[Token(Token = "0x2000256")]
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001067")]
			internal Enumerator(LinkedList<T> list)
			{
			}

			// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001068")]
			private Enumerator(SerializationInfo info, StreamingContext context)
			{
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06001069 RID: 4201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000354")]
			public T Current
			{
				[Token(Token = "0x6001069")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x0600106A RID: 4202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000355")]
			private object Current
			{
				[Token(Token = "0x600106A")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600106B RID: 4203 RVA: 0x00007FF8 File Offset: 0x000061F8
			[Token(Token = "0x600106B")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600106C")]
			private void Reset()
			{
			}

			// Token: 0x0600106D RID: 4205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600106D")]
			public void Dispose()
			{
			}

			// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600106E")]
			private void GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600106F")]
			private void OnDeserialization(object sender)
			{
			}

			// Token: 0x04000860 RID: 2144
			[Token(Token = "0x4000860")]
			[FieldOffset(Offset = "0x0")]
			private LinkedList<T> _list;

			// Token: 0x04000861 RID: 2145
			[Token(Token = "0x4000861")]
			[FieldOffset(Offset = "0x0")]
			private LinkedListNode<T> _node;

			// Token: 0x04000862 RID: 2146
			[Token(Token = "0x4000862")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x04000863 RID: 2147
			[Token(Token = "0x4000863")]
			[FieldOffset(Offset = "0x0")]
			private T _current;

			// Token: 0x04000864 RID: 2148
			[Token(Token = "0x4000864")]
			[FieldOffset(Offset = "0x0")]
			private int _index;
		}
	}
}
