using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BEA RID: 15338
	[Token(Token = "0x2003BEA")]
	public class UniEquipArchiveCharacterView : DataBinder<UniEquipArchiveCharacterProperty>
	{
		// Token: 0x06017FFF RID: 98303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FFF")]
		[Address(RVA = "0x1079260", Offset = "0x1077E60", VA = "0x181079260", Slot = "7")]
		public override void OnValueChanged(UniEquipArchiveCharacterProperty property)
		{
		}

		// Token: 0x06018000 RID: 98304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018000")]
		[Address(RVA = "0x10795D0", Offset = "0x10781D0", VA = "0x1810795D0")]
		public void ResetListToTop()
		{
		}

		// Token: 0x06018001 RID: 98305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018001")]
		[Address(RVA = "0x10796B0", Offset = "0x10782B0", VA = "0x1810796B0")]
		public UniEquipArchiveCharacterView()
		{
		}

		// Token: 0x0401D119 RID: 119065
		[Token(Token = "0x401D119")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UILayoutDimensionListener _dimensionListener;

		// Token: 0x0401D11A RID: 119066
		[Token(Token = "0x401D11A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UniEquipArchiveCharacterCardAdapter _adapter;

		// Token: 0x0401D11B RID: 119067
		[Token(Token = "0x401D11B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UniEquipArchiveCharacterSortView _sortView;

		// Token: 0x0401D11C RID: 119068
		[Token(Token = "0x401D11C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401D11D RID: 119069
		[Token(Token = "0x401D11D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401D11E RID: 119070
		[Token(Token = "0x401D11E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetListToTop;

		// Token: 0x0401D11F RID: 119071
		[Token(Token = "0x401D11F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003BEB RID: 15339
		[Token(Token = "0x2003BEB")]
		private class OnPostLayoutScrollVerticalAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06018002 RID: 98306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018002")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutScrollVerticalAction(UniEquipArchiveCharacterView closure)
			{
			}

			// Token: 0x06018003 RID: 98307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018003")]
			[Address(RVA = "0x10770F0", Offset = "0x1075CF0", VA = "0x1810770F0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401D120 RID: 119072
			[Token(Token = "0x401D120")]
			[FieldOffset(Offset = "0x10")]
			private UniEquipArchiveCharacterView m_closure;
		}
	}
}
