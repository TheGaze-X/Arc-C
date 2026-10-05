using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F6B RID: 8043
	[Token(Token = "0x2001F6B")]
	public class AVGShowItemCgSlot : AVGShowItemSlot
	{
		// Token: 0x0600C7D5 RID: 51157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7D5")]
		[Address(RVA = "0x348EBE0", Offset = "0x348D7E0", VA = "0x18348EBE0")]
		public void SetOverrideLayer(bool overrideLayer)
		{
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7D6")]
		[Address(RVA = "0x348ECA0", Offset = "0x348D8A0", VA = "0x18348ECA0", Slot = "4")]
		public override void Show(Command command, Sprite sprite, Action onShowEnd)
		{
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7D7")]
		[Address(RVA = "0x348E980", Offset = "0x348D580", VA = "0x18348E980", Slot = "5")]
		public override void Hide(Command command, Action onShowEnd)
		{
		}

		// Token: 0x0600C7D8 RID: 51160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7D8")]
		[Address(RVA = "0x348FCF0", Offset = "0x348E8F0", VA = "0x18348FCF0")]
		private void _OverrideLayer(int layer)
		{
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x00048C30 File Offset: 0x00046E30
		[Token(Token = "0x600C7D9")]
		[Address(RVA = "0x348FB60", Offset = "0x348E760", VA = "0x18348FB60")]
		private Vector3 _GenPosByRaw(string rawPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x00048C48 File Offset: 0x00046E48
		[Token(Token = "0x600C7DA")]
		[Address(RVA = "0x348FA30", Offset = "0x348E630", VA = "0x18348FA30")]
		private Color _GenColorByRaw(string rawColor)
		{
			return default(Color);
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7DB")]
		[Address(RVA = "0x348FC90", Offset = "0x348E890", VA = "0x18348FC90", Slot = "6")]
		protected override void _InitSlot()
		{
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7DC")]
		[Address(RVA = "0x348FDF0", Offset = "0x348E9F0", VA = "0x18348FDF0")]
		public AVGShowItemCgSlot()
		{
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7DD")]
		[Address(RVA = "0x348FA20", Offset = "0x348E620", VA = "0x18348FA20")]
		private void <>xLuaBaseProxy_Show(Command P0, Sprite P1, Action P2)
		{
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7DE")]
		[Address(RVA = "0x348FA10", Offset = "0x348E610", VA = "0x18348FA10")]
		private void <>xLuaBaseProxy_Hide(Command P0, Action P1)
		{
		}

		// Token: 0x0400CE10 RID: 52752
		[Token(Token = "0x400CE10")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _defaultFadeTime;

		// Token: 0x0400CE11 RID: 52753
		[Token(Token = "0x400CE11")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Canvas _canvas;

		// Token: 0x0400CE12 RID: 52754
		[Token(Token = "0x400CE12")]
		[FieldOffset(Offset = "0x50")]
		private bool m_overrideLayer;

		// Token: 0x0400CE13 RID: 52755
		[Token(Token = "0x400CE13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOverrideLayer;

		// Token: 0x0400CE14 RID: 52756
		[Token(Token = "0x400CE14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0400CE15 RID: 52757
		[Token(Token = "0x400CE15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0400CE16 RID: 52758
		[Token(Token = "0x400CE16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OverrideLayer;

		// Token: 0x0400CE17 RID: 52759
		[Token(Token = "0x400CE17")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenPosByRaw;

		// Token: 0x0400CE18 RID: 52760
		[Token(Token = "0x400CE18")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenColorByRaw;

		// Token: 0x0400CE19 RID: 52761
		[Token(Token = "0x400CE19")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitSlot;

		// Token: 0x0400CE1A RID: 52762
		[Token(Token = "0x400CE1A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
