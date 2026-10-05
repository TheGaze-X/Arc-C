using System;
using System.IO;
using Il2CppDummyDll;
using XLua;

namespace Torappu.DataStream
{
	// Token: 0x020016C2 RID: 5826
	[Token(Token = "0x20016C2")]
	public class FileWriter : IStreamWriter, IHotfixable, IDisposable
	{
		// Token: 0x06009388 RID: 37768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009388")]
		[Address(RVA = "0x2B35B90", Offset = "0x2B34790", VA = "0x182B35B90")]
		public FileWriter(FileStream file)
		{
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009389")]
		[Address(RVA = "0x2B35320", Offset = "0x2B33F20", VA = "0x182B35320", Slot = "16")]
		public void Dispose()
		{
		}

		// Token: 0x0600938A RID: 37770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938A")]
		[Address(RVA = "0x2B353B0", Offset = "0x2B33FB0", VA = "0x182B353B0", Slot = "4")]
		public void WriteBool(bool v)
		{
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938B")]
		[Address(RVA = "0x2B35780", Offset = "0x2B34380", VA = "0x182B35780", Slot = "5")]
		public void WriteSByte(sbyte v)
		{
		}

		// Token: 0x0600938C RID: 37772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938C")]
		[Address(RVA = "0x2B35450", Offset = "0x2B34050", VA = "0x182B35450", Slot = "6")]
		public void WriteByte(byte v)
		{
		}

		// Token: 0x0600938D RID: 37773 RVA: 0x000396F0 File Offset: 0x000378F0
		[Token(Token = "0x600938D")]
		[Address(RVA = "0x2B354F0", Offset = "0x2B340F0", VA = "0x182B354F0", Slot = "13")]
		public int WriteBytes(byte[] src, int offset, int len)
		{
			return 0;
		}

		// Token: 0x0600938E RID: 37774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938E")]
		[Address(RVA = "0x2B355A0", Offset = "0x2B341A0", VA = "0x182B355A0", Slot = "7")]
		public void WriteInt16(short v)
		{
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600938F")]
		[Address(RVA = "0x2B35640", Offset = "0x2B34240", VA = "0x182B35640", Slot = "9")]
		public void WriteInt32(int v)
		{
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009390")]
		[Address(RVA = "0x2B356E0", Offset = "0x2B342E0", VA = "0x182B356E0", Slot = "11")]
		public void WriteInt64(long v)
		{
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009391")]
		[Address(RVA = "0x2B35910", Offset = "0x2B34510", VA = "0x182B35910", Slot = "14")]
		public void WriteString(string v)
		{
		}

		// Token: 0x06009392 RID: 37778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009392")]
		[Address(RVA = "0x2B35870", Offset = "0x2B34470", VA = "0x182B35870", Slot = "15")]
		public void WriteString2(string v)
		{
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009393")]
		[Address(RVA = "0x2B359B0", Offset = "0x2B345B0", VA = "0x182B359B0", Slot = "8")]
		public void WriteUint16(ushort v)
		{
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009394")]
		[Address(RVA = "0x2B35A50", Offset = "0x2B34650", VA = "0x182B35A50", Slot = "10")]
		public void WriteUint32(uint v)
		{
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009395")]
		[Address(RVA = "0x2B35AF0", Offset = "0x2B346F0", VA = "0x182B35AF0", Slot = "12")]
		public void WriteUint64(ulong v)
		{
		}

		// Token: 0x04008943 RID: 35139
		[Token(Token = "0x4008943")]
		[FieldOffset(Offset = "0x10")]
		private readonly BinaryWriter m_file;

		// Token: 0x04008944 RID: 35140
		[Token(Token = "0x4008944")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04008945 RID: 35141
		[Token(Token = "0x4008945")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04008946 RID: 35142
		[Token(Token = "0x4008946")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_WriteBool;

		// Token: 0x04008947 RID: 35143
		[Token(Token = "0x4008947")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_WriteSByte;

		// Token: 0x04008948 RID: 35144
		[Token(Token = "0x4008948")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_WriteByte;

		// Token: 0x04008949 RID: 35145
		[Token(Token = "0x4008949")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_WriteBytes;

		// Token: 0x0400894A RID: 35146
		[Token(Token = "0x400894A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_WriteInt16;

		// Token: 0x0400894B RID: 35147
		[Token(Token = "0x400894B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_WriteInt32;

		// Token: 0x0400894C RID: 35148
		[Token(Token = "0x400894C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_WriteInt64;

		// Token: 0x0400894D RID: 35149
		[Token(Token = "0x400894D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_WriteString;

		// Token: 0x0400894E RID: 35150
		[Token(Token = "0x400894E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_WriteString2;

		// Token: 0x0400894F RID: 35151
		[Token(Token = "0x400894F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_WriteUint16;

		// Token: 0x04008950 RID: 35152
		[Token(Token = "0x4008950")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_WriteUint32;

		// Token: 0x04008951 RID: 35153
		[Token(Token = "0x4008951")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_WriteUint64;
	}
}
