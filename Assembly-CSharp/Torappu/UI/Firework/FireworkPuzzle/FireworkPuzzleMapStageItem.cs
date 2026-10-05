using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Firework.FireworkPuzzle
{
	// Token: 0x02004E5E RID: 20062
	[Token(Token = "0x2004E5E")]
	public class FireworkPuzzleMapStageItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601DF02 RID: 122626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF02")]
		[Address(RVA = "0x17A98A0", Offset = "0x17A84A0", VA = "0x1817A98A0")]
		public void Render(FireworkPuzzleItemModel model)
		{
		}

		// Token: 0x0601DF03 RID: 122627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF03")]
		[Address(RVA = "0x17A97C0", Offset = "0x17A83C0", VA = "0x1817A97C0")]
		public void OnClick()
		{
		}

		// Token: 0x0601DF04 RID: 122628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DF04")]
		[Address(RVA = "0x17A99A0", Offset = "0x17A85A0", VA = "0x1817A99A0")]
		public FireworkPuzzleMapStageItem()
		{
		}

		// Token: 0x04027BE8 RID: 162792
		[Token(Token = "0x4027BE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnLocked;

		// Token: 0x04027BE9 RID: 162793
		[Token(Token = "0x4027BE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnUnlock;

		// Token: 0x04027BEA RID: 162794
		[Token(Token = "0x4027BEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Button")]
		private GameObject _panelBtnComplete;

		// Token: 0x04027BEB RID: 162795
		[Token(Token = "0x4027BEB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTomorrowUnlock;

		// Token: 0x04027BEC RID: 162796
		[Token(Token = "0x4027BEC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _tomorrowUnlockDesc;

		// Token: 0x04027BED RID: 162797
		[Token(Token = "0x4027BED")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027BEE RID: 162798
		[Token(Token = "0x4027BEE")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedPuzzleId;

		// Token: 0x04027BEF RID: 162799
		[Token(Token = "0x4027BEF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04027BF0 RID: 162800
		[Token(Token = "0x4027BF0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04027BF1 RID: 162801
		[Token(Token = "0x4027BF1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
