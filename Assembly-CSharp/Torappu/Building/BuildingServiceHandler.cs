using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building
{
	// Token: 0x02001811 RID: 6161
	[Token(Token = "0x2001811")]
	public class BuildingServiceHandler<ResType> : UISender.ResultHandler<ResType>
	{
		// Token: 0x06009BF2 RID: 39922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BF2")]
		public BuildingServiceHandler(Action<ResType> internalProceed, [Optional] Action internalFinal)
		{
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06009BF3 RID: 39923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009BF4 RID: 39924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700112D")]
		public override Action<ResType> onProceed
		{
			[Token(Token = "0x6009BF3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009BF4")]
			set
			{
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06009BF5 RID: 39925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009BF6 RID: 39926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700112E")]
		public override Action onFinal
		{
			[Token(Token = "0x6009BF5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6009BF6")]
			set
			{
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06009BF7 RID: 39927 RVA: 0x0003CBD0 File Offset: 0x0003ADD0
		// (set) Token: 0x06009BF8 RID: 39928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700112F")]
		public bool broadcastChange
		{
			[Token(Token = "0x6009BF7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6009BF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06009BF9 RID: 39929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BF9")]
		private void _OnProceed(ResType resType)
		{
		}

		// Token: 0x06009BFA RID: 39930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BFA")]
		private void _OnFinal()
		{
		}

		// Token: 0x040092A3 RID: 37539
		[Token(Token = "0x40092A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<ResType> m_internalProceed;

		// Token: 0x040092A4 RID: 37540
		[Token(Token = "0x40092A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_internalFinal;
	}
}
