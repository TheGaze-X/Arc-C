using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003683 RID: 13955
	[Token(Token = "0x2003683")]
	public struct TransActionListener
	{
		// Token: 0x0601633C RID: 90940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601633C")]
		[Address(RVA = "0xE9D560", Offset = "0xE9C160", VA = "0x180E9D560")]
		public TransActionListener(Action listener)
		{
		}

		// Token: 0x0601633D RID: 90941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601633D")]
		[Address(RVA = "0xE9D4C0", Offset = "0xE9C0C0", VA = "0x180E9D4C0")]
		public void Invoke()
		{
		}

		// Token: 0x0401AAEC RID: 109292
		[Token(Token = "0x401AAEC")]
		[FieldOffset(Offset = "0x0")]
		private static uint s_callbackCtr;

		// Token: 0x0401AAED RID: 109293
		[Token(Token = "0x401AAED")]
		[FieldOffset(Offset = "0x0")]
		private TransActionListener.CallbackInst m_callback;

		// Token: 0x0401AAEE RID: 109294
		[Token(Token = "0x401AAEE")]
		[FieldOffset(Offset = "0x8")]
		private uint m_currentId;

		// Token: 0x02003684 RID: 13956
		[Token(Token = "0x2003684")]
		public class CallbackInst : IPtrObject
		{
			// Token: 0x1700355D RID: 13661
			// (get) Token: 0x0601633E RID: 90942 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601633F RID: 90943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700355D")]
			public Action listener
			{
				[Token(Token = "0x601633E")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601633F")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700355E RID: 13662
			// (get) Token: 0x06016340 RID: 90944 RVA: 0x0008FF70 File Offset: 0x0008E170
			// (set) Token: 0x06016341 RID: 90945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700355E")]
			public uint instanceUid
			{
				[Token(Token = "0x6016340")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6016341")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06016342 RID: 90946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016342")]
			[Address(RVA = "0xE8EC70", Offset = "0xE8D870", VA = "0x180E8EC70")]
			public void Reset(Action listener, uint id)
			{
			}

			// Token: 0x06016343 RID: 90947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016343")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CallbackInst()
			{
			}
		}
	}
}
