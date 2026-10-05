using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEventInternal where T : PointerCaptureEventBase<T>, new()
	{
		// Token: 0x1700025C RID: 604
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025C")]
		private IEventHandler relatedTarget
		{
			[Token(Token = "0x6000AD3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00005D30 File Offset: 0x00003F30
		// (set) Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700025D")]
		public int pointerId
		{
			[Token(Token = "0x6000AD4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000AD5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD6")]
		protected override void Init()
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD7")]
		private void LocalInit()
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000AD8")]
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
		{
			return null;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		protected PointerCaptureEventBase()
		{
		}
	}
}
