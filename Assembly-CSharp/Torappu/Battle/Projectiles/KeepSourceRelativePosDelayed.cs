using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029DE RID: 10718
	[Token(Token = "0x20029DE")]
	public class KeepSourceRelativePosDelayed : HarpoonMovement
	{
		// Token: 0x06011C53 RID: 72787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C53")]
		[Address(RVA = "0x99D600", Offset = "0x99C200", VA = "0x18099D600", Slot = "17")]
		protected override void OnInit(ILocatable start, ILocatable target)
		{
		}

		// Token: 0x06011C54 RID: 72788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C54")]
		[Address(RVA = "0x99D760", Offset = "0x99C360", VA = "0x18099D760", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C55 RID: 72789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C55")]
		[Address(RVA = "0x99DAB0", Offset = "0x99C6B0", VA = "0x18099DAB0")]
		public KeepSourceRelativePosDelayed()
		{
		}

		// Token: 0x06011C56 RID: 72790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C56")]
		[Address(RVA = "0x99DA90", Offset = "0x99C690", VA = "0x18099DA90")]
		private void <>xLuaBaseProxy_OnInit(ILocatable P0, ILocatable P1)
		{
		}

		// Token: 0x06011C57 RID: 72791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C57")]
		[Address(RVA = "0x99DAA0", Offset = "0x99C6A0", VA = "0x18099DAA0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013F12 RID: 81682
		[Token(Token = "0x4013F12")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _delayKey;

		// Token: 0x04013F13 RID: 81683
		[Token(Token = "0x4013F13")]
		[FieldOffset(Offset = "0xC8")]
		private FP m_delayTime;

		// Token: 0x04013F14 RID: 81684
		[Token(Token = "0x4013F14")]
		[FieldOffset(Offset = "0xD0")]
		private Vector2 m_relativePos;

		// Token: 0x04013F15 RID: 81685
		[Token(Token = "0x4013F15")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04013F16 RID: 81686
		[Token(Token = "0x4013F16")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F17 RID: 81687
		[Token(Token = "0x4013F17")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
