using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	public class CriFsRequest : CriDisposable
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000069")]
		public CriFsRequest.DoneDelegate doneDelegate
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00003B54 File Offset: 0x00001D54
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006A")]
		public bool isDone
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006B")]
		public string error
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00003B6C File Offset: 0x00001D6C
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006C")]
		public bool isDisposed
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x36FA4B0", Offset = "0x36F90B0", VA = "0x1836FA4B0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void Stop()
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x36FA5E0", Offset = "0x36F91E0", VA = "0x1836FA5E0")]
		public YieldInstruction WaitForDone(MonoBehaviour mb)
		{
			return null;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void Update()
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x36FA530", Offset = "0x36F9130", VA = "0x1836FA530")]
		protected void Done()
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x36FA430", Offset = "0x36F9030", VA = "0x1836FA430")]
		private IEnumerator CheckDone()
		{
			return null;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x36FA550", Offset = "0x36F9150", VA = "0x1836FA550", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x36F3310", Offset = "0x36F1F10", VA = "0x1836F3310")]
		public CriFsRequest()
		{
		}

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000650 RID: 1616
		[Token(Token = "0x20000BE")]
		public delegate void DoneDelegate(CriFsRequest request);
	}
}
