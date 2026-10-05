using System;
using System.Net;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib.Layers
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public class XorEncryptLayer : PacketLayerBase
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x36B20C0", Offset = "0x36B0CC0", VA = "0x1836B20C0")]
		public XorEncryptLayer()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x36B2170", Offset = "0x36B0D70", VA = "0x1836B2170")]
		public XorEncryptLayer(byte[] key)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x36B20E0", Offset = "0x36B0CE0", VA = "0x1836B20E0")]
		public XorEncryptLayer(string key)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x36B2040", Offset = "0x36B0C40", VA = "0x1836B2040")]
		public void SetKey(string key)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x36B1FA0", Offset = "0x36B0BA0", VA = "0x1836B1FA0")]
		public void SetKey(byte[] key)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x36B1F10", Offset = "0x36B0B10", VA = "0x1836B1F10", Slot = "4")]
		public override void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x36B1F10", Offset = "0x36B0B10", VA = "0x1836B1F10", Slot = "5")]
		public override void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length)
		{
		}

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _byteKey;
	}
}
