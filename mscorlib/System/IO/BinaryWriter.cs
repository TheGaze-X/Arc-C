using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Il2CppDummyDll;

namespace System.IO
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class BinaryWriter : System.IDisposable
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003252")]
		[Address(RVA = "0x4C763B0", Offset = "0x4C74FB0", VA = "0x184C763B0")]
		protected BinaryWriter()
		{
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003253")]
		[Address(RVA = "0x4C766F0", Offset = "0x4C752F0", VA = "0x184C766F0")]
		public BinaryWriter(Stream output)
		{
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003254")]
		[Address(RVA = "0x4C76390", Offset = "0x4C74F90", VA = "0x184C76390")]
		public BinaryWriter(Stream output, System.Text.Encoding encoding)
		{
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003255")]
		[Address(RVA = "0x4C764E0", Offset = "0x4C750E0", VA = "0x184C764E0")]
		public BinaryWriter(Stream output, System.Text.Encoding encoding, bool leaveOpen)
		{
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003256")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "5")]
		public virtual void Close()
		{
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003257")]
		[Address(RVA = "0x4C75180", Offset = "0x4C73D80", VA = "0x184C75180", Slot = "6")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06003259 RID: 12889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x4C75210", Offset = "0x4C73E10", VA = "0x184C75210", Slot = "7")]
		public virtual void Flush()
		{
		}

		// Token: 0x0600325A RID: 12890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325A")]
		[Address(RVA = "0x4C75B60", Offset = "0x4C74760", VA = "0x184C75B60", Slot = "8")]
		public virtual void Write(bool value)
		{
		}

		// Token: 0x0600325B RID: 12891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325B")]
		[Address(RVA = "0x4C758A0", Offset = "0x4C744A0", VA = "0x184C758A0", Slot = "9")]
		public virtual void Write(byte value)
		{
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x4C758A0", Offset = "0x4C744A0", VA = "0x184C758A0", Slot = "10")]
		[System.CLSCompliant(false)]
		public virtual void Write(sbyte value)
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325D")]
		[Address(RVA = "0x4C758F0", Offset = "0x4C744F0", VA = "0x184C758F0", Slot = "11")]
		public virtual void Write(byte[] buffer)
		{
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325E")]
		[Address(RVA = "0x4C760B0", Offset = "0x4C74CB0", VA = "0x184C760B0", Slot = "12")]
		public virtual void Write(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600325F")]
		[Address(RVA = "0x4C75F10", Offset = "0x4C74B10", VA = "0x184C75F10", Slot = "13")]
		public virtual void Write(char ch)
		{
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003260")]
		[Address(RVA = "0x4C759C0", Offset = "0x4C745C0", VA = "0x184C759C0", Slot = "14")]
		public virtual void Write(char[] chars)
		{
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003261")]
		[Address(RVA = "0x4C75DD0", Offset = "0x4C749D0", VA = "0x184C75DD0", Slot = "15")]
		public virtual void Write(double value)
		{
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003262")]
		[Address(RVA = "0x4C756B0", Offset = "0x4C742B0", VA = "0x184C756B0", Slot = "16")]
		public virtual void Write(short value)
		{
		}

		// Token: 0x06003263 RID: 12899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003263")]
		[Address(RVA = "0x4C75D40", Offset = "0x4C74940", VA = "0x184C75D40", Slot = "17")]
		[System.CLSCompliant(false)]
		public virtual void Write(ushort value)
		{
		}

		// Token: 0x06003264 RID: 12900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003264")]
		[Address(RVA = "0x4C75E40", Offset = "0x4C74A40", VA = "0x184C75E40", Slot = "18")]
		public virtual void Write(int value)
		{
		}

		// Token: 0x06003265 RID: 12901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003265")]
		[Address(RVA = "0x4C76130", Offset = "0x4C74D30", VA = "0x184C76130", Slot = "19")]
		[System.CLSCompliant(false)]
		public virtual void Write(uint value)
		{
		}

		// Token: 0x06003266 RID: 12902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003266")]
		[Address(RVA = "0x4C75BE0", Offset = "0x4C747E0", VA = "0x184C75BE0", Slot = "20")]
		public virtual void Write(long value)
		{
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x4C75740", Offset = "0x4C74340", VA = "0x184C75740", Slot = "21")]
		[System.CLSCompliant(false)]
		public virtual void Write(ulong value)
		{
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003268")]
		[Address(RVA = "0x4C75AF0", Offset = "0x4C746F0", VA = "0x184C75AF0", Slot = "22")]
		public virtual void Write(float value)
		{
		}

		// Token: 0x06003269 RID: 12905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003269")]
		[Address(RVA = "0x4C752D0", Offset = "0x4C73ED0", VA = "0x184C752D0", Slot = "23")]
		public virtual void Write(string value)
		{
		}

		// Token: 0x0600326A RID: 12906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600326A")]
		[Address(RVA = "0x4C75250", Offset = "0x4C73E50", VA = "0x184C75250")]
		protected void Write7BitEncodedInt(int value)
		{
		}

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly BinaryWriter Null;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Stream OutStream;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte[] _buffer;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private System.Text.Encoding _encoding;

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.Text.Encoder _encoder;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[System.Runtime.Serialization.OptionalField]
		private bool _leaveOpen;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private byte[] _largeByteBuffer;

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _maxChars;
	}
}
