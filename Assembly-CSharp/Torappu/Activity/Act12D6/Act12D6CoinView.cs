using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AE0 RID: 31456
	[Token(Token = "0x2007AE0")]
	public class Act12D6CoinView : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0602C0E9 RID: 180457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0E9")]
		[Address(RVA = "0x27ECAA0", Offset = "0x27EB6A0", VA = "0x1827ECAA0")]
		public void Init()
		{
		}

		// Token: 0x0602C0EA RID: 180458 RVA: 0x000DDFD0 File Offset: 0x000DC1D0
		[Token(Token = "0x602C0EA")]
		[Address(RVA = "0x27EC920", Offset = "0x27EB520", VA = "0x1827EC920", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0602C0EB RID: 180459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0EB")]
		[Address(RVA = "0x27ECC20", Offset = "0x27EB820", VA = "0x1827ECC20", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0602C0EC RID: 180460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0EC")]
		[Address(RVA = "0x27ECC80", Offset = "0x27EB880", VA = "0x1827ECC80")]
		private void _TryUpdateCoin()
		{
		}

		// Token: 0x0602C0ED RID: 180461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0ED")]
		[Address(RVA = "0x27ECBC0", Offset = "0x27EB7C0", VA = "0x1827ECBC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602C0EE RID: 180462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0EE")]
		[Address(RVA = "0x27ECB60", Offset = "0x27EB760", VA = "0x1827ECB60")]
		private void OnDisable()
		{
		}

		// Token: 0x0602C0EF RID: 180463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0EF")]
		[Address(RVA = "0x27ECB00", Offset = "0x27EB700", VA = "0x1827ECB00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602C0F0 RID: 180464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0F0")]
		[Address(RVA = "0x27ECDC0", Offset = "0x27EB9C0", VA = "0x1827ECDC0")]
		public Act12D6CoinView()
		{
		}

		// Token: 0x0403FD39 RID: 261433
		[Token(Token = "0x403FD39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x0403FD3A RID: 261434
		[Token(Token = "0x403FD3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FD3B RID: 261435
		[Token(Token = "0x403FD3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403FD3C RID: 261436
		[Token(Token = "0x403FD3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403FD3D RID: 261437
		[Token(Token = "0x403FD3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdateCoin;

		// Token: 0x0403FD3E RID: 261438
		[Token(Token = "0x403FD3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403FD3F RID: 261439
		[Token(Token = "0x403FD3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403FD40 RID: 261440
		[Token(Token = "0x403FD40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403FD41 RID: 261441
		[Token(Token = "0x403FD41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
