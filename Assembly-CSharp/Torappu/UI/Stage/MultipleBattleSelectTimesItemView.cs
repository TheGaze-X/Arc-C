using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200691C RID: 26908
	[Token(Token = "0x200691C")]
	public class MultipleBattleSelectTimesItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060268BA RID: 157882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268BA")]
		[Address(RVA = "0x21950D0", Offset = "0x2193CD0", VA = "0x1821950D0")]
		public void Render(MultipleBattleSelectTimesItemView.RenderOptions renderOptions)
		{
		}

		// Token: 0x060268BB RID: 157883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268BB")]
		[Address(RVA = "0x2195060", Offset = "0x2193C60", VA = "0x182195060")]
		public void OnClick()
		{
		}

		// Token: 0x060268BC RID: 157884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60268BC")]
		[Address(RVA = "0x21952B0", Offset = "0x2193EB0", VA = "0x1821952B0")]
		public MultipleBattleSelectTimesItemView()
		{
		}

		// Token: 0x040365BF RID: 222655
		[Token(Token = "0x40365BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objSelected;

		// Token: 0x040365C0 RID: 222656
		[Token(Token = "0x40365C0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objNeedApItem;

		// Token: 0x040365C1 RID: 222657
		[Token(Token = "0x40365C1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _colorNeedBuyAp;

		// Token: 0x040365C2 RID: 222658
		[Token(Token = "0x40365C2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _colorNotNeedBuyAp;

		// Token: 0x040365C3 RID: 222659
		[Token(Token = "0x40365C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTimes;

		// Token: 0x040365C4 RID: 222660
		[Token(Token = "0x40365C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objSplit;

		// Token: 0x040365C5 RID: 222661
		[Token(Token = "0x40365C5")]
		[FieldOffset(Offset = "0x58")]
		private Action<int> m_actionClick;

		// Token: 0x040365C6 RID: 222662
		[Token(Token = "0x40365C6")]
		[FieldOffset(Offset = "0x60")]
		private int m_times;

		// Token: 0x040365C7 RID: 222663
		[Token(Token = "0x40365C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040365C8 RID: 222664
		[Token(Token = "0x40365C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040365C9 RID: 222665
		[Token(Token = "0x40365C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200691D RID: 26909
		[Token(Token = "0x200691D")]
		public enum ApStatus
		{
			// Token: 0x040365CB RID: 222667
			[Token(Token = "0x40365CB")]
			Enough,
			// Token: 0x040365CC RID: 222668
			[Token(Token = "0x40365CC")]
			NeedApItem,
			// Token: 0x040365CD RID: 222669
			[Token(Token = "0x40365CD")]
			NeedBuyAp
		}

		// Token: 0x0200691E RID: 26910
		[Token(Token = "0x200691E")]
		public struct RenderOptions
		{
			// Token: 0x040365CE RID: 222670
			[Token(Token = "0x40365CE")]
			[FieldOffset(Offset = "0x0")]
			public int times;

			// Token: 0x040365CF RID: 222671
			[Token(Token = "0x40365CF")]
			[FieldOffset(Offset = "0x4")]
			public MultipleBattleSelectTimesItemView.ApStatus apStatus;

			// Token: 0x040365D0 RID: 222672
			[Token(Token = "0x40365D0")]
			[FieldOffset(Offset = "0x8")]
			public bool isSelected;

			// Token: 0x040365D1 RID: 222673
			[Token(Token = "0x40365D1")]
			[FieldOffset(Offset = "0x10")]
			public Action<int> actionClick;
		}
	}
}
