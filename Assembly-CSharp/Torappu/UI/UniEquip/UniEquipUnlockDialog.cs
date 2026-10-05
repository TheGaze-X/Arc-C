using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C4C RID: 15436
	[Token(Token = "0x2003C4C")]
	public class UniEquipUnlockDialog : UICompDialog<UniEquipUnlockDialog.Input>
	{
		// Token: 0x0601820B RID: 98827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601820B")]
		[Address(RVA = "0x109E160", Offset = "0x109CD60", VA = "0x18109E160", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601820C RID: 98828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601820C")]
		[Address(RVA = "0x109E260", Offset = "0x109CE60", VA = "0x18109E260", Slot = "18")]
		protected override void OnRender(UniEquipUnlockDialog.Input input)
		{
		}

		// Token: 0x0601820D RID: 98829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601820D")]
		[Address(RVA = "0x109E0A0", Offset = "0x109CCA0", VA = "0x18109E0A0")]
		public void OnConfirm()
		{
		}

		// Token: 0x0601820E RID: 98830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601820E")]
		[Address(RVA = "0x109E560", Offset = "0x109D160", VA = "0x18109E560")]
		public UniEquipUnlockDialog()
		{
		}

		// Token: 0x06018210 RID: 98832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018210")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401D52F RID: 120111
		[Token(Token = "0x401D52F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UniEquipShowView _showViewPrefab;

		// Token: 0x0401D530 RID: 120112
		[Token(Token = "0x401D530")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401D531 RID: 120113
		[Token(Token = "0x401D531")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0401D532 RID: 120114
		[Token(Token = "0x401D532")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_clickDelayTween;

		// Token: 0x0401D533 RID: 120115
		[Token(Token = "0x401D533")]
		[FieldOffset(Offset = "0x90")]
		private UniEquipShowView m_uniEquipShowView;

		// Token: 0x0401D534 RID: 120116
		[Token(Token = "0x401D534")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401D535 RID: 120117
		[Token(Token = "0x401D535")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401D536 RID: 120118
		[Token(Token = "0x401D536")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirm;

		// Token: 0x0401D537 RID: 120119
		[Token(Token = "0x401D537")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C4D RID: 15437
		[Token(Token = "0x2003C4D")]
		public class Input
		{
			// Token: 0x06018211 RID: 98833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018211")]
			[Address(RVA = "0x108E630", Offset = "0x108D230", VA = "0x18108E630")]
			public Input()
			{
			}

			// Token: 0x0401D538 RID: 120120
			[Token(Token = "0x401D538")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipData uniEquipData;

			// Token: 0x0401D539 RID: 120121
			[Token(Token = "0x401D539")]
			[FieldOffset(Offset = "0x18")]
			public string subProfessionId;

			// Token: 0x0401D53A RID: 120122
			[Token(Token = "0x401D53A")]
			[FieldOffset(Offset = "0x20")]
			public float clickDelay;
		}
	}
}
