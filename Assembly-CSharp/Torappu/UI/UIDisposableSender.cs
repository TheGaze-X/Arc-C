using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Network;

namespace Torappu.UI
{
	// Token: 0x020037F0 RID: 14320
	[Token(Token = "0x20037F0")]
	public class UIDisposableSender : IDisposable
	{
		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x06016B1B RID: 92955 RVA: 0x000926D0 File Offset: 0x000908D0
		// (set) Token: 0x06016B1C RID: 92956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003640")]
		public bool isDisposed
		{
			[Token(Token = "0x6016B1B")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016B1C")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06016B1D RID: 92957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016B1D")]
		public UISender.ResultHandler<ResType> SendRequest<ResType>(Request request) where ResType : class
		{
			return null;
		}

		// Token: 0x06016B1E RID: 92958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B1E")]
		[Address(RVA = "0xF12E00", Offset = "0xF11A00", VA = "0x180F12E00", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06016B1F RID: 92959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016B1F")]
		[Address(RVA = "0xF13090", Offset = "0xF11C90", VA = "0x180F13090")]
		public UIDisposableSender()
		{
		}

		// Token: 0x0401B5B4 RID: 112052
		[Token(Token = "0x401B5B4")]
		[FieldOffset(Offset = "0x10")]
		private ListSet<IDisposable> m_wrappedHandlers;

		// Token: 0x020037F1 RID: 14321
		[Token(Token = "0x20037F1")]
		private class ResultHandler<ResType> : UISender.ResultHandler<ResType>, IDisposable
		{
			// Token: 0x17003641 RID: 13889
			// (get) Token: 0x06016B20 RID: 92960 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016B21 RID: 92961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003641")]
			public Action innerFinal
			{
				[Token(Token = "0x6016B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016B21")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17003642 RID: 13890
			// (get) Token: 0x06016B22 RID: 92962 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016B23 RID: 92963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003642")]
			public Action onSystemCancel
			{
				[Token(Token = "0x6016B22")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6016B23")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06016B24 RID: 92964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B24")]
			public ResultHandler(Action onFail)
			{
			}

			// Token: 0x17003643 RID: 13891
			// (get) Token: 0x06016B25 RID: 92965 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06016B26 RID: 92966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17003643")]
			public override Action onFinal
			{
				[Token(Token = "0x6016B25")]
				get
				{
					return null;
				}
				[Token(Token = "0x6016B26")]
				set
				{
				}
			}

			// Token: 0x06016B27 RID: 92967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6016B27")]
			public override Action SystemCancelHandler()
			{
				return null;
			}

			// Token: 0x06016B28 RID: 92968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B28")]
			private void _OnFinal()
			{
			}

			// Token: 0x06016B29 RID: 92969 RVA: 0x000926E8 File Offset: 0x000908E8
			[Token(Token = "0x6016B29")]
			private static bool _DefaultOnBlock(ResponseError error)
			{
				return default(bool);
			}

			// Token: 0x06016B2A RID: 92970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016B2A")]
			public void Dispose()
			{
			}
		}
	}
}
