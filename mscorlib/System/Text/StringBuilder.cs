using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	[System.Serializable]
	[StructLayout(0)]
	public sealed class StringBuilder : System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001605 RID: 5637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001605")]
		[Address(RVA = "0x4B003E0", Offset = "0x4AFEFE0", VA = "0x184B003E0")]
		public StringBuilder()
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x4B00440", Offset = "0x4AFF040", VA = "0x184B00440")]
		public StringBuilder(int capacity)
		{
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001607")]
		[Address(RVA = "0x4B00DD0", Offset = "0x4AFF9D0", VA = "0x184B00DD0")]
		public StringBuilder(string value)
		{
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001608")]
		[Address(RVA = "0x4B00E00", Offset = "0x4AFFA00", VA = "0x184B00E00")]
		public StringBuilder(string value, int capacity)
		{
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001609")]
		[Address(RVA = "0x4B00650", Offset = "0x4AFF250", VA = "0x184B00650")]
		public StringBuilder(string value, int startIndex, int length, int capacity)
		{
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160A")]
		[Address(RVA = "0x4B00450", Offset = "0x4AFF050", VA = "0x184B00450")]
		public StringBuilder(int capacity, int maxCapacity)
		{
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160B")]
		[Address(RVA = "0x4B00960", Offset = "0x4AFF560", VA = "0x184B00960")]
		private StringBuilder(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600160C")]
		[Address(RVA = "0x4AFFC20", Offset = "0x4AFE820", VA = "0x184AFFC20", Slot = "4")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000101A0 File Offset: 0x0000E3A0
		// (set) Token: 0x0600160E RID: 5646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000235")]
		public int Capacity
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x4B00E30", Offset = "0x4AFFA30", VA = "0x184B00E30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x4B00FF0", Offset = "0x4AFFBF0", VA = "0x184B00FF0")]
			set
			{
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x17000236")]
		public int MaxCapacity
		{
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001610")]
		[Address(RVA = "0x4B00280", Offset = "0x4AFEE80", VA = "0x184B00280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001611")]
		[Address(RVA = "0x4AFFFF0", Offset = "0x4AFEBF0", VA = "0x184AFFFF0")]
		public string ToString(int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001612")]
		[Address(RVA = "0x4AFDC50", Offset = "0x4AFC850", VA = "0x184AFDC50")]
		public StringBuilder Clear()
		{
			return null;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x000101D0 File Offset: 0x0000E3D0
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000237")]
		public int Length
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x4B00F30", Offset = "0x4AFFB30", VA = "0x184B00F30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x4B01310", Offset = "0x4AFFF10", VA = "0x184B01310")]
			set
			{
			}
		}

		// Token: 0x17000238 RID: 568
		[Token(Token = "0x17000238")]
		[IndexerName("Chars")]
		public char this[int index]
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x4B00E50", Offset = "0x4AFFA50", VA = "0x184B00E50")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x4B011E0", Offset = "0x4AFFDE0", VA = "0x184B011E0")]
			set
			{
			}
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001617")]
		[Address(RVA = "0x4AFD8D0", Offset = "0x4AFC4D0", VA = "0x184AFD8D0")]
		public StringBuilder Append(char value, int repeatCount)
		{
			return null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001618")]
		[Address(RVA = "0x4AFD5F0", Offset = "0x4AFC1F0", VA = "0x184AFD5F0")]
		public StringBuilder Append(char[] value, int startIndex, int charCount)
		{
			return null;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001619")]
		[Address(RVA = "0x4AFD0B0", Offset = "0x4AFBCB0", VA = "0x184AFD0B0")]
		public StringBuilder Append(string value)
		{
			return null;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161A")]
		[Address(RVA = "0x4AFD000", Offset = "0x4AFBC00", VA = "0x184AFD000")]
		private void AppendHelper(string value)
		{
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600161B")]
		[Address(RVA = "0x4AFDA40", Offset = "0x4AFC640", VA = "0x184AFDA40")]
		public StringBuilder Append(string value, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600161C")]
		[Address(RVA = "0x4AFD570", Offset = "0x4AFC170", VA = "0x184AFD570")]
		public StringBuilder Append(StringBuilder value)
		{
			return null;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600161D")]
		[Address(RVA = "0x4AFC070", Offset = "0x4AFAC70", VA = "0x184AFC070")]
		private StringBuilder AppendCore(StringBuilder value, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600161E")]
		[Address(RVA = "0x4AFD050", Offset = "0x4AFBC50", VA = "0x184AFD050")]
		public StringBuilder AppendLine()
		{
			return null;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x4AFD080", Offset = "0x4AFBC80", VA = "0x184AFD080")]
		public StringBuilder AppendLine(string value)
		{
			return null;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001620")]
		[Address(RVA = "0x4AFDC70", Offset = "0x4AFC870", VA = "0x184AFDC70")]
		public void CopyTo(int sourceIndex, System.Span<char> destination, int count)
		{
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001621")]
		[Address(RVA = "0x4AFED70", Offset = "0x4AFD970", VA = "0x184AFED70")]
		public StringBuilder Remove(int startIndex, int length)
		{
			return null;
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001622")]
		[Address(RVA = "0x4AFD7F0", Offset = "0x4AFC3F0", VA = "0x184AFD7F0")]
		public StringBuilder Append(bool value)
		{
			return null;
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001623")]
		[Address(RVA = "0x4AFD510", Offset = "0x4AFC110", VA = "0x184AFD510")]
		public StringBuilder Append(char value)
		{
			return null;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001624")]
		[Address(RVA = "0x4AFD200", Offset = "0x4AFBE00", VA = "0x184AFD200")]
		public StringBuilder Append(byte value)
		{
			return null;
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001625")]
		[Address(RVA = "0x4AFD1B0", Offset = "0x4AFBDB0", VA = "0x184AFD1B0")]
		public StringBuilder Append(int value)
		{
			return null;
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001626")]
		[Address(RVA = "0x4AFD4C0", Offset = "0x4AFC0C0", VA = "0x184AFD4C0")]
		public StringBuilder Append(long value)
		{
			return null;
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001627")]
		[Address(RVA = "0x4AFD470", Offset = "0x4AFC070", VA = "0x184AFD470")]
		[System.CLSCompliant(false)]
		public StringBuilder Append(uint value)
		{
			return null;
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001628")]
		private StringBuilder AppendSpanFormattable<T>(T value) where T : System.IFormattable
		{
			return null;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001629")]
		[Address(RVA = "0x4AFD250", Offset = "0x4AFBE50", VA = "0x184AFD250")]
		public StringBuilder Append(object value)
		{
			return null;
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162A")]
		[Address(RVA = "0x4AFD5B0", Offset = "0x4AFC1B0", VA = "0x184AFD5B0")]
		public StringBuilder Append(char[] value)
		{
			return null;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162B")]
		[Address(RVA = "0x4AFD850", Offset = "0x4AFC450", VA = "0x184AFD850")]
		public StringBuilder Append(System.ReadOnlySpan<char> value)
		{
			return null;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162C")]
		[Address(RVA = "0x4AFE7D0", Offset = "0x4AFD3D0", VA = "0x184AFE7D0")]
		public StringBuilder Insert(int index, string value)
		{
			return null;
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162D")]
		[Address(RVA = "0x4AFE160", Offset = "0x4AFCD60", VA = "0x184AFE160")]
		public StringBuilder Insert(int index, char value)
		{
			return null;
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162E")]
		[Address(RVA = "0x4AFCF90", Offset = "0x4AFBB90", VA = "0x184AFCF90")]
		public StringBuilder AppendFormat(string format, object arg0)
		{
			return null;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600162F")]
		[Address(RVA = "0x4AFCF10", Offset = "0x4AFBB10", VA = "0x184AFCF10")]
		public StringBuilder AppendFormat(string format, object arg0, object arg1)
		{
			return null;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001630")]
		[Address(RVA = "0x4AFCD70", Offset = "0x4AFB970", VA = "0x184AFCD70")]
		public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001631")]
		[Address(RVA = "0x4AFCC90", Offset = "0x4AFB890", VA = "0x184AFCC90")]
		public StringBuilder AppendFormat(string format, params object[] args)
		{
			return null;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001632")]
		[Address(RVA = "0x4AFCE90", Offset = "0x4AFBA90", VA = "0x184AFCE90")]
		public StringBuilder AppendFormat(System.IFormatProvider provider, string format, object arg0)
		{
			return null;
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001633")]
		[Address(RVA = "0x4AFCE00", Offset = "0x4AFBA00", VA = "0x184AFCE00")]
		public StringBuilder AppendFormat(System.IFormatProvider provider, string format, object arg0, object arg1, object arg2)
		{
			return null;
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x4AFE100", Offset = "0x4AFCD00", VA = "0x184AFE100")]
		private static void FormatError()
		{
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x4AFC2D0", Offset = "0x4AFAED0", VA = "0x184AFC2D0")]
		internal StringBuilder AppendFormatHelper(System.IFormatProvider provider, string format, ParamsArray args)
		{
			return null;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001636")]
		[Address(RVA = "0x4AFFB20", Offset = "0x4AFE720", VA = "0x184AFFB20")]
		public StringBuilder Replace(string oldValue, string newValue)
		{
			return null;
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001637")]
		[Address(RVA = "0x4AFF650", Offset = "0x4AFE250", VA = "0x184AFF650")]
		public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
		{
			return null;
		}

		// Token: 0x06001638 RID: 5688 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001638")]
		[Address(RVA = "0x4AFD2C0", Offset = "0x4AFBEC0", VA = "0x184AFD2C0")]
		[System.CLSCompliant(false)]
		public unsafe StringBuilder Append(char* value, int valueCount)
		{
			return null;
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001639")]
		[Address(RVA = "0x4AFE190", Offset = "0x4AFCD90", VA = "0x184AFE190")]
		private unsafe void Insert(int index, char* value, int valueCount)
		{
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163A")]
		[Address(RVA = "0x4AFF280", Offset = "0x4AFDE80", VA = "0x184AFF280")]
		private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value)
		{
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x600163B")]
		[Address(RVA = "0x4AFFB50", Offset = "0x4AFE750", VA = "0x184AFFB50")]
		private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value)
		{
			return default(bool);
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163C")]
		[Address(RVA = "0x4AFF480", Offset = "0x4AFE080", VA = "0x184AFF480")]
		private unsafe void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count)
		{
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163D")]
		[Address(RVA = "0x4AFFD70", Offset = "0x4AFE970", VA = "0x184AFFD70")]
		private unsafe static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count)
		{
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600163E")]
		[Address(RVA = "0x4AFFE40", Offset = "0x4AFEA40", VA = "0x184AFFE40")]
		private static void ThreadSafeCopy(char[] source, int sourceIndex, System.Span<char> destination, int destinationIndex, int count)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600163F")]
		[Address(RVA = "0x4AFE0C0", Offset = "0x4AFCCC0", VA = "0x184AFE0C0")]
		private StringBuilder FindChunkForIndex(int index)
		{
			return null;
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x17000239")]
		private System.Span<char> RemainingCurrentChunk
		{
			[Token(Token = "0x6001640")]
			[Address(RVA = "0x4B00F40", Offset = "0x4AFFB40", VA = "0x184B00F40")]
			[MethodImpl(256)]
			get
			{
				return default(System.Span<char>);
			}
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001641")]
		[Address(RVA = "0x4AFED10", Offset = "0x4AFD910", VA = "0x184AFED10")]
		private StringBuilder Next(StringBuilder chunk)
		{
			return null;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001642")]
		[Address(RVA = "0x4AFDEB0", Offset = "0x4AFCAB0", VA = "0x184AFDEB0")]
		private void ExpandByABlock(int minBlockCharCount)
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x4B00D70", Offset = "0x4AFF970", VA = "0x184B00D70")]
		private StringBuilder(StringBuilder from)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x4AFE890", Offset = "0x4AFD490", VA = "0x184AFE890")]
		private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doNotMoveFollowingChars)
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x4B00CD0", Offset = "0x4AFF8D0", VA = "0x184B00CD0")]
		private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001646")]
		[Address(RVA = "0x4AFF0A0", Offset = "0x4AFDCA0", VA = "0x184AFF0A0")]
		private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk)
		{
		}

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal char[] m_ChunkChars;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal StringBuilder m_ChunkPrevious;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int m_ChunkLength;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int m_ChunkOffset;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal int m_MaxCapacity;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		internal const int DefaultCapacity = 16;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		private const string CapacityField = "Capacity";

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		private const string MaxCapacityField = "m_MaxCapacity";

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		private const string StringValueField = "m_StringValue";

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		private const string ThreadIDField = "m_currentThread";

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		internal const int MaxChunkSize = 8000;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		private const int IndexLimit = 1000000;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		private const int WidthLimit = 1000000;
	}
}
