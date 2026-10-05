using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007160 RID: 29024
	[Token(Token = "0x2007160")]
	public class Act9D0CoinView : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06029363 RID: 168803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029363")]
		[Address(RVA = "0x24921A0", Offset = "0x2490DA0", VA = "0x1824921A0")]
		public void Init()
		{
		}

		// Token: 0x06029364 RID: 168804 RVA: 0x000D4C40 File Offset: 0x000D2E40
		[Token(Token = "0x6029364")]
		[Address(RVA = "0x2492030", Offset = "0x2490C30", VA = "0x182492030", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06029365 RID: 168805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029365")]
		[Address(RVA = "0x2492320", Offset = "0x2490F20", VA = "0x182492320", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06029366 RID: 168806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029366")]
		[Address(RVA = "0x2492380", Offset = "0x2490F80", VA = "0x182492380")]
		private void _TryUpdateCoin()
		{
		}

		// Token: 0x06029367 RID: 168807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029367")]
		[Address(RVA = "0x24922C0", Offset = "0x2490EC0", VA = "0x1824922C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06029368 RID: 168808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029368")]
		[Address(RVA = "0x2492260", Offset = "0x2490E60", VA = "0x182492260")]
		private void OnDisable()
		{
		}

		// Token: 0x06029369 RID: 168809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029369")]
		[Address(RVA = "0x2492200", Offset = "0x2490E00", VA = "0x182492200")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602936A RID: 168810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602936A")]
		[Address(RVA = "0x24924A0", Offset = "0x24910A0", VA = "0x1824924A0")]
		public Act9D0CoinView()
		{
		}

		// Token: 0x0403AD66 RID: 240998
		[Token(Token = "0x403AD66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x0403AD67 RID: 240999
		[Token(Token = "0x403AD67")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403AD68 RID: 241000
		[Token(Token = "0x403AD68")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403AD69 RID: 241001
		[Token(Token = "0x403AD69")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403AD6A RID: 241002
		[Token(Token = "0x403AD6A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdateCoin;

		// Token: 0x0403AD6B RID: 241003
		[Token(Token = "0x403AD6B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403AD6C RID: 241004
		[Token(Token = "0x403AD6C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403AD6D RID: 241005
		[Token(Token = "0x403AD6D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403AD6E RID: 241006
		[Token(Token = "0x403AD6E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
