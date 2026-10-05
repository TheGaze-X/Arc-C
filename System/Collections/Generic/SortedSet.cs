using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	[DebuggerTypeProxy(typeof(ICollectionDebugView<>))]
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	public class SortedSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
	{
		// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001144")]
		public SortedSet()
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001145")]
		public SortedSet(IComparer<T> comparer)
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001146")]
		protected SortedSet(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x6001147")]
		internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action)
		{
			return default(bool);
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x17000399")]
		public int Count
		{
			[Token(Token = "0x6001148")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x1700039A")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6001149")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x1700039B")]
		private bool IsSynchronized
		{
			[Token(Token = "0x600114A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039C")]
		private object SyncRoot
		{
			[Token(Token = "0x600114B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114C")]
		internal virtual void VersionCheck()
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x600114D")]
		internal virtual bool IsWithinRange(T item)
		{
			return default(bool);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x600114E")]
		public bool Add(T item)
		{
			return default(bool);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600114F")]
		private void Add(T item)
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6001150")]
		internal virtual bool AddIfNotPresent(T item)
		{
			return default(bool);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6001151")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6001152")]
		internal virtual bool DoRemove(T item)
		{
			return default(bool);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001153")]
		public virtual void Clear()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6001154")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001155")]
		public void CopyTo(T[] array, int index)
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001156")]
		public void CopyTo(T[] array, int index, int count)
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001157")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6001158")]
		public SortedSet<T>.Enumerator GetEnumerator()
		{
			return default(SortedSet<T>.Enumerator);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001159")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115A")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115B")]
		private void InsertionBalance(SortedSet<T>.Node current, ref SortedSet<T>.Node parent, SortedSet<T>.Node grandParent, SortedSet<T>.Node greatGrandParent)
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115C")]
		private void ReplaceChildOrRoot(SortedSet<T>.Node parent, SortedSet<T>.Node child, SortedSet<T>.Node newChild)
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115D")]
		private void ReplaceNode(SortedSet<T>.Node match, SortedSet<T>.Node parentOfMatch, SortedSet<T>.Node successor, SortedSet<T>.Node parentOfSuccessor)
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600115E")]
		internal virtual SortedSet<T>.Node FindNode(T item)
		{
			return null;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115F")]
		internal void UpdateVersion()
		{
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001160")]
		private void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001161")]
		protected virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001162")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001163")]
		protected virtual void OnDeserialization(object sender)
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6001164")]
		private static int Log2(int value)
		{
			return 0;
		}

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x0")]
		private SortedSet<T>.Node root;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x0")]
		private IComparer<T> comparer;

		// Token: 0x04000899 RID: 2201
		[Token(Token = "0x4000899")]
		[FieldOffset(Offset = "0x0")]
		private int count;

		// Token: 0x0400089A RID: 2202
		[Token(Token = "0x400089A")]
		[FieldOffset(Offset = "0x0")]
		private int version;

		// Token: 0x0400089B RID: 2203
		[Token(Token = "0x400089B")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private object _syncRoot;

		// Token: 0x0400089C RID: 2204
		[Token(Token = "0x400089C")]
		[FieldOffset(Offset = "0x0")]
		private SerializationInfo siInfo;

		// Token: 0x0200026D RID: 621
		[Token(Token = "0x200026D")]
		[Serializable]
		internal sealed class Node
		{
			// Token: 0x06001165 RID: 4453 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001165")]
			public Node(T item, NodeColor color)
			{
			}

			// Token: 0x06001166 RID: 4454 RVA: 0x000087C0 File Offset: 0x000069C0
			[Token(Token = "0x6001166")]
			public static bool IsNonNullRed(SortedSet<T>.Node node)
			{
				return default(bool);
			}

			// Token: 0x06001167 RID: 4455 RVA: 0x000087D8 File Offset: 0x000069D8
			[Token(Token = "0x6001167")]
			public static bool IsNullOrBlack(SortedSet<T>.Node node)
			{
				return default(bool);
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700039D")]
			public T Item
			{
				[Token(Token = "0x6001168")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001169")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x0600116A RID: 4458 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600116B RID: 4459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700039E")]
			public SortedSet<T>.Node Left
			{
				[Token(Token = "0x600116A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600116B")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x0600116C RID: 4460 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600116D RID: 4461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700039F")]
			public SortedSet<T>.Node Right
			{
				[Token(Token = "0x600116C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600116D")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x0600116E RID: 4462 RVA: 0x000087F0 File Offset: 0x000069F0
			// (set) Token: 0x0600116F RID: 4463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170003A0")]
			public NodeColor Color
			{
				[Token(Token = "0x600116E")]
				[CompilerGenerated]
				get
				{
					return NodeColor.Black;
				}
				[Token(Token = "0x600116F")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06001170 RID: 4464 RVA: 0x00008808 File Offset: 0x00006A08
			[Token(Token = "0x170003A1")]
			public bool IsBlack
			{
				[Token(Token = "0x6001170")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06001171 RID: 4465 RVA: 0x00008820 File Offset: 0x00006A20
			[Token(Token = "0x170003A2")]
			public bool IsRed
			{
				[Token(Token = "0x6001171")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06001172 RID: 4466 RVA: 0x00008838 File Offset: 0x00006A38
			[Token(Token = "0x170003A3")]
			public bool Is2Node
			{
				[Token(Token = "0x6001172")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06001173 RID: 4467 RVA: 0x00008850 File Offset: 0x00006A50
			[Token(Token = "0x170003A4")]
			public bool Is4Node
			{
				[Token(Token = "0x6001173")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06001174 RID: 4468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001174")]
			public void ColorBlack()
			{
			}

			// Token: 0x06001175 RID: 4469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001175")]
			public void ColorRed()
			{
			}

			// Token: 0x06001176 RID: 4470 RVA: 0x00008868 File Offset: 0x00006A68
			[Token(Token = "0x6001176")]
			public TreeRotation GetRotation(SortedSet<T>.Node current, SortedSet<T>.Node sibling)
			{
				return TreeRotation.Left;
			}

			// Token: 0x06001177 RID: 4471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001177")]
			public SortedSet<T>.Node GetSibling(SortedSet<T>.Node node)
			{
				return null;
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001178")]
			public void Split4Node()
			{
			}

			// Token: 0x06001179 RID: 4473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001179")]
			public SortedSet<T>.Node Rotate(TreeRotation rotation)
			{
				return null;
			}

			// Token: 0x0600117A RID: 4474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117A")]
			public SortedSet<T>.Node RotateLeft()
			{
				return null;
			}

			// Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117B")]
			public SortedSet<T>.Node RotateLeftRight()
			{
				return null;
			}

			// Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117C")]
			public SortedSet<T>.Node RotateRight()
			{
				return null;
			}

			// Token: 0x0600117D RID: 4477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600117D")]
			public SortedSet<T>.Node RotateRightLeft()
			{
				return null;
			}

			// Token: 0x0600117E RID: 4478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600117E")]
			public void Merge2Nodes()
			{
			}

			// Token: 0x0600117F RID: 4479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600117F")]
			public void ReplaceChild(SortedSet<T>.Node child, SortedSet<T>.Node newChild)
			{
			}
		}

		// Token: 0x0200026E RID: 622
		[Token(Token = "0x200026E")]
		[Serializable]
		public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
		{
			// Token: 0x06001180 RID: 4480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001180")]
			internal Enumerator(SortedSet<T> set)
			{
			}

			// Token: 0x06001181 RID: 4481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001181")]
			internal Enumerator(SortedSet<T> set, bool reverse)
			{
			}

			// Token: 0x06001182 RID: 4482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001182")]
			private void GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			// Token: 0x06001183 RID: 4483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001183")]
			private void OnDeserialization(object sender)
			{
			}

			// Token: 0x06001184 RID: 4484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001184")]
			private void Initialize()
			{
			}

			// Token: 0x06001185 RID: 4485 RVA: 0x00008880 File Offset: 0x00006A80
			[Token(Token = "0x6001185")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06001186 RID: 4486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001186")]
			public void Dispose()
			{
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003A5")]
			public T Current
			{
				[Token(Token = "0x6001187")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06001188 RID: 4488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170003A6")]
			private object Current
			{
				[Token(Token = "0x6001188")]
				get
				{
					return null;
				}
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06001189 RID: 4489 RVA: 0x00008898 File Offset: 0x00006A98
			[Token(Token = "0x170003A7")]
			internal bool NotStartedOrEnded
			{
				[Token(Token = "0x6001189")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600118A RID: 4490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600118A")]
			internal void Reset()
			{
			}

			// Token: 0x0600118B RID: 4491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600118B")]
			private void Reset()
			{
			}

			// Token: 0x040008A1 RID: 2209
			[Token(Token = "0x40008A1")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SortedSet<T>.Node s_dummyNode;

			// Token: 0x040008A2 RID: 2210
			[Token(Token = "0x40008A2")]
			[FieldOffset(Offset = "0x0")]
			private SortedSet<T> _tree;

			// Token: 0x040008A3 RID: 2211
			[Token(Token = "0x40008A3")]
			[FieldOffset(Offset = "0x0")]
			private int _version;

			// Token: 0x040008A4 RID: 2212
			[Token(Token = "0x40008A4")]
			[FieldOffset(Offset = "0x0")]
			private Stack<SortedSet<T>.Node> _stack;

			// Token: 0x040008A5 RID: 2213
			[Token(Token = "0x40008A5")]
			[FieldOffset(Offset = "0x0")]
			private SortedSet<T>.Node _current;

			// Token: 0x040008A6 RID: 2214
			[Token(Token = "0x40008A6")]
			[FieldOffset(Offset = "0x0")]
			private bool _reverse;
		}
	}
}
