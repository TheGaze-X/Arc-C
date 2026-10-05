using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Utils
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	public class NetSerializer
	{
		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		public void RegisterNestedType<T>() where T : struct, INetSerializable
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		public void RegisterNestedType<T>(Func<T> constructor) where T : class, INetSerializable
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		public void RegisterNestedType<T>(Action<NetDataWriter, T> writer, Func<NetDataReader, T> reader)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x36B04C0", Offset = "0x36AF0C0", VA = "0x1836B04C0")]
		public NetSerializer()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x36B0420", Offset = "0x36AF020", VA = "0x1836B0420")]
		public NetSerializer(int maxStringLength)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000259")]
		private NetSerializer.ClassInfo<T> RegisterInternal<T>()
		{
			return null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		public void Register<T>()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025B")]
		public T Deserialize<T>(NetDataReader reader) where T : class, new()
		{
			return null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x600025C")]
		public bool Deserialize<T>(NetDataReader reader, T target) where T : class, new()
		{
			return default(bool);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		public void Serialize<T>(NetDataWriter writer, T obj) where T : class, new()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600025E")]
		public byte[] Serialize<T>(T obj) where T : class, new()
		{
			return null;
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x10")]
		private NetDataWriter _writer;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _maxStringLength;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<Type, NetSerializer.CustomType> _registeredTypes;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		private enum CallType
		{
			// Token: 0x04000177 RID: 375
			[Token(Token = "0x4000177")]
			Basic,
			// Token: 0x04000178 RID: 376
			[Token(Token = "0x4000178")]
			Array,
			// Token: 0x04000179 RID: 377
			[Token(Token = "0x4000179")]
			List
		}

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		private abstract class FastCall<T>
		{
			// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025F")]
			public virtual void Init(MethodInfo getMethod, MethodInfo setMethod, NetSerializer.CallType type)
			{
			}

			// Token: 0x06000260 RID: 608
			[Token(Token = "0x6000260")]
			public abstract void Read(T inf, NetDataReader r);

			// Token: 0x06000261 RID: 609
			[Token(Token = "0x6000261")]
			public abstract void Write(T inf, NetDataWriter w);

			// Token: 0x06000262 RID: 610
			[Token(Token = "0x6000262")]
			public abstract void ReadArray(T inf, NetDataReader r);

			// Token: 0x06000263 RID: 611
			[Token(Token = "0x6000263")]
			public abstract void WriteArray(T inf, NetDataWriter w);

			// Token: 0x06000264 RID: 612
			[Token(Token = "0x6000264")]
			public abstract void ReadList(T inf, NetDataReader r);

			// Token: 0x06000265 RID: 613
			[Token(Token = "0x6000265")]
			public abstract void WriteList(T inf, NetDataWriter w);

			// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000266")]
			protected FastCall()
			{
			}

			// Token: 0x0400017A RID: 378
			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x0")]
			public NetSerializer.CallType Type;
		}

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		private abstract class FastCallSpecific<TClass, TProperty> : NetSerializer.FastCall<TClass>
		{
			// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000267")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000268")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000269")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026A")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x0600026B RID: 619 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x600026B")]
			protected TProperty[] ReadArrayHelper(TClass inf, NetDataReader r)
			{
				return null;
			}

			// Token: 0x0600026C RID: 620 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x600026C")]
			protected TProperty[] WriteArrayHelper(TClass inf, NetDataWriter w)
			{
				return null;
			}

			// Token: 0x0600026D RID: 621 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x600026D")]
			protected List<TProperty> ReadListHelper(TClass inf, NetDataReader r, out int len)
			{
				return null;
			}

			// Token: 0x0600026E RID: 622 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x600026E")]
			protected List<TProperty> WriteListHelper(TClass inf, NetDataWriter w, out int len)
			{
				return null;
			}

			// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600026F")]
			public override void Init(MethodInfo getMethod, MethodInfo setMethod, NetSerializer.CallType type)
			{
			}

			// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000270")]
			protected FastCallSpecific()
			{
			}

			// Token: 0x0400017B RID: 379
			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty> Getter;

			// Token: 0x0400017C RID: 380
			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty> Setter;

			// Token: 0x0400017D RID: 381
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x0")]
			protected Func<TClass, TProperty[]> GetterArr;

			// Token: 0x0400017E RID: 382
			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x0")]
			protected Action<TClass, TProperty[]> SetterArr;

			// Token: 0x0400017F RID: 383
			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x0")]
			protected Func<TClass, List<TProperty>> GetterList;

			// Token: 0x04000180 RID: 384
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x0")]
			protected Action<TClass, List<TProperty>> SetterList;
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		private abstract class FastCallSpecificAuto<TClass, TProperty> : NetSerializer.FastCallSpecific<TClass, TProperty>
		{
			// Token: 0x06000271 RID: 625
			[Token(Token = "0x6000271")]
			protected abstract void ElementRead(NetDataReader r, out TProperty prop);

			// Token: 0x06000272 RID: 626
			[Token(Token = "0x6000272")]
			protected abstract void ElementWrite(NetDataWriter w, ref TProperty prop);

			// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000273")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000274")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000275")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000276")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000277")]
			protected FastCallSpecificAuto()
			{
			}
		}

		// Token: 0x0200005B RID: 91
		[Token(Token = "0x200005B")]
		private sealed class FastCallStatic<TClass, TProperty> : NetSerializer.FastCallSpecific<TClass, TProperty>
		{
			// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000278")]
			public FastCallStatic(Action<NetDataWriter, TProperty> write, Func<NetDataReader, TProperty> read)
			{
			}

			// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000279")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027A")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027B")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027C")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027D")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027E")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x04000181 RID: 385
			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			// Token: 0x04000182 RID: 386
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		private sealed class FastCallStruct<TClass, TProperty> : NetSerializer.FastCallSpecific<TClass, TProperty> where TProperty : struct, INetSerializable
		{
			// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600027F")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000280")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000281")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000282")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000283")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000284")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000285")]
			public FastCallStruct()
			{
			}

			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x0")]
			private TProperty _p;
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		private sealed class FastCallClass<TClass, TProperty> : NetSerializer.FastCallSpecific<TClass, TProperty> where TProperty : class, INetSerializable
		{
			// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000286")]
			public FastCallClass(Func<TProperty> constructor)
			{
			}

			// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000287")]
			public override void Read(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000288")]
			public override void Write(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000289")]
			public override void ReadList(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028A")]
			public override void WriteList(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028B")]
			public override void ReadArray(TClass inf, NetDataReader r)
			{
			}

			// Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028C")]
			public override void WriteArray(TClass inf, NetDataWriter w)
			{
			}

			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;
		}

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		private class IntSerializer<T> : NetSerializer.FastCallSpecific<T, int>
		{
			// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028D")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028E")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600028F")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000290")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000291")]
			public IntSerializer()
			{
			}
		}

		// Token: 0x0200005F RID: 95
		[Token(Token = "0x200005F")]
		private class UIntSerializer<T> : NetSerializer.FastCallSpecific<T, uint>
		{
			// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000292")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000293")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000294")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000295")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000296")]
			public UIntSerializer()
			{
			}
		}

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		private class ShortSerializer<T> : NetSerializer.FastCallSpecific<T, short>
		{
			// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000297")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000298")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x06000299 RID: 665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000299")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029A")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029B")]
			public ShortSerializer()
			{
			}
		}

		// Token: 0x02000061 RID: 97
		[Token(Token = "0x2000061")]
		private class UShortSerializer<T> : NetSerializer.FastCallSpecific<T, ushort>
		{
			// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029C")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029D")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029E")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029F")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A0")]
			public UShortSerializer()
			{
			}
		}

		// Token: 0x02000062 RID: 98
		[Token(Token = "0x2000062")]
		private class LongSerializer<T> : NetSerializer.FastCallSpecific<T, long>
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A1")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A2")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A3")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A4")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A5")]
			public LongSerializer()
			{
			}
		}

		// Token: 0x02000063 RID: 99
		[Token(Token = "0x2000063")]
		private class ULongSerializer<T> : NetSerializer.FastCallSpecific<T, ulong>
		{
			// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A6")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A7")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A8")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A9")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AA")]
			public ULongSerializer()
			{
			}
		}

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		private class ByteSerializer<T> : NetSerializer.FastCallSpecific<T, byte>
		{
			// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AB")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AC")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AD")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AE")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002AF")]
			public ByteSerializer()
			{
			}
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		private class SByteSerializer<T> : NetSerializer.FastCallSpecific<T, sbyte>
		{
			// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B0")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002B1 RID: 689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B1")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B2")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B3")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B4")]
			public SByteSerializer()
			{
			}
		}

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		private class FloatSerializer<T> : NetSerializer.FastCallSpecific<T, float>
		{
			// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B5")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B6")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B7")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B8")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002B9")]
			public FloatSerializer()
			{
			}
		}

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		private class DoubleSerializer<T> : NetSerializer.FastCallSpecific<T, double>
		{
			// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BA")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BB")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BC")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BD")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BE")]
			public DoubleSerializer()
			{
			}
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		private class BoolSerializer<T> : NetSerializer.FastCallSpecific<T, bool>
		{
			// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002BF")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C0")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C1")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C2")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C3")]
			public BoolSerializer()
			{
			}
		}

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		private class CharSerializer<T> : NetSerializer.FastCallSpecificAuto<T, char>
		{
			// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C4")]
			protected override void ElementWrite(NetDataWriter w, ref char prop)
			{
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C5")]
			protected override void ElementRead(NetDataReader r, out char prop)
			{
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C6")]
			public CharSerializer()
			{
			}
		}

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		private class IPEndPointSerializer<T> : NetSerializer.FastCallSpecificAuto<T, IPEndPoint>
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C7")]
			protected override void ElementWrite(NetDataWriter w, ref IPEndPoint prop)
			{
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C8")]
			protected override void ElementRead(NetDataReader r, out IPEndPoint prop)
			{
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002C9")]
			public IPEndPointSerializer()
			{
			}
		}

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		private class StringSerializer<T> : NetSerializer.FastCallSpecific<T, string>
		{
			// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CA")]
			public StringSerializer(int maxLength)
			{
			}

			// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CB")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CC")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CD")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CE")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _maxLength;
		}

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		private class EnumByteSerializer<T> : NetSerializer.FastCall<T>
		{
			// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002CF")]
			public EnumByteSerializer(PropertyInfo property, Type propertyType)
			{
			}

			// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D0")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D1")]
			public override void Write(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D2")]
			public override void ReadArray(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D3")]
			public override void WriteArray(T inf, NetDataWriter w)
			{
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D4")]
			public override void ReadList(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D5")]
			public override void WriteList(T inf, NetDataWriter w)
			{
			}

			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x0")]
			protected readonly PropertyInfo Property;

			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x0")]
			protected readonly Type PropertyType;
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		private class EnumIntSerializer<T> : NetSerializer.EnumByteSerializer<T>
		{
			// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D6")]
			public EnumIntSerializer(PropertyInfo property, Type propertyType)
			{
			}

			// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D7")]
			public override void Read(T inf, NetDataReader r)
			{
			}

			// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D8")]
			public override void Write(T inf, NetDataWriter w)
			{
			}
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		private sealed class ClassInfo<T>
		{
			// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002D9")]
			public ClassInfo(List<NetSerializer.FastCall<T>> serializers)
			{
			}

			// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DA")]
			public void Write(T obj, NetDataWriter writer)
			{
			}

			// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DB")]
			public void Read(T obj, NetDataReader reader)
			{
			}

			// Token: 0x04000188 RID: 392
			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x0")]
			public static NetSerializer.ClassInfo<T> Instance;

			// Token: 0x04000189 RID: 393
			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x0")]
			private readonly NetSerializer.FastCall<T>[] _serializers;

			// Token: 0x0400018A RID: 394
			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x0")]
			private readonly int _membersCount;
		}

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		private abstract class CustomType
		{
			// Token: 0x060002DC RID: 732
			[Token(Token = "0x60002DC")]
			public abstract NetSerializer.FastCall<T> Get<T>();

			// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected CustomType()
			{
			}
		}

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		private sealed class CustomTypeStruct<TProperty> : NetSerializer.CustomType where TProperty : struct, INetSerializable
		{
			// Token: 0x060002DE RID: 734 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x60002DE")]
			public override NetSerializer.FastCall<T> Get<T>()
			{
				return null;
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002DF")]
			public CustomTypeStruct()
			{
			}
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		private sealed class CustomTypeClass<TProperty> : NetSerializer.CustomType where TProperty : class, INetSerializable
		{
			// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002E0")]
			public CustomTypeClass(Func<TProperty> constructor)
			{
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x60002E1")]
			public override NetSerializer.FastCall<T> Get<T>()
			{
				return null;
			}

			// Token: 0x0400018B RID: 395
			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<TProperty> _constructor;
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		private sealed class CustomTypeStatic<TProperty> : NetSerializer.CustomType
		{
			// Token: 0x060002E2 RID: 738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002E2")]
			public CustomTypeStatic(Action<NetDataWriter, TProperty> writer, Func<NetDataReader, TProperty> reader)
			{
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x60002E3")]
			public override NetSerializer.FastCall<T> Get<T>()
			{
				return null;
			}

			// Token: 0x0400018C RID: 396
			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x0")]
			private readonly Action<NetDataWriter, TProperty> _writer;

			// Token: 0x0400018D RID: 397
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x0")]
			private readonly Func<NetDataReader, TProperty> _reader;
		}
	}
}
