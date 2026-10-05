using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.SocketNetwork
{
	// Token: 0x02001499 RID: 5273
	[Token(Token = "0x2001499")]
	public abstract class Protocol : IHotfixable
	{
		// Token: 0x060079E2 RID: 31202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E2")]
		[Address(RVA = "0x2644AE0", Offset = "0x26436E0", VA = "0x182644AE0")]
		protected Protocol(uint pid)
		{
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x00036B10 File Offset: 0x00034D10
		// (set) Token: 0x060079E4 RID: 31204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E8E")]
		public uint id
		{
			[Token(Token = "0x60079E3")]
			[Address(RVA = "0x2644B90", Offset = "0x2643790", VA = "0x182644B90")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60079E4")]
			[Address(RVA = "0x2644BF0", Offset = "0x26437F0", VA = "0x182644BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060079E5 RID: 31205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E5")]
		[Address(RVA = "0x2644940", Offset = "0x2643540", VA = "0x182644940")]
		public void ReadFrom(IStreamReader bytes)
		{
		}

		// Token: 0x060079E6 RID: 31206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E6")]
		[Address(RVA = "0x2644A50", Offset = "0x2643650", VA = "0x182644A50")]
		public void WriteTo(IStreamWriter bytes)
		{
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E7")]
		[Address(RVA = "0x26449D0", Offset = "0x26435D0", VA = "0x1826449D0")]
		public void Recycle()
		{
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E8")]
		[Address(RVA = "0x2636E20", Offset = "0x2635A20", VA = "0x182636E20", Slot = "4")]
		protected virtual void OnRead(IStreamReader from)
		{
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079E9")]
		[Address(RVA = "0x2636FB0", Offset = "0x2635BB0", VA = "0x182636FB0", Slot = "5")]
		protected virtual void OnWrite(IStreamWriter to)
		{
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079EA")]
		[Address(RVA = "0x26448E0", Offset = "0x26434E0", VA = "0x1826448E0", Slot = "6")]
		protected virtual void OnRecycle()
		{
		}

		// Token: 0x040077EC RID: 30700
		[Token(Token = "0x40077EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040077ED RID: 30701
		[Token(Token = "0x40077ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_id;

		// Token: 0x040077EE RID: 30702
		[Token(Token = "0x40077EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_id;

		// Token: 0x040077EF RID: 30703
		[Token(Token = "0x40077EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReadFrom;

		// Token: 0x040077F0 RID: 30704
		[Token(Token = "0x40077F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_WriteTo;

		// Token: 0x040077F1 RID: 30705
		[Token(Token = "0x40077F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x040077F2 RID: 30706
		[Token(Token = "0x40077F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRead;

		// Token: 0x040077F3 RID: 30707
		[Token(Token = "0x40077F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnWrite;

		// Token: 0x040077F4 RID: 30708
		[Token(Token = "0x40077F4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRecycle;
	}
}
