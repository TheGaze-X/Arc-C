using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x20002B7")]
	internal class TextureSlotManager
	{
		// Token: 0x060012F9 RID: 4857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x5A5C200", Offset = "0x5A5AE00", VA = "0x185A5C200")]
		public TextureSlotManager()
		{
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x5A5BD20", Offset = "0x5A5A920", VA = "0x185A5BD20")]
		public void Reset()
		{
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x5A5BE20", Offset = "0x5A5AA20", VA = "0x185A5BE20")]
		public void StartNewBatch()
		{
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x60012FC")]
		[Address(RVA = "0x5A5BBF0", Offset = "0x5A5A7F0", VA = "0x185A5BBF0")]
		public int IndexOf(TextureId id)
		{
			return 0;
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x5A5BCD0", Offset = "0x5A5A8D0", VA = "0x185A5BCD0")]
		[MethodImpl(256)]
		public void MarkUsed(int slotIndex)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00009F78 File Offset: 0x00008178
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		public int FreeSlots
		{
			[Token(Token = "0x60012FE")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60012FF")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x6001300")]
		[Address(RVA = "0x5A5BB30", Offset = "0x5A5A730", VA = "0x185A5BB30")]
		public int FindOldestSlot()
		{
			return 0;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001301")]
		[Address(RVA = "0x5A5B880", Offset = "0x5A5A480", VA = "0x185A5B880")]
		public void Bind(TextureId id, int slot, MaterialPropertyBlock mat)
		{
		}

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int k_SlotCount;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] slotIds;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int textureTableId;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x10")]
		private TextureId[] m_Textures;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x18")]
		private int[] m_Tickets;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentTicket;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x24")]
		private int m_FirstUsedTicket;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x28")]
		private Vector4[] m_GpuTextures;

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[FieldOffset(Offset = "0x38")]
		internal TextureRegistry textureRegistry;
	}
}
