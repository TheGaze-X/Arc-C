using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x020076A8 RID: 30376
	[Token(Token = "0x20076A8")]
	public class Act20sideVoteTrackPoint : ITrackPointModel, IHotfixable
	{
		// Token: 0x0602AB52 RID: 174930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB52")]
		[Address(RVA = "0x267C5D0", Offset = "0x267B1D0", VA = "0x18267C5D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x1700645A RID: 25690
		// (get) Token: 0x0602AB53 RID: 174931 RVA: 0x000D97E8 File Offset: 0x000D79E8
		[Token(Token = "0x1700645A")]
		public bool isShow
		{
			[Token(Token = "0x602AB53")]
			[Address(RVA = "0x267C720", Offset = "0x267B320", VA = "0x18267C720", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AB54 RID: 174932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AB54")]
		[Address(RVA = "0x267C6C0", Offset = "0x267B2C0", VA = "0x18267C6C0")]
		public Act20sideVoteTrackPoint()
		{
		}

		// Token: 0x0403D8B6 RID: 252086
		[Token(Token = "0x403D8B6")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0403D8B7 RID: 252087
		[Token(Token = "0x403D8B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0403D8B8 RID: 252088
		[Token(Token = "0x403D8B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0403D8B9 RID: 252089
		[Token(Token = "0x403D8B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
