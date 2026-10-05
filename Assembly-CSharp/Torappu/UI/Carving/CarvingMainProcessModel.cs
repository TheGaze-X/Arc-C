using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006040 RID: 24640
	[Token(Token = "0x2006040")]
	public class CarvingMainProcessModel : IHotfixable
	{
		// Token: 0x1700541E RID: 21534
		// (get) Token: 0x06023A1E RID: 145950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700541E")]
		public CarvingMainProcessFrameModel curFrame
		{
			[Token(Token = "0x6023A1E")]
			[Address(RVA = "0x1E4E850", Offset = "0x1E4D450", VA = "0x181E4E850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700541F RID: 21535
		// (get) Token: 0x06023A1F RID: 145951 RVA: 0x000C1680 File Offset: 0x000BF880
		[Token(Token = "0x1700541F")]
		public int curBounce
		{
			[Token(Token = "0x6023A1F")]
			[Address(RVA = "0x1E4E7E0", Offset = "0x1E4D3E0", VA = "0x181E4E7E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06023A20 RID: 145952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A20")]
		[Address(RVA = "0x1E4E2F0", Offset = "0x1E4CEF0", VA = "0x181E4E2F0")]
		public void LoadProcessFrame(int beforeScore, Act35SideData actData, List<CarvingProcessFrame> frames)
		{
		}

		// Token: 0x06023A21 RID: 145953 RVA: 0x000C1698 File Offset: 0x000BF898
		[Token(Token = "0x6023A21")]
		[Address(RVA = "0x1E4E6A0", Offset = "0x1E4D2A0", VA = "0x181E4E6A0")]
		public bool TryNextFrame()
		{
			return default(bool);
		}

		// Token: 0x06023A22 RID: 145954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A22")]
		[Address(RVA = "0x1E4E730", Offset = "0x1E4D330", VA = "0x181E4E730")]
		public CarvingMainProcessModel()
		{
		}

		// Token: 0x04031577 RID: 202103
		[Token(Token = "0x4031577")]
		[FieldOffset(Offset = "0x10")]
		public List<CarvingMainProcessFrameModel> frameList;

		// Token: 0x04031578 RID: 202104
		[Token(Token = "0x4031578")]
		[FieldOffset(Offset = "0x18")]
		public int frameSeq;

		// Token: 0x04031579 RID: 202105
		[Token(Token = "0x4031579")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curFrame;

		// Token: 0x0403157A RID: 202106
		[Token(Token = "0x403157A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_curBounce;

		// Token: 0x0403157B RID: 202107
		[Token(Token = "0x403157B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadProcessFrame;

		// Token: 0x0403157C RID: 202108
		[Token(Token = "0x403157C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryNextFrame;

		// Token: 0x0403157D RID: 202109
		[Token(Token = "0x403157D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
