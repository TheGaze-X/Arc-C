using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	public class Gost28147Engine : IBlockCipher
	{
		// Token: 0x06001B93 RID: 7059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B93")]
		[Address(RVA = "0x52BD5A0", Offset = "0x52BC1A0", VA = "0x1852BD5A0")]
		private static void AddSBox(string sBoxName, byte[] sBox)
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B94")]
		[Address(RVA = "0x52BE7B0", Offset = "0x52BD3B0", VA = "0x1852BE7B0")]
		public Gost28147Engine()
		{
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B95")]
		[Address(RVA = "0x52BDD80", Offset = "0x52BC980", VA = "0x1852BDD80", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D3")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B96")]
			[Address(RVA = "0x52BE990", Offset = "0x52BD590", VA = "0x1852BE990", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x170003D4")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B98 RID: 7064 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x6001B98")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B99 RID: 7065 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x6001B99")]
		[Address(RVA = "0x52BE190", Offset = "0x52BCD90", VA = "0x1852BE190", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B9A RID: 7066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x52BE820", Offset = "0x52BD420", VA = "0x1852BE820")]
		private int[] generateWorkingKey(bool forEncryption, byte[] userKey)
		{
			return null;
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x52BDC30", Offset = "0x52BC830", VA = "0x1852BDC30")]
		private int Gost28147_mainStep(int n1, int key)
		{
			return 0;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x52BD8D0", Offset = "0x52BC4D0", VA = "0x1852BD8D0")]
		private void Gost28147Func(int[] workingKey, byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x52A7600", Offset = "0x52A6200", VA = "0x1852A7600")]
		private static int bytesToint(byte[] inBytes, int inOff)
		{
			return 0;
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x52A7B50", Offset = "0x52A6750", VA = "0x1852A7B50")]
		private static void intTobytes(int num, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x52BD700", Offset = "0x52BC300", VA = "0x1852BD700")]
		public static byte[] GetSBox(string sBoxName)
		{
			return null;
		}

		// Token: 0x04000ED1 RID: 3793
		[Token(Token = "0x4000ED1")]
		private const int BlockSize = 8;

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x10")]
		private int[] workingKey;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0x18")]
		private bool forEncryption;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x20")]
		private byte[] S;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] Sbox_Default;

		// Token: 0x04000ED6 RID: 3798
		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] ESbox_Test;

		// Token: 0x04000ED7 RID: 3799
		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] ESbox_A;

		// Token: 0x04000ED8 RID: 3800
		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] ESbox_B;

		// Token: 0x04000ED9 RID: 3801
		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0x20")]
		private static readonly byte[] ESbox_C;

		// Token: 0x04000EDA RID: 3802
		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0x28")]
		private static readonly byte[] ESbox_D;

		// Token: 0x04000EDB RID: 3803
		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0x30")]
		private static readonly byte[] DSbox_Test;

		// Token: 0x04000EDC RID: 3804
		[Token(Token = "0x4000EDC")]
		[FieldOffset(Offset = "0x38")]
		private static readonly byte[] DSbox_A;

		// Token: 0x04000EDD RID: 3805
		[Token(Token = "0x4000EDD")]
		[FieldOffset(Offset = "0x40")]
		private static readonly IDictionary sBoxes;
	}
}
